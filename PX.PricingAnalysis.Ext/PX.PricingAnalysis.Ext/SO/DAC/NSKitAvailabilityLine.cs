using System;
using PX.Data;
using PX.Data.BQL;
using PX.Objects.IN;

namespace PX.PricingAnalysis.Ext
{
	[Serializable]
	[PXHidden]
	public class NSKitAvailabilityLine : IBqlTable
	{
		#region RecordID
		public abstract class recordID : PX.Data.BQL.BqlInt.Field<recordID> { }

		[PXInt(IsKey = true)]
		public virtual int? RecordID { get; set; }
		#endregion

		#region InventoryID
		public abstract class inventoryID : PX.Data.BQL.BqlInt.Field<inventoryID> { }

		public virtual Int32? InventoryID { get; set; }
		#endregion

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

		#region CompQty
		public abstract class compQty : PX.Data.BQL.BqlDecimal.Field<compQty> { }

		[PXDecimal(2)]
		[PXUnboundDefault(TypeCode.Decimal, "0.0")]
		[PXUIField(DisplayName = "Component Qty.", Enabled = false)]
		public virtual Decimal? CompQty { get; set; }
		#endregion

		#region Qty
		public abstract class qty : PX.Data.BQL.BqlDecimal.Field<qty> { }

		[PXDecimal(2)]
		[PXUnboundDefault(TypeCode.Decimal, "0.0")]
		[PXUIField(DisplayName = "Qty.", Enabled = false)]
		public virtual Decimal? Qty { get; set; }
		#endregion

		#region UOM
		public abstract class uOM : PX.Data.BQL.BqlString.Field<uOM> { }

		[PXUIField(DisplayName = "UOM", Enabled = false)]
		public virtual String UOM { get; set; }
		#endregion

		#region AllowQtyVariation
		public abstract class allowQtyVariation : PX.Data.BQL.BqlBool.Field<allowQtyVariation> { }

		[PXBool()]
		[PXUnboundDefault(false)]
		[PXUIField(DisplayName = "Allow Component Qty. Variance", Enabled =false)]
		public virtual Boolean? AllowQtyVariation { get; set; }
		#endregion

		#region MinCompQty
		public abstract class minCompQty : PX.Data.BQL.BqlDecimal.Field<minCompQty> { }

		[PXDecimal(2)]
		[PXUIField(DisplayName = "Min. Component Qty.", Enabled = false)]
		public virtual Decimal? MinCompQty { get; set; }
		#endregion

		#region MaxCompQty
		public abstract class maxCompQty : PX.Data.BQL.BqlDecimal.Field<maxCompQty> { }

		[PXDecimal(2)]
		[PXUIField(DisplayName = "Max. Component Qty.", Enabled = false)]
		public virtual Decimal? MaxCompQty { get; set; }
		#endregion

		#region QtyOnHand
		public abstract class qtyOnHand : BqlDecimal.Field<qtyOnHand> { }

		[PXUIField(DisplayName = "Qty. On Hand", Enabled = false)]
		[PXDecimal(2)]
		[PXUnboundDefault(TypeCode.Decimal, "0.0")]
		public Decimal? QtyOnHand { get; set; }
		#endregion

		#region QtyAvailable
		public abstract class qtyAvailable : BqlDecimal.Field<qtyAvailable> { }

		[PXUIField(DisplayName = "Qty. Available", Enabled = false)]
		[PXDecimal(2)]
		[PXUnboundDefault(TypeCode.Decimal, "0.0")]
		public Decimal? QtyAvailable { get; set; }
		#endregion

		#region IsLimiting
		public abstract class isLimiting : PX.Data.BQL.BqlBool.Field<isLimiting> { }

		[PXBool()]
		[PXUnboundDefault(false)]
		public virtual Boolean? IsLimiting { get; set; }
		#endregion
	}
}