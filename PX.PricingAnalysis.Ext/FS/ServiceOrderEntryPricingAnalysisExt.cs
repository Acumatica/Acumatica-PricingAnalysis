using System;
using PX.Data;
using PX.Objects.FS;
using PX.Objects.IN;

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
                PricingEligible = typeof(FSSODetPricingPXExt.usrPricingEligible),
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

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXUnboundDefault(typeof(Search<INItemStats.qtyOnHand,
                                    Where<INItemStats.inventoryID, Equal<Current<FSSODet.inventoryID>>,
                                        And<INItemStats.siteID, Equal<Current<FSSODet.siteID>>>>>), PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Default<FSSODet.inventoryID, FSSODet.siteID>))]
        protected virtual void _(Events.CacheAttached<FSSODetPricingPXExt.usrQtyOnHand> e) { }
    }
}