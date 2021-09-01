[![Project Status](http://opensource.box.com/badges/active.svg)](http://opensource.box.com/badges)

Extension to compare and choose best selling price
==================================

With this extension, you can:

* Quickly reprice some or all items on the document based on desired profit, margin or markup 
* Speed up price negotiations and profitability understanding
* Apply profit adjustment based on Price Or Discount at line level / entire document level

The Pricing Analysis displays profits for all the items contained in the document at the current selling price based on line level valuation based cost. 
Cost is determined based on 

* Actual/Specific cost is utilized for allocated Lot/Serial #. 
* Standard cost or line cost is utilized for non-stock items having cost accrual enabled.
* Last Cost is utilized for zero stock item.

### Prerequisites
* Acumatica 2020 R1 (20.109.0032 or higher)
* Acumatica 2020 R2 (20.202.0043 or higher)

Quick Start
-----------

### Installation

##### Install customization deployment package
1. Download PXPricingAnalysisPkg.zip.
2. In your Acumatica ERP instance, navigate to System -> Customization -> Customization Projects (SM204505), import PXPricingAnalysisPkg.zip as a customization project
3. Publish customization project.

### Usage

Once package is published on Acumatica Instance, new option Pricing Analysis is available on below screens

1. Sales Order screen (SO301000) for Sales Order with Open status
2. Service Order screen (FS300100) for Service Order with Open status
3. Appointment screen (FS300200) for Appointment with not Closed or not Cancelled status
4. Sales Quote (CR304500) for Sales Quote with Draft status
5. Project Quote (PM304500) for Project Quote with Draft status

![Screenshot](/_ReadMeImages/Image1-SO301000.png)

Adjustment can be applied based on Price Or Discount. 

Pricing Analysis shows order line details twice – 

1. Current Line – non-editable  
2. Preview Line – Where Margin %, Markup %, Line Profit and Amount are editable

This helps in comparing the profitability of current order line with updated parameters like Profit, Margin %, Markup % and line Amount. Also, user can compare Profit and Amount totals along with Markup % and Margin % of entire order. 

![Screenshot](/_ReadMeImages/Image2-PricingAnalysis.png)

Clicking on Apply updates the Unit Price / Discount Amount and Amount in document.

User can select Pricing Analysis for the entire document or for one particular order line as below:

![Screenshot](/_ReadMeImages/Image3-PricingOptions.png)

##### Document Pricing Ruler 

Displays the pricing analysis statistics and calculations for the entire document. First line is current line for comparing.

Pricing Ruler grid displays the pricing analysis and user can choose to use the Markup or Margin settings to display the profits. User can choose Apply to update selected Markup/Margin in the pricing analysis.

![Screenshot](/_ReadMeImages/Image4-DocumentPricingRuler.png)

##### Line Pricing Ruler

Displays the pricing analysis statistics and calculations for the selected line.

Pricing Ruler grid displays the pricing analysis and user can choose to use the Markup or Margin settings to display the profits. User can choose Apply to update selected Markup/Margin in the pricing analysis.

![Screenshot](/_ReadMeImages/Image5-LinePricingRuler.png)

### Pricing Analysis Preferences

Default Adjustment Type and Default Pricing By can be specified in Accounts Receivable Preferences (AR101000) -> Price/Discount Settings -> Pricing Analysis

![Screenshot](/_ReadMeImages/Image6-Preference.png)

### Profitability for Freight Prices

This feature is available on Sales Orders screens (SO301000) with Open status. It facilitates the user to identify / calculate the profitability of pricing on freight charges.

The embedded freight price profitability calculator enables calculation/recalculation of the freight price, for the sales order, based on profit, margin or markup.
The freight price entries would appear below the inventory lines as shown in the table below.

![Screenshot](/_ReadMeImages/Image8-FreightChargers.PNG)

The amounts displayed on the the lines contianing freight prices will be totaled into the Current and Preview totals on the Summary area.

The preview line for amending the freight price will be available ONLY if the user has opted for overriding the default freight prices on the sales order by selecting the "Override Freight Price" on the "Totals" tab of the Sales Order.

![Screenshot](/_ReadMeImages/Image7-OverrideFreightPrice.PNG)


Freight price information is shown on the table in two lines 
1. Current Line – non-editable
2. Preview Line – Where Margin %, Markup %, Line Profit and Amount are editable

![Screenshot](/_ReadMeImages/Image9-freight-price-lines.PNG)


Freight pricing fields are calculated as follows in the freight price lines:

* Unit Price = Freight Price + Premium Freight Price
* Cost Amount = Freight Cost
* Amount = Unit Price
* Discount = Will not be applicable for freight price calculations

![Screenshot](/_ReadMeImages/Image10-freight-price-discounts-warning.PNG)


Clicking on Apply, will update the Freight Price in document.

* Freight Price = Unit Price - Premium Freight Price
* Premium Freight Price = Will not be amended


Known Issues
------------
None at the moment

## Copyright and License

Copyright © `2020` `Acumatica, INC`

This component is licensed under the MIT License, a copy of which is available online [here](LICENSE)
