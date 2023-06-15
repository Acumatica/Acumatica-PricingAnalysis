using System;
using PX.Data;
using PX.Data.BQL;
using PX.Objects.CS;
using PX.Objects.IN;

namespace PX.PricingAnalysis.Ext
{
    public sealed class INComponentTranPricingAnalysisExt : PXCacheExtension<INComponentTran>
    {
		#region UsrUnitPrice
		public abstract class usrUnitPrice : PX.Data.BQL.BqlDecimal.Field<usrUnitPrice> { }

		[PXPriceCost()]
		[PXUnboundDefault(TypeCode.Decimal, "0.0", typeof(Search<InventoryItemCurySettings.basePrice, Where<InventoryItemCurySettings.inventoryID, Equal<Current<INComponentTran.inventoryID>>, And<InventoryItemCurySettings.curyID, Equal<Current<AccessInfo.baseCuryID>>>>>))]
		[PXUIField(DisplayName = "Unit Price", Enabled = false)]
		public Decimal? UsrUnitPrice { get; set; }
		#endregion

		#region UsrAmount
		public abstract class usrAmount : PX.Data.BQL.BqlDecimal.Field<usrAmount> { }

		[PXPriceCost()]
		[PXUnboundDefault(TypeCode.Decimal, "0.00")]
		[PXFormula(typeof(Mult<usrUnitPrice, INComponentTran.qty>))]
		[PXUIField(DisplayName = "Amount", Enabled = false)]
		public Decimal? UsrAmount { get; set; }
		#endregion

		#region UsrCostAmount
		public abstract class usrCostAmount : PX.Data.BQL.BqlDecimal.Field<usrCostAmount> { }

		[PXPriceCost()]
		[PXUnboundDefault(TypeCode.Decimal, "0.00")]
		[PXUIField(DisplayName = "Cost Amount", Enabled = false)]
		public Decimal? UsrCostAmount { get; set; }
		#endregion

		#region UsrUnitCost
		public abstract class usrUnitCost : PX.Data.BQL.BqlDecimal.Field<usrUnitCost> { }

		[PXPriceCost()]
		[PXUnboundDefault(TypeCode.Decimal, "0.00")]
		[PXFormula(typeof(IIf<INComponentTran.qty.IsEqual<decimal0>, decimal0, Div<usrCostAmount, INComponentTran.qty>>))]
		[PXUIField(DisplayName = "Current Unit Cost", Enabled = false)]
		public Decimal? UsrUnitCost { get; set; }
		#endregion

		#region UsrProfitAmount
		public abstract class usrProfitAmount : PX.Data.BQL.BqlDecimal.Field<usrProfitAmount> { }

		[PXPriceCost()]
		[PXUnboundDefault(TypeCode.Decimal, "0.00")]
		[PXFormula(typeof(Sub<usrAmount, usrCostAmount>))]
		[PXUIField(DisplayName = "Profit Amount", Enabled = false)]
		public Decimal? UsrProfitAmount { get; set; }
		#endregion

		#region UsrUnitProfitAmount
		public abstract class usrUnitProfitAmount : PX.Data.BQL.BqlDecimal.Field<usrUnitProfitAmount> { }

		[PXPriceCost()]
		[PXUnboundDefault(TypeCode.Decimal, "0.00")]
		[PXFormula(typeof(IIf<INComponentTran.qty.IsEqual<decimal0>, decimal0, Div<usrProfitAmount, INComponentTran.qty>>))]
		[PXUIField(DisplayName = "Unit Profit", Enabled = false)]
		public Decimal? UsrUnitProfitAmount { get; set; }
		#endregion

		

		#region UsrMarkup
		public abstract class usrMarkup : PX.Data.BQL.BqlDecimal.Field<usrMarkup> { }

		[PXDecimal(2)]
		[PXUnboundDefault(TypeCode.Decimal, "0.00")]
		[PXFormula(typeof(IIf<usrCostAmount.IsNotEqual<decimal0>, Mult<Div<usrProfitAmount, usrCostAmount>, decimal100>, decimal0>))]
		[PXUIField(DisplayName = "Markup %", Enabled = false)]
		public Decimal? UsrMarkup { get; set; }
		#endregion

		#region UsrMargin
		public abstract class usrMargin : PX.Data.BQL.BqlDecimal.Field<usrMargin> { }

		[PXDecimal(2)]
		[PXFormula(typeof(IIf<usrAmount.IsNotEqual<decimal0>, Mult<Div<usrProfitAmount, usrAmount>, decimal100>, decimal0>))]
		[PXUIField(DisplayName = "Margin %", Enabled = false)]
		public Decimal? UsrMargin { get; set; }
		#endregion

		#region UsrQtyOnHand
		public abstract class usrQtyOnHand : BqlDecimal.Field<usrQtyOnHand> { }

		[PXUIField(DisplayName = "Qty. On Hand", Enabled = false)]
		[PXDecimal(2)]
		[PXUnboundDefault(TypeCode.Decimal, "0.0")]
		public Decimal? UsrQtyOnHand { get; set; }
		#endregion

		#region UsrQtyAvailable
		public abstract class usrQtyAvailable : BqlDecimal.Field<usrQtyAvailable> { }

		[PXUIField(DisplayName = "Qty. Available", Enabled = false)]
		[PXDecimal(2)]
		[PXUnboundDefault(TypeCode.Decimal, "0.0")]
		public Decimal? UsrQtyAvailable { get; set; }
		#endregion

		#region UsrQtyWarehouseAvailable
		public abstract class usrQtyWarehouseAvailable : BqlDecimal.Field<usrQtyWarehouseAvailable> { }

		[PXDecimal(2)]
		[PXUnboundDefault(TypeCode.Decimal, "0.0")]
		public Decimal? UsrQtyWarehouseAvailable { get; set; }
		#endregion
	}
}