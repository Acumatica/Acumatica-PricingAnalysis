using GeneratedWrappers.Acumatica;

namespace TestFreightPrice.Extensions.Shipment
{
    public class Shipment : SO302000_SOShipmentEntry
    {
        public c_transactions_grid ShipmentTransGrid =>Transactions_grid;
    }
}
