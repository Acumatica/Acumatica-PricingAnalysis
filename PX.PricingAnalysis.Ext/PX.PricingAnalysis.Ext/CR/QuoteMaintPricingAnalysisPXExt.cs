using System;
using PX.Data;
using PX.Objects.CM;
using PX.Objects.CR;
using PX.Objects.IN;

namespace PX.PricingAnalysis.Ext
{
    public class QuoteMaintPricingAnalysisPXExt : PricingAnalysisGraph<QuoteMaint, CRQuote>
    {
        protected override DocumentMapping GetDocumentMapping()
        {
            return new DocumentMapping(typeof(CRQuote))
            {
                NoteID = typeof(CRQuote.noteID),
                UsrEditable = typeof(CRQuotePricingPXExt.usrEditable)
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
    }
}