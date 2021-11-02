using System;

namespace TestFreightPrice.CalculationMethods
{
    public class Calculate
    {
        public decimal CalculateUnitPrice(decimal Amount, decimal Qty)
        {
            decimal UnitPrice = Amount / Qty;
            decimal UnitPriceNew = Math.Round(UnitPrice, 2);
            return UnitPriceNew;
        }
        public decimal CalculateAmount(decimal UnitPrice, decimal Qty)
        {
            decimal Amount = UnitPrice * Qty;
            return Amount;
        }
        public decimal CalculateFreightUnitPrice(decimal FreightPrice, decimal PremFreightPrice)
        {
            decimal UnitPrice = FreightPrice + PremFreightPrice;
            return UnitPrice;
        }

        public decimal CalculateProfitAmount(decimal Amount, decimal CostAmount)
        {
            decimal ProfitAmount = Amount - CostAmount;
            return ProfitAmount;
        }
        public decimal CalculateMarkup(decimal Amount, decimal CostAmount)
        {
            decimal Markup = ((Amount - CostAmount) / CostAmount) * 100;
            decimal MarkupNew = Math.Round(Markup, 2);
            return MarkupNew;
        }
        public decimal CalculateMargin(decimal Amount, decimal CostAmount)
        {
            decimal Margin = ((Amount - CostAmount) / Amount) * 100;
            decimal MarginNew = Math.Round(Margin, 2);
            return MarginNew;
        }
        public decimal CalculateSummaryTotals(decimal value1, decimal value2)
        {
            decimal SummaryTotal = value1 + value2;
            return SummaryTotal;
        }
        public decimal CalculateFreightPrice(decimal UnitPrice, decimal PremFreightPrice)
        {
            decimal FreightPrice = UnitPrice - PremFreightPrice;
            return FreightPrice;
        }
    }
}
