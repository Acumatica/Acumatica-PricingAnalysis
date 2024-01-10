using System;
using PX.Data;
using PX.Objects.CR;
using PX.Objects.IN;

namespace PX.PricingAnalysis.Ext
{
    public sealed class CROpportunityProductsPricingPXExt : PXCacheExtension<CROpportunityProducts>
    {
        public static bool IsActive() => true;

        #region UsrIsStockItem
        public abstract class usrIsStockItem : PX.Data.BQL.BqlBool.Field<usrIsStockItem> { }

        [PXBool]
        [PXUIField(DisplayName = "Is stock", Visibility = PXUIVisibility.Invisible, Visible = false, Enabled = false)]
        [PXFormula(typeof(Selector<CROpportunityProducts.inventoryID, InventoryItem.stkItem>))]
        [PXDependsOnFields(typeof(CROpportunityProducts.inventoryID))]
        public Boolean? UsrIsStockItem { get; set; }
        #endregion

        #region UsrPricingEligible
        public abstract class usrPricingEligible : PX.Data.BQL.BqlBool.Field<usrPricingEligible> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(True))]
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