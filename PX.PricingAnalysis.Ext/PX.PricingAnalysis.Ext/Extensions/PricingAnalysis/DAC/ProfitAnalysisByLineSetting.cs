using System;
using PX.Data;

namespace PX.PricingAnalysis.Ext
{
    [Serializable]
    [PXHidden]
    public class ProfitAnalysisByLineSetting : IBqlTable
    {
		public abstract class inventoryID : PX.Data.BQL.BqlInt.Field<inventoryID> { }
		public virtual int? InventoryID { get; set; }

		#region InventoryIDDisplay
		public abstract class inventoryIDDisplay : PX.Data.BQL.BqlString.Field<inventoryIDDisplay> { }
		[PXString]
		[PXUIField(DisplayName = "Inventory", Enabled = false)]
		public virtual String InventoryIDDisplay { get; set; }
		#endregion

		#region InventoryDescription
		public abstract class inventoryDescription : PX.Data.BQL.BqlString.Field<inventoryDescription> { }
		[PXString]
		[PXUIField(DisplayName = "Description", Enabled = false)]
		public virtual String InventoryDescription { get; set; }
		#endregion

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