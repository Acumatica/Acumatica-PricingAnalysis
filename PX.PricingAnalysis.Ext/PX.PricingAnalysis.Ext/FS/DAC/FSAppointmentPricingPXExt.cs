using System;
using PX.Data;
using PX.Objects.FS;

namespace PX.PricingAnalysis.Ext
{
    public sealed class FSAppointmentPricingPXExt : PXCacheExtension<FSAppointment>
    {
        #region UsrEditable
        public abstract class usrEditable : PX.Data.BQL.BqlBool.Field<usrEditable> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Switch<Case<Where<FSAppointment.status, Equal<FSAppointment.status.Values.inProcess>,
                                        Or<FSAppointment.status, Equal<FSAppointment.status.Values.completed>,
                                        Or<FSAppointment.status, Equal<FSAppointment.status.Values.hold>>>>, True>, False>))]
        public bool? UsrEditable { get; set; }
        #endregion
    }
}