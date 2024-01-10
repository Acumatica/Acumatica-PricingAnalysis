using PX.Data;
using PX.Objects.CS;
using PX.Objects.FS;

namespace PX.PricingAnalysis.Ext
{
    public sealed class FSServiceOrderPricingPXExt : PXCacheExtension<FSServiceOrder>
    {
        public static bool IsActive() => PXAccess.FeatureInstalled<FeaturesSet.serviceManagementModule>();

        #region UsrEditable
        public abstract class usrEditable : PX.Data.BQL.BqlBool.Field<usrEditable> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Switch<Case<Where<FSServiceOrder.status, Equal<FSServiceOrder.status.Values.open>>, True>, False>))]
        public bool? UsrEditable { get; set; }
        #endregion
    }
}