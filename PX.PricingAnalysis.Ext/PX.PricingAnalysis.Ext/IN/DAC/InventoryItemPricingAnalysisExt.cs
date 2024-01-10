using System;
using PX.Data;
using PX.Objects.IN;

namespace PX.PricingAnalysis.Ext
{
    public sealed class InventoryItemPricingAnalysisExt : PXCacheExtension<InventoryItem>
    {
        public static bool IsActive() => true;

        #region UsrLotSerTrack
        public abstract class usrLotSerTrack : PX.Data.BQL.BqlString.Field<usrLotSerTrack> { }
		
		[PXString(1, IsFixed = true)]
		[PXFormula(typeof(Selector<InventoryItem.lotSerClassID, INLotSerClass.lotSerTrack>))]
		public String UsrLotSerTrack { get; set; }
		#endregion
	}
}