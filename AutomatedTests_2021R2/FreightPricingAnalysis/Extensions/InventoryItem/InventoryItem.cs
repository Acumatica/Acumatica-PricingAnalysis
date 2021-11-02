using GeneratedWrappers.Acumatica;

namespace TestFreightPrice.Extensions.InventoryItem
{
    public class InventoryItem : IN202500_InventoryItemMaint
    {
        public c_item_form InvItemSummary => Item_form;
        public c_itemsettings_tab InvItemSettings => ItemSettings_tab;
        public c_itemcosts_formcoststats InvCostSettings => Itemcosts_formcoststats;
        public c_curysettings_inventoryitem_curysettingsform InvCostCurySettings => CurySettings_InventoryItem_curySettingsForm;
    }
}
