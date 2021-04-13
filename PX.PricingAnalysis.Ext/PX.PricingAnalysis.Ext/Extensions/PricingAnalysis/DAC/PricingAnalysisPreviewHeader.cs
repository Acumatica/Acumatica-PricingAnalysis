using System;
using PX.Data;
using PX.Objects.CS;
using PX.Objects.IN;

namespace PX.PricingAnalysis.Ext
{
    [Serializable]
    [PXHidden]
    public class PricingAnalysisPreviewHeader : IBqlTable
    {
        #region CuryExtCostTotalCurrent
        public abstract class curyExtCostTotalCurrent : PX.Data.BQL.BqlDecimal.Field<curyExtCostTotalCurrent> { }

        [PXPriceCost]
        [PXUIField(DisplayName = "Cost", Enabled = false)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public virtual Decimal? CuryExtCostTotalCurrent { get; set; }
        #endregion

        #region CuryProfitTotalCurrent
        public abstract class curyProfitTotalCurrent : PX.Data.BQL.BqlDecimal.Field<curyProfitTotalCurrent> { }

        [PXPriceCost]
        [PXUIField(DisplayName = "Profit", Enabled = false)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public virtual decimal? CuryProfitTotalCurrent { get; set; }
        #endregion

        #region CuryAmountTotalCurrent
        public abstract class curyAmountTotalCurrent : PX.Data.BQL.BqlDecimal.Field<curyAmountTotalCurrent> { }

        [PXPriceCost]
        [PXUIField(DisplayName = "Amount", Enabled = false)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public virtual Decimal? CuryAmountTotalCurrent { get; set; }
        #endregion

        #region MarkupPercentCurrent
        public abstract class markupPercentCurrent : PX.Data.BQL.BqlDecimal.Field<markupPercentCurrent> { }

        [PXDecimal(2)]
        [PXUIField(DisplayName = "Markup %", Enabled = false)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public virtual decimal? MarkupPercentCurrent { get; set; }
        #endregion

        #region MarginPercentCurrent
        public abstract class marginPercentCurrent : PX.Data.BQL.BqlDecimal.Field<marginPercentCurrent> { }

        [PXDecimal(2)]
        [PXUIField(DisplayName = "Margin %", Enabled = false)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public virtual decimal? MarginPercentCurrent { get; set; }
        #endregion

        #region CuryExtCostTotal
        public abstract class curyExtCostTotal : PX.Data.BQL.BqlDecimal.Field<curyExtCostTotal> { }

        [PXPriceCost]
        [PXUIField(DisplayName = "Cost", Enabled = false)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public virtual Decimal? CuryExtCostTotal { get; set; }
        #endregion

        #region CuryProfitTotal
        public abstract class curyProfitTotal : PX.Data.BQL.BqlDecimal.Field<curyProfitTotal> { }

        [PXPriceCost]
        [PXUIField(DisplayName = "Profit", Enabled = false)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public virtual decimal? CuryProfitTotal { get; set; }
        #endregion

        #region CuryAmountTotal
        public abstract class curyAmountTotal : PX.Data.BQL.BqlDecimal.Field<curyAmountTotal> { }

        [PXPriceCost]
        [PXUIField(DisplayName = "Amount", Enabled = false)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public virtual Decimal? CuryAmountTotal { get; set; }
        #endregion

        #region MarkupPercentPreview
        public abstract class markupPercentPreview : PX.Data.BQL.BqlDecimal.Field<markupPercentPreview> { }

        [PXDecimal(2)]
        [PXUIField(DisplayName = "Markup %", Enabled = false)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public virtual decimal? MarkupPercentPreview { get; set; }
        #endregion

        #region MarginPercentPreview
        public abstract class marginPercentPreview : PX.Data.BQL.BqlDecimal.Field<marginPercentPreview> { }

        [PXDecimal(2)]
        [PXUIField(DisplayName = "Margin %", Enabled = false)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public virtual decimal? MarginPercentPreview { get; set; }
        #endregion

        #region ApplyAdjustmentAsHidden
        public abstract class applyAdjustmentAsHidden : PX.Data.BQL.BqlString.Field<applyAdjustmentAsHidden> { }

        [PXDBString(1, IsFixed = true, IsUnicode = false)]
        [PXUnboundDefault(typeof(Search<ARSetupPricingAnalysisPXExt.usrDefAdjustmentType>))]
        public virtual String ApplyAdjustmentAsHidden { get; set; }
        #endregion

        #region ApplyAdjustmentAs
        public abstract class applyAdjustmentAs : PX.Data.BQL.BqlString.Field<applyAdjustmentAs> { }

        [PXDBString(1, IsFixed = true, IsUnicode = false)]
        [AdjustmentType.List]
        [PXUIField(DisplayName = "Apply Adjustments As")]
        [PXUnboundDefault(typeof(Switch<Case<Where<PricingAnalysisPreviewHeader.applyAdjustmentAsHidden, IsNotNull>,
                                    PricingAnalysisPreviewHeader.applyAdjustmentAsHidden>, AdjustmentType.priceadjustment>))]
        public virtual String ApplyAdjustmentAs { get; set; }
        #endregion
    }
}