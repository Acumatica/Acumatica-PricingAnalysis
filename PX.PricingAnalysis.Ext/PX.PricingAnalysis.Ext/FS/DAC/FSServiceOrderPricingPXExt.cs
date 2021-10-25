using System;
using PX.Data;
using PX.Objects.FS;

namespace PX.PricingAnalysis.Ext
{
    public sealed class FSServiceOrderPricingPXExt : PXCacheExtension<FSServiceOrder>
    {
        #region UsrEditable
        public abstract class usrEditable : PX.Data.BQL.BqlBool.Field<usrEditable> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Switch<Case<Where<FSServiceOrder.status, Equal<FSServiceOrder.status.Values.open>>, True>, False>))]
        public bool? UsrEditable { get; set; }
        #endregion
    }
}