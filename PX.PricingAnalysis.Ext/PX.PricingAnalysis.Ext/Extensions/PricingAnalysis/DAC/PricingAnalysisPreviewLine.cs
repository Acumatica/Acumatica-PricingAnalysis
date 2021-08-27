using System;
using PX.Data;
using PX.Objects.CS;
using PX.Objects.IN;

namespace PX.PricingAnalysis.Ext
{
    [Serializable]
    [PXHidden]
    public class PricingAnalysisPreviewLine : IBqlTable
	{
		#region RecordID
		public abstract class recordID : PX.Data.BQL.BqlInt.Field<recordID> { }
		[PXInt(IsKey = true)]
		public virtual int? RecordID { get; set; }
		#endregion

		#region LineNbr
		public abstract class lineNbr : PX.Data.BQL.BqlInt.Field<lineNbr> { }
		[PXInt]
		[PXUIField(DisplayName = "Line Nbr.", Visible = false, Enabled = false)]
		public virtual Int32? LineNbr { get; set; }
		#endregion

		#region InventoryID
		public abstract class inventoryID : PX.Data.BQL.BqlInt.Field<inventoryID> { }
		public virtual Int32? InventoryID { get; set; }
		#endregion

		#region IsFreightLine
		public abstract class isFreightLine : PX.Data.BQL.BqlBool.Field<isFreightLine> { }
		[PXBool]
		public virtual bool? IsFreightLine { get; set; }
		#endregion

		#region EnableLinePriceAnalysis
		public abstract class enablePriceAnalysisByLine : PX.Data.BQL.BqlBool.Field<enablePriceAnalysisByLine> { }
		[PXBool]
		[PXUIField]
		[PXUnboundDefault(true)]
		[PXFormula(typeof(Default<isFreightLine>))]
		public virtual bool? EnablePriceAnalysisByLine { get; set; }
		#endregion

		#region InventoryIDDisplay
		public abstract class inventoryIDDisplay : PX.Data.BQL.BqlString.Field<inventoryIDDisplay> { }
		[PXString]
		[PXUIField(DisplayName = "Inventory ID", Enabled = false)]
		public virtual String InventoryIDDisplay { get; set; }
		#endregion

		#region InventoryDescription
		public abstract class inventoryDescription : PX.Data.BQL.BqlString.Field<inventoryDescription> { }
		[PXString]
		[PXUIField(DisplayName = "Description", Enabled = false)]
		public virtual String InventoryDescription { get; set; }
		#endregion

		#region LineType
		public abstract class lineType : PX.Data.BQL.BqlString.Field<lineType> { }

		[PXDBString(2, IsFixed = true, IsUnicode = false)]
		[ProfitLineType.List]
		[PXUIField(DisplayName = "Line type")]
		public virtual String LineType { get; set; }
		#endregion

		#region IsLastCostUsed
		public abstract class isLastCostUsed : PX.Data.BQL.BqlBool.Field<isLastCostUsed> { }

		[PXDBBool]
		public virtual bool? IsLastCostUsed { get; set; }
		#endregion

		#region UOM
		public abstract class uOM : PX.Data.BQL.BqlString.Field<uOM> { }

		[PXString(6, IsUnicode = true, InputMask = ">aaaaaa")]
		[PXUIField(DisplayName = "UOM", Enabled = false)]
		public virtual String UOM { get; set; }
		#endregion

		#region OrderQtyDisplay
		public abstract class orderQtyDisplay : PX.Data.BQL.BqlDecimal.Field<orderQtyDisplay> { }

		[PXQuantity()]
		[PXUIField(DisplayName = "Quantity", Enabled = false)]
		public virtual Decimal? OrderQtyDisplay { get; set; }
		#endregion

		#region OrderQty
		public abstract class orderQty : PX.Data.BQL.BqlDecimal.Field<orderQty> { }

		[PXQuantity()]
		[PXUIField(DisplayName = "Quantity", Enabled = false)]
		public virtual Decimal? OrderQty { get; set; }
		#endregion

		#region CuryDiscAmt
		public abstract class curyDiscAmt : PX.Data.BQL.BqlDecimal.Field<curyDiscAmt> { }

		[PXPriceCost]
		[PXUIField(DisplayName = "Discount Amount", Enabled = true)]
		public virtual Decimal? CuryDiscAmt { get; set; }
		#endregion

		#region CuryUnitPrice
		public abstract class curyUnitPrice : PX.Data.BQL.BqlDecimal.Field<curyUnitPrice> { }

		[PXPriceCost]
		[PXUIField(DisplayName = "Unit Price", Enabled = false)]
		public virtual Decimal? CuryUnitPrice { get; set; }
		#endregion

		#region CuryUnitCost
		public abstract class curyUnitCost : PX.Data.BQL.BqlDecimal.Field<curyUnitCost> { }
		[PXPriceCost]
		[PXUIField(DisplayName = "Unit Cost", Enabled = false)]
		public virtual Decimal? CuryUnitCost { get; set; }
		#endregion

		#region CuryExtCostDisplay
		public abstract class curyExtCostDisplay : PX.Data.BQL.BqlDecimal.Field<curyExtCostDisplay> { }

		[PXPriceCost]
		[PXUIField(DisplayName = "Cost Amount", Enabled = false)]
		public virtual Decimal? CuryExtCostDisplay { get; set; }
		#endregion

		#region CuryExtCost
		public abstract class curyExtCost : PX.Data.BQL.BqlDecimal.Field<curyExtCost> { }

		[PXPriceCost]
		[PXUIField(DisplayName = "Cost Amount", Enabled = false)]
		[PXUnboundDefault(TypeCode.Decimal, "0.0")]
		public virtual Decimal? CuryExtCost { get; set; }
		#endregion

		#region CuryLineAmt
		public abstract class curyLineAmt : PX.Data.BQL.BqlDecimal.Field<curyLineAmt> { }

		[PXPriceCost]
		[PXUIField(DisplayName = "Amount", Enabled = true)]
		public virtual Decimal? CuryLineAmt { get; set; }
		#endregion

		#region CuryProfit
		public abstract class curyProfit : PX.Data.BQL.BqlDecimal.Field<curyProfit> { }

		[PXPriceCost]
		[PXUIField(DisplayName = "Profit Amount", Enabled = true)]
		public virtual decimal? CuryProfit { get; set; }
		#endregion

		#region MarkupPercent
		public abstract class markupPercent : PX.Data.BQL.BqlDecimal.Field<markupPercent> { }

		[PXDecimal(2)]
		[PXUIField(DisplayName = "Markup %", Enabled = true)]
		public virtual decimal? MarkupPercent { get; set; }
		#endregion

		#region MarginPercent
		public abstract class marginPercent : PX.Data.BQL.BqlDecimal.Field<marginPercent> { }

		[PXDecimal(2)]
		[PXUIField(DisplayName = "Margin %", Enabled = true)]
		public virtual decimal? MarginPercent { get; set; }
        #endregion
    }
}