using System;
using PX.Data;
using PX.Data.BQL;
using PX.Objects.CM;
using PX.Objects.CS;
using PX.Objects.IN;

namespace PX.PricingAnalysis.Ext
{
    public class INKitRegisterPricingAnalysisExt : PXCacheExtension<INKitRegister>
	{
		#region UsrTotalAmount
		public abstract class usrTotalAmount : BqlDecimal.Field<usrTotalAmount> { }

		[PXPriceCost()]
		[PXUnboundDefault(TypeCode.Decimal, "0.00")]
        [PXUIField(DisplayName = "Amount", Enabled = false)]
		public virtual Decimal? UsrTotalAmount { get; set; }
        #endregion

        #region UsrTotalCost
        public abstract class usrTotalCost : BqlDecimal.Field<usrTotalCost> { }

        [PXPriceCost()]
		[PXUnboundDefault(TypeCode.Decimal, "0.00")]
        [PXUIField(DisplayName = "Cost Amount", Enabled = false)]
        public virtual Decimal? UsrTotalCost { get; set; }
        #endregion

        #region UsrProfitAmount
        public abstract class usrProfitAmount : PX.Data.BQL.BqlDecimal.Field<usrProfitAmount> { }

		[PXPriceCost()]
        [PXUIField(DisplayName = "Profit Amount", Enabled = false)]
		public Decimal? UsrProfitAmount { get; set; }
        #endregion

        #region MarkupPercent
        public abstract class markupPercent : PX.Data.BQL.BqlDecimal.Field<markupPercent> { }

        [PXDecimal(2)]
        [PXUIField(DisplayName = "Markup %", Enabled = false)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public virtual decimal? MarkupPercent { get; set; }
        #endregion

        #region MarginPercent
        public abstract class marginPercent : PX.Data.BQL.BqlDecimal.Field<marginPercent> { }

        [PXDecimal(2)]
        [PXUIField(DisplayName = "Margin %", Enabled = false)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public virtual decimal? MarginPercent { get; set; }
        #endregion

        #region MaxQtyOnHand
        public abstract class maxQtyOnHand : BqlDecimal.Field<maxQtyOnHand> { }

        [PXUIField(DisplayName = "Max Qty", Enabled = false)]
        [PXDecimal(2)]
        [PXUnboundDefault(TypeCode.Decimal, "0.0")]
        public virtual Decimal? MaxQtyOnHand { get; set; }
        #endregion
    }
}