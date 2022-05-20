using System;
using PX.Data;
using PX.Objects.FS;
using PX.Objects.IN;
using static PX.Objects.FS.SharedClasses;

namespace PX.PricingAnalysis.Ext
{
    public sealed class FSSODetPricingPXExt : PXCacheExtension<FSSODet>
    {
		#region UsrCuryExtCost
		public abstract class usrCuryExtCost : PX.Data.BQL.BqlDecimal.Field<usrCuryExtCost> { }

		[PXPriceCost]
		[PXUIField(DisplayName = "Line Cost", Enabled = false)]
		[PXUnboundDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
		[PXFormula(typeof(Switch<Case<Where<FSSODet.estimatedQty, IsNotNull, And<FSSODet.curyUnitCost, IsNotNull>>, 
							Mult<FSSODet.curyUnitCost, FSSODet.estimatedQty>>, decimal_0>))]
		[PXDependsOnFields(typeof(FSSODet.curyUnitCost), typeof(FSSODet.estimatedQty))]
		public Decimal? UsrCuryExtCost { get; set; }
        #endregion

        #region UsrAccrueCost
        public abstract class usrAccrueCost : PX.Data.BQL.BqlDecimal.Field<usrAccrueCost> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Selector<FSSODet.inventoryID, InventoryItem.accrueCost>))]
        public bool? UsrAccrueCost { get; set; }
        #endregion

        #region UsrPricingEligible
        public abstract class usrPricingEligible : PX.Data.BQL.BqlDecimal.Field<usrPricingEligible> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Switch<Case<Where<FSSODet.isStockItem, Equal<True>, Or<FSSODetPricingPXExt.usrAccrueCost, Equal<True>>>, True>, False>))]
        public bool? UsrPricingEligible { get; set; }
        #endregion

        #region UsrCuryLineCost
        public abstract class usrCuryLineCost : PX.Data.BQL.BqlDecimal.Field<usrCuryLineCost> { }

        [PXPriceCost]
        [PXUIField(DisplayName = "Line Cost (For Pricing)", Enabled = false)]
        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        public Decimal? UsrCuryLineCost { get; set; }
        #endregion

        #region UsrQtyOnHand
        public abstract class usrQtyOnHand : PX.Data.BQL.BqlDecimal.Field<usrQtyOnHand> { }

        [PXQuantity()]
        [PXFormula(typeof(Selector<FSSODet.siteID, INItemStats.qtyOnHand>))]
        [PXFormula(typeof(Default<FSSODet.inventoryID, FSSODet.siteID>))]
        public Decimal? UsrQtyOnHand { get; set; }
        #endregion

        #region UsrIsLastCostUsed
        public abstract class usrIsLastCostUsed : PX.Data.BQL.BqlDecimal.Field<usrIsLastCostUsed> { }

        [PXBool]
        [PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXFormula(typeof(Switch<Case<Where<FSSODetPricingPXExt.usrQtyOnHand, IsNull, Or<FSSODetPricingPXExt.usrQtyOnHand, Equal<Objects.CS.decimal0>>>, True>, False>))]
        public bool? UsrIsLastCostUsed { get; set; }
        #endregion
    }
}