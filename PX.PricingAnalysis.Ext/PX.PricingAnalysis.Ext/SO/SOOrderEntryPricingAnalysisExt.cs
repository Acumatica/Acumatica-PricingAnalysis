using PX.Data;
using PX.Objects.SO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PX.PricingAnalysis.Ext
{
    public class SOOrderEntryPricingAnalysisExt : PricingAnalysisGraph<SOOrderEntry, SOOrder>
    {
        protected override bool CalcFreightPrices => true;

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
                IsStockItem = typeof(SOLinePricingPXExt.usrPricingEligible),
                UOM = typeof(SOLine.uOM),
                OrderQty = typeof(SOLine.orderQty),
                CuryDiscAmt = typeof(SOLine.curyDiscAmt),
                CuryUnitPrice = typeof(SOLine.curyUnitPrice),
                CuryExtCost = typeof(SOLinePricingPXExt.usrCuryLineCost),
                CuryLineAmt = typeof(SOLine.curyLineAmt),
                IsLastCostUsed = typeof(SOLinePricingPXExt.usrIsLastCostUsed)
            };
        }

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(PALineCostValueExtAttribute<SOLine.inventoryID, SOLine.siteID, SOLine.extCost, SOLine.orderQty, SOLine.curyUnitCost>))]
        protected virtual void _(Events.CacheAttached<SOLinePricingPXExt.usrCuryLineCost> e) { }
    }
}