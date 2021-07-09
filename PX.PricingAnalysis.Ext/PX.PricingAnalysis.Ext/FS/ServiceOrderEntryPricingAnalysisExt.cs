using System;
using PX.Data;
using PX.Objects.FS;

namespace PX.PricingAnalysis.Ext
{
    public class ServiceOrderEntryPricingAnalysisExt : PricingAnalysisGraph<ServiceOrderEntry, FSServiceOrder>
    {
        protected override DocumentMapping GetDocumentMapping()
        {
            return new DocumentMapping(typeof(FSServiceOrder))
            {
                NoteID = typeof(FSServiceOrder.noteID),
                UsrEditable = typeof(FSServiceOrderPricingPXExt.usrEditable)
            };
        }

        protected override DocumentLineMapping GetDocumentLineMapping()
        {
            return new DocumentLineMapping(typeof(FSSODet))
            {
                NoteID = typeof(FSSODet.noteID),
                LineNbr = typeof(FSSODet.lineNbr),
                InventoryID = typeof(FSSODet.inventoryID),
                IsStockItem = typeof(FSSODetPricingPXExt.usrPricingEligible),
                UOM = typeof(FSSODet.uOM),
                OrderQty = typeof(FSSODet.estimatedQty),
                CuryDiscAmt = typeof(FSSODet.curyDiscAmt),
                CuryUnitPrice = typeof(FSSODet.curyUnitPrice),
                CuryExtCost = typeof(FSSODetPricingPXExt.usrCuryLineCost),
                CuryLineAmt = typeof(FSSODet.curyBillableTranAmt),
                IsLastCostUsed = typeof(FSSODetPricingPXExt.usrIsLastCostUsed)
            };
        }

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(PALineCostValueExtAttribute<FSSODet.inventoryID, FSSODet.siteID, FSSODetPricingPXExt.usrCuryExtCost, FSSODet.estimatedQty, FSSODet.curyUnitCost>))]
        protected virtual void _(Events.CacheAttached<FSSODetPricingPXExt.usrCuryLineCost> e) { }
    }
}