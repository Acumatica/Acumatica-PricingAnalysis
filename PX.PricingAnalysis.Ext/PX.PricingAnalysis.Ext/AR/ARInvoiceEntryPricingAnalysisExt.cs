using PX.Objects.AR;
using PX.Data;
using PX.Objects.IN;
using System;
using System.Collections;
using PX.Objects.CS;
using System.Linq;
using System.Collections.Generic;

namespace PX.PricingAnalysis.Ext
{
    public class ARInvoiceEntryPricingAnalysisExt : PricingAnalysisGraph<ARInvoiceEntry, ARInvoice>
    {
        private decimal? cost = 0;
        private decimal? profit = 0;

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
                PricingEligible = typeof(ARTranPricingAnalysisPXExt.usrPricingEligible),
                UOM = typeof(ARTran.uOM),
                InvtRefNbr = typeof(ARTranPricingAnalysisPXExt.usrInvtRefNbr),
                OrderQty = typeof(ARTran.qty),
                CuryDiscAmt = typeof(ARTran.curyDiscAmt),
                CuryUnitPrice = typeof(ARTran.curyUnitPrice),
                CuryLineAmt = typeof(ARTran.curyTranAmt),
                CuryExtCost = typeof(ARTranPricingAnalysisPXExt.usrCostFinal),
                IsLastCostUsed = typeof(True),
                //nsk
                SiteID = typeof(ARTran.siteID)
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
            Search<INTran.tranCost, Where<INTran.docType, Equal<INDocType.issue>,
                And<INTran.aRRefNbr, Equal<Current<ARTran.refNbr>>,
                    And<INTran.aRLineNbr, Equal<Current<ARTran.lineNbr>>,
                        And<INTran.inventoryID, Equal<Current<ARTran.inventoryID>>>>>>>, 
            Coalesce<
            Search<INTran.tranCost, Where<INTran.docType, Equal<INDocType.issue>,
                And<INTran.sOShipmentNbr, Equal<Current<ARTran.sOShipmentNbr>>,
                    And<INTran.sOShipmentLineNbr, Equal<Current<ARTran.sOShipmentLineNbr>>,
                        And<INTran.inventoryID, Equal<Current<ARTran.inventoryID>>>>>>>, Search<INTran.tranCost, Where<INTran.docType, Equal<INDocType.issue>,
                And<INTran.sOOrderNbr, Equal<Current<ARTran.sOOrderNbr>>,
                    And<INTran.sOOrderLineNbr, Equal<Current<ARTran.sOOrderLineNbr>>,
                        And<INTran.inventoryID, Equal<Current<ARTran.inventoryID>>>>>>>
            >>))]
        protected virtual void _(Events.CacheAttached<ARTranPricingAnalysisPXExt.usrCost> e) { }

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(IIf<ARTran.qty.IsGreater<decimal0>, PALineCostValueExtAttribute<ARTran.inventoryID, ARTran.siteID, ARTran.tranCost, ARTran.qty, ARTran.unitCost>, decimal0>))]
        protected virtual void _(Events.CacheAttached<ARTranPricingAnalysisPXExt.usrCostCM> e) { }

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(IIf<ARTran.tranType.FromCurrent.IsNotEqual<ARDocType.creditMemo>,
            IIf<ARTran.isStockItem.IsEqual<False>.And<ARTranPricingAnalysisPXExt.usrAccrueCost.IsEqual<True>>, ARTran.curyAccruedCost, ARTranPricingAnalysisPXExt.usrCost>, 
            IIf<ARTran.tranCostOrig.IsNotNull.And<ARTran.tranCostOrig.IsNotEqual<decimal0>>,
                ARTran.tranCostOrig, 
                ARTranPricingAnalysisPXExt.usrCostCM>>))]
        protected virtual void _(Events.CacheAttached<ARTranPricingAnalysisPXExt.usrCostFinal> e) { }

        protected void _(Events.RowSelected<ARInvoice> e)
        {
            PricingAnalysisPreviewHeaderRecs.Cache.AllowSelect = false;
            if (e.Cache == null || e.Row == null) return;
            bool isNewUnreleased = e.Cache.GetStatus(e.Row) == PXEntryStatus.Inserted
                || e.Row.Status == ARDocStatus.Hold || e.Row.Status == ARDocStatus.Balanced;
            PXUIFieldAttribute.SetVisible<ARInvoicePricingAnalysisPXExt.usrCostTotal>(e.Cache, e.Row, !isNewUnreleased);
            PXUIFieldAttribute.SetVisible<ARInvoicePricingAnalysisPXExt.usrMarginPercent>(e.Cache, e.Row, !isNewUnreleased);
            PXUIFieldAttribute.SetVisible<ARInvoicePricingAnalysisPXExt.usrMarkupPercent>(e.Cache, e.Row, !isNewUnreleased);
            PXUIFieldAttribute.SetVisible<ARInvoicePricingAnalysisPXExt.usrProfitTotal>(e.Cache, e.Row, !isNewUnreleased);
        }
        protected void _(Events.RowSelected<ARTran> e)
        {
            PricingAnalysisPreviewHeaderRecs.Cache.AllowSelect = false;
            if (e.Cache == null || e.Row == null) return;
            bool isNewRecord = e.Cache.GetStatus(e.Row) == PXEntryStatus.Inserted;
            PXUIFieldAttribute.SetVisible<ARTranPricingAnalysisPXExt.usrCostFinal>(e.Cache, e.Row, !isNewRecord);
        }
        #region Event Handlers

        public virtual void _(Events.FieldSelecting<ARInvoice, ARInvoicePricingAnalysisPXExt.usrCostTotal> args)
        {
            if (args.Cache == null || args.Row == null) return;
            var row = args.Row;
            var rowExt = row.GetExtension<ARInvoicePricingAnalysisPXExt>();
            decimal? cost = 0;
            var trans = Base.Transactions.Select().FirstTableItems.ToList();
            foreach (ARTran tran in trans)
            {
                var tranExt = tran.GetExtension<ARTranPricingAnalysisPXExt>();
                if (tran.Qty.GetValueOrDefault(0) <= 0) { continue; }
                var inventoryItem = InventoryItem.PK.Find(Base, tran.InventoryID);
                if (tranExt == null) { return; }

                //NSK
                if (!inventoryItem.StkItem.GetValueOrDefault(false) && inventoryItem.KitItem.GetValueOrDefault(false) && tranExt.UsrInvtRefNbr != null)
                {
                    tranExt.UsrCostFinal = 0;
                    decimal? kitCost = 0;
                    foreach (INTran component in PXSelect<INTran, Where<INTran.refNbr, Equal<Required<INTran.refNbr>>,
                        And<INTran.docType, Equal<INDocType.issue>, And<INTran.aRLineNbr, Equal<Required<INTran.aRLineNbr>>>>>>.
                                                            SelectMultiBound(Base, null, tranExt.UsrInvtRefNbr, tran.LineNbr))
                    {
                        kitCost += component.TranCost;
                    }
                    foreach (INKitSpecNonStkDet det in PXSelect<INKitSpecNonStkDet, Where<INKitSpecNonStkDet.kitInventoryID, Equal<Required<INKitSpecNonStkDet.kitInventoryID>>>>.
                                                            SelectMultiBound(Base, null, tran.InventoryID))
                    {
                        var detItem = InventoryItem.PK.Find(Base, det.CompInventoryID);
                        if (!detItem.AccrueCost.GetValueOrDefault(false))
                        {
                            INKitSpecNonStkDetPricingAnalysisExt detExt = det.GetExtension<INKitSpecNonStkDetPricingAnalysisExt>();
                            detExt.UsrCostAmount = 0;
                            continue;
                        }
                        var a = new PALineCostValueExtAttribute<INKitSpecNonStkDet.compInventoryID, ARTran.siteID, decimal0, INKitSpecNonStkDet.dfltCompQty, decimal0>();
                        Dictionary<Type, object> d = new Dictionary<Type, object>();
                        d.Add(typeof(INKitSpecNonStkDet.compInventoryID), det.CompInventoryID);
                        d.Add(typeof(ARTran.siteID), tran.SiteID);
                        d.Add(typeof(decimal0), 0m);
                        d.Add(typeof(INKitSpecNonStkDet.dfltCompQty), det.DfltCompQty);
                        var value = a.Evaluate(args.Cache, tran, d);
                        kitCost += (decimal?)value * tran.Qty.GetValueOrDefault(0);
                    }
                    tranExt.UsrCostFinal = kitCost;
                }
                //NSK

                cost += tranExt.UsrPricingEligible.GetValueOrDefault(false) ? tranExt.UsrCostFinal : 0;
            }
            cost += row.CuryFreightCost;
            this.cost = cost;
            this.profit = row.CuryLineTotal - cost;
            args.ReturnValue = cost;
        }
        public virtual void _(Events.FieldSelecting<ARInvoice, ARInvoicePricingAnalysisPXExt.usrProfitTotal> args)
        {
            args.ReturnValue = profit;
        }
        public virtual void _(Events.FieldSelecting<ARInvoice, ARInvoicePricingAnalysisPXExt.usrMarkupPercent> args)
        {
            args.ReturnValue = (cost > 0) ? (profit / cost) * 100 : null;
        }
        public virtual void _(Events.FieldSelecting<ARInvoice, ARInvoicePricingAnalysisPXExt.usrMarginPercent> args)
        {
            if (args.Cache == null || args.Row == null) return;
            var row = args.Row;
            args.ReturnValue = (row.CuryLineTotal.GetValueOrDefault(0) > 0) ? (profit / row.CuryLineTotal * 100) : null;
        }
        #endregion
    }
}