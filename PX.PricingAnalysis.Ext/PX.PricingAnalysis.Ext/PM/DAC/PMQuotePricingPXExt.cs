using PX.Data;
using PX.Objects.PM;

namespace PX.PricingAnalysis.Ext
{
    public sealed class PMQuotePricingPXExt : PXCacheExtension<PMQuote>
    {
        #region UsrEditable
        public abstract class usrEditable : PX.Data.BQL.BqlBool.Field<usrEditable> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Switch<Case<Where<PMQuote.status, Equal<PMQuoteStatusAttribute.draft>>, True>, False>))]
        public bool? UsrEditable { get; set; }
        #endregion
    }
}
