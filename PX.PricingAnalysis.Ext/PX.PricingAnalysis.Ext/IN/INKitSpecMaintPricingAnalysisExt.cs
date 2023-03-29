using System;
using PX.Objects.IN;
using PX.Data;
using System.Linq;
using PX.Objects.PO;
using PX.Data.BQL.Fluent;
using PX.Objects.CS;
using PX.Data.BQL;

namespace PX.PricingAnalysis.Ext
{
	public class INKitSpecMaintPricingAnalysisExt : PXGraphExtension<INKitSpecMaint>
	{

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(PALineCostValueExtAttribute<INKitSpecStkDet.compInventoryID, INKitSpecStkDetPricingAnalysisExt.usrSiteID, decimal0, INKitSpecStkDet.dfltCompQty, decimal0>))]
        protected virtual void _(Events.CacheAttached<INKitSpecStkDetPricingAnalysisExt.usrCostAmount> e) { }
        
        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(PALineCostValueExtAttribute<INKitSpecNonStkDet.compInventoryID, INKitSpecNonStkDetPricingAnalysisExt.usrSiteID, decimal0, INKitSpecNonStkDet.dfltCompQty, decimal0>))]
        protected virtual void _(Events.CacheAttached<INKitSpecNonStkDetPricingAnalysisExt.usrCostAmount> e) { }

        #region Event Handlers
        protected void _(Events.RowSelected<INKitSpecHdr> e)
        {
            bool isNewRecord = e?.Row?.KitInventoryID == null || e?.Row?.RevisionID == null;
            PXUIFieldAttribute.SetVisible<INKitSpecHdrPricingAnalysisExt.usrTotalAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecHdrPricingAnalysisExt.usrTotalCost>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecHdrPricingAnalysisExt.usrProfitAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecHdrPricingAnalysisExt.markupPercent>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecHdrPricingAnalysisExt.marginPercent>(e.Cache, e.Row, !isNewRecord);
        }

        protected void _(Events.RowSelected<INKitSpecStkDet> e)
        {
            bool isNewRecord = e?.Row?.KitInventoryID == null || e?.Row?.RevisionID == null;

            PXUIFieldAttribute.SetVisible<INKitSpecStkDetPricingAnalysisExt.usrAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecStkDetPricingAnalysisExt.usrCostAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecStkDetPricingAnalysisExt.usrProfitAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecStkDetPricingAnalysisExt.usrMargin>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecStkDetPricingAnalysisExt.usrMarkup>(e.Cache, e.Row, !isNewRecord);
        }

        protected void _(Events.RowSelected<INKitSpecNonStkDet> e)
        {
            bool isNewRecord = e?.Row?.KitInventoryID == null || e?.Row?.RevisionID == null;

            PXUIFieldAttribute.SetVisible<INKitSpecNonStkDetPricingAnalysisExt.usrAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecNonStkDetPricingAnalysisExt.usrCostAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecNonStkDetPricingAnalysisExt.usrProfitAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecNonStkDetPricingAnalysisExt.usrMargin>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitSpecNonStkDetPricingAnalysisExt.usrMarkup>(e.Cache, e.Row, !isNewRecord);
        }

        public virtual void _(Events.FieldSelecting<INKitSpecHdr, INKitSpecHdrPricingAnalysisExt.usrTotalAmount> args)
        {
            if (args.ReturnState == null)
            {
                return;
            }
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
                amount += componentTranExt.UsrAmount;
                cost += componentTranExt.UsrCostAmount;
            }
            args.ReturnValue = amount;
            var row = args.Row;
            var rowExt = row.GetExtension<INKitSpecHdrPricingAnalysisExt>();
            rowExt.UsrTotalCost = cost;
            rowExt.UsrProfitAmount = amount - rowExt.UsrTotalCost;
            rowExt.MarkupPercent = (rowExt.UsrTotalCost > 0) ? (rowExt.UsrProfitAmount / rowExt.UsrTotalCost) * 100 : null;
            rowExt.MarginPercent = (amount > 0) ? (rowExt.UsrProfitAmount / amount) * 100 : null;
        }

        #endregion
    }
}