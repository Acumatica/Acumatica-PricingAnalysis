using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PX.Data;
using PX.Objects.IN;
using PX.Objects.SO;
using PX.Web.UI;

namespace PX.PricingAnalysis.Ext
{
    public class SOOrderEntryPricingAnalysisExt : PricingAnalysisGraph<SOOrderEntry, SOOrder>
    {

        protected override bool CalcFreightPrices => true;

        string QtyOnHand = "";

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

        public virtual void _(Events.RowSelected<SOOrder> args)
        {
            if (args.Cache == null || args.Row == null) return;

            var trans = Base.Transactions.Select().FirstTableItems.ToList();
            string orderStatus = null;

            foreach (SOLine tran in trans)
            {
                var tranExt = tran.GetExtension<SOLinePricingPXExt>();
                var inventoryItem = InventoryItem.PK.Find(Base, tran.InventoryID);
                if (tranExt.UsrIsNonStockKit.GetValueOrDefault(false))
                {
                    tranExt.UsrQtyAvailable = "View";
                    tranExt.UsrQtyOnHand = "View";
                }
                else if (inventoryItem.StkItem.GetValueOrDefault(false))
                {
                    INSiteStatus data = PXSelect<INSiteStatus, Where<INSiteStatus.inventoryID, Equal<Required<SOLine.inventoryID>>,
                                                            And<INSiteStatus.siteID, Equal<Required<SOLine.siteID>>>>>
                                                            .SelectWindowed(this.Base, 0, 1, tran.InventoryID, tran.SiteID);
                    decimal available = data.QtyAvail.GetValueOrDefault(0);
                    if (orderStatus == null)
                    {
                        SOOrder order = SOOrder.PK.Find(Base, tran.OrderType, tran.OrderNbr);
                        orderStatus = order?.Status;
                    }

                    available += (orderStatus == SOOrderStatus.Open || orderStatus == null) ? tran.OrderQty.GetValueOrDefault(0) : 0;
                    tranExt.UsrQtyAvailable = available.ToString("0.00");
                    tranExt.UsrQtyOnHand = data.QtyOnHand.GetValueOrDefault(0).ToString("0.00");

                }
            }
        }

        public PXAction<NSKitAvailabilityLine> MyPanelLineItemAvailability;
        [PXLookupButton()]
        [PXUIField(Visibility = PXUIVisibility.Invisible)]
        protected virtual void myPanelLineItemAvailability()
        {
            PXCache tCache = MyPanelLine.Cache;
            NSKitAvailabilityLine line = MyPanelLine.Current;
            SOLine SOLine = Base.Transactions.Current;

            if (line == null) return;

            InventoryItem item = InventoryItem.PK.Find(Base, line.InventoryID);
            if (item != null && item.StkItem == true)
            {
                INSubItem sbitem = (INSubItem)PXSelectorAttribute.Select<InventoryItem.defaultSubItemID>(tCache, item);

                InventoryAllocDetEnq.Redirect(item.InventoryID,
                                             null,
                                             null,
                                             SOLine.SiteID,
                                             SOLine.LocationID,
                                             PXBaseRedirectException.WindowMode.New);
            }
        }

        public PXAction<SOLine> KitAvailability;
        [PXButton(CommitChanges = false)]
        [PXUIField(DisplayName = "Non-Stock Kit Availability", Enabled = false)]
        public virtual void kitAvailability()
        {
            if (Base?.Transactions?.Current == null) { return; }
            if (Base.Transactions.Current.IsStockItem.GetValueOrDefault(false))
            {
                Base.itemAvailability.Press();
                return;
            }
            if (!Base.Transactions.Current.IsKit.GetValueOrDefault(false)) { return; }
            Base.Persist();

            MyPanel.Cache.Clear();
            MyPanelLine.Cache.Clear();
            MyPanel.ClearDialog();
            InitializeAvailability();

            if (MyPanel.AskExtFullyValid((graph, viewName) =>
            {
                MyPanel.Cache.Clear();
                MyPanel.Cache.ClearQueryCache();
                MyPanelLine.Cache.Clear();
                MyPanelLine.Cache.ClearQueryCache();

            }, DialogAnswerType.Positive, true))
            {
                return;
            }
        }


        public PXFilter<NSKitAvailabilityHeader> MyPanel;
        public PXFilter<NSKitAvailabilityLine> MyPanelLine;

        #region ViewDelegates

        public IEnumerable myPanel()
        {
            InitializeAvailability();
            return MyPanel.Cache.Cached;
        }

        public IEnumerable myPanelLine()
        {
            InitializeAvailability();
            return (IEnumerable<NSKitAvailabilityLine>)MyPanelLine.Cache.Cached;
        }

        public virtual void InitializeAvailability()
        {
            SOLine currentLine = (SOLine)Base.Transactions.Current;
            if (currentLine == null) { return; }
            int iRecordCounter = 0;
            decimal maxQty = int.MaxValue;
            var dets = PXSelect<INKitSpecStkDet, Where<INKitSpecStkDet.kitInventoryID, Equal<Required<INKitSpecStkDet.kitInventoryID>>>>.
                                                            SelectMultiBound(Base, null, currentLine.InventoryID);
            foreach (INKitSpecStkDet det in dets)
            {
                INSiteStatus data = PXSelect<INSiteStatus, Where<INSiteStatus.inventoryID, Equal<Required<INSiteStatus.inventoryID>>,
                                                        And<INSiteStatus.siteID, Equal<Required<INSiteStatus.siteID>>>>>
                                                        .SelectWindowed(this.Base, 0, 1, det.CompInventoryID, currentLine.SiteID);
                decimal tempQty = Math.Floor((decimal)data.QtyAvail / (decimal)det.DfltCompQty);
                if (maxQty > tempQty)
                {
                    maxQty = tempQty;
                }
            }
            foreach (INKitSpecStkDet det in dets)
            {
                INSiteStatus data = PXSelect<INSiteStatus, Where<INSiteStatus.inventoryID, Equal<Required<INSiteStatus.inventoryID>>,
                                                        And<INSiteStatus.siteID, Equal<Required<INSiteStatus.siteID>>>>>
                                                        .SelectWindowed(this.Base, 0, 1, det.CompInventoryID, currentLine.SiteID);
                bool isLimiting = false;
                decimal tempQty = Math.Floor((decimal)data.QtyAvail / (decimal)det.DfltCompQty);
                if (maxQty == tempQty)
                {
                    isLimiting = true;
                }
                var inventoryItem = InventoryItem.PK.Find(Base, det.CompInventoryID);
                NSKitAvailabilityLine line = new NSKitAvailabilityLine()
                {
                    RecordID = iRecordCounter++,
                    InventoryID = det.CompInventoryID,
                    InventoryIDDisplay = inventoryItem.InventoryCD,
                    InventoryDescription = inventoryItem.Descr,
                    UOM = det.UOM,
                    Qty = currentLine.Qty * det.DfltCompQty,
                    CompQty = det.DfltCompQty,
                    AllowQtyVariation = det.AllowQtyVariation,
                    MinCompQty = det.MinCompQty,
                    MaxCompQty = det.MaxCompQty,
                    QtyOnHand = data.QtyOnHand,
                    QtyAvailable = data.QtyAvail,
                    IsLimiting = isLimiting,
                };
                line = MyPanelLine.Insert(line);
                MyPanelLine.Cache.SetStatus(line, PXEntryStatus.Held);
            }

            NSKitAvailabilityHeader header = MyPanel.Current;
            header.UsrMaxQty = maxQty == decimal.MaxValue ? 0 : maxQty;
            header.UsrOrderQty = currentLine.OrderQty;
            MyPanel.Update(header);
        }
        #endregion
    }
}