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
        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(PALineCostValueExtAttribute<INComponentTran.inventoryID, INComponentTran.siteID, decimal0, INComponentTran.qty, decimal0>))]
        protected virtual void _(Events.CacheAttached<INComponentTranPricingAnalysisExt.usrCostAmount> e) { }

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(PALineCostValueExtAttribute<INOverheadTran.inventoryID, INOverheadTran.siteID, INOverheadTranPricingAnalysisExt.usrLineCost, INOverheadTran.qty, INOverheadTran.unitCost>))]
        protected virtual void _(Events.CacheAttached<INOverheadTranPricingAnalysisExt.usrCostAmount> e) { }

        #region Event Handlers
        protected void _(Events.RowSelected<INKitRegister> e)
        {
            bool isNewRecord = e?.Row?.RefNbr == " <NEW>";
            PXUIFieldAttribute.SetVisible<INKitRegisterPricingAnalysisExt.usrTotalAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitRegisterPricingAnalysisExt.usrTotalCost>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitRegisterPricingAnalysisExt.usrProfitAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitRegisterPricingAnalysisExt.markupPercent>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitRegisterPricingAnalysisExt.marginPercent>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INKitRegisterPricingAnalysisExt.maxQtyOnHand>(e.Cache, e.Row, !isNewRecord);
        }
        protected void _(Events.RowSelected<INComponentTran> e)
        {
            bool isNewRecord = e?.Row?.RefNbr == null;
            
            PXUIFieldAttribute.SetVisible<INComponentTranPricingAnalysisExt.usrAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INComponentTranPricingAnalysisExt.usrCostAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INComponentTranPricingAnalysisExt.usrProfitAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INComponentTranPricingAnalysisExt.usrMargin>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INComponentTranPricingAnalysisExt.usrMarkup>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INComponentTranPricingAnalysisExt.qtyOnHand>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INComponentTranPricingAnalysisExt.qtyAvailable>(e.Cache, e.Row, !isNewRecord);
        }
        protected void _(Events.RowSelected<INOverheadTran> e)
        {
            bool isNewRecord = e?.Row?.RefNbr == null;
            PXUIFieldAttribute.SetVisible<INOverheadTranPricingAnalysisExt.usrAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INOverheadTranPricingAnalysisExt.usrCostAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INOverheadTranPricingAnalysisExt.usrProfitAmount>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INOverheadTranPricingAnalysisExt.usrMargin>(e.Cache, e.Row, !isNewRecord);
            PXUIFieldAttribute.SetVisible<INOverheadTranPricingAnalysisExt.usrMarkup>(e.Cache, e.Row, !isNewRecord);
        }

        public virtual void _(Events.FieldSelecting<INKitRegister, INKitRegisterPricingAnalysisExt.maxQtyOnHand> args)
        {
            INKitRegister row = (INKitRegister)args.Row;
            if (row == null) { return; }
            var rowExt = row.GetExtension<INKitRegisterPricingAnalysisExt>();
            if (rowExt == null) { return; }
            var INKitItemAvailability = this.Base.GetExtension<INComponentItemAvailabilityExtension>();
            var components = Base.Components.Select().FirstTableItems.ToList();
            decimal maxOnHand = decimal.MaxValue;
            foreach (INComponentTran component in components)
                {
                    bool exclude = !Base.Document.Current.Released ?? true;
                    if (INKitItemAvailability.FetchWithLineUOM(component, exclude) is IStatus availability)
                    {
                        var componentTranExt = component.GetExtension<INComponentTranPricingAnalysisExt>();
                        componentTranExt.QtyOnHand = availability.QtyOnHand;
                        componentTranExt.QtyAvailable = availability.QtyAvail;
                        INKitSpecStkDet spec = Base.GetComponentSpecByID(component.InventoryID, component.SubItemID);
                        if (spec?.DfltCompQty == null) { continue; }
                        maxOnHand = Math.Min(maxOnHand, (decimal)availability.QtyOnHand / (decimal)spec.DfltCompQty);
                    }
                }
            maxOnHand = Math.Round(maxOnHand, 2);
            args.ReturnValue = maxOnHand == decimal.MaxValue ? 0 : maxOnHand;
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