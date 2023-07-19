using System;
using PX.Data;
using PX.Objects.AR;
using PX.Objects.IN;

namespace PX.PricingAnalysis.Ext
{
    public sealed class ARInvoicePricingAnalysisPXExt : PXCacheExtension<ARInvoice>
    {
        #region UsrCostTotal
        public abstract class usrCostTotal : PX.Data.BQL.BqlDecimal.Field<usrCostTotal> { }

        [PXPriceCost]
        [PXUIField(DisplayName = "Cost Amount", Enabled = false)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public Decimal? UsrCostTotal { get; set; }
        #endregion

        #region UsrProfitTotal
        public abstract class usrProfitTotal : PX.Data.BQL.BqlDecimal.Field<usrProfitTotal> { }

        [PXPriceCost]
        [PXUIField(DisplayName = "Profit", Enabled = false)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]

        public decimal? UsrProfitTotal { get; set; }
        #endregion

        #region UsrMarkupPercent
        public abstract class usrMarkupPercent : PX.Data.BQL.BqlDecimal.Field<usrMarkupPercent> { }

        [PXDecimal(2)]
        [PXUIField(DisplayName = "Markup %", Enabled = false)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public decimal? UsrMarkupPercent { get; set; }
        #endregion

        #region UsrMarginPercent
        public abstract class usrMarginPercent : PX.Data.BQL.BqlDecimal.Field<usrMarginPercent> { }

        [PXDecimal(2)]
        [PXUIField(DisplayName = "Margin %", Enabled = false)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public decimal? UsrMarginPercent { get; set; }
        #endregion
    }
}