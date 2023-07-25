using System;
using PX.Data;
using PX.Objects.CR;
using PX.Objects.IN;

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
        public abstract class usrAccrueCost : PX.Data.BQL.BqlBool.Field<usrAccrueCost> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Selector<CROpportunityProducts.inventoryID, InventoryItem.accrueCost>))]
        public bool? UsrAccrueCost { get; set; }
        #endregion

        #region UsrIsKit
        public abstract class usrIsKit : PX.Data.BQL.BqlBool.Field<usrIsKit> { }

        [PXBool]
        [PXUnboundDefault(typeof(Search<InventoryItem.kitItem,
                                    Where<InventoryItem.inventoryID, Equal<Current<CROpportunityProducts.inventoryID>>>>), PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Default<CROpportunityProducts.inventoryID>))]
        public bool? UsrIsKit { get; set; }
        #endregion

        #region UsrPricingEligible
        public abstract class usrPricingEligible : PX.Data.BQL.BqlBool.Field<usrPricingEligible> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Switch<Case<Where<CROpportunityProductsPricingPXExt.usrIsStockItem, Equal<True>, Or<CROpportunityProductsPricingPXExt.usrAccrueCost, Equal<True>, Or<CROpportunityProductsPricingPXExt.usrIsKit, Equal<True>>>>, True>, False>))]
        public bool? UsrPricingEligible { get; set; }
        #endregion

        #region UsrQtyOnHand
        public abstract class usrQtyOnHand : PX.Data.BQL.BqlDecimal.Field<usrQtyOnHand> { }

        [PXQuantity()]
        [PXUnboundDefault(typeof(Search<INItemStats.qtyOnHand,
                                    Where<INItemStats.inventoryID, Equal<Current<CROpportunityProducts.inventoryID>>,
                                        And<INItemStats.siteID, Equal<Current<CROpportunityProducts.siteID>>>>>), PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Default<CROpportunityProducts.inventoryID, CROpportunityProducts.siteID>))]
        public Decimal? UsrQtyOnHand { get; set; }
        #endregion

        #region UsrIsLastCostUsed
        public abstract class usrIsLastCostUsed : PX.Data.BQL.BqlBool.Field<usrIsLastCostUsed> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Switch<Case<Where<CROpportunityProductsPricingPXExt.usrQtyOnHand, IsNull, Or<CROpportunityProductsPricingPXExt.usrQtyOnHand, Equal<Objects.CS.decimal0>>>, True>, False>))]
        public bool? UsrIsLastCostUsed { get; set; }
        #endregion
    }
}