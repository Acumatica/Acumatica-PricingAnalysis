using System;
using PX.Data;
using PX.Data.BQL;
using PX.Objects.IN;

namespace PX.PricingAnalysis.Ext
{
    [Serializable]
    [PXHidden]
    public class NSKitAvailabilityHeader : IBqlTable
    {
        #region UsrMaxQty
        public abstract class usrMaxQty : BqlDecimal.Field<usrMaxQty> { }

        [PXUIField(DisplayName = "Max Qty", Enabled = false)]
        [PXDecimal(2)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public virtual Decimal? UsrMaxQty { get; set; }
        #endregion

        #region UsrOrderQty
        public abstract class usrOrderQty : BqlDecimal.Field<usrOrderQty> { }

        [PXUIField(DisplayName = "Order Qty", Enabled = false)]
        [PXDecimal(2)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public virtual Decimal? UsrOrderQty { get; set; }
        #endregion
    }
}