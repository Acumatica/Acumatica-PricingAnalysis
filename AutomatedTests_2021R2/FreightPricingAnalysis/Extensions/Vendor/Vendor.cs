using GeneratedWrappers.Acumatica;

namespace TestFreightPrice.Extensions.Vendor
{
    public class Vendor : AP303000_VendorMaint
    {
        public c_baccount_baccount VendorAccountSummary => BAccount_BAccount;
        public c_currentvendor_tab VendorAccountGeneral => CurrentVendor_tab;
        public c_defaddress_defaddress VendorAddress => DefAddress_DefAddress;

    }
}
