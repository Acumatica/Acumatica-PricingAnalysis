namespace TestFreightPrice.Entity
{
    public class PurchaseReceiptEntity
    {
        public string VendorID { get; set; }
        public string InvoiceNbr { get; set; }
        public string InventoryID { get; set; }
        public decimal ReceiptQty { get; set; }
    }
}
