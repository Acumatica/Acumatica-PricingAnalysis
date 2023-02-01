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

		#region UsrUnitCost
		public abstract class usrUnitCost : PX.Data.BQL.BqlDecimal.Field<usrUnitCost> { }

		[PXPriceCost(MinValue = 0)]
		[PXUIField(DisplayName = "Unit Cost", Enabled = false)]
		public Decimal? UsrUnitCost { get; set; }
		#endregion

	}
}