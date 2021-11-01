using Core.Wait;
using FreightPrice.Extensions;
using System;
using TestFreightPrice.CalculationMethods;
using TestFreightPrice.Entity;
using TestFreightPrice.Entity.CustomerClassEntity;
using TestFreightPrice.Entity.SalesOrder;
using TestFreightPrice.EntityData;
using TestFreightPrice.EntityDataService;
using TestFreightPrice.Extensions.ARSetup;
using TestFreightPrice.Extensions.Customer;
using TestFreightPrice.Extensions.CustomerClass;
using TestFreightPrice.Extensions.InventoryItem;
using TestFreightPrice.Extensions.ItemClass;
using TestFreightPrice.Extensions.ManageFinancialPeriods;
using TestFreightPrice.Extensions.PurchaseReceipt;
using TestFreightPrice.Extensions.Shipment;
using TestFreightPrice.Extensions.Vendor;
using TestFreightPrice.Extensions.VendorClass;
using TestFreightPrice.TestData;

namespace TestFreightPrice.Tests
{
    public class FreightPriceBase : TestBase
    {
        protected static ARSetup ARSetup => new ARSetup();
        protected static CustomerClass CustomerClass => new CustomerClass();
        protected static Customer Customer => new Customer();
        protected static ItemClass ItemClass => new ItemClass();
        protected static InventoryItem InventoryItem => new InventoryItem();
        protected static VendorClass VendorClass => new VendorClass();
        protected static Vendor Vendor => new Vendor();
        protected static PurchaseReceipt PurchaseReceipt => new PurchaseReceipt();
        protected static SalesOrder SalesOrder => new SalesOrder();
        protected static Shipment Shipment => new Shipment();
        protected static ManageFinancialPeriods ManageFinancialPeriods => new ManageFinancialPeriods();
        protected static Calculate Calculate => new Calculate();
        protected static GeneralTestData GeneralTestData => new GeneralTestData();

        protected CustomerClassEntity CustomerClassEntity;

        protected CustomerEntity CustomerEntity;

        protected ItemClassEntity ItemClassEntity;

        protected InventoryItemEntity InventoryItemEntity;

        protected VendorClassEntity VendorClassEntity;

        protected VendorEntity VendorEntity;

        protected PurchaseReceiptEntity PurchaseReceiptEntity;

        protected SalesOrderEntity SalesOrderEntity;

        public static string getCustomerAcctCD;

        public static string getVendorAcctCD;

        public static string getInventoryCD;

        public static int currentYear;

        protected FreightPriceBase()
        {
            CustomerClassEntity = new CustomerClassEntity();
            CustomerEntity = new CustomerEntity();
            ItemClassEntity = new ItemClassEntity();
            InventoryItemEntity = new InventoryItemEntity();
            VendorClassEntity = new VendorClassEntity();
            VendorEntity = new VendorEntity();
            PurchaseReceiptEntity = new PurchaseReceiptEntity();
            SalesOrderEntity = new SalesOrderEntity();
        }

        public decimal FCLineAmt { get; set; } 
        public decimal FCLineCostAmt { get; set; }
        public decimal FCLineQty { get; set; }
        public decimal LineAmount1 { get; set; }
        public decimal LineAmount2 { get; set; }
        public decimal LineCost1 { get; set; }
        public decimal LineCost2 { get; set; }
        public decimal LineProfit1 { get; set; }
        public decimal LineProfit2 { get; set; }
        public decimal Markup { get; set; }
        public decimal Margin { get; set; }
        public decimal FPUnitPrice { get; set; }
        public decimal IPUnitPrice { get; set; }

        public static string GenerateRandomName()
        {
            string myname = Guid.NewGuid().ToString();
            string RandomName = myname.Substring(0, 6);
            return RandomName;
        }

        public void ProcessFinancialPeriods()
        {
            currentYear = DateTime.Today.Year;
            ManageFinancialPeriods.OpenScreen();
            ManageFinancialPeriods.MngFinancialPeriodsSummary.Action.Select("Open");
            ManageFinancialPeriods.MngFinancialPeriodsSummary.ToYear.Select(currentYear.ToString());
            ManageFinancialPeriods.ProcessAll();
        }

        public void SetupARPreferences()
        {
            ARSetup.OpenScreen();
            ARSetup.PriceDiscountSettings.UsrDefAdjustmentType.Select(GeneralTestData.DefaultAdjustmentType);           
            ARSetup.PriceDiscountSettings.UsrDefAdjustmentType.GetValue().VerifyEquals(GeneralTestData.DefaultAdjustmentType);        
            ARSetup.PriceDiscountSettings.UsrDefPricingType.Select(GeneralTestData.DefaultPricingBy);                
            ARSetup.PriceDiscountSettings.UsrDefPricingType.GetValue().VerifyEquals(GeneralTestData.DefaultPricingBy);
            ARSetup.Save();
        }
        public void CreateCustomerClass()
        {
            CustomerClass.OpenScreen();
            CustomerClass.Insert();
            CustomerClassEntity = DataService.GetCustomerClassData(DataFilePath.CreateCustomerClassData);          
            CustomerClass.CustomerClassSummary.CustomerClassID.Type(CustomerClassEntity.CustomerClassID);
            CustomerClass.CustomerClassSummary.Descr.Type(CustomerClassEntity.Descr);
            CustomerClass.DefaultSettings.CountryID.Type(CustomerClassEntity.CountryID);
            CustomerClass.DefaultSettings.TermsID.Type(CustomerClassEntity.TermsID);
            CustomerClass.DefaultSettings.StatementCycleId.Type(CustomerClassEntity.StatementCycleId);
            CustomerClass.DefaultSettings.DefPaymentMethodID.Type(CustomerClassEntity.DefPaymentMethodID);
            CustomerClass.DefaultSettings.ARAcctID.Type(CustomerClassEntity.ARAcctID);
            CustomerClass.DefaultSettings.SalesAcctID.Type(CustomerClassEntity.SalesAcctID);
            CustomerClass.DefaultSettings.DiscTakenAcctID.Type(CustomerClassEntity.DiscTakenAcctID);
            CustomerClass.Save();
        }
        public void CreateCustomer()
        {
            Customer.OpenScreen();
            Customer.Insert();
            CustomerEntity = DataService.GetCustomerData(DataFilePath.CreateCustomerData);
            getCustomerAcctCD = GenerateRandomName();
            Customer.CustomerAccountSummary.AcctCD.Type(Prefix + CustomerEntity.AcctCD + getCustomerAcctCD);  
            Customer.CustomerAccountSummary.CustomerClassID.Type(CustomerEntity.CustomerClassID);               
            Customer.CustomerAccountGeneral.AcctName.Type(CustomerEntity.AcctName + getCustomerAcctCD);          
            Customer.CustomerDefaultAddress.AddressLine1.Type(CustomerEntity.AddressLine1);
            Customer.CustomerDefaultAddress.City.Type(CustomerEntity.City);
            Customer.CustomerDefaultAddress.State.Type(CustomerEntity.State);
            Customer.CustomerDefaultAddress.PostalCode.Type(CustomerEntity.PostalCode);
            Customer.CustomerAccountGeneral.CreditRule.Select(CustomerEntity.CreditRule);
            Customer.Save();
        }     
        public void CreateItemClass()
        {
            ItemClass.OpenScreen();
            ItemClass.Insert();
            ItemClassEntity = DataService.GetItemClassData(DataFilePath.CreateItemClassData);
            ItemClass.ItemClassSummary.ItemClassCD.Type(ItemClassEntity.ItemClassCD);
            ItemClass.ItemClassSummary.Descr.Type(ItemClassEntity.Descr);
            if (ItemClass.ItemClassSettings.StkItem.GetValue() == false)
            {
                ItemClass.ItemClassSettings.StkItem.SetTrue();
            }
            ItemClass.ItemClassSettings.ItemType.Select(ItemClassEntity.ItemType);
            ItemClass.ItemClassSettings.ValMethod.Select(ItemClassEntity.ValMethod);
            ItemClass.ItemClassSettings.TaxCategoryID.Type(ItemClassEntity.TaxCategoryID);
            ItemClass.ItemClassSettings.PostClassID.Type(ItemClassEntity.PostClassID);
            ItemClass.ItemClassSettings.LotSerClassID.Type(ItemClassEntity.LotSerClassID);
            ItemClass.DefaultSiteSettings.DfltSiteID.Type(ItemClassEntity.DfltSiteID);
            ItemClass.ItemClassSettings.AvailabilitySchemeID.Type(ItemClassEntity.AvailabilitySchemeID);
            ItemClass.ItemClassSettings.BaseUnit.Type(ItemClassEntity.BaseUnit);
            ItemClass.ItemClassSettings.SalesUnit.Type(ItemClassEntity.SalesUnit);
            ItemClass.ItemClassSettings.PurchaseUnit.Type(ItemClassEntity.PurchaseUnit);
            ItemClass.Save();
        }
        public void CreateInventoryItem()
        {
            InventoryItem.OpenScreen();
            InventoryItem.Insert();
            InventoryItemEntity = DataService.GetInventoryItemData(DataFilePath.CreateInventoryItemData);
            getInventoryCD = GenerateRandomName();
            InventoryItem.InvItemSummary.InventoryCD.Type(Prefix + getInventoryCD);
            InventoryItem.InvItemSummary.ItemStatus.Select(InventoryItemEntity.ItemStatus);
            InventoryItem.InvItemSummary.Descr.Type(InventoryItemEntity.Descr + getInventoryCD);
            InventoryItem.InvItemSettings.ItemClassID.Type(InventoryItemEntity.ItemClassID);           
            InventoryItem.InvCostCurySettings.BasePrice.Type(InventoryItemEntity.BasePrice);  
            InventoryItem.Save();
            InventoryItem.InvCostSettings.LastCost.Type(InventoryItemEntity.LastCost);
            InventoryItem.Save();
        }
        public void CreateVendorClass()
        {
            VendorClass.OpenScreen();
            VendorClass.Insert();
            VendorClassEntity = DataService.GetVendorClassData(DataFilePath.CreateVendorClassData);
            VendorClass.VendorClassSummary.VendorClassID.Type(VendorClassEntity.VendorClassID);
            VendorClass.VendorClassSummary.Descr.Type(VendorClassEntity.Descr);
            VendorClass.VendorDefaultSettings.CountryID.Type(VendorClassEntity.CountryID);
            VendorClass.VendorDefaultSettings.TermsID.Type(VendorClassEntity.TermsID);
            VendorClass.VendorDefaultSettings.PaymentMethodID.Type(VendorClassEntity.PaymentMethodID);
            VendorClass.VendorDefaultSettings.CashAcctID.Type(VendorClassEntity.CashAcctID);
            VendorClass.VendorDefaultSettings.APAcctID.Type(VendorClassEntity.APAcctID);
            VendorClass.VendorDefaultSettings.APSubID.Type(VendorClassEntity.APSubID);
            VendorClass.VendorDefaultSettings.DiscTakenAcctID.Type(VendorClassEntity.DiscTakenAcctID);
            VendorClass.VendorDefaultSettings.DiscTakenSubID.Type(VendorClassEntity.DiscTakenSubID);
            VendorClass.Save();
        }
        public void CreateVendor()
        {
            Vendor.OpenScreen();
            Vendor.Insert();
            VendorEntity = DataService.GetVendorData(DataFilePath.CreateVendorData);
            getVendorAcctCD = GenerateRandomName();
            Vendor.VendorAccountSummary.AcctCD.Type(Prefix + VendorEntity.AcctCD + getVendorAcctCD);                                         
            Vendor.VendorAccountSummary.VendorClassID.Type(VendorEntity.VendorClassID);           
            Vendor.VendorAccountGeneral.AcctName.Type(VendorEntity.AcctName + getVendorAcctCD);
            Vendor.VendorAddress.AddressLine1.Type(VendorEntity.AddressLine1);
            Vendor.VendorAddress.City.Type(VendorEntity.City);
            Vendor.VendorAddress.State.Type(VendorEntity.State);
            Vendor.VendorAddress.PostalCode.Type(VendorEntity.PostalCode);
            Vendor.Save();
        }
        public void CreatePurchaseReceipt()
        {
            PurchaseReceipt.OpenScreen();
            PurchaseReceipt.Insert();
            PurchaseReceiptEntity = DataService.GetPurchaseReceiptData(DataFilePath.CreatePurchaseReceiptData);
            PurchaseReceipt.PurchaseReceiptSummary.VendorID.Type(Prefix + VendorEntity.AcctCD + getVendorAcctCD);
            PurchaseReceipt.PurchaseReceiptSummary.InvoiceNbr.Type(Prefix + PurchaseReceiptEntity.InvoiceNbr + getInventoryCD);
            PurchaseReceipt.PRTransGrid.New();
            PurchaseReceipt.PRTransGrid.Row.InventoryID.Select(Prefix + getInventoryCD);
            PurchaseReceipt.PRTransGrid.Row.ReceiptQty.Type(PurchaseReceiptEntity.ReceiptQty);
            PurchaseReceipt.Save();
            PurchaseReceipt.ToolBar.Release.Element.Click();
        }
        public void CreateSalesOrder() 
        {
            SalesOrder.OpenScreen();
            SalesOrder.Insert();
            SalesOrderEntity = DataService.GetSalesOrderData(DataFilePath.CreateSalesOrderData);
            SalesOrder.SOSummary.CustomerID.Type(Prefix + CustomerEntity.AcctCD + getCustomerAcctCD);
            SalesOrder.SOSummary.OrderDesc.Type(SalesOrderEntity.OrderDesc + getCustomerAcctCD);
            SalesOrder.SOTransGrid.New();
            SalesOrder.SOTransGrid.Row.InventoryID.Select(Prefix + getInventoryCD);
            SalesOrder.SOTransGrid.Row.OrderQty.Type(SalesOrderEntity.OrderQty);
            SalesOrder.SOShippingSettings.ShipVia.Select(SalesOrderEntity.ShipVia);
            SalesOrder.SOShippingSettings.ShipTermsID.Select(SalesOrderEntity.ShipTermsID);
            SalesOrder.SOShippingSettings.ShipZoneID.Select(SalesOrderEntity.ShipZoneID);
            SalesOrder.SOTotals.CuryFreightCost.Type(SalesOrderEntity.CuryFreightCost);
            SalesOrder.SOTotals.OverrideFreightAmount.SetTrue();
            SalesOrder.SOTotals.CuryFreightAmt.Type(SalesOrderEntity.CuryFreightAmt);
            SalesOrder.SOTotals.CuryPremiumFreightAmt.Type(SalesOrderEntity.CuryPremiumFreightAmt);
            SalesOrder.Save();
        }
    }
}
