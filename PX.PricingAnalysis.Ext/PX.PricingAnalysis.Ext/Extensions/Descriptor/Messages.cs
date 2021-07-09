using System;
using PX.Common;

namespace PX.PricingAnalysis.Ext
{
	[PXLocalizable(Messages.Prefix)]
	public static class Messages
	{
		public const string Prefix = "Pricing Analysis Error";

		public const string Margin = "Margin";
		public const string Markup = "Markup";

		public const string CurrentLine = "Line";
		public const string Document = "Document";
		public const string InvalidMargin = "Margin cannot be equal to or greater than 100 %. Please input a lower value.";

		public const string CurrentLineType = "Current";
		public const string PreviewLineType = "Preview";

		public const string PriceAdjustmentType = "Price";
		public const string DiscountAdjustmentType = "Discount";

		public const string CurrentHeaderInfoType = "Current Totals";
		public const string PreviewHeaderInfoType = "Preview Totals";
	}
}