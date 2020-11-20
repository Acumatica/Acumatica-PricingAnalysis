using System;
using PX.Data;
using PX.Objects.CR;

namespace PX.PricingAnalysis.Ext
{
    public sealed class CRQuotePricingPXExt : PXCacheExtension<CRQuote>
    {
        #region UsrEditable
        public abstract class usrEditable : PX.Data.BQL.BqlBool.Field<usrEditable> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Switch<Case<Where<CRQuote.status, Equal<CRQuoteStatusAttribute.draft>>, True>, False>))]
        public bool? UsrEditable { get; set; }
        #endregion
    }
}