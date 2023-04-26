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
        private decimal? amount = 0;
        private decimal? cost = 0;
        private decimal? profit = 0;

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
                    erdb.Row.Cells["UsrQtyOnHand"].Style.CssClass = (dataExt.UsrQtyOnHand < data.Qty) ? "red20" : 
                    (dataExt.UsrQtyActual < data.Qty) ? "yellow20" : erdb.Row.Cells["UsrQtyOnHand"].Style.CssClass;
                    erdb.Row.Cells["UsrQtyAvailable"].Style.CssClass = (dataExt.UsrQtyOnHand < data.Qty) ? "red20" : erdb.Row.Cells["UsrQtyAvailable"].Style.CssClass;
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
                    componentTranExt.UsrQtyActual = availability.QtyActual;

                    INKitSpecStkDet spec = Base.GetComponentSpecByID(component.InventoryID, component.SubItemID);
                    if (spec?.DfltCompQty == null) { continue; }
                    maxOnHand = Math.Min(maxOnHand, (decimal)availability.QtyOnHand / (decimal)spec.DfltCompQty);
                }
            }
            maxOnHand = Math.Floor(maxOnHand);
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
            this.amount = amount;
            this.cost = cost;
            this.profit = amount - cost;
            args.ReturnValue = amount;
        }
        public virtual void _(Events.FieldSelecting<INKitRegister, INKitRegisterPricingAnalysisExt.usrTotalCost> args)
        {
            args.ReturnValue = cost;
        }
        public virtual void _(Events.FieldSelecting<INKitRegister, INKitRegisterPricingAnalysisExt.usrProfitAmount> args)
        {
            args.ReturnValue = profit;
        }
        public virtual void _(Events.FieldSelecting<INKitRegister, INKitRegisterPricingAnalysisExt.usrMarkupPercent> args)
        {
            args.ReturnValue = (cost > 0) ? (profit / cost) * 100 : null;
        }
        public virtual void _(Events.FieldSelecting<INKitRegister, INKitRegisterPricingAnalysisExt.usrMarginPercent> args)
        {
            args.ReturnValue = (amount > 0) ? (profit / amount) * 100 : null;
        }

        #endregion
    }
}