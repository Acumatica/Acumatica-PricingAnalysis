using GeneratedWrappers.Acumatica;

namespace TestFreightPrice.Extensions.VendorClass
{
    public class VendorClass : AP201000_VendorClassMaint
    {
        public c_vendorclassrecord_form VendorClassSummary => VendorClassRecord_form;
        public c_curvendorclassrecord_tab VendorDefaultSettings => CurVendorClassRecord_tab;
    }
}
