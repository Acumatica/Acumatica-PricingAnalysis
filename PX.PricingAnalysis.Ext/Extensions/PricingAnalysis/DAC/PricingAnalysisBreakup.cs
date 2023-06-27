using System;
using PX.Data;
using PX.Objects.CS;
using PX.Objects.IN;

namespace PX.PricingAnalysis.Ext
{
    [Serializable]
    [PXHidden]
    public class PricingAnalysisBreakup : IBqlTable
	{
		#region RecordID
		public abstract class recordID : PX.Data.BQL.BqlInt.Field<recordID> { }
		[PXInt(IsKey = true)]
		public virtual int? RecordID { get; set; }
		#endregion

		public abstract class lineNbr : PX.Data.BQL.BqlInt.Field<lineNbr> { }
		[PXInt]
		[PXUIField(DisplayName = "Line Nbr.", Visible = false)]
		public virtual Int32? LineNbr { get; set; }

		#region LineType
		public abstract class lineType : PX.Data.BQL.BqlString.Field<lineType> { }

		[PXDBString(2, IsFixed = true, IsUnicode = false)]
		[ProfitLineType.List]
		[PXUIField(DisplayName = "Line type")]
		public virtual String LineType { get; set; }
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
		[PXUIField(DisplayName = "Discount Amount", Enabled = false)]
		public virtual Decimal? CuryDiscAmt { get; set; }
		#endregion

		#region CuryUnitPrice
		public abstract class curyUnitPrice : PX.Data.BQL.BqlDecimal.Field<curyUnitPrice> { }

		[PXPriceCost]
		[PXUIField(DisplayName = "Unit Price", Enabled = false)]
		public virtual Decimal? CuryUnitPrice { get; set; }
		#endregion

		public abstract class curyExtCost : PX.Data.BQL.BqlDecimal.Field<curyExtCost> { }

		[PXDecimal]
		[PXUIField(DisplayName = "Cost Amount", Enabled = false)]
		[PXUnboundDefault(TypeCode.Decimal, "0.0")]
		public virtual Decimal? CuryExtCost { get; set; }

		public abstract class markupPercent : PX.Data.BQL.BqlDecimal.Field<markupPercent> { }
		[PXUIField(DisplayName = "Markup %", Enabled = true)]
		[PXDecimal]
		public virtual decimal? MarkupPercent { get; set; }

		public abstract class marginPercent : PX.Data.BQL.BqlDecimal.Field<marginPercent> { }
		[PXUIField(DisplayName = "Margin %", Enabled = true)]
		[PXDecimal]
		public virtual decimal? MarginPercent { get; set; }

		public abstract class curyProfit : PX.Data.BQL.BqlDecimal.Field<curyProfit> { }
		[PXUIField(DisplayName = "Profit Amount", Enabled = true)]
		[PXDecimal]
		public virtual decimal? CuryProfit { get; set; }

		public abstract class curyExtPrice : PX.Data.BQL.BqlDecimal.Field<curyExtPrice> { }

		[PXDecimal]
		[PXUIField(DisplayName = "Amount", Enabled = true)]
		public virtual Decimal? CuryExtPrice { get; set; }
	}
}