using GeneratedWrappers.Acumatica;

namespace TestFreightPrice.Extensions.CustomerClass
{
    public class CustomerClass : AR201000_CustomerClassMaint
    {
        public c_customerclassrecord_form CustomerClassSummary => CustomerClassRecord_form;
        public c_curcustomerclassrecord_tab DefaultSettings => CurCustomerClassRecord_tab;
    }
}
