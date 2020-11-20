using System;
using PX.Data;
using PX.Objects.SO;

namespace PX.PricingAnalysis.Ext
{
    public sealed class SOOrderPricingPXExt : PXCacheExtension<SOOrder>
    {
        #region UsrEditable
        public abstract class usrEditable : PX.Data.BQL.BqlBool.Field<usrEditable> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Switch<Case<Where<SOOrder.status, Equal<SOOrderStatus.open>, Or<SOOrder.status, Equal<SOOrderStatus.hold>>>, True>, False>))]
        public bool? UsrEditable { get; set; }
        #endregion
    }
}
