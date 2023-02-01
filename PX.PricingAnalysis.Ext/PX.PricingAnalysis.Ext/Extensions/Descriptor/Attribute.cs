using System;
using System.Collections.Generic;
using PX.Data;
using PX.Objects.AR;
using PX.Objects.CM;
using PX.Objects.FS;
using PX.Objects.IN;
using PX.Objects.SO;

namespace PX.PricingAnalysis.Ext
{
	public class ProfitLineType
	{
		public class ListAttribute : PXStringListAttribute
		{
			public ListAttribute() : base(
				new[]
				{
					Pair(CurrentLineType, Messages.CurrentLineType),
					Pair(PreviewLineType, Messages.PreviewLineType)
				})
			{ }
		}
		
		public const string CurrentLineType = "C";
		public const string PreviewLineType = "P";

		public class currentLine : PX.Data.BQL.BqlString.Constant<currentLine>
		{
			public currentLine() : base(CurrentLineType) { }
		}
		public class document : PX.Data.BQL.BqlString.Constant<document>
		{
			public document() : base(PreviewLineType) { }
		}
	}
	
	public class BreakupBy
	{
		public class ListAttribute : PXStringListAttribute
		{
			public ListAttribute() : base(
				new[]
				{
					Pair(Margin, Messages.Margin),
					Pair(Markup, Messages.Markup)
				})
			{ }
		}

		public const string Margin = "MG";
		public const string Markup = "MU";

		public class margin : PX.Data.BQL.BqlString.Constant<margin>
		{
			public margin() : base(Margin) { }
		}
		public class markup : PX.Data.BQL.BqlString.Constant<markup>
		{
			public markup() : base(Markup) { }
		}
	}

	public class PAUnitCostValueAttribute<InventoryID, SiteID> : BqlFormulaEvaluator<InventoryID, SiteID>
				where InventoryID : IBqlOperand
				where SiteID : IBqlOperand
	{
		public override object Evaluate(PXCache cache, object item, Dictionary<Type, object> pars)
		{
			int? inventoryID = (int?)pars[typeof(InventoryID)];
			int? siteID = (int?)pars[typeof(SiteID)];

			decimal dValue = 0m;
			if (inventoryID.HasValue && siteID.HasValue)
			{
				INItemSite data = PXSelect<INItemSite, Where<INItemSite.inventoryID, Equal<Required<INItemSite.inventoryID>>,
														And<INItemSite.siteID, Equal<Required<INItemSite.siteID>>>>>
														.SelectWindowed(cache.Graph, 0, 1, inventoryID, siteID);

				PXCurrencyAttribute.CuryConvCury(cache, item, data?.TranUnitCost ?? 0m, out dValue);
			}
			return dValue;
		}
	}

	public class PALineCostValueExtAttribute<InventoryID, SiteID, LineCost, Quantity, LineOUnitCost> : BqlFormulaEvaluator<InventoryID, SiteID, LineCost, Quantity, LineOUnitCost>
				where InventoryID : IBqlOperand
				where SiteID : IBqlOperand
				where LineCost : IBqlOperand
				where Quantity : IBqlOperand
				where LineOUnitCost : IBqlOperand
	{

		public override object Evaluate(PXCache cache, object item, Dictionary<Type, object> pars)
		{
			int? inventoryID = (int?)pars[typeof(InventoryID)];
			int? siteID = (int?)pars[typeof(SiteID)];
			decimal? CostExt = (decimal?)pars[typeof(LineCost)];
			decimal? quantity = (decimal?)pars[typeof(Quantity)];

			decimal dValue = 0m;
			decimal? dValueCaled = 0m;

			if (!inventoryID.HasValue || !siteID.HasValue) { return dValue; }
			InventoryItem itemData = InventoryItem.PK.Find(cache.Graph, inventoryID);
			InventoryItemPricingAnalysisExt itemDataExt = PXCache<InventoryItem>.GetExtension<InventoryItemPricingAnalysisExt>(itemData);
			bool? bIsSpecialOrderItem = (bool?)cache.Graph.Caches[typeof(InventoryItem)]?.GetValue(itemData, "UsrIsSpecialOrderItem");

			if (bIsSpecialOrderItem.GetValueOrDefault(false))
            {
				dValueCaled = CostExt ?? 0m;
			}
			else if (itemData.StkItem.GetValueOrDefault(false))
			{
				if ((itemDataExt.UsrLotSerTrack == INLotSerTrack.SerialNumbered ||
					itemDataExt.UsrLotSerTrack == INLotSerTrack.LotNumbered) && itemData.ValMethod == INValMethod.Specific)
				{
					if (item is SOLine)
					{
						decimal? qtyRemaining = quantity;
						foreach (SOLineSplit split in PXSelect<SOLineSplit, Where<SOLineSplit.lineNbr, Equal<Current<SOLine.lineNbr>>,
																				And<SOLineSplit.orderType, Equal<Current<SOLine.orderType>>,
																				And<SOLineSplit.orderNbr, Equal<Current<SOLine.orderNbr>>>>>>.
															SelectMultiBound(cache.Graph, new object[] { item }))
						{
							qtyRemaining -= split.Qty;
							if (split.IsAllocated.GetValueOrDefault(false) && !String.IsNullOrEmpty(split.LotSerialNbr))
							{

								dValueCaled += GetLotSerialActualCost(cache, split.InventoryID, split.SiteID, split.LotSerialNbr, split.Qty);
							}
							else
							{
								dValueCaled += GetValuationBasedCost(cache, split.InventoryID, split.SiteID, split.Qty, true);
							}
						}
						if (qtyRemaining != quantity)
                        {
							dValueCaled += GetValuationBasedCost(cache, inventoryID, siteID, qtyRemaining, true);
						}
					}
					else if (item is FSSODet)
					{
						decimal? qtyRemaining = quantity;
						foreach (FSSODetSplit split in PXSelect<FSSODetSplit, Where<FSSODetSplit.srvOrdType, Equal<Current<FSSODet.srvOrdType>>,
																				And<FSSODetSplit.refNbr, Equal<Current<FSSODet.refNbr>>,
																				And<FSSODetSplit.lineNbr, Equal<Current<FSSODet.lineNbr>>>>>>.
															SelectMultiBound(cache.Graph, new object[] { item }))
                        {
							qtyRemaining -= split.Qty;
							if (split.IsAllocated.GetValueOrDefault(false) && !String.IsNullOrEmpty(split.LotSerialNbr))
							{

								dValueCaled += GetLotSerialActualCost(cache, split.InventoryID, split.SiteID, split.LotSerialNbr, split.Qty);
							}
							else
							{
								dValueCaled += GetValuationBasedCost(cache, split.InventoryID, split.SiteID, split.Qty, true);
							}
						}
						if (qtyRemaining != quantity)
						{
							dValueCaled += GetValuationBasedCost(cache, inventoryID, siteID, qtyRemaining, true);
						}
					}
					else
					{
						dValueCaled = GetValuationBasedCost(cache, inventoryID, siteID, quantity, true);
					}
				}
				else
				{
					if (item is SOLine)
					{
						decimal? qtyRemaining = quantity;
						foreach (INTran intran in PXSelect<INTran, Where<INTran.sOOrderLineNbr, Equal<Current<SOLine.lineNbr>>,
																				And<INTran.sOOrderType, Equal<Current<SOLine.orderType>>,
																				And<INTran.sOOrderNbr, Equal<Current<SOLine.orderNbr>>>>>>.
															SelectMultiBound(cache.Graph, new object[] { item }))
						{
							qtyRemaining -= intran.Qty;
							dValueCaled += intran.TranCost;
						}
						dValueCaled += GetValuationBasedCost(cache, inventoryID, siteID, qtyRemaining);
					}
					else if (item is FSSODet)
					{
						decimal? qtyRemaining = quantity;
						foreach (INTran intran in PXSelectJoin<INTran, InnerJoin<ARTran, On<ARTran.lineNbr, Equal<INTran.aRLineNbr>,
																							And<ARTran.tranType, Equal<INTran.aRDocType>,
																							And<ARTran.refNbr, Equal<INTran.aRRefNbr>>>>,
																	   InnerJoin<FSARTran, On< FSARTran.lineNbr, Equal<ARTran.lineNbr>,
																							And< FSARTran.tranType, Equal<ARTran.tranType>,
																							And<FSARTran.refNbr, Equal< ARTran.refNbr>>>>>>,
																	   Where<FSARTran.srvOrdType, Equal<Current<FSSODet.srvOrdType>>,
																				And<FSARTran.serviceOrderRefNbr, Equal<Current<FSSODet.refNbr>>,
																				And <FSARTran.serviceOrderLineNbr, Equal<Current<FSSODet.lineNbr>>>>>>.
																	   SelectMultiBound(cache.Graph, new object[] { item }))
						{
							qtyRemaining -= intran.Qty;
							dValueCaled += intran.TranCost;
						}
						dValueCaled += GetValuationBasedCost(cache, inventoryID, siteID, qtyRemaining);
					}
					else if (item is FSAppointmentDet)
					{
						decimal? qtyRemaining = quantity;
						foreach (INTran intran in PXSelectJoin<INTran, InnerJoin<ARTran, On<ARTran.lineNbr, Equal<INTran.aRLineNbr>,
																							And<ARTran.tranType, Equal<INTran.aRDocType>,
																							And<ARTran.refNbr, Equal<INTran.aRRefNbr>>>>,
																	   InnerJoin<FSARTran, On<FSARTran.lineNbr, Equal<ARTran.lineNbr>,
																							And<FSARTran.tranType, Equal<ARTran.tranType>,
																							And<FSARTran.refNbr, Equal<ARTran.refNbr>>>>>>,
																Where<FSARTran.srvOrdType, Equal<Current<FSAppointmentDet.srvOrdType>>,
																		And<FSARTran.appointmentRefNbr, Equal<Current<FSAppointmentDet.refNbr>>,
																		And<FSARTran.appointmentLineNbr, Equal<Current<FSAppointmentDet.lineNbr>>>>>>.
															SelectMultiBound(cache.Graph, new object[] { item }))
						{
							qtyRemaining -= intran.Qty;
							dValueCaled += intran.TranCost;
						}
						dValueCaled += GetValuationBasedCost(cache, inventoryID, siteID, qtyRemaining);
					}
					else
					{
						dValueCaled = GetValuationBasedCost(cache, inventoryID, siteID, quantity);
					}
				}
			}
			else
			{
				if (CostExt.GetValueOrDefault(0) <= 0) { CostExt = (itemData.StdCost ?? 0m) * (quantity ?? 0m); }
				dValueCaled = CostExt ?? 0m;
			}
			if (dValueCaled.GetValueOrDefault(0) <=0)
            {
				dValueCaled = GetLastCost(cache, inventoryID, quantity);
			}

			PXCurrencyAttribute.CuryConvCury(cache, item, (dValueCaled ?? 0m), out dValue);

            PXTrace.WriteInformation(dValue.ToString());
			return dValue;
		}

		private decimal? GetLotSerialActualCost(PXCache cache, int? inventoryID, int? siteID, string lotserialNbr, decimal? qty)
        {
			decimal? dReturnValue = 0m;
			INCostStatus status = PXSelect<INCostStatus, Where<INCostStatus.inventoryID, Equal<Required<INCostStatus.inventoryID>>,
															And<INCostStatus.siteID, Equal<Required<INCostStatus.siteID>>,
															And<INCostStatus.lotSerialNbr, Equal<Required<INCostStatus.lotSerialNbr>>>>>>.
															SelectWindowed(cache.Graph, 0, 1, inventoryID, siteID, lotserialNbr);
			if (status != null && status.QtyOnHand != 0m)
			{
				dReturnValue = PXDBPriceCostAttribute.Round((decimal)(status.TotalCost / status.QtyOnHand)) * qty;
			}
			return dReturnValue;
		}

		private decimal? GetValuationBasedCost(PXCache cache, int? inventoryID, int? siteID, decimal? qty, bool bUseAvg = false)
		{
			INItemSite data = PXSelect<INItemSite, Where<INItemSite.inventoryID, Equal<Required<INItemSite.inventoryID>>,
													And<INItemSite.siteID, Equal<Required<INItemSite.siteID>>>>>
													.SelectWindowed(cache.Graph, 0, 1, inventoryID, siteID);

			if (!bUseAvg)
			{
				decimal? dValuedCost = (qty.GetValueOrDefault(0)) * (data?.TranUnitCost ?? 0m);
				return dValuedCost.GetValueOrDefault(0) > 0 ? dValuedCost : GetLastCost(cache, inventoryID, qty);
			}
			else
            {
				decimal? dValuedCost = (qty.GetValueOrDefault(0)) * (data?.AvgCost ?? 0m);
				return dValuedCost.GetValueOrDefault(0) > 0 ? dValuedCost : GetLastCost(cache, inventoryID, qty);
			}
		}

		private decimal? GetLastCost(PXCache cache, int? inventoryID, decimal? qty)
        {
			INItemCost data = INItemCost.PK.Find(cache.Graph, inventoryID, cache.Graph.Accessinfo.BaseCuryID);
			return (qty.GetValueOrDefault(0)) * (data?.LastCost ?? 0m);
		}
	}

	public class AdjustmentType
	{
		public class ListAttribute : PXStringListAttribute
		{
			public ListAttribute() : base(
				new[]
				{
					Pair(Price, Messages.PriceAdjustmentType),
					Pair(Discount, Messages.DiscountAdjustmentType)
				})
			{ }
		}

		public const string Price = "P";
		public const string Discount = "D";

		public class priceadjustment : PX.Data.BQL.BqlString.Constant<priceadjustment>
		{
			public priceadjustment() : base(Price) { }
		}
		public class discountadjustment : PX.Data.BQL.BqlString.Constant<discountadjustment>
		{
			public discountadjustment() : base(Discount) { }
		}
	}

	public class HeaderInfoTypes
	{
		public class ListAttribute : PXStringListAttribute
		{
			public ListAttribute() : base(
				new[]
				{
					Pair(Current, Messages.CurrentHeaderInfoType),
					Pair(Preview, Messages.PreviewHeaderInfoType)
				})
			{ }
		}

		public const string Current = "CU";
		public const string Preview = "PR";

		public class currentHeader : PX.Data.BQL.BqlString.Constant<currentHeader>
		{
			public currentHeader() : base(Current) { }
		}
		public class previewHeader : PX.Data.BQL.BqlString.Constant<previewHeader>
		{
			public previewHeader() : base(Preview) { }
		}
	}

	[Obsolete("Later removal")]
	public class BreakupType
	{
		public class ListAttribute : PXStringListAttribute
		{
			public ListAttribute() : base(
				new[]
				{
					Pair(CurrentLine, Messages.CurrentLine),
					Pair(Document, Messages.Document)
				})
			{ }
		}

		public const string CurrentLine = "L";
		public const string Document = "D";

		public class currentLine : PX.Data.BQL.BqlString.Constant<currentLine>
		{
			public currentLine() : base(CurrentLine) { }
		}
		public class document : PX.Data.BQL.BqlString.Constant<document>
		{
			public document() : base(Document) { }
		}
	}
}