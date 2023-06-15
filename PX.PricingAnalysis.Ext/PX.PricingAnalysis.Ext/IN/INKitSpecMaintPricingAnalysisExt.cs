using System;
using PX.Objects.IN;
using PX.Data;
using System.Linq;
using PX.Objects.PO;
using PX.Data.BQL.Fluent;
using PX.Objects.CS;
using PX.Data.BQL;
using System.Web.UI;
using PX.Web.UI;
using System.Web;

namespace PX.PricingAnalysis.Ext
{
	public class INKitSpecMaintPricingAnalysisExt : PXGraphExtension<INKitSpecMaint>
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

            PX.Web.UI.PXGrid grdComponents = (PX.Web.UI.PXGrid)ControlHelper.FindControl("gridStock", page);
            if (grdComponents != null)
            {
                grdComponents.RowDataBound += (object grdSender, PXGridRowEventArgs erdb) =>
                {
                    var data = erdb.Row.DataItem as INKitSpecStkDet;
                    var dataExt = data.GetExtension<INKitSpecStkDetPricingAnalysisExt>();
                    var inventoryItem = InventoryItem.PK.Find(Base, data.CompInventoryID);

                    //if (dataExt.UsrMarkup.GetValueOrDefault(0) == 0M || dataExt.UsrMarkup.GetValueOrDefault(0) < inventoryItem.MinGrossProfitPct.GetValueOrDefault(0))
                    //{
                    //    erdb.Row.Cells["UsrMarkup"].Style.CssClass = "red20";
                    //}
                };
            }

            PX.Web.UI.PXGrid gridNonStock = (PX.Web.UI.PXGrid)ControlHelper.FindControl("gridNonStock", page);
            if (gridNonStock != null)
            {
                gridNonStock.RowDataBound += (object grdSender, PXGridRowEventArgs erdb) =>
                {
                    var data = erdb.Row.DataItem as INKitSpecNonStkDet;
                    var dataExt = data.GetExtension<INKitSpecNonStkDetPricingAnalysisExt>();
                    var inventoryItem = InventoryItem.PK.Find(Base, data.CompInventoryID);

                    //if (dataExt.UsrMarkup.GetValueOrDefault(0) == 0M || dataExt.UsrMarkup.GetValueOrDefault(0) < inventoryItem.MinGrossProfitPct.GetValueOrDefault(0))
                    //{
                    //    erdb.Row.Cells["UsrMarkup"].Style.CssClass = "red20";
                    //}
                };
            }
        }

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(PALineCostValueExtAttribute<INKitSpecStkDet.compInventoryID, INKitSpecStkDetPricingAnalysisExt.usrSiteID, decimal0, INKitSpecStkDet.dfltCompQty, decimal0>))]
        protected virtual void _(Events.CacheAttached<INKitSpecStkDetPricingAnalysisExt.usrCostAmount> e) { }
        
        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(PALineCostValueExtAttribute<INKitSpecNonStkDet.compInventoryID, INKitSpecNonStkDetPricingAnalysisExt.usrSiteID, decimal0, INKitSpecNonStkDet.dfltCompQty, decimal0>))]
        protected virtual void _(Events.CacheAttached<INKitSpecNonStkDetPricingAnalysisExt.usrCostAmount> e) { }

        #region Event Handlers
        protected void _(Events.RowSelected<INKitSpecHdr> e)
        {
            if (e.Cache == null || e.Row == null) return;
            bool isNewRecord = e.Cache.GetStatus(e.Row) == PXEntryStatus.Inserted;
            PXUIFieldAttribute.SetVisible<INKitSpecHdrPricingAnalysisExt.usrTotalAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecHdrPricingAnalysisExt.usrTotalCost>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecHdrPricingAnalysisExt.usrProfitAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecHdrPricingAnalysisExt.usrMarkupPercent>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecHdrPricingAnalysisExt.usrMarginPercent>(e.Cache, e.Row, !isNewRecord);
        }

        protected void _(Events.RowSelected<INKitSpecStkDet> e)
        {
            if (e.Cache == null || e.Row == null) return;
            bool isNewRecord = e.Cache.GetStatus(e.Row) == PXEntryStatus.Inserted;
            PXUIFieldAttribute.SetVisible<INKitSpecStkDetPricingAnalysisExt.usrAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecStkDetPricingAnalysisExt.usrCostAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecStkDetPricingAnalysisExt.usrProfitAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecStkDetPricingAnalysisExt.usrMargin>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecStkDetPricingAnalysisExt.usrMarkup>(e.Cache, e.Row, !isNewRecord);
        }

        protected void _(Events.RowSelected<INKitSpecNonStkDet> e)
        {
            if (e.Cache == null || e.Row == null) return;
            bool isNewRecord = e.Cache.GetStatus(e.Row) == PXEntryStatus.Inserted;
            PXUIFieldAttribute.SetVisible<INKitSpecNonStkDetPricingAnalysisExt.usrAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecNonStkDetPricingAnalysisExt.usrCostAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecNonStkDetPricingAnalysisExt.usrProfitAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecNonStkDetPricingAnalysisExt.usrMargin>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecNonStkDetPricingAnalysisExt.usrMarkup>(e.Cache, e.Row, !isNewRecord);
        }

        public virtual void _(Events.FieldSelecting<INKitSpecHdr, INKitSpecHdrPricingAnalysisExt.usrTotalAmount> args)
        {
            if (args.Cache == null || args.Row == null) return;

            decimal? amount = 0;
            decimal? cost = 0;
            var components = Base.StockDet.Select().FirstTableItems.ToList();
            foreach (INKitSpecStkDet component in components)
            {
                var componentTranExt = component.GetExtension<INKitSpecStkDetPricingAnalysisExt>();
                amount += componentTranExt.UsrAmount;
                cost += componentTranExt.UsrCostAmount;
            }
            var overheads = Base.NonStockDet.Select().FirstTableItems.ToList();
            foreach (INKitSpecNonStkDet overhead in overheads)
            {
                var componentTranExt = overhead.GetExtension<INKitSpecNonStkDetPricingAnalysisExt>();
                var inventoryItem = InventoryItem.PK.Find(Base, overhead.CompInventoryID);

                if (!inventoryItem.AccrueCost.GetValueOrDefault(false)){
                    componentTranExt.UsrCostAmount = 0;
                    componentTranExt.UsrUnitCost = 0;
                    componentTranExt.UsrProfitAmount = componentTranExt.UsrAmount;
                    componentTranExt.UsrUnitProfitAmount = componentTranExt.UsrUnitPrice;
                    componentTranExt.UsrMarkup = 0;
                    componentTranExt.UsrMargin = 100;
                }
                else { cost += componentTranExt.UsrCostAmount; }
                amount += componentTranExt.UsrAmount;
                
            }
            this.amount = amount;
            this.cost = cost;
            this.profit = amount - cost;
            args.ReturnValue = amount;
        }
        public virtual void _(Events.FieldSelecting<INKitSpecHdr, INKitSpecHdrPricingAnalysisExt.usrTotalCost> args)
        {
            args.ReturnValue = cost;
        }
        public virtual void _(Events.FieldSelecting<INKitSpecHdr, INKitSpecHdrPricingAnalysisExt.usrProfitAmount> args)
        {
            args.ReturnValue = profit;
        }
        public virtual void _(Events.FieldSelecting<INKitSpecHdr, INKitSpecHdrPricingAnalysisExt.usrMarkupPercent> args)
        {
            args.ReturnValue = (cost > 0) ? (profit / cost) * 100 : null;
        }
        public virtual void _(Events.FieldSelecting<INKitSpecHdr, INKitSpecHdrPricingAnalysisExt.usrMarginPercent> args)
        {
            args.ReturnValue = (amount > 0) ? (profit / amount) * 100 : null;
        }
        #endregion
    }
}