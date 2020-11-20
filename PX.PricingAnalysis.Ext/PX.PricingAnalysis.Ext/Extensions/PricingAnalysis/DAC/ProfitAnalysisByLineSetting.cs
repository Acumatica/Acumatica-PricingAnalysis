using System;
using PX.Data;
using PX.Objects.CS;
using PX.Objects.IN;

namespace PX.PricingAnalysis.Ext
{
    [Serializable]
    [PXHidden]
    public class ProfitAnalysisByLineSetting : IBqlTable
    {
		public abstract class inventoryID : PX.Data.BQL.BqlInt.Field<inventoryID> { }

		[AnyInventory(typeof(Search<InventoryItem.inventoryID, 
								Where<InventoryItem.stkItem, NotEqual<boolFalse>, And<Where<Match<Current<AccessInfo.userName>>>>>>),
					  typeof(InventoryItem.inventoryCD), typeof(InventoryItem.descr))]
		[PXUIField(DisplayName = "Inventory")]
		public virtual int? InventoryID { get; set; }

		public abstract class breakupByHidden : PX.Data.BQL.BqlString.Field<breakupByHidden> { }

		[PXDBString(2, IsFixed = true, IsUnicode = false)]
		[PXDefault(typeof(Search<ARSetupPricingAnalysisPXExt.usrDefPricingType>))]
		public virtual String BreakupByHidden { get; set; }

		public abstract class breakupBy : PX.Data.BQL.BqlString.Field<breakupBy> { }

        [PXDBString(2, IsFixed = true, IsUnicode = false)]
		[BreakupBy.List]
		[PXUIField(DisplayName = "Break up by")]
		[PXDefault(typeof(Switch<Case<Where<ProfitAnalysisByLineSetting.breakupByHidden, IsNotNull>, 
									ProfitAnalysisByLineSetting.breakupByHidden>, BreakupBy.markup>))]
		public virtual String BreakupBy { get; set; }

		public abstract class startValue : PX.Data.BQL.BqlInt.Field<startValue> { }

		[PXDBInt(MinValue = 1)]
		[PXUIField(DisplayName = "Start")]
		[PXDefault(10)]
		public virtual int? StartValue { get; set; }

		public abstract class incrementValue : PX.Data.BQL.BqlInt.Field<incrementValue> { }

		[PXDBInt(MinValue = 1)]
		[PXUIField(DisplayName = "Step")]
		[PXDefault(2)]
		public virtual int? IncrementValue { get; set; }
	}
}