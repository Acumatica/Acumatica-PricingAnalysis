﻿using System;
using PX.Data;
using PX.Objects.IN;
using PX.Objects.SO;

namespace PX.PricingAnalysis.Ext
{
    public sealed class SOLinePricingPXExt : PXCacheExtension<SOLine>
    {
        #region UsrAccrueCost
        public abstract class usrAccrueCost : PX.Data.BQL.BqlBool.Field<usrAccrueCost> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Selector<SOLine.inventoryID, InventoryItem.accrueCost>))]
        public bool? UsrAccrueCost { get; set; }
        #endregion

        #region UsrPricingEligible
        public abstract class usrPricingEligible : PX.Data.BQL.BqlBool.Field<usrPricingEligible> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Switch<Case<Where<SOLine.isStockItem, Equal<True>, Or<SOLinePricingPXExt.usrAccrueCost, Equal<True>, Or<SOLine.isKit, Equal<True>>>>, True>, False>))]
        public bool? UsrPricingEligible { get; set; }
        #endregion

        #region UsrCuryLineCost
        public abstract class usrCuryLineCost : PX.Data.BQL.BqlDecimal.Field<usrCuryLineCost> { }

        [PXPriceCost]
        [PXUIField(DisplayName = "Line Cost (For Pricing)", Enabled = false)]
        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        public Decimal? UsrCuryLineCost { get; set; }
        #endregion

        #region UsrQtyOnHandPricing
        public abstract class usrQtyOnHandPricing : PX.Data.BQL.BqlDecimal.Field<usrQtyOnHandPricing> { }
        [PXQuantity]
        public Decimal? UsrQtyOnHandPricing { get; set; }
        #endregion

        #region UsrIsLastCostUsed
        public abstract class usrIsLastCostUsed : PX.Data.BQL.BqlBool.Field<usrIsLastCostUsed> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Switch<Case<Where<usrQtyOnHandPricing, IsNull,
                                        Or<usrQtyOnHandPricing, Equal<Objects.CS.decimal0>>>, True>, False>))]
        public bool? UsrIsLastCostUsed { get; set; }
        #endregion

        #region UsrIsNonStockKit
        public abstract class usrIsNonStockKit : PX.Data.BQL.BqlBool.Field<usrIsNonStockKit> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Switch<Case<Where<SOLine.isStockItem, Equal<False>, And<SOLine.isKit, Equal<True>>>, True>, False>))]
        [PXUIField(DisplayName = "Is Non-Stock Kit", Enabled = false, Visible = false)]

        public bool? UsrIsNonStockKit { get; set; }
        #endregion
    }
}