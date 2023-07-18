using PX.Data;
using PX.Objects.IN;
using PX.Objects.SO;

namespace PX.PricingAnalysis.Ext
{
    public class SOOrderEntryPricingAnalysisExt : PricingAnalysisGraph<SOOrderEntry, SOOrder>
    {

        protected override bool CalcFreightPrices => true;

        protected override DocumentMapping GetDocumentMapping()
        {
            return new DocumentMapping(typeof(SOOrder))
            {
                NoteID = typeof(SOOrder.noteID),
                UsrEditable = typeof(SOOrderPricingPXExt.usrEditable),
                CuryFreightTot = typeof(SOOrder.curyFreightTot),
                CuryFreightAmt = typeof(SOOrder.curyFreightAmt),
                CuryFreightCost = typeof(SOOrder.curyFreightCost),
                CuryPremiumFreightAmt = typeof(SOOrder.curyPremiumFreightAmt),
                OverrideFreightAmount = typeof(SOOrder.overrideFreightAmount)
            };
        }

        protected override DocumentLineMapping GetDocumentLineMapping()
        {
            return new DocumentLineMapping(typeof(SOLine))
            {
                NoteID = typeof(SOLine.noteID),
                LineNbr = typeof(SOLine.lineNbr),
                InventoryID = typeof(SOLine.inventoryID),
                PricingEligible = typeof(SOLinePricingPXExt.usrPricingEligible),
                UOM = typeof(SOLine.uOM),
                OrderQty = typeof(SOLine.orderQty),
                CuryDiscAmt = typeof(SOLine.curyDiscAmt),
                CuryUnitPrice = typeof(SOLine.curyUnitPrice),
                CuryExtCost = typeof(SOLinePricingPXExt.usrCuryLineCost),
                CuryLineAmt = typeof(SOLine.curyLineAmt),
                IsLastCostUsed = typeof(SOLinePricingPXExt.usrIsLastCostUsed),
                PriceType = typeof(SOLine.priceType),
                IsPromotionalPrice = typeof(SOLine.isPromotionalPrice),
                SiteID = typeof(SOLine.siteID)
            };
        }

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(PALineCostValueExtAttribute<SOLine.inventoryID, SOLine.siteID, SOLine.extCost, SOLine.orderQty, SOLine.curyUnitCost>))]
        protected virtual void _(Events.CacheAttached<SOLinePricingPXExt.usrCuryLineCost> e) { }

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXUnboundDefault(typeof(Search<INItemStats.qtyOnHand,
                                    Where<INItemStats.inventoryID, Equal<Current<SOLine.inventoryID>>,
                                        And<INItemStats.siteID, Equal<Current<SOLine.siteID>>>>>), PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Default<SOLine.inventoryID, SOLine.siteID>))]
        protected virtual void _(Events.CacheAttached<SOLinePricingPXExt.usrQtyOnHandDecimal> e) { }

    }
}