using System;
using PX.Data;
using PX.Objects.IN;
using PX.Objects.SO;

namespace PX.PricingAnalysis.Ext
{
    public sealed class SOLinePricingPXExt : PXCacheExtension<SOLine>
    {
        #region UsrAccrueCost
        public abstract class usrAccrueCost : PX.Data.BQL.BqlDecimal.Field<usrAccrueCost> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Selector<SOLine.inventoryID, InventoryItem.accrueCost>))]
        public bool? UsrAccrueCost { get; set; }
        #endregion

        #region UsrPricingEligible
        public abstract class usrPricingEligible : PX.Data.BQL.BqlDecimal.Field<usrPricingEligible> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Switch<Case<Where<SOLine.isStockItem, Equal<True>, Or<SOLinePricingPXExt.usrAccrueCost, Equal<True>>>, True>, False>))]
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
        public abstract class usrIsLastCostUsed : PX.Data.BQL.BqlDecimal.Field<usrIsLastCostUsed> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Switch<Case<Where<SOLinePricingPXExt.usrQtyOnHand, IsNull,
                                        Or<SOLinePricingPXExt.usrQtyOnHand, Equal<Objects.CS.decimal0>>>, True>, False>))]
        public bool? UsrIsLastCostUsed { get; set; }
        #endregion
    }
}