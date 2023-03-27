using System;
using PX.Data;
using PX.Objects.AR;
using PX.Objects.IN;

namespace PX.PricingAnalysis.Ext
{
    public sealed class ARTranPricingAnalysisPXExt : PXCacheExtension<ARTran>
    {

		#region UsrInvtRefNbr
		public abstract class usrInvtRefNbr : PX.Data.BQL.BqlString.Field<usrInvtRefNbr> { }

		[PXString(15, IsUnicode = true)]
		public string UsrInvtRefNbr { get; set; }
		#endregion

		#region UsrUnitCostFinal
		public abstract class usrUnitCostFinal : PX.Data.BQL.BqlDecimal.Field<usrUnitCostFinal> { }

		[PXPriceCost()]
		[PXUIField(DisplayName = "Unit Cost", Enabled = false)]
		public Decimal? UsrUnitCostFinal { get; set; }
		#endregion

		#region UsrUnitCost
		public abstract class usrUnitCost : PX.Data.BQL.BqlDecimal.Field<usrUnitCost> { }

		[PXPriceCost()]
		public Decimal? UsrUnitCost { get; set; }
		#endregion

		#region UsrUnitCostCM
		public abstract class usrUnitCostCM : PX.Data.BQL.BqlDecimal.Field<usrUnitCostCM> { }

		[PXPriceCost()]
		public Decimal? UsrUnitCostCM { get; set; }
		#endregion

	}
}