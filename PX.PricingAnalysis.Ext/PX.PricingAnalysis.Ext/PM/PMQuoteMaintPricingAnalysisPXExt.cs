using System;
using PX.Data;
using PX.Objects.CM;
using PX.Objects.PM;
using PX.Objects.IN;
using PX.Objects.CR;

namespace PX.PricingAnalysis.Ext
{
    public class PMQuoteMaintPricingAnalysisPXExt : PricingAnalysisGraph<PMQuoteMaint, PMQuote>
    {
        protected override DocumentMapping GetDocumentMapping()
        {
            return new DocumentMapping(typeof(PMQuote))
            {
                NoteID = typeof(PMQuote.noteID),
                UsrEditable = typeof(PMQuotePricingPXExt.usrEditable)
            };
        }

        protected override DocumentLineMapping GetDocumentLineMapping()
        {
            return new DocumentLineMapping(typeof(CROpportunityProducts))
            {
                NoteID = typeof(CROpportunityProducts.noteID),
                LineNbr = typeof(CROpportunityProducts.lineNbr),
                InventoryID = typeof(CROpportunityProducts.inventoryID),
                IsStockItem = typeof(CROpportunityProductsPricingPXExt.usrPricingEligible),
                UOM = typeof(CROpportunityProducts.uOM),
                OrderQty = typeof(CROpportunityProducts.quantity),
                CuryDiscAmt = typeof(CROpportunityProducts.curyDiscAmt),
                CuryUnitPrice = typeof(CROpportunityProducts.curyUnitPrice),
                CuryExtCost = typeof(CROpportunityProducts.curyExtCost),
                CuryLineAmt = typeof(CROpportunityProducts.curyAmount),
                IsLastCostUsed = typeof(CROpportunityProductsPricingPXExt.usrIsLastCostUsed)
            };
        }

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(PAUnitCostValueAttribute<CROpportunityProducts.inventoryID, CROpportunityProducts.siteID>))]
        protected virtual void _(Events.CacheAttached<CROpportunityProductsPricingPXExt.usrCuryUnitCost> e) { }

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(PALineCostValueExtAttribute<CROpportunityProducts.inventoryID, CROpportunityProducts.siteID, CROpportunityProductsPricingPXExt.usrCuryExtCost, CROpportunityProducts.quantity>))]
        [PXDependsOnFields(typeof(CROpportunityProducts.inventoryID), typeof(CROpportunityProducts.siteID), typeof(CROpportunityProductsPricingPXExt.usrCuryExtCost), typeof(CROpportunityProducts.quantity))]
        protected virtual void _(Events.CacheAttached<CROpportunityProductsPricingPXExt.usrCuryLineCost> e) { }
    }
}
