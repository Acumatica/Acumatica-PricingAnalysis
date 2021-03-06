﻿using System;
using PX.Data;
using PX.Objects.CM;
using PX.Objects.CR;
using PX.Objects.CS;
using PX.Objects.IN;
using static PX.Objects.FS.SharedClasses;

namespace PX.PricingAnalysis.Ext
{
    public sealed class CROpportunityProductsPricingPXExt : PXCacheExtension<CROpportunityProducts>
    {
        #region UsrIsStockItem
        public abstract class usrIsStockItem : PX.Data.BQL.BqlBool.Field<usrIsStockItem> { }

        [PXBool]
        [PXUIField(DisplayName = "Is stock", Visibility = PXUIVisibility.Invisible, Visible = false, Enabled = false)]
        [PXFormula(typeof(Selector<CROpportunityProducts.inventoryID, InventoryItem.stkItem>))]
        [PXDependsOnFields(typeof(CROpportunityProducts.inventoryID))]
        public Boolean? UsrIsStockItem { get; set; }
        #endregion

        #region UsrAccrueCost
        public abstract class usrAccrueCost : PX.Data.BQL.BqlDecimal.Field<usrAccrueCost> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Selector<CROpportunityProducts.inventoryID, InventoryItem.accrueCost>))]
        public bool? UsrAccrueCost { get; set; }
        #endregion

        #region UsrPricingEligible
        public abstract class usrPricingEligible : PX.Data.BQL.BqlDecimal.Field<usrPricingEligible> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Switch<Case<Where<CROpportunityProductsPricingPXExt.usrIsStockItem, Equal<True>, Or<CROpportunityProductsPricingPXExt.usrAccrueCost, Equal<True>>>, True>, False>))]
        public bool? UsrPricingEligible { get; set; }
        #endregion

        #region UsrIsLastCostUsed
        public abstract class usrIsLastCostUsed : PX.Data.BQL.BqlDecimal.Field<usrIsLastCostUsed> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Switch<Case<Where<CROpportunityProducts.curyExtCost, IsNull, Or<CROpportunityProducts.curyExtCost, Equal<Objects.CS.decimal0>>>, True>, False>))]
        public bool? UsrIsLastCostUsed { get; set; }
        #endregion
    }
}