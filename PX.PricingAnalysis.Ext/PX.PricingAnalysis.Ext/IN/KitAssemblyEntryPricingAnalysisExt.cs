using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using PX.Data;
using PX.Objects.CS;
using PX.Objects.IN;
using PX.Objects.IN.GraphExtensions.KitAssemblyEntryExt;
using PX.Web.UI;

namespace PX.PricingAnalysis.Ext
{
    public class KitAssemblyEntryPricingAnalysisExt : PXGraphExtension<KitAssemblyEntry>
    {
        public override void Initialize()
        {
            Page page = HttpContext.Current?.Handler as PXPage;
            if (page != null)
            {
                page.Load += Page_Load;
            }
        }

        private void Page_Load(object sender, EventArgs e)
        {
            Page page = (Page)sender;

            PX.Web.UI.PXGrid grdComponents = (PX.Web.UI.PXGrid)ControlHelper.FindControl("componentsGrid", page);
            if (grdComponents != null)
            {
                grdComponents.RowDataBound += (object grdSender, PXGridRowEventArgs erdb) =>
                {
                    var data = ((PX.Data.PXResult)erdb.Row.DataItem).GetItem<INComponentTran>();
                    var dataSpec = ((PX.Data.PXResult)erdb.Row.DataItem).GetItem<INKitSpecStkDet>();
                    var dataExt = data.GetExtension<INComponentTranPricingAnalysisExt>();
                    erdb.Row.Cells["UsrQtyOnHand"].Style.CssClass = ((dataSpec.MinCompQty != null && dataExt.UsrQtyOnHand < dataExt.UsrKitQty.GetValueOrDefault(0) * dataSpec.MinCompQty) ||
                    dataSpec.MinCompQty == null && dataExt.UsrQtyOnHand < dataExt.UsrKitQty.GetValueOrDefault(0) * dataSpec.DfltCompQty) ? "red20" : 
                    (dataSpec.MinCompQty != null && dataExt.UsrQtyOnHand < dataExt.UsrKitQty.GetValueOrDefault(0) * dataSpec.DfltCompQty) ? "yellow20" : "green20";
                    erdb.Row.Cells["UsrQtyAvailable"].Style.CssClass = (dataExt.UsrQtyAvailable < dataExt.UsrKitQty.GetValueOrDefault(0) * dataSpec.DfltCompQty) ? "red20" : "green20";
                }; 
            }
        }

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(PALineCostValueExtAttribute<INComponentTran.inventoryID, INComponentTran.siteID, decimal0, INComponentTran.qty, decimal0>))]
        protected virtual void _(Events.CacheAttached<INComponentTranPricingAnalysisExt.usrCostAmount> e) { }

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(PALineCostValueExtAttribute<INOverheadTran.inventoryID, INOverheadTran.siteID, INOverheadTranPricingAnalysisExt.usrLineCost, INOverheadTran.qty, INOverheadTran.unitCost>))]
        protected virtual void _(Events.CacheAttached<INOverheadTranPricingAnalysisExt.usrCostAmount> e) { }

        #region Event Handlers
        protected void _(Events.RowSelected<INKitRegister> e)
        {
            if (e.Cache == null || e.Row == null) return;
            bool isNewRecord = e.Cache.GetStatus(e.Row) == PXEntryStatus.Inserted;
            PXUIFieldAttribute.SetVisible<INKitRegisterPricingAnalysisExt.usrTotalAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitRegisterPricingAnalysisExt.usrTotalCost>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitRegisterPricingAnalysisExt.usrProfitAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitRegisterPricingAnalysisExt.usrMarkupPercent>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitRegisterPricingAnalysisExt.usrMarginPercent>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitRegisterPricingAnalysisExt.usrMaxQtyOnHand>(e.Cache, e.Row, !isNewRecord);
        }
        protected void _(Events.RowSelected<INComponentTran> e)
        {
            if (e.Cache == null || e.Row == null) return;
            bool isNewRecord = e.Cache.GetStatus(e.Row) == PXEntryStatus.Inserted;
            PXUIFieldAttribute.SetVisible<INComponentTranPricingAnalysisExt.usrAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INComponentTranPricingAnalysisExt.usrCostAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INComponentTranPricingAnalysisExt.usrProfitAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INComponentTranPricingAnalysisExt.usrMargin>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INComponentTranPricingAnalysisExt.usrMarkup>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INComponentTranPricingAnalysisExt.usrQtyOnHand>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INComponentTranPricingAnalysisExt.usrQtyAvailable>(e.Cache, e.Row, !isNewRecord);
        }
        protected void _(Events.RowSelected<INOverheadTran> e)
        {
            if (e.Cache == null || e.Row == null) return;
            bool isNewRecord = e.Cache.GetStatus(e.Row) == PXEntryStatus.Inserted;
            PXUIFieldAttribute.SetVisible<INOverheadTranPricingAnalysisExt.usrAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INOverheadTranPricingAnalysisExt.usrCostAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INOverheadTranPricingAnalysisExt.usrProfitAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INOverheadTranPricingAnalysisExt.usrMargin>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INOverheadTranPricingAnalysisExt.usrMarkup>(e.Cache, e.Row, !isNewRecord);
        }

        public virtual void _(Events.FieldSelecting<INKitRegister, INKitRegisterPricingAnalysisExt.usrMaxQtyOnHand> args)
        {
            if (args.Cache == null || args.Row == null) return;
            INKitRegister row = (INKitRegister)args.Row;
            var rowExt = row.GetExtension<INKitRegisterPricingAnalysisExt>();
            var INKitItemAvailability = this.Base.GetExtension<INComponentItemAvailabilityExtension>();
            var components = Base.Components.Select().FirstTableItems.ToList();
            decimal maxOnHand = decimal.MaxValue;
            foreach (INComponentTran component in components)
            {
                var componentTranExt = component.GetExtension<INComponentTranPricingAnalysisExt>();
                bool exclude = !Base.Document.Current.Released ?? true;
                if (INKitItemAvailability.FetchWithLineUOM(component, exclude) is IStatus availability)
                {
                    componentTranExt.UsrQtyOnHand = availability.QtyOnHand;
                    componentTranExt.UsrQtyAvailable = availability.QtyAvail;
                    INKitSpecStkDet spec = Base.GetComponentSpecByID(component.InventoryID, component.SubItemID);
                    if (spec?.DfltCompQty == null) { continue; }
                    maxOnHand = Math.Min(maxOnHand, (decimal)availability.QtyOnHand / (decimal)spec.DfltCompQty);
                }
                componentTranExt.UsrKitQty = row.Qty;
            }
            maxOnHand = Math.Round(maxOnHand, 2);
            args.ReturnValue = maxOnHand == decimal.MaxValue ? 0 : maxOnHand;
        }

        public virtual void _(Events.FieldSelecting<INKitRegister, INKitRegisterPricingAnalysisExt.usrTotalAmount> args)
        {
            if (args.Cache == null || args.Row == null) return;
            decimal? amount = 0;
            decimal? cost = 0;
            var components = Base.Components.Select().FirstTableItems.ToList();
            foreach (INComponentTran component in components)
            {
                var componentTranExt = component.GetExtension<INComponentTranPricingAnalysisExt>();
                amount += componentTranExt.UsrAmount;
                cost += componentTranExt.UsrCostAmount;
            }
            var overheads = Base.Overhead.Select().FirstTableItems.ToList();
            foreach (INOverheadTran overhead in overheads)
            {
                var componentTranExt = overhead.GetExtension<INOverheadTranPricingAnalysisExt>();
                amount += componentTranExt.UsrAmount;
                cost += componentTranExt.UsrCostAmount;
            }
            args.ReturnValue = amount;
            var row = args.Row;
            var rowExt = row.GetExtension<INKitRegisterPricingAnalysisExt>();
            rowExt.UsrTotalCost = cost;
            rowExt.UsrProfitAmount = amount - rowExt.UsrTotalCost;
            rowExt.UsrMarkupPercent = (rowExt.UsrTotalCost > 0) ? (rowExt.UsrProfitAmount / rowExt.UsrTotalCost) * 100 : null;
            rowExt.UsrMarginPercent = (amount > 0) ? (rowExt.UsrProfitAmount / amount) * 100 : null;
        }

            #endregion
    }
}