using System;
using PX.Data;
using PX.Objects.FS;
using PX.Objects.IN;

namespace PX.PricingAnalysis.Ext
{
    public sealed class FSAppointmentDetPricingPXExt : PXCacheExtension<FSAppointmentDet>
    {
        #region UsrIsStockItem
        public abstract class usrIsStockItem : PX.Data.BQL.BqlBool.Field<usrIsStockItem> { }

        [PXBool]
        [PXUIField(DisplayName = "Is stock", Visibility = PXUIVisibility.Invisible, Visible = false, Enabled = false)]
        [PXFormula(typeof(Selector<FSAppointmentDet.inventoryID, InventoryItem.stkItem>))]
        [PXDependsOnFields(typeof(FSAppointmentDet.inventoryID))]
        public Boolean? UsrIsStockItem { get; set; }
        #endregion

        #region UsrAccrueCost
        public abstract class usrAccrueCost : PX.Data.BQL.BqlBool.Field<usrAccrueCost> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Selector<FSAppointmentDet.inventoryID, InventoryItem.accrueCost>))]
        public bool? UsrAccrueCost { get; set; }
        #endregion

        #region UsrPricingEligible
        public abstract class usrPricingEligible : PX.Data.BQL.BqlBool.Field<usrPricingEligible> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Switch<Case<Where<FSAppointmentDetPricingPXExt.usrIsStockItem, Equal<True>, Or<FSAppointmentDetPricingPXExt.usrAccrueCost, Equal<True>>>, True>, False>))]
        public bool? UsrPricingEligible { get; set; }
        #endregion

        #region UsrCuryLineCost
        public abstract class usrCuryLineCost : PX.Data.BQL.BqlDecimal.Field<usrCuryLineCost> { }

        [PXPriceCost]
        [PXUIField(DisplayName = "Line Cost (For Pricing)", Enabled = false)]
        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        public Decimal? UsrCuryLineCost { get; set; }
        #endregion

        #region UsrQtyOnHand
        public abstract class usrQtyOnHand : PX.Data.BQL.BqlDecimal.Field<usrQtyOnHand> { }

        [PXQuantity()]
        [PXUIField(DisplayName = "Qty. On Hand (For Pricing)", Enabled = false)]
        public Decimal? UsrQtyOnHand { get; set; }
        #endregion

        #region UsrIsLastCostUsed
        public abstract class usrIsLastCostUsed : PX.Data.BQL.BqlBool.Field<usrIsLastCostUsed> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Switch<Case<Where<FSAppointmentDetPricingPXExt.usrQtyOnHand, IsNull, Or<FSAppointmentDetPricingPXExt.usrQtyOnHand, Equal<Objects.CS.decimal0>>>, True>, False>))]
        public bool? UsrIsLastCostUsed { get; set; }
        #endregion
    }
}