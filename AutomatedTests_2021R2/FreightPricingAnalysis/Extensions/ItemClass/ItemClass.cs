using GeneratedWrappers.Acumatica;

namespace TestFreightPrice.Extensions.ItemClass
{
    public class ItemClass : IN201000_INItemClassMaint
    {
        public c_itemclass_form ItemClassSummary => Itemclass_form;
        public c_itemclasssettings_tab ItemClassSettings => Itemclasssettings_tab;
        public c_itemclasscurysettings_curysettingsformdefaultsite DefaultSiteSettings => Itemclasscurysettings_curysettingsformdefaultsite;
    }
}
