using System;
using PX.Common;
using PX.Data;
using PX.Objects.IN;
using PX.Objects.IN.GraphExtensions;

namespace PX.PricingAnalysis.Ext
{
	public abstract class ItemAvailabilityNewKitExtension<TGraph, TItemAvailExt, TLine, TSplit> : PXGraphExtension<TItemAvailExt, TGraph>
		where TGraph : PXGraph
		where TItemAvailExt : ItemAvailabilityExtension<TGraph, TLine, TSplit>
		where TLine : class, IBqlTable, ILSPrimary, new()
		where TSplit : class, IBqlTable, ILSDetail, new()
	{
		protected TItemAvailExt ItemAvailBase => Base1;

		protected static bool UseKitAvailability => true;

		#region Overrides

		/// Overrides <see cref="ItemAvailabilityExtension{TGraph, TLine, TSplit}.Fetch(ILSDetail, bool)"/>x	
		[PXOverride]
		public virtual IStatus Fetch(ILSDetail split, bool excludeCurrent, Func<ILSDetail, bool, IStatus> base_Fetch)
		{
            using (NewKitScope())
            {
				if (!_newKit)
					return base_Fetch(split, excludeCurrent);

				if (split == null || split.InventoryID == null || split.SubItemID == null || split.SiteID == null)
					return null;

				INLotSerClass lsClass =
					InventoryItem.PK.Find(Base, split.InventoryID)
					.With(ii => ii.StkItem == true ? INLotSerClass.PK.Find(Base, ii.LotSerClassID) : null);

				if (lsClass?.LotSerTrack == null)
					return null;

				if (_detailsRequested++ == DetailsCountToEnableOptimization)
					Optimize();

				if (split.LocationID != null)
				{
					if (string.IsNullOrEmpty(split.LotSerialNbr) == false &&
						(string.IsNullOrEmpty(split.AssignedNbr) || INLotSerialNbrAttribute.StringsEqual(split.AssignedNbr, split.LotSerialNbr) == false) &&
						lsClass.LotSerAssign == INLotSerAssign.WhenReceived &&
						lsClass.LotSerTrack != INLotSerTrack.SerialNumbered)
					{
						return FetchLotSerial(split, excludeCurrent);
					}

					return FetchLocation(split, excludeCurrent);
				}

				return FetchSite(split, excludeCurrent);
			}
		}

        #endregion

        #region NewKitScope
        protected IDisposable NewKitScope() => new PX.Objects.Common.SimpleScope(
			onOpen: () => _newKit = true,
			onClose: () => _newKit = false);
		private bool _newKit;
		#endregion

		#region Protected Access

		/// Uses <see cref="ItemAvailabilityExtension{TGraph, TLine, TSplit}.FetchLotSerial(ILSDetail, bool)"/>
		[PXProtectedAccess] protected abstract IStatus FetchLotSerial(ILSDetail split, bool excludeCurrent);

		/// Uses <see cref="ItemAvailabilityExtension{TGraph, TLine, TSplit}.FetchLocation(ILSDetail, bool)"/>
		[PXProtectedAccess] protected abstract IStatus FetchLocation(ILSDetail split, bool excludeCurrent);

		/// Uses <see cref="ItemAvailabilityExtension{TGraph, TLine, TSplit}.FetchSite(ILSDetail, bool)"/>
		[PXProtectedAccess] protected abstract IStatus FetchSite(ILSDetail split, bool excludeCurrent);

		/// Uses <see cref="ItemAvailabilityExtension{TGraph, TLine, TSplit}.Optimize()"/>
		[PXProtectedAccess] protected abstract void Optimize();

		[PXProtectedAccess] protected int _detailsRequested { get; set; }

		[PXProtectedAccess] protected abstract int DetailsCountToEnableOptimization { get; }

		#endregion
	}
}
