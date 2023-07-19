using System;
using PX.Data;
using PX.Objects.IN;

namespace PX.PricingAnalysis.Ext
{
    [PXHidden]
    public class PricingAnalysisPreviewHeaderSummary : IBqlTable
    {
        #region HeaderInfoID
        public abstract class headerInfoID : PX.Data.BQL.BqlInt.Field<headerInfoID> { }

        [PXInt(IsKey = true)]
        [PXUIField(DisplayName = "ID", Enabled = false)]
        public virtual int? HeaderInfoID { get; set; }
        #endregion

        #region HeaderInfoType
        public abstract class headerInfoType : PX.Data.BQL.BqlString.Field<headerInfoType> { }

        [PXString(2, IsFixed = true)]
        [PXUIField(DisplayName = " ", Enabled = false)]
        [HeaderInfoTypes.List]
        public virtual String HeaderInfoType { get; set; }
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

        #region MarkupPercent
        public abstract class markupPercent : PX.Data.BQL.BqlDecimal.Field<markupPercent> { }

        [PXDecimal(2)]
        [PXUIField(DisplayName = "Markup %", Enabled = false)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public virtual decimal? MarkupPercent { get; set; }
        #endregion

        #region MarginPercent
        public abstract class marginPercent : PX.Data.BQL.BqlDecimal.Field<marginPercent> { }

        [PXDecimal(2)]
        [PXUIField(DisplayName = "Margin %", Enabled = false)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public virtual decimal? MarginPercent { get; set; }
        #endregion
    }
}