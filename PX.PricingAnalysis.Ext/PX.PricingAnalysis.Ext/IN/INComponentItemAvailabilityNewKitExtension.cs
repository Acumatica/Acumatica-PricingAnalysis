using PX.Data;
using PX.Objects.IN;
using PX.Objects.IN.GraphExtensions.KitAssemblyEntryExt;

namespace PX.PricingAnalysis.Ext
{
	[PXProtectedAccess(typeof(INComponentItemAvailabilityExtension))]
	public abstract class INComponentItemAvailabilityNewKitExtension
		: ItemAvailabilityNewKitExtension<KitAssemblyEntry, INComponentItemAvailabilityExtension, INComponentTran, INComponentTranSplit>
	{
		public static bool IsActive() => true;
	}
}
