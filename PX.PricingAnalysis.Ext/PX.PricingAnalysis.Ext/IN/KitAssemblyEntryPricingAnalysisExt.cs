using System;
using System.Linq;
using PX.Data;
using PX.Objects.CS;
using PX.Objects.IN;
using PX.Objects.IN.GraphExtensions.KitAssemblyEntryExt;

namespace PX.PricingAnalysis.Ext
{
    public class KitAssemblyEntryPricingAnalysisExt : PXGraphExtension<KitAssemblyEntry>
    {

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(PALineCostValueExtAttribute<INComponentTran.inventoryID, INComponentTran.siteID, decimal0, INComponentTran.qty, decimal0>))]
        protected virtual void _(Events.CacheAttached<INComponentTranPricingAnalysisExt.usrCostAmount> e) { }

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(PALineCostValueExtAttribute<INOverheadTran.inventoryID, INOverheadTran.siteID, INOverheadTranPricingAnalysisExt.usrLineCost, INOverheadTran.qty, INOverheadTran.unitCost>))]
        protected virtual void _(Events.CacheAttached<INOverheadTranPricingAnalysisExt.usrCostAmount> e) { }

        #region Event Handlers
        public virtual void _(Events.FieldSelecting<INKitRegister, INKitRegisterPricingAnalysisExt.maxQtyOnHand> args)
        {
            INKitRegister row = (INKitRegister)args.Row;
            if (row == null) { return; }
            var rowExt = row.GetExtension<INKitRegisterPricingAnalysisExt>();
            if (rowExt == null) { return; }
            var INKitItemAvailability = this.Base.GetExtension<INComponentItemAvailabilityExtension>();
            var components = Base.Components.Select().FirstTableItems.ToList();
            decimal maxOnHand = decimal.MaxValue;
            decimal maxAvailable = decimal.MaxValue;
            foreach (INComponentTran component in components)
                {
                    bool exclude = !Base.Document.Current.Released ?? true;
                    if (INKitItemAvailability.FetchWithLineUOM(component, exclude) is IStatus availability)
                    {
                        INKitSpecStkDet spec = Base.GetComponentSpecByID(component.InventoryID, component.SubItemID);
                        if (spec?.DfltCompQty == null) { continue; }
                        maxOnHand = Math.Min(maxOnHand, (decimal)availability.QtyOnHand / (decimal)spec.DfltCompQty);
                        maxAvailable = Math.Min(maxAvailable, (decimal)availability.QtyAvail / (decimal)spec.DfltCompQty);
                    }
                }
            maxOnHand = Math.Round(maxOnHand, 2);
            maxAvailable = Math.Round(maxAvailable, 2);
            args.ReturnValue = maxOnHand == decimal.MaxValue ? 0 : maxOnHand;
            rowExt.MaxQtyAvailable = maxAvailable == decimal.MaxValue ? 0 : maxAvailable;
        }

        public virtual void _(Events.FieldSelecting<INKitRegister, INKitRegisterPricingAnalysisExt.usrTotalAmount> args)
        {
            if (args.ReturnState == null)
            {
                return;
            }
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
            rowExt.MarkupPercent = (rowExt.UsrTotalCost > 0) ? (rowExt.UsrProfitAmount / rowExt.UsrTotalCost) * 100 : null;
            rowExt.MarginPercent = (amount > 0) ? (rowExt.UsrProfitAmount / amount) * 100 : null;
        }

        #endregion
    }
}