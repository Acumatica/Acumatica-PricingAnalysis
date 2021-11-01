using GeneratedWrappers.Acumatica;

namespace TestFreightPrice.Extensions.Customer
{
    public class Customer : AR303000_CustomerMaint
    {
        public c_baccount_baccount CustomerAccountSummary => BAccount_BAccount;
        public c_currentcustomer_tab CustomerAccountGeneral => CurrentCustomer_tab;
        public c_defaddress_defaddress CustomerDefaultAddress => DefAddress_DefAddress;
    }
}
