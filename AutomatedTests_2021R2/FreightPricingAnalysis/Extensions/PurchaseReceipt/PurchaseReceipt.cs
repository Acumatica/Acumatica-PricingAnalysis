using GeneratedWrappers.Acumatica;

namespace TestFreightPrice.Extensions.PurchaseReceipt
{
    public class PurchaseReceipt : PO302000_POReceiptEntry
    {
        public c_document_form PurchaseReceiptSummary => Document_form;
        public c_transactions_grid PRTransGrid =>  Transactions_grid;
    }
}
