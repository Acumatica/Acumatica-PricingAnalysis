using System;
using PX.Data;

namespace PX.PricingAnalysis.Ext
{
    [Serializable]
    [PXHidden]
    public class PricingAnalysisBreakupByDoc : IBqlTable
	{
		#region RecordID
		public abstract class recordID : PX.Data.BQL.BqlInt.Field<recordID> { }
		[PXInt(IsKey = true)]
		public virtual int? RecordID { get; set; }
		#endregion

		#region LineType
		public abstract class lineType : PX.Data.BQL.BqlString.Field<lineType> { }

		[PXDBString(2, IsFixed = true, IsUnicode = false)]
		[ProfitLineType.List]
		[PXUIField(DisplayName = "Line type")]
		public virtual String LineType { get; set; }
		#endregion

		#region CuryExtCost
		public abstract class curyExtCost : PX.Data.BQL.BqlDecimal.Field<curyExtCost> { }

		[PXDecimal]
		[PXUIField(DisplayName = "Cost Amount", Enabled = false)]
		[PXUnboundDefault(TypeCode.Decimal, "0.0")]
		public virtual Decimal? CuryExtCost { get; set; }
		#endregion

		#region MarkupPercent
		public abstract class markupPercent : PX.Data.BQL.BqlDecimal.Field<markupPercent> { }
		[PXUIField(DisplayName = "Markup %", Enabled = true)]
		[PXDecimal]
		public virtual decimal? MarkupPercent { get; set; }
		#endregion

		#region MarginPercent
		public abstract class marginPercent : PX.Data.BQL.BqlDecimal.Field<marginPercent> { }
		[PXUIField(DisplayName = "Margin %", Enabled = true)]
		[PXDecimal]
		public virtual decimal? MarginPercent { get; set; }
		#endregion

		#region CuryProfit
		public abstract class curyProfit : PX.Data.BQL.BqlDecimal.Field<curyProfit> { }
		[PXUIField(DisplayName = "Profit Amount", Enabled = true)]
		[PXDecimal]
		public virtual decimal? CuryProfit { get; set; }
		#endregion

		#region CuryExtPrice
		public abstract class curyExtPrice : PX.Data.BQL.BqlDecimal.Field<curyExtPrice> { }

		[PXDecimal]
		[PXUIField(DisplayName = "Amount", Enabled = true)]
		public virtual Decimal? CuryExtPrice { get; set; }
		#endregion
	}
}