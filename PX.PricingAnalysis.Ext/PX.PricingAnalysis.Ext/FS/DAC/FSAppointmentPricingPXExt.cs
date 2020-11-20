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
        [PXFormula(typeof(Switch<Case<Where<FSAppointment.status, Equal<ListField_Status_Appointment.InProcess>,
                                        Or<FSAppointment.status, Equal<ListField_Status_Appointment.Completed>,
                                        Or<FSAppointment.status, Equal<ListField_Status_Appointment.OnHold>>>>, True>, False>))]
        public bool? UsrEditable { get; set; }
        #endregion
    }
}