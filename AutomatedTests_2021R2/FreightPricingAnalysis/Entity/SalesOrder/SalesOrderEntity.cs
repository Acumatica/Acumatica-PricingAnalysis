namespace TestFreightPrice.Entity.SalesOrder
{
    public class SalesOrderEntity
    {
        public string OrderType { get; set; }
        public string CustomerID { get; set; }
        public string OrderDesc { get; set; }
        public string InventoryID { get; set; }
        public decimal OrderQty { get; set; }
        public string ShipVia { get; set; }
        public string ShipTermsID { get; set; }
        public string ShipZoneID { get; set; }
        public decimal CuryFreightCost { get; set; }
        public decimal CuryFreightAmt { get; set; }
        public decimal CuryPremiumFreightAmt { get; set; }



    }
}
