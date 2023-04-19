using System;
using PX.Data;
using PX.Objects.AR;
using PX.Objects.IN;

namespace PX.PricingAnalysis.Ext
{
    public sealed class ARTranPricingAnalysisPXExt : PXCacheExtension<ARTran>
    {
		#region UsrAccrueCost
		public abstract class usrAccrueCost : PX.Data.BQL.BqlBool.Field<usrAccrueCost> { }

		[PXBool]
		[PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
		[PXFormula(typeof(Selector<ARTran.inventoryID, InventoryItem.accrueCost>))]
		public bool? UsrAccrueCost { get; set; }
		#endregion

		#region UsrKitItem
		public abstract class usrKitItem : PX.Data.BQL.BqlBool.Field<usrKitItem> { }

		[PXBool]
		[PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
		[PXFormula(typeof(Selector<ARTran.inventoryID, InventoryItem.kitItem>))]
		public bool? UsrKitItem { get; set; }
		#endregion

		#region UsrPricingEligible
		public abstract class usrPricingEligible : PX.Data.BQL.BqlDecimal.Field<usrPricingEligible> { }

		[PXBool]
		[PXUnboundDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
		[PXFormula(typeof(Switch<Case<Where<ARTran.isStockItem, Equal<True>, Or<ARTranPricingAnalysisPXExt.usrAccrueCost, Equal<True>, Or<ARTranPricingAnalysisPXExt.usrKitItem, Equal<True>>>>, True>, False>))]
		public bool? UsrPricingEligible { get; set; }
		#endregion

		#region UsrInvtRefNbr
		public abstract class usrInvtRefNbr : PX.Data.BQL.BqlString.Field<usrInvtRefNbr> { }

		[PXString(15, IsUnicode = true)]
		public string UsrInvtRefNbr { get; set; }
		#endregion

		#region UsrCost
		public abstract class usrCost : PX.Data.BQL.BqlDecimal.Field<usrCost> { }

		/// <summary>
		/// Cost Amount calculated for the Invoice type
		/// </summary>
		[PXPriceCost()]
		public Decimal? UsrCost { get; set; }
		#endregion

		#region UsrCostCM
		public abstract class usrCostCM : PX.Data.BQL.BqlDecimal.Field<usrCostCM> { }

		/// <summary>
		/// Cost Amount calculated for the Credit Memo type
		/// </summary>
		[PXPriceCost()]
		public Decimal? UsrCostCM { get; set; }
		#endregion

		#region UsrCostFinal
		public abstract class usrCostFinal : PX.Data.BQL.BqlDecimal.Field<usrCostFinal> { }

		/// <summary>
		/// Cost Amount calculated using usrCost, usrCost, and curyAccruedCost depending on Invoice type and the isStockItem boolean.
		/// </summary>
		[PXPriceCost()]
		[PXUIField(DisplayName = "Cost Amount", Enabled = false)]
		public Decimal? UsrCostFinal { get; set; }
		#endregion
	}
}