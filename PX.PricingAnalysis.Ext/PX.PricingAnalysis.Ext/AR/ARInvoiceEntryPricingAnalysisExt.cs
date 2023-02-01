using PX.Objects.AR;
using PX.Data;
using PX.Objects.IN;
using System;
using PX.Objects.SO;

namespace PX.PricingAnalysis.Ext
{
    public class ARInvoiceEntryPricingAnalysisExt : PricingAnalysisGraph<ARInvoiceEntry, ARInvoice>
    {
        protected override bool CalcFreightPrices => true;

        protected override bool PreviewOnly => true;

        protected override DocumentMapping GetDocumentMapping()
        {
            return new DocumentMapping(typeof(ARInvoice))
            {
                NoteID = typeof(ARInvoice.noteID),
                CuryFreightTot = typeof(ARInvoice.curyFreightTot),
                CuryFreightAmt = typeof(ARInvoice.curyFreightAmt),
                CuryFreightCost = typeof(ARInvoice.curyFreightCost),
                CuryPremiumFreightAmt = typeof(ARInvoice.curyPremiumFreightAmt)
            };
        }

        protected override DocumentLineMapping GetDocumentLineMapping()
        {
            return new DocumentLineMapping(typeof(ARTran))
            {
                NoteID = typeof(ARTran.noteID),
                LineNbr = typeof(ARTran.lineNbr),
                InventoryID = typeof(ARTran.inventoryID),
                IsStockItem = typeof(ARTran.isStockItem),
                UOM = typeof(ARTran.uOM),
                InvtRefNbr = typeof(ARTranPricingAnalysisPXExt.usrInvtRefNbr),
                UnitCost = typeof(ARTranPricingAnalysisPXExt.usrUnitCost),
                OrderQty = typeof(ARTran.qty),
                CuryDiscAmt = typeof(ARTran.curyDiscAmt),
                CuryUnitPrice = typeof(ARTran.curyUnitPrice),
                CuryLineAmt = typeof(ARTran.curyTranAmt),
                IsLastCostUsed = typeof(True)
            };
        }

        public PXAction<PricingAnalysisPreviewLine> PricingAnalysisPreviewLineViewIssue;
        [PXButton]
        [PXUIField(Visibility = PXUIVisibility.Invisible)]
        protected virtual void pricingAnalysisPreviewLineViewIssue()
        {
            PricingAnalysisPreviewLine row = PricingAnalysisPreview.Current;
            if(row.InvtRefNbr == null) { return; }
            // Creating the instance of the graph
            INIssueEntry graph = PXGraph.CreateInstance<INIssueEntry>();
            // Setting the current product for the graph
            graph.issue.Current = graph.issue.Search<INRegister.refNbr>(row.InvtRefNbr);
            // If the product is found by its ID, throw an exception to open
            // a new window (tab) in the browser
            if (graph.issue.Current != null)
            {
                throw new PXRedirectRequiredException(graph, true, "Issues") { Mode = PXBaseRedirectException.WindowMode.NewWindow };
            }
        }

        //BUG IN AR010717
        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXUnboundDefault(typeof(Coalesce<
            Search<INTran.refNbr, Where<INTran.docType, Equal<INDocType.issue>, And<INTran.aRRefNbr, Equal<Current<ARTran.refNbr>>>>>,
            Coalesce<Search<INTran.refNbr, Where<INTran.docType, Equal<INDocType.issue>, And<INTran.sOShipmentNbr, Equal<Current<ARTran.sOShipmentNbr>>>>>,
                Search<INTran.refNbr, Where<INTran.docType, Equal<INDocType.issue>, And<INTran.sOOrderNbr, Equal<Current<ARTran.sOOrderNbr>>>>>>>))]
        protected virtual void _(Events.CacheAttached<ARTranPricingAnalysisPXExt.usrInvtRefNbr> e) { }

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0", typeof(Coalesce<
            Search<INTran.unitCost, Where<INTran.docType, Equal<INDocType.issue>,
                And<INTran.aRRefNbr, Equal<Current<ARTran.refNbr>>,
                    And<INTran.aRLineNbr, Equal<Current<ARTran.lineNbr>>,
                        And<INTran.inventoryID, Equal<Current<ARTran.inventoryID>>>>>>>,
            Search<INTran.unitCost, Where<INTran.docType, Equal<INDocType.issue>,
                And<INTran.sOShipmentNbr, Equal<Current<ARTran.sOShipmentNbr>>,
                    And<INTran.sOShipmentLineNbr, Equal<Current<ARTran.sOShipmentLineNbr>>,
                        And<INTran.inventoryID, Equal<Current<ARTran.inventoryID>>>>>>>>))]
        protected virtual void _(Events.CacheAttached<ARTranPricingAnalysisPXExt.usrUnitCost> e) { }
    }
}