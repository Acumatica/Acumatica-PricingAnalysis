using System;
using PX.Data;

namespace PX.PricingAnalysis.Ext
{
    [Serializable]
    [PXHidden]
    public class ProfitAnalysisByDocSetting : PXBqlTable, IBqlTable
    {
		public abstract class breakupByHidden : PX.Data.BQL.BqlString.Field<breakupByHidden> { }

		[PXDBString(2, IsFixed = true, IsUnicode = false)]
		[PXDefault(typeof(Search<ARSetupPricingAnalysisPXExt.usrDefPricingType>))]
		public virtual String BreakupByHidden { get; set; }

		public abstract class breakupBy : PX.Data.BQL.BqlString.Field<breakupBy> { }

		[PXDBString(2, IsFixed = true, IsUnicode = false)]
		[BreakupBy.List]
		[PXUIField(DisplayName = "Break up by")]
		[PXDefault(typeof(Switch<Case<Where<ProfitAnalysisByDocSetting.breakupByHidden, IsNotNull>,
									ProfitAnalysisByDocSetting.breakupByHidden>, BreakupBy.markup>))]
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
