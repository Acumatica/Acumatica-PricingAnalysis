using System;
using PX.Data;
using PX.Objects.FS;
using PX.Objects.IN;

namespace PX.PricingAnalysis.Ext
{
    public class AppointmentEntryPricingAnalysisPXExt : PricingAnalysisGraph<AppointmentEntry, FSAppointment>
    {
        protected override DocumentMapping GetDocumentMapping()
        {
            return new DocumentMapping(typeof(FSAppointment))
            {
                NoteID = typeof(FSAppointment.noteID),
                UsrEditable = typeof(FSAppointmentPricingPXExt.usrEditable)
            };
        }

        protected override DocumentLineMapping GetDocumentLineMapping()
        {
            return new DocumentLineMapping(typeof(FSAppointmentDet))
            {
                NoteID = typeof(FSAppointmentDet.noteID),
                LineNbr = typeof(FSAppointmentDet.lineNbr),
                InventoryID = typeof(FSAppointmentDet.inventoryID),
                IsStockItem = typeof(FSAppointmentDetPricingPXExt.usrPricingEligible),
                UOM = typeof(FSAppointmentDet.uOM),
                OrderQty = typeof(FSAppointmentDet.estimatedQty),
                CuryDiscAmt = typeof(FSAppointmentDet.curyDiscAmt),
                CuryUnitPrice = typeof(FSAppointmentDet.curyUnitPrice),
                CuryExtCost = typeof(FSAppointmentDetPricingPXExt.usrCuryLineCost),
                CuryLineAmt = typeof(FSAppointmentDet.curyBillableTranAmt),
                IsLastCostUsed = typeof(FSAppointmentDetPricingPXExt.usrIsLastCostUsed)
            };
        }

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXFormula(typeof(PALineCostValueExtAttribute<FSAppointmentDet.inventoryID, FSAppointmentDet.siteID, FSAppointmentDet.extCost, FSAppointmentDet.estimatedQty, FSAppointmentDet.curyUnitCost>))]
        protected virtual void _(Events.CacheAttached<FSAppointmentDetPricingPXExt.usrCuryLineCost> e) { }

        [PXMergeAttributes(Method = MergeMethod.Append)]
        [PXUnboundDefault(typeof(Search<INItemStats.qtyOnHand,
                                    Where<INItemStats.inventoryID, Equal<Current<FSAppointmentDet.inventoryID>>,
                                        And<INItemStats.siteID, Equal<Current<FSAppointmentDet.siteID>>>>>), PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Default<FSSODet.inventoryID, FSSODet.siteID>))]
        protected virtual void _(Events.CacheAttached<FSAppointmentDetPricingPXExt.usrQtyOnHand> e) { }
    }
}