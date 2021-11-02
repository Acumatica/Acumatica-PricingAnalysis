using Core.TestExecution;
using FreightPrice.Extensions;
using TestFreightPrice.CalculationMethods;
using TestFreightPrice.Tests;

namespace FreightPrice.Tests
{
    public class TestFreightPriceChanges : FreightPriceBase
    {    
        public override void Execute()
        {
            // Test Case 1
            using (TestExecution.CreateTestCaseGroup("Verify Freight Current Line Values"))
            {
                // Create Prerequisites
                using (TestExecution.CreateTestStepGroup("Create Prerequisites"))
                {
                    // Process Financial Periods
                    ProcessFinancialPeriods();

                    // Setup Account Receivable Preferences
                    SetupARPreferences();

                    // Create Customer Class
                    CreateCustomerClass();

                    // Create Customer
                    CreateCustomer();

                    // Create Item Class
                    CreateItemClass();

                    // Create Inventory Item
                    CreateInventoryItem();

                    // Create Vendor Class
                    CreateVendorClass();

                    // Create Vendor
                    CreateVendor();

                    // Create Purchase Receipt
                    CreatePurchaseReceipt();

                    // Create Sales Order
                    CreateSalesOrder();
                }

                // Navigate to the Pricing Analysis Panel
                using (TestExecution.CreateTestStepGroup("Navigate to the Pricing Analysis Panel"))
                {
                    SalesOrder.SOToolBar.PricingAnalysis.Click();
                }

                // Select Freight Current Line
                using (TestExecution.CreateTestStepGroup("Select Freight Current Line"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.SelectRow(SalesOrder.SOPricingProfitPreviewGrid.Columns.InventoryIDDisplay,GeneralTestData.FreightInvID); 
                }

                //Validate Inventory ID
                using (TestExecution.CreateTestStepGroup("Validate Inventory ID"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.Row.InventoryIDDisplay.GetValue().VerifyEquals(GeneralTestData.FreightInvID);
                }

                // Validate Description
                using (TestExecution.CreateTestStepGroup("Validate Description"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.Row.InventoryDescription.GetValue().VerifyEquals(GeneralTestData.FreightDesc);
                }

                // Validate UOM
                using (TestExecution.CreateTestStepGroup("Validate UOM"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.Row.UOM.GetValue().VerifyEquals(GeneralTestData.FreightUOM);
                }

                // Validate Quantity
                using (TestExecution.CreateTestStepGroup("Validate Quantity"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.Row.OrderQtyDisplay.GetValue().VerifyEquals(GeneralTestData.FreightQty);
                }

                // Validate Unit Price
                using (TestExecution.CreateTestStepGroup("Validate Unit Price"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryUnitPrice.GetValue().VerifyEquals(Calculate.CalculateFreightUnitPrice(SalesOrderEntity.CuryFreightAmt, SalesOrderEntity.CuryPremiumFreightAmt));
                }

                // Validate Discount Amount
                using (TestExecution.CreateTestStepGroup("Validate Discount Amount"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryDiscAmt.GetValue().VerifyEquals(GeneralTestData.FreightDiscAmt);
                }

                // Validate Amount
                using (TestExecution.CreateTestStepGroup("Validate Amount"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue().VerifyEquals(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryUnitPrice.GetValue());
                }

                // Validate Cost Amount
                using (TestExecution.CreateTestStepGroup("Validate Cost Amount"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryExtCostDisplay.GetValue().VerifyEquals(SalesOrderEntity.CuryFreightCost);
                }

                // Validate Profit Amount
                using (TestExecution.CreateTestStepGroup("Validate Profit Amount"))
                {
                    FCLineAmt = decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue());
                    FCLineCostAmt = decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryExtCostDisplay.GetValue());
                    FCLineQty = decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.OrderQtyDisplay.GetValue());
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryProfit.GetValue().VerifyEquals(Calculate.CalculateProfitAmount(FCLineAmt, FCLineCostAmt));
                }

                // Validate Markup%
                using (TestExecution.CreateTestStepGroup("Validate Markup%"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.Row.MarkupPercent.GetValue().VerifyEquals(Calculate.CalculateMarkup(FCLineAmt, FCLineCostAmt));
                }

                // Validate Margin%
                using (TestExecution.CreateTestStepGroup("Validate Margin%"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.Row.MarginPercent.GetValue().VerifyEquals(Calculate.CalculateMargin(FCLineAmt, FCLineCostAmt));
                }
            }

            // Test Case 2
            using (TestExecution.CreateTestCaseGroup("Verify Default Freight Preview Line Values"))
            {
                // Select Freight Preview Line
                using (TestExecution.CreateTestStepGroup("Select Freight Preview Line"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.SelectRow(4);
                }

                // Validate Unit Price
                using (TestExecution.CreateTestStepGroup("Validate Unit Price"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryUnitPrice.GetValue().VerifyEquals(Calculate.CalculateFreightUnitPrice(SalesOrderEntity.CuryFreightAmt, SalesOrderEntity.CuryPremiumFreightAmt));
                }

                // Validate Discount Amount
                using (TestExecution.CreateTestStepGroup("Validate Discount Amount"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryDiscAmt.GetValue().VerifyEquals(GeneralTestData.FreightDiscAmt);
                }

                // Validate Amount
                using (TestExecution.CreateTestStepGroup("Validate Amount"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue().VerifyEquals(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryUnitPrice.GetValue());
                }

                // Validate Profit Amount
                using (TestExecution.CreateTestStepGroup("Validate Profit Amount"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryProfit.GetValue().VerifyEquals(Calculate.CalculateProfitAmount(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue()), FCLineCostAmt));
                }

                // Validate Markup%
                using (TestExecution.CreateTestStepGroup("Validate Markup%"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.Row.MarkupPercent.GetValue().VerifyEquals(Calculate.CalculateMarkup(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue()), FCLineCostAmt));
                }

                // Validate Margin%
                using (TestExecution.CreateTestStepGroup("Validate Margin%"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.Row.MarginPercent.GetValue().VerifyEquals(Calculate.CalculateMargin(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue()), FCLineCostAmt));
                }
            }

            // Test Case 3
            using (TestExecution.CreateTestCaseGroup("Verify Current Total Values in Summary Area"))
            {
                // Validate Current Amount Total
                using (TestExecution.CreateTestStepGroup("Validate Current Amount Total"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.SelectRow(1);
                    LineAmount1 = decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue());
                    SalesOrder.SOPricingProfitPreviewGrid.SelectRow(3);
                    LineAmount2 = decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue());
                    SalesOrder.SOPricingAnalysisSummary.SelectRow(1);
                    SalesOrder.SOPricingAnalysisSummary.Row.CuryAmountTotal.GetValue().VerifyEquals(Calculate.CalculateSummaryTotals(LineAmount1, LineAmount2));
                }

                // Validate Current Cost Total
                using (TestExecution.CreateTestStepGroup("Validate Current Cost Total"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.SelectRow(1);
                    LineCost1 = decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryExtCostDisplay.GetValue());
                    SalesOrder.SOPricingProfitPreviewGrid.SelectRow(3);
                    LineCost2 = decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryExtCostDisplay.GetValue());
                    SalesOrder.SOPricingAnalysisSummary.SelectRow(1);
                    SalesOrder.SOPricingAnalysisSummary.Row.CuryExtCostTotal.GetValue().VerifyEquals(Calculate.CalculateSummaryTotals(LineCost1, LineCost2));
                }

                // Validate Current Total Profit
                using (TestExecution.CreateTestStepGroup("Validate Current Total Profit"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.SelectRow(1);
                    LineProfit1 = decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryProfit.GetValue());
                    SalesOrder.SOPricingProfitPreviewGrid.SelectRow(3);
                    LineProfit2 = decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryProfit.GetValue());
                    SalesOrder.SOPricingAnalysisSummary.SelectRow(1);
                    SalesOrder.SOPricingAnalysisSummary.Row.CuryProfitTotal.GetValue().VerifyEquals(Calculate.CalculateSummaryTotals(LineProfit1, LineProfit2));
                }
                 // Validate Current Total Markup%
                using (TestExecution.CreateTestStepGroup("Validate Current Total Markup%"))
                {
                     SalesOrder.SOPricingAnalysisSummary.Row.MarkupPercent.GetValue().VerifyEquals(Calculate.CalculateMarkup(decimal.Parse(SalesOrder.SOPricingAnalysisSummary.Row.CuryAmountTotal.GetValue()), decimal.Parse(SalesOrder.SOPricingAnalysisSummary.Row.CuryExtCostTotal.GetValue())));
                }

                 // Validate Current Total Margin%
                using (TestExecution.CreateTestStepGroup("Validate Current Total Margin%"))
                {
                        SalesOrder.SOPricingAnalysisSummary.Row.MarginPercent.GetValue().VerifyEquals(Calculate.CalculateMargin(decimal.Parse(SalesOrder.SOPricingAnalysisSummary.Row.CuryAmountTotal.GetValue()), decimal.Parse(SalesOrder.SOPricingAnalysisSummary.Row.CuryExtCostTotal.GetValue())));
                }
            }
        
            // Test Case 4
            using (TestExecution.CreateTestCaseGroup("Verify Freight Preview Line Updated Based on the User Adjustments"))
            {
                // Select Freight Preview Line
                using (TestExecution.CreateTestStepGroup("Select Freight Preview Line"))
                {
                   SalesOrder.SOPricingProfitPreviewGrid.SelectRow(4);
                }

                    // Adjust Unit Price Value and Validate other values
                    using (TestExecution.CreateTestStepGroup("Adjust Unit Price Value and Validate other values"))
                    {

                        SalesOrder.SOPricingProfitPreviewGrid.Row.CuryUnitPrice.Type(250);
                        SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue().VerifyEquals(Calculate.CalculateAmount(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryUnitPrice.GetValue()), FCLineQty));
                        SalesOrder.SOPricingProfitPreviewGrid.Row.CuryProfit.GetValue().VerifyEquals(Calculate.CalculateProfitAmount(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue()), FCLineCostAmt));
                        SalesOrder.SOPricingProfitPreviewGrid.Row.MarkupPercent.GetValue().VerifyEquals(Calculate.CalculateMarkup(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue()), FCLineCostAmt));
                        SalesOrder.SOPricingProfitPreviewGrid.Row.MarginPercent.GetValue().VerifyEquals(Calculate.CalculateMargin(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue()), FCLineCostAmt));
                    }

                    // Adjust Amount Value and Validate other values
                    using (TestExecution.CreateTestStepGroup("Adjust Amount Value and Validate other values"))
                    {
                        SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.Type(260);
                        SalesOrder.SOPricingProfitPreviewGrid.Row.CuryUnitPrice.GetValue().VerifyEquals(Calculate.CalculateUnitPrice(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue()), FCLineQty));
                        SalesOrder.SOPricingProfitPreviewGrid.Row.CuryProfit.GetValue().VerifyEquals(Calculate.CalculateProfitAmount(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue()), FCLineCostAmt));
                        SalesOrder.SOPricingProfitPreviewGrid.Row.MarkupPercent.GetValue().VerifyEquals(Calculate.CalculateMarkup(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue()), FCLineCostAmt));
                        SalesOrder.SOPricingProfitPreviewGrid.Row.MarginPercent.GetValue().VerifyEquals(Calculate.CalculateMargin(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue()), FCLineCostAmt));
                    }

                    // Adjust Profit Amount Value and Validate other values
                    using (TestExecution.CreateTestStepGroup("Adjust Profit Amount Value and Validate other values"))
                    {
                        SalesOrder.SOPricingProfitPreviewGrid.Row.CuryProfit.Type(100);
                        SalesOrder.SOPricingProfitPreviewGrid.Row.CuryUnitPrice.GetValue().VerifyEquals(Calculate.CalculateUnitPrice(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue()), FCLineQty));
                        SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue().VerifyEquals(Calculate.CalculateAmount(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryUnitPrice.GetValue()), FCLineQty));
                        SalesOrder.SOPricingProfitPreviewGrid.Row.MarkupPercent.GetValue().VerifyEquals(Calculate.CalculateMarkup(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue()), FCLineCostAmt));
                        SalesOrder.SOPricingProfitPreviewGrid.Row.MarginPercent.GetValue().VerifyEquals(Calculate.CalculateMargin(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue()), FCLineCostAmt));
                    }

                    // Adjust Markup% Value and Validate other values
                    using (TestExecution.CreateTestStepGroup("Adjust Markup% Value and Validate other values"))
                    {
                        SalesOrder.SOPricingProfitPreviewGrid.Row.MarkupPercent.Type(50);
                        SalesOrder.SOPricingProfitPreviewGrid.Row.CuryUnitPrice.GetValue().VerifyEquals(Calculate.CalculateUnitPrice(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue()), FCLineQty));
                        SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue().VerifyEquals(Calculate.CalculateAmount(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryUnitPrice.GetValue()), FCLineQty));
                        SalesOrder.SOPricingProfitPreviewGrid.Row.CuryProfit.GetValue().VerifyEquals(Calculate.CalculateProfitAmount(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue()), FCLineCostAmt));
                        SalesOrder.SOPricingProfitPreviewGrid.Row.MarginPercent.GetValue().VerifyEquals(Calculate.CalculateMargin(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue()), FCLineCostAmt));
                    }

                    // Adjust Margin% Value and Validate other values
                    using (TestExecution.CreateTestStepGroup("Adjust Margin% Value and Validate other values"))
                    {
                        SalesOrder.SOPricingProfitPreviewGrid.Row.MarginPercent.Type(40);
                        SalesOrder.SOPricingProfitPreviewGrid.Row.CuryUnitPrice.GetValue().VerifyEquals(Calculate.CalculateUnitPrice(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue()), FCLineQty));
                        SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue().VerifyEquals(Calculate.CalculateAmount(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryUnitPrice.GetValue()), FCLineQty));
                        SalesOrder.SOPricingProfitPreviewGrid.Row.CuryProfit.GetValue().VerifyEquals(Calculate.CalculateProfitAmount(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue()), FCLineCostAmt));
                        SalesOrder.SOPricingProfitPreviewGrid.Row.MarkupPercent.GetValue().VerifyEquals(Calculate.CalculateMarkup(decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue()), FCLineCostAmt));
                    }

                    // Validate Discount Amount is disabled
                    using (TestExecution.CreateTestStepGroup("Validate Discount Amount is disabled"))
                    {
                        SalesOrder.SOPricingProfitPreviewGrid.Row.CuryDiscAmt.IsEnabled().VerifyEquals(false);
                    }
                }

            // Test Case 5
            using (TestExecution.CreateTestCaseGroup("Verify Preview Total Values in Summary Area"))
                {

                    // Validate Preview Amount Total
                    using (TestExecution.CreateTestStepGroup("Validate Preview Amount Total"))
                    {
                        SalesOrder.SOPricingProfitPreviewGrid.SelectRow(2);
                        LineAmount1 = decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue());
                        SalesOrder.SOPricingProfitPreviewGrid.SelectRow(4);
                        LineAmount2 = decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue());
                        SalesOrder.SOPricingAnalysisSummary.SelectRow(2);
                        SalesOrder.SOPricingAnalysisSummary.Row.CuryAmountTotal.GetValue().VerifyEquals(Calculate.CalculateSummaryTotals(LineAmount1, LineAmount2));
                    }

                    // Validate Preview Cost Total
                    using (TestExecution.CreateTestStepGroup("Validate Preview Cost Total"))
                    {
                        SalesOrder.SOPricingProfitPreviewGrid.SelectRow(1);
                        LineCost1 = decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryExtCostDisplay.GetValue());
                        SalesOrder.SOPricingProfitPreviewGrid.SelectRow(3);
                        LineCost2 = decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryExtCostDisplay.GetValue());
                        SalesOrder.SOPricingAnalysisSummary.SelectRow(2);
                        SalesOrder.SOPricingAnalysisSummary.Row.CuryExtCostTotal.GetValue().VerifyEquals(Calculate.CalculateSummaryTotals(LineCost1, LineCost2));
                    }

                    // Validate Preview Total Profit
                    using (TestExecution.CreateTestStepGroup("Validate Preview Total Profit"))
                    {
                        SalesOrder.SOPricingProfitPreviewGrid.SelectRow(2);
                        LineProfit1 = decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryProfit.GetValue());
                        SalesOrder.SOPricingProfitPreviewGrid.SelectRow(4);
                        LineProfit2 = decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryProfit.GetValue());
                        SalesOrder.SOPricingAnalysisSummary.SelectRow(2);
                        SalesOrder.SOPricingAnalysisSummary.Row.CuryProfitTotal.GetValue().VerifyEquals(Calculate.CalculateSummaryTotals(LineProfit1, LineProfit2));
                    }

                    // Validate Preview Total Markup%
                    using (TestExecution.CreateTestStepGroup("Validate Preview Total Markup%"))
                    {
                        SalesOrder.SOPricingAnalysisSummary.Row.MarkupPercent.GetValue().VerifyEquals(Calculate.CalculateMarkup(decimal.Parse(SalesOrder.SOPricingAnalysisSummary.Row.CuryAmountTotal.GetValue()), decimal.Parse(SalesOrder.SOPricingAnalysisSummary.Row.CuryExtCostTotal.GetValue())));
                    }

                    // Validate Preview Total Margin%
                    using (TestExecution.CreateTestStepGroup("Validate Preview Total Margin%"))
                    {
                        SalesOrder.SOPricingAnalysisSummary.Row.MarginPercent.GetValue().VerifyEquals(Calculate.CalculateMargin(decimal.Parse(SalesOrder.SOPricingAnalysisSummary.Row.CuryAmountTotal.GetValue()), decimal.Parse(SalesOrder.SOPricingAnalysisSummary.Row.CuryExtCostTotal.GetValue())));
                    }                 
                }

            // Test Case 6
            using (TestExecution.CreateTestCaseGroup("Verify Unapplied Adjustments will be reset"))
                {                               
                 // Change Apply Adjustments As Discount
                 using (TestExecution.CreateTestStepGroup("Change Apply Adjustments As Discount"))
                 {
                     SalesOrder.SOPricingProfitPreviewHeader.ApplyAdjustmentAs.Select("Discount");
                 }

                // Validate Information icon and the message
                using (TestExecution.CreateTestStepGroup("Validate Information icon and the message"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.Row.GetWarning().VerifyContains("Adjustments are always based on price for Freight.");
                }

                // Validate Freight Preview Line fields
                using (TestExecution.CreateTestStepGroup("Validate Freight Preview Line fields"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryUnitPrice.IsEnabled().VerifyEquals(true);
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryDiscAmt.IsEnabled().VerifyEquals(false);
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.IsEnabled().VerifyEquals(true);
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryProfit.IsEnabled().VerifyEquals(true);
                    SalesOrder.SOPricingProfitPreviewGrid.Row.MarkupPercent.IsEnabled().VerifyEquals(true);
                    SalesOrder.SOPricingProfitPreviewGrid.Row.MarginPercent.IsEnabled().VerifyEquals(true);
                }

                // Validate Current Amount values in Inventory and Freight Preview Lines
                using (TestExecution.CreateTestStepGroup("Validate Current Amount values in Inventory and Freight Preview Lines"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.SelectRow(2);
                    LineAmount1 = decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue());
                    SalesOrder.SOPricingProfitPreviewGrid.SelectRow(4);
                    LineAmount2 = decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue());

                }

                // Do Adjustments in Preview Lines
                using (TestExecution.CreateTestStepGroup("Do Adjustments in Preview Lines"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.SelectRow(2);
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.Type(450);
                    SalesOrder.SOPricingProfitPreviewGrid.SelectRow(4);
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.Type(190);
                }

                // Change Apply Adjustments As Price
                using (TestExecution.CreateTestStepGroup("Change Apply Adjustments As Price"))
                {
                    SalesOrder.SOPricingProfitPreviewHeader.ApplyAdjustmentAs.Select("Price");
                }

                // Validate previously adjusted values 
                using (TestExecution.CreateTestStepGroup(" Validate previously adjusted values "))
                    {
                    SalesOrder.SOPricingProfitPreviewGrid.SelectRow(2);
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue().VerifyEquals(LineAmount1);
                    SalesOrder.SOPricingProfitPreviewGrid.SelectRow(4);
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.GetValue().VerifyEquals(LineAmount2);
                    }
                }

            // Test Case 7 
            using (TestExecution.CreateTestCaseGroup("Verify Line Pricing Ruler changes and Freight Price in SO"))
                {
                    // Select Freight Current Line
                    using (TestExecution.CreateTestStepGroup("Select Freight Current Line"))
                    {
                        SalesOrder.SOPricingProfitPreviewGrid.SelectRow(SalesOrder.SOPricingProfitPreviewGrid.Columns.InventoryIDDisplay, "Freight");
                    }

                    // Navigate to the Line Pricing Ruler
                    using (TestExecution.CreateTestStepGroup("Navigate to the Line Pricing Ruler"))
                    {
                        SalesOrder.SOPricingProfitPreviewGrid.ProfitBreakUpByCurrentItem();
                    }

                    // Select Markup Option
                    using (TestExecution.CreateTestStepGroup("Select Markup Option"))
                    {
                        SalesOrder.SOLinePricingRulerPanel.BreakupBy.Set("Markup");
                    }

                    // Adjust Markup Start and Step in Line Pricing Ruler
                    using (TestExecution.CreateTestStepGroup("Adjust Markup Start and Step in Line Pricing Ruler"))
                    {
                        SalesOrder.SOLinePricingRulerPanel.StartValue.Type(14);
                        SalesOrder.SOLinePricingRulerPanel.IncrementValue.Type(10);
                    }

                    // Select New Markup%
                    using (TestExecution.CreateTestStepGroup("Select New Markup%"))
                    {
                        SalesOrder.SOLinePricingRulerPanelGrid.SelectRow(5);
                        Markup = decimal.Parse(SalesOrder.SOLinePricingRulerPanelGrid.Row.MarkupPercent.GetValue());
                    }
                   
                    // Apply New Markup%
                    using (TestExecution.CreateTestStepGroup("Apply New Markup%"))
                    {
                        SalesOrder.SOLinePricingRulerPanelGrid.Apply();
                    }

                    // Validate Markup% in Freight Preview Line
                    using (TestExecution.CreateTestStepGroup("Validate Markup% in Freight Preview Line"))
                    {
                        SalesOrder.SOPricingProfitPreviewGrid.SelectRow(4);
                        SalesOrder.SOPricingProfitPreviewGrid.Row.MarkupPercent.GetValue().VerifyEquals(Markup);
                    }

                    // Validate Unit Price in Freight Preview Line
                    using (TestExecution.CreateTestStepGroup("Validate Unit Price in Freight Preview Line"))
                    {
                        FPUnitPrice = decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryUnitPrice.GetValue());
                    }

                    // Click Apply button
                    using (TestExecution.CreateTestStepGroup("Click Apply button"))
                    {
                        SalesOrder.SOPricingAnalysisSummary.Apply();
                    }

                    // Validate Premium Freight Price
                    using (TestExecution.CreateTestStepGroup("Validate Premium Freight Price"))
                    {
                        SalesOrder.SOTotals.CuryPremiumFreightAmt.GetValue().VerifyEquals(SalesOrderEntity.CuryPremiumFreightAmt);
                    }

                    // Validate Freight Price
                    using (TestExecution.CreateTestStepGroup("Validate Freight Price"))
                    {
                        SalesOrder.SOTotals.CuryFreightAmt.GetValue().VerifyEquals(Calculate.CalculateFreightPrice(FPUnitPrice, SalesOrderEntity.CuryPremiumFreightAmt));
                    }
            }
        
            // Test Case 8
            using (TestExecution.CreateTestCaseGroup("Verify Document Pricing Ruler changes and Unit Price in SO"))
                {           
                    // Navigate to the Pricing Analysis Panel
                    using (TestExecution.CreateTestStepGroup("Navigate to the Pricing Analysis Panel"))
                    {
                        SalesOrder.SOToolBar.PricingAnalysis.Click();
                    }

                    // Navigate to the Document Pricing Ruler
                    using (TestExecution.CreateTestStepGroup("Navigate to the Document Pricing Ruler"))
                    {
                        SalesOrder.SOPricingProfitPreviewGrid.ProfitBreakUpByDocument();
                    }

                    // Adjust Margin Start and Step in Document Pricing Ruler
                    using (TestExecution.CreateTestStepGroup("Adjust Margin Start and Step in Document Pricing Ruler"))
                    {
                        SalesOrder.SODocPricingRulerPanel.StartValue.Type(15);
                        SalesOrder.SODocPricingRulerPanel.IncrementValue.Type(10);
                    }

                    // Select New Margin%
                    using (TestExecution.CreateTestStepGroup("Select New Margin%"))
                    {
                        SalesOrder.SODocPricingRulerPanelGrid.SelectRow(5);
                        Margin = decimal.Parse(SalesOrder.SODocPricingRulerPanelGrid.Row.MarginPercent.GetValue());
                    }                   

                    // Apply New Margin%
                    using (TestExecution.CreateTestStepGroup("Apply New Margin%"))
                    {
                        SalesOrder.SODocPricingRulerPanel.Apply();
                    }

                    // Validate Margin% in Inventory Line
                    using (TestExecution.CreateTestStepGroup("Validate Margin% in Inventory Line"))
                    {
                        SalesOrder.SOPricingProfitPreviewGrid.SelectRow(2);
                        SalesOrder.SOPricingProfitPreviewGrid.Row.MarginPercent.GetValue().VerifyEquals(Margin);
                        IPUnitPrice = decimal.Parse(SalesOrder.SOPricingProfitPreviewGrid.Row.CuryUnitPrice.GetValue());
                    }

                    // Validate Margin% in Freight Preview Line
                    using (TestExecution.CreateTestStepGroup("Validate Margin% in Freight Preview Line"))
                    {
                        SalesOrder.SOPricingProfitPreviewGrid.SelectRow(4);
                        SalesOrder.SOPricingProfitPreviewGrid.Row.MarginPercent.GetValue().VerifyEquals(Margin);
                    }

                    // Validate Margin% in Preview Totals
                    using (TestExecution.CreateTestStepGroup("Validate Margin% in Preview Totals"))
                    {
                        SalesOrder.SOPricingAnalysisSummary.SelectRow(2);
                        SalesOrder.SOPricingAnalysisSummary.Row.MarginPercent.GetValue().VerifyEquals(Margin);
                    }

                    // Apply Pricing Analysis Changes
                    using (TestExecution.CreateTestStepGroup("Apply Pricing Analysis Changes"))
                    {
                        SalesOrder.SOPricingAnalysisSummary.Apply();
                    }

                    // Validate Updated Unit Price in SO Inventory Line
                    using (TestExecution.CreateTestStepGroup("Validate Updated Unit Price in SO Inventory Line"))
                    {
                        SalesOrder.SOTransGrid.Row.CuryUnitPrice.GetValue().VerifyEquals(IPUnitPrice);
                    }
            }

            // Test Case 9
            using (TestExecution.CreateTestCaseGroup("Verify Freight Price functionalities when Override Freight Price is not Validateed"))
                {
                    // Clear Override Freight Price check box
                    using (TestExecution.CreateTestStepGroup("Clear Override Freight Price check box"))
                    {
                        SalesOrder.SOTotals.OverrideFreightAmount.SetFalse();
                    }

                    // Navigate to the Pricing Analysis Panel
                    using (TestExecution.CreateTestStepGroup("Navigate to the Pricing Analysis Panel"))
                    {
                        SalesOrder.SOToolBar.PricingAnalysis.Click();
                    }

                    // Validate Line Pricing Ruler is disabled
                    using (TestExecution.CreateTestStepGroup("Validate Line Pricing Ruler is disabled"))
                    {
                        SalesOrder.SOPricingProfitPreviewGrid.SelectRow(SalesOrder.SOPricingProfitPreviewGrid.Columns.InventoryIDDisplay, GeneralTestData.FreightInvID);
                        SalesOrder.SOPricingProfitPreviewGrid.ToolBar.ProfitBreakUpByCurrentItem.IsEnabled().VerifyEquals(false);
                    }

                    // Validate Freight Preview Line is not available
                    using (TestExecution.CreateTestStepGroup("Validate Freight Preview Line is not available"))
                    {
                        SalesOrder.SOPricingProfitPreviewGrid.Columns.InventoryIDDisplay.IsNull();
                        SalesOrder.SOPricingProfitPreviewGrid.RowsCount().VerifyEquals(1);
                        SalesOrder.SOPricingProfitPreviewGrid.Columns.InventoryIDDisplay.ClearFilter();
                    }

                    // Close Pricing Analysis Panel
                    using (TestExecution.CreateTestStepGroup("Close Pricing Analysis Panel"))                
                    {
                        SalesOrder.SOPricingAnalysisSummary.Close();
                    }                  
                }

            //Test Case 10
            using (TestExecution.CreateTestCaseGroup("Verify Freight Preview Line field statuses when SO Status is Shipping"))
            {
                // Check off Override Freight Price check box
                using (TestExecution.CreateTestStepGroup("Check off Override Freight Price check box"))
                {
                    SalesOrder.SOTotals.OverrideFreightAmount.SetTrue();
                }
                // Save Sales Order Changes
                using (TestExecution.CreateTestStepGroup("Save Sales Order Changes"))
                {
                    SalesOrder.SOToolBar.Save.Click();
                }
                // Click on Create Shipment Button
                using (TestExecution.CreateTestStepGroup("Click on Create Shipment Button"))
                {
                    SalesOrder.SOToolBar.CreateShipmentIssue.Click();
                }
                // Click on OK in Specify Shipment Parameters
                using (TestExecution.CreateTestStepGroup("Click on OK in Specify Shipment Parameters"))
                {
                    SalesOrder.SOCreateShipment.Ok();
                }               
                // Click on the Order No and Navigate back to SO
                using (TestExecution.CreateTestStepGroup("Click on the Order No and Navigate back to SO"))
                {
                    Shipment.ShipmentTransGrid.SelectRow(1);
                    Shipment.ShipmentTransGrid.Row.OrigOrderNbr.ClickLink();
                    SalesOrder.MaximizeWindow();
                }
                // Navigate to the Pricing Analysis Panel
                using (TestExecution.CreateTestStepGroup("Navigate to the Pricing Analysis Panel"))
                {
                    SalesOrder.SOToolBar.PricingAnalysis.Click();
                }
                // Select Freight Preview Line
                using (TestExecution.CreateTestStepGroup("Select Freight Preview Line"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.SelectRow(4);
                }
                // Validate Freight Preview Line fields
                using (TestExecution.CreateTestStepGroup("Validate Freight Preview Line fields"))
                {
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryUnitPrice.IsEnabled().VerifyEquals(false);
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryDiscAmt.IsEnabled().VerifyEquals(false);
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryLineAmt.IsEnabled().VerifyEquals(false);
                    SalesOrder.SOPricingProfitPreviewGrid.Row.CuryProfit.IsEnabled().VerifyEquals(false);
                    SalesOrder.SOPricingProfitPreviewGrid.Row.MarkupPercent.IsEnabled().VerifyEquals(false);
                    SalesOrder.SOPricingProfitPreviewGrid.Row.MarginPercent.IsEnabled().VerifyEquals(false);
                }
            }
        }
    }
}


