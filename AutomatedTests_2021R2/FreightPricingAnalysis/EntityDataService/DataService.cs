using System;
using System.IO;
using TestFreightPrice.Entity;
using TestFreightPrice.Entity.CustomerClassEntity;
using TestFreightPrice.Entity.SalesOrder;

namespace TestFreightPrice.EntityDataService
{
    public class DataService
    {

        private readonly FileDataProvider builder;

        private DataService(FileDataProvider builder)
        {
            this.builder = builder;
        }
        public static DataService FileReader<T>() where T : FileDataProvider
        {
            var builder = Activator.CreateInstance<T>() as FileDataProvider;
            return new DataService(builder);
        }
        public FileDataProvider Construct(string fileName)
        {
            builder.FilePath = Path.Combine(Environment.CurrentDirectory, fileName);
            return builder;
        }
        public static SalesOrderEntity GetSalesOrderData(string fileName)
        {
            return FileReader<FileReader>().Construct(fileName).Get<SalesOrderEntity>();
        }
        public static CustomerClassEntity GetCustomerClassData(string fileName)
        {
            return FileReader<FileReader>().Construct(fileName).Get<CustomerClassEntity>();
        }
        public static CustomerEntity GetCustomerData(string fileName)
        {
            return FileReader<FileReader>().Construct(fileName).Get<CustomerEntity>();
        }
        public static ItemClassEntity GetItemClassData(string fileName)
        {
            return FileReader<FileReader>().Construct(fileName).Get<ItemClassEntity>();
        }
        public static InventoryItemEntity GetInventoryItemData(string fileName)
        {
            return FileReader<FileReader>().Construct(fileName).Get<InventoryItemEntity>();
        }
        public static VendorClassEntity GetVendorClassData(string fileName)
        {
            return FileReader<FileReader>().Construct(fileName).Get<VendorClassEntity>();
        }
        public static VendorEntity GetVendorData(string fileName)
        {
            return FileReader<FileReader>().Construct(fileName).Get<VendorEntity>();
        }
        public static PurchaseReceiptEntity GetPurchaseReceiptData(string fileName)
        {
            return FileReader<FileReader>().Construct(fileName).Get<PurchaseReceiptEntity>();
        }
    }
}
