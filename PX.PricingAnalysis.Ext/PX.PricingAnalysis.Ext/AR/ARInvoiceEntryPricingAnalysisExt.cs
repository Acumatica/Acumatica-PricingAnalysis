using PX.Objects.AR;
using PX.Data;
using PX.Objects.IN;
using System;
using PX.Objects.CS;
using System.Linq;

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
                CuryPremiumFreightAmt = typeof(ARInvoice.curyPremiumFreightAmt),
                DocType = typeof(ARInvoice.docType)
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
                UnitCost = typeof(ARTranPricingAnalysisPXExt.usrUnitCostFinal),
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
            Coalesce<
            Search<INTran.unitCost, Where<INTran.docType, Equal<INDocType.issue>,
                And<INTran.sOShipmentNbr, Equal<Current<ARTran.sOShipmentNbr>>,
                    And<INTran.sOShipmentLineNbr, Equal<Current<ARTran.sOShipmentLineNbr>>,
                        And<INTran.inventoryID, Equal<Current<ARTran.inventoryID>>>>>>>, Search<INTran.unitCost, Where<INTran.docType, Equal<INDocType.issue>,
                And<INTran.sOOrderNbr, Equal<Current<ARTran.sOOrderNbr>>,
                    And<INTran.sOOrderLineNbr, Equal<Current<ARTran.sOOrderLineNbr>>,
                        And<INTran.inventoryID, Equal<Current<ARTran.inventoryID>>>>>>>
            >>))]
        protected virtual void _(Events.CacheAttached<ARTranPricingAnalysisPXExt.usrUnitCost> e) { }

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(IIf<ARTran.qty.IsGreater<decimal0>, Div<PALineCostValueExtAttribute<ARTran.inventoryID, ARTran.siteID, ARTran.tranCost, ARTran.qty, ARTran.unitCost>, ARTran.qty>, decimal0>))]
        protected virtual void _(Events.CacheAttached<ARTranPricingAnalysisPXExt.usrUnitCostCM> e) { }

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(IIf<ARTran.tranType.FromCurrent.IsNotEqual<ARDocType.creditMemo>,
            ARTranPricingAnalysisPXExt.usrUnitCost, 
            IIf<ARTran.tranCostOrig.IsNotNull.And<ARTran.tranCostOrig.IsNotEqual<decimal0>>, 
                Div<ARTran.tranCostOrig, ARTran.qty>, 
                ARTranPricingAnalysisPXExt.usrUnitCostCM>>))]
        protected virtual void _(Events.CacheAttached<ARTranPricingAnalysisPXExt.usrUnitCostFinal> e) { }

        protected void _(Events.RowSelected<ARInvoice> e)
        {
            PricingAnalysisPreviewHeaderRecs.Cache.AllowSelect = false;
            bool isNewRecord = e?.Row?.RefNbr == " <NEW>";
            PXUIFieldAttribute.SetVisible<ARInvoicePricingAnalysisPXExt.usrAmountTotal>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<ARInvoicePricingAnalysisPXExt.usrCostTotal>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<ARInvoicePricingAnalysisPXExt.usrMarginPercent>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<ARInvoicePricingAnalysisPXExt.usrMarkupPercent>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<ARInvoicePricingAnalysisPXExt.usrProfitTotal>(e.Cache, e.Row, !isNewRecord);
        }
        protected void _(Events.RowSelected<ARTran> e)
        {
            PricingAnalysisPreviewHeaderRecs.Cache.AllowSelect = false;
            bool isNewRecord = e?.Row?.RefNbr == null;
            PXUIFieldAttribute.SetVisible<ARTranPricingAnalysisPXExt.usrUnitCostFinal>(e.Cache, e.Row, !isNewRecord);
        }
        #region Event Handlers

        public virtual void _(Events.FieldSelecting<ARInvoice, ARInvoicePricingAnalysisPXExt.usrAmountTotal> args)
        {
            if (args.ReturnState == null)
            {
                return;
            }
            var row = args.Row;
            var rowExt = row.GetExtension<ARInvoicePricingAnalysisPXExt>();
            decimal? amount = 0;
            decimal? cost = 0;
            var trans = Base.Transactions.Select().FirstTableItems.ToList();
            foreach (ARTran tran in trans)
            {
                if (!tran.IsStockItem.GetValueOrDefault(false) || tran.Qty.GetValueOrDefault(0) <= 0) { continue; }
                var tranExt = tran.GetExtension<ARTranPricingAnalysisPXExt>();
                var inventoryItem = InventoryItem.PK.Find(Base, tran.InventoryID);
                if (tranExt == null) { return; }
                cost += tranExt.UsrUnitCostFinal * tran.Qty;
                amount += tran.CuryTranAmt;
            }
            cost += row.CuryFreightCost;
            amount += row.CuryFreightTot;
            args.ReturnValue = amount;
            rowExt.UsrCostTotal = cost;
            rowExt.UsrProfitTotal = amount - rowExt.UsrCostTotal;
            rowExt.UsrMarkupPercent = (rowExt.UsrCostTotal > 0) ? (rowExt.UsrProfitTotal / rowExt.UsrCostTotal) * 100 : null;
            rowExt.UsrMarginPercent = (amount > 0) ? (rowExt.UsrProfitTotal / amount) * 100 : null;
        }

        #endregion
    }
}