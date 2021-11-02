using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;
using Controls.Editors.TreeSelector;
using Controls.FileColumnButton;
using Controls.Grid;
using Controls.Grid.Filter;
using Controls.Grid.Upload;
using Controls.GroupBox;
using Controls.ImageUploader;
using Controls.Input;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.NoteColumnButton;
using Controls.PxControlCollection;
using Controls.RichTextEdit;
using Controls.ToolBarButton;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace GeneratedWrappers.Acumatica
{
    
    
    public class IN202500_InventoryItemMaint : Wrapper
    {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
        protected c_allscreens_screensgrid AllScreens_screensGrid { get; } = new c_allscreens_screensgrid("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_screens_screensGrid", "AllScreens_screensGrid");
        protected c_pages_articlesgrid Pages_articlesGrid { get; } = new c_pages_articlesgrid("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_articles_articlesGrid", "Pages_articlesGrid");
        protected c_pages_lv0 Pages_lv0 { get; } = new c_pages_lv0("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_articles_articlesGrid_lv0", "Pages_lv0");
        protected c_fileswithsize_filessearchgrid FilesWithSize_filesSearchGrid { get; } = new c_fileswithsize_filessearchgrid("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid", "FilesWithSize_filesSearchGrid");
        protected c_fileswithsize_lv0 FilesWithSize_lv0 { get; } = new c_fileswithsize_lv0("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_lv0", "FilesWithSize_lv0");
        protected c_item_form Item_form { get; } = new c_item_form("ctl00_phF_form", "Item_form");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_profilerinfoview_formprofiler ProfilerInfoView_formProfiler { get; } = new c_profilerinfoview_formprofiler("ctl00_usrCaption_pnlProfiler_formProfiler", "ProfilerInfoView_formProfiler");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_comboboxvalues_gridcombos ComboBoxValues_gridCombos { get; } = new c_comboboxvalues_gridcombos("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos", "ComboBoxValues_gridCombos");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_itemsettings_tab ItemSettings_tab { get; } = new c_itemsettings_tab("ctl00_phG_tab", "ItemSettings_tab");
        protected c_itemsettings_formdr ItemSettings_formDR { get; } = new c_itemsettings_formdr("ctl00_phG_tab_t11_formDR", "ItemSettings_formDR");
        protected c_itemsettings_formsm ItemSettings_formSM { get; } = new c_itemsettings_formsm("ctl00_phG_tab_t15_formSM", "ItemSettings_formSM");
        protected c_curysettings_inventoryitem_curysettingsformdefaultsite CurySettings_InventoryItem_CurySettingsFormDefaultSite { get; } = new c_curysettings_inventoryitem_curysettingsformdefaultsite("ctl00_phG_tab_t0_CurySettingsFormDefaultSite", "CurySettings_InventoryItem_CurySettingsFormDefaultSite");
        protected c_curysettings_inventoryitem_curysettingsform CurySettings_InventoryItem_curySettingsForm { get; } = new c_curysettings_inventoryitem_curysettingsform("ctl00_phG_tab_t2_curySettingsForm", "CurySettings_InventoryItem_curySettingsForm");
        protected c_curysettings_inventoryitem_curysettingsform2 CurySettings_InventoryItem_curySettingsForm2 { get; } = new c_curysettings_inventoryitem_curysettingsform2("ctl00_phG_tab_t2_curySettingsForm2", "CurySettings_InventoryItem_curySettingsForm2");
        protected c_segmentvalues_gridsegmentvalues SegmentValues_gridSegmentValues { get; } = new c_segmentvalues_gridsegmentvalues("ctl00_phG_tab_t1_gridSegmentValues", "SegmentValues_gridSegmentValues");
        protected c_segmentvalues_lv0 SegmentValues_lv0 { get; } = new c_segmentvalues_lv0("ctl00_phG_tab_t1_gridSegmentValues_lv0", "SegmentValues_lv0");
        protected c_itemunits_gridunits Itemunits_gridunits { get; } = new c_itemunits_gridunits("ctl00_phG_tab_t0_gridUnits", "itemunits_gridUnits");
        protected c_itemunits_lv0 Itemunits_lv0 { get; } = new c_itemunits_lv0("ctl00_phG_tab_t0_gridUnits_lv0", "itemunits_lv0");
        protected c_components_pxgridcomponents Components_PXGridComponents { get; } = new c_components_pxgridcomponents("ctl00_phG_tab_t11_PXGridComponents", "Components_PXGridComponents");
        protected c_components_lv0 Components_lv0 { get; } = new c_components_lv0("ctl00_phG_tab_t11_PXGridComponents_lv0", "Components_lv0");
        protected c_itemxrefrecords_crossgrid Itemxrefrecords_crossgrid { get; } = new c_itemxrefrecords_crossgrid("ctl00_phG_tab_t8_crossgrid", "itemxrefrecords_crossgrid");
        protected c_itemxrefrecords_lv0 Itemxrefrecords_lv0 { get; } = new c_itemxrefrecords_lv0("ctl00_phG_tab_t8_crossgrid_lv0", "itemxrefrecords_lv0");
        protected c_vendoritems_pxgridvendoritems VendorItems_PXGridVendorItems { get; } = new c_vendoritems_pxgridvendoritems("ctl00_phG_tab_t5_PXGridVendorItems", "VendorItems_PXGridVendorItems");
        protected c_vendoritems_lv0 VendorItems_lv0 { get; } = new c_vendoritems_lv0("ctl00_phG_tab_t5_PXGridVendorItems_lv0", "VendorItems_lv0");
        protected c_answers_pxgridanswers Answers_PXGridAnswers { get; } = new c_answers_pxgridanswers("ctl00_phG_tab_t6_PXGridAnswers", "Answers_PXGridAnswers");
        protected c_answers_lv0 Answers_lv0 { get; } = new c_answers_lv0("ctl00_phG_tab_t6_PXGridAnswers_lv0", "Answers_lv0");
        protected c_category_pxgridcategory Category_PXGridCategory { get; } = new c_category_pxgridcategory("ctl00_phG_tab_t6_PXGridCategory", "Category_PXGridCategory");
        protected c_category_lv0 Category_lv0 { get; } = new c_category_lv0("ctl00_phG_tab_t6_PXGridCategory_lv0", "Category_lv0");
        protected c_itemcosts_formcoststats Itemcosts_formcoststats { get; } = new c_itemcosts_formcoststats("ctl00_phG_tab_t2_formCostStats", "itemcosts_formCostStats");
        protected c_itemsiterecords_grid2 Itemsiterecords_grid2 { get; } = new c_itemsiterecords_grid2("ctl00_phG_tab_t4_grid2", "itemsiterecords_grid2");
        protected c_itemsiterecords_lv0 Itemsiterecords_lv0 { get; } = new c_itemsiterecords_lv0("ctl00_phG_tab_t4_grid2_lv0", "itemsiterecords_lv0");
        protected c_replenishment_repgrid Replenishment_repgrid { get; } = new c_replenishment_repgrid("ctl00_phG_tab_t10_sp1_repGrid", "replenishment_repGrid");
        protected c_replenishment_lv0 Replenishment_lv0 { get; } = new c_replenishment_lv0("ctl00_phG_tab_t10_sp1_repGrid_lv0", "replenishment_lv0");
        protected c_subreplenishment_repsubgrid Subreplenishment_repsubgrid { get; } = new c_subreplenishment_repsubgrid("ctl00_phG_tab_t10_sp1_repSubGrid", "subreplenishment_repSubGrid");
        protected c_subreplenishment_lv0 Subreplenishment_lv0 { get; } = new c_subreplenishment_lv0("ctl00_phG_tab_t10_sp1_repSubGrid_lv0", "subreplenishment_lv0");
        protected c_boxes_pxgridboxes Boxes_PXGridBoxes { get; } = new c_boxes_pxgridboxes("ctl00_phG_tab_t7_PXGridBoxes", "Boxes_PXGridBoxes");
        protected c_boxes_lv0 Boxes_lv0 { get; } = new c_boxes_lv0("ctl00_phG_tab_t7_PXGridBoxes_lv0", "Boxes_lv0");
        protected c_groups_grid3 Groups_grid3 { get; } = new c_groups_grid3("ctl00_phG_tab_t13_grid3", "Groups_grid3");
        protected c_groups_lv0 Groups_lv0 { get; } = new c_groups_lv0("ctl00_phG_tab_t13_grid3_lv0", "Groups_lv0");
        protected c_relateditems_relateditemsgrid RelatedItems_relatedItemsGrid { get; } = new c_relateditems_relateditemsgrid("ctl00_phG_tab_t9_relatedItemsGrid", "RelatedItems_relatedItemsGrid");
        protected c_relateditems_lv0 RelatedItems_lv0 { get; } = new c_relateditems_lv0("ctl00_phG_tab_t9_relatedItemsGrid_lv0", "RelatedItems_lv0");
        protected c_vendorinventory_updateprice_formeffectivedate VendorInventory_UpdatePrice_formEffectiveDate { get; } = new c_vendorinventory_updateprice_formeffectivedate("ctl00_phG_pnlUpdatePrice_formEffectiveDate", "VendorInventory$UpdatePrice_formEffectiveDate");
        protected c_changeiddialog_formchangeid ChangeIDDialog_formChangeID { get; } = new c_changeiddialog_formchangeid("ctl00_phF_pnlChangeID_formChangeID", "ChangeIDDialog_formChangeID");
        protected c_rutrotitemsettings_formrutrotitemsettings RUTROTItemSettings_formRUTROTItemSettings { get; } = new c_rutrotitemsettings_formrutrotitemsettings("ctl00_phG_tab_t2_formRUTROTItemSettings", "RUTROTItemSettings_formRUTROTItemSettings");
        protected c_inventoryfileurls_gridinventoryfileurls InventoryFileUrls_gridInventoryFileUrls { get; } = new c_inventoryfileurls_gridinventoryfileurls("ctl00_phG_tab_t17_gridInventoryFileUrls", "InventoryFileUrls_gridInventoryFileUrls");
        protected c_inventoryfileurls_lv0 InventoryFileUrls_lv0 { get; } = new c_inventoryfileurls_lv0("ctl00_phG_tab_t17_gridInventoryFileUrls_lv0", "InventoryFileUrls_lv0");
        protected c_amsubitemdefaults_amgridamsubitemdefault AMSubItemDefaults_AMGridAMSubItemDefault { get; } = new c_amsubitemdefaults_amgridamsubitemdefault("ctl00_phG_tab_t3_AMGridAMSubItemDefault", "AMSubItemDefaults_AMGridAMSubItemDefault");
        protected c_amsubitemdefaults_lv0 AMSubItemDefaults_lv0 { get; } = new c_amsubitemdefaults_lv0("ctl00_phG_tab_t3_AMGridAMSubItemDefault_lv0", "AMSubItemDefaults_lv0");
        protected c_modelcomponents_gridcomponents ModelComponents_gridComponents { get; } = new c_modelcomponents_gridcomponents("ctl00_phG_tab_t15_gridComponents", "ModelComponents_gridComponents");
        protected c_modelcomponents_lv0 ModelComponents_lv0 { get; } = new c_modelcomponents_lv0("ctl00_phG_tab_t15_gridComponents_lv0", "ModelComponents_lv0");
        protected c_syncrecs_syncgrid SyncRecs_syncGrid { get; } = new c_syncrecs_syncgrid("ctl00_phG_tab_t16_syncGrid", "SyncRecs_syncGrid");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        protected c_itemsettings_filesgrid ItemSettings_filesGrid { get; } = new c_itemsettings_filesgrid("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_attFiles_filesGrid", "ItemSettings_filesGrid");
        protected c_relateditems_importcsvsettings_frmimportcsvsettings RelatedItems_ImportCSVSettings_frmImportCSVSettings { get; } = new c_relateditems_importcsvsettings_frmimportcsvsettings("ctl00_phG_tab_t9_relatedItemsGrid_imp_importCSVSettingsDlg_frmImportCSVSettings", "RelatedItems$ImportCSVSettings_frmImportCSVSettings");
        protected c_relateditems_importxlsxsettings_frmimportxlsxsettings RelatedItems_ImportXLSXSettings_frmImportXLSXSettings { get; } = new c_relateditems_importxlsxsettings_frmimportxlsxsettings("ctl00_phG_tab_t9_relatedItemsGrid_imp_importXLSXSettingsDlg_frmImportXLSXSettings", "RelatedItems$ImportXLSXSettings_frmImportXLSXSettings");
        protected c_relateditems_importcolumns_grdimportcolumn RelatedItems_ImportColumns_grdImportColumn { get; } = new c_relateditems_importcolumns_grdimportcolumn("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn", "RelatedItems$ImportColumns_grdImportColumn");
        protected c_relateditems_importcolumns_lv0 RelatedItems_ImportColumns_lv0 { get; } = new c_relateditems_importcolumns_lv0("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0", "RelatedItems$ImportColumns_lv0");
        
        public IN202500_InventoryItemMaint()
        {
            ScreenId = "IN202500";
            ScreenUrl = "/Pages/IN/IN202500.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual IN202500_InventoryItemMaint ReadOne(Gate gate, string InventoryCD)
        {
            new BiObject<IN202500_InventoryItemMaint>(gate).ReadOne(this, InventoryCD);
            return this;
        }
        
        public virtual IN202500_InventoryItemMaint ReadOne(string InventoryCD)
        {
            return this.ReadOne(ApiConnection.Source, InventoryCD);
        }
        
        public virtual void SyncTOC()
        {
            ToolBar.SyncTOC.Click();
        }
        
        public virtual void Note()
        {
            ToolBar.Note.Click();
        }
        
        public virtual void ActivityShow()
        {
            ToolBar.ActivityShow.Click();
        }
        
        public virtual void FilesMenuShow()
        {
            ToolBar.FilesMenuShow.Click();
        }
        
        public virtual void Custom()
        {
            ToolBar.Custom.Click();
        }
        
        public virtual void ActionSelectWorkingProject()
        {
            ToolBar.ActionSelectWorkingProject.Click();
        }
        
        public virtual void InspectElementCtrlAltClick()
        {
            ToolBar.InspectElementCtrlAltClick.Click();
        }
        
        public virtual void MenuEditProj()
        {
            ToolBar.MenuEditProj.Click();
        }
        
        public virtual void ManageCustomizations()
        {
            ToolBar.ManageCustomizations.Click();
        }
        
        public virtual void KeyBtnRefresh()
        {
            ToolBar.KeyBtnRefresh.Click();
        }
        
        public virtual void Help()
        {
            ToolBar.Help.Click();
        }
        
        public virtual void MenuOpener()
        {
            ToolBar.MenuOpener.Click();
        }
        
        public virtual void CancelClose()
        {
            ToolBar.CancelClose.Click();
        }
        
        public virtual void SaveClose()
        {
            ToolBar.SaveClose.Click();
        }
        
        public virtual void Save()
        {
            ToolBar.Save.Click();
        }
        
        public virtual void Cancel()
        {
            ToolBar.Cancel.Click();
        }
        
        public virtual void Insert()
        {
            ToolBar.Insert.Click();
        }
        
        public virtual void Delete()
        {
            ToolBar.Delete.Click();
        }
        
        public virtual void CopyPaste()
        {
            ToolBar.CopyPaste.Click();
        }
        
        public virtual void CopyDocument()
        {
            ToolBar.CopyDocument.Click();
        }
        
        public virtual void PasteDocument()
        {
            ToolBar.PasteDocument.Click();
        }
        
        public virtual void SaveTemplate()
        {
            ToolBar.SaveTemplate.Click();
        }
        
        public virtual void First()
        {
            ToolBar.First.Click();
        }
        
        public virtual void Previous()
        {
            ToolBar.Previous.Click();
        }
        
        public virtual void Next()
        {
            ToolBar.Next.Click();
        }
        
        public virtual void Last()
        {
            ToolBar.Last.Click();
        }
        
        public virtual void ViewSalesPrices()
        {
            ToolBar.ViewSalesPrices.Click();
        }
        
        public virtual void ViewVendorPrices()
        {
            ToolBar.ViewVendorPrices.Click();
        }
        
        public virtual void UpdateCost()
        {
            ToolBar.UpdateCost.Click();
        }
        
        public virtual void ChangeID()
        {
            ToolBar.ChangeID.Click();
        }
        
        public virtual void ViewRestrictionGroups()
        {
            ToolBar.ViewRestrictionGroups.Click();
        }
        
        public virtual void ViewSummary()
        {
            ToolBar.ViewSummary.Click();
        }
        
        public virtual void ViewAllocationDetails()
        {
            ToolBar.ViewAllocationDetails.Click();
        }
        
        public virtual void ViewTransactionSummary()
        {
            ToolBar.ViewTransactionSummary.Click();
        }
        
        public virtual void ViewTransactionDetails()
        {
            ToolBar.ViewTransactionDetails.Click();
        }
        
        public virtual void ViewTransactionHistory()
        {
            ToolBar.ViewTransactionHistory.Click();
        }
        
        public virtual void GenerateLotSerialNumber()
        {
            ToolBar.GenerateLotSerialNumber.Click();
        }
        
        public virtual void PricesCategory()
        {
            ToolBar.PricesCategory.Click();
        }
        
        public virtual void OtherCategory()
        {
            ToolBar.OtherCategory.Click();
        }
        
        public virtual void Inquiry()
        {
            ToolBar.Inquiry.Click();
        }
        
        public virtual void LongRun()
        {
            ToolBar.LongRun.Click();
        }
        
        public virtual void LongrunCancel()
        {
            ToolBar.LongrunCancel.Click();
        }
        
        public virtual void LongrunTimer()
        {
            ToolBar.LongrunTimer.Click();
        }
        
        public class PxToolBar : PxControlCollection
        {
            
			public ToolBarButton SyncTOC { get; }
			public ToolBarButton Note { get; }
			public ToolBarButton ActivityShow { get; }
			public ToolBarButton FilesMenuShow { get; }
			public ToolBarButton Custom { get; }
			public ToolBarButton ActionSelectWorkingProject { get; }
			public ToolBarButton InspectElementCtrlAltClick { get; }
			public ToolBarButton MenuEditProj { get; }
			public ToolBarButton ManageCustomizations { get; }
			public ToolBarButton KeyBtnRefresh { get; }
			public ToolBarButton Help { get; }
			public ToolBarButton MenuOpener { get; }
			public ToolBarButton CancelClose { get; }
			public ToolBarButton SaveClose { get; }
			public ToolBarButton Save { get; }
			public ToolBarButton Cancel { get; }
			public ToolBarButton Insert { get; }
			public ToolBarButton Delete { get; }
			public ToolBarButton CopyPaste { get; }
			public ToolBarButton CopyDocument { get; }
			public ToolBarButton PasteDocument { get; }
			public ToolBarButton SaveTemplate { get; }
			public ToolBarButton First { get; }
			public ToolBarButton Previous { get; }
			public ToolBarButton Next { get; }
			public ToolBarButton Last { get; }
			public ToolBarButton ViewSalesPrices { get; }
			public ToolBarButton ViewVendorPrices { get; }
			public ToolBarButton UpdateCost { get; }
			public ToolBarButton ChangeID { get; }
			public ToolBarButton ViewRestrictionGroups { get; }
			public ToolBarButton ViewSummary { get; }
			public ToolBarButton ViewAllocationDetails { get; }
			public ToolBarButton ViewTransactionSummary { get; }
			public ToolBarButton ViewTransactionDetails { get; }
			public ToolBarButton ViewTransactionHistory { get; }
			public ToolBarButton GenerateLotSerialNumber { get; }
			public ToolBarButton PricesCategory { get; }
			public ToolBarButton OtherCategory { get; }
			public ToolBarButton Inquiry { get; }
			public ToolBarButton LongRun { get; }
			public ToolBarButton LongrunCancel { get; }
			public ToolBarButton LongrunTimer { get; }
            
            public PxToolBar(string locator)
            {
                SyncTOC = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
                Note = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'NoteShow\']", "Add Note", locator, null);
                ActivityShow = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'ActivityShow\']", "Activities", locator, null);
                FilesMenuShow = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'FilesMenuShow\']", "Files", locator, null);
                Custom = new ToolBarButton("css=#ctl00_usrCaption_CustomizationDialogs_PXToolBar1 div[data-cmd=\'Custom\']", "Customization", locator, null);
                ActionSelectWorkingProject = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "ActionSelectWorkingProject\']", "Select Project...", locator, Custom);
                InspectElementCtrlAltClick = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li.menuItem d" +
                        "iv:textEqual(\"Inspect Element (Ctrl+Alt+Click)\")", "Inspect Element (Ctrl+Alt+Click)", locator, Custom);
                MenuEditProj = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "menuEditProj\']", "Edit Project...", locator, Custom);
                ManageCustomizations = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li.menuItem d" +
                        "iv:textEqual(\"Manage Customizations...\")", "Manage Customizations...", locator, Custom);
                KeyBtnRefresh = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'keyBtnRefresh\']", "Click to refresh page.", locator, null);
                Help = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'help\']", "View Tools", locator, null);
                MenuOpener = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_MenuOpener", "Menu", locator, null);
                CancelClose = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CancelClose", "Discard Changes and Close", locator, null);
                CancelClose.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                SaveClose = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_SaveClose", "Save the current record and close the screen (Ctrl+Shift+S).", locator, null);
                Save = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Save", "Save (Ctrl+S).", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_cancel", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                Insert = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Insert", "Add New Record (Ctrl+Ins)", locator, null);
                Delete = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Delete", "Delete (Ctrl+Del).", locator, null);
                Delete.ConfirmAction = () => Alert.AlertToException("The current Inventory Item record will be deleted.");
                CopyPaste = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CopyPaste", "Clipboard", locator, null);
                CopyDocument = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@CopyDocument\']", "CopyDocument", locator, CopyPaste);
                PasteDocument = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@PasteDocument\']", "PasteDocument", locator, CopyPaste);
                SaveTemplate = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@SaveTemplate\']", "SaveTemplate", locator, CopyPaste);
                First = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_First", "Go to First Record", locator, null);
                Previous = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Previous", "Go to Previous Record (PgUp)", locator, null);
                Next = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Next", "Go to Next Record (PgDn)", locator, null);
                Last = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Last", "Go to Last Record", locator, null);
                ViewSalesPrices = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewSalesPrices,#ctl00_phDS_ds_ToolBar_ViewSalesPrices" +
                        "_item", "Sales Prices", locator, MenuOpener);
                ViewVendorPrices = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewVendorPrices,#ctl00_phDS_ds_ToolBar_ViewVendorPric" +
                        "es_item", "Vendor Prices", locator, MenuOpener);
                UpdateCost = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_UpdateCost,#ctl00_phDS_ds_ToolBar_UpdateCost_item", "Update Cost", locator, MenuOpener);
                ChangeID = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ChangeID,#ctl00_phDS_ds_ToolBar_ChangeID_item", "Change ID", locator, MenuOpener);
                ViewRestrictionGroups = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewRestrictionGroups,#ctl00_phDS_ds_ToolBar_ViewRestr" +
                        "ictionGroups_item", "Manage Restriction Groups", locator, MenuOpener);
                ViewSummary = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewSummary,#ctl00_phDS_ds_ToolBar_ViewSummary_item", "Inventory Summary", locator, MenuOpener);
                ViewAllocationDetails = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewAllocationDetails,#ctl00_phDS_ds_ToolBar_ViewAlloc" +
                        "ationDetails_item", "Inventory Allocation Details", locator, MenuOpener);
                ViewTransactionSummary = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewTransactionSummary,#ctl00_phDS_ds_ToolBar_ViewTran" +
                        "sactionSummary_item", "Inventory Transaction Summary", locator, MenuOpener);
                ViewTransactionDetails = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewTransactionDetails,#ctl00_phDS_ds_ToolBar_ViewTran" +
                        "sactionDetails_item", "Inventory Transaction Details", locator, MenuOpener);
                ViewTransactionHistory = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewTransactionHistory,#ctl00_phDS_ds_ToolBar_ViewTran" +
                        "sactionHistory_item", "Inventory Transaction History", locator, MenuOpener);
                GenerateLotSerialNumber = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_GenerateLotSerialNumber,#ctl00_phDS_ds_ToolBar_Generat" +
                        "eLotSerialNumber_item", "Generate Lot/Serial Number", locator, MenuOpener);
                PricesCategory = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Prices_Category", "Prices", locator, MenuOpener);
                OtherCategory = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Other_Category", "Other", locator, MenuOpener);
                Inquiry = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Inquiry", "Inquiries", locator, MenuOpener);
                LongRun = new ToolBarButton("css=qp-long-run", "Nothing in progress", locator, null);
                LongrunCancel = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_cancel", "Cancel", locator, null);
                LongrunTimer = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_timer", "Elapsed Time", locator, null);
            }
        }
        
        public class c_allscreens_screensgrid : Grid<c_allscreens_screensgrid.c_grid_row, c_allscreens_screensgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_allscreens_screensgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_screens_screensGrid");
                DataMemberName = "AllScreens";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_screens_screensGrid_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_screens_screensGrid_at_tlb div[d" +
                            "ata-cmd=\'Refresh\']", "Refresh", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_screens_screensGrid_at_tlb div[d" +
                            "ata-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_screens_screensGrid_ab_tlb div[d" +
                            "ata-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_screens_screensGrid_ab_tlb div[d" +
                            "ata-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_screens_screensGrid_ab_tlb div[d" +
                            "ata-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_screens_screensGrid_ab_tlb div[d" +
                            "ata-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_screens_screensGrid_ab_tlb div[d" +
                            "ata-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit Title { get; }
			public PXTextEdit ScreenID { get; }
			public PXTextEdit Module { get; }
			public PXTextEdit Url { get; }
                
                public c_grid_row(c_allscreens_screensgrid grid) : 
                        base(grid)
                {
                    Title = new PXTextEdit("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_screens_screensGrid_ei", "Title", grid.Locator, "Title");
                    Title.DataField = "Title";
                    ScreenID = new PXTextEdit("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_screens_screensGrid_ei", "ScreenID", grid.Locator, "ScreenID");
                    ScreenID.DataField = "ScreenID";
                    Module = new PXTextEdit("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_screens_screensGrid_ei", "Module", grid.Locator, "Module");
                    Module.DataField = "Module";
                    Url = new PXTextEdit("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_screens_screensGrid_ei", "Url", grid.Locator, "Url");
                    Url.DataField = "Url";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter Title { get; }
				public PXTextEditColumnFilter ScreenID { get; }
				public PXTextEditColumnFilter Module { get; }
				public PXTextEditColumnFilter Url { get; }
                
                public c_grid_header(c_allscreens_screensgrid grid) : 
                        base(grid)
                {
                    Title = new PXTextEditColumnFilter(grid.Row.Title);
                    ScreenID = new PXTextEditColumnFilter(grid.Row.ScreenID);
                    Module = new PXTextEditColumnFilter(grid.Row.Module);
                    Url = new PXTextEditColumnFilter(grid.Row.Url);
                }
            }
        }
        
        public class c_pages_articlesgrid : Grid<c_pages_articlesgrid.c_grid_row, c_pages_articlesgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_pages_articlesgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_articles_articlesGrid");
                DataMemberName = "Pages";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_articles_articlesGrid_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_articles_articlesGrid_at_tlb div" +
                            "[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_articles_articlesGrid_at_tlb div" +
                            "[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_articles_articlesGrid_ab_tlb div" +
                            "[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_articles_articlesGrid_ab_tlb div" +
                            "[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_articles_articlesGrid_ab_tlb div" +
                            "[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_articles_articlesGrid_ab_tlb div" +
                            "[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_articles_articlesGrid_ab_tlb div" +
                            "[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit Title { get; }
			public PXTextEdit WikiPageParent__Title { get; }
			public DateSelector CreatedDateTime { get; }
			public PXTextEdit PageID { get; }
                
                public c_grid_row(c_pages_articlesgrid grid) : 
                        base(grid)
                {
                    Title = new PXTextEdit("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_articles_articlesGrid_ei", "Title", grid.Locator, "Title");
                    Title.DataField = "Title";
                    WikiPageParent__Title = new PXTextEdit("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_articles_articlesGrid_ei", "Title", grid.Locator, "WikiPageParent__Title");
                    WikiPageParent__Title.DataField = "WikiPageParent__Title";
                    CreatedDateTime = new DateSelector("_ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_articles_articlesGrid_lv0_ed2", "Create", grid.Locator, "CreatedDateTime");
                    CreatedDateTime.DataField = "CreatedDateTime";
                    PageID = new PXTextEdit("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_articles_articlesGrid_ei", "PageID", grid.Locator, "PageID");
                    PageID.DataField = "PageID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter Title { get; }
				public PXTextEditColumnFilter WikiPageParent__Title { get; }
				public DateSelectorColumnFilter CreatedDateTime { get; }
				public PXTextEditColumnFilter PageID { get; }
                
                public c_grid_header(c_pages_articlesgrid grid) : 
                        base(grid)
                {
                    Title = new PXTextEditColumnFilter(grid.Row.Title);
                    WikiPageParent__Title = new PXTextEditColumnFilter(grid.Row.WikiPageParent__Title);
                    CreatedDateTime = new DateSelectorColumnFilter(grid.Row.CreatedDateTime);
                    PageID = new PXTextEditColumnFilter(grid.Row.PageID);
                }
            }
        }
        
        public class c_pages_lv0 : Container
        {
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
            
            public c_pages_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_articles_articlesGrid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                DataMemberName = "Pages";
            }
        }
        
        public class c_fileswithsize_filessearchgrid : Grid<c_fileswithsize_filessearchgrid.c_grid_row, c_fileswithsize_filessearchgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_fileswithsize_filessearchgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid");
                DataMemberName = "FilesWithSize";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_at_tlb " +
                            "div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_at_tlb " +
                            "div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ab_tlb " +
                            "div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ab_tlb " +
                            "div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ab_tlb " +
                            "div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ab_tlb " +
                            "div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ab_tlb " +
                            "div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public Selector Name { get; }
			public PXTextEdit Size { get; }
			public PXTextEdit Comment { get; }
			public PXTextEdit FileID { get; }
                
                public c_grid_row(c_fileswithsize_filessearchgrid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Name = new Selector("_ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_lv0_es", "Name", grid.Locator, "Name");
                    Name.DataField = "Name";
                    Size = new PXTextEdit("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ei", "Size (kb)", grid.Locator, "Size");
                    Size.DataField = "Size";
                    Comment = new PXTextEdit("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ei", "Comment", grid.Locator, "Comment");
                    Comment.DataField = "Comment";
                    FileID = new PXTextEdit("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_ei", "File", grid.Locator, "FileID");
                    FileID.DataField = "FileID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public SelectorColumnFilter Name { get; }
				public PXTextEditColumnFilter Size { get; }
				public PXTextEditColumnFilter Comment { get; }
				public PXTextEditColumnFilter FileID { get; }
                
                public c_grid_header(c_fileswithsize_filessearchgrid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Name = new SelectorColumnFilter(grid.Row.Name);
                    Size = new PXTextEditColumnFilter(grid.Row.Size);
                    Comment = new PXTextEditColumnFilter(grid.Row.Comment);
                    FileID = new PXTextEditColumnFilter(grid.Row.FileID);
                }
            }
        }
        
        public class c_fileswithsize_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_fileswithsize_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_allFiles_filesSearchGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "FilesWithSize";
            }
        }
        
        public class c_item_form : Container
        {
            
			public Selector InventoryCD { get; }
			public Label InventoryCDLabel { get; }
			public DropDown ItemStatus { get; }
			public Label ItemStatusLabel { get; }
			public Selector ProductWorkgroupID { get; }
			public Label ProductWorkgroupIDLabel { get; }
			public Selector ProductManagerID { get; }
			public Label ProductManagerIDLabel { get; }
			public InputLocalizable Descr { get; }
			public Label DescrLabel { get; }
			public CheckBox ChkEquipmentManagement { get; }
			public Label ChkEquipmentManagementLabel { get; }
            
            public c_item_form(string locator, string name) : 
                    base(locator, name)
            {
                InventoryCD = new Selector("ctl00_phF_form_edInventoryCD", "Inventory ID", locator, null);
                InventoryCDLabel = new Label(InventoryCD);
                InventoryCD.DataField = "InventoryCD";
                ItemStatus = new DropDown("ctl00_phF_form_edItemStatus", "Item Status", locator, null);
                ItemStatusLabel = new Label(ItemStatus);
                ItemStatus.DataField = "ItemStatus";
                ItemStatus.Items.Add("AC", "Active");
                ItemStatus.Items.Add("NS", "No Sales");
                ItemStatus.Items.Add("NP", "No Purchases");
                ItemStatus.Items.Add("NR", "No Request");
                ItemStatus.Items.Add("IN", "Inactive");
                ItemStatus.Items.Add("DE", "Marked for Deletion");
                ProductWorkgroupID = new Selector("ctl00_phF_form_edProductWorkgroupID", "Product Workgroup", locator, null);
                ProductWorkgroupIDLabel = new Label(ProductWorkgroupID);
                ProductWorkgroupID.DataField = "ProductWorkgroupID";
                ProductManagerID = new Selector("ctl00_phF_form_edProductManagerID", "Product Manager", locator, null);
                ProductManagerIDLabel = new Label(ProductManagerID);
                ProductManagerID.DataField = "ProductManagerID";
                Descr = new InputLocalizable("ctl00_phF_form_edDescr", "Description", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                ChkEquipmentManagement = new CheckBox("ctl00_phF_form_chkEquipmentManagement", "chkEquipmentManagement", locator, null);
                ChkEquipmentManagementLabel = new Label(ChkEquipmentManagement);
                ChkEquipmentManagement.DataField = "ChkEquipmentManagement";
                DataMemberName = "Item";
            }
        }
        
        public class c_parameters_gridwizard : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox IsDefault { get; }
			public Label IsDefaultLabel { get; }
			public CheckBox Override { get; }
			public Label OverrideLabel { get; }
			public Selector RoleName { get; }
			public Label RoleNameLabel { get; }
            
            public c_parameters_gridwizard(string locator, string name) : 
                    base(locator, name)
            {
                IsDefault = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_defaultCkbx", "Is Default", locator, null);
                IsDefaultLabel = new Label(IsDefault);
                IsDefault.DataField = "IsDefault";
                Override = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_overrideCkbx", "Override", locator, null);
                OverrideLabel = new Label(Override);
                Override.DataField = "Override";
                RoleName = new Selector("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_edRole", "Role Name", locator, null);
                RoleNameLabel = new Label(RoleName);
                RoleName.DataField = "RoleName";
                DataMemberName = "Parameters";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Finish()
            {
                Buttons.Finish.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Cancel { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Finish { get; }
                
                public PxButtonCollection()
                {
                    Cancel = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_cancel", "Cancel", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                    Prev = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_prev", "Prev", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                    Next = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_next", "Next", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                    Finish = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_save", "Finish", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                }
            }
        }
        
        public class c_profilerinfoview_formprofiler : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit StartText { get; }
			public Label StartTextLabel { get; }
			public PXTextEdit Started { get; }
			public Label StartedLabel { get; }
			public PXTextEdit RequestsLogged { get; }
			public Label RequestsLoggedLabel { get; }
			public PXTextEdit ExportText { get; }
			public Label ExportTextLabel { get; }
			public Label PXLabel1_ { get; }
			public Label LblPlace_ { get; }
            
            public c_profilerinfoview_formprofiler(string locator, string name) : 
                    base(locator, name)
            {
                StartText = new PXTextEdit("ctl00_usrCaption_pnlProfiler_formProfiler_lblStartText", "Start Text", locator, null);
                StartTextLabel = new Label(StartText);
                StartText.DataField = "StartText";
                Started = new PXTextEdit("ctl00_usrCaption_pnlProfiler_formProfiler_lblStartedAt", "Started", locator, null);
                StartedLabel = new Label(Started);
                Started.DataField = "Started";
                RequestsLogged = new PXTextEdit("ctl00_usrCaption_pnlProfiler_formProfiler_lblRequestsLogged", "Requests Logged", locator, null);
                RequestsLoggedLabel = new Label(RequestsLogged);
                RequestsLogged.DataField = "RequestsLogged";
                ExportText = new PXTextEdit("ctl00_usrCaption_pnlProfiler_formProfiler_lblExportText", "Export Text", locator, null);
                ExportTextLabel = new Label(ExportText);
                ExportText.DataField = "ExportText";
                PXLabel1_ = new Label("ctl00_usrCaption_pnlProfiler_formProfiler_PXLabel1", "PX Label 1_", locator, null);
                LblPlace_ = new Label("ctl00_usrCaption_pnlProfiler_formProfiler_lblPlace", "Lbl Place _", locator, null);
                DataMemberName = "ProfilerInfoView";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void BtnStartProfiler()
            {
                Buttons.BtnStartProfiler.Click();
            }
            
            public virtual void BtnStopProfiler()
            {
                Buttons.BtnStopProfiler.Click();
            }
            
            public virtual void BtnLastRequest()
            {
                Buttons.BtnLastRequest.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button BtnStartProfiler { get; }
			public Button BtnStopProfiler { get; }
			public Button BtnLastRequest { get; }
                
                public PxButtonCollection()
                {
                    BtnStartProfiler = new Button("ctl00_usrCaption_pnlProfiler_formProfiler_btnStartProfiler", "btnStartProfiler", "ctl00_usrCaption_pnlProfiler_formProfiler");
                    BtnStopProfiler = new Button("ctl00_usrCaption_pnlProfiler_formProfiler_btnStopProfiler", "btnStopProfiler", "ctl00_usrCaption_pnlProfiler_formProfiler");
                    BtnLastRequest = new Button("ctl00_usrCaption_pnlProfiler_formProfiler_btnLastRequest", "btnLastRequest", "ctl00_usrCaption_pnlProfiler_formProfiler");
                }
            }
        }
        
        public class c_firstselect_formactions : Container
        {
            
			public PXTextEdit Key { get; }
			public Label KeyLabel { get; }
            
            public c_firstselect_formactions(string locator, string name) : 
                    base(locator, name)
            {
                Key = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions_edKey", "Key", locator, null);
                KeyLabel = new Label(Key);
                Key.DataField = "Key";
                DataMemberName = "FirstSelect";
            }
        }
        
        public class c_comboboxvalues_gridcombos : Grid<c_comboboxvalues_gridcombos.c_grid_row, c_comboboxvalues_gridcombos.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_comboboxvalues_gridcombos(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos");
                DataMemberName = "ComboBoxValues";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_fe_gf", "FilterForm");
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void Close()
            {
                Buttons.Close.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Close { get; }
                
                public PxButtonCollection()
                {
                    Close = new Button("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_PXButton5", "Close", "ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit Value { get; }
			public PXTextEdit Description { get; }
                
                public c_grid_row(c_comboboxvalues_gridcombos grid) : 
                        base(grid)
                {
                    Value = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ei", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                    Description = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ei", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter Value { get; }
				public PXTextEditColumnFilter Description { get; }
                
                public c_grid_header(c_comboboxvalues_gridcombos grid) : 
                        base(grid)
                {
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                }
            }
        }
        
        public class c_vieweleminfo_formeleminfo : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AspxControl { get; }
			public Label AspxControlLabel { get; }
			public GroupBox IsComboBox { get; }
			public Label IsComboBoxLabel { get; }
			public PXTextEdit CacheType { get; }
			public Label CacheTypeLabel { get; }
			public PXTextEdit FieldName { get; }
			public Label FieldNameLabel { get; }
			public PXTextEdit ViewName { get; }
			public Label ViewNameLabel { get; }
			public PXTextEdit GraphName { get; }
			public Label GraphNameLabel { get; }
			public PXTextEdit ActionName { get; }
			public Label ActionNameLabel { get; }
            
            public c_vieweleminfo_formeleminfo(string locator, string name) : 
                    base(locator, name)
            {
                AspxControl = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_edAspxControl", "Control Type", locator, null);
                AspxControlLabel = new Label(AspxControl);
                AspxControl.DataField = "AspxControl";
                IsComboBox = new GroupBox("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_panelPXBUtton1", "Is Combo Box", locator, null);
                IsComboBoxLabel = new Label(IsComboBox);
                IsComboBox.DataField = "IsComboBox";
                CacheType = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_CacheType", "Data Class", locator, null);
                CacheTypeLabel = new Label(CacheType);
                CacheType.DataField = "CacheType";
                FieldName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_FieldName", "Data Field", locator, null);
                FieldNameLabel = new Label(FieldName);
                FieldName.DataField = "FieldName";
                ViewName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_ViewName", "View Name", locator, null);
                ViewNameLabel = new Label(ViewName);
                ViewName.DataField = "ViewName";
                GraphName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_GraphName", "Business Logic", locator, null);
                GraphNameLabel = new Label(GraphName);
                GraphName.DataField = "GraphName";
                ActionName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_ActionName", "Action Name", locator, null);
                ActionNameLabel = new Label(ActionName);
                ActionName.DataField = "ActionName";
                DataMemberName = "ViewElemInfo";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Drop_downValues()
            {
                Buttons.Drop_downValues.Click();
            }
            
            public virtual void Customize()
            {
                Buttons.Customize.Click();
            }
            
            public virtual void Actions()
            {
                Buttons.Actions.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Drop_downValues { get; }
			public Button Customize { get; }
			public Button Actions { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Drop_downValues = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_panelPXBUtton1_P" +
                            "XButton1", "Drop-down Values", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                    Customize = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_PXButton3", "Customize", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                    Actions = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_ButtonGraphActions", "Actions", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_PXButton4", "Cancel", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                }
            }
        }
        
        public class c_filterworkingproject_formnewproject : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NewProject { get; }
			public Label NewProjectLabel { get; }
            
            public c_filterworkingproject_formnewproject(string locator, string name) : 
                    base(locator, name)
            {
                NewProject = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject_edNewProject", "Project Name", locator, null);
                NewProjectLabel = new Label(NewProject);
                NewProject.DataField = "NewProject";
                DataMemberName = "FilterWorkingProject";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_DlgNewProjectButtonOk", "OK", "ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_DlgNewProjectButtonCancel", "Cancel", "ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject");
                }
            }
        }
        
        public class c_filterworkingproject_formselectproject : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Name { get; }
			public Label NameLabel { get; }
            
            public c_filterworkingproject_formselectproject(string locator, string name) : 
                    base(locator, name)
            {
                Name = new Selector("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject_edWP", "Project Name", locator, null);
                NameLabel = new Label(Name);
                Name.DataField = "Name";
                DataMemberName = "FilterWorkingProject";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void New()
            {
                Buttons.New.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
			public Button New { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_SelectProjectOk", "OK", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_SelectProjectCancel", "Cancel", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                    New = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_BtnNewProject", "New...", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                }
            }
        }
        
        public class c_gridlist_gridgrid : Grid<c_gridlist_gridgrid.c_grid_row, c_gridlist_gridgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_gridlist_gridgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid");
                DataMemberName = "GridList";
                FilterForm = new c_grid_filter("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_fe_gf", "FilterForm");
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public PXTextEdit View { get; }
			public PXTextEdit Id { get; }
                
                public c_grid_row(c_gridlist_gridgrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ef", "Included", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    View = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ei", "Table ID", grid.Locator, "View");
                    View.DataField = "View";
                    Id = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ei", "Grid ID", grid.Locator, "Id");
                    Id.DataField = "Id";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter View { get; }
				public PXTextEditColumnFilter Id { get; }
                
                public c_grid_header(c_gridlist_gridgrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    View = new PXTextEditColumnFilter(grid.Row.View);
                    Id = new PXTextEditColumnFilter(grid.Row.Id);
                }
            }
        }
        
        public class c_userlist_usergrid : Grid<c_userlist_usergrid.c_grid_row, c_userlist_usergrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_userlist_usergrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid");
                DataMemberName = "UserList";
                FilterForm = new c_grid_filter("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Included { get; }
			public Selector Username { get; }
			public PXTextEdit DisplayName { get; }
			public PXTextEdit Email { get; }
			public PXTextEdit Guest { get; }
			public DropDown State { get; }
                
                public c_grid_row(c_userlist_usergrid grid) : 
                        base(grid)
                {
                    Included = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ef", "Included", grid.Locator, "Included");
                    Included.DataField = "Included";
                    Username = new Selector("_ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_es", "Login", grid.Locator, "Username");
                    Username.DataField = "Username";
                    DisplayName = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ei", "Display Name", grid.Locator, "DisplayName");
                    DisplayName.DataField = "DisplayName";
                    Email = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ei", "Email", grid.Locator, "Email");
                    Email.DataField = "Email";
                    Guest = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ef", "Guest Account", grid.Locator, "Guest");
                    Guest.DataField = "Guest";
                    State = new DropDown("_ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_ec", "Status", grid.Locator, "State");
                    State.DataField = "State";
                    State.Items.Add("N", "Not Created");
                    State.Items.Add("O", "Online");
                    State.Items.Add("P", "Pending Activation");
                    State.Items.Add("D", "Disabled");
                    State.Items.Add("A", "Active");
                    State.Items.Add("L", "Temporarily Locked");
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Included { get; }
				public SelectorColumnFilter Username { get; }
				public PXTextEditColumnFilter DisplayName { get; }
				public PXTextEditColumnFilter Email { get; }
				public PXTextEditColumnFilter Guest { get; }
				public DropDownColumnFilter State { get; }
                
                public c_grid_header(c_userlist_usergrid grid) : 
                        base(grid)
                {
                    Included = new CheckBoxColumnFilter(grid.Row.Included);
                    Username = new SelectorColumnFilter(grid.Row.Username);
                    DisplayName = new PXTextEditColumnFilter(grid.Row.DisplayName);
                    Email = new PXTextEditColumnFilter(grid.Row.Email);
                    Guest = new PXTextEditColumnFilter(grid.Row.Guest);
                    State = new DropDownColumnFilter(grid.Row.State);
                }
            }
        }
        
        public class c_userlist_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_userlist_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "UserList";
            }
        }
        
        public class c_itemsettings_tab : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector TemplateItemID { get; }
			public Label TemplateItemIDLabel { get; }
			public Selector ItemClassID { get; }
			public Label ItemClassIDLabel { get; }
			public DropDown ItemType { get; }
			public Label ItemTypeLabel { get; }
			public CheckBox KitItem { get; }
			public Label KitItemLabel { get; }
			public DropDown ValMethod { get; }
			public Label ValMethodLabel { get; }
			public Selector TaxCategoryID { get; }
			public Label TaxCategoryIDLabel { get; }
			public Selector PostClassID { get; }
			public Label PostClassIDLabel { get; }
			public Selector LotSerClassID { get; }
			public Label LotSerClassIDLabel { get; }
			public PXTextEdit LotSerNumVal { get; }
			public Label LotSerNumValLabel { get; }
			public Selector CountryOfOrigin { get; }
			public Label CountryOfOriginLabel { get; }
			public Selector DefaultSubItemID { get; }
			public Label DefaultSubItemIDLabel { get; }
			public CheckBox DefaultSubItemOnEntry { get; }
			public Label DefaultSubItemOnEntryLabel { get; }
			public Selector BaseUnit { get; }
			public Label BaseUnitLabel { get; }
			public CheckBox DecimalBaseUnit { get; }
			public Label DecimalBaseUnitLabel { get; }
			public Selector SalesUnit { get; }
			public Label SalesUnitLabel { get; }
			public CheckBox DecimalSalesUnit { get; }
			public Label DecimalSalesUnitLabel { get; }
			public Selector PurchaseUnit { get; }
			public Label PurchaseUnitLabel { get; }
			public CheckBox DecimalPurchaseUnit { get; }
			public Label DecimalPurchaseUnitLabel { get; }
			public CheckBox WeightItem { get; }
			public Label WeightItemLabel { get; }
			public Selector CycleID { get; }
			public Label CycleIDLabel { get; }
			public Selector ABCCodeID { get; }
			public Label ABCCodeIDLabel { get; }
			public CheckBox ABCCodeIsFixed { get; }
			public Label ABCCodeIsFixedLabel { get; }
			public Selector MovementClassID { get; }
			public Label MovementClassIDLabel { get; }
			public CheckBox MovementClassIsFixed { get; }
			public Label MovementClassIsFixedLabel { get; }
			public Selector PriceClassID { get; }
			public Label PriceClassIDLabel { get; }
			public Selector PriceWorkgroupID { get; }
			public Label PriceWorkgroupIDLabel { get; }
			public Selector PriceManagerID { get; }
			public Label PriceManagerIDLabel { get; }
			public CheckBox Commisionable { get; }
			public Label CommisionableLabel { get; }
			public PXNumberEdit MinGrossProfitPct { get; }
			public Label MinGrossProfitPctLabel { get; }
			public PXNumberEdit MarkupPct { get; }
			public Label MarkupPctLabel { get; }
			public Selector AMBOMID { get; }
			public Label AMBOMIDLabel { get; }
			public Selector AMPlanningBOMID { get; }
			public Label AMPlanningBOMIDLabel { get; }
			public Selector AMConfigurationID { get; }
			public Label AMConfigurationIDLabel { get; }
			public PXNumberEdit AMGroupWindow { get; }
			public Label AMGroupWindowLabel { get; }
			public DropDown AMDefaultMarkFor { get; }
			public Label AMDefaultMarkForLabel { get; }
			public CheckBox AMMakeToOrderItem { get; }
			public Label AMMakeToOrderItemLabel { get; }
			public CheckBox AMMRPItem { get; }
			public Label AMMRPItemLabel { get; }
			public CheckBox AMQtyRoundUp { get; }
			public Label AMQtyRoundUpLabel { get; }
			public CheckBox AMCTPItem { get; }
			public Label AMCTPItemLabel { get; }
			public DropDown AMReplenishmentSource { get; }
			public Label AMReplenishmentSourceLabel { get; }
			public CheckBox AMReplenishmentSourceOverride { get; }
			public Label AMReplenishmentSourceOverrideLabel { get; }
			public PXNumberEdit AMSafetyStock { get; }
			public Label AMSafetyStockLabel { get; }
			public CheckBox AMSafetyStockOverride { get; }
			public Label AMSafetyStockOverrideLabel { get; }
			public PXNumberEdit AMMinQty { get; }
			public Label AMMinQtyLabel { get; }
			public CheckBox AMMinQtyOverride { get; }
			public Label AMMinQtyOverrideLabel { get; }
			public PXNumberEdit AMMinOrdQty { get; }
			public Label AMMinOrdQtyLabel { get; }
			public PXNumberEdit AMMaxOrdQty { get; }
			public Label AMMaxOrdQtyLabel { get; }
			public PXNumberEdit AMLotSize { get; }
			public Label AMLotSizeLabel { get; }
			public PXNumberEdit AMMFGLeadTime { get; }
			public Label AMMFGLeadTimeLabel { get; }
			public Selector AMScrapSiteID { get; }
			public Label AMScrapSiteIDLabel { get; }
			public Selector AMScrapLocationID { get; }
			public Label AMScrapLocationIDLabel { get; }
			public CheckBox AMCheckSchdMatlAvailability { get; }
			public Label AMCheckSchdMatlAvailabilityLabel { get; }
			public ImageUploader ImageUrl { get; }
			public Label ImageUrlLabel { get; }
			public PXNumberEdit BaseItemWeight { get; }
			public Label BaseItemWeightLabel { get; }
			public Selector WeightUOM { get; }
			public Label WeightUOMLabel { get; }
			public PXNumberEdit BaseItemVolume { get; }
			public Label BaseItemVolumeLabel { get; }
			public Selector VolumeUOM { get; }
			public Label VolumeUOMLabel { get; }
			public PXTextEdit HSTariffCode { get; }
			public Label HSTariffCodeLabel { get; }
			public PXNumberEdit UndershipThreshold { get; }
			public Label UndershipThresholdLabel { get; }
			public PXNumberEdit OvershipThreshold { get; }
			public Label OvershipThresholdLabel { get; }
			public DropDown PackageOption { get; }
			public Label PackageOptionLabel { get; }
			public CheckBox PackSeparately { get; }
			public Label PackSeparatelyLabel { get; }
			public Selector InvtAcctID { get; }
			public Label InvtAcctIDLabel { get; }
			public Selector InvtSubID { get; }
			public Label InvtSubIDLabel { get; }
			public Selector ReasonCodeSubID { get; }
			public Label ReasonCodeSubIDLabel { get; }
			public Selector SalesAcctID { get; }
			public Label SalesAcctIDLabel { get; }
			public Selector SalesSubID { get; }
			public Label SalesSubIDLabel { get; }
			public Selector COGSAcctID { get; }
			public Label COGSAcctIDLabel { get; }
			public Selector COGSSubID { get; }
			public Label COGSSubIDLabel { get; }
			public Selector StdCstVarAcctID { get; }
			public Label StdCstVarAcctIDLabel { get; }
			public Selector StdCstVarSubID { get; }
			public Label StdCstVarSubIDLabel { get; }
			public Selector StdCstRevAcctID { get; }
			public Label StdCstRevAcctIDLabel { get; }
			public Selector StdCstRevSubID { get; }
			public Label StdCstRevSubIDLabel { get; }
			public Selector POAccrualAcctID { get; }
			public Label POAccrualAcctIDLabel { get; }
			public Selector POAccrualSubID { get; }
			public Label POAccrualSubIDLabel { get; }
			public Selector PPVAcctID { get; }
			public Label PPVAcctIDLabel { get; }
			public Selector PPVSubID { get; }
			public Label PPVSubIDLabel { get; }
			public Selector LCVarianceAcctID { get; }
			public Label LCVarianceAcctIDLabel { get; }
			public Selector LCVarianceSubID { get; }
			public Label LCVarianceSubIDLabel { get; }
			public Selector DeferralAcctID { get; }
			public Label DeferralAcctIDLabel { get; }
			public Selector DeferralSubID { get; }
			public Label DeferralSubIDLabel { get; }
			public Selector AMWIPAcctID { get; }
			public Label AMWIPAcctIDLabel { get; }
			public Selector AMWIPSubID { get; }
			public Label AMWIPSubIDLabel { get; }
			public Selector AMWIPVarianceAcctID { get; }
			public Label AMWIPVarianceAcctIDLabel { get; }
			public Selector AMWIPVarianceSubID { get; }
			public Label AMWIPVarianceSubIDLabel { get; }
			public RichTextEdit Body { get; }
			public Label BodyLabel { get; }
			public CheckBox ExportToExternal { get; }
			public Label ExportToExternalLabel { get; }
			public DropDown Visibility { get; }
			public Label VisibilityLabel { get; }
			public DropDown Availability { get; }
			public Label AvailabilityLabel { get; }
			public DropDown NotAvailMode { get; }
			public Label NotAvailModeLabel { get; }
			public PXTextEdit CustomURL { get; }
			public Label CustomURLLabel { get; }
			public PXTextEdit PageTitle { get; }
			public Label PageTitleLabel { get; }
			public PXTextEdit ShortDescription { get; }
			public Label ShortDescriptionLabel { get; }
			public PXTextEdit SearchKeywords { get; }
			public Label SearchKeywordsLabel { get; }
			public PXTextEdit MetaKeywords { get; }
			public Label MetaKeywordsLabel { get; }
			public PXTextEdit MetaDescription { get; }
			public Label MetaDescriptionLabel { get; }
			public Label Label1_importColumnDlg { get; }
			public Label LblImportSource_ { get; }
			public Label LblPassword_ { get; }
			public Label Ctl08_ { get; }
			public Label Ctl21_ { get; }
			public Label Pixwidth_ { get; }
			public Label Pixcaption_ { get; }
			public Label Ctl34_ { get; }
            
            public c_itemsettings_tab(string locator, string name) : 
                    base(locator, name)
            {
                TemplateItemID = new Selector("ctl00_phG_tab_t0_edTemplateItemID", "Template ID", locator, null);
                TemplateItemIDLabel = new Label(TemplateItemID);
                TemplateItemID.DataField = "TemplateItemID";
                ItemClassID = new Selector("ctl00_phG_tab_t0_edItemClassID", "Item Class", locator, null);
                ItemClassIDLabel = new Label(ItemClassID);
                ItemClassID.DataField = "ItemClassID";
                ItemType = new DropDown("ctl00_phG_tab_t0_edItemType", "Type", locator, null);
                ItemTypeLabel = new Label(ItemType);
                ItemType.DataField = "ItemType";
                ItemType.Items.Add("F", "Finished Good");
                ItemType.Items.Add("M", "Component Part");
                ItemType.Items.Add("A", "Subassembly");
                KitItem = new CheckBox("ctl00_phG_tab_t0_chkKitItem", "Is a Kit", locator, null);
                KitItemLabel = new Label(KitItem);
                KitItem.DataField = "KitItem";
                ValMethod = new DropDown("ctl00_phG_tab_t0_edValMethod", "Valuation Method", locator, null);
                ValMethodLabel = new Label(ValMethod);
                ValMethod.DataField = "ValMethod";
                ValMethod.Items.Add("T", "Standard");
                ValMethod.Items.Add("A", "Average");
                ValMethod.Items.Add("F", "FIFO");
                ValMethod.Items.Add("S", "Specific");
                TaxCategoryID = new Selector("ctl00_phG_tab_t0_edTaxCategoryID", "Tax Category", locator, null);
                TaxCategoryIDLabel = new Label(TaxCategoryID);
                TaxCategoryID.DataField = "TaxCategoryID";
                PostClassID = new Selector("ctl00_phG_tab_t0_edPostClassID", "Posting Class", locator, null);
                PostClassIDLabel = new Label(PostClassID);
                PostClassID.DataField = "PostClassID";
                LotSerClassID = new Selector("ctl00_phG_tab_t0_edLotSerClassID", "Lot/Serial Class", locator, null);
                LotSerClassIDLabel = new Label(LotSerClassID);
                LotSerClassID.DataField = "LotSerClassID";
                LotSerNumVal = new PXTextEdit("ctl00_phG_tab_t0_edLotSerNumVal", "Auto-Incremental Value", locator, null);
                LotSerNumValLabel = new Label(LotSerNumVal);
                LotSerNumVal.DataField = "LotSerNumVal";
                CountryOfOrigin = new Selector("ctl00_phG_tab_t0_edCountryOfOrigin", "Country Of Origin", locator, null);
                CountryOfOriginLabel = new Label(CountryOfOrigin);
                CountryOfOrigin.DataField = "CountryOfOrigin";
                DefaultSubItemID = new Selector("ctl00_phG_tab_t0_edDefaultSubItemID", "Default Subitem", locator, null);
                DefaultSubItemIDLabel = new Label(DefaultSubItemID);
                DefaultSubItemID.DataField = "DefaultSubItemID";
                DefaultSubItemOnEntry = new CheckBox("ctl00_phG_tab_t0_chkDefaultSubItemOnEntry", "Use On Entry", locator, null);
                DefaultSubItemOnEntryLabel = new Label(DefaultSubItemOnEntry);
                DefaultSubItemOnEntry.DataField = "DefaultSubItemOnEntry";
                BaseUnit = new Selector("ctl00_phG_tab_t0_edBaseUnit", "Base Unit", locator, null);
                BaseUnitLabel = new Label(BaseUnit);
                BaseUnit.DataField = "BaseUnit";
                DecimalBaseUnit = new CheckBox("ctl00_phG_tab_t0_chkDecimalBaseUnit", "Divisible Unit", locator, null);
                DecimalBaseUnitLabel = new Label(DecimalBaseUnit);
                DecimalBaseUnit.DataField = "DecimalBaseUnit";
                SalesUnit = new Selector("ctl00_phG_tab_t0_edSalesUnit", "Sales Unit", locator, null);
                SalesUnitLabel = new Label(SalesUnit);
                SalesUnit.DataField = "SalesUnit";
                DecimalSalesUnit = new CheckBox("ctl00_phG_tab_t0_chkDecimalSalesUnit", "Divisible Unit", locator, null);
                DecimalSalesUnitLabel = new Label(DecimalSalesUnit);
                DecimalSalesUnit.DataField = "DecimalSalesUnit";
                PurchaseUnit = new Selector("ctl00_phG_tab_t0_edPurchaseUnit", "Purchase Unit", locator, null);
                PurchaseUnitLabel = new Label(PurchaseUnit);
                PurchaseUnit.DataField = "PurchaseUnit";
                DecimalPurchaseUnit = new CheckBox("ctl00_phG_tab_t0_chkDecimalPurchaseUnit", "Divisible Unit", locator, null);
                DecimalPurchaseUnitLabel = new Label(DecimalPurchaseUnit);
                DecimalPurchaseUnit.DataField = "DecimalPurchaseUnit";
                WeightItem = new CheckBox("ctl00_phG_tab_t0_chkWeightItem", "Weight Item", locator, null);
                WeightItemLabel = new Label(WeightItem);
                WeightItem.DataField = "WeightItem";
                CycleID = new Selector("ctl00_phG_tab_t0_edPICycleID", "PI Cycle", locator, null);
                CycleIDLabel = new Label(CycleID);
                CycleID.DataField = "CycleID";
                ABCCodeID = new Selector("ctl00_phG_tab_t0_edABCCodeID", "ABC Code", locator, null);
                ABCCodeIDLabel = new Label(ABCCodeID);
                ABCCodeID.DataField = "ABCCodeID";
                ABCCodeIsFixed = new CheckBox("ctl00_phG_tab_t0_chkABCCodeIsFixed", "Fixed ABC Code", locator, null);
                ABCCodeIsFixedLabel = new Label(ABCCodeIsFixed);
                ABCCodeIsFixed.DataField = "ABCCodeIsFixed";
                MovementClassID = new Selector("ctl00_phG_tab_t0_edMovementClassID", "Movement Class", locator, null);
                MovementClassIDLabel = new Label(MovementClassID);
                MovementClassID.DataField = "MovementClassID";
                MovementClassIsFixed = new CheckBox("ctl00_phG_tab_t0_chkMovementClassIsFixed", "Fixed Movement Class", locator, null);
                MovementClassIsFixedLabel = new Label(MovementClassIsFixed);
                MovementClassIsFixed.DataField = "MovementClassIsFixed";
                PriceClassID = new Selector("ctl00_phG_tab_t2_edPriceClassID", "Price Class", locator, null);
                PriceClassIDLabel = new Label(PriceClassID);
                PriceClassID.DataField = "PriceClassID";
                PriceWorkgroupID = new Selector("ctl00_phG_tab_t2_edPriceWorkgroupID", "Price Workgroup", locator, null);
                PriceWorkgroupIDLabel = new Label(PriceWorkgroupID);
                PriceWorkgroupID.DataField = "PriceWorkgroupID";
                PriceManagerID = new Selector("ctl00_phG_tab_t2_edPriceManagerID", "Price Manager", locator, null);
                PriceManagerIDLabel = new Label(PriceManagerID);
                PriceManagerID.DataField = "PriceManagerID";
                Commisionable = new CheckBox("ctl00_phG_tab_t2_chkCommisionable", "Subject to Commission", locator, null);
                CommisionableLabel = new Label(Commisionable);
                Commisionable.DataField = "Commisionable";
                MinGrossProfitPct = new PXNumberEdit("ctl00_phG_tab_t2_edMinGrossProfitPct", "Min. Markup %", locator, null);
                MinGrossProfitPctLabel = new Label(MinGrossProfitPct);
                MinGrossProfitPct.DataField = "MinGrossProfitPct";
                MarkupPct = new PXNumberEdit("ctl00_phG_tab_t2_edMarkupPct", "Markup %", locator, null);
                MarkupPctLabel = new Label(MarkupPct);
                MarkupPct.DataField = "MarkupPct";
                AMBOMID = new Selector("ctl00_phG_tab_t3_edAMBOMID", "Default BOM ID", locator, null);
                AMBOMIDLabel = new Label(AMBOMID);
                AMBOMID.DataField = "AMBOMID";
                AMPlanningBOMID = new Selector("ctl00_phG_tab_t3_edAMPlanningBOMID", "Planning BOM ID", locator, null);
                AMPlanningBOMIDLabel = new Label(AMPlanningBOMID);
                AMPlanningBOMID.DataField = "AMPlanningBOMID";
                AMConfigurationID = new Selector("ctl00_phG_tab_t3_edAMConfigurationID", "Configuration ID", locator, null);
                AMConfigurationIDLabel = new Label(AMConfigurationID);
                AMConfigurationID.DataField = "AMConfigurationID";
                AMGroupWindow = new PXNumberEdit("ctl00_phG_tab_t3_edAMGroupWindow", "Group Planning", locator, null);
                AMGroupWindowLabel = new Label(AMGroupWindow);
                AMGroupWindow.DataField = "AMGroupWindow";
                AMDefaultMarkFor = new DropDown("ctl00_phG_tab_t3_edAMDefaultMarkFor", "Dflt Mark For", locator, null);
                AMDefaultMarkForLabel = new Label(AMDefaultMarkFor);
                AMDefaultMarkFor.DataField = "AMDefaultMarkFor";
                AMMakeToOrderItem = new CheckBox("ctl00_phG_tab_t3_chkAMMakeToOrderItem", "Make to Order Item", locator, null);
                AMMakeToOrderItemLabel = new Label(AMMakeToOrderItem);
                AMMakeToOrderItem.DataField = "AMMakeToOrderItem";
                AMMRPItem = new CheckBox("ctl00_phG_tab_t3_chkAMMRPItem", "MRP Item", locator, null);
                AMMRPItemLabel = new Label(AMMRPItem);
                AMMRPItem.DataField = "AMMRPItem";
                AMQtyRoundUp = new CheckBox("ctl00_phG_tab_t3_chkAMQtyRoundUp", "Quantity Round Up", locator, null);
                AMQtyRoundUpLabel = new Label(AMQtyRoundUp);
                AMQtyRoundUp.DataField = "AMQtyRoundUp";
                AMCTPItem = new CheckBox("ctl00_phG_tab_t3_chkAMCTPItem", "CTP Item", locator, null);
                AMCTPItemLabel = new Label(AMCTPItem);
                AMCTPItem.DataField = "AMCTPItem";
                AMReplenishmentSource = new DropDown("ctl00_phG_tab_t3_edAMReplenishmentSource", "Source", locator, null);
                AMReplenishmentSourceLabel = new Label(AMReplenishmentSource);
                AMReplenishmentSource.DataField = "AMReplenishmentSource";
                AMReplenishmentSourceOverride = new CheckBox("ctl00_phG_tab_t3_chkAMReplenishmentSourceOverride", "Override", locator, null);
                AMReplenishmentSourceOverrideLabel = new Label(AMReplenishmentSourceOverride);
                AMReplenishmentSourceOverride.DataField = "AMReplenishmentSourceOverride";
                AMSafetyStock = new PXNumberEdit("ctl00_phG_tab_t3_edAMSafetyStock", "Safety Stock", locator, null);
                AMSafetyStockLabel = new Label(AMSafetyStock);
                AMSafetyStock.DataField = "AMSafetyStock";
                AMSafetyStockOverride = new CheckBox("ctl00_phG_tab_t3_chkAMSafetyStockOverride", "Override", locator, null);
                AMSafetyStockOverrideLabel = new Label(AMSafetyStockOverride);
                AMSafetyStockOverride.DataField = "AMSafetyStockOverride";
                AMMinQty = new PXNumberEdit("ctl00_phG_tab_t3_edAMMinQty", "Reorder Point", locator, null);
                AMMinQtyLabel = new Label(AMMinQty);
                AMMinQty.DataField = "AMMinQty";
                AMMinQtyOverride = new CheckBox("ctl00_phG_tab_t3_chkAMMinQtyOverride", "Override", locator, null);
                AMMinQtyOverrideLabel = new Label(AMMinQtyOverride);
                AMMinQtyOverride.DataField = "AMMinQtyOverride";
                AMMinOrdQty = new PXNumberEdit("ctl00_phG_tab_t3_edAMMinOrdQty", "Min Order Qty", locator, null);
                AMMinOrdQtyLabel = new Label(AMMinOrdQty);
                AMMinOrdQty.DataField = "AMMinOrdQty";
                AMMaxOrdQty = new PXNumberEdit("ctl00_phG_tab_t3_edAMMaxOrdQty", "Max Order Qty", locator, null);
                AMMaxOrdQtyLabel = new Label(AMMaxOrdQty);
                AMMaxOrdQty.DataField = "AMMaxOrdQty";
                AMLotSize = new PXNumberEdit("ctl00_phG_tab_t3_edAMLotSize", "Lot Size", locator, null);
                AMLotSizeLabel = new Label(AMLotSize);
                AMLotSize.DataField = "AMLotSize";
                AMMFGLeadTime = new PXNumberEdit("ctl00_phG_tab_t3_edAMMFGLeadTime", "MFG Lead Time", locator, null);
                AMMFGLeadTimeLabel = new Label(AMMFGLeadTime);
                AMMFGLeadTime.DataField = "AMMFGLeadTime";
                AMScrapSiteID = new Selector("ctl00_phG_tab_t3_edAMScrapSiteID", "Scrap Warehouse", locator, null);
                AMScrapSiteIDLabel = new Label(AMScrapSiteID);
                AMScrapSiteID.DataField = "AMScrapSiteID";
                AMScrapLocationID = new Selector("ctl00_phG_tab_t3_edAMScrapLocationID", "Scrap Location", locator, null);
                AMScrapLocationIDLabel = new Label(AMScrapLocationID);
                AMScrapLocationID.DataField = "AMScrapLocationID";
                AMCheckSchdMatlAvailability = new CheckBox("ctl00_phG_tab_t3_edAMCheckSchdMatlAvailability", "Check for Material Availability", locator, null);
                AMCheckSchdMatlAvailabilityLabel = new Label(AMCheckSchdMatlAvailability);
                AMCheckSchdMatlAvailability.DataField = "AMCheckSchdMatlAvailability";
                ImageUrl = new ImageUploader("ctl00_phG_tab_t6_imgUploader", "Image", locator);
                ImageUrlLabel = new Label(ImageUrl);
                ImageUrl.DataField = "ImageUrl";
                BaseItemWeight = new PXNumberEdit("ctl00_phG_tab_t7_edBaseItemWeight", "Weight", locator, null);
                BaseItemWeightLabel = new Label(BaseItemWeight);
                BaseItemWeight.DataField = "BaseItemWeight";
                WeightUOM = new Selector("ctl00_phG_tab_t7_edWeightUOM", "Weight UOM", locator, null);
                WeightUOMLabel = new Label(WeightUOM);
                WeightUOM.DataField = "WeightUOM";
                BaseItemVolume = new PXNumberEdit("ctl00_phG_tab_t7_edBaseItemVolume", "Volume", locator, null);
                BaseItemVolumeLabel = new Label(BaseItemVolume);
                BaseItemVolume.DataField = "BaseItemVolume";
                VolumeUOM = new Selector("ctl00_phG_tab_t7_edVolumeUOM", "Volume UOM", locator, null);
                VolumeUOMLabel = new Label(VolumeUOM);
                VolumeUOM.DataField = "VolumeUOM";
                HSTariffCode = new PXTextEdit("ctl00_phG_tab_t7_edHSTariffCode", "Tariff Code", locator, null);
                HSTariffCodeLabel = new Label(HSTariffCode);
                HSTariffCode.DataField = "HSTariffCode";
                UndershipThreshold = new PXNumberEdit("ctl00_phG_tab_t7_edUndershipThreshold", "Undership Threshold (%)", locator, null);
                UndershipThresholdLabel = new Label(UndershipThreshold);
                UndershipThreshold.DataField = "UndershipThreshold";
                OvershipThreshold = new PXNumberEdit("ctl00_phG_tab_t7_edOvershipThreshold", "Overship Threshold (%)", locator, null);
                OvershipThresholdLabel = new Label(OvershipThreshold);
                OvershipThreshold.DataField = "OvershipThreshold";
                PackageOption = new DropDown("ctl00_phG_tab_t7_edPackageOption", "Packaging Option", locator, null);
                PackageOptionLabel = new Label(PackageOption);
                PackageOption.DataField = "PackageOption";
                PackageOption.Items.Add("N", "Manual");
                PackageOption.Items.Add("W", "By Weight");
                PackageOption.Items.Add("Q", "By Quantity");
                PackageOption.Items.Add("V", "By Weight & Volume");
                PackSeparately = new CheckBox("ctl00_phG_tab_t7_edPackSeparately", "Pack Separately", locator, null);
                PackSeparatelyLabel = new Label(PackSeparately);
                PackSeparately.DataField = "PackSeparately";
                InvtAcctID = new Selector("ctl00_phG_tab_t12_edInvtAcctID", "Inventory Account", locator, null);
                InvtAcctIDLabel = new Label(InvtAcctID);
                InvtAcctID.DataField = "InvtAcctID";
                InvtSubID = new Selector("ctl00_phG_tab_t12_edInvtSubID", "Inventory Sub.", locator, null);
                InvtSubIDLabel = new Label(InvtSubID);
                InvtSubID.DataField = "InvtSubID";
                ReasonCodeSubID = new Selector("ctl00_phG_tab_t12_edReasonCodeSubID", "Reason Code Sub.", locator, null);
                ReasonCodeSubIDLabel = new Label(ReasonCodeSubID);
                ReasonCodeSubID.DataField = "ReasonCodeSubID";
                SalesAcctID = new Selector("ctl00_phG_tab_t12_edSalesAcctID", "Sales Account", locator, null);
                SalesAcctIDLabel = new Label(SalesAcctID);
                SalesAcctID.DataField = "SalesAcctID";
                SalesSubID = new Selector("ctl00_phG_tab_t12_edSalesSubID", "Sales Sub.", locator, null);
                SalesSubIDLabel = new Label(SalesSubID);
                SalesSubID.DataField = "SalesSubID";
                COGSAcctID = new Selector("ctl00_phG_tab_t12_edCOGSAcctID", "COGS Account", locator, null);
                COGSAcctIDLabel = new Label(COGSAcctID);
                COGSAcctID.DataField = "COGSAcctID";
                COGSSubID = new Selector("ctl00_phG_tab_t12_edCOGSSubID", "COGS Sub.", locator, null);
                COGSSubIDLabel = new Label(COGSSubID);
                COGSSubID.DataField = "COGSSubID";
                StdCstVarAcctID = new Selector("ctl00_phG_tab_t12_edStdCstVarAcctID", "Standard Cost Variance Account", locator, null);
                StdCstVarAcctIDLabel = new Label(StdCstVarAcctID);
                StdCstVarAcctID.DataField = "StdCstVarAcctID";
                StdCstVarSubID = new Selector("ctl00_phG_tab_t12_edStdCstVarSubID", "Standard Cost Variance Sub.", locator, null);
                StdCstVarSubIDLabel = new Label(StdCstVarSubID);
                StdCstVarSubID.DataField = "StdCstVarSubID";
                StdCstRevAcctID = new Selector("ctl00_phG_tab_t12_edStdCstRevAcctID", "Standard Cost Revaluation Account", locator, null);
                StdCstRevAcctIDLabel = new Label(StdCstRevAcctID);
                StdCstRevAcctID.DataField = "StdCstRevAcctID";
                StdCstRevSubID = new Selector("ctl00_phG_tab_t12_edStdCstRevSubID", "Standard Cost Revaluation Sub.", locator, null);
                StdCstRevSubIDLabel = new Label(StdCstRevSubID);
                StdCstRevSubID.DataField = "StdCstRevSubID";
                POAccrualAcctID = new Selector("ctl00_phG_tab_t12_edPOAccrualAcctID", "PO Accrual Account", locator, null);
                POAccrualAcctIDLabel = new Label(POAccrualAcctID);
                POAccrualAcctID.DataField = "POAccrualAcctID";
                POAccrualSubID = new Selector("ctl00_phG_tab_t12_edPOAccrualSubID", "PO Accrual Sub.", locator, null);
                POAccrualSubIDLabel = new Label(POAccrualSubID);
                POAccrualSubID.DataField = "POAccrualSubID";
                PPVAcctID = new Selector("ctl00_phG_tab_t12_edPPVAcctID", "Purchase Price Variance Account", locator, null);
                PPVAcctIDLabel = new Label(PPVAcctID);
                PPVAcctID.DataField = "PPVAcctID";
                PPVSubID = new Selector("ctl00_phG_tab_t12_edPPVSubID", "Purchase Price Variance Sub.", locator, null);
                PPVSubIDLabel = new Label(PPVSubID);
                PPVSubID.DataField = "PPVSubID";
                LCVarianceAcctID = new Selector("ctl00_phG_tab_t12_edLCVarianceAcctID", "Landed Cost Variance Account", locator, null);
                LCVarianceAcctIDLabel = new Label(LCVarianceAcctID);
                LCVarianceAcctID.DataField = "LCVarianceAcctID";
                LCVarianceSubID = new Selector("ctl00_phG_tab_t12_edLCVarianceSubID", "Landed Cost Variance Sub.", locator, null);
                LCVarianceSubIDLabel = new Label(LCVarianceSubID);
                LCVarianceSubID.DataField = "LCVarianceSubID";
                DeferralAcctID = new Selector("ctl00_phG_tab_t12_edDeferralAcctID", "Deferral Account", locator, null);
                DeferralAcctIDLabel = new Label(DeferralAcctID);
                DeferralAcctID.DataField = "DeferralAcctID";
                DeferralSubID = new Selector("ctl00_phG_tab_t12_edDeferralSubID", "Deferral Sub.", locator, null);
                DeferralSubIDLabel = new Label(DeferralSubID);
                DeferralSubID.DataField = "DeferralSubID";
                AMWIPAcctID = new Selector("ctl00_phG_tab_t12_edWIPAcctID", "Work In Process Account", locator, null);
                AMWIPAcctIDLabel = new Label(AMWIPAcctID);
                AMWIPAcctID.DataField = "AMWIPAcctID";
                AMWIPSubID = new Selector("ctl00_phG_tab_t12_edWIPSubID", "Work In Process Sub.", locator, null);
                AMWIPSubIDLabel = new Label(AMWIPSubID);
                AMWIPSubID.DataField = "AMWIPSubID";
                AMWIPVarianceAcctID = new Selector("ctl00_phG_tab_t12_edAMWIPVarianceAcctID", "WIP Variance Account", locator, null);
                AMWIPVarianceAcctIDLabel = new Label(AMWIPVarianceAcctID);
                AMWIPVarianceAcctID.DataField = "AMWIPVarianceAcctID";
                AMWIPVarianceSubID = new Selector("ctl00_phG_tab_t12_edAMWIPVarianceSubID", "WIP Variance Sub.", locator, null);
                AMWIPVarianceSubIDLabel = new Label(AMWIPVarianceSubID);
                AMWIPVarianceSubID.DataField = "AMWIPVarianceSubID";
                Body = new RichTextEdit("ctl00_phG_tab_t14_edBody", "Body", locator, null);
                BodyLabel = new Label(Body);
                Body.DataField = "Body";
                ExportToExternal = new CheckBox("ctl00_phG_tab_t17_edExportToExternal", "Export to External System", locator, null);
                ExportToExternalLabel = new Label(ExportToExternal);
                ExportToExternal.DataField = "ExportToExternal";
                Visibility = new DropDown("ctl00_phG_tab_t17_edVisibility", "Visibility", locator, null);
                VisibilityLabel = new Label(Visibility);
                Visibility.DataField = "Visibility";
                Availability = new DropDown("ctl00_phG_tab_t17_edAvailability", "Availability", locator, null);
                AvailabilityLabel = new Label(Availability);
                Availability.DataField = "Availability";
                NotAvailMode = new DropDown("ctl00_phG_tab_t17_edNotAvailMode", "When Qty Unavailable", locator, null);
                NotAvailModeLabel = new Label(NotAvailMode);
                NotAvailMode.DataField = "NotAvailMode";
                CustomURL = new PXTextEdit("ctl00_phG_tab_t17_edCustomURL", "Custom URL", locator, null);
                CustomURLLabel = new Label(CustomURL);
                CustomURL.DataField = "CustomURL";
                PageTitle = new PXTextEdit("ctl00_phG_tab_t17_edPageTitle", "Page Title", locator, null);
                PageTitleLabel = new Label(PageTitle);
                PageTitle.DataField = "PageTitle";
                ShortDescription = new PXTextEdit("ctl00_phG_tab_t17_edShortDescription", "Short Description", locator, null);
                ShortDescriptionLabel = new Label(ShortDescription);
                ShortDescription.DataField = "ShortDescription";
                SearchKeywords = new PXTextEdit("ctl00_phG_tab_t17_edSearchKeywords", "Search Keywords", locator, null);
                SearchKeywordsLabel = new Label(SearchKeywords);
                SearchKeywords.DataField = "SearchKeywords";
                MetaKeywords = new PXTextEdit("ctl00_phG_tab_t17_edMetaKeywords", "Meta Keywords", locator, null);
                MetaKeywordsLabel = new Label(MetaKeywords);
                MetaKeywords.DataField = "MetaKeywords";
                MetaDescription = new PXTextEdit("ctl00_phG_tab_t17_edMetaDescription", "Meta Description", locator, null);
                MetaDescriptionLabel = new Label(MetaDescription);
                MetaDescription.DataField = "MetaDescription";
                Label1_importColumnDlg = new Label("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_Label1", "Choose corresponding item properties.", locator, null);
                LblImportSource_ = new Label("ctl00_phG_tab_t9_relatedItemsGrid_imp_upl_pnl_lblImportSource", "File path:", locator, null);
                LblPassword_ = new Label("ctl00_phG_tab_t9_relatedItemsGrid_imp_upl_pnl_lblPassword", "Password:", locator, null);
                Ctl08_ = new Label("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_ctl08", "Enter file URL here", locator, null);
                Ctl21_ = new Label("ctl00_phG_tab_t14_edBody_insi2_splitter_rpnl_ctl21", "Enter image URL:", locator, null);
                Pixwidth_ = new Label("ctl00_phG_tab_t14_edBody_imgprops_pixwidth", "Width", locator, null);
                Pixcaption_ = new Label("ctl00_phG_tab_t14_edBody_imgprops_pixcaption", "Caption", locator, null);
                Ctl34_ = new Label("ctl00_phG_tab_t14_edBody_imgprops_ctl34", "px", locator, null);
                DataMemberName = "ItemSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Unnamed()
            {
                Buttons.Unnamed.Click();
            }
            
            public virtual void Unnamed1()
            {
                Buttons.Unnamed1.Click();
            }
            
            public virtual void ItemClassIDEdit()
            {
                Buttons.ItemClassIDEdit.Click();
            }
            
            public virtual void TaxCategoryIDEdit()
            {
                Buttons.TaxCategoryIDEdit.Click();
            }
            
            public virtual void PostClassIDEdit()
            {
                Buttons.PostClassIDEdit.Click();
            }
            
            public virtual void LotSerClassIDEdit()
            {
                Buttons.LotSerClassIDEdit.Click();
            }
            
            public virtual void BaseUnitEdit()
            {
                Buttons.BaseUnitEdit.Click();
            }
            
            public virtual void SalesUnitEdit()
            {
                Buttons.SalesUnitEdit.Click();
            }
            
            public virtual void PurchaseUnitEdit()
            {
                Buttons.PurchaseUnitEdit.Click();
            }
            
            public virtual void CycleIDEdit()
            {
                Buttons.CycleIDEdit.Click();
            }
            
            public virtual void ABCCodeIDEdit()
            {
                Buttons.ABCCodeIDEdit.Click();
            }
            
            public virtual void MovementClassIDEdit()
            {
                Buttons.MovementClassIDEdit.Click();
            }
            
            public virtual void PriceClassIDEdit()
            {
                Buttons.PriceClassIDEdit.Click();
            }
            
            public virtual void AMConfigurationIDEdit()
            {
                Buttons.AMConfigurationIDEdit.Click();
            }
            
            public virtual void AMScrapSiteIDEdit()
            {
                Buttons.AMScrapSiteIDEdit.Click();
            }
            
            public virtual void AMScrapLocationIDEdit()
            {
                Buttons.AMScrapLocationIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Unnamed { get; }
			public Button Unnamed1 { get; }
			public Button ItemClassIDEdit { get; }
			public Button TaxCategoryIDEdit { get; }
			public Button PostClassIDEdit { get; }
			public Button LotSerClassIDEdit { get; }
			public Button BaseUnitEdit { get; }
			public Button SalesUnitEdit { get; }
			public Button PurchaseUnitEdit { get; }
			public Button CycleIDEdit { get; }
			public Button ABCCodeIDEdit { get; }
			public Button MovementClassIDEdit { get; }
			public Button PriceClassIDEdit { get; }
			public Button AMConfigurationIDEdit { get; }
			public Button AMScrapSiteIDEdit { get; }
			public Button AMScrapLocationIDEdit { get; }
                
                public PxButtonCollection()
                {
                    Unnamed = new Button("ctl00_phG_tab_t3_btnViewBOM", "", "ctl00_phG_tab");
                    Unnamed1 = new Button("ctl00_phG_tab_t3_btnViewPlanningBOM", "", "ctl00_phG_tab");
                    ItemClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edItemClassID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "ItemClassIDEdit", "ctl00_phG_tab");
                    ItemClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edTaxCategoryID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "TaxCategoryIDEdit", "ctl00_phG_tab");
                    TaxCategoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PostClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPostClassID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "PostClassIDEdit", "ctl00_phG_tab");
                    PostClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    LotSerClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edLotSerClassID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "LotSerClassIDEdit", "ctl00_phG_tab");
                    LotSerClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    BaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edBaseUnit\'] div[class=\'editBtnCont\'] > div > div", "BaseUnitEdit", "ctl00_phG_tab");
                    BaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    SalesUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edSalesUnit\'] div[class=\'editBtnCont\'] > div > div", "SalesUnitEdit", "ctl00_phG_tab");
                    SalesUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PurchaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPurchaseUnit\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "PurchaseUnitEdit", "ctl00_phG_tab");
                    PurchaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    CycleIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPICycleID\'] div[class=\'editBtnCont\'] > div > div", "CycleIDEdit", "ctl00_phG_tab");
                    CycleIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ABCCodeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edABCCodeID\'] div[class=\'editBtnCont\'] > div > div", "ABCCodeIDEdit", "ctl00_phG_tab");
                    ABCCodeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    MovementClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edMovementClassID\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "MovementClassIDEdit", "ctl00_phG_tab");
                    MovementClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PriceClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_edPriceClassID\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "PriceClassIDEdit", "ctl00_phG_tab");
                    PriceClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    AMConfigurationIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_edAMConfigurationID\'] div[class=\'editBtnCont\'] > div" +
                            " > div", "AMConfigurationIDEdit", "ctl00_phG_tab");
                    AMConfigurationIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    AMScrapSiteIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_edAMScrapSiteID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "AMScrapSiteIDEdit", "ctl00_phG_tab");
                    AMScrapSiteIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    AMScrapLocationIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_edAMScrapLocationID\'] div[class=\'editBtnCont\'] > div" +
                            " > div", "AMScrapLocationIDEdit", "ctl00_phG_tab");
                    AMScrapLocationIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_itemsettings_formdr : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector DeferredCode { get; }
			public Label DeferredCodeLabel { get; }
			public PXNumberEdit DefaultTerm { get; }
			public Label DefaultTermLabel { get; }
			public DropDown DefaultTermUOM { get; }
			public Label DefaultTermUOMLabel { get; }
			public CheckBox UseParentSubID { get; }
			public Label UseParentSubIDLabel { get; }
			public PXNumberEdit TotalPercentage { get; }
			public Label TotalPercentageLabel { get; }
            
            public c_itemsettings_formdr(string locator, string name) : 
                    base(locator, name)
            {
                DeferredCode = new Selector("ctl00_phG_tab_t11_formDR_edDeferredCode1", "Deferral Code", locator, null);
                DeferredCodeLabel = new Label(DeferredCode);
                DeferredCode.DataField = "DeferredCode";
                DefaultTerm = new PXNumberEdit("ctl00_phG_tab_t11_formDR_edDefaultTerm", "Default Term", locator, null);
                DefaultTermLabel = new Label(DefaultTerm);
                DefaultTerm.DataField = "DefaultTerm";
                DefaultTermUOM = new DropDown("ctl00_phG_tab_t11_formDR_edDefaultTermUOM", "Default Term UOM", locator, null);
                DefaultTermUOMLabel = new Label(DefaultTermUOM);
                DefaultTermUOM.DataField = "DefaultTermUOM";
                DefaultTermUOM.Items.Add("D", "day(s)");
                DefaultTermUOM.Items.Add("W", "week(s)");
                DefaultTermUOM.Items.Add("M", "month(s)");
                DefaultTermUOM.Items.Add("Y", "year(s)");
                UseParentSubID = new CheckBox("ctl00_phG_tab_t11_formDR_chkUseParentSubID", "Use Component Subaccounts", locator, null);
                UseParentSubIDLabel = new Label(UseParentSubID);
                UseParentSubID.DataField = "UseParentSubID";
                TotalPercentage = new PXNumberEdit("ctl00_phG_tab_t11_formDR_edTotalPercentage", "Total Percentage", locator, null);
                TotalPercentageLabel = new Label(TotalPercentage);
                TotalPercentage.DataField = "TotalPercentage";
                DataMemberName = "ItemSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void DeferredCodeEdit()
            {
                Buttons.DeferredCodeEdit.Click();
            }
            
            public virtual void DeferredCodeEdit1()
            {
                Buttons.DeferredCodeEdit1.Click();
            }
            
            public virtual void UOMEdit()
            {
                Buttons.UOMEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DeferredCodeEdit { get; }
			public Button DeferredCodeEdit1 { get; }
			public Button UOMEdit { get; }
                
                public PxButtonCollection()
                {
                    DeferredCodeEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_formDR_edDeferredCode1\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "DeferredCodeEdit", "ctl00_phG_tab_t11_formDR");
                    DeferredCodeEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DeferredCodeEdit1 = new Button("css=div[id=\'ctl00_phG_tab_t11_PXGridComponents_lv0_edDeferredCode\'] div[class=\'ed" +
                            "itBtnCont\'] > div > div", "DeferredCodeEdit", "ctl00_phG_tab_t11_formDR");
                    DeferredCodeEdit1.WaitAction = Wait.WaitForNewWindowToOpen;
                    UOMEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_PXGridComponents_lv0_edUOM\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "UOMEdit", "ctl00_phG_tab_t11_formDR");
                    UOMEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_itemsettings_formsm : Container
        {
            
            public PxButtonCollection Buttons;
            
			public GroupBox EquipmentItemClass { get; }
			public Label EquipmentItemClassLabel { get; }
			public Selector ManufacturerID { get; }
			public Label ManufacturerIDLabel { get; }
			public Selector ManufacturerModelID { get; }
			public Label ManufacturerModelIDLabel { get; }
			public Selector EquipmentTypeID { get; }
			public Label EquipmentTypeIDLabel { get; }
			public CheckBox Mem_ShowComponent { get; }
			public Label Mem_ShowComponentLabel { get; }
			public PXNumberEdit CpnyWarrantyValue { get; }
			public Label CpnyWarrantyValueLabel { get; }
			public DropDown CpnyWarrantyType { get; }
			public Label CpnyWarrantyTypeLabel { get; }
			public PXNumberEdit VendorWarrantyValue { get; }
			public Label VendorWarrantyValueLabel { get; }
			public DropDown VendorWarrantyType { get; }
			public Label VendorWarrantyTypeLabel { get; }
            
            public c_itemsettings_formsm(string locator, string name) : 
                    base(locator, name)
            {
                EquipmentItemClass = new GroupBox("ctl00_phG_tab_t15_formSM_edEquipmentItemClass", "Equipment Item Class", locator, null);
                EquipmentItemClassLabel = new Label(EquipmentItemClass);
                EquipmentItemClass.DataField = "EquipmentItemClass";
                ManufacturerID = new Selector("ctl00_phG_tab_t15_formSM_edManufacturerID", "Manufacturer", locator, null);
                ManufacturerIDLabel = new Label(ManufacturerID);
                ManufacturerID.DataField = "ManufacturerID";
                ManufacturerModelID = new Selector("ctl00_phG_tab_t15_formSM_edManufacturerModelID", "Manufacturer Model", locator, null);
                ManufacturerModelIDLabel = new Label(ManufacturerModelID);
                ManufacturerModelID.DataField = "ManufacturerModelID";
                EquipmentTypeID = new Selector("ctl00_phG_tab_t15_formSM_edEquipmentTypeID", "Equipment Type", locator, null);
                EquipmentTypeIDLabel = new Label(EquipmentTypeID);
                EquipmentTypeID.DataField = "EquipmentTypeID";
                Mem_ShowComponent = new CheckBox("ctl00_phG_tab_t15_formSM_edMem_ShowComponent", "Mem_ShowComponent", locator, null);
                Mem_ShowComponentLabel = new Label(Mem_ShowComponent);
                Mem_ShowComponent.DataField = "Mem_ShowComponent";
                CpnyWarrantyValue = new PXNumberEdit("ctl00_phG_tab_t15_formSM_edCpnyWarrantyValue", "Company Warranty", locator, null);
                CpnyWarrantyValueLabel = new Label(CpnyWarrantyValue);
                CpnyWarrantyValue.DataField = "CpnyWarrantyValue";
                CpnyWarrantyType = new DropDown("ctl00_phG_tab_t15_formSM_edCpnyWarrantyType", "Cpny Warranty Type", locator, null);
                CpnyWarrantyTypeLabel = new Label(CpnyWarrantyType);
                CpnyWarrantyType.DataField = "CpnyWarrantyType";
                VendorWarrantyValue = new PXNumberEdit("ctl00_phG_tab_t15_formSM_edVendorWarrantyValue", "Vendor Warranty", locator, null);
                VendorWarrantyValueLabel = new Label(VendorWarrantyValue);
                VendorWarrantyValue.DataField = "VendorWarrantyValue";
                VendorWarrantyType = new DropDown("ctl00_phG_tab_t15_formSM_edVendorWarrantyType", "Vendor Warranty Type", locator, null);
                VendorWarrantyTypeLabel = new Label(VendorWarrantyType);
                VendorWarrantyType.DataField = "VendorWarrantyType";
                DataMemberName = "ItemSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ManufacturerIDEdit()
            {
                Buttons.ManufacturerIDEdit.Click();
            }
            
            public virtual void ManufacturerModelIDEdit()
            {
                Buttons.ManufacturerModelIDEdit.Click();
            }
            
            public virtual void EquipmentTypeIDEdit()
            {
                Buttons.EquipmentTypeIDEdit.Click();
            }
            
            public virtual void ClassIDEdit()
            {
                Buttons.ClassIDEdit.Click();
            }
            
            public virtual void InventoryIDEdit()
            {
                Buttons.InventoryIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ManufacturerIDEdit { get; }
			public Button ManufacturerModelIDEdit { get; }
			public Button EquipmentTypeIDEdit { get; }
			public Button ClassIDEdit { get; }
			public Button InventoryIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ManufacturerIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t15_formSM_edManufacturerID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "ManufacturerIDEdit", "ctl00_phG_tab_t15_formSM");
                    ManufacturerIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ManufacturerModelIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t15_formSM_edManufacturerModelID\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "ManufacturerModelIDEdit", "ctl00_phG_tab_t15_formSM");
                    ManufacturerModelIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    EquipmentTypeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t15_formSM_edEquipmentTypeID\'] div[class=\'editBtnCont\']" +
                            " > div > div", "EquipmentTypeIDEdit", "ctl00_phG_tab_t15_formSM");
                    EquipmentTypeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t15_gridComponents_lv0_edEQClassID\'] div[class=\'editBtn" +
                            "Cont\'] > div > div", "ClassIDEdit", "ctl00_phG_tab_t15_formSM");
                    ClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    InventoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t15_gridComponents_lv0_edEQInventoryID\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "InventoryIDEdit", "ctl00_phG_tab_t15_formSM");
                    InventoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_curysettings_inventoryitem_curysettingsformdefaultsite : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector DfltSiteID { get; }
			public Label DfltSiteIDLabel { get; }
			public Selector DfltShipLocationID { get; }
			public Label DfltShipLocationIDLabel { get; }
			public Selector DfltReceiptLocationID { get; }
			public Label DfltReceiptLocationIDLabel { get; }
            
            public c_curysettings_inventoryitem_curysettingsformdefaultsite(string locator, string name) : 
                    base(locator, name)
            {
                DfltSiteID = new Selector("ctl00_phG_tab_t0_CurySettingsFormDefaultSite_edDfltSiteID", "Default Warehouse", locator, null);
                DfltSiteIDLabel = new Label(DfltSiteID);
                DfltSiteID.DataField = "DfltSiteID";
                DfltShipLocationID = new Selector("ctl00_phG_tab_t0_CurySettingsFormDefaultSite_edDfltShipLocationID", "Default Issue From", locator, null);
                DfltShipLocationIDLabel = new Label(DfltShipLocationID);
                DfltShipLocationID.DataField = "DfltShipLocationID";
                DfltReceiptLocationID = new Selector("ctl00_phG_tab_t0_CurySettingsFormDefaultSite_edDfltReceiptLocationID", "Default Receipt To", locator, null);
                DfltReceiptLocationIDLabel = new Label(DfltReceiptLocationID);
                DfltReceiptLocationID.DataField = "DfltReceiptLocationID";
                DataMemberName = "CurySettings_InventoryItem";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void DfltSiteIDEdit()
            {
                Buttons.DfltSiteIDEdit.Click();
            }
            
            public virtual void DfltShipLocationIDEdit()
            {
                Buttons.DfltShipLocationIDEdit.Click();
            }
            
            public virtual void DfltReceiptLocationIDEdit()
            {
                Buttons.DfltReceiptLocationIDEdit.Click();
            }
            
            public virtual void TaxCategoryIDEdit()
            {
                Buttons.TaxCategoryIDEdit.Click();
            }
            
            public virtual void PostClassIDEdit()
            {
                Buttons.PostClassIDEdit.Click();
            }
            
            public virtual void LotSerClassIDEdit()
            {
                Buttons.LotSerClassIDEdit.Click();
            }
            
            public virtual void BaseUnitEdit()
            {
                Buttons.BaseUnitEdit.Click();
            }
            
            public virtual void SalesUnitEdit()
            {
                Buttons.SalesUnitEdit.Click();
            }
            
            public virtual void PurchaseUnitEdit()
            {
                Buttons.PurchaseUnitEdit.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void CycleIDEdit()
            {
                Buttons.CycleIDEdit.Click();
            }
            
            public virtual void ABCCodeIDEdit()
            {
                Buttons.ABCCodeIDEdit.Click();
            }
            
            public virtual void MovementClassIDEdit()
            {
                Buttons.MovementClassIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DfltSiteIDEdit { get; }
			public Button DfltShipLocationIDEdit { get; }
			public Button DfltReceiptLocationIDEdit { get; }
			public Button TaxCategoryIDEdit { get; }
			public Button PostClassIDEdit { get; }
			public Button LotSerClassIDEdit { get; }
			public Button BaseUnitEdit { get; }
			public Button SalesUnitEdit { get; }
			public Button PurchaseUnitEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button CycleIDEdit { get; }
			public Button ABCCodeIDEdit { get; }
			public Button MovementClassIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DfltSiteIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_CurySettingsFormDefaultSite_edDfltSiteID\'] div[class" +
                            "=\'editBtnCont\'] > div > div", "DfltSiteIDEdit", "ctl00_phG_tab_t0_CurySettingsFormDefaultSite");
                    DfltSiteIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DfltShipLocationIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_CurySettingsFormDefaultSite_edDfltShipLocationID\'] d" +
                            "iv[class=\'editBtnCont\'] > div > div", "DfltShipLocationIDEdit", "ctl00_phG_tab_t0_CurySettingsFormDefaultSite");
                    DfltShipLocationIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DfltReceiptLocationIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_CurySettingsFormDefaultSite_edDfltReceiptLocationID\'" +
                            "] div[class=\'editBtnCont\'] > div > div", "DfltReceiptLocationIDEdit", "ctl00_phG_tab_t0_CurySettingsFormDefaultSite");
                    DfltReceiptLocationIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edTaxCategoryID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "TaxCategoryIDEdit", "ctl00_phG_tab_t0_CurySettingsFormDefaultSite");
                    TaxCategoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PostClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPostClassID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "PostClassIDEdit", "ctl00_phG_tab_t0_CurySettingsFormDefaultSite");
                    PostClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    LotSerClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edLotSerClassID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "LotSerClassIDEdit", "ctl00_phG_tab_t0_CurySettingsFormDefaultSite");
                    LotSerClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    BaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edBaseUnit\'] div[class=\'editBtnCont\'] > div > div", "BaseUnitEdit", "ctl00_phG_tab_t0_CurySettingsFormDefaultSite");
                    BaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    SalesUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edSalesUnit\'] div[class=\'editBtnCont\'] > div > div", "SalesUnitEdit", "ctl00_phG_tab_t0_CurySettingsFormDefaultSite");
                    SalesUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PurchaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPurchaseUnit\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "PurchaseUnitEdit", "ctl00_phG_tab_t0_CurySettingsFormDefaultSite");
                    PurchaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    First = new Button("ctl00_phG_tab_t0_gridUnits_lfFirst0", "First", "ctl00_phG_tab_t0_CurySettingsFormDefaultSite");
                    Prev = new Button("ctl00_phG_tab_t0_gridUnits_lfPrev0", "Prev", "ctl00_phG_tab_t0_CurySettingsFormDefaultSite");
                    Next = new Button("ctl00_phG_tab_t0_gridUnits_lfNext0", "Next", "ctl00_phG_tab_t0_CurySettingsFormDefaultSite");
                    Last = new Button("ctl00_phG_tab_t0_gridUnits_lfLast0", "Last", "ctl00_phG_tab_t0_CurySettingsFormDefaultSite");
                    CycleIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPICycleID\'] div[class=\'editBtnCont\'] > div > div", "CycleIDEdit", "ctl00_phG_tab_t0_CurySettingsFormDefaultSite");
                    CycleIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ABCCodeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edABCCodeID\'] div[class=\'editBtnCont\'] > div > div", "ABCCodeIDEdit", "ctl00_phG_tab_t0_CurySettingsFormDefaultSite");
                    ABCCodeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    MovementClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edMovementClassID\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "MovementClassIDEdit", "ctl00_phG_tab_t0_CurySettingsFormDefaultSite");
                    MovementClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_curysettings_inventoryitem_curysettingsform : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit RecPrice_Label { get; }
			public Label RecPrice_LabelLabel { get; }
			public PXNumberEdit RecPrice { get; }
			public Label RecPriceLabel { get; }
			public PXTextEdit BasePrice_Label { get; }
			public Label BasePrice_LabelLabel { get; }
			public PXNumberEdit BasePrice { get; }
			public Label BasePriceLabel { get; }
            
            public c_curysettings_inventoryitem_curysettingsform(string locator, string name) : 
                    base(locator, name)
            {
                RecPrice_Label = new PXTextEdit("ctl00_phG_tab_t2_curySettingsForm_edRecPriceLabel", "Rec Price _ Label", locator, null);
                RecPrice_LabelLabel = new Label(RecPrice_Label);
                RecPrice_Label.DataField = "RecPrice_Label";
                RecPrice = new PXNumberEdit("ctl00_phG_tab_t2_curySettingsForm_edRecPrice", "Rec Price", locator, null);
                RecPriceLabel = new Label(RecPrice);
                RecPrice.DataField = "RecPrice";
                BasePrice_Label = new PXTextEdit("ctl00_phG_tab_t2_curySettingsForm_edBasePriceLabel", "Base Price _ Label", locator, null);
                BasePrice_LabelLabel = new Label(BasePrice_Label);
                BasePrice_Label.DataField = "BasePrice_Label";
                BasePrice = new PXNumberEdit("ctl00_phG_tab_t2_curySettingsForm_edBasePrice", "Base Price", locator, null);
                BasePriceLabel = new Label(BasePrice);
                BasePrice.DataField = "BasePrice";
                DataMemberName = "CurySettings_InventoryItem";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void PriceClassIDEdit()
            {
                Buttons.PriceClassIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button PriceClassIDEdit { get; }
                
                public PxButtonCollection()
                {
                    PriceClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_edPriceClassID\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "PriceClassIDEdit", "ctl00_phG_tab_t2_curySettingsForm");
                    PriceClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_curysettings_inventoryitem_curysettingsform2 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit PendingStdCost_Label { get; }
			public Label PendingStdCost_LabelLabel { get; }
			public PXNumberEdit PendingStdCost { get; }
			public Label PendingStdCostLabel { get; }
			public DateSelector PendingStdCostDate { get; }
			public Label PendingStdCostDateLabel { get; }
			public PXTextEdit StdCost_Label { get; }
			public Label StdCost_LabelLabel { get; }
			public PXNumberEdit StdCost { get; }
			public Label StdCostLabel { get; }
			public DateSelector StdCostDate { get; }
			public Label StdCostDateLabel { get; }
			public PXTextEdit LastStdCost_Label { get; }
			public Label LastStdCost_LabelLabel { get; }
			public PXNumberEdit LastStdCost { get; }
			public Label LastStdCostLabel { get; }
            
            public c_curysettings_inventoryitem_curysettingsform2(string locator, string name) : 
                    base(locator, name)
            {
                PendingStdCost_Label = new PXTextEdit("ctl00_phG_tab_t2_curySettingsForm2_edPendingStdCostLabel", "Pending Std Cost _ Label", locator, null);
                PendingStdCost_LabelLabel = new Label(PendingStdCost_Label);
                PendingStdCost_Label.DataField = "PendingStdCost_Label";
                PendingStdCost = new PXNumberEdit("ctl00_phG_tab_t2_curySettingsForm2_edPendingStdCost", "Pending Std Cost", locator, null);
                PendingStdCostLabel = new Label(PendingStdCost);
                PendingStdCost.DataField = "PendingStdCost";
                PendingStdCostDate = new DateSelector("ctl00_phG_tab_t2_curySettingsForm2_edPendingStdCostDate", "Pending Cost Date", locator, null);
                PendingStdCostDateLabel = new Label(PendingStdCostDate);
                PendingStdCostDate.DataField = "PendingStdCostDate";
                StdCost_Label = new PXTextEdit("ctl00_phG_tab_t2_curySettingsForm2_edStdCostLabel", "Std Cost _ Label", locator, null);
                StdCost_LabelLabel = new Label(StdCost_Label);
                StdCost_Label.DataField = "StdCost_Label";
                StdCost = new PXNumberEdit("ctl00_phG_tab_t2_curySettingsForm2_edStdCost", "Std Cost", locator, null);
                StdCostLabel = new Label(StdCost);
                StdCost.DataField = "StdCost";
                StdCostDate = new DateSelector("ctl00_phG_tab_t2_curySettingsForm2_edStdCostDate", "Effective Date", locator, null);
                StdCostDateLabel = new Label(StdCostDate);
                StdCostDate.DataField = "StdCostDate";
                LastStdCost_Label = new PXTextEdit("ctl00_phG_tab_t2_curySettingsForm2_edLastStdCostLabel", "Last Std Cost _ Label", locator, null);
                LastStdCost_LabelLabel = new Label(LastStdCost_Label);
                LastStdCost_Label.DataField = "LastStdCost_Label";
                LastStdCost = new PXNumberEdit("ctl00_phG_tab_t2_curySettingsForm2_edLastStdCost", "Last Std Cost", locator, null);
                LastStdCostLabel = new Label(LastStdCost);
                LastStdCost.DataField = "LastStdCost";
                DataMemberName = "CurySettings_InventoryItem";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void PriceClassIDEdit()
            {
                Buttons.PriceClassIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button PriceClassIDEdit { get; }
                
                public PxButtonCollection()
                {
                    PriceClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_edPriceClassID\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "PriceClassIDEdit", "ctl00_phG_tab_t2_curySettingsForm2");
                    PriceClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_segmentvalues_gridsegmentvalues : Grid<c_segmentvalues_gridsegmentvalues.c_grid_row, c_segmentvalues_gridsegmentvalues.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_segmentvalues_gridsegmentvalues(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t1_gridSegmentValues");
                DataMemberName = "SegmentValues";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t1_gridSegmentValues_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridSegmentValues_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridSegmentValues_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridSegmentValues_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridSegmentValues_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridSegmentValues_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridSegmentValues_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridSegmentValues_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridSegmentValues_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridSegmentValues_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridSegmentValues_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridSegmentValues_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXNumberEdit SegmentID { get; }
			public PXTextEdit Value { get; }
			public Selector InventoryID { get; }
                
                public c_grid_row(c_segmentvalues_gridsegmentvalues grid) : 
                        base(grid)
                {
                    SegmentID = new PXNumberEdit("ctl00_phG_tab_t1_gridSegmentValues_en", "Segment ID", grid.Locator, "SegmentID");
                    SegmentID.DataField = "SegmentID";
                    Value = new PXTextEdit("ctl00_phG_tab_t1_gridSegmentValues_em", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                    InventoryID = new Selector("_ctl00_phG_tab_t1_gridSegmentValues_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXNumberEditColumnFilter SegmentID { get; }
				public PXTextEditColumnFilter Value { get; }
				public SelectorColumnFilter InventoryID { get; }
                
                public c_grid_header(c_segmentvalues_gridsegmentvalues grid) : 
                        base(grid)
                {
                    SegmentID = new PXNumberEditColumnFilter(grid.Row.SegmentID);
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                }
            }
        }
        
        public class c_segmentvalues_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_segmentvalues_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t1_gridSegmentValues_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "SegmentValues";
            }
        }
        
        public class c_itemunits_gridunits : Grid<c_itemunits_gridunits.c_grid_row, c_itemunits_gridunits.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_itemunits_gridunits(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t0_gridUnits");
                DataMemberName = "itemunits";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void TaxCategoryIDEdit()
            {
                Buttons.TaxCategoryIDEdit.Click();
            }
            
            public virtual void PostClassIDEdit()
            {
                Buttons.PostClassIDEdit.Click();
            }
            
            public virtual void LotSerClassIDEdit()
            {
                Buttons.LotSerClassIDEdit.Click();
            }
            
            public virtual void BaseUnitEdit()
            {
                Buttons.BaseUnitEdit.Click();
            }
            
            public virtual void SalesUnitEdit()
            {
                Buttons.SalesUnitEdit.Click();
            }
            
            public virtual void PurchaseUnitEdit()
            {
                Buttons.PurchaseUnitEdit.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void CycleIDEdit()
            {
                Buttons.CycleIDEdit.Click();
            }
            
            public virtual void ABCCodeIDEdit()
            {
                Buttons.ABCCodeIDEdit.Click();
            }
            
            public virtual void MovementClassIDEdit()
            {
                Buttons.MovementClassIDEdit.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridUnits_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridUnits_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridUnits_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridUnits_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button TaxCategoryIDEdit { get; }
			public Button PostClassIDEdit { get; }
			public Button LotSerClassIDEdit { get; }
			public Button BaseUnitEdit { get; }
			public Button SalesUnitEdit { get; }
			public Button PurchaseUnitEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button CycleIDEdit { get; }
			public Button ABCCodeIDEdit { get; }
			public Button MovementClassIDEdit { get; }
                
                public PxButtonCollection()
                {
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edTaxCategoryID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "TaxCategoryIDEdit", "ctl00_phG_tab_t0_gridUnits");
                    TaxCategoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PostClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPostClassID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "PostClassIDEdit", "ctl00_phG_tab_t0_gridUnits");
                    PostClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    LotSerClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edLotSerClassID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "LotSerClassIDEdit", "ctl00_phG_tab_t0_gridUnits");
                    LotSerClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    BaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edBaseUnit\'] div[class=\'editBtnCont\'] > div > div", "BaseUnitEdit", "ctl00_phG_tab_t0_gridUnits");
                    BaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    SalesUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edSalesUnit\'] div[class=\'editBtnCont\'] > div > div", "SalesUnitEdit", "ctl00_phG_tab_t0_gridUnits");
                    SalesUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PurchaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPurchaseUnit\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "PurchaseUnitEdit", "ctl00_phG_tab_t0_gridUnits");
                    PurchaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    First = new Button("ctl00_phG_tab_t0_gridUnits_lfFirst0", "First", "ctl00_phG_tab_t0_gridUnits");
                    Prev = new Button("ctl00_phG_tab_t0_gridUnits_lfPrev0", "Prev", "ctl00_phG_tab_t0_gridUnits");
                    Next = new Button("ctl00_phG_tab_t0_gridUnits_lfNext0", "Next", "ctl00_phG_tab_t0_gridUnits");
                    Last = new Button("ctl00_phG_tab_t0_gridUnits_lfLast0", "Last", "ctl00_phG_tab_t0_gridUnits");
                    CycleIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPICycleID\'] div[class=\'editBtnCont\'] > div > div", "CycleIDEdit", "ctl00_phG_tab_t0_gridUnits");
                    CycleIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ABCCodeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edABCCodeID\'] div[class=\'editBtnCont\'] > div > div", "ABCCodeIDEdit", "ctl00_phG_tab_t0_gridUnits");
                    ABCCodeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    MovementClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edMovementClassID\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "MovementClassIDEdit", "ctl00_phG_tab_t0_gridUnits");
                    MovementClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public DropDown UnitType { get; }
			public PXNumberEdit ItemClassID { get; }
			public PXNumberEdit InventoryID { get; }
			public PXTextEdit FromUnit { get; }
			public DropDown UnitMultDiv { get; }
			public PXNumberEdit UnitRate { get; }
			public PXTextEdit SampleToUnit { get; }
			public PXNumberEdit PriceAdjustmentMultiplier { get; }
			public Selector ToUnit { get; }
                
                public c_grid_row(c_itemunits_gridunits grid) : 
                        base(grid)
                {
                    UnitType = new DropDown("_ctl00_phG_tab_t0_gridUnits_lv0_ec", "Unit Type", grid.Locator, "UnitType");
                    UnitType.DataField = "UnitType";
                    UnitType.Items.Add("1", "Inventory Item");
                    UnitType.Items.Add("2", "Item Class");
                    UnitType.Items.Add("3", "Global");
                    ItemClassID = new PXNumberEdit("_ctl00_phG_tab_t0_gridUnits_lv0_edItemClassID2", "Item Class ID", grid.Locator, "ItemClassID");
                    ItemClassID.DataField = "ItemClassID";
                    InventoryID = new PXNumberEdit("_ctl00_phG_tab_t0_gridUnits_lv0_edInventoryID", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    FromUnit = new PXTextEdit("_ctl00_phG_tab_t0_gridUnits_lv0_edFromUnit", "From Unit", grid.Locator, "FromUnit");
                    FromUnit.DataField = "FromUnit";
                    UnitMultDiv = new DropDown("_ctl00_phG_tab_t0_gridUnits_lv0_ec", "Multiply/Divide", grid.Locator, "UnitMultDiv");
                    UnitMultDiv.DataField = "UnitMultDiv";
                    UnitMultDiv.Items.Add("M", "Multiply");
                    UnitMultDiv.Items.Add("D", "Divide");
                    UnitRate = new PXNumberEdit("_ctl00_phG_tab_t0_gridUnits_lv0_edUnitRate", "Conversion Factor", grid.Locator, "UnitRate");
                    UnitRate.DataField = "UnitRate";
                    SampleToUnit = new PXTextEdit("_ctl00_phG_tab_t0_gridUnits_lv0_edSampleToUnit", "To Unit", grid.Locator, "SampleToUnit");
                    SampleToUnit.DataField = "SampleToUnit";
                    PriceAdjustmentMultiplier = new PXNumberEdit("ctl00_phG_tab_t0_gridUnits_en", "Price Adjustment Multiplier", grid.Locator, "PriceAdjustmentMultiplier");
                    PriceAdjustmentMultiplier.DataField = "PriceAdjustmentMultiplier";
                    ToUnit = new Selector("_ctl00_phG_tab_t0_gridUnits_lv0_es", "To Unit", grid.Locator, "ToUnit");
                    ToUnit.DataField = "ToUnit";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public DropDownColumnFilter UnitType { get; }
				public PXNumberEditColumnFilter ItemClassID { get; }
				public PXNumberEditColumnFilter InventoryID { get; }
				public PXTextEditColumnFilter FromUnit { get; }
				public DropDownColumnFilter UnitMultDiv { get; }
				public PXNumberEditColumnFilter UnitRate { get; }
				public PXTextEditColumnFilter SampleToUnit { get; }
				public PXNumberEditColumnFilter PriceAdjustmentMultiplier { get; }
				public SelectorColumnFilter ToUnit { get; }
                
                public c_grid_header(c_itemunits_gridunits grid) : 
                        base(grid)
                {
                    UnitType = new DropDownColumnFilter(grid.Row.UnitType);
                    ItemClassID = new PXNumberEditColumnFilter(grid.Row.ItemClassID);
                    InventoryID = new PXNumberEditColumnFilter(grid.Row.InventoryID);
                    FromUnit = new PXTextEditColumnFilter(grid.Row.FromUnit);
                    UnitMultDiv = new DropDownColumnFilter(grid.Row.UnitMultDiv);
                    UnitRate = new PXNumberEditColumnFilter(grid.Row.UnitRate);
                    SampleToUnit = new PXTextEditColumnFilter(grid.Row.SampleToUnit);
                    PriceAdjustmentMultiplier = new PXNumberEditColumnFilter(grid.Row.PriceAdjustmentMultiplier);
                    ToUnit = new SelectorColumnFilter(grid.Row.ToUnit);
                }
            }
        }
        
        public class c_itemunits_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit ItemClassID { get; }
			public Label ItemClassIDLabel { get; }
			public PXNumberEdit InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public PXTextEdit FromUnit { get; }
			public Label FromUnitLabel { get; }
			public PXTextEdit SampleToUnit { get; }
			public Label SampleToUnitLabel { get; }
			public PXNumberEdit UnitRate { get; }
			public Label UnitRateLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_itemunits_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ItemClassID = new PXNumberEdit("ctl00_phG_tab_t0_gridUnits_lv0_edItemClassID2", "Item Class ID", locator, null);
                ItemClassIDLabel = new Label(ItemClassID);
                ItemClassID.DataField = "ItemClassID";
                InventoryID = new PXNumberEdit("ctl00_phG_tab_t0_gridUnits_lv0_edInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                FromUnit = new PXTextEdit("ctl00_phG_tab_t0_gridUnits_lv0_edFromUnit", "From Unit", locator, null);
                FromUnitLabel = new Label(FromUnit);
                FromUnit.DataField = "FromUnit";
                SampleToUnit = new PXTextEdit("ctl00_phG_tab_t0_gridUnits_lv0_edSampleToUnit", "To Unit", locator, null);
                SampleToUnitLabel = new Label(SampleToUnit);
                SampleToUnit.DataField = "SampleToUnit";
                UnitRate = new PXNumberEdit("ctl00_phG_tab_t0_gridUnits_lv0_edUnitRate", "Conversion Factor", locator, null);
                UnitRateLabel = new Label(UnitRate);
                UnitRate.DataField = "UnitRate";
                Es = new Selector("ctl00_phG_tab_t0_gridUnits_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t0_gridUnits_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t0_gridUnits_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t0_gridUnits_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "itemunits";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void TaxCategoryIDEdit()
            {
                Buttons.TaxCategoryIDEdit.Click();
            }
            
            public virtual void PostClassIDEdit()
            {
                Buttons.PostClassIDEdit.Click();
            }
            
            public virtual void LotSerClassIDEdit()
            {
                Buttons.LotSerClassIDEdit.Click();
            }
            
            public virtual void BaseUnitEdit()
            {
                Buttons.BaseUnitEdit.Click();
            }
            
            public virtual void SalesUnitEdit()
            {
                Buttons.SalesUnitEdit.Click();
            }
            
            public virtual void PurchaseUnitEdit()
            {
                Buttons.PurchaseUnitEdit.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void CycleIDEdit()
            {
                Buttons.CycleIDEdit.Click();
            }
            
            public virtual void ABCCodeIDEdit()
            {
                Buttons.ABCCodeIDEdit.Click();
            }
            
            public virtual void MovementClassIDEdit()
            {
                Buttons.MovementClassIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button TaxCategoryIDEdit { get; }
			public Button PostClassIDEdit { get; }
			public Button LotSerClassIDEdit { get; }
			public Button BaseUnitEdit { get; }
			public Button SalesUnitEdit { get; }
			public Button PurchaseUnitEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button CycleIDEdit { get; }
			public Button ABCCodeIDEdit { get; }
			public Button MovementClassIDEdit { get; }
                
                public PxButtonCollection()
                {
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edTaxCategoryID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "TaxCategoryIDEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    TaxCategoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PostClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPostClassID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "PostClassIDEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    PostClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    LotSerClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edLotSerClassID\'] div[class=\'editBtnCont\'] > div > d" +
                            "iv", "LotSerClassIDEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    LotSerClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    BaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edBaseUnit\'] div[class=\'editBtnCont\'] > div > div", "BaseUnitEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    BaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    SalesUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edSalesUnit\'] div[class=\'editBtnCont\'] > div > div", "SalesUnitEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    SalesUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PurchaseUnitEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPurchaseUnit\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "PurchaseUnitEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    PurchaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    First = new Button("ctl00_phG_tab_t0_gridUnits_lfFirst0", "First", "ctl00_phG_tab_t0_gridUnits_lv0");
                    Prev = new Button("ctl00_phG_tab_t0_gridUnits_lfPrev0", "Prev", "ctl00_phG_tab_t0_gridUnits_lv0");
                    Next = new Button("ctl00_phG_tab_t0_gridUnits_lfNext0", "Next", "ctl00_phG_tab_t0_gridUnits_lv0");
                    Last = new Button("ctl00_phG_tab_t0_gridUnits_lfLast0", "Last", "ctl00_phG_tab_t0_gridUnits_lv0");
                    CycleIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPICycleID\'] div[class=\'editBtnCont\'] > div > div", "CycleIDEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    CycleIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ABCCodeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edABCCodeID\'] div[class=\'editBtnCont\'] > div > div", "ABCCodeIDEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    ABCCodeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    MovementClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edMovementClassID\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "MovementClassIDEdit", "ctl00_phG_tab_t0_gridUnits_lv0");
                    MovementClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_components_pxgridcomponents : Grid<c_components_pxgridcomponents.c_grid_row, c_components_pxgridcomponents.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_components_pxgridcomponents(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t11_PXGridComponents");
                DataMemberName = "Components";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public virtual void DeferredCodeEdit()
            {
                Buttons.DeferredCodeEdit.Click();
            }
            
            public virtual void DeferredCodeEdit1()
            {
                Buttons.DeferredCodeEdit1.Click();
            }
            
            public virtual void UOMEdit()
            {
                Buttons.UOMEdit.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_PXGridComponents_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_PXGridComponents_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_PXGridComponents_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_PXGridComponents_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_PXGridComponents_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_PXGridComponents_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_PXGridComponents_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_PXGridComponents_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_PXGridComponents_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_PXGridComponents_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_PXGridComponents_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DeferredCodeEdit { get; }
			public Button DeferredCodeEdit1 { get; }
			public Button UOMEdit { get; }
                
                public PxButtonCollection()
                {
                    DeferredCodeEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_formDR_edDeferredCode1\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "DeferredCodeEdit", "ctl00_phG_tab_t11_PXGridComponents");
                    DeferredCodeEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DeferredCodeEdit1 = new Button("css=div[id=\'ctl00_phG_tab_t11_PXGridComponents_lv0_edDeferredCode\'] div[class=\'ed" +
                            "itBtnCont\'] > div > div", "DeferredCodeEdit", "ctl00_phG_tab_t11_PXGridComponents");
                    DeferredCodeEdit1.WaitAction = Wait.WaitForNewWindowToOpen;
                    UOMEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_PXGridComponents_lv0_edUOM\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "UOMEdit", "ctl00_phG_tab_t11_PXGridComponents");
                    UOMEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector ComponentID { get; }
			public Selector SalesAcctID { get; }
			public Selector SalesSubID { get; }
			public Selector UOM { get; }
			public PXNumberEdit Qty { get; }
			public Selector DeferredCode { get; }
			public PXNumberEdit DefaultTerm { get; }
			public DropDown DefaultTermUOM { get; }
			public DropDown AmtOption { get; }
			public PXNumberEdit FixedAmt { get; }
			public PXNumberEdit Percentage { get; }
			public PXNumberEdit InventoryID { get; }
                
                public c_grid_row(c_components_pxgridcomponents grid) : 
                        base(grid)
                {
                    ComponentID = new Selector("_ctl00_phG_tab_t11_PXGridComponents_lv0_edComponentID", "Inventory ID", grid.Locator, "ComponentID");
                    ComponentID.DataField = "ComponentID";
                    SalesAcctID = new Selector("_ctl00_phG_tab_t11_PXGridComponents_lv0_edSalesAcctID", "Sales Account", grid.Locator, "SalesAcctID");
                    SalesAcctID.DataField = "SalesAcctID";
                    SalesSubID = new Selector("_ctl00_phG_tab_t11_PXGridComponents_lv0_edSalesSubID", "Sales Sub.", grid.Locator, "SalesSubID");
                    SalesSubID.DataField = "SalesSubID";
                    UOM = new Selector("_ctl00_phG_tab_t11_PXGridComponents_lv0_edUOM", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    Qty = new PXNumberEdit("_ctl00_phG_tab_t11_PXGridComponents_lv0_edQty", "Quantity", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    DeferredCode = new Selector("_ctl00_phG_tab_t11_PXGridComponents_lv0_edDeferredCode", "Deferral Code", grid.Locator, "DeferredCode");
                    DeferredCode.DataField = "DeferredCode";
                    DefaultTerm = new PXNumberEdit("_ctl00_phG_tab_t11_PXGridComponents_lv0_edDefaultTerm", "Default Term", grid.Locator, "DefaultTerm");
                    DefaultTerm.DataField = "DefaultTerm";
                    DefaultTermUOM = new DropDown("_ctl00_phG_tab_t11_PXGridComponents_lv0_ec", "Default Term UOM", grid.Locator, "DefaultTermUOM");
                    DefaultTermUOM.DataField = "DefaultTermUOM";
                    DefaultTermUOM.Items.Add("D", "day(s)");
                    DefaultTermUOM.Items.Add("W", "week(s)");
                    DefaultTermUOM.Items.Add("M", "month(s)");
                    DefaultTermUOM.Items.Add("Y", "year(s)");
                    AmtOption = new DropDown("_ctl00_phG_tab_t11_PXGridComponents_lv0_edPriceOption", "Allocation Method", grid.Locator, "AmtOption");
                    AmtOption.DataField = "AmtOption";
                    AmtOption.Items.Add("P", "Percentage");
                    AmtOption.Items.Add("F", "Fixed Amount");
                    AmtOption.Items.Add("R", "Residual");
                    FixedAmt = new PXNumberEdit("_ctl00_phG_tab_t11_PXGridComponents_lv0_edFixedAmt", "Fixed Amount", grid.Locator, "FixedAmt");
                    FixedAmt.DataField = "FixedAmt";
                    Percentage = new PXNumberEdit("_ctl00_phG_tab_t11_PXGridComponents_lv0_edPercentage", "Percentage", grid.Locator, "Percentage");
                    Percentage.DataField = "Percentage";
                    InventoryID = new PXNumberEdit("ctl00_phG_tab_t11_PXGridComponents_en", "InventoryID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter ComponentID { get; }
				public SelectorColumnFilter SalesAcctID { get; }
				public SelectorColumnFilter SalesSubID { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public SelectorColumnFilter DeferredCode { get; }
				public PXNumberEditColumnFilter DefaultTerm { get; }
				public DropDownColumnFilter DefaultTermUOM { get; }
				public DropDownColumnFilter AmtOption { get; }
				public PXNumberEditColumnFilter FixedAmt { get; }
				public PXNumberEditColumnFilter Percentage { get; }
				public PXNumberEditColumnFilter InventoryID { get; }
                
                public c_grid_header(c_components_pxgridcomponents grid) : 
                        base(grid)
                {
                    ComponentID = new SelectorColumnFilter(grid.Row.ComponentID);
                    SalesAcctID = new SelectorColumnFilter(grid.Row.SalesAcctID);
                    SalesSubID = new SelectorColumnFilter(grid.Row.SalesSubID);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    DeferredCode = new SelectorColumnFilter(grid.Row.DeferredCode);
                    DefaultTerm = new PXNumberEditColumnFilter(grid.Row.DefaultTerm);
                    DefaultTermUOM = new DropDownColumnFilter(grid.Row.DefaultTermUOM);
                    AmtOption = new DropDownColumnFilter(grid.Row.AmtOption);
                    FixedAmt = new PXNumberEditColumnFilter(grid.Row.FixedAmt);
                    Percentage = new PXNumberEditColumnFilter(grid.Row.Percentage);
                    InventoryID = new PXNumberEditColumnFilter(grid.Row.InventoryID);
                }
            }
        }
        
        public class c_components_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown AmtOption { get; }
			public Label AmtOptionLabel { get; }
			public Selector ComponentID { get; }
			public Label ComponentIDLabel { get; }
			public PXNumberEdit FixedAmt { get; }
			public Label FixedAmtLabel { get; }
			public Selector DeferredCode { get; }
			public Label DeferredCodeLabel { get; }
			public PXNumberEdit DefaultTerm { get; }
			public Label DefaultTermLabel { get; }
			public PXNumberEdit Percentage { get; }
			public Label PercentageLabel { get; }
			public Selector SalesAcctID { get; }
			public Label SalesAcctIDLabel { get; }
			public Selector SalesSubID { get; }
			public Label SalesSubIDLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public PXNumberEdit Qty { get; }
			public Label QtyLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_components_lv0(string locator, string name) : 
                    base(locator, name)
            {
                AmtOption = new DropDown("ctl00_phG_tab_t11_PXGridComponents_lv0_edPriceOption", "Allocation Method", locator, null);
                AmtOptionLabel = new Label(AmtOption);
                AmtOption.DataField = "AmtOption";
                AmtOption.Items.Add("P", "Percentage");
                AmtOption.Items.Add("F", "Fixed Amount");
                AmtOption.Items.Add("R", "Residual");
                ComponentID = new Selector("ctl00_phG_tab_t11_PXGridComponents_lv0_edComponentID", "Inventory ID", locator, null);
                ComponentIDLabel = new Label(ComponentID);
                ComponentID.DataField = "ComponentID";
                FixedAmt = new PXNumberEdit("ctl00_phG_tab_t11_PXGridComponents_lv0_edFixedAmt", "Fixed Amount", locator, null);
                FixedAmtLabel = new Label(FixedAmt);
                FixedAmt.DataField = "FixedAmt";
                DeferredCode = new Selector("ctl00_phG_tab_t11_PXGridComponents_lv0_edDeferredCode", "Deferral Code", locator, null);
                DeferredCodeLabel = new Label(DeferredCode);
                DeferredCode.DataField = "DeferredCode";
                DefaultTerm = new PXNumberEdit("ctl00_phG_tab_t11_PXGridComponents_lv0_edDefaultTerm", "Default Term", locator, null);
                DefaultTermLabel = new Label(DefaultTerm);
                DefaultTerm.DataField = "DefaultTerm";
                Percentage = new PXNumberEdit("ctl00_phG_tab_t11_PXGridComponents_lv0_edPercentage", "Percentage", locator, null);
                PercentageLabel = new Label(Percentage);
                Percentage.DataField = "Percentage";
                SalesAcctID = new Selector("ctl00_phG_tab_t11_PXGridComponents_lv0_edSalesAcctID", "Sales Account", locator, null);
                SalesAcctIDLabel = new Label(SalesAcctID);
                SalesAcctID.DataField = "SalesAcctID";
                SalesSubID = new Selector("ctl00_phG_tab_t11_PXGridComponents_lv0_edSalesSubID", "Sales Sub.", locator, null);
                SalesSubIDLabel = new Label(SalesSubID);
                SalesSubID.DataField = "SalesSubID";
                UOM = new Selector("ctl00_phG_tab_t11_PXGridComponents_lv0_edUOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                Qty = new PXNumberEdit("ctl00_phG_tab_t11_PXGridComponents_lv0_edQty", "Quantity", locator, null);
                QtyLabel = new Label(Qty);
                Qty.DataField = "Qty";
                Es = new Selector("ctl00_phG_tab_t11_PXGridComponents_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t11_PXGridComponents_lv0_ec", "Ec", locator, null);
                DataMemberName = "Components";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ComponentIDEdit()
            {
                Buttons.ComponentIDEdit.Click();
            }
            
            public virtual void DeferredCodeEdit()
            {
                Buttons.DeferredCodeEdit.Click();
            }
            
            public virtual void SalesAcctIDEdit()
            {
                Buttons.SalesAcctIDEdit.Click();
            }
            
            public virtual void UOMEdit()
            {
                Buttons.UOMEdit.Click();
            }
            
            public virtual void DeferredCodeEdit1()
            {
                Buttons.DeferredCodeEdit1.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ComponentIDEdit { get; }
			public Button DeferredCodeEdit { get; }
			public Button SalesAcctIDEdit { get; }
			public Button UOMEdit { get; }
			public Button DeferredCodeEdit1 { get; }
                
                public PxButtonCollection()
                {
                    ComponentIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_PXGridComponents_lv0_edComponentID\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "ComponentIDEdit", "ctl00_phG_tab_t11_PXGridComponents_lv0");
                    ComponentIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DeferredCodeEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_PXGridComponents_lv0_edDeferredCode\'] div[class=\'ed" +
                            "itBtnCont\'] > div > div", "DeferredCodeEdit", "ctl00_phG_tab_t11_PXGridComponents_lv0");
                    DeferredCodeEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    SalesAcctIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_PXGridComponents_lv0_edSalesAcctID\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "SalesAcctIDEdit", "ctl00_phG_tab_t11_PXGridComponents_lv0");
                    SalesAcctIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    UOMEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_PXGridComponents_lv0_edUOM\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "UOMEdit", "ctl00_phG_tab_t11_PXGridComponents_lv0");
                    UOMEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DeferredCodeEdit1 = new Button("css=div[id=\'ctl00_phG_tab_t11_formDR_edDeferredCode1\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "DeferredCodeEdit", "ctl00_phG_tab_t11_PXGridComponents_lv0");
                    DeferredCodeEdit1.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_itemxrefrecords_crossgrid : Grid<c_itemxrefrecords_crossgrid.c_grid_row, c_itemxrefrecords_crossgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_itemxrefrecords_crossgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t8_crossgrid");
                DataMemberName = "itemxrefrecords";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t8_crossgrid_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public virtual void UOMEdit()
            {
                Buttons.UOMEdit.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_crossgrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_crossgrid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_crossgrid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_crossgrid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_crossgrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_crossgrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_crossgrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_crossgrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_crossgrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_crossgrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_crossgrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button UOMEdit { get; }
                
                public PxButtonCollection()
                {
                    UOMEdit = new Button("css=div[id=\'ctl00_phG_tab_t8_crossgrid_lv0_edxUOM\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "UOMEdit", "ctl00_phG_tab_t8_crossgrid");
                    UOMEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector SubItemID { get; }
			public DropDown AlternateType { get; }
			public Selector BAccountID { get; }
			public PXTextEdit AlternateID { get; }
			public Selector UOM { get; }
			public PXTextEdit Descr { get; }
			public Selector InventoryID { get; }
                
                public c_grid_row(c_itemxrefrecords_crossgrid grid) : 
                        base(grid)
                {
                    SubItemID = new Selector("_ctl00_phG_tab_t8_crossgrid_lv0_edSubItemID", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    AlternateType = new DropDown("_ctl00_phG_tab_t8_crossgrid_lv0_ec", "Alternate Type", grid.Locator, "AlternateType");
                    AlternateType.DataField = "AlternateType";
                    AlternateType.Items.Add("0CPN", "Customer Part Number");
                    AlternateType.Items.Add("0VPN", "Vendor Part Number");
                    AlternateType.Items.Add("GLBL", "Global");
                    AlternateType.Items.Add("BAR", "Barcode");
                    BAccountID = new Selector("_ctl00_phG_tab_t8_crossgrid_lv0_edBAccountID", "Vendor/Customer", grid.Locator, "BAccountID");
                    BAccountID.DataField = "BAccountID";
                    AlternateID = new PXTextEdit("_ctl00_phG_tab_t8_crossgrid_lv0_edAlternateID", "Alternate ID", grid.Locator, "AlternateID");
                    AlternateID.DataField = "AlternateID";
                    UOM = new Selector("_ctl00_phG_tab_t8_crossgrid_lv0_edxUOM", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    Descr = new PXTextEdit("_ctl00_phG_tab_t8_crossgrid_lv0_edDescr", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    InventoryID = new Selector("_ctl00_phG_tab_t8_crossgrid_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter SubItemID { get; }
				public DropDownColumnFilter AlternateType { get; }
				public SelectorColumnFilter BAccountID { get; }
				public PXTextEditColumnFilter AlternateID { get; }
				public SelectorColumnFilter UOM { get; }
				public PXTextEditColumnFilter Descr { get; }
				public SelectorColumnFilter InventoryID { get; }
                
                public c_grid_header(c_itemxrefrecords_crossgrid grid) : 
                        base(grid)
                {
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    AlternateType = new DropDownColumnFilter(grid.Row.AlternateType);
                    BAccountID = new SelectorColumnFilter(grid.Row.BAccountID);
                    AlternateID = new PXTextEditColumnFilter(grid.Row.AlternateID);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                }
            }
        }
        
        public class c_itemxrefrecords_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector BAccountID { get; }
			public Label BAccountIDLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public PXTextEdit AlternateID { get; }
			public Label AlternateIDLabel { get; }
			public PXTextEdit Descr { get; }
			public Label DescrLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_itemxrefrecords_lv0(string locator, string name) : 
                    base(locator, name)
            {
                BAccountID = new Selector("ctl00_phG_tab_t8_crossgrid_lv0_edBAccountID", "Vendor/Customer", locator, null);
                BAccountIDLabel = new Label(BAccountID);
                BAccountID.DataField = "BAccountID";
                UOM = new Selector("ctl00_phG_tab_t8_crossgrid_lv0_edxUOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                SubItemID = new Selector("ctl00_phG_tab_t8_crossgrid_lv0_edSubItemID", "Sub Item ID", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                AlternateID = new PXTextEdit("ctl00_phG_tab_t8_crossgrid_lv0_edAlternateID", "Alternate ID", locator, null);
                AlternateIDLabel = new Label(AlternateID);
                AlternateID.DataField = "AlternateID";
                Descr = new PXTextEdit("ctl00_phG_tab_t8_crossgrid_lv0_edDescr", "Description", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                Es = new Selector("ctl00_phG_tab_t8_crossgrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t8_crossgrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "itemxrefrecords";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void BAccountIDEdit()
            {
                Buttons.BAccountIDEdit.Click();
            }
            
            public virtual void UOMEdit()
            {
                Buttons.UOMEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button BAccountIDEdit { get; }
			public Button UOMEdit { get; }
                
                public PxButtonCollection()
                {
                    BAccountIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t8_crossgrid_lv0_edBAccountID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "BAccountIDEdit", "ctl00_phG_tab_t8_crossgrid_lv0");
                    BAccountIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    UOMEdit = new Button("css=div[id=\'ctl00_phG_tab_t8_crossgrid_lv0_edxUOM\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "UOMEdit", "ctl00_phG_tab_t8_crossgrid_lv0");
                    UOMEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_vendoritems_pxgridvendoritems : Grid<c_vendoritems_pxgridvendoritems.c_grid_row, c_vendoritems_pxgridvendoritems.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_vendoritems_pxgridvendoritems(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t5_PXGridVendorItems");
                DataMemberName = "VendorItems";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t5_PXGridVendorItems_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridVendorItems_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridVendorItems_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridVendorItems_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridVendorItems_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridVendorItems_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridVendorItems_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridVendorItems_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridVendorItems_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridVendorItems_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridVendorItems_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridVendorItems_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Active { get; }
			public CheckBox IsDefault { get; }
			public Selector VendorID { get; }
			public PXTextEdit Vendor__AcctName { get; }
			public Selector VendorLocationID { get; }
			public Selector Location__VSiteID { get; }
			public Selector SubItemID { get; }
			public Selector PurchaseUnit { get; }
			public PXTextEdit VendorInventoryID { get; }
			public PXNumberEdit Location__VLeadTime { get; }
			public CheckBox OverrideSettings { get; }
			public PXNumberEdit AddLeadTimeDays { get; }
			public PXNumberEdit MinOrdFreq { get; }
			public PXNumberEdit MinOrdQty { get; }
			public PXNumberEdit MaxOrdQty { get; }
			public PXNumberEdit LotSize { get; }
			public PXNumberEdit ERQ { get; }
			public Selector CuryID { get; }
			public PXNumberEdit LastPrice { get; }
			public PXNumberEdit PrepaymentPct { get; }
			public PXNumberEdit RecordID { get; }
                
                public c_grid_row(c_vendoritems_pxgridvendoritems grid) : 
                        base(grid)
                {
                    Active = new CheckBox("_ctl00_phG_tab_t5_PXGridVendorItems_lv0_vp_chkActive", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    IsDefault = new CheckBox("_ctl00_phG_tab_t5_PXGridVendorItems_lv0_chkIsDefault", "Default", grid.Locator, "IsDefault");
                    IsDefault.DataField = "IsDefault";
                    VendorID = new Selector("_ctl00_phG_tab_t5_PXGridVendorItems_lv0_edVendorID", "Vendor ID", grid.Locator, "VendorID");
                    VendorID.DataField = "VendorID";
                    Vendor__AcctName = new PXTextEdit("_ctl00_phG_tab_t5_PXGridVendorItems_lv0_edVendor__AcctName", "Vendor Name", grid.Locator, "Vendor__AcctName");
                    Vendor__AcctName.DataField = "Vendor__AcctName";
                    VendorLocationID = new Selector("_ctl00_phG_tab_t5_PXGridVendorItems_lv0_edVendorLocationID", "Location", grid.Locator, "VendorLocationID");
                    VendorLocationID.DataField = "VendorLocationID";
                    Location__VSiteID = new Selector("_ctl00_phG_tab_t5_PXGridVendorItems_lv0_edLocation__VSiteID", "Warehouse", grid.Locator, "Location__VSiteID");
                    Location__VSiteID.DataField = "Location__VSiteID";
                    SubItemID = new Selector("_ctl00_phG_tab_t5_PXGridVendorItems_lv0_vp_edSubItemID", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    PurchaseUnit = new Selector("_ctl00_phG_tab_t5_PXGridVendorItems_lv0_es", "Purchase Unit", grid.Locator, "PurchaseUnit");
                    PurchaseUnit.DataField = "PurchaseUnit";
                    VendorInventoryID = new PXTextEdit("_ctl00_phG_tab_t5_PXGridVendorItems_lv0_edVendorInventoryID", "Vendor Inventory ID", grid.Locator, "VendorInventoryID");
                    VendorInventoryID.DataField = "VendorInventoryID";
                    Location__VLeadTime = new PXNumberEdit("_ctl00_phG_tab_t5_PXGridVendorItems_lv0_edLocation__VLeadTime", "Lead Time (Days)", grid.Locator, "Location__VLeadTime");
                    Location__VLeadTime.DataField = "Location__VLeadTime";
                    OverrideSettings = new CheckBox("ctl00_phG_tab_t5_PXGridVendorItems_ef", "Override", grid.Locator, "OverrideSettings");
                    OverrideSettings.DataField = "OverrideSettings";
                    AddLeadTimeDays = new PXNumberEdit("_ctl00_phG_tab_t5_PXGridVendorItems_lv0_edAddLeadTimeDays", "Add. Lead Time (Days)", grid.Locator, "AddLeadTimeDays");
                    AddLeadTimeDays.DataField = "AddLeadTimeDays";
                    MinOrdFreq = new PXNumberEdit("_ctl00_phG_tab_t5_PXGridVendorItems_lv0_edMinOrdFreq", "Min. Order Freq.(Days)", grid.Locator, "MinOrdFreq");
                    MinOrdFreq.DataField = "MinOrdFreq";
                    MinOrdQty = new PXNumberEdit("_ctl00_phG_tab_t5_PXGridVendorItems_lv0_edMinOrdQty", "Min. Order Qty.", grid.Locator, "MinOrdQty");
                    MinOrdQty.DataField = "MinOrdQty";
                    MaxOrdQty = new PXNumberEdit("_ctl00_phG_tab_t5_PXGridVendorItems_lv0_edMaxOrdQty", "Max Order Qty.", grid.Locator, "MaxOrdQty");
                    MaxOrdQty.DataField = "MaxOrdQty";
                    LotSize = new PXNumberEdit("_ctl00_phG_tab_t5_PXGridVendorItems_lv0_edLotSize", "Lot Size", grid.Locator, "LotSize");
                    LotSize.DataField = "LotSize";
                    ERQ = new PXNumberEdit("_ctl00_phG_tab_t5_PXGridVendorItems_lv0_edERQ", "EOQ", grid.Locator, "ERQ");
                    ERQ.DataField = "ERQ";
                    CuryID = new Selector("_ctl00_phG_tab_t5_PXGridVendorItems_lv0_edCuryID", "Currency ID", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    LastPrice = new PXNumberEdit("_ctl00_phG_tab_t5_PXGridVendorItems_lv0_edLastPrice", "Last Vendor Price", grid.Locator, "LastPrice");
                    LastPrice.DataField = "LastPrice";
                    PrepaymentPct = new PXNumberEdit("ctl00_phG_tab_t5_PXGridVendorItems_en", "Prepayment Percent", grid.Locator, "PrepaymentPct");
                    PrepaymentPct.DataField = "PrepaymentPct";
                    RecordID = new PXNumberEdit("ctl00_phG_tab_t5_PXGridVendorItems_en", "RecordID", grid.Locator, "RecordID");
                    RecordID.DataField = "RecordID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Active { get; }
				public CheckBoxColumnFilter IsDefault { get; }
				public SelectorColumnFilter VendorID { get; }
				public PXTextEditColumnFilter Vendor__AcctName { get; }
				public SelectorColumnFilter VendorLocationID { get; }
				public InputColumnFilter Location__VSiteID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public SelectorColumnFilter PurchaseUnit { get; }
				public PXTextEditColumnFilter VendorInventoryID { get; }
				public PXNumberEditColumnFilter Location__VLeadTime { get; }
				public CheckBoxColumnFilter OverrideSettings { get; }
				public PXNumberEditColumnFilter AddLeadTimeDays { get; }
				public PXNumberEditColumnFilter MinOrdFreq { get; }
				public PXNumberEditColumnFilter MinOrdQty { get; }
				public PXNumberEditColumnFilter MaxOrdQty { get; }
				public PXNumberEditColumnFilter LotSize { get; }
				public PXNumberEditColumnFilter ERQ { get; }
				public SelectorColumnFilter CuryID { get; }
				public PXNumberEditColumnFilter LastPrice { get; }
				public PXNumberEditColumnFilter PrepaymentPct { get; }
				public PXNumberEditColumnFilter RecordID { get; }
                
                public c_grid_header(c_vendoritems_pxgridvendoritems grid) : 
                        base(grid)
                {
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    IsDefault = new CheckBoxColumnFilter(grid.Row.IsDefault);
                    VendorID = new SelectorColumnFilter(grid.Row.VendorID);
                    Vendor__AcctName = new PXTextEditColumnFilter(grid.Row.Vendor__AcctName);
                    VendorLocationID = new SelectorColumnFilter(grid.Row.VendorLocationID);
                    Location__VSiteID = new InputColumnFilter(grid.Row.Location__VSiteID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    PurchaseUnit = new SelectorColumnFilter(grid.Row.PurchaseUnit);
                    VendorInventoryID = new PXTextEditColumnFilter(grid.Row.VendorInventoryID);
                    Location__VLeadTime = new PXNumberEditColumnFilter(grid.Row.Location__VLeadTime);
                    OverrideSettings = new CheckBoxColumnFilter(grid.Row.OverrideSettings);
                    AddLeadTimeDays = new PXNumberEditColumnFilter(grid.Row.AddLeadTimeDays);
                    MinOrdFreq = new PXNumberEditColumnFilter(grid.Row.MinOrdFreq);
                    MinOrdQty = new PXNumberEditColumnFilter(grid.Row.MinOrdQty);
                    MaxOrdQty = new PXNumberEditColumnFilter(grid.Row.MaxOrdQty);
                    LotSize = new PXNumberEditColumnFilter(grid.Row.LotSize);
                    ERQ = new PXNumberEditColumnFilter(grid.Row.ERQ);
                    CuryID = new SelectorColumnFilter(grid.Row.CuryID);
                    LastPrice = new PXNumberEditColumnFilter(grid.Row.LastPrice);
                    PrepaymentPct = new PXNumberEditColumnFilter(grid.Row.PrepaymentPct);
                    RecordID = new PXNumberEditColumnFilter(grid.Row.RecordID);
                }
            }
        }
        
        public class c_vendoritems_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector VendorID { get; }
			public Label VendorIDLabel { get; }
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public Selector Location__VSiteID { get; }
			public Label Location__VSiteIDLabel { get; }
			public Selector VendorLocationID { get; }
			public Label VendorLocationIDLabel { get; }
			public PXTextEdit VendorInventoryID { get; }
			public Label VendorInventoryIDLabel { get; }
			public PXNumberEdit AddLeadTimeDays { get; }
			public Label AddLeadTimeDaysLabel { get; }
			public CheckBox Active { get; }
			public Label ActiveLabel { get; }
			public PXNumberEdit MinOrdFreq { get; }
			public Label MinOrdFreqLabel { get; }
			public PXNumberEdit MinOrdQty { get; }
			public Label MinOrdQtyLabel { get; }
			public PXNumberEdit MaxOrdQty { get; }
			public Label MaxOrdQtyLabel { get; }
			public PXNumberEdit LotSize { get; }
			public Label LotSizeLabel { get; }
			public PXNumberEdit ERQ { get; }
			public Label ERQLabel { get; }
			public Selector CuryID { get; }
			public Label CuryIDLabel { get; }
			public PXNumberEdit LastPrice { get; }
			public Label LastPriceLabel { get; }
			public CheckBox IsDefault { get; }
			public Label IsDefaultLabel { get; }
			public PXTextEdit Vendor__AcctName { get; }
			public Label Vendor__AcctNameLabel { get; }
			public PXNumberEdit Location__VLeadTime { get; }
			public Label Location__VLeadTimeLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_vendoritems_lv0(string locator, string name) : 
                    base(locator, name)
            {
                VendorID = new Selector("ctl00_phG_tab_t5_PXGridVendorItems_lv0_edVendorID", "Vendor ID", locator, null);
                VendorIDLabel = new Label(VendorID);
                VendorID.DataField = "VendorID";
                SubItemID = new Selector("ctl00_phG_tab_t5_PXGridVendorItems_lv0_vp_edSubItemID", "Subitem", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                Location__VSiteID = new Selector("ctl00_phG_tab_t5_PXGridVendorItems_lv0_edLocation__VSiteID", "Warehouse", locator, null);
                Location__VSiteIDLabel = new Label(Location__VSiteID);
                Location__VSiteID.DataField = "Location__VSiteID";
                VendorLocationID = new Selector("ctl00_phG_tab_t5_PXGridVendorItems_lv0_edVendorLocationID", "Location", locator, null);
                VendorLocationIDLabel = new Label(VendorLocationID);
                VendorLocationID.DataField = "VendorLocationID";
                VendorInventoryID = new PXTextEdit("ctl00_phG_tab_t5_PXGridVendorItems_lv0_edVendorInventoryID", "Vendor Inventory ID", locator, null);
                VendorInventoryIDLabel = new Label(VendorInventoryID);
                VendorInventoryID.DataField = "VendorInventoryID";
                AddLeadTimeDays = new PXNumberEdit("ctl00_phG_tab_t5_PXGridVendorItems_lv0_edAddLeadTimeDays", "Add. Lead Time (Days)", locator, null);
                AddLeadTimeDaysLabel = new Label(AddLeadTimeDays);
                AddLeadTimeDays.DataField = "AddLeadTimeDays";
                Active = new CheckBox("ctl00_phG_tab_t5_PXGridVendorItems_lv0_vp_chkActive", "Active", locator, null);
                ActiveLabel = new Label(Active);
                Active.DataField = "Active";
                MinOrdFreq = new PXNumberEdit("ctl00_phG_tab_t5_PXGridVendorItems_lv0_edMinOrdFreq", "Min. Order Freq.(Days)", locator, null);
                MinOrdFreqLabel = new Label(MinOrdFreq);
                MinOrdFreq.DataField = "MinOrdFreq";
                MinOrdQty = new PXNumberEdit("ctl00_phG_tab_t5_PXGridVendorItems_lv0_edMinOrdQty", "Min. Order Qty.", locator, null);
                MinOrdQtyLabel = new Label(MinOrdQty);
                MinOrdQty.DataField = "MinOrdQty";
                MaxOrdQty = new PXNumberEdit("ctl00_phG_tab_t5_PXGridVendorItems_lv0_edMaxOrdQty", "Max Order Qty.", locator, null);
                MaxOrdQtyLabel = new Label(MaxOrdQty);
                MaxOrdQty.DataField = "MaxOrdQty";
                LotSize = new PXNumberEdit("ctl00_phG_tab_t5_PXGridVendorItems_lv0_edLotSize", "Lot Size", locator, null);
                LotSizeLabel = new Label(LotSize);
                LotSize.DataField = "LotSize";
                ERQ = new PXNumberEdit("ctl00_phG_tab_t5_PXGridVendorItems_lv0_edERQ", "EOQ", locator, null);
                ERQLabel = new Label(ERQ);
                ERQ.DataField = "ERQ";
                CuryID = new Selector("ctl00_phG_tab_t5_PXGridVendorItems_lv0_edCuryID", "Currency ID", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                LastPrice = new PXNumberEdit("ctl00_phG_tab_t5_PXGridVendorItems_lv0_edLastPrice", "Last Vendor Price", locator, null);
                LastPriceLabel = new Label(LastPrice);
                LastPrice.DataField = "LastPrice";
                IsDefault = new CheckBox("ctl00_phG_tab_t5_PXGridVendorItems_lv0_chkIsDefault", "Default", locator, null);
                IsDefaultLabel = new Label(IsDefault);
                IsDefault.DataField = "IsDefault";
                Vendor__AcctName = new PXTextEdit("ctl00_phG_tab_t5_PXGridVendorItems_lv0_edVendor__AcctName", "Vendor Name", locator, null);
                Vendor__AcctNameLabel = new Label(Vendor__AcctName);
                Vendor__AcctName.DataField = "Vendor__AcctName";
                Location__VLeadTime = new PXNumberEdit("ctl00_phG_tab_t5_PXGridVendorItems_lv0_edLocation__VLeadTime", "Lead Time (Days)", locator, null);
                Location__VLeadTimeLabel = new Label(Location__VLeadTime);
                Location__VLeadTime.DataField = "Location__VLeadTime";
                Es = new Selector("ctl00_phG_tab_t5_PXGridVendorItems_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "VendorItems";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void VendorIDEdit()
            {
                Buttons.VendorIDEdit.Click();
            }
            
            public virtual void Location__VSiteIDEdit()
            {
                Buttons.Location__VSiteIDEdit.Click();
            }
            
            public virtual void VendorLocationIDEdit()
            {
                Buttons.VendorLocationIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button VendorIDEdit { get; }
			public Button Location__VSiteIDEdit { get; }
			public Button VendorLocationIDEdit { get; }
                
                public PxButtonCollection()
                {
                    VendorIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t5_PXGridVendorItems_lv0_edVendorID\'] div[class=\'editBt" +
                            "nCont\'] > div > div", "VendorIDEdit", "ctl00_phG_tab_t5_PXGridVendorItems_lv0");
                    VendorIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    Location__VSiteIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t5_PXGridVendorItems_lv0_edLocation__VSiteID\'] div[clas" +
                            "s=\'editBtnCont\'] > div > div", "Location__VSiteIDEdit", "ctl00_phG_tab_t5_PXGridVendorItems_lv0");
                    Location__VSiteIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    VendorLocationIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t5_PXGridVendorItems_lv0_edVendorLocationID\'] div[class" +
                            "=\'editBtnCont\'] > div > div", "VendorLocationIDEdit", "ctl00_phG_tab_t5_PXGridVendorItems_lv0");
                    VendorLocationIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_answers_pxgridanswers : Grid<c_answers_pxgridanswers.c_grid_row, c_answers_pxgridanswers.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_answers_pxgridanswers(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "Answers";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void First1()
            {
                Buttons.First1.Click();
            }
            
            public virtual void Prev1()
            {
                Buttons.Prev1.Click();
            }
            
            public virtual void Next1()
            {
                Buttons.Next1.Click();
            }
            
            public virtual void Last1()
            {
                Buttons.Last1.Click();
            }
            
            public virtual void UpBtn()
            {
                Buttons.UpBtn.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button First1 { get; }
			public Button Prev1 { get; }
			public Button Next1 { get; }
			public Button Last1 { get; }
			public Button UpBtn { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfFirst0", "First", "ctl00_phG_tab_t6_PXGridAnswers");
                    Prev = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfPrev0", "Prev", "ctl00_phG_tab_t6_PXGridAnswers");
                    Next = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfNext0", "Next", "ctl00_phG_tab_t6_PXGridAnswers");
                    Last = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfLast0", "Last", "ctl00_phG_tab_t6_PXGridAnswers");
                    First1 = new Button("ctl00_phG_tab_t6_PXGridCategory_lfFirst0", "First", "ctl00_phG_tab_t6_PXGridAnswers");
                    Prev1 = new Button("ctl00_phG_tab_t6_PXGridCategory_lfPrev0", "Prev", "ctl00_phG_tab_t6_PXGridAnswers");
                    Next1 = new Button("ctl00_phG_tab_t6_PXGridCategory_lfNext0", "Next", "ctl00_phG_tab_t6_PXGridAnswers");
                    Last1 = new Button("ctl00_phG_tab_t6_PXGridCategory_lfLast0", "Last", "ctl00_phG_tab_t6_PXGridAnswers");
                    UpBtn = new Button("ctl00_phG_tab_t6_imgUploader_upld_upBtn", "upBtn", "ctl00_phG_tab_t6_PXGridAnswers");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit AttributeID { get; }
			public CheckBox IsRequired { get; }
			public DropDown AttributeCategory { get; }
			public PXTextEdit Value { get; }
			public PXTextEdit RefNoteID { get; }
                
                public c_grid_row(c_answers_pxgridanswers grid) : 
                        base(grid)
                {
                    AttributeID = new PXTextEdit("_ctl00_phG_tab_t6_PXGridAnswers_lv0_edParameterID", "Attribute", grid.Locator, "AttributeID");
                    AttributeID.DataField = "AttributeID";
                    IsRequired = new CheckBox("ctl00_phG_tab_t6_PXGridAnswers", "Required", grid.Locator, "isRequired");
                    IsRequired.DataField = "isRequired";
                    AttributeCategory = new DropDown("_ctl00_phG_tab_t6_PXGridAnswers_lv0_ec", "Category", grid.Locator, "AttributeCategory");
                    AttributeCategory.DataField = "AttributeCategory";
                    AttributeCategory.Items.Add("A", "Attribute");
                    AttributeCategory.Items.Add("V", "Variant");
                    Value = new PXTextEdit("_ctl00_phG_tab_t6_PXGridAnswers_lv0_edAnswerValue", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                    RefNoteID = new PXTextEdit("ctl00_phG_tab_t6_PXGridAnswers_ei", "RefNoteID", grid.Locator, "RefNoteID");
                    RefNoteID.DataField = "RefNoteID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter AttributeID { get; }
				public CheckBoxColumnFilter IsRequired { get; }
				public DropDownColumnFilter AttributeCategory { get; }
				public PXTextEditColumnFilter Value { get; }
				public PXTextEditColumnFilter RefNoteID { get; }
                
                public c_grid_header(c_answers_pxgridanswers grid) : 
                        base(grid)
                {
                    AttributeID = new PXTextEditColumnFilter(grid.Row.AttributeID);
                    IsRequired = new CheckBoxColumnFilter(grid.Row.IsRequired);
                    AttributeCategory = new DropDownColumnFilter(grid.Row.AttributeCategory);
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                    RefNoteID = new PXTextEditColumnFilter(grid.Row.RefNoteID);
                }
            }
        }
        
        public class c_answers_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AttributeID { get; }
			public Label AttributeIDLabel { get; }
			public PXTextEdit Value { get; }
			public Label ValueLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_answers_lv0(string locator, string name) : 
                    base(locator, name)
            {
                AttributeID = new PXTextEdit("ctl00_phG_tab_t6_PXGridAnswers_lv0_edParameterID", "Attribute", locator, null);
                AttributeIDLabel = new Label(AttributeID);
                AttributeID.DataField = "AttributeID";
                Value = new PXTextEdit("ctl00_phG_tab_t6_PXGridAnswers_lv0_edAnswerValue", "Value", locator, null);
                ValueLabel = new Label(Value);
                Value.DataField = "Value";
                Es = new Selector("ctl00_phG_tab_t6_PXGridAnswers_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t6_PXGridAnswers_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t6_PXGridAnswers_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t6_PXGridAnswers_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Answers";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void First1()
            {
                Buttons.First1.Click();
            }
            
            public virtual void Prev1()
            {
                Buttons.Prev1.Click();
            }
            
            public virtual void Next1()
            {
                Buttons.Next1.Click();
            }
            
            public virtual void Last1()
            {
                Buttons.Last1.Click();
            }
            
            public virtual void UpBtn()
            {
                Buttons.UpBtn.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button First1 { get; }
			public Button Prev1 { get; }
			public Button Next1 { get; }
			public Button Last1 { get; }
			public Button UpBtn { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfFirst0", "First", "ctl00_phG_tab_t6_PXGridAnswers_lv0");
                    Prev = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfPrev0", "Prev", "ctl00_phG_tab_t6_PXGridAnswers_lv0");
                    Next = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfNext0", "Next", "ctl00_phG_tab_t6_PXGridAnswers_lv0");
                    Last = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfLast0", "Last", "ctl00_phG_tab_t6_PXGridAnswers_lv0");
                    First1 = new Button("ctl00_phG_tab_t6_PXGridCategory_lfFirst0", "First", "ctl00_phG_tab_t6_PXGridAnswers_lv0");
                    Prev1 = new Button("ctl00_phG_tab_t6_PXGridCategory_lfPrev0", "Prev", "ctl00_phG_tab_t6_PXGridAnswers_lv0");
                    Next1 = new Button("ctl00_phG_tab_t6_PXGridCategory_lfNext0", "Next", "ctl00_phG_tab_t6_PXGridAnswers_lv0");
                    Last1 = new Button("ctl00_phG_tab_t6_PXGridCategory_lfLast0", "Last", "ctl00_phG_tab_t6_PXGridAnswers_lv0");
                    UpBtn = new Button("ctl00_phG_tab_t6_imgUploader_upld_upBtn", "upBtn", "ctl00_phG_tab_t6_PXGridAnswers_lv0");
                }
            }
        }
        
        public class c_category_pxgridcategory : Grid<c_category_pxgridcategory.c_grid_row, c_category_pxgridcategory.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_category_pxgridcategory(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t6_PXGridCategory");
                DataMemberName = "Category";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void First1()
            {
                Buttons.First1.Click();
            }
            
            public virtual void Prev1()
            {
                Buttons.Prev1.Click();
            }
            
            public virtual void Next1()
            {
                Buttons.Next1.Click();
            }
            
            public virtual void Last1()
            {
                Buttons.Last1.Click();
            }
            
            public virtual void UpBtn()
            {
                Buttons.UpBtn.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridCategory_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridCategory_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridCategory_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_PXGridCategory_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button First1 { get; }
			public Button Prev1 { get; }
			public Button Next1 { get; }
			public Button Last1 { get; }
			public Button UpBtn { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfFirst0", "First", "ctl00_phG_tab_t6_PXGridCategory");
                    Prev = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfPrev0", "Prev", "ctl00_phG_tab_t6_PXGridCategory");
                    Next = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfNext0", "Next", "ctl00_phG_tab_t6_PXGridCategory");
                    Last = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfLast0", "Last", "ctl00_phG_tab_t6_PXGridCategory");
                    First1 = new Button("ctl00_phG_tab_t6_PXGridCategory_lfFirst0", "First", "ctl00_phG_tab_t6_PXGridCategory");
                    Prev1 = new Button("ctl00_phG_tab_t6_PXGridCategory_lfPrev0", "Prev", "ctl00_phG_tab_t6_PXGridCategory");
                    Next1 = new Button("ctl00_phG_tab_t6_PXGridCategory_lfNext0", "Next", "ctl00_phG_tab_t6_PXGridCategory");
                    Last1 = new Button("ctl00_phG_tab_t6_PXGridCategory_lfLast0", "Last", "ctl00_phG_tab_t6_PXGridCategory");
                    UpBtn = new Button("ctl00_phG_tab_t6_imgUploader_upld_upBtn", "upBtn", "ctl00_phG_tab_t6_PXGridCategory");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public TreeSelector CategoryID { get; }
			public Selector InventoryID { get; }
                
                public c_grid_row(c_category_pxgridcategory grid) : 
                        base(grid)
                {
                    CategoryID = new TreeSelector("_ctl00_phG_tab_t6_PXGridCategory_lv0_edParent", "Category ID", grid.Locator, "CategoryID");
                    CategoryID.DataField = "CategoryID";
                    InventoryID = new Selector("_ctl00_phG_tab_t6_PXGridCategory_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public TreeSelectorColumnFilter CategoryID { get; }
				public SelectorColumnFilter InventoryID { get; }
                
                public c_grid_header(c_category_pxgridcategory grid) : 
                        base(grid)
                {
                    CategoryID = new TreeSelectorColumnFilter(grid.Row.CategoryID);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                }
            }
        }
        
        public class c_category_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public TreeSelector CategoryID { get; }
			public Label CategoryIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_category_lv0(string locator, string name) : 
                    base(locator, name)
            {
                CategoryID = new TreeSelector("ctl00_phG_tab_t6_PXGridCategory_lv0_edParent", "Category ID", locator, null);
                CategoryIDLabel = new Label(CategoryID);
                CategoryID.DataField = "CategoryID";
                Es = new Selector("ctl00_phG_tab_t6_PXGridCategory_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "Category";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void First1()
            {
                Buttons.First1.Click();
            }
            
            public virtual void Prev1()
            {
                Buttons.Prev1.Click();
            }
            
            public virtual void Next1()
            {
                Buttons.Next1.Click();
            }
            
            public virtual void Last1()
            {
                Buttons.Last1.Click();
            }
            
            public virtual void UpBtn()
            {
                Buttons.UpBtn.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button First1 { get; }
			public Button Prev1 { get; }
			public Button Next1 { get; }
			public Button Last1 { get; }
			public Button UpBtn { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfFirst0", "First", "ctl00_phG_tab_t6_PXGridCategory_lv0");
                    Prev = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfPrev0", "Prev", "ctl00_phG_tab_t6_PXGridCategory_lv0");
                    Next = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfNext0", "Next", "ctl00_phG_tab_t6_PXGridCategory_lv0");
                    Last = new Button("ctl00_phG_tab_t6_PXGridAnswers_lfLast0", "Last", "ctl00_phG_tab_t6_PXGridCategory_lv0");
                    First1 = new Button("ctl00_phG_tab_t6_PXGridCategory_lfFirst0", "First", "ctl00_phG_tab_t6_PXGridCategory_lv0");
                    Prev1 = new Button("ctl00_phG_tab_t6_PXGridCategory_lfPrev0", "Prev", "ctl00_phG_tab_t6_PXGridCategory_lv0");
                    Next1 = new Button("ctl00_phG_tab_t6_PXGridCategory_lfNext0", "Next", "ctl00_phG_tab_t6_PXGridCategory_lv0");
                    Last1 = new Button("ctl00_phG_tab_t6_PXGridCategory_lfLast0", "Last", "ctl00_phG_tab_t6_PXGridCategory_lv0");
                    UpBtn = new Button("ctl00_phG_tab_t6_imgUploader_upld_upBtn", "upBtn", "ctl00_phG_tab_t6_PXGridCategory_lv0");
                }
            }
        }
        
        public class c_itemcosts_formcoststats : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit LastCost_Label { get; }
			public Label LastCost_LabelLabel { get; }
			public PXNumberEdit LastCost { get; }
			public Label LastCostLabel { get; }
			public PXTextEdit AvgCost_Label { get; }
			public Label AvgCost_LabelLabel { get; }
			public PXNumberEdit AvgCost { get; }
			public Label AvgCostLabel { get; }
			public PXTextEdit MinCost_Label { get; }
			public Label MinCost_LabelLabel { get; }
			public PXNumberEdit MinCost { get; }
			public Label MinCostLabel { get; }
			public PXTextEdit MaxCost_Label { get; }
			public Label MaxCost_LabelLabel { get; }
			public PXNumberEdit MaxCost { get; }
			public Label MaxCostLabel { get; }
            
            public c_itemcosts_formcoststats(string locator, string name) : 
                    base(locator, name)
            {
                LastCost_Label = new PXTextEdit("ctl00_phG_tab_t2_formCostStats_edLastCostLable", "Last Cost _ Label", locator, null);
                LastCost_LabelLabel = new Label(LastCost_Label);
                LastCost_Label.DataField = "LastCost_Label";
                LastCost = new PXNumberEdit("ctl00_phG_tab_t2_formCostStats_edLastCost", "Last Cost", locator, null);
                LastCostLabel = new Label(LastCost);
                LastCost.DataField = "LastCost";
                AvgCost_Label = new PXTextEdit("ctl00_phG_tab_t2_formCostStats_edAvgCostLabel", "Avg Cost _ Label", locator, null);
                AvgCost_LabelLabel = new Label(AvgCost_Label);
                AvgCost_Label.DataField = "AvgCost_Label";
                AvgCost = new PXNumberEdit("ctl00_phG_tab_t2_formCostStats_edAvgCost", "Avg Cost", locator, null);
                AvgCostLabel = new Label(AvgCost);
                AvgCost.DataField = "AvgCost";
                MinCost_Label = new PXTextEdit("ctl00_phG_tab_t2_formCostStats_edMinCostLabel", "Min Cost _ Label", locator, null);
                MinCost_LabelLabel = new Label(MinCost_Label);
                MinCost_Label.DataField = "MinCost_Label";
                MinCost = new PXNumberEdit("ctl00_phG_tab_t2_formCostStats_edMinCost", "Min Cost", locator, null);
                MinCostLabel = new Label(MinCost);
                MinCost.DataField = "MinCost";
                MaxCost_Label = new PXTextEdit("ctl00_phG_tab_t2_formCostStats_edMaxCostLabel", "Max Cost _ Label", locator, null);
                MaxCost_LabelLabel = new Label(MaxCost_Label);
                MaxCost_Label.DataField = "MaxCost_Label";
                MaxCost = new PXNumberEdit("ctl00_phG_tab_t2_formCostStats_edMaxCost", "Max Cost", locator, null);
                MaxCostLabel = new Label(MaxCost);
                MaxCost.DataField = "MaxCost";
                DataMemberName = "itemcosts";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void PriceClassIDEdit()
            {
                Buttons.PriceClassIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button PriceClassIDEdit { get; }
                
                public PxButtonCollection()
                {
                    PriceClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_edPriceClassID\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "PriceClassIDEdit", "ctl00_phG_tab_t2_formCostStats");
                    PriceClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_itemsiterecords_grid2 : Grid<c_itemsiterecords_grid2.c_grid_row, c_itemsiterecords_grid2.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_itemsiterecords_grid2(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t4_grid2");
                DataMemberName = "itemsiterecords";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t4_grid2_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void FormView()
            {
                ToolBar.FormView.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void AddWarehouseDetail()
            {
                ToolBar.AddWarehouseDetail.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid FormView { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid AddWarehouseDetail { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid2_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid2_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    FormView = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid2_at_tlb div[data-cmd=\'EditRecord\']", "Switch Between Grid and Form", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid2_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    AddWarehouseDetail = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid2_at_tlb div[data-cmd=\'AddWarehouseDetail\']", "Add Warehouse Detail", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid2_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid2_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid2_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid2_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid2_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid2_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid2_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_grid2_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox IsDefault { get; }
			public Selector SiteID { get; }
			public Selector DfltReceiptLocationID { get; }
			public Selector DfltShipLocationID { get; }
			public DropDown SiteStatus { get; }
			public Selector InvtAcctID { get; }
			public Selector InvtSubID { get; }
			public CheckBox ProductManagerOverride { get; }
			public Selector ProductWorkgroupID { get; }
			public Selector ProductManagerID { get; }
			public CheckBox StdCostOverride { get; }
			public CheckBox BasePriceOverride { get; }
			public PXNumberEdit INSiteStatusSummary__QtyOnHand { get; }
			public CheckBox PreferredVendorOverride { get; }
			public Selector PreferredVendorID { get; }
			public CheckBox ReplenishmentPolicyOverride { get; }
			public Selector ReplenishmentPolicyID { get; }
			public DropDown ReplenishmentSource { get; }
			public Selector ReplenishmentSourceSiteID { get; }
			public CheckBox ServiceLevelOverride { get; }
			public PXNumberEdit ServiceLevelPct { get; }
			public DateSelector LastForecastDate { get; }
			public PXNumberEdit DemandPerDayAverage { get; }
			public PXNumberEdit DemandPerDaySTDEV { get; }
			public Selector InventoryID { get; }
                
                public c_grid_row(c_itemsiterecords_grid2 grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    IsDefault = new CheckBox("ctl00_phG_tab_t4_grid2_ef", "Default", grid.Locator, "IsDefault");
                    IsDefault.DataField = "IsDefault";
                    SiteID = new Selector("_ctl00_phG_tab_t4_grid2_lv0_edSiteID2", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    DfltReceiptLocationID = new Selector("_ctl00_phG_tab_t4_grid2_lv0_edDfltReceiptLocationID2", "Default Receipt To", grid.Locator, "DfltReceiptLocationID");
                    DfltReceiptLocationID.DataField = "DfltReceiptLocationID";
                    DfltShipLocationID = new Selector("_ctl00_phG_tab_t4_grid2_lv0_edDfltShipLocationID2", "Default Issue From", grid.Locator, "DfltShipLocationID");
                    DfltShipLocationID.DataField = "DfltShipLocationID";
                    SiteStatus = new DropDown("_ctl00_phG_tab_t4_grid2_lv0_ec", "Status", grid.Locator, "SiteStatus");
                    SiteStatus.DataField = "SiteStatus";
                    SiteStatus.Items.Add("AC", "Active");
                    SiteStatus.Items.Add("IN", "Inactive");
                    InvtAcctID = new Selector("_ctl00_phG_tab_t4_grid2_lv0_edInvtAcctID2", "Inventory Account", grid.Locator, "InvtAcctID");
                    InvtAcctID.DataField = "InvtAcctID";
                    InvtSubID = new Selector("_ctl00_phG_tab_t4_grid2_lv0_edInvtSubID2", "Inventory Sub.", grid.Locator, "InvtSubID");
                    InvtSubID.DataField = "InvtSubID";
                    ProductManagerOverride = new CheckBox("ctl00_phG_tab_t4_grid2", "Override Product Manager", grid.Locator, "ProductManagerOverride");
                    ProductManagerOverride.DataField = "ProductManagerOverride";
                    ProductWorkgroupID = new Selector("_ctl00_phG_tab_t4_grid2_lv0_es", "Product Workgroup", grid.Locator, "ProductWorkgroupID");
                    ProductWorkgroupID.DataField = "ProductWorkgroupID";
                    ProductManagerID = new Selector("_ctl00_phG_tab_t4_grid2_lv0_es", "Product Manager", grid.Locator, "ProductManagerID");
                    ProductManagerID.DataField = "ProductManagerID";
                    StdCostOverride = new CheckBox("ctl00_phG_tab_t4_grid2", "Override Std. Cost", grid.Locator, "StdCostOverride");
                    StdCostOverride.DataField = "StdCostOverride";
                    BasePriceOverride = new CheckBox("ctl00_phG_tab_t4_grid2", "Price Override", grid.Locator, "BasePriceOverride");
                    BasePriceOverride.DataField = "BasePriceOverride";
                    INSiteStatusSummary__QtyOnHand = new PXNumberEdit("ctl00_phG_tab_t4_grid2_en", "Qty. On Hand", grid.Locator, "INSiteStatusSummary__QtyOnHand");
                    INSiteStatusSummary__QtyOnHand.DataField = "INSiteStatusSummary__QtyOnHand";
                    PreferredVendorOverride = new CheckBox("ctl00_phG_tab_t4_grid2", "Override Preferred Vendor", grid.Locator, "PreferredVendorOverride");
                    PreferredVendorOverride.DataField = "PreferredVendorOverride";
                    PreferredVendorID = new Selector("_ctl00_phG_tab_t4_grid2_lv0_edPreferredVendorID", "Preferred Vendor", grid.Locator, "PreferredVendorID");
                    PreferredVendorID.DataField = "PreferredVendorID";
                    ReplenishmentPolicyOverride = new CheckBox("ctl00_phG_tab_t4_grid2", "Override Replenishment Settings", grid.Locator, "ReplenishmentPolicyOverride");
                    ReplenishmentPolicyOverride.DataField = "ReplenishmentPolicyOverride";
                    ReplenishmentPolicyID = new Selector("_ctl00_phG_tab_t4_grid2_lv0_es", "Seasonality", grid.Locator, "ReplenishmentPolicyID");
                    ReplenishmentPolicyID.DataField = "ReplenishmentPolicyID";
                    ReplenishmentSource = new DropDown("_ctl00_phG_tab_t4_grid2_lv0_ec", "Replenishment Source", grid.Locator, "ReplenishmentSource");
                    ReplenishmentSource.DataField = "ReplenishmentSource";
                    ReplenishmentSource.Items.Add("N", "None");
                    ReplenishmentSource.Items.Add("P", "Purchase");
                    ReplenishmentSource.Items.Add("M", "Manufacturing");
                    ReplenishmentSource.Items.Add("T", "Transfer");
                    ReplenishmentSource.Items.Add("D", "Drop-Shipment");
                    ReplenishmentSource.Items.Add("O", "Purchase to Order");
                    ReplenishmentSourceSiteID = new Selector("_ctl00_phG_tab_t4_grid2_lv0_es", "Replenishment Warehouse", grid.Locator, "ReplenishmentSourceSiteID");
                    ReplenishmentSourceSiteID.DataField = "ReplenishmentSourceSiteID";
                    ServiceLevelOverride = new CheckBox("ctl00_phG_tab_t4_grid2", "Override", grid.Locator, "ServiceLevelOverride");
                    ServiceLevelOverride.DataField = "ServiceLevelOverride";
                    ServiceLevelPct = new PXNumberEdit("ctl00_phG_tab_t4_grid2_en", "Service Level (%)", grid.Locator, "ServiceLevelPct");
                    ServiceLevelPct.DataField = "ServiceLevelPct";
                    LastForecastDate = new DateSelector("_ctl00_phG_tab_t4_grid2_lv0_ed23", "Last Forecast Date", grid.Locator, "LastForecastDate");
                    LastForecastDate.DataField = "LastForecastDate";
                    DemandPerDayAverage = new PXNumberEdit("ctl00_phG_tab_t4_grid2_en", "Daily Demand Forecast", grid.Locator, "DemandPerDayAverage");
                    DemandPerDayAverage.DataField = "DemandPerDayAverage";
                    DemandPerDaySTDEV = new PXNumberEdit("ctl00_phG_tab_t4_grid2_en", "Daily Demand Forecast Error(STDEV)", grid.Locator, "DemandPerDaySTDEV");
                    DemandPerDaySTDEV.DataField = "DemandPerDaySTDEV";
                    InventoryID = new Selector("_ctl00_phG_tab_t4_grid2_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter IsDefault { get; }
				public SelectorColumnFilter SiteID { get; }
				public SelectorColumnFilter DfltReceiptLocationID { get; }
				public SelectorColumnFilter DfltShipLocationID { get; }
				public DropDownColumnFilter SiteStatus { get; }
				public SelectorColumnFilter InvtAcctID { get; }
				public SelectorColumnFilter InvtSubID { get; }
				public CheckBoxColumnFilter ProductManagerOverride { get; }
				public SelectorColumnFilter ProductWorkgroupID { get; }
				public SelectorColumnFilter ProductManagerID { get; }
				public CheckBoxColumnFilter StdCostOverride { get; }
				public CheckBoxColumnFilter BasePriceOverride { get; }
				public PXNumberEditColumnFilter INSiteStatusSummary__QtyOnHand { get; }
				public CheckBoxColumnFilter PreferredVendorOverride { get; }
				public SelectorColumnFilter PreferredVendorID { get; }
				public CheckBoxColumnFilter ReplenishmentPolicyOverride { get; }
				public SelectorColumnFilter ReplenishmentPolicyID { get; }
				public DropDownColumnFilter ReplenishmentSource { get; }
				public SelectorColumnFilter ReplenishmentSourceSiteID { get; }
				public CheckBoxColumnFilter ServiceLevelOverride { get; }
				public PXNumberEditColumnFilter ServiceLevelPct { get; }
				public DateSelectorColumnFilter LastForecastDate { get; }
				public PXNumberEditColumnFilter DemandPerDayAverage { get; }
				public PXNumberEditColumnFilter DemandPerDaySTDEV { get; }
				public SelectorColumnFilter InventoryID { get; }
                
                public c_grid_header(c_itemsiterecords_grid2 grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    IsDefault = new CheckBoxColumnFilter(grid.Row.IsDefault);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    DfltReceiptLocationID = new SelectorColumnFilter(grid.Row.DfltReceiptLocationID);
                    DfltShipLocationID = new SelectorColumnFilter(grid.Row.DfltShipLocationID);
                    SiteStatus = new DropDownColumnFilter(grid.Row.SiteStatus);
                    InvtAcctID = new SelectorColumnFilter(grid.Row.InvtAcctID);
                    InvtSubID = new SelectorColumnFilter(grid.Row.InvtSubID);
                    ProductManagerOverride = new CheckBoxColumnFilter(grid.Row.ProductManagerOverride);
                    ProductWorkgroupID = new SelectorColumnFilter(grid.Row.ProductWorkgroupID);
                    ProductManagerID = new SelectorColumnFilter(grid.Row.ProductManagerID);
                    StdCostOverride = new CheckBoxColumnFilter(grid.Row.StdCostOverride);
                    BasePriceOverride = new CheckBoxColumnFilter(grid.Row.BasePriceOverride);
                    INSiteStatusSummary__QtyOnHand = new PXNumberEditColumnFilter(grid.Row.INSiteStatusSummary__QtyOnHand);
                    PreferredVendorOverride = new CheckBoxColumnFilter(grid.Row.PreferredVendorOverride);
                    PreferredVendorID = new SelectorColumnFilter(grid.Row.PreferredVendorID);
                    ReplenishmentPolicyOverride = new CheckBoxColumnFilter(grid.Row.ReplenishmentPolicyOverride);
                    ReplenishmentPolicyID = new SelectorColumnFilter(grid.Row.ReplenishmentPolicyID);
                    ReplenishmentSource = new DropDownColumnFilter(grid.Row.ReplenishmentSource);
                    ReplenishmentSourceSiteID = new SelectorColumnFilter(grid.Row.ReplenishmentSourceSiteID);
                    ServiceLevelOverride = new CheckBoxColumnFilter(grid.Row.ServiceLevelOverride);
                    ServiceLevelPct = new PXNumberEditColumnFilter(grid.Row.ServiceLevelPct);
                    LastForecastDate = new DateSelectorColumnFilter(grid.Row.LastForecastDate);
                    DemandPerDayAverage = new PXNumberEditColumnFilter(grid.Row.DemandPerDayAverage);
                    DemandPerDaySTDEV = new PXNumberEditColumnFilter(grid.Row.DemandPerDaySTDEV);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                }
            }
        }
        
        public class c_itemsiterecords_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector PreferredVendorID { get; }
			public Label PreferredVendorIDLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public Selector InvtAcctID { get; }
			public Label InvtAcctIDLabel { get; }
			public Selector DfltShipLocationID { get; }
			public Label DfltShipLocationIDLabel { get; }
			public Selector InvtSubID { get; }
			public Label InvtSubIDLabel { get; }
			public Selector DfltReceiptLocationID { get; }
			public Label DfltReceiptLocationIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_itemsiterecords_lv0(string locator, string name) : 
                    base(locator, name)
            {
                PreferredVendorID = new Selector("ctl00_phG_tab_t4_grid2_lv0_edPreferredVendorID", "Preferred Vendor", locator, null);
                PreferredVendorIDLabel = new Label(PreferredVendorID);
                PreferredVendorID.DataField = "PreferredVendorID";
                SiteID = new Selector("ctl00_phG_tab_t4_grid2_lv0_edSiteID2", "Site ID", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                InvtAcctID = new Selector("ctl00_phG_tab_t4_grid2_lv0_edInvtAcctID2", "Invt Acct ID", locator, null);
                InvtAcctIDLabel = new Label(InvtAcctID);
                InvtAcctID.DataField = "InvtAcctID";
                DfltShipLocationID = new Selector("ctl00_phG_tab_t4_grid2_lv0_edDfltShipLocationID2", "Dflt Ship Location ID", locator, null);
                DfltShipLocationIDLabel = new Label(DfltShipLocationID);
                DfltShipLocationID.DataField = "DfltShipLocationID";
                InvtSubID = new Selector("ctl00_phG_tab_t4_grid2_lv0_edInvtSubID2", "Invt Sub ID", locator, null);
                InvtSubIDLabel = new Label(InvtSubID);
                InvtSubID.DataField = "InvtSubID";
                DfltReceiptLocationID = new Selector("ctl00_phG_tab_t4_grid2_lv0_edDfltReceiptLocationID2", "Dflt Receipt Location ID", locator, null);
                DfltReceiptLocationIDLabel = new Label(DfltReceiptLocationID);
                DfltReceiptLocationID.DataField = "DfltReceiptLocationID";
                Es = new Selector("ctl00_phG_tab_t4_grid2_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t4_grid2_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t4_grid2_lv0_ec", "Ec", locator, null);
                DataMemberName = "itemsiterecords";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void SiteIDEdit()
            {
                Buttons.SiteIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button SiteIDEdit { get; }
                
                public PxButtonCollection()
                {
                    SiteIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_grid2_lv0_edSiteID2\'] div[class=\'editBtnCont\'] > div" +
                            " > div", "SiteIDEdit", "ctl00_phG_tab_t4_grid2_lv0");
                    SiteIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_replenishment_repgrid : Grid<c_replenishment_repgrid.c_grid_row, c_replenishment_repgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_replenishment_repgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t10_sp1_repGrid");
                DataMemberName = "replenishment";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t10_sp1_repGrid_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public virtual void ReplenishmentClassIDEdit()
            {
                Buttons.ReplenishmentClassIDEdit.Click();
            }
            
            public virtual void ReplenishmentPolicyIDEdit()
            {
                Buttons.ReplenishmentPolicyIDEdit.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repGrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repGrid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repGrid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repGrid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repGrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repGrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repGrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repGrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repGrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repGrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repGrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ReplenishmentClassIDEdit { get; }
			public Button ReplenishmentPolicyIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ReplenishmentClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t10_sp1_repGrid_lv0_edReplenishmentClassID\'] div[class=" +
                            "\'editBtnCont\'] > div > div", "ReplenishmentClassIDEdit", "ctl00_phG_tab_t10_sp1_repGrid");
                    ReplenishmentClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ReplenishmentPolicyIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t10_sp1_repGrid_lv0_edReplenishmentPolicyID\'] div[class" +
                            "=\'editBtnCont\'] > div > div", "ReplenishmentPolicyIDEdit", "ctl00_phG_tab_t10_sp1_repGrid");
                    ReplenishmentPolicyIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector ReplenishmentClassID { get; }
			public Selector ReplenishmentPolicyID { get; }
			public DropDown ReplenishmentSource { get; }
			public DropDown ReplenishmentMethod { get; }
			public Selector ReplenishmentSourceSiteID { get; }
			public PXNumberEdit MaxShelfLife { get; }
			public DateSelector LaunchDate { get; }
			public DateSelector TerminationDate { get; }
			public PXNumberEdit ServiceLevelPct { get; }
			public PXNumberEdit SafetyStock { get; }
			public PXNumberEdit MinQty { get; }
			public PXNumberEdit MaxQty { get; }
			public PXNumberEdit TransferERQ { get; }
			public DropDown ForecastModelType { get; }
			public DropDown ForecastPeriodType { get; }
			public PXNumberEdit HistoryDepth { get; }
			public Selector InventoryID { get; }
			public Selector CuryID { get; }
                
                public c_grid_row(c_replenishment_repgrid grid) : 
                        base(grid)
                {
                    ReplenishmentClassID = new Selector("_ctl00_phG_tab_t10_sp1_repGrid_lv0_edReplenishmentClassID", "Repl. Class", grid.Locator, "ReplenishmentClassID");
                    ReplenishmentClassID.DataField = "ReplenishmentClassID";
                    ReplenishmentPolicyID = new Selector("_ctl00_phG_tab_t10_sp1_repGrid_lv0_edReplenishmentPolicyID", "Seasonality", grid.Locator, "ReplenishmentPolicyID");
                    ReplenishmentPolicyID.DataField = "ReplenishmentPolicyID";
                    ReplenishmentSource = new DropDown("_ctl00_phG_tab_t10_sp1_repGrid_lv0_edReplenishmentSource", "Source", grid.Locator, "ReplenishmentSource");
                    ReplenishmentSource.DataField = "ReplenishmentSource";
                    ReplenishmentSource.Items.Add("N", "None");
                    ReplenishmentSource.Items.Add("P", "Purchase");
                    ReplenishmentSource.Items.Add("M", "Manufacturing");
                    ReplenishmentSource.Items.Add("T", "Transfer");
                    ReplenishmentSource.Items.Add("D", "Drop-Shipment");
                    ReplenishmentSource.Items.Add("O", "Purchase to Order");
                    ReplenishmentMethod = new DropDown("_ctl00_phG_tab_t10_sp1_repGrid_lv0_edReplenishmentMethod", "Method", grid.Locator, "ReplenishmentMethod");
                    ReplenishmentMethod.DataField = "ReplenishmentMethod";
                    ReplenishmentMethod.Items.Add("N", "None");
                    ReplenishmentMethod.Items.Add("M", "Min./Max.");
                    ReplenishmentMethod.Items.Add("F", "Fixed Reorder Qty");
                    ReplenishmentSourceSiteID = new Selector("_ctl00_phG_tab_t10_sp1_repGrid_lv0_edReplenishmentSourceSiteID", "Replenishment Warehouse", grid.Locator, "ReplenishmentSourceSiteID");
                    ReplenishmentSourceSiteID.DataField = "ReplenishmentSourceSiteID";
                    MaxShelfLife = new PXNumberEdit("_ctl00_phG_tab_t10_sp1_repGrid_lv0_edMaxShelfLife", "Max. Shelf Life (Days)", grid.Locator, "MaxShelfLife");
                    MaxShelfLife.DataField = "MaxShelfLife";
                    LaunchDate = new DateSelector("_ctl00_phG_tab_t10_sp1_repGrid_lv0_edLaunchDate", "Launch Date", grid.Locator, "LaunchDate");
                    LaunchDate.DataField = "LaunchDate";
                    TerminationDate = new DateSelector("_ctl00_phG_tab_t10_sp1_repGrid_lv0_edTerminationDate", "Termination Date", grid.Locator, "TerminationDate");
                    TerminationDate.DataField = "TerminationDate";
                    ServiceLevelPct = new PXNumberEdit("_ctl00_phG_tab_t10_sp1_repGrid_lv0_edServiceLevelPct", "Service Level (%)", grid.Locator, "ServiceLevelPct");
                    ServiceLevelPct.DataField = "ServiceLevelPct";
                    SafetyStock = new PXNumberEdit("_ctl00_phG_tab_t10_sp1_repGrid_lv0_edSafetyStock", "Safety Stock", grid.Locator, "SafetyStock");
                    SafetyStock.DataField = "SafetyStock";
                    MinQty = new PXNumberEdit("_ctl00_phG_tab_t10_sp1_repGrid_lv0_edMinQty", "Reorder Point", grid.Locator, "MinQty");
                    MinQty.DataField = "MinQty";
                    MaxQty = new PXNumberEdit("_ctl00_phG_tab_t10_sp1_repGrid_lv0_edMaxQty", "Max Qty.", grid.Locator, "MaxQty");
                    MaxQty.DataField = "MaxQty";
                    TransferERQ = new PXNumberEdit("_ctl00_phG_tab_t10_sp1_repGrid_lv0_edTransferERQ", "Transfer ERQ", grid.Locator, "TransferERQ");
                    TransferERQ.DataField = "TransferERQ";
                    ForecastModelType = new DropDown("_ctl00_phG_tab_t10_sp1_repGrid_lv0_ec", "Demand Forecast Model", grid.Locator, "ForecastModelType");
                    ForecastModelType.DataField = "ForecastModelType";
                    ForecastModelType.Items.Add("NNN", "None");
                    ForecastModelType.Items.Add("CMA", "Moving Average");
                    ForecastPeriodType = new DropDown("_ctl00_phG_tab_t10_sp1_repGrid_lv0_ec", "Forecast Period Type", grid.Locator, "ForecastPeriodType");
                    ForecastPeriodType.DataField = "ForecastPeriodType";
                    ForecastPeriodType.Items.Add("QT", "Quarter");
                    ForecastPeriodType.Items.Add("MT", "Month");
                    ForecastPeriodType.Items.Add("WK", "Week");
                    ForecastPeriodType.Items.Add("DY", "Day");
                    HistoryDepth = new PXNumberEdit("_ctl00_phG_tab_t10_sp1_repGrid_lv0_edHistoryDepth", "Periods to Analyze", grid.Locator, "HistoryDepth");
                    HistoryDepth.DataField = "HistoryDepth";
                    InventoryID = new Selector("_ctl00_phG_tab_t10_sp1_repGrid_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    CuryID = new Selector("_ctl00_phG_tab_t10_sp1_repGrid_lv0_es", "Currency", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter ReplenishmentClassID { get; }
				public SelectorColumnFilter ReplenishmentPolicyID { get; }
				public DropDownColumnFilter ReplenishmentSource { get; }
				public DropDownColumnFilter ReplenishmentMethod { get; }
				public SelectorColumnFilter ReplenishmentSourceSiteID { get; }
				public PXNumberEditColumnFilter MaxShelfLife { get; }
				public DateSelectorColumnFilter LaunchDate { get; }
				public DateSelectorColumnFilter TerminationDate { get; }
				public PXNumberEditColumnFilter ServiceLevelPct { get; }
				public PXNumberEditColumnFilter SafetyStock { get; }
				public PXNumberEditColumnFilter MinQty { get; }
				public PXNumberEditColumnFilter MaxQty { get; }
				public PXNumberEditColumnFilter TransferERQ { get; }
				public DropDownColumnFilter ForecastModelType { get; }
				public DropDownColumnFilter ForecastPeriodType { get; }
				public PXNumberEditColumnFilter HistoryDepth { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter CuryID { get; }
                
                public c_grid_header(c_replenishment_repgrid grid) : 
                        base(grid)
                {
                    ReplenishmentClassID = new SelectorColumnFilter(grid.Row.ReplenishmentClassID);
                    ReplenishmentPolicyID = new SelectorColumnFilter(grid.Row.ReplenishmentPolicyID);
                    ReplenishmentSource = new DropDownColumnFilter(grid.Row.ReplenishmentSource);
                    ReplenishmentMethod = new DropDownColumnFilter(grid.Row.ReplenishmentMethod);
                    ReplenishmentSourceSiteID = new SelectorColumnFilter(grid.Row.ReplenishmentSourceSiteID);
                    MaxShelfLife = new PXNumberEditColumnFilter(grid.Row.MaxShelfLife);
                    LaunchDate = new DateSelectorColumnFilter(grid.Row.LaunchDate);
                    TerminationDate = new DateSelectorColumnFilter(grid.Row.TerminationDate);
                    ServiceLevelPct = new PXNumberEditColumnFilter(grid.Row.ServiceLevelPct);
                    SafetyStock = new PXNumberEditColumnFilter(grid.Row.SafetyStock);
                    MinQty = new PXNumberEditColumnFilter(grid.Row.MinQty);
                    MaxQty = new PXNumberEditColumnFilter(grid.Row.MaxQty);
                    TransferERQ = new PXNumberEditColumnFilter(grid.Row.TransferERQ);
                    ForecastModelType = new DropDownColumnFilter(grid.Row.ForecastModelType);
                    ForecastPeriodType = new DropDownColumnFilter(grid.Row.ForecastPeriodType);
                    HistoryDepth = new PXNumberEditColumnFilter(grid.Row.HistoryDepth);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    CuryID = new SelectorColumnFilter(grid.Row.CuryID);
                }
            }
        }
        
        public class c_replenishment_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector ReplenishmentClassID { get; }
			public Label ReplenishmentClassIDLabel { get; }
			public Selector ReplenishmentPolicyID { get; }
			public Label ReplenishmentPolicyIDLabel { get; }
			public DropDown ReplenishmentSource { get; }
			public Label ReplenishmentSourceLabel { get; }
			public DropDown ReplenishmentMethod { get; }
			public Label ReplenishmentMethodLabel { get; }
			public Selector ReplenishmentSourceSiteID { get; }
			public Label ReplenishmentSourceSiteIDLabel { get; }
			public PXNumberEdit MaxShelfLife { get; }
			public Label MaxShelfLifeLabel { get; }
			public DateSelector LaunchDate { get; }
			public Label LaunchDateLabel { get; }
			public DateSelector TerminationDate { get; }
			public Label TerminationDateLabel { get; }
			public PXNumberEdit ServiceLevelPct { get; }
			public Label ServiceLevelPctLabel { get; }
			public PXNumberEdit SafetyStock { get; }
			public Label SafetyStockLabel { get; }
			public PXNumberEdit MinQty { get; }
			public Label MinQtyLabel { get; }
			public PXNumberEdit MaxQty { get; }
			public Label MaxQtyLabel { get; }
			public PXNumberEdit TransferERQ { get; }
			public Label TransferERQLabel { get; }
			public PXNumberEdit HistoryDepth { get; }
			public Label HistoryDepthLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_replenishment_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ReplenishmentClassID = new Selector("ctl00_phG_tab_t10_sp1_repGrid_lv0_edReplenishmentClassID", "Repl. Class", locator, null);
                ReplenishmentClassIDLabel = new Label(ReplenishmentClassID);
                ReplenishmentClassID.DataField = "ReplenishmentClassID";
                ReplenishmentPolicyID = new Selector("ctl00_phG_tab_t10_sp1_repGrid_lv0_edReplenishmentPolicyID", "Seasonality", locator, null);
                ReplenishmentPolicyIDLabel = new Label(ReplenishmentPolicyID);
                ReplenishmentPolicyID.DataField = "ReplenishmentPolicyID";
                ReplenishmentSource = new DropDown("ctl00_phG_tab_t10_sp1_repGrid_lv0_edReplenishmentSource", "Source", locator, null);
                ReplenishmentSourceLabel = new Label(ReplenishmentSource);
                ReplenishmentSource.DataField = "ReplenishmentSource";
                ReplenishmentSource.Items.Add("N", "None");
                ReplenishmentSource.Items.Add("P", "Purchase");
                ReplenishmentSource.Items.Add("M", "Manufacturing");
                ReplenishmentSource.Items.Add("T", "Transfer");
                ReplenishmentSource.Items.Add("D", "Drop-Shipment");
                ReplenishmentSource.Items.Add("O", "Purchase to Order");
                ReplenishmentMethod = new DropDown("ctl00_phG_tab_t10_sp1_repGrid_lv0_edReplenishmentMethod", "Method", locator, null);
                ReplenishmentMethodLabel = new Label(ReplenishmentMethod);
                ReplenishmentMethod.DataField = "ReplenishmentMethod";
                ReplenishmentMethod.Items.Add("N", "None");
                ReplenishmentMethod.Items.Add("M", "Min./Max.");
                ReplenishmentMethod.Items.Add("F", "Fixed Reorder Qty");
                ReplenishmentSourceSiteID = new Selector("ctl00_phG_tab_t10_sp1_repGrid_lv0_edReplenishmentSourceSiteID", "Replenishment Warehouse", locator, null);
                ReplenishmentSourceSiteIDLabel = new Label(ReplenishmentSourceSiteID);
                ReplenishmentSourceSiteID.DataField = "ReplenishmentSourceSiteID";
                MaxShelfLife = new PXNumberEdit("ctl00_phG_tab_t10_sp1_repGrid_lv0_edMaxShelfLife", "Max. Shelf Life (Days)", locator, null);
                MaxShelfLifeLabel = new Label(MaxShelfLife);
                MaxShelfLife.DataField = "MaxShelfLife";
                LaunchDate = new DateSelector("ctl00_phG_tab_t10_sp1_repGrid_lv0_edLaunchDate", "Launch Date", locator, null);
                LaunchDateLabel = new Label(LaunchDate);
                LaunchDate.DataField = "LaunchDate";
                TerminationDate = new DateSelector("ctl00_phG_tab_t10_sp1_repGrid_lv0_edTerminationDate", "Termination Date", locator, null);
                TerminationDateLabel = new Label(TerminationDate);
                TerminationDate.DataField = "TerminationDate";
                ServiceLevelPct = new PXNumberEdit("ctl00_phG_tab_t10_sp1_repGrid_lv0_edServiceLevelPct", "Service Level (%)", locator, null);
                ServiceLevelPctLabel = new Label(ServiceLevelPct);
                ServiceLevelPct.DataField = "ServiceLevelPct";
                SafetyStock = new PXNumberEdit("ctl00_phG_tab_t10_sp1_repGrid_lv0_edSafetyStock", "Safety Stock", locator, null);
                SafetyStockLabel = new Label(SafetyStock);
                SafetyStock.DataField = "SafetyStock";
                MinQty = new PXNumberEdit("ctl00_phG_tab_t10_sp1_repGrid_lv0_edMinQty", "Reorder Point", locator, null);
                MinQtyLabel = new Label(MinQty);
                MinQty.DataField = "MinQty";
                MaxQty = new PXNumberEdit("ctl00_phG_tab_t10_sp1_repGrid_lv0_edMaxQty", "Max Qty.", locator, null);
                MaxQtyLabel = new Label(MaxQty);
                MaxQty.DataField = "MaxQty";
                TransferERQ = new PXNumberEdit("ctl00_phG_tab_t10_sp1_repGrid_lv0_edTransferERQ", "Transfer ERQ", locator, null);
                TransferERQLabel = new Label(TransferERQ);
                TransferERQ.DataField = "TransferERQ";
                HistoryDepth = new PXNumberEdit("ctl00_phG_tab_t10_sp1_repGrid_lv0_edHistoryDepth", "Periods to Analyze", locator, null);
                HistoryDepthLabel = new Label(HistoryDepth);
                HistoryDepth.DataField = "HistoryDepth";
                Es = new Selector("ctl00_phG_tab_t10_sp1_repGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t10_sp1_repGrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "replenishment";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ReplenishmentClassIDEdit()
            {
                Buttons.ReplenishmentClassIDEdit.Click();
            }
            
            public virtual void ReplenishmentPolicyIDEdit()
            {
                Buttons.ReplenishmentPolicyIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ReplenishmentClassIDEdit { get; }
			public Button ReplenishmentPolicyIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ReplenishmentClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t10_sp1_repGrid_lv0_edReplenishmentClassID\'] div[class=" +
                            "\'editBtnCont\'] > div > div", "ReplenishmentClassIDEdit", "ctl00_phG_tab_t10_sp1_repGrid_lv0");
                    ReplenishmentClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ReplenishmentPolicyIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t10_sp1_repGrid_lv0_edReplenishmentPolicyID\'] div[class" +
                            "=\'editBtnCont\'] > div > div", "ReplenishmentPolicyIDEdit", "ctl00_phG_tab_t10_sp1_repGrid_lv0");
                    ReplenishmentPolicyIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_subreplenishment_repsubgrid : Grid<c_subreplenishment_repsubgrid.c_grid_row, c_subreplenishment_repsubgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_subreplenishment_repsubgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t10_sp1_repSubGrid");
                DataMemberName = "subreplenishment";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t10_sp1_repSubGrid_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void GenerateSubitems()
            {
                ToolBar.GenerateSubitems.Click();
            }
            
            public virtual void UpdateReplenishment()
            {
                ToolBar.UpdateReplenishment.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public virtual void ReplenishmentClassIDEdit()
            {
                Buttons.ReplenishmentClassIDEdit.Click();
            }
            
            public virtual void ReplenishmentPolicyIDEdit()
            {
                Buttons.ReplenishmentPolicyIDEdit.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid GenerateSubitems { get; }
			public ToolBarButtonGrid UpdateReplenishment { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repSubGrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repSubGrid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repSubGrid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    GenerateSubitems = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repSubGrid_at_tlb div[data-cmd=\'GenerateSubitems\']", "Generate Subitems", locator, null);
                    UpdateReplenishment = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repSubGrid_at_tlb div[data-cmd=\'UpdateReplenishment\']", "Reset to Default", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repSubGrid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repSubGrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repSubGrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repSubGrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repSubGrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repSubGrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repSubGrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t10_sp1_repSubGrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ReplenishmentClassIDEdit { get; }
			public Button ReplenishmentPolicyIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ReplenishmentClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t10_sp1_repGrid_lv0_edReplenishmentClassID\'] div[class=" +
                            "\'editBtnCont\'] > div > div", "ReplenishmentClassIDEdit", "ctl00_phG_tab_t10_sp1_repSubGrid");
                    ReplenishmentClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ReplenishmentPolicyIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t10_sp1_repGrid_lv0_edReplenishmentPolicyID\'] div[class" +
                            "=\'editBtnCont\'] > div > div", "ReplenishmentPolicyIDEdit", "ctl00_phG_tab_t10_sp1_repSubGrid");
                    ReplenishmentPolicyIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector InventoryID { get; }
			public PXTextEdit ReplenishmentClassID { get; }
			public Selector SubItemID { get; }
			public PXNumberEdit SafetyStock { get; }
			public PXNumberEdit MinQty { get; }
			public PXNumberEdit MaxQty { get; }
			public PXNumberEdit TransferERQ { get; }
			public DropDown ItemStatus { get; }
			public Selector CuryID { get; }
                
                public c_grid_row(c_subreplenishment_repsubgrid grid) : 
                        base(grid)
                {
                    InventoryID = new Selector("_ctl00_phG_tab_t10_sp1_repSubGrid_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    ReplenishmentClassID = new PXTextEdit("ctl00_phG_tab_t10_sp1_repSubGrid_em", "Replenishment Class ID", grid.Locator, "ReplenishmentClassID");
                    ReplenishmentClassID.DataField = "ReplenishmentClassID";
                    SubItemID = new Selector("_ctl00_phG_tab_t10_sp1_repSubGrid_lv0_edRPSubItemID", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    SafetyStock = new PXNumberEdit("ctl00_phG_tab_t10_sp1_repSubGrid_en", "Safety Stock", grid.Locator, "SafetyStock");
                    SafetyStock.DataField = "SafetyStock";
                    MinQty = new PXNumberEdit("ctl00_phG_tab_t10_sp1_repSubGrid_en", "Reorder Point", grid.Locator, "MinQty");
                    MinQty.DataField = "MinQty";
                    MaxQty = new PXNumberEdit("ctl00_phG_tab_t10_sp1_repSubGrid_en", "Max Qty.", grid.Locator, "MaxQty");
                    MaxQty.DataField = "MaxQty";
                    TransferERQ = new PXNumberEdit("ctl00_phG_tab_t10_sp1_repSubGrid_en", "Transfer ERQ", grid.Locator, "TransferERQ");
                    TransferERQ.DataField = "TransferERQ";
                    ItemStatus = new DropDown("_ctl00_phG_tab_t10_sp1_repSubGrid_lv0_ec", "Status", grid.Locator, "ItemStatus");
                    ItemStatus.DataField = "ItemStatus";
                    ItemStatus.Items.Add("AC", "Active");
                    ItemStatus.Items.Add("NS", "No Sales");
                    ItemStatus.Items.Add("NP", "No Purchases");
                    ItemStatus.Items.Add("NR", "No Request");
                    ItemStatus.Items.Add("IN", "Inactive");
                    CuryID = new Selector("_ctl00_phG_tab_t10_sp1_repSubGrid_lv0_es", "Currency", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter InventoryID { get; }
				public PXTextEditColumnFilter ReplenishmentClassID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public PXNumberEditColumnFilter SafetyStock { get; }
				public PXNumberEditColumnFilter MinQty { get; }
				public PXNumberEditColumnFilter MaxQty { get; }
				public PXNumberEditColumnFilter TransferERQ { get; }
				public DropDownColumnFilter ItemStatus { get; }
				public SelectorColumnFilter CuryID { get; }
                
                public c_grid_header(c_subreplenishment_repsubgrid grid) : 
                        base(grid)
                {
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    ReplenishmentClassID = new PXTextEditColumnFilter(grid.Row.ReplenishmentClassID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    SafetyStock = new PXNumberEditColumnFilter(grid.Row.SafetyStock);
                    MinQty = new PXNumberEditColumnFilter(grid.Row.MinQty);
                    MaxQty = new PXNumberEditColumnFilter(grid.Row.MaxQty);
                    TransferERQ = new PXNumberEditColumnFilter(grid.Row.TransferERQ);
                    ItemStatus = new DropDownColumnFilter(grid.Row.ItemStatus);
                    CuryID = new SelectorColumnFilter(grid.Row.CuryID);
                }
            }
        }
        
        public class c_subreplenishment_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_subreplenishment_lv0(string locator, string name) : 
                    base(locator, name)
            {
                SubItemID = new Selector("ctl00_phG_tab_t10_sp1_repSubGrid_lv0_edRPSubItemID", "Subitem", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                Es = new Selector("ctl00_phG_tab_t10_sp1_repSubGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t10_sp1_repSubGrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "subreplenishment";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ReplenishmentClassIDEdit()
            {
                Buttons.ReplenishmentClassIDEdit.Click();
            }
            
            public virtual void ReplenishmentPolicyIDEdit()
            {
                Buttons.ReplenishmentPolicyIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ReplenishmentClassIDEdit { get; }
			public Button ReplenishmentPolicyIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ReplenishmentClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t10_sp1_repGrid_lv0_edReplenishmentClassID\'] div[class=" +
                            "\'editBtnCont\'] > div > div", "ReplenishmentClassIDEdit", "ctl00_phG_tab_t10_sp1_repSubGrid_lv0");
                    ReplenishmentClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ReplenishmentPolicyIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t10_sp1_repGrid_lv0_edReplenishmentPolicyID\'] div[class" +
                            "=\'editBtnCont\'] > div > div", "ReplenishmentPolicyIDEdit", "ctl00_phG_tab_t10_sp1_repSubGrid_lv0");
                    ReplenishmentPolicyIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_boxes_pxgridboxes : Grid<c_boxes_pxgridboxes.c_grid_row, c_boxes_pxgridboxes.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_boxes_pxgridboxes(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t7_PXGridBoxes");
                DataMemberName = "Boxes";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PXGridBoxes_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PXGridBoxes_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PXGridBoxes_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_PXGridBoxes_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t7_PXGridBoxes_lfFirst0", "First", "ctl00_phG_tab_t7_PXGridBoxes");
                    Prev = new Button("ctl00_phG_tab_t7_PXGridBoxes_lfPrev0", "Prev", "ctl00_phG_tab_t7_PXGridBoxes");
                    Next = new Button("ctl00_phG_tab_t7_PXGridBoxes_lfNext0", "Next", "ctl00_phG_tab_t7_PXGridBoxes");
                    Last = new Button("ctl00_phG_tab_t7_PXGridBoxes_lfLast0", "Last", "ctl00_phG_tab_t7_PXGridBoxes");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector BoxID { get; }
			public PXTextEdit Description { get; }
			public Selector UOM { get; }
			public PXNumberEdit Qty { get; }
			public PXNumberEdit MaxWeight { get; }
			public PXNumberEdit MaxVolume { get; }
			public PXNumberEdit MaxQty { get; }
			public PXNumberEdit InventoryID { get; }
                
                public c_grid_row(c_boxes_pxgridboxes grid) : 
                        base(grid)
                {
                    BoxID = new Selector("_ctl00_phG_tab_t7_PXGridBoxes_lv0_edBoxID", "Box ID", grid.Locator, "BoxID");
                    BoxID.DataField = "BoxID";
                    Description = new PXTextEdit("ctl00_phG_tab_t7_PXGridBoxes_ei", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                    UOM = new Selector("_ctl00_phG_tab_t7_PXGridBoxes_lv0_edUOM_box", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    Qty = new PXNumberEdit("_ctl00_phG_tab_t7_PXGridBoxes_lv0_edQty_box", "Qty.", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    MaxWeight = new PXNumberEdit("ctl00_phG_tab_t7_PXGridBoxes_en", "Max. Weight", grid.Locator, "MaxWeight");
                    MaxWeight.DataField = "MaxWeight";
                    MaxVolume = new PXNumberEdit("ctl00_phG_tab_t7_PXGridBoxes_en", "Max Volume", grid.Locator, "MaxVolume");
                    MaxVolume.DataField = "MaxVolume";
                    MaxQty = new PXNumberEdit("ctl00_phG_tab_t7_PXGridBoxes_en", "Max. Qty", grid.Locator, "MaxQty");
                    MaxQty.DataField = "MaxQty";
                    InventoryID = new PXNumberEdit("ctl00_phG_tab_t7_PXGridBoxes_en", "InventoryID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter BoxID { get; }
				public PXTextEditColumnFilter Description { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public PXNumberEditColumnFilter MaxWeight { get; }
				public PXNumberEditColumnFilter MaxVolume { get; }
				public PXNumberEditColumnFilter MaxQty { get; }
				public PXNumberEditColumnFilter InventoryID { get; }
                
                public c_grid_header(c_boxes_pxgridboxes grid) : 
                        base(grid)
                {
                    BoxID = new SelectorColumnFilter(grid.Row.BoxID);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    MaxWeight = new PXNumberEditColumnFilter(grid.Row.MaxWeight);
                    MaxVolume = new PXNumberEditColumnFilter(grid.Row.MaxVolume);
                    MaxQty = new PXNumberEditColumnFilter(grid.Row.MaxQty);
                    InventoryID = new PXNumberEditColumnFilter(grid.Row.InventoryID);
                }
            }
        }
        
        public class c_boxes_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector BoxID { get; }
			public Label BoxIDLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public PXNumberEdit Qty { get; }
			public Label QtyLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_boxes_lv0(string locator, string name) : 
                    base(locator, name)
            {
                BoxID = new Selector("ctl00_phG_tab_t7_PXGridBoxes_lv0_edBoxID", "Box ID", locator, null);
                BoxIDLabel = new Label(BoxID);
                BoxID.DataField = "BoxID";
                UOM = new Selector("ctl00_phG_tab_t7_PXGridBoxes_lv0_edUOM_box", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                Qty = new PXNumberEdit("ctl00_phG_tab_t7_PXGridBoxes_lv0_edQty_box", "Qty.", locator, null);
                QtyLabel = new Label(Qty);
                Qty.DataField = "Qty";
                Es = new Selector("ctl00_phG_tab_t7_PXGridBoxes_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t7_PXGridBoxes_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t7_PXGridBoxes_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t7_PXGridBoxes_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Boxes";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t7_PXGridBoxes_lfFirst0", "First", "ctl00_phG_tab_t7_PXGridBoxes_lv0");
                    Prev = new Button("ctl00_phG_tab_t7_PXGridBoxes_lfPrev0", "Prev", "ctl00_phG_tab_t7_PXGridBoxes_lv0");
                    Next = new Button("ctl00_phG_tab_t7_PXGridBoxes_lfNext0", "Next", "ctl00_phG_tab_t7_PXGridBoxes_lv0");
                    Last = new Button("ctl00_phG_tab_t7_PXGridBoxes_lfLast0", "Last", "ctl00_phG_tab_t7_PXGridBoxes_lv0");
                }
            }
        }
        
        public class c_groups_grid3 : Grid<c_groups_grid3.c_grid_row, c_groups_grid3.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_groups_grid3(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t13_grid3");
                DataMemberName = "Groups";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t13_grid3_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void ViewGroupDetails()
            {
                ToolBar.ViewGroupDetails.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid ViewGroupDetails { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grid3_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grid3_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grid3_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    ViewGroupDetails = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grid3_at_tlb div[data-cmd=\'ViewGroupDetails\']", "Group Details", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grid3_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grid3_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grid3_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grid3_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grid3_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grid3_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grid3_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grid3_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Included { get; }
			public Selector GroupName { get; }
			public DropDown SpecificType { get; }
			public PXTextEdit Description { get; }
			public CheckBox Active { get; }
			public DropDown GroupType { get; }
                
                public c_grid_row(c_groups_grid3 grid) : 
                        base(grid)
                {
                    Included = new CheckBox("_ctl00_phG_tab_t13_grid3_lv0_chkSelected", "Included", grid.Locator, "Included");
                    Included.DataField = "Included";
                    GroupName = new Selector("_ctl00_phG_tab_t13_grid3_lv0_edGroupName", "Group Name", grid.Locator, "GroupName");
                    GroupName.DataField = "GroupName";
                    SpecificType = new DropDown("_ctl00_phG_tab_t13_grid3_lv0_ec", "Specific Type", grid.Locator, "SpecificType");
                    SpecificType.DataField = "SpecificType";
                    SpecificType.Items.Add("PX.Objects.CS.SegmentValue", "Subitem");
                    SpecificType.Items.Add("PX.Objects.IN.InventoryItem", "Inventory Item Restriction");
                    Description = new PXTextEdit("_ctl00_phG_tab_t13_grid3_lv0_edDescription", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                    Active = new CheckBox("_ctl00_phG_tab_t13_grid3_lv0_chkActive", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    GroupType = new DropDown("_ctl00_phG_tab_t13_grid3_lv0_edGroupType", "Group Type", grid.Locator, "GroupType");
                    GroupType.DataField = "GroupType";
                    GroupType.Items.Add("IE", "B");
                    GroupType.Items.Add("EE", "B Inverse");
                    GroupType.Items.Add("IO", "A");
                    GroupType.Items.Add("EO", "A Inverse");
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Included { get; }
				public SelectorColumnFilter GroupName { get; }
				public DropDownColumnFilter SpecificType { get; }
				public PXTextEditColumnFilter Description { get; }
				public CheckBoxColumnFilter Active { get; }
				public DropDownColumnFilter GroupType { get; }
                
                public c_grid_header(c_groups_grid3 grid) : 
                        base(grid)
                {
                    Included = new CheckBoxColumnFilter(grid.Row.Included);
                    GroupName = new SelectorColumnFilter(grid.Row.GroupName);
                    SpecificType = new DropDownColumnFilter(grid.Row.SpecificType);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    GroupType = new DropDownColumnFilter(grid.Row.GroupType);
                }
            }
        }
        
        public class c_groups_lv0 : Container
        {
            
			public CheckBox Included { get; }
			public Label IncludedLabel { get; }
			public Selector GroupName { get; }
			public Label GroupNameLabel { get; }
			public PXTextEdit Description { get; }
			public Label DescriptionLabel { get; }
			public CheckBox Active { get; }
			public Label ActiveLabel { get; }
			public DropDown GroupType { get; }
			public Label GroupTypeLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_groups_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Included = new CheckBox("ctl00_phG_tab_t13_grid3_lv0_chkSelected", "Included", locator, null);
                IncludedLabel = new Label(Included);
                Included.DataField = "Included";
                GroupName = new Selector("ctl00_phG_tab_t13_grid3_lv0_edGroupName", "Group Name", locator, null);
                GroupNameLabel = new Label(GroupName);
                GroupName.DataField = "GroupName";
                Description = new PXTextEdit("ctl00_phG_tab_t13_grid3_lv0_edDescription", "Description", locator, null);
                DescriptionLabel = new Label(Description);
                Description.DataField = "Description";
                Active = new CheckBox("ctl00_phG_tab_t13_grid3_lv0_chkActive", "Active", locator, null);
                ActiveLabel = new Label(Active);
                Active.DataField = "Active";
                GroupType = new DropDown("ctl00_phG_tab_t13_grid3_lv0_edGroupType", "Group Type", locator, null);
                GroupTypeLabel = new Label(GroupType);
                GroupType.DataField = "GroupType";
                GroupType.Items.Add("IE", "B");
                GroupType.Items.Add("EE", "B Inverse");
                GroupType.Items.Add("IO", "A");
                GroupType.Items.Add("EO", "A Inverse");
                Es = new Selector("ctl00_phG_tab_t13_grid3_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t13_grid3_lv0_ec", "Ec", locator, null);
                DataMemberName = "Groups";
            }
        }
        
        public class c_relateditems_relateditemsgrid : Grid<c_relateditems_relateditemsgrid.c_grid_row, c_relateditems_relateditemsgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_upload UploadForm { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_relateditems_relateditemsgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t9_relatedItemsGrid");
                DataMemberName = "RelatedItems";
                Buttons = new PxButtonCollection();
                UploadForm = new c_grid_upload("ctl00_phG_tab_t9_relatedItemsGrid_imp_upl_pnl", "UploadForm");
                FilterForm = new c_grid_filter("ctl00_phG_tab_t9_relatedItemsGrid_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Upload()
            {
                ToolBar.Upload.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public virtual void RelatedInventoryIDEdit()
            {
                Buttons.RelatedInventoryIDEdit.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Ok1()
            {
                Buttons.Ok1.Click();
            }
            
            public virtual void Cancel1()
            {
                Buttons.Cancel1.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok2()
            {
                Buttons.Ok2.Click();
            }
            
            public virtual void Cancel2()
            {
                Buttons.Cancel2.Click();
            }
            
            public virtual void Upload1()
            {
                Buttons.Upload1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Upload { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_relatedItemsGrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_relatedItemsGrid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_relatedItemsGrid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_relatedItemsGrid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_relatedItemsGrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Upload = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_relatedItemsGrid_at_tlb div[data-cmd=\'Upload\']", "Load Records from File", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_relatedItemsGrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_relatedItemsGrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_relatedItemsGrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_relatedItemsGrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_relatedItemsGrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t9_relatedItemsGrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button RelatedInventoryIDEdit { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
			public Button Ok1 { get; }
			public Button Cancel1 { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok2 { get; }
			public Button Cancel2 { get; }
			public Button Upload1 { get; }
                
                public PxButtonCollection()
                {
                    RelatedInventoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t9_relatedItemsGrid_lv0_edRelatedInventoryID\'] div[clas" +
                            "s=\'editBtnCont\'] > div > div", "RelatedInventoryIDEdit", "ctl00_phG_tab_t9_relatedItemsGrid");
                    RelatedInventoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    Ok = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t9_relatedItemsGrid");
                    Cancel = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t9_relatedItemsGrid");
                    Ok1 = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t9_relatedItemsGrid");
                    Cancel1 = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t9_relatedItemsGrid");
                    First = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t9_relatedItemsGrid");
                    Prev = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t9_relatedItemsGrid");
                    Next = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t9_relatedItemsGrid");
                    Last = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t9_relatedItemsGrid");
                    Ok2 = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t9_relatedItemsGrid");
                    Cancel2 = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t9_relatedItemsGrid");
                    Upload1 = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t9_relatedItemsGrid");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public DropDown Relation { get; }
			public PXNumberEdit Rank { get; }
			public DropDown Tag { get; }
			public Selector RelatedInventoryID { get; }
			public PXTextEdit Desc { get; }
			public Selector UOM { get; }
			public PXNumberEdit Qty { get; }
			public DateSelector EffectiveDate { get; }
			public DateSelector ExpirationDate { get; }
			public CheckBox Interchangeable { get; }
			public CheckBox Required { get; }
			public CheckBox IsActive { get; }
			public PXNumberEdit InventoryID { get; }
			public PXNumberEdit LineID { get; }
                
                public c_grid_row(c_relateditems_relateditemsgrid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Relation = new DropDown("_ctl00_phG_tab_t9_relatedItemsGrid_lv0_edRelation", "Relation", grid.Locator, "Relation");
                    Relation.DataField = "Relation";
                    Relation.Items.Add("CSELL", "Cross-Sell");
                    Relation.Items.Add("USELL", "Up-Sell");
                    Relation.Items.Add("SUBST", "Substitute");
                    Relation.Items.Add("OTHER", "Other");
                    Rank = new PXNumberEdit("_ctl00_phG_tab_t9_relatedItemsGrid_lv0_edRank", "Rank", grid.Locator, "Rank");
                    Rank.DataField = "Rank";
                    Tag = new DropDown("_ctl00_phG_tab_t9_relatedItemsGrid_lv0_edTag", "Tag", grid.Locator, "Tag");
                    Tag.DataField = "Tag";
                    Tag.Items.Add("COMP", "Complementary Items");
                    Tag.Items.Add("INTS", "Items of Interest");
                    Tag.Items.Add("USER", "Other Users Bought");
                    Tag.Items.Add("ESNT", "Essential Related Products");
                    Tag.Items.Add("SERV", "Services");
                    Tag.Items.Add("PREM", "Premium");
                    Tag.Items.Add("CUST", "Customization");
                    Tag.Items.Add("OPTN", "Options");
                    Tag.Items.Add("PROM", "Promotional");
                    Tag.Items.Add("POPL", "Popular");
                    Tag.Items.Add("SEAS", "Seasonal");
                    Tag.Items.Add("RLTD", "Related");
                    Tag.Items.Add("SUBS", "Substitute");
                    Tag.Items.Add("ALTN", "Alternative");
                    RelatedInventoryID = new Selector("_ctl00_phG_tab_t9_relatedItemsGrid_lv0_edRelatedInventoryID", "Inventory ID", grid.Locator, "RelatedInventoryID");
                    RelatedInventoryID.DataField = "RelatedInventoryID";
                    Desc = new PXTextEdit("_ctl00_phG_tab_t9_relatedItemsGrid_lv0_edRelatedInventoryDesc", "Description", grid.Locator, "Desc");
                    Desc.DataField = "Desc";
                    UOM = new Selector("_ctl00_phG_tab_t9_relatedItemsGrid_lv0_edRelatedInventoryUOM", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    Qty = new PXNumberEdit("_ctl00_phG_tab_t9_relatedItemsGrid_lv0_edRelatedItemQty", "Quantity", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    EffectiveDate = new DateSelector("_ctl00_phG_tab_t9_relatedItemsGrid_lv0_edEffectiveDate", "Effective Date", grid.Locator, "EffectiveDate");
                    EffectiveDate.DataField = "EffectiveDate";
                    ExpirationDate = new DateSelector("_ctl00_phG_tab_t9_relatedItemsGrid_lv0_edExpirationDate", "Expiration Date", grid.Locator, "ExpirationDate");
                    ExpirationDate.DataField = "ExpirationDate";
                    Interchangeable = new CheckBox("_ctl00_phG_tab_t9_relatedItemsGrid_lv0_edInterchangeable", "Customer Approval Not Needed", grid.Locator, "Interchangeable");
                    Interchangeable.DataField = "Interchangeable";
                    Required = new CheckBox("_ctl00_phG_tab_t9_relatedItemsGrid_lv0_edRelatedItemRequired", "Required", grid.Locator, "Required");
                    Required.DataField = "Required";
                    IsActive = new CheckBox("_ctl00_phG_tab_t9_relatedItemsGrid_lv0_edRelatedItemIsActive", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    InventoryID = new PXNumberEdit("ctl00_phG_tab_t9_relatedItemsGrid_en", "InventoryID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    LineID = new PXNumberEdit("ctl00_phG_tab_t9_relatedItemsGrid_en", "LineID", grid.Locator, "LineID");
                    LineID.DataField = "LineID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public DropDownColumnFilter Relation { get; }
				public PXNumberEditColumnFilter Rank { get; }
				public DropDownColumnFilter Tag { get; }
				public SelectorColumnFilter RelatedInventoryID { get; }
				public PXTextEditColumnFilter Desc { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public DateSelectorColumnFilter EffectiveDate { get; }
				public DateSelectorColumnFilter ExpirationDate { get; }
				public CheckBoxColumnFilter Interchangeable { get; }
				public CheckBoxColumnFilter Required { get; }
				public CheckBoxColumnFilter IsActive { get; }
				public PXNumberEditColumnFilter InventoryID { get; }
				public PXNumberEditColumnFilter LineID { get; }
                
                public c_grid_header(c_relateditems_relateditemsgrid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Relation = new DropDownColumnFilter(grid.Row.Relation);
                    Rank = new PXNumberEditColumnFilter(grid.Row.Rank);
                    Tag = new DropDownColumnFilter(grid.Row.Tag);
                    RelatedInventoryID = new SelectorColumnFilter(grid.Row.RelatedInventoryID);
                    Desc = new PXTextEditColumnFilter(grid.Row.Desc);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    EffectiveDate = new DateSelectorColumnFilter(grid.Row.EffectiveDate);
                    ExpirationDate = new DateSelectorColumnFilter(grid.Row.ExpirationDate);
                    Interchangeable = new CheckBoxColumnFilter(grid.Row.Interchangeable);
                    Required = new CheckBoxColumnFilter(grid.Row.Required);
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    InventoryID = new PXNumberEditColumnFilter(grid.Row.InventoryID);
                    LineID = new PXNumberEditColumnFilter(grid.Row.LineID);
                }
            }
        }
        
        public class c_relateditems_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown Relation { get; }
			public Label RelationLabel { get; }
			public PXNumberEdit Rank { get; }
			public Label RankLabel { get; }
			public DropDown Tag { get; }
			public Label TagLabel { get; }
			public Selector RelatedInventoryID { get; }
			public Label RelatedInventoryIDLabel { get; }
			public PXTextEdit Desc { get; }
			public Label DescLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public PXNumberEdit Qty { get; }
			public Label QtyLabel { get; }
			public DateSelector EffectiveDate { get; }
			public Label EffectiveDateLabel { get; }
			public DateSelector ExpirationDate { get; }
			public Label ExpirationDateLabel { get; }
			public CheckBox Interchangeable { get; }
			public Label InterchangeableLabel { get; }
			public CheckBox Required { get; }
			public Label RequiredLabel { get; }
			public CheckBox IsActive { get; }
			public Label IsActiveLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_relateditems_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Relation = new DropDown("ctl00_phG_tab_t9_relatedItemsGrid_lv0_edRelation", "Relation", locator, null);
                RelationLabel = new Label(Relation);
                Relation.DataField = "Relation";
                Relation.Items.Add("CSELL", "Cross-Sell");
                Relation.Items.Add("USELL", "Up-Sell");
                Relation.Items.Add("SUBST", "Substitute");
                Relation.Items.Add("OTHER", "Other");
                Rank = new PXNumberEdit("ctl00_phG_tab_t9_relatedItemsGrid_lv0_edRank", "Rank", locator, null);
                RankLabel = new Label(Rank);
                Rank.DataField = "Rank";
                Tag = new DropDown("ctl00_phG_tab_t9_relatedItemsGrid_lv0_edTag", "Tag", locator, null);
                TagLabel = new Label(Tag);
                Tag.DataField = "Tag";
                Tag.Items.Add("COMP", "Complementary Items");
                Tag.Items.Add("INTS", "Items of Interest");
                Tag.Items.Add("USER", "Other Users Bought");
                Tag.Items.Add("ESNT", "Essential Related Products");
                Tag.Items.Add("SERV", "Services");
                Tag.Items.Add("PREM", "Premium");
                Tag.Items.Add("CUST", "Customization");
                Tag.Items.Add("OPTN", "Options");
                Tag.Items.Add("PROM", "Promotional");
                Tag.Items.Add("POPL", "Popular");
                Tag.Items.Add("SEAS", "Seasonal");
                Tag.Items.Add("RLTD", "Related");
                Tag.Items.Add("SUBS", "Substitute");
                Tag.Items.Add("ALTN", "Alternative");
                RelatedInventoryID = new Selector("ctl00_phG_tab_t9_relatedItemsGrid_lv0_edRelatedInventoryID", "Inventory ID", locator, null);
                RelatedInventoryIDLabel = new Label(RelatedInventoryID);
                RelatedInventoryID.DataField = "RelatedInventoryID";
                Desc = new PXTextEdit("ctl00_phG_tab_t9_relatedItemsGrid_lv0_edRelatedInventoryDesc", "Description", locator, null);
                DescLabel = new Label(Desc);
                Desc.DataField = "Desc";
                UOM = new Selector("ctl00_phG_tab_t9_relatedItemsGrid_lv0_edRelatedInventoryUOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                Qty = new PXNumberEdit("ctl00_phG_tab_t9_relatedItemsGrid_lv0_edRelatedItemQty", "Quantity", locator, null);
                QtyLabel = new Label(Qty);
                Qty.DataField = "Qty";
                EffectiveDate = new DateSelector("ctl00_phG_tab_t9_relatedItemsGrid_lv0_edEffectiveDate", "Effective Date", locator, null);
                EffectiveDateLabel = new Label(EffectiveDate);
                EffectiveDate.DataField = "EffectiveDate";
                ExpirationDate = new DateSelector("ctl00_phG_tab_t9_relatedItemsGrid_lv0_edExpirationDate", "Expiration Date", locator, null);
                ExpirationDateLabel = new Label(ExpirationDate);
                ExpirationDate.DataField = "ExpirationDate";
                Interchangeable = new CheckBox("ctl00_phG_tab_t9_relatedItemsGrid_lv0_edInterchangeable", "Customer Approval Not Needed", locator, null);
                InterchangeableLabel = new Label(Interchangeable);
                Interchangeable.DataField = "Interchangeable";
                Required = new CheckBox("ctl00_phG_tab_t9_relatedItemsGrid_lv0_edRelatedItemRequired", "Required", locator, null);
                RequiredLabel = new Label(Required);
                Required.DataField = "Required";
                IsActive = new CheckBox("ctl00_phG_tab_t9_relatedItemsGrid_lv0_edRelatedItemIsActive", "Active", locator, null);
                IsActiveLabel = new Label(IsActive);
                IsActive.DataField = "IsActive";
                Es = new Selector("ctl00_phG_tab_t9_relatedItemsGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "RelatedItems";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void RelatedInventoryIDEdit()
            {
                Buttons.RelatedInventoryIDEdit.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Ok1()
            {
                Buttons.Ok1.Click();
            }
            
            public virtual void Cancel1()
            {
                Buttons.Cancel1.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok2()
            {
                Buttons.Ok2.Click();
            }
            
            public virtual void Cancel2()
            {
                Buttons.Cancel2.Click();
            }
            
            public virtual void Upload()
            {
                Buttons.Upload.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button RelatedInventoryIDEdit { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
			public Button Ok1 { get; }
			public Button Cancel1 { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok2 { get; }
			public Button Cancel2 { get; }
			public Button Upload { get; }
                
                public PxButtonCollection()
                {
                    RelatedInventoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t9_relatedItemsGrid_lv0_edRelatedInventoryID\'] div[clas" +
                            "s=\'editBtnCont\'] > div > div", "RelatedInventoryIDEdit", "ctl00_phG_tab_t9_relatedItemsGrid_lv0");
                    RelatedInventoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    Ok = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t9_relatedItemsGrid_lv0");
                    Cancel = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t9_relatedItemsGrid_lv0");
                    Ok1 = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t9_relatedItemsGrid_lv0");
                    Cancel1 = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t9_relatedItemsGrid_lv0");
                    First = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t9_relatedItemsGrid_lv0");
                    Prev = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t9_relatedItemsGrid_lv0");
                    Next = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t9_relatedItemsGrid_lv0");
                    Last = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t9_relatedItemsGrid_lv0");
                    Ok2 = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t9_relatedItemsGrid_lv0");
                    Cancel2 = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t9_relatedItemsGrid_lv0");
                    Upload = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_upl_pnl_btnUpload", "Upload", "ctl00_phG_tab_t9_relatedItemsGrid_lv0");
                }
            }
        }
        
        public class c_vendorinventory_updateprice_formeffectivedate : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector PendingDate { get; }
			public Label PendingDateLabel { get; }
            
            public c_vendorinventory_updateprice_formeffectivedate(string locator, string name) : 
                    base(locator, name)
            {
                PendingDate = new DateSelector("ctl00_phG_pnlUpdatePrice_formEffectiveDate_edPendingDate", "Max. Pending Date", locator, null);
                PendingDateLabel = new Label(PendingDate);
                PendingDate.DataField = "PendingDate";
                DataMemberName = "VendorInventory$UpdatePrice";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Update()
            {
                Buttons.Update.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Update { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Update = new Button("ctl00_phG_pnlUpdatePrice_PXButton3", "Update", "ctl00_phG_pnlUpdatePrice_formEffectiveDate");
                    Cancel = new Button("ctl00_phG_pnlUpdatePrice_PXButton4", "Cancel", "ctl00_phG_pnlUpdatePrice_formEffectiveDate");
                }
            }
        }
        
        public class c_changeiddialog_formchangeid : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector CD { get; }
			public Label CDLabel { get; }
            
            public c_changeiddialog_formchangeid(string locator, string name) : 
                    base(locator, name)
            {
                CD = new Selector("ctl00_phF_pnlChangeID_formChangeID_edAcctCD", "Inventory ID", locator, null);
                CDLabel = new Label(CD);
                CD.DataField = "CD";
                DataMemberName = "ChangeIDDialog";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phF_pnlChangeID_btnOK", "OK", "ctl00_phF_pnlChangeID_formChangeID");
                    Cancel = new Button("ctl00_phF_pnlChangeID_btnCancel", "Cancel", "ctl00_phF_pnlChangeID_formChangeID");
                }
            }
        }
        
        public class c_rutrotitemsettings_formrutrotitemsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public GroupBox RUTROTType { get; }
			public Label RUTROTTypeLabel { get; }
			public DropDown RUTROTItemType { get; }
			public Label RUTROTItemTypeLabel { get; }
			public Selector RUTROTWorkTypeID { get; }
			public Label RUTROTWorkTypeIDLabel { get; }
            
            public c_rutrotitemsettings_formrutrotitemsettings(string locator, string name) : 
                    base(locator, name)
            {
                RUTROTType = new GroupBox("ctl00_phG_tab_t2_formRUTROTItemSettings_gbRRType", "RUTROT Type", locator, null);
                RUTROTTypeLabel = new Label(RUTROTType);
                RUTROTType.DataField = "RUTROTType";
                RUTROTItemType = new DropDown("ctl00_phG_tab_t2_formRUTROTItemSettings_cmbRUTROTItemType", "Type", locator, null);
                RUTROTItemTypeLabel = new Label(RUTROTItemType);
                RUTROTItemType.DataField = "RUTROTItemType";
                RUTROTWorkTypeID = new Selector("ctl00_phG_tab_t2_formRUTROTItemSettings_cmbRUTROTWorkType", "Type of Work", locator, null);
                RUTROTWorkTypeIDLabel = new Label(RUTROTWorkTypeID);
                RUTROTWorkTypeID.DataField = "RUTROTWorkTypeID";
                DataMemberName = "RUTROTItemSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void PriceClassIDEdit()
            {
                Buttons.PriceClassIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button PriceClassIDEdit { get; }
                
                public PxButtonCollection()
                {
                    PriceClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_edPriceClassID\'] div[class=\'editBtnCont\'] > div > di" +
                            "v", "PriceClassIDEdit", "ctl00_phG_tab_t2_formRUTROTItemSettings");
                    PriceClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_inventoryfileurls_gridinventoryfileurls : Grid<c_inventoryfileurls_gridinventoryfileurls.c_grid_row, c_inventoryfileurls_gridinventoryfileurls.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_inventoryfileurls_gridinventoryfileurls(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t17_gridInventoryFileUrls");
                DataMemberName = "InventoryFileUrls";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t17_gridInventoryFileUrls_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t17_gridInventoryFileUrls_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t17_gridInventoryFileUrls_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t17_gridInventoryFileUrls_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t17_gridInventoryFileUrls_lfFirst0", "First", "ctl00_phG_tab_t17_gridInventoryFileUrls");
                    Prev = new Button("ctl00_phG_tab_t17_gridInventoryFileUrls_lfPrev0", "Prev", "ctl00_phG_tab_t17_gridInventoryFileUrls");
                    Next = new Button("ctl00_phG_tab_t17_gridInventoryFileUrls_lfNext0", "Next", "ctl00_phG_tab_t17_gridInventoryFileUrls");
                    Last = new Button("ctl00_phG_tab_t17_gridInventoryFileUrls_lfLast0", "Last", "ctl00_phG_tab_t17_gridInventoryFileUrls");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit FileURL { get; }
			public PXTextEdit FileType { get; }
                
                public c_grid_row(c_inventoryfileurls_gridinventoryfileurls grid) : 
                        base(grid)
                {
                    FileURL = new PXTextEdit("ctl00_phG_tab_t17_gridInventoryFileUrls_ei", "File URL", grid.Locator, "FileURL");
                    FileURL.DataField = "FileURL";
                    FileType = new PXTextEdit("ctl00_phG_tab_t17_gridInventoryFileUrls_ei", "File Type", grid.Locator, "FileType");
                    FileType.DataField = "FileType";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter FileURL { get; }
				public PXTextEditColumnFilter FileType { get; }
                
                public c_grid_header(c_inventoryfileurls_gridinventoryfileurls grid) : 
                        base(grid)
                {
                    FileURL = new PXTextEditColumnFilter(grid.Row.FileURL);
                    FileType = new PXTextEditColumnFilter(grid.Row.FileType);
                }
            }
        }
        
        public class c_inventoryfileurls_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_inventoryfileurls_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_tab_t17_gridInventoryFileUrls_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t17_gridInventoryFileUrls_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t17_gridInventoryFileUrls_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t17_gridInventoryFileUrls_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "InventoryFileUrls";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t17_gridInventoryFileUrls_lfFirst0", "First", "ctl00_phG_tab_t17_gridInventoryFileUrls_lv0");
                    Prev = new Button("ctl00_phG_tab_t17_gridInventoryFileUrls_lfPrev0", "Prev", "ctl00_phG_tab_t17_gridInventoryFileUrls_lv0");
                    Next = new Button("ctl00_phG_tab_t17_gridInventoryFileUrls_lfNext0", "Next", "ctl00_phG_tab_t17_gridInventoryFileUrls_lv0");
                    Last = new Button("ctl00_phG_tab_t17_gridInventoryFileUrls_lfLast0", "Last", "ctl00_phG_tab_t17_gridInventoryFileUrls_lv0");
                }
            }
        }
        
        public class c_amsubitemdefaults_amgridamsubitemdefault : Grid<c_amsubitemdefaults_amgridamsubitemdefault.c_grid_row, c_amsubitemdefaults_amgridamsubitemdefault.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_amsubitemdefaults_amgridamsubitemdefault(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "AMSubItemDefaults";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Unnamed()
            {
                Buttons.Unnamed.Click();
            }
            
            public virtual void Unnamed1()
            {
                Buttons.Unnamed1.Click();
            }
            
            public virtual void AMConfigurationIDEdit()
            {
                Buttons.AMConfigurationIDEdit.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Unnamed { get; }
			public Button Unnamed1 { get; }
			public Button AMConfigurationIDEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    Unnamed = new Button("ctl00_phG_tab_t3_btnViewBOM", "", "ctl00_phG_tab_t3_AMGridAMSubItemDefault");
                    Unnamed1 = new Button("ctl00_phG_tab_t3_btnViewPlanningBOM", "", "ctl00_phG_tab_t3_AMGridAMSubItemDefault");
                    AMConfigurationIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_edAMConfigurationID\'] div[class=\'editBtnCont\'] > div" +
                            " > div", "AMConfigurationIDEdit", "ctl00_phG_tab_t3_AMGridAMSubItemDefault");
                    AMConfigurationIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    First = new Button("ctl00_phG_tab_t3_AMGridAMSubItemDefault_lfFirst0", "First", "ctl00_phG_tab_t3_AMGridAMSubItemDefault");
                    Prev = new Button("ctl00_phG_tab_t3_AMGridAMSubItemDefault_lfPrev0", "Prev", "ctl00_phG_tab_t3_AMGridAMSubItemDefault");
                    Next = new Button("ctl00_phG_tab_t3_AMGridAMSubItemDefault_lfNext0", "Next", "ctl00_phG_tab_t3_AMGridAMSubItemDefault");
                    Last = new Button("ctl00_phG_tab_t3_AMGridAMSubItemDefault_lfLast0", "Last", "ctl00_phG_tab_t3_AMGridAMSubItemDefault");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector SiteID { get; }
			public Selector SubItemID { get; }
			public CheckBox IsItemDefault { get; }
			public Selector BOMID { get; }
			public Selector PlanningBOMID { get; }
                
                public c_grid_row(c_amsubitemdefaults_amgridamsubitemdefault grid) : 
                        base(grid)
                {
                    SiteID = new Selector("_ctl00_phG_tab_t3_AMGridAMSubItemDefault_lv0_edSubItemAMSiteID", "Site ID", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    SubItemID = new Selector("_ctl00_phG_tab_t3_AMGridAMSubItemDefault_lv0_edSubItemAMSubItemID", "Sub Item ID", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    IsItemDefault = new CheckBox("_ctl00_phG_tab_t3_AMGridAMSubItemDefault_lv0_edSubItemAMIsItemDefault", "Is Item Default", grid.Locator, "IsItemDefault");
                    IsItemDefault.DataField = "IsItemDefault";
                    BOMID = new Selector("_ctl00_phG_tab_t3_AMGridAMSubItemDefault_lv0_edSubItemAMBOMID", "BOMID", grid.Locator, "BOMID");
                    BOMID.DataField = "BOMID";
                    PlanningBOMID = new Selector("_ctl00_phG_tab_t3_AMGridAMSubItemDefault_lv0_edSubItemAMPlanningBOMID", "Planning BOMID", grid.Locator, "PlanningBOMID");
                    PlanningBOMID.DataField = "PlanningBOMID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter SiteID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public CheckBoxColumnFilter IsItemDefault { get; }
				public SelectorColumnFilter BOMID { get; }
				public SelectorColumnFilter PlanningBOMID { get; }
                
                public c_grid_header(c_amsubitemdefaults_amgridamsubitemdefault grid) : 
                        base(grid)
                {
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    IsItemDefault = new CheckBoxColumnFilter(grid.Row.IsItemDefault);
                    BOMID = new SelectorColumnFilter(grid.Row.BOMID);
                    PlanningBOMID = new SelectorColumnFilter(grid.Row.PlanningBOMID);
                }
            }
        }
        
        public class c_amsubitemdefaults_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public CheckBox IsItemDefault { get; }
			public Label IsItemDefaultLabel { get; }
			public Selector BOMID { get; }
			public Label BOMIDLabel { get; }
			public Selector PlanningBOMID { get; }
			public Label PlanningBOMIDLabel { get; }
            
            public c_amsubitemdefaults_lv0(string locator, string name) : 
                    base(locator, name)
            {
                SubItemID = new Selector("ctl00_phG_tab_t3_AMGridAMSubItemDefault_lv0_edSubItemAMSubItemID", "Sub Item ID", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                SiteID = new Selector("ctl00_phG_tab_t3_AMGridAMSubItemDefault_lv0_edSubItemAMSiteID", "Site ID", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                IsItemDefault = new CheckBox("ctl00_phG_tab_t3_AMGridAMSubItemDefault_lv0_edSubItemAMIsItemDefault", "Is Item Default", locator, null);
                IsItemDefaultLabel = new Label(IsItemDefault);
                IsItemDefault.DataField = "IsItemDefault";
                BOMID = new Selector("ctl00_phG_tab_t3_AMGridAMSubItemDefault_lv0_edSubItemAMBOMID", "BOMID", locator, null);
                BOMIDLabel = new Label(BOMID);
                BOMID.DataField = "BOMID";
                PlanningBOMID = new Selector("ctl00_phG_tab_t3_AMGridAMSubItemDefault_lv0_edSubItemAMPlanningBOMID", "Planning BOMID", locator, null);
                PlanningBOMIDLabel = new Label(PlanningBOMID);
                PlanningBOMID.DataField = "PlanningBOMID";
                DataMemberName = "AMSubItemDefaults";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Unnamed()
            {
                Buttons.Unnamed.Click();
            }
            
            public virtual void Unnamed1()
            {
                Buttons.Unnamed1.Click();
            }
            
            public virtual void AMConfigurationIDEdit()
            {
                Buttons.AMConfigurationIDEdit.Click();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Unnamed { get; }
			public Button Unnamed1 { get; }
			public Button AMConfigurationIDEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    Unnamed = new Button("ctl00_phG_tab_t3_btnViewBOM", "", "ctl00_phG_tab_t3_AMGridAMSubItemDefault_lv0");
                    Unnamed1 = new Button("ctl00_phG_tab_t3_btnViewPlanningBOM", "", "ctl00_phG_tab_t3_AMGridAMSubItemDefault_lv0");
                    AMConfigurationIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_edAMConfigurationID\'] div[class=\'editBtnCont\'] > div" +
                            " > div", "AMConfigurationIDEdit", "ctl00_phG_tab_t3_AMGridAMSubItemDefault_lv0");
                    AMConfigurationIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    First = new Button("ctl00_phG_tab_t3_AMGridAMSubItemDefault_lfFirst0", "First", "ctl00_phG_tab_t3_AMGridAMSubItemDefault_lv0");
                    Prev = new Button("ctl00_phG_tab_t3_AMGridAMSubItemDefault_lfPrev0", "Prev", "ctl00_phG_tab_t3_AMGridAMSubItemDefault_lv0");
                    Next = new Button("ctl00_phG_tab_t3_AMGridAMSubItemDefault_lfNext0", "Next", "ctl00_phG_tab_t3_AMGridAMSubItemDefault_lv0");
                    Last = new Button("ctl00_phG_tab_t3_AMGridAMSubItemDefault_lfLast0", "Last", "ctl00_phG_tab_t3_AMGridAMSubItemDefault_lv0");
                }
            }
        }
        
        public class c_modelcomponents_gridcomponents : Grid<c_modelcomponents_gridcomponents.c_grid_row, c_modelcomponents_gridcomponents.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_modelcomponents_gridcomponents(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t15_gridComponents");
                DataMemberName = "ModelComponents";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t15_gridComponents_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public virtual void ManufacturerIDEdit()
            {
                Buttons.ManufacturerIDEdit.Click();
            }
            
            public virtual void ManufacturerModelIDEdit()
            {
                Buttons.ManufacturerModelIDEdit.Click();
            }
            
            public virtual void EquipmentTypeIDEdit()
            {
                Buttons.EquipmentTypeIDEdit.Click();
            }
            
            public virtual void ClassIDEdit()
            {
                Buttons.ClassIDEdit.Click();
            }
            
            public virtual void InventoryIDEdit()
            {
                Buttons.InventoryIDEdit.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t15_gridComponents_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t15_gridComponents_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t15_gridComponents_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t15_gridComponents_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t15_gridComponents_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t15_gridComponents_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t15_gridComponents_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t15_gridComponents_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t15_gridComponents_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t15_gridComponents_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t15_gridComponents_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ManufacturerIDEdit { get; }
			public Button ManufacturerModelIDEdit { get; }
			public Button EquipmentTypeIDEdit { get; }
			public Button ClassIDEdit { get; }
			public Button InventoryIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ManufacturerIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t15_formSM_edManufacturerID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "ManufacturerIDEdit", "ctl00_phG_tab_t15_gridComponents");
                    ManufacturerIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ManufacturerModelIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t15_formSM_edManufacturerModelID\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "ManufacturerModelIDEdit", "ctl00_phG_tab_t15_gridComponents");
                    ManufacturerModelIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    EquipmentTypeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t15_formSM_edEquipmentTypeID\'] div[class=\'editBtnCont\']" +
                            " > div > div", "EquipmentTypeIDEdit", "ctl00_phG_tab_t15_gridComponents");
                    EquipmentTypeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t15_gridComponents_lv0_edEQClassID\'] div[class=\'editBtn" +
                            "Cont\'] > div > div", "ClassIDEdit", "ctl00_phG_tab_t15_gridComponents");
                    ClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    InventoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t15_gridComponents_lv0_edEQInventoryID\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "InventoryIDEdit", "ctl00_phG_tab_t15_gridComponents");
                    InventoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector ComponentID { get; }
			public CheckBox Active { get; }
			public CheckBox Optional { get; }
			public PXNumberEdit Qty { get; }
			public InputLocalizable Descr { get; }
			public Selector ClassID { get; }
			public Selector InventoryID { get; }
			public CheckBox RequireSerial { get; }
			public PXNumberEdit CpnyWarrantyValue { get; }
			public DropDown CpnyWarrantyType { get; }
			public PXNumberEdit VendorWarrantyValue { get; }
			public DropDown VendorWarrantyType { get; }
			public Selector VendorID { get; }
                
                public c_grid_row(c_modelcomponents_gridcomponents grid) : 
                        base(grid)
                {
                    ComponentID = new Selector("_ctl00_phG_tab_t15_gridComponents_lv0_edEQComponentID", "Component ID", grid.Locator, "ComponentID");
                    ComponentID.DataField = "ComponentID";
                    Active = new CheckBox("_ctl00_phG_tab_t15_gridComponents_lv0_edEQActive", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    Optional = new CheckBox("_ctl00_phG_tab_t15_gridComponents_lv0_edEQOptional", "Optional", grid.Locator, "Optional");
                    Optional.DataField = "Optional";
                    Qty = new PXNumberEdit("_ctl00_phG_tab_t15_gridComponents_lv0_edEQQty", "Qty", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    Descr = new InputLocalizable("_ctl00_phG_tab_t15_gridComponents_lv0_edEQDescr", "Descr", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    ClassID = new Selector("_ctl00_phG_tab_t15_gridComponents_lv0_edEQClassID", "Class ID", grid.Locator, "ClassID");
                    ClassID.DataField = "ClassID";
                    InventoryID = new Selector("_ctl00_phG_tab_t15_gridComponents_lv0_edEQInventoryID", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    RequireSerial = new CheckBox("_ctl00_phG_tab_t15_gridComponents_lv0_edEQRequireSerial", "Require Serial", grid.Locator, "RequireSerial");
                    RequireSerial.DataField = "RequireSerial";
                    CpnyWarrantyValue = new PXNumberEdit("_ctl00_phG_tab_t15_gridComponents_lv0_edEQCpnyWarrantyValue", "Cpny Warranty Value", grid.Locator, "CpnyWarrantyValue");
                    CpnyWarrantyValue.DataField = "CpnyWarrantyValue";
                    CpnyWarrantyType = new DropDown("_ctl00_phG_tab_t15_gridComponents_lv0_edEQCpnyWarrantyType", "Cpny Warranty Type", grid.Locator, "CpnyWarrantyType");
                    CpnyWarrantyType.DataField = "CpnyWarrantyType";
                    VendorWarrantyValue = new PXNumberEdit("_ctl00_phG_tab_t15_gridComponents_lv0_edEQVendorWarrantyValue", "Vendor Warranty Value", grid.Locator, "VendorWarrantyValue");
                    VendorWarrantyValue.DataField = "VendorWarrantyValue";
                    VendorWarrantyType = new DropDown("_ctl00_phG_tab_t15_gridComponents_lv0_edEQVendorWarrantyType", "Vendor Warranty Type", grid.Locator, "VendorWarrantyType");
                    VendorWarrantyType.DataField = "VendorWarrantyType";
                    VendorID = new Selector("_ctl00_phG_tab_t15_gridComponents_lv0_edEQVendorID", "Vendor ID", grid.Locator, "VendorID");
                    VendorID.DataField = "VendorID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter ComponentID { get; }
				public CheckBoxColumnFilter Active { get; }
				public CheckBoxColumnFilter Optional { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public PXTextEditColumnFilter Descr { get; }
				public SelectorColumnFilter ClassID { get; }
				public SelectorColumnFilter InventoryID { get; }
				public CheckBoxColumnFilter RequireSerial { get; }
				public PXNumberEditColumnFilter CpnyWarrantyValue { get; }
				public DropDownColumnFilter CpnyWarrantyType { get; }
				public PXNumberEditColumnFilter VendorWarrantyValue { get; }
				public DropDownColumnFilter VendorWarrantyType { get; }
				public SelectorColumnFilter VendorID { get; }
                
                public c_grid_header(c_modelcomponents_gridcomponents grid) : 
                        base(grid)
                {
                    ComponentID = new SelectorColumnFilter(grid.Row.ComponentID);
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    Optional = new CheckBoxColumnFilter(grid.Row.Optional);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    ClassID = new SelectorColumnFilter(grid.Row.ClassID);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    RequireSerial = new CheckBoxColumnFilter(grid.Row.RequireSerial);
                    CpnyWarrantyValue = new PXNumberEditColumnFilter(grid.Row.CpnyWarrantyValue);
                    CpnyWarrantyType = new DropDownColumnFilter(grid.Row.CpnyWarrantyType);
                    VendorWarrantyValue = new PXNumberEditColumnFilter(grid.Row.VendorWarrantyValue);
                    VendorWarrantyType = new DropDownColumnFilter(grid.Row.VendorWarrantyType);
                    VendorID = new SelectorColumnFilter(grid.Row.VendorID);
                }
            }
        }
        
        public class c_modelcomponents_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector ComponentID { get; }
			public Label ComponentIDLabel { get; }
			public CheckBox Active { get; }
			public Label ActiveLabel { get; }
			public CheckBox Optional { get; }
			public Label OptionalLabel { get; }
			public PXNumberEdit Qty { get; }
			public Label QtyLabel { get; }
			public InputLocalizable Descr { get; }
			public Label DescrLabel { get; }
			public Selector ClassID { get; }
			public Label ClassIDLabel { get; }
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public CheckBox RequireSerial { get; }
			public Label RequireSerialLabel { get; }
			public PXNumberEdit CpnyWarrantyValue { get; }
			public Label CpnyWarrantyValueLabel { get; }
			public DropDown CpnyWarrantyType { get; }
			public Label CpnyWarrantyTypeLabel { get; }
			public PXNumberEdit VendorWarrantyValue { get; }
			public Label VendorWarrantyValueLabel { get; }
			public DropDown VendorWarrantyType { get; }
			public Label VendorWarrantyTypeLabel { get; }
			public Selector VendorID { get; }
			public Label VendorIDLabel { get; }
            
            public c_modelcomponents_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ComponentID = new Selector("ctl00_phG_tab_t15_gridComponents_lv0_edEQComponentID", "Component ID", locator, null);
                ComponentIDLabel = new Label(ComponentID);
                ComponentID.DataField = "ComponentID";
                Active = new CheckBox("ctl00_phG_tab_t15_gridComponents_lv0_edEQActive", "Active", locator, null);
                ActiveLabel = new Label(Active);
                Active.DataField = "Active";
                Optional = new CheckBox("ctl00_phG_tab_t15_gridComponents_lv0_edEQOptional", "Optional", locator, null);
                OptionalLabel = new Label(Optional);
                Optional.DataField = "Optional";
                Qty = new PXNumberEdit("ctl00_phG_tab_t15_gridComponents_lv0_edEQQty", "Qty", locator, null);
                QtyLabel = new Label(Qty);
                Qty.DataField = "Qty";
                Descr = new InputLocalizable("ctl00_phG_tab_t15_gridComponents_lv0_edEQDescr", "Descr", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                ClassID = new Selector("ctl00_phG_tab_t15_gridComponents_lv0_edEQClassID", "Class ID", locator, null);
                ClassIDLabel = new Label(ClassID);
                ClassID.DataField = "ClassID";
                InventoryID = new Selector("ctl00_phG_tab_t15_gridComponents_lv0_edEQInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                RequireSerial = new CheckBox("ctl00_phG_tab_t15_gridComponents_lv0_edEQRequireSerial", "Require Serial", locator, null);
                RequireSerialLabel = new Label(RequireSerial);
                RequireSerial.DataField = "RequireSerial";
                CpnyWarrantyValue = new PXNumberEdit("ctl00_phG_tab_t15_gridComponents_lv0_edEQCpnyWarrantyValue", "Cpny Warranty Value", locator, null);
                CpnyWarrantyValueLabel = new Label(CpnyWarrantyValue);
                CpnyWarrantyValue.DataField = "CpnyWarrantyValue";
                CpnyWarrantyType = new DropDown("ctl00_phG_tab_t15_gridComponents_lv0_edEQCpnyWarrantyType", "Cpny Warranty Type", locator, null);
                CpnyWarrantyTypeLabel = new Label(CpnyWarrantyType);
                CpnyWarrantyType.DataField = "CpnyWarrantyType";
                VendorWarrantyValue = new PXNumberEdit("ctl00_phG_tab_t15_gridComponents_lv0_edEQVendorWarrantyValue", "Vendor Warranty Value", locator, null);
                VendorWarrantyValueLabel = new Label(VendorWarrantyValue);
                VendorWarrantyValue.DataField = "VendorWarrantyValue";
                VendorWarrantyType = new DropDown("ctl00_phG_tab_t15_gridComponents_lv0_edEQVendorWarrantyType", "Vendor Warranty Type", locator, null);
                VendorWarrantyTypeLabel = new Label(VendorWarrantyType);
                VendorWarrantyType.DataField = "VendorWarrantyType";
                VendorID = new Selector("ctl00_phG_tab_t15_gridComponents_lv0_edEQVendorID", "Vendor ID", locator, null);
                VendorIDLabel = new Label(VendorID);
                VendorID.DataField = "VendorID";
                DataMemberName = "ModelComponents";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ClassIDEdit()
            {
                Buttons.ClassIDEdit.Click();
            }
            
            public virtual void InventoryIDEdit()
            {
                Buttons.InventoryIDEdit.Click();
            }
            
            public virtual void ManufacturerIDEdit()
            {
                Buttons.ManufacturerIDEdit.Click();
            }
            
            public virtual void ManufacturerModelIDEdit()
            {
                Buttons.ManufacturerModelIDEdit.Click();
            }
            
            public virtual void EquipmentTypeIDEdit()
            {
                Buttons.EquipmentTypeIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ClassIDEdit { get; }
			public Button InventoryIDEdit { get; }
			public Button ManufacturerIDEdit { get; }
			public Button ManufacturerModelIDEdit { get; }
			public Button EquipmentTypeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ClassIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t15_gridComponents_lv0_edEQClassID\'] div[class=\'editBtn" +
                            "Cont\'] > div > div", "ClassIDEdit", "ctl00_phG_tab_t15_gridComponents_lv0");
                    ClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    InventoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t15_gridComponents_lv0_edEQInventoryID\'] div[class=\'edi" +
                            "tBtnCont\'] > div > div", "InventoryIDEdit", "ctl00_phG_tab_t15_gridComponents_lv0");
                    InventoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ManufacturerIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t15_formSM_edManufacturerID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "ManufacturerIDEdit", "ctl00_phG_tab_t15_gridComponents_lv0");
                    ManufacturerIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ManufacturerModelIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t15_formSM_edManufacturerModelID\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "ManufacturerModelIDEdit", "ctl00_phG_tab_t15_gridComponents_lv0");
                    ManufacturerModelIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    EquipmentTypeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t15_formSM_edEquipmentTypeID\'] div[class=\'editBtnCont\']" +
                            " > div > div", "EquipmentTypeIDEdit", "ctl00_phG_tab_t15_gridComponents_lv0");
                    EquipmentTypeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_syncrecs_syncgrid : Grid<c_syncrecs_syncgrid.c_grid_row, c_syncrecs_syncgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_syncrecs_syncgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t16_syncGrid");
                DataMemberName = "SyncRecs";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t16_syncGrid_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void SyncSalesforce()
            {
                ToolBar.SyncSalesforce.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid SyncSalesforce { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t16_syncGrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    SyncSalesforce = new ToolBarButtonGrid("css=#ctl00_phG_tab_t16_syncGrid_at_tlb div[data-cmd=\'SyncSalesforce\']", "SyncSalesforce", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t16_syncGrid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t16_syncGrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t16_syncGrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t16_syncGrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t16_syncGrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t16_syncGrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t16_syncGrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t16_syncGrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit SYProvider__Name { get; }
			public PXTextEdit RemoteID { get; }
			public PXTextEdit Status { get; }
			public PXTextEdit Operation { get; }
			public PXTextEdit LastErrorMessage { get; }
			public PXTextEdit LastAttemptTS { get; }
			public PXTextEdit AttemptCount { get; }
			public PXTextEdit SFEntitySetup__ImportScenario { get; }
			public PXTextEdit SFEntitySetup__ExportScenario { get; }
                
                public c_grid_row(c_syncrecs_syncgrid grid) : 
                        base(grid)
                {
                    SYProvider__Name = new PXTextEdit("ctl00_phG_tab_t16_syncGrid_ei", "SY Provider __ Name", grid.Locator, "SYProvider__Name");
                    SYProvider__Name.DataField = "SYProvider__Name";
                    RemoteID = new PXTextEdit("ctl00_phG_tab_t16_syncGrid_ei", "Remote ID", grid.Locator, "RemoteID");
                    RemoteID.DataField = "RemoteID";
                    Status = new PXTextEdit("ctl00_phG_tab_t16_syncGrid_ei", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Operation = new PXTextEdit("ctl00_phG_tab_t16_syncGrid_ei", "Operation", grid.Locator, "Operation");
                    Operation.DataField = "Operation";
                    LastErrorMessage = new PXTextEdit("ctl00_phG_tab_t16_syncGrid_ei", "Last Error Message", grid.Locator, "LastErrorMessage");
                    LastErrorMessage.DataField = "LastErrorMessage";
                    LastAttemptTS = new PXTextEdit("ctl00_phG_tab_t16_syncGrid_em", "Last Attempt TS", grid.Locator, "LastAttemptTS");
                    LastAttemptTS.DataField = "LastAttemptTS";
                    AttemptCount = new PXTextEdit("ctl00_phG_tab_t16_syncGrid_ei", "Attempt Count", grid.Locator, "AttemptCount");
                    AttemptCount.DataField = "AttemptCount";
                    SFEntitySetup__ImportScenario = new PXTextEdit("ctl00_phG_tab_t16_syncGrid_ei", "SF Entity Setup __ Import Scenario", grid.Locator, "SFEntitySetup__ImportScenario");
                    SFEntitySetup__ImportScenario.DataField = "SFEntitySetup__ImportScenario";
                    SFEntitySetup__ExportScenario = new PXTextEdit("ctl00_phG_tab_t16_syncGrid_ei", "SF Entity Setup __ Export Scenario", grid.Locator, "SFEntitySetup__ExportScenario");
                    SFEntitySetup__ExportScenario.DataField = "SFEntitySetup__ExportScenario";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter SYProvider__Name { get; }
				public PXTextEditColumnFilter RemoteID { get; }
				public PXTextEditColumnFilter Status { get; }
				public PXTextEditColumnFilter Operation { get; }
				public PXTextEditColumnFilter LastErrorMessage { get; }
				public PXTextEditColumnFilter LastAttemptTS { get; }
				public PXTextEditColumnFilter AttemptCount { get; }
				public PXTextEditColumnFilter SFEntitySetup__ImportScenario { get; }
				public PXTextEditColumnFilter SFEntitySetup__ExportScenario { get; }
                
                public c_grid_header(c_syncrecs_syncgrid grid) : 
                        base(grid)
                {
                    SYProvider__Name = new PXTextEditColumnFilter(grid.Row.SYProvider__Name);
                    RemoteID = new PXTextEditColumnFilter(grid.Row.RemoteID);
                    Status = new PXTextEditColumnFilter(grid.Row.Status);
                    Operation = new PXTextEditColumnFilter(grid.Row.Operation);
                    LastErrorMessage = new PXTextEditColumnFilter(grid.Row.LastErrorMessage);
                    LastAttemptTS = new PXTextEditColumnFilter(grid.Row.LastAttemptTS);
                    AttemptCount = new PXTextEditColumnFilter(grid.Row.AttemptCount);
                    SFEntitySetup__ImportScenario = new PXTextEditColumnFilter(grid.Row.SFEntitySetup__ImportScenario);
                    SFEntitySetup__ExportScenario = new PXTextEditColumnFilter(grid.Row.SFEntitySetup__ExportScenario);
                }
            }
        }
        
        public class c_filterpreview_formpreview : Container
        {
            
            public PxButtonCollection Buttons;
            
            public c_filterpreview_formpreview(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "FilterPreview";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_usrCaption_PanelDynamicForm_PXButtonOK", "OK", "ctl00_usrCaption_PanelDynamicForm_FormPreview");
                    Cancel = new Button("ctl00_usrCaption_PanelDynamicForm_PXButtonCancel", "Cancel", "ctl00_usrCaption_PanelDynamicForm_FormPreview");
                }
            }
        }
        
        public class c_itemsettings_filesgrid : Grid<c_itemsettings_filesgrid.c_grid_row, c_itemsettings_filesgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_itemsettings_filesgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_attFiles_filesGrid");
                DataMemberName = "ItemSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public virtual void UpBtn()
            {
                Buttons.UpBtn.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_attFiles_filesGrid_at_tlb div[da" +
                            "ta-cmd=\'Refresh\']", "Refresh", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_attFiles_filesGrid_at_tlb div[da" +
                            "ta-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_attFiles_filesGrid_ab_tlb div[da" +
                            "ta-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_attFiles_filesGrid_ab_tlb div[da" +
                            "ta-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_attFiles_filesGrid_ab_tlb div[da" +
                            "ta-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_attFiles_filesGrid_ab_tlb div[da" +
                            "ta-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_attFiles_filesGrid_ab_tlb div[da" +
                            "ta-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button UpBtn { get; }
                
                public PxButtonCollection()
                {
                    UpBtn = new Button("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_attFiles_attFileUp_upBtn", "upBtn", "ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_attFiles_filesGrid");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit Name { get; }
			public PXTextEdit Size { get; }
			public PXTextEdit Comment { get; }
                
                public c_grid_row(c_itemsettings_filesgrid grid) : 
                        base(grid)
                {
                    Name = new PXTextEdit("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_attFiles_filesGrid_ei", "Name", grid.Locator, "Name");
                    Name.DataField = "Name";
                    Size = new PXTextEdit("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_attFiles_filesGrid_ei", "Size (kb)", grid.Locator, "Size");
                    Size.DataField = "Size";
                    Comment = new PXTextEdit("ctl00_phG_tab_t14_edBody_insl_splitter_rpnl_attFiles_filesGrid_ei", "Comment", grid.Locator, "Comment");
                    Comment.DataField = "Comment";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter Name { get; }
				public PXTextEditColumnFilter Size { get; }
				public PXTextEditColumnFilter Comment { get; }
                
                public c_grid_header(c_itemsettings_filesgrid grid) : 
                        base(grid)
                {
                    Name = new PXTextEditColumnFilter(grid.Row.Name);
                    Size = new PXTextEditColumnFilter(grid.Row.Size);
                    Comment = new PXTextEditColumnFilter(grid.Row.Comment);
                }
            }
        }
        
        public class c_relateditems_importcsvsettings_frmimportcsvsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit Separator { get; }
			public Label SeparatorLabel { get; }
			public PXTextEdit NullValue { get; }
			public Label NullValueLabel { get; }
			public DropDown CodePage { get; }
			public Label CodePageLabel { get; }
			public DropDown Culture { get; }
			public Label CultureLabel { get; }
			public DropDown Mode { get; }
			public Label ModeLabel { get; }
            
            public c_relateditems_importcsvsettings_frmimportcsvsettings(string locator, string name) : 
                    base(locator, name)
            {
                Separator = new PXTextEdit("ctl00_phG_tab_t9_relatedItemsGrid_imp_importCSVSettingsDlg_frmImportCSVSettings_e" +
                        "dSeparator", "Separator", locator, null);
                SeparatorLabel = new Label(Separator);
                Separator.DataField = "Separator";
                NullValue = new PXTextEdit("ctl00_phG_tab_t9_relatedItemsGrid_imp_importCSVSettingsDlg_frmImportCSVSettings_e" +
                        "dNullValue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                CodePage = new DropDown("ctl00_phG_tab_t9_relatedItemsGrid_imp_importCSVSettingsDlg_frmImportCSVSettings_e" +
                        "dCodePage", "Code Page", locator, null);
                CodePageLabel = new Label(CodePage);
                CodePage.DataField = "CodePage";
                Culture = new DropDown("ctl00_phG_tab_t9_relatedItemsGrid_imp_importCSVSettingsDlg_frmImportCSVSettings_e" +
                        "dCultures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t9_relatedItemsGrid_imp_importCSVSettingsDlg_frmImportCSVSettings_e" +
                        "dMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "RelatedItems$ImportCSVSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_tab_t9_relatedItemsGrid_imp_importCSVSettingsDlg_frmImportCSVSettings");
                    Cancel = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_tab_t9_relatedItemsGrid_imp_importCSVSettingsDlg_frmImportCSVSettings");
                }
            }
        }
        
        public class c_relateditems_importxlsxsettings_frmimportxlsxsettings : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NullValue { get; }
			public Label NullValueLabel { get; }
			public DropDown Culture { get; }
			public Label CultureLabel { get; }
			public DropDown Mode { get; }
			public Label ModeLabel { get; }
            
            public c_relateditems_importxlsxsettings_frmimportxlsxsettings(string locator, string name) : 
                    base(locator, name)
            {
                NullValue = new PXTextEdit("ctl00_phG_tab_t9_relatedItemsGrid_imp_importXLSXSettingsDlg_frmImportXLSXSettings" +
                        "_edNullValue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                Culture = new DropDown("ctl00_phG_tab_t9_relatedItemsGrid_imp_importXLSXSettingsDlg_frmImportXLSXSettings" +
                        "_edCultures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_tab_t9_relatedItemsGrid_imp_importXLSXSettingsDlg_frmImportXLSXSettings" +
                        "_edMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "RelatedItems$ImportXLSXSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_tab_t9_relatedItemsGrid_imp_importXLSXSettingsDlg_frmImportXLSXSettings" +
                            "");
                    Cancel = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_tab_t9_relatedItemsGrid_imp_importXLSXSettingsDlg_frmImportXLSXSettings" +
                            "");
                }
            }
        }
        
        public class c_relateditems_importcolumns_grdimportcolumn : Grid<c_relateditems_importcolumns_grdimportcolumn.c_grid_row, c_relateditems_importcolumns_grdimportcolumn.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_relateditems_importcolumns_grdimportcolumn(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "RelatedItems$ImportColumns";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn");
                    Prev = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn");
                    Next = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn");
                    Last = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn");
                    Ok = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn");
                    Cancel = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit ColumnName { get; }
			public DropDown PropertyName { get; }
                
                public c_grid_row(c_relateditems_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEdit("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_ei", "ColumnName", grid.Locator, "ColumnName");
                    ColumnName.DataField = "ColumnName";
                    PropertyName = new DropDown("_ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0_ec", "PropertyName", grid.Locator, "PropertyName");
                    PropertyName.DataField = "PropertyName";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter ColumnName { get; }
				public InputColumnFilter PropertyName { get; }
                
                public c_grid_header(c_relateditems_importcolumns_grdimportcolumn grid) : 
                        base(grid)
                {
                    ColumnName = new PXTextEditColumnFilter(grid.Row.ColumnName);
                    PropertyName = new InputColumnFilter(grid.Row.PropertyName);
                }
            }
        }
        
        public class c_relateditems_importcolumns_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_relateditems_importcolumns_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "RelatedItems$ImportColumns";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First()
            {
                Buttons.First.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Last()
            {
                Buttons.Last.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0");
                    Prev = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0");
                    Next = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0");
                    Last = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0");
                    Ok = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0");
                    Cancel = new Button("ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_tab_t9_relatedItemsGrid_imp_importColumnDlg_grdImportColumn_lv0");
                }
            }
        }
    }
}
