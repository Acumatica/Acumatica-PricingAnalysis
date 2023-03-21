﻿using System;
using PX.Data;
using PX.Objects.CS;
using PX.Objects.IN;

namespace PX.PricingAnalysis.Ext
{
    public sealed class INOverheadTranPricingAnalysisExt : PXCacheExtension<INOverheadTran>
    {
		#region UsrUnitPrice
		public abstract class usrUnitPrice : PX.Data.BQL.BqlDecimal.Field<usrUnitPrice> { }

		[PXPriceCost()]
		[PXUnboundDefault(TypeCode.Decimal, "0.0", typeof(Search<InventoryItemCurySettings.basePrice, Where<InventoryItemCurySettings.inventoryID, Equal<Current<INOverheadTran.inventoryID>>, And<InventoryItemCurySettings.curyID, Equal<Current<AccessInfo.baseCuryID>>>>>))]
		[PXUIField(DisplayName = "Unit Price", Enabled = false)]
		public Decimal? UsrUnitPrice { get; set; }
		#endregion

		#region UsrAmount
		public abstract class usrAmount : PX.Data.BQL.BqlDecimal.Field<usrAmount> { }

		[PXPriceCost()]
		[PXUnboundDefault(TypeCode.Decimal, "0.00")]
		[PXFormula(typeof(Mult<usrUnitPrice, INOverheadTran.qty>))]
		[PXUIField(DisplayName = "Amount", Enabled = false)]
		public Decimal? UsrAmount { get; set; }
		#endregion

		#region UsrLineCost
		public abstract class usrLineCost : PX.Data.BQL.BqlDecimal.Field<usrLineCost> { }

		[PXPriceCost()]
		[PXUnboundDefault(TypeCode.Decimal, "0.00")]
		[PXUIField(DisplayName = "Cost Amount", Enabled = false)]
		[PXFormula(typeof(Mult<INOverheadTran.unitCost, INOverheadTran.qty>))]
		public Decimal? UsrLineCost { get; set; }
		#endregion

		#region UsrCostAmount
		public abstract class usrCostAmount : PX.Data.BQL.BqlDecimal.Field<usrCostAmount> { }

        [PXPriceCost()]
        [PXUnboundDefault(TypeCode.Decimal, "0.00")]
        [PXUIField(DisplayName = "Cost Amount", Enabled = false)]
		public Decimal? UsrCostAmount { get; set; }
        #endregion

        #region UsrProfitAmount
        public abstract class usrProfitAmount : PX.Data.BQL.BqlDecimal.Field<usrProfitAmount> { }

		[PXPriceCost()]
		[PXUnboundDefault(TypeCode.Decimal, "0.00")]
		[PXFormula(typeof(Sub<usrAmount, usrCostAmount>))]
		[PXUIField(DisplayName = "Profit Amount", Enabled = false)]
		public Decimal? UsrProfitAmount { get; set; }
		#endregion

		#region UsrMarkup
		public abstract class usrMarkup : PX.Data.BQL.BqlDecimal.Field<usrMarkup> { }

		[PXDecimal(2)]
		[PXUnboundDefault(TypeCode.Decimal, "0.00")]
		[PXFormula(typeof(IIf<usrCostAmount.IsNotEqual<decimal0>, Mult<Div<usrProfitAmount, usrCostAmount>, decimal100>, decimal0>))]
		[PXUIField(DisplayName = "Markup %", Enabled = false)]
		public Decimal? UsrMarkup { get; set; }
		#endregion

		#region UsrMargin
		public abstract class usrMargin : PX.Data.BQL.BqlDecimal.Field<usrMargin> { }

		[PXDecimal(2)]
		[PXUnboundDefault(TypeCode.Decimal, "0.00")]
		[PXFormula(typeof(IIf<usrAmount.IsNotEqual<decimal0>, Mult<Div<usrProfitAmount, usrAmount>, decimal100>, decimal0>))]
		[PXUIField(DisplayName = "Margin %", Enabled = false)]
		public Decimal? UsrMargin { get; set; }
		#endregion
	}
}