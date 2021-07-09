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
        protected override DocumentMapping GetDocumentMapping()
        {
            return new DocumentMapping(typeof(SOOrder))
            {
                NoteID = typeof(SOOrder.noteID),
                UsrEditable = typeof(SOOrderPricingPXExt.usrEditable)
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