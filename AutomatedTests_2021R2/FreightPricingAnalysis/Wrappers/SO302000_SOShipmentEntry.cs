using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.CheckBoxButton;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.EmailEdit;
using Controls.Editors.Selector;
using Controls.Editors.TreeSelector;
using Controls.FileColumnButton;
using Controls.Grid;
using Controls.Grid.Filter;
using Controls.Grid.Upload;
using Controls.GroupBox;
using Controls.Input;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.NoteColumnButton;
using Controls.PxControlCollection;
using Controls.ToolBarButton;
using Controls.UnknownControl;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace GeneratedWrappers.Acumatica
{
    
    
    public class SO302000_SOShipmentEntry : Wrapper
    {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
        protected c_document_form Document_form { get; } = new c_document_form("ctl00_phF_form", "Document_form");
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
        protected c__soshipment_currencyinfo__rf _SOShipment_CurrencyInfo__rf { get; } = new c__soshipment_currencyinfo__rf("ctl00_phG_tab_t2_formF_edCury_pnlRate_rf", "_SOShipment_CurrencyInfo__rf");
        protected c_currentdocument_formcarrierrates CurrentDocument_formCarrierRates { get; } = new c_currentdocument_formcarrierrates("ctl00_phG_PanelCarrierRates_formCarrierRates", "CurrentDocument_formCarrierRates");
        protected c_currentdocument_formi CurrentDocument_formI { get; } = new c_currentdocument_formi("ctl00_phG_tab_t2_formI", "CurrentDocument_formI");
        protected c_currentdocument_formf CurrentDocument_formF { get; } = new c_currentdocument_formf("ctl00_phG_tab_t2_formF", "CurrentDocument_formF");
        protected c_currentdocument_gridsm CurrentDocument_gridSM { get; } = new c_currentdocument_gridsm("ctl00_phG_tab_t2_gridSM", "CurrentDocument_gridSM");
        protected c_transactions_grid Transactions_grid { get; } = new c_transactions_grid("ctl00_phG_tab_t0_grid", "Transactions_grid");
        protected c_transactions_lv0 Transactions_lv0 { get; } = new c_transactions_lv0("ctl00_phG_tab_t0_grid_lv0", "Transactions_lv0");
        protected c_shipping_address_formb Shipping_Address_formB { get; } = new c_shipping_address_formb("ctl00_phG_tab_t2_formB", "Shipping_Address_formB");
        protected c_shipping_contact_formd Shipping_Contact_formD { get; } = new c_shipping_contact_formd("ctl00_phG_tab_t2_formD", "Shipping_Contact_formD");
        protected c_orderlist_grid5 OrderList_grid5 { get; } = new c_orderlist_grid5("ctl00_phG_tab_t1_grid5", "OrderList_grid5");
        protected c_orderlist_lv0 OrderList_lv0 { get; } = new c_orderlist_lv0("ctl00_phG_tab_t1_grid5_lv0", "OrderList_lv0");
        protected c_packages_gridpackages Packages_gridPackages { get; } = new c_packages_gridpackages("ctl00_phG_tab_t3_gridPackages", "Packages_gridPackages");
        protected c_packages_lv0 Packages_lv0 { get; } = new c_packages_lv0("ctl00_phG_tab_t3_gridPackages_lv0", "Packages_lv0");
        protected c_packagesforrates_gridpackagesforrates PackagesForRates_gridPackagesForRates { get; } = new c_packagesforrates_gridpackagesforrates("ctl00_phG_PanelCarrierRates_gridPackagesForRates", "PackagesForRates_gridPackagesForRates");
        protected c_packagesforrates_lv0 PackagesForRates_lv0 { get; } = new c_packagesforrates_lv0("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lv0", "PackagesForRates_lv0");
        protected c_splits_grid2 Splits_grid2 { get; } = new c_splits_grid2("ctl00_phG_PanelLS_grid2", "splits_grid2");
        protected c_splits_lv0 Splits_lv0 { get; } = new c_splits_lv0("ctl00_phG_PanelLS_grid2_lv0", "splits_lv0");
        protected c_addsofilter_form4 Addsofilter_form4 { get; } = new c_addsofilter_form4("ctl00_phG_PanelAddSO_form4", "addsofilter_form4");
        protected c_soshipmentplan_grid4 Soshipmentplan_grid4 { get; } = new c_soshipmentplan_grid4("ctl00_phG_PanelAddSO_grid4", "soshipmentplan_grid4");
        protected c_soshipmentplan_lv0 Soshipmentplan_lv0 { get; } = new c_soshipmentplan_lv0("ctl00_phG_PanelAddSO_grid4_lv0", "soshipmentplan_lv0");
        protected c_carrierrates_gridrates CarrierRates_gridRates { get; } = new c_carrierrates_gridrates("ctl00_phG_PanelCarrierRates_gridRates", "CarrierRates_gridRates");
        protected c_carrierrates_lv0 CarrierRates_lv0 { get; } = new c_carrierrates_lv0("ctl00_phG_PanelCarrierRates_gridRates_lv0", "CarrierRates_lv0");
        protected c_packagedetailsplit_gridpackagedetailsplit PackageDetailSplit_gridPackageDetailSplit { get; } = new c_packagedetailsplit_gridpackagedetailsplit("ctl00_phG_tab_t3_gridPackageDetailSplit", "PackageDetailSplit_gridPackageDetailSplit");
        protected c_packagedetailsplit_lv0 PackageDetailSplit_lv0 { get; } = new c_packagedetailsplit_lv0("ctl00_phG_tab_t3_gridPackageDetailSplit_lv0", "PackageDetailSplit_lv0");
        protected c_addresslookupfilter_addresslookuppanelformaddress AddressLookupFilter_AddressLookupPanelformAddress { get; } = new c_addresslookupfilter_addresslookuppanelformaddress("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress", "AddressLookupFilter_AddressLookupPanelformAddress");
        protected c_lssoshipline_lotseropts_optform LSSOShipLine_lotseropts_optform { get; } = new c_lssoshipline_lotseropts_optform("ctl00_phG_PanelLS_optform", "LSSOShipLine_lotseropts_optform");
        protected c_picklistentries_picklistheader PickListEntries_PickListHeader { get; } = new c_picklistentries_picklistheader("ctl00_phG_PanelPickList_PickListHeader", "PickListEntries_PickListHeader");
        protected c_picklistentries_gridpicklist PickListEntries_gridPickList { get; } = new c_picklistentries_gridpicklist("ctl00_phG_PanelPickList_gridPickList", "PickListEntries_gridPickList");
        protected c_picklistentries_lv0 PickListEntries_lv0 { get; } = new c_picklistentries_lv0("ctl00_phG_PanelPickList_gridPickList_lv0", "PickListEntries_lv0");
        protected c_workflowview_workflowfictivediagram WorkflowView_WorkflowFictiveDiagram { get; } = new c_workflowview_workflowfictivediagram("ctl00_usrCaption_WorkflowDiagram_pnlWorkFlow_WorkflowFictiveDiagram", "WorkflowView_WorkflowFictiveDiagram");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        public c_attributes Attributes { get; } = new c_attributes("ctl00_phF_form_t1", "Attributes");
        
        public SO302000_SOShipmentEntry()
        {
            ScreenId = "SO302000";
            ScreenUrl = "/Pages/SO/SO302000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual SO302000_SOShipmentEntry ReadOne(Gate gate, string ShipmentNbr)
        {
            new BiObject<SO302000_SOShipmentEntry>(gate).ReadOne(this, ShipmentNbr);
            return this;
        }
        
        public virtual SO302000_SOShipmentEntry ReadOne(string ShipmentNbr)
        {
            return this.ReadOne(ApiConnection.Source, ShipmentNbr);
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
        
        public virtual void ManageAttributes()
        {
            ToolBar.ManageAttributes.Click();
        }
        
        public virtual void MenuEditProj()
        {
            ToolBar.MenuEditProj.Click();
        }
        
        public virtual void ManageCustomizations()
        {
            ToolBar.ManageCustomizations.Click();
        }
        
        public virtual void ShowWorkflow()
        {
            ToolBar.ShowWorkflow.Click();
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
        
        public virtual void InitializeState()
        {
            ToolBar.InitializeState.Click();
        }
        
        public virtual void ReleaseFromHold()
        {
            ToolBar.ReleaseFromHold.Click();
        }
        
        public virtual void ViewActivity()
        {
            ToolBar.ViewActivity.Click();
        }
        
        public virtual void ViewactivityWorkflow()
        {
            ToolBar.ViewactivityWorkflow.Click();
        }
        
        public virtual void OpenActivityOwner()
        {
            ToolBar.OpenActivityOwner.Click();
        }
        
        public virtual void OpenactivityownerWorkflow()
        {
            ToolBar.OpenactivityownerWorkflow.Click();
        }
        
        public virtual void ViewAllActivities()
        {
            ToolBar.ViewAllActivities.Click();
        }
        
        public virtual void ViewallactivitiesWorkflow()
        {
            ToolBar.ViewallactivitiesWorkflow.Click();
        }
        
        public virtual void ConfirmShipmentAction()
        {
            ToolBar.ConfirmShipmentAction.Click();
        }
        
        public virtual void ConfirmShipmentAction(bool status, string message = null)
        {
            ToolBar.ConfirmShipmentAction.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.ConfirmShipmentAction.Click();
        }
        
        public virtual void CreateInvoice()
        {
            ToolBar.CreateInvoice.Click();
        }
        
        public virtual void CreateInvoice(bool status, string message = null)
        {
            ToolBar.CreateInvoice.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.CreateInvoice.Click();
        }
        
        public virtual void CreateDropshipInvoice()
        {
            ToolBar.CreateDropshipInvoice.Click();
        }
        
        public virtual void CreateDropshipInvoice(bool status, string message = null)
        {
            ToolBar.CreateDropshipInvoice.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.CreateDropshipInvoice.Click();
        }
        
        public virtual void CorrectShipmentAction()
        {
            ToolBar.CorrectShipmentAction.Click();
        }
        
        public virtual void GeneratePOReceipt()
        {
            ToolBar.GeneratePOReceipt.Click();
        }
        
        public virtual void PrintPickListAction()
        {
            ToolBar.PrintPickListAction.Click();
        }
        
        public virtual void PrintShipmentConfirmation()
        {
            ToolBar.PrintShipmentConfirmation.Click();
        }
        
        public virtual void EmailShipment()
        {
            ToolBar.EmailShipment.Click();
        }
        
        public virtual void PrintLabels()
        {
            ToolBar.PrintLabels.Click();
        }
        
        public virtual void PrintLabels(bool status, string message = null)
        {
            ToolBar.PrintLabels.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.PrintLabels.Click();
        }
        
        public virtual void GetReturnLabelsAction()
        {
            ToolBar.GetReturnLabelsAction.Click();
        }
        
        public virtual void GetReturnLabelsAction(bool status, string message = null)
        {
            ToolBar.GetReturnLabelsAction.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.GetReturnLabelsAction.Click();
        }
        
        public virtual void UpdateIN()
        {
            ToolBar.UpdateIN.Click();
        }
        
        public virtual void CancelReturn()
        {
            ToolBar.CancelReturn.Click();
        }
        
        public virtual void CancelReturn(bool status, string message = null)
        {
            ToolBar.CancelReturn.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.CancelReturn.Click();
        }
        
        public virtual void ValidateAddresses()
        {
            ToolBar.ValidateAddresses.Click();
        }
        
        public virtual void UnlinkFromWorksheet()
        {
            ToolBar.UnlinkFromWorksheet.Click();
        }
        
        public virtual void UnlinkFromWorksheet(bool status, string message = null)
        {
            ToolBar.UnlinkFromWorksheet.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.UnlinkFromWorksheet.Click();
        }
        
        public virtual void PutOnHold()
        {
            ToolBar.PutOnHold.Click();
        }
        
        public virtual void Notification()
        {
            ToolBar.Notification.Click();
        }
        
        public virtual void Action()
        {
            ToolBar.Action.Click();
        }
        
        public virtual void Inquiry()
        {
            ToolBar.Inquiry.Click();
        }
        
        public virtual void Report()
        {
            ToolBar.Report.Click();
        }
        
        public virtual void ProcessingCategory()
        {
            ToolBar.ProcessingCategory.Click();
        }
        
        public virtual void PickList()
        {
            ToolBar.PickList.Click();
        }
        
        public virtual void IntercompanyCategory()
        {
            ToolBar.IntercompanyCategory.Click();
        }
        
        public virtual void PrintingAndEmailingCategory()
        {
            ToolBar.PrintingAndEmailingCategory.Click();
        }
        
        public virtual void LabelsCategory()
        {
            ToolBar.LabelsCategory.Click();
        }
        
        public virtual void OtherCategory()
        {
            ToolBar.OtherCategory.Click();
        }
        
        public virtual void ApplyAssignmentRules()
        {
            ToolBar.ApplyAssignmentRules.Click();
        }
        
        public virtual void ViewManifest()
        {
            ToolBar.ViewManifest.Click();
        }
        
        public virtual void SoordershipmentDisplayshippingrefnoteidLink()
        {
            ToolBar.SoordershipmentDisplayshippingrefnoteidLink.Click();
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
			public ToolBarButton ManageAttributes { get; }
			public ToolBarButton MenuEditProj { get; }
			public ToolBarButton ManageCustomizations { get; }
			public ToolBarButton ShowWorkflow { get; }
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
			public ToolBarButton InitializeState { get; }
			public ToolBarButton ReleaseFromHold { get; }
			public ToolBarButton ViewActivity { get; }
			public ToolBarButton ViewactivityWorkflow { get; }
			public ToolBarButton OpenActivityOwner { get; }
			public ToolBarButton OpenactivityownerWorkflow { get; }
			public ToolBarButton ViewAllActivities { get; }
			public ToolBarButton ViewallactivitiesWorkflow { get; }
			public ToolBarButton ConfirmShipmentAction { get; }
			public ToolBarButton CreateInvoice { get; }
			public ToolBarButton CreateDropshipInvoice { get; }
			public ToolBarButton CorrectShipmentAction { get; }
			public ToolBarButton GeneratePOReceipt { get; }
			public ToolBarButton PrintPickListAction { get; }
			public ToolBarButton PrintShipmentConfirmation { get; }
			public ToolBarButton EmailShipment { get; }
			public ToolBarButton PrintLabels { get; }
			public ToolBarButton GetReturnLabelsAction { get; }
			public ToolBarButton UpdateIN { get; }
			public ToolBarButton CancelReturn { get; }
			public ToolBarButton ValidateAddresses { get; }
			public ToolBarButton UnlinkFromWorksheet { get; }
			public ToolBarButton PutOnHold { get; }
			public ToolBarButton Notification { get; }
			public ToolBarButton Action { get; }
			public ToolBarButton Inquiry { get; }
			public ToolBarButton Report { get; }
			public ToolBarButton ProcessingCategory { get; }
			public ToolBarButton PickList { get; }
			public ToolBarButton IntercompanyCategory { get; }
			public ToolBarButton PrintingAndEmailingCategory { get; }
			public ToolBarButton LabelsCategory { get; }
			public ToolBarButton OtherCategory { get; }
			public ToolBarButton ApplyAssignmentRules { get; }
			public ToolBarButton ViewManifest { get; }
			public ToolBarButton SoordershipmentDisplayshippingrefnoteidLink { get; }
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
                ManageAttributes = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "ManageAttributes\']", "Manage User-Defined Fields", locator, Custom);
                MenuEditProj = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "menuEditProj\']", "Edit Project...", locator, Custom);
                ManageCustomizations = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li.menuItem d" +
                        "iv:textEqual(\"Manage Customizations...\")", "Manage Customizations...", locator, Custom);
                ShowWorkflow = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "ShowWorkflow\']", "Show state diagram", locator, Custom);
                KeyBtnRefresh = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'keyBtnRefresh\']", "Click to refresh page.", locator, null);
                Help = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'help\']", "View Tools", locator, null);
                MenuOpener = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_MenuOpener", "Menu", locator, null);
                CancelClose = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CancelClose", "Discard Changes and Close", locator, null);
                CancelClose.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                SaveClose = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_SaveClose", "Save the current record and close the screen (Ctrl+Shift+S).", locator, null);
                Save = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Save", "Save (Ctrl+S).", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Cancel", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                Insert = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Insert", "Add New Record (Ctrl+Ins)", locator, null);
                Delete = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Delete", "Delete (Ctrl+Del).", locator, null);
                Delete.ConfirmAction = () => Alert.AlertToException("The current Shipment record will be deleted.");
                CopyPaste = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CopyPaste", "Clipboard", locator, null);
                CopyDocument = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@CopyDocument\']", "CopyDocument", locator, CopyPaste);
                PasteDocument = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@PasteDocument\']", "PasteDocument", locator, CopyPaste);
                SaveTemplate = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@SaveTemplate\']", "SaveTemplate", locator, CopyPaste);
                First = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_First", "Go to First Record", locator, null);
                Previous = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Previous", "Go to Previous Record (PgUp)", locator, null);
                Next = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Next", "Go to Next Record (PgDn)", locator, null);
                Last = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Last", "Go to Last Record", locator, null);
                InitializeState = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_initializeState,#ctl00_phDS_ds_ToolBar_initializeState" +
                        "_item", "initializeState", locator, MenuOpener);
                ReleaseFromHold = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ReleaseFromHold,#ctl00_phDS_ds_ToolBar_ReleaseFromHold" +
                        "_item", "Remove Hold", locator, MenuOpener);
                ViewActivity = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewActivity,#ctl00_phDS_ds_ToolBar_ViewActivity_item", "Details", locator, MenuOpener);
                ViewactivityWorkflow = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewActivity_Workflow,#ctl00_phDS_ds_ToolBar_ViewActiv" +
                        "ity_Workflow_item", "Details", locator, MenuOpener);
                OpenActivityOwner = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_OpenActivityOwner,#ctl00_phDS_ds_ToolBar_OpenActivityO" +
                        "wner_item", "OpenActivityOwner", locator, MenuOpener);
                OpenactivityownerWorkflow = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_OpenActivityOwner_Workflow,#ctl00_phDS_ds_ToolBar_Open" +
                        "ActivityOwner_Workflow_item", "OpenActivityOwner_Workflow", locator, MenuOpener);
                ViewAllActivities = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewAllActivities,#ctl00_phDS_ds_ToolBar_ViewAllActivi" +
                        "ties_item", "View Activities", locator, MenuOpener);
                ViewallactivitiesWorkflow = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewAllActivities_Workflow,#ctl00_phDS_ds_ToolBar_View" +
                        "AllActivities_Workflow_item", "View Activities", locator, MenuOpener);
                ConfirmShipmentAction = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ConfirmShipmentAction,#ctl00_phDS_ds_ToolBar_ConfirmSh" +
                        "ipmentAction_item", "Confirm Shipment", locator, MenuOpener);
                ConfirmShipmentAction.WaitAction = Wait.WaitForLongOperationToComplete;
                CreateInvoice = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CreateInvoice,#ctl00_phDS_ds_ToolBar_CreateInvoice_ite" +
                        "m", "Prepare Invoice", locator, MenuOpener);
                CreateInvoice.WaitAction = Wait.WaitForLongOperationToComplete;
                CreateDropshipInvoice = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CreateDropshipInvoice,#ctl00_phDS_ds_ToolBar_CreateDro" +
                        "pshipInvoice_item", "Prepare Drop-Ship Invoice", locator, MenuOpener);
                CreateDropshipInvoice.WaitAction = Wait.WaitForLongOperationToComplete;
                CorrectShipmentAction = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CorrectShipmentAction,#ctl00_phDS_ds_ToolBar_CorrectSh" +
                        "ipmentAction_item", "Correct Shipment", locator, MenuOpener);
                GeneratePOReceipt = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_GeneratePOReceipt,#ctl00_phDS_ds_ToolBar_GeneratePORec" +
                        "eipt_item", "Generate PO Receipt", locator, MenuOpener);
                PrintPickListAction = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PrintPickListAction,#ctl00_phDS_ds_ToolBar_PrintPickLi" +
                        "stAction_item", "Print Pick List", locator, MenuOpener);
                PrintShipmentConfirmation = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PrintShipmentConfirmation,#ctl00_phDS_ds_ToolBar_Print" +
                        "ShipmentConfirmation_item", "Print Shipment Confirmation", locator, MenuOpener);
                EmailShipment = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_EmailShipment,#ctl00_phDS_ds_ToolBar_EmailShipment_ite" +
                        "m", "Email Shipment", locator, MenuOpener);
                PrintLabels = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PrintLabels,#ctl00_phDS_ds_ToolBar_PrintLabels_item", "Print Labels", locator, MenuOpener);
                PrintLabels.WaitAction = Wait.WaitForLongOperationToComplete;
                GetReturnLabelsAction = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_GetReturnLabelsAction,#ctl00_phDS_ds_ToolBar_GetReturn" +
                        "LabelsAction_item", "Get Return Labels", locator, MenuOpener);
                GetReturnLabelsAction.WaitAction = Wait.WaitForLongOperationToComplete;
                UpdateIN = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_updateIN,#ctl00_phDS_ds_ToolBar_updateIN_item", "Update IN", locator, MenuOpener);
                CancelReturn = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CancelReturn,#ctl00_phDS_ds_ToolBar_CancelReturn_item", "Cancel Return", locator, MenuOpener);
                CancelReturn.WaitAction = Wait.WaitForLongOperationToComplete;
                ValidateAddresses = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ValidateAddresses,#ctl00_phDS_ds_ToolBar_ValidateAddre" +
                        "sses_item", "Validate Addresses", locator, MenuOpener);
                UnlinkFromWorksheet = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_unlinkFromWorksheet,#ctl00_phDS_ds_ToolBar_unlinkFromW" +
                        "orksheet_item", "Remove from Worksheet", locator, MenuOpener);
                UnlinkFromWorksheet.WaitAction = Wait.WaitForLongOperationToComplete;
                PutOnHold = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PutOnHold,#ctl00_phDS_ds_ToolBar_PutOnHold_item", "Hold", locator, MenuOpener);
                Notification = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Notification,#ctl00_phDS_ds_ToolBar_Notification_item", "Notifications", locator, MenuOpener);
                Action = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Action", "Actions", locator, MenuOpener);
                Inquiry = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Inquiry", "Inquiries", locator, MenuOpener);
                Report = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Report", "Reports", locator, MenuOpener);
                ProcessingCategory = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Processing_Category", "Processing", locator, MenuOpener);
                PickList = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Pick_List", "Pick List", locator, MenuOpener);
                IntercompanyCategory = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Intercompany_Category", "Intercompany", locator, MenuOpener);
                PrintingAndEmailingCategory = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Printing_and_Emailing_Category", "Printing and Emailing", locator, MenuOpener);
                LabelsCategory = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Labels_Category", "Labels", locator, MenuOpener);
                OtherCategory = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Other_Category", "Other", locator, MenuOpener);
                ApplyAssignmentRules = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ApplyAssignmentRules,#ctl00_phDS_ds_ToolBar_ApplyAssig" +
                        "nmentRules_item", "Apply Assignment Rules", locator, MenuOpener);
                ViewManifest = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_viewManifest,#ctl00_phDS_ds_ToolBar_viewManifest_item", "View Manifest/Scanform", locator, MenuOpener);
                SoordershipmentDisplayshippingrefnoteidLink = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_SOOrderShipment~DisplayShippingRefNoteID~Link,#ctl00_p" +
                        "hDS_ds_ToolBar_SOOrderShipment~DisplayShippingRefNoteID~Link_item", "SOOrderShipment\r\nDisplayShippingRefNoteID\r\nLink", locator, MenuOpener);
                LongRun = new ToolBarButton("css=qp-long-run", "Nothing in progress", locator, null);
                LongrunCancel = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_cancel", "Cancel", locator, null);
                LongrunTimer = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_timer", "Elapsed Time", locator, null);
            }
        }
        
        public class c_document_form : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector ShipmentNbr { get; }
			public Label ShipmentNbrLabel { get; }
			public DropDown ShipmentType { get; }
			public Label ShipmentTypeLabel { get; }
			public DropDown Status { get; }
			public Label StatusLabel { get; }
			public DropDown Operation { get; }
			public Label OperationLabel { get; }
			public DateSelector ShipDate { get; }
			public Label ShipDateLabel { get; }
			public Selector CustomerID { get; }
			public Label CustomerIDLabel { get; }
			public Selector CustomerLocationID { get; }
			public Label CustomerLocationIDLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public Selector DestinationSiteID { get; }
			public Label DestinationSiteIDLabel { get; }
			public TreeSelector WorkgroupID { get; }
			public Label WorkgroupIDLabel { get; }
			public Selector OwnerID { get; }
			public Label OwnerIDLabel { get; }
			public Selector CurrentWorksheetNbr { get; }
			public Label CurrentWorksheetNbrLabel { get; }
			public PXNumberEdit ShipmentQty { get; }
			public Label ShipmentQtyLabel { get; }
			public PXNumberEdit ControlQty { get; }
			public Label ControlQtyLabel { get; }
			public PXNumberEdit ShipmentWeight { get; }
			public Label ShipmentWeightLabel { get; }
			public PXNumberEdit ShipmentVolume { get; }
			public Label ShipmentVolumeLabel { get; }
			public PXNumberEdit PackageCount { get; }
			public Label PackageCountLabel { get; }
			public PXNumberEdit PackageWeight { get; }
			public Label PackageWeightLabel { get; }
			public PXTextEdit ShipmentDesc { get; }
			public Label ShipmentDescLabel { get; }
			public Label Ctl02_ { get; }
            
            public c_document_form(string locator, string name) : 
                    base(locator, name)
            {
                ShipmentNbr = new Selector("ctl00_phF_form_t0_edShipmentNbr", "Shipment Nbr.", locator, null);
                ShipmentNbrLabel = new Label(ShipmentNbr);
                ShipmentNbr.DataField = "ShipmentNbr";
                ShipmentType = new DropDown("ctl00_phF_form_t0_edShipmentType", "Type", locator, null);
                ShipmentTypeLabel = new Label(ShipmentType);
                ShipmentType.DataField = "ShipmentType";
                ShipmentType.Items.Add("I", "Shipment");
                ShipmentType.Items.Add("T", "Transfer");
                Status = new DropDown("ctl00_phF_form_t0_edStatus", "Status", locator, null);
                StatusLabel = new Label(Status);
                Status.DataField = "Status";
                Status.Items.Add("N", "Open");
                Status.Items.Add("H", "On Hold");
                Status.Items.Add("C", "Completed");
                Status.Items.Add("L", "Canceled");
                Status.Items.Add("F", "Confirmed");
                Status.Items.Add("I", "Invoiced");
                Status.Items.Add("Y", "Partially Invoiced");
                Status.Items.Add("R", "Receipted");
                Status.Items.Add("A", "Auto-Generated");
                Operation = new DropDown("ctl00_phF_form_t0_edOperation", "Operation", locator, null);
                OperationLabel = new Label(Operation);
                Operation.DataField = "Operation";
                Operation.Items.Add("I", "Issue");
                Operation.Items.Add("R", "Receipt");
                ShipDate = new DateSelector("ctl00_phF_form_t0_edShipDate", "Shipment Date", locator, null);
                ShipDateLabel = new Label(ShipDate);
                ShipDate.DataField = "ShipDate";
                CustomerID = new Selector("ctl00_phF_form_t0_edCustomerID", "Customer", locator, null);
                CustomerIDLabel = new Label(CustomerID);
                CustomerID.DataField = "CustomerID";
                CustomerLocationID = new Selector("ctl00_phF_form_t0_edCustomerLocationID", "Location", locator, null);
                CustomerLocationIDLabel = new Label(CustomerLocationID);
                CustomerLocationID.DataField = "CustomerLocationID";
                SiteID = new Selector("ctl00_phF_form_t0_edSiteID", "Warehouse ID", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                DestinationSiteID = new Selector("ctl00_phF_form_t0_edDestinationSiteID", "To Warehouse", locator, null);
                DestinationSiteIDLabel = new Label(DestinationSiteID);
                DestinationSiteID.DataField = "DestinationSiteID";
                WorkgroupID = new TreeSelector("ctl00_phF_form_t0_PXTreeSelector1", "Workgroup", locator, null);
                WorkgroupIDLabel = new Label(WorkgroupID);
                WorkgroupID.DataField = "WorkgroupID";
                OwnerID = new Selector("ctl00_phF_form_t0_edOwnerID", "Owner", locator, null);
                OwnerIDLabel = new Label(OwnerID);
                OwnerID.DataField = "OwnerID";
                CurrentWorksheetNbr = new Selector("ctl00_phF_form_t0_edWorksheet", "Worksheet Nbr.", locator, null);
                CurrentWorksheetNbrLabel = new Label(CurrentWorksheetNbr);
                CurrentWorksheetNbr.DataField = "CurrentWorksheetNbr";
                ShipmentQty = new PXNumberEdit("ctl00_phF_form_t0_edShipmentQty", "Shipped Quantity", locator, null);
                ShipmentQtyLabel = new Label(ShipmentQty);
                ShipmentQty.DataField = "ShipmentQty";
                ControlQty = new PXNumberEdit("ctl00_phF_form_t0_edControlQty", "Control Quantity", locator, null);
                ControlQtyLabel = new Label(ControlQty);
                ControlQty.DataField = "ControlQty";
                ShipmentWeight = new PXNumberEdit("ctl00_phF_form_t0_PXNumberEdit1", "Shipped Weight", locator, null);
                ShipmentWeightLabel = new Label(ShipmentWeight);
                ShipmentWeight.DataField = "ShipmentWeight";
                ShipmentVolume = new PXNumberEdit("ctl00_phF_form_t0_PXNumberEdit4", "Shipped Volume", locator, null);
                ShipmentVolumeLabel = new Label(ShipmentVolume);
                ShipmentVolume.DataField = "ShipmentVolume";
                PackageCount = new PXNumberEdit("ctl00_phF_form_t0_PXNumberEdit3", "Packages", locator, null);
                PackageCountLabel = new Label(PackageCount);
                PackageCount.DataField = "PackageCount";
                PackageWeight = new PXNumberEdit("ctl00_phF_form_t0_PXNumberEdit2", "Package Weight", locator, null);
                PackageWeightLabel = new Label(PackageWeight);
                PackageWeight.DataField = "PackageWeight";
                ShipmentDesc = new PXTextEdit("ctl00_phF_form_t0_edShipmentDesc", "Description", locator, null);
                ShipmentDescLabel = new Label(ShipmentDesc);
                ShipmentDesc.DataField = "ShipmentDesc";
                Ctl02_ = new Label("ctl00_phF_form_t1_ctl02", "No user-defined fields have been found.", locator, null);
                DataMemberName = "Document";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void CustomerIDEdit()
            {
                Buttons.CustomerIDEdit.Click();
            }
            
            public virtual void CurrentWorksheetNbrEdit()
            {
                Buttons.CurrentWorksheetNbrEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button CustomerIDEdit { get; }
			public Button CurrentWorksheetNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    CustomerIDEdit = new Button("css=div[id=\'ctl00_phF_form_t0_edCustomerID\'] div[class=\'editBtnCont\'] > div > div" +
                            "", "CustomerIDEdit", "ctl00_phF_form");
                    CustomerIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    CurrentWorksheetNbrEdit = new Button("css=div[id=\'ctl00_phF_form_t0_edWorksheet\'] div[class=\'editBtnCont\'] > div > div", "CurrentWorksheetNbrEdit", "ctl00_phF_form");
                    CurrentWorksheetNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
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
        
        public class c__soshipment_currencyinfo__rf : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector CuryRateTypeID { get; }
			public Label CuryRateTypeIDLabel { get; }
			public DateSelector CuryEffDate { get; }
			public Label CuryEffDateLabel { get; }
			public PXTextEdit DisplayCuryID { get; }
			public Label DisplayCuryIDLabel { get; }
			public PXNumberEdit SampleCuryRate { get; }
			public Label SampleCuryRateLabel { get; }
			public PXTextEdit BaseCuryID { get; }
			public Label BaseCuryIDLabel { get; }
			public PXTextEdit BaseCuryID2 { get; }
			public Label BaseCuryID2Label { get; }
			public PXNumberEdit SampleRecipRate { get; }
			public Label SampleRecipRateLabel { get; }
			public PXTextEdit DisplayCuryID2 { get; }
			public Label DisplayCuryID2Label { get; }
			public Label LblCount_ { get; }
			public Label LblEQ_ { get; }
			public Label LblCount2_ { get; }
			public Label LblEQ2_ { get; }
            
            public c__soshipment_currencyinfo__rf(string locator, string name) : 
                    base(locator, name)
            {
                CuryRateTypeID = new Selector("ctl00_phG_tab_t2_formF_edCury_pnlRate_rf_edRateType", "Curr. Rate Type ID", locator, null);
                CuryRateTypeIDLabel = new Label(CuryRateTypeID);
                CuryRateTypeID.DataField = "CuryRateTypeID";
                CuryEffDate = new DateSelector("ctl00_phG_tab_t2_formF_edCury_pnlRate_rf_edEffDate", "Effective Date", locator, null);
                CuryEffDateLabel = new Label(CuryEffDate);
                CuryEffDate.DataField = "CuryEffDate";
                DisplayCuryID = new PXTextEdit("ctl00_phG_tab_t2_formF_edCury_pnlRate_rf_txtCury", "Display Cury ID", locator, null);
                DisplayCuryIDLabel = new Label(DisplayCuryID);
                DisplayCuryID.DataField = "DisplayCuryID";
                SampleCuryRate = new PXNumberEdit("ctl00_phG_tab_t2_formF_edCury_pnlRate_rf_txtCuryRate", "Sample Cury Rate", locator, null);
                SampleCuryRateLabel = new Label(SampleCuryRate);
                SampleCuryRate.DataField = "SampleCuryRate";
                BaseCuryID = new PXTextEdit("ctl00_phG_tab_t2_formF_edCury_pnlRate_rf_txtBaseCury", "Base Cury ID", locator, null);
                BaseCuryIDLabel = new Label(BaseCuryID);
                BaseCuryID.DataField = "BaseCuryID";
                BaseCuryID2 = new PXTextEdit("ctl00_phG_tab_t2_formF_edCury_pnlRate_rf_txtBaseCury2", "Base Cury ID 2", locator, null);
                BaseCuryID2Label = new Label(BaseCuryID2);
                BaseCuryID2.DataField = "BaseCuryID";
                SampleRecipRate = new PXNumberEdit("ctl00_phG_tab_t2_formF_edCury_pnlRate_rf_txtCuryRate2", "Sample Recip Rate", locator, null);
                SampleRecipRateLabel = new Label(SampleRecipRate);
                SampleRecipRate.DataField = "SampleRecipRate";
                DisplayCuryID2 = new PXTextEdit("ctl00_phG_tab_t2_formF_edCury_pnlRate_rf_txtCury2", "Display Cury ID 2", locator, null);
                DisplayCuryID2Label = new Label(DisplayCuryID2);
                DisplayCuryID2.DataField = "DisplayCuryID";
                LblCount_ = new Label("ctl00_phG_tab_t2_formF_edCury_pnlRate_rf_lblCount", "1.000", locator, null);
                LblEQ_ = new Label("ctl00_phG_tab_t2_formF_edCury_pnlRate_rf_lblEQ", "=", locator, null);
                LblCount2_ = new Label("ctl00_phG_tab_t2_formF_edCury_pnlRate_rf_lblCount2", "1.000", locator, null);
                LblEQ2_ = new Label("ctl00_phG_tab_t2_formF_edCury_pnlRate_rf_lblEQ2", "=", locator, null);
                DataMemberName = "_SOShipment_CurrencyInfo_";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phG_tab_t2_formF_edCury_pnlRate_btnOk", "OK", "ctl00_phG_tab_t2_formF_edCury_pnlRate_rf");
                }
            }
        }
        
        public class c_currentdocument_formcarrierrates : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit ShipmentWeight { get; }
			public Label ShipmentWeightLabel { get; }
			public PXNumberEdit PackageWeight { get; }
			public Label PackageWeightLabel { get; }
            
            public c_currentdocument_formcarrierrates(string locator, string name) : 
                    base(locator, name)
            {
                ShipmentWeight = new PXNumberEdit("ctl00_phG_PanelCarrierRates_formCarrierRates_edOrderWeight", "Shipment Weight", locator, null);
                ShipmentWeightLabel = new Label(ShipmentWeight);
                ShipmentWeight.DataField = "ShipmentWeight";
                PackageWeight = new PXNumberEdit("ctl00_phG_PanelCarrierRates_formCarrierRates_PXNumberEdit1", "Package Weight", locator, null);
                PackageWeightLabel = new Label(PackageWeight);
                PackageWeight.DataField = "PackageWeight";
                DataMemberName = "CurrentDocument";
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
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
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
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_formCarrierRates");
                    Prev = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_formCarrierRates");
                    Next = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_formCarrierRates");
                    Last = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_formCarrierRates");
                    First1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_formCarrierRates");
                    Prev1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_formCarrierRates");
                    Next1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_formCarrierRates");
                    Last1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_formCarrierRates");
                    Ok = new Button("ctl00_phG_PanelCarrierRates_PXButtonRatesOK", "OK", "ctl00_phG_PanelCarrierRates_formCarrierRates");
                }
            }
        }
        
        public class c_currentdocument_formi : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector IntercompanyPOReceiptNbr { get; }
			public Label IntercompanyPOReceiptNbrLabel { get; }
			public CheckBox ExcludeFromIntercompanyProc { get; }
			public Label ExcludeFromIntercompanyProcLabel { get; }
            
            public c_currentdocument_formi(string locator, string name) : 
                    base(locator, name)
            {
                IntercompanyPOReceiptNbr = new Selector("ctl00_phG_tab_t2_formI_edIntercompanyPOReceiptNbr", "Related PO Receipt Nbr.", locator, null);
                IntercompanyPOReceiptNbrLabel = new Label(IntercompanyPOReceiptNbr);
                IntercompanyPOReceiptNbr.DataField = "IntercompanyPOReceiptNbr";
                ExcludeFromIntercompanyProc = new CheckBox("ctl00_phG_tab_t2_formI_chkExcludeFromIntercompanyProc", "Exclude from Intercompany Processing", locator, null);
                ExcludeFromIntercompanyProcLabel = new Label(ExcludeFromIntercompanyProc);
                ExcludeFromIntercompanyProc.DataField = "ExcludeFromIntercompanyProc";
                DataMemberName = "CurrentDocument";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ShopforRates()
            {
                Buttons.ShopforRates.Click();
            }
            
            public virtual void Unnamed()
            {
                Buttons.Unnamed.Click();
            }
            
            public virtual void Viewbase()
            {
                Buttons.Viewbase.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button ShopforRates { get; }
			public Button Unnamed { get; }
			public Button Viewbase { get; }
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t2_formB_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_formI");
                    ShopforRates = new Button("ctl00_phG_tab_t2_formF_shopRates", "Shop for Rates", "ctl00_phG_tab_t2_formI");
                    Unnamed = new Button("ctl00_phG_tab_t2_formF_edCury_rateB", "0", "ctl00_phG_tab_t2_formI");
                    Viewbase = new Button("ctl00_phG_tab_t2_formF_edCury_curyB", "View base", "ctl00_phG_tab_t2_formI");
                    Ok = new Button("ctl00_phG_tab_t2_formF_edCury_pnlRate_btnOk", "OK", "ctl00_phG_tab_t2_formI");
                }
            }
        }
        
        public class c_currentdocument_formf : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector ShipVia { get; }
			public Label ShipViaLabel { get; }
			public CheckBox WillCall { get; }
			public Label WillCallLabel { get; }
			public DropDown FreightClass { get; }
			public Label FreightClassLabel { get; }
			public Selector FOBPoint { get; }
			public Label FOBPointLabel { get; }
			public Selector ShipTermsID { get; }
			public Label ShipTermsIDLabel { get; }
			public Selector ShipZoneID { get; }
			public Label ShipZoneIDLabel { get; }
			public DropDown TermsOfSale { get; }
			public Label TermsOfSaleLabel { get; }
			public PXTextEdit DHLBillingRef { get; }
			public Label DHLBillingRefLabel { get; }
			public CheckBox SkipAddressVerification { get; }
			public Label SkipAddressVerificationLabel { get; }
			public DropDown DeliveryConfirmation { get; }
			public Label DeliveryConfirmationLabel { get; }
			public DropDown EndorsementService { get; }
			public Label EndorsementServiceLabel { get; }
			public CheckBox Resedential { get; }
			public Label ResedentialLabel { get; }
			public CheckBox SaturdayDelivery { get; }
			public Label SaturdayDeliveryLabel { get; }
			public CheckBox UseCustomerAccount { get; }
			public Label UseCustomerAccountLabel { get; }
			public CheckBox Insurance { get; }
			public Label InsuranceLabel { get; }
			public CheckBox GroundCollect { get; }
			public Label GroundCollectLabel { get; }
			public Selector CuryID { get; }
			public Label CuryIDLabel { get; }
			public CheckBoxButton CuryViewState { get; }
			public Label CuryViewStateLabel { get; }
			public PXNumberEdit CuryFreightCost { get; }
			public Label CuryFreightCostLabel { get; }
			public CheckBox OverrideFreightAmount { get; }
			public Label OverrideFreightAmountLabel { get; }
			public DropDown FreightAmountSource { get; }
			public Label FreightAmountSourceLabel { get; }
			public PXNumberEdit CuryFreightAmt { get; }
			public Label CuryFreightAmtLabel { get; }
			public Label LblCount_ { get; }
			public Label LblEQ_ { get; }
			public Label LblCount2_ { get; }
			public Label LblEQ2_ { get; }
            
            public c_currentdocument_formf(string locator, string name) : 
                    base(locator, name)
            {
                ShipVia = new Selector("ctl00_phG_tab_t2_formF_edShipVia", "Ship Via", locator, null);
                ShipViaLabel = new Label(ShipVia);
                ShipVia.DataField = "ShipVia";
                WillCall = new CheckBox("ctl00_phG_tab_t2_formF_edWillCall", "Will Call", locator, null);
                WillCallLabel = new Label(WillCall);
                WillCall.DataField = "WillCall";
                FreightClass = new DropDown("ctl00_phG_tab_t2_formF_edFreightClass", "Freight Class", locator, null);
                FreightClassLabel = new Label(FreightClass);
                FreightClass.DataField = "FreightClass";
                FreightClass.Items.Add("50", "50");
                FreightClass.Items.Add("55", "55");
                FreightClass.Items.Add("60", "60");
                FreightClass.Items.Add("65", "65");
                FreightClass.Items.Add("70", "70");
                FreightClass.Items.Add("77.5", "77.5");
                FreightClass.Items.Add("85", "85");
                FreightClass.Items.Add("92.5", "92.5");
                FreightClass.Items.Add("100", "100");
                FreightClass.Items.Add("110", "110");
                FreightClass.Items.Add("125", "125");
                FreightClass.Items.Add("150", "150");
                FreightClass.Items.Add("175", "175");
                FreightClass.Items.Add("200", "200");
                FreightClass.Items.Add("250", "250");
                FreightClass.Items.Add("300", "300");
                FreightClass.Items.Add("400", "400");
                FreightClass.Items.Add("500", "500");
                FOBPoint = new Selector("ctl00_phG_tab_t2_formF_edFOBPoint", "FOB Point", locator, null);
                FOBPointLabel = new Label(FOBPoint);
                FOBPoint.DataField = "FOBPoint";
                ShipTermsID = new Selector("ctl00_phG_tab_t2_formF_edShipTermsID", "Shipping Terms", locator, null);
                ShipTermsIDLabel = new Label(ShipTermsID);
                ShipTermsID.DataField = "ShipTermsID";
                ShipZoneID = new Selector("ctl00_phG_tab_t2_formF_edShipZoneID", "Shipping Zone ID", locator, null);
                ShipZoneIDLabel = new Label(ShipZoneID);
                ShipZoneID.DataField = "ShipZoneID";
                TermsOfSale = new DropDown("ctl00_phG_tab_t2_formF_edTermsOfSale", "Terms Of Sale (Incoterm)", locator, null);
                TermsOfSaleLabel = new Label(TermsOfSale);
                TermsOfSale.DataField = "TermsOfSale";
                TermsOfSale.Items.Add("EXW", "EXW - Ex Works");
                TermsOfSale.Items.Add("FCA", "FCA - Free Carrier");
                TermsOfSale.Items.Add("CPT", "CPT - Carriage Paid To");
                TermsOfSale.Items.Add("CIP", "CIP - Carriage and Insurance Paid To");
                TermsOfSale.Items.Add("DAT", "DAT - Delivered at Terminal");
                TermsOfSale.Items.Add("DAP", "DAP - Delivered at Place");
                TermsOfSale.Items.Add("DDP", "DDP - Delivered Duty Paid");
                TermsOfSale.Items.Add("DDU", "DDU - Delivered Duty Un-Paid");
                TermsOfSale.Items.Add("FAS", "FAS - Free Alongside Ship");
                TermsOfSale.Items.Add("FOB", "FOB - Free on Board");
                TermsOfSale.Items.Add("CFR", "CFR - Cost and Freight");
                TermsOfSale.Items.Add("CIF", "CIF - Cost Insurance and Freight");
                DHLBillingRef = new PXTextEdit("ctl00_phG_tab_t2_formF_edDHLBillingRef", "Billing Reference # (DHL)", locator, null);
                DHLBillingRefLabel = new Label(DHLBillingRef);
                DHLBillingRef.DataField = "DHLBillingRef";
                SkipAddressVerification = new CheckBox("ctl00_phG_tab_t2_formF_edSkipAddressVerification", "Skip Address Verification", locator, null);
                SkipAddressVerificationLabel = new Label(SkipAddressVerification);
                SkipAddressVerification.DataField = "SkipAddressVerification";
                DeliveryConfirmation = new DropDown("ctl00_phG_tab_t2_formF_edDeliveryConfirmation", "Delivery Confirmation", locator, null);
                DeliveryConfirmationLabel = new Label(DeliveryConfirmation);
                DeliveryConfirmation.DataField = "DeliveryConfirmation";
                DeliveryConfirmation.Items.Add("NONE", "None");
                DeliveryConfirmation.Items.Add("NO_SIGNATURE", "No Signature");
                DeliveryConfirmation.Items.Add("SIGNATURE", "Signature");
                DeliveryConfirmation.Items.Add("ADULT_SIGNATURE", "Adult Signature");
                EndorsementService = new DropDown("ctl00_phG_tab_t2_formF_edEndorsementService", "Endorsement", locator, null);
                EndorsementServiceLabel = new Label(EndorsementService);
                EndorsementService.DataField = "EndorsementService";
                EndorsementService.Items.Add("NONE", "No Endorsement Service");
                EndorsementService.Items.Add("ADDRESS_SERVICE_REQUESTED", "Address Service Requested");
                EndorsementService.Items.Add("FORWARDING_SERVICE_REQUESTED", "Forwarding Service Requested");
                EndorsementService.Items.Add("CHANGE_SERVICE_REQUESTED", "Change Service Requested");
                EndorsementService.Items.Add("RETURN_SERVICE_REQUESTED", "Return Service Requested");
                EndorsementService.Items.Add("LEAVE_IF_NO_RESPONSE", "Leave if No Response");
                Resedential = new CheckBox("ctl00_phG_tab_t2_formF_chkResedential", "Residential Delivery", locator, null);
                ResedentialLabel = new Label(Resedential);
                Resedential.DataField = "Resedential";
                SaturdayDelivery = new CheckBox("ctl00_phG_tab_t2_formF_chkSaturdayDelivery", "Saturday Delivery", locator, null);
                SaturdayDeliveryLabel = new Label(SaturdayDelivery);
                SaturdayDelivery.DataField = "SaturdayDelivery";
                UseCustomerAccount = new CheckBox("ctl00_phG_tab_t2_formF_chkUseCustomerAccount", "Use Customer\'s Account", locator, null);
                UseCustomerAccountLabel = new Label(UseCustomerAccount);
                UseCustomerAccount.DataField = "UseCustomerAccount";
                Insurance = new CheckBox("ctl00_phG_tab_t2_formF_chkInsurance", "Insurance", locator, null);
                InsuranceLabel = new Label(Insurance);
                Insurance.DataField = "Insurance";
                GroundCollect = new CheckBox("ctl00_phG_tab_t2_formF_chkGroundCollect", "Ground Collect", locator, null);
                GroundCollectLabel = new Label(GroundCollect);
                GroundCollect.DataField = "GroundCollect";
                CuryID = new Selector("ctl00_phG_tab_t2_formF_edCury_cury", "Cury ID", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                CuryViewState = new CheckBoxButton("ctl00_phG_tab_t2_formF_edCury_curyB", "CuryViewState", locator, null);
                CuryViewStateLabel = new Label(CuryViewState);
                CuryViewState.DataField = "CuryViewState";
                CuryFreightCost = new PXNumberEdit("ctl00_phG_tab_t2_formF_edCuryFreightCost", "Freight Cost", locator, null);
                CuryFreightCostLabel = new Label(CuryFreightCost);
                CuryFreightCost.DataField = "CuryFreightCost";
                OverrideFreightAmount = new CheckBox("ctl00_phG_tab_t2_formF_chkOverrideFreightAmount", "Override Freight Price", locator, null);
                OverrideFreightAmountLabel = new Label(OverrideFreightAmount);
                OverrideFreightAmount.DataField = "OverrideFreightAmount";
                FreightAmountSource = new DropDown("ctl00_phG_tab_t2_formF_edFreightAmountSource", "Invoice Freight Price Based On", locator, null);
                FreightAmountSourceLabel = new Label(FreightAmountSource);
                FreightAmountSource.DataField = "FreightAmountSource";
                FreightAmountSource.Items.Add("S", "Shipment");
                FreightAmountSource.Items.Add("O", "Sales Order");
                CuryFreightAmt = new PXNumberEdit("ctl00_phG_tab_t2_formF_edCuryFreightAmt", "Freight Price", locator, null);
                CuryFreightAmtLabel = new Label(CuryFreightAmt);
                CuryFreightAmt.DataField = "CuryFreightAmt";
                LblCount_ = new Label("ctl00_phG_tab_t2_formF_edCury_pnlRate_rf_lblCount", "1.000", locator, null);
                LblEQ_ = new Label("ctl00_phG_tab_t2_formF_edCury_pnlRate_rf_lblEQ", "=", locator, null);
                LblCount2_ = new Label("ctl00_phG_tab_t2_formF_edCury_pnlRate_rf_lblCount2", "1.000", locator, null);
                LblEQ2_ = new Label("ctl00_phG_tab_t2_formF_edCury_pnlRate_rf_lblEQ2", "=", locator, null);
                DataMemberName = "CurrentDocument";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ShopforRates()
            {
                Buttons.ShopforRates.Click();
            }
            
            public virtual void Unnamed()
            {
                Buttons.Unnamed.Click();
            }
            
            public virtual void Viewbase()
            {
                Buttons.Viewbase.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ShopforRates { get; }
			public Button Unnamed { get; }
			public Button Viewbase { get; }
			public Button Ok { get; }
			public Button AddressLookup { get; }
                
                public PxButtonCollection()
                {
                    ShopforRates = new Button("ctl00_phG_tab_t2_formF_shopRates", "Shop for Rates", "ctl00_phG_tab_t2_formF");
                    Unnamed = new Button("ctl00_phG_tab_t2_formF_edCury_rateB", "0", "ctl00_phG_tab_t2_formF");
                    Viewbase = new Button("ctl00_phG_tab_t2_formF_edCury_curyB", "View base", "ctl00_phG_tab_t2_formF");
                    Ok = new Button("ctl00_phG_tab_t2_formF_edCury_pnlRate_btnOk", "OK", "ctl00_phG_tab_t2_formF");
                    AddressLookup = new Button("ctl00_phG_tab_t2_formB_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_formF");
                }
            }
        }
        
        public class c_currentdocument_gridsm : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox Installed { get; }
			public Label InstalledLabel { get; }
            
            public c_currentdocument_gridsm(string locator, string name) : 
                    base(locator, name)
            {
                Installed = new CheckBox("ctl00_phG_tab_t2_gridSM_edInstalled", "Installed", locator, null);
                InstalledLabel = new Label(Installed);
                Installed.DataField = "Installed";
                DataMemberName = "CurrentDocument";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ShopforRates()
            {
                Buttons.ShopforRates.Click();
            }
            
            public virtual void Unnamed()
            {
                Buttons.Unnamed.Click();
            }
            
            public virtual void Viewbase()
            {
                Buttons.Viewbase.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button ShopforRates { get; }
			public Button Unnamed { get; }
			public Button Viewbase { get; }
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t2_formB_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_gridSM");
                    ShopforRates = new Button("ctl00_phG_tab_t2_formF_shopRates", "Shop for Rates", "ctl00_phG_tab_t2_gridSM");
                    Unnamed = new Button("ctl00_phG_tab_t2_formF_edCury_rateB", "0", "ctl00_phG_tab_t2_gridSM");
                    Viewbase = new Button("ctl00_phG_tab_t2_formF_edCury_curyB", "View base", "ctl00_phG_tab_t2_gridSM");
                    Ok = new Button("ctl00_phG_tab_t2_formF_edCury_pnlRate_btnOk", "OK", "ctl00_phG_tab_t2_gridSM");
                }
            }
        }
        
        public class c_transactions_grid : Grid<c_transactions_grid.c_grid_row, c_transactions_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            private Label _StatusBar = new Label("ctl00_phG_tab_t0_grid_ab_tlb_ul", "Status Bar", "ctl00_phG_tab_t0_grid", null);
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_transactions_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t0_grid");
                DataMemberName = "Transactions";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t0_grid_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual Label StatusBar
            {
                get
                {
                    return _StatusBar;
                }
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
            
            public virtual void LineDetails()
            {
                ToolBar.LineDetails.Click();
            }
            
            public virtual void SelectSO()
            {
                ToolBar.SelectSO.Click();
            }
            
            public virtual void InventorySummary()
            {
                ToolBar.InventorySummary.Click();
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
			public ToolBarButtonGrid LineDetails { get; }
			public ToolBarButtonGrid SelectSO { get; }
			public ToolBarButtonGrid InventorySummary { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    FormView = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'EditRecord\']", "Switch Between Grid and Form", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    LineDetails = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div:textEqual(\"Line Details\") > div[data-type=\'" +
                            "button\']", "Line Details", locator, null);
                    SelectSO = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'SelectSO\']", "Add Order", locator, null);
                    InventorySummary = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'InventorySummary\']", "Inventory Summary", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXTextEdit Availability { get; }
			public PXTextEdit ShipmentNbr { get; }
			public PXNumberEdit LineNbr { get; }
			public PXTextEdit OrigOrderType { get; }
			public Selector OrigOrderNbr { get; }
			public PXNumberEdit OrigLineNbr { get; }
			public Selector InventoryID { get; }
			public Selector SubItemID { get; }
			public CheckBox IsFree { get; }
			public Selector SiteID { get; }
			public Selector LocationID { get; }
			public Selector UOM { get; }
			public PXTextEdit AssociatedOrderLineNbr { get; }
			public PXTextEdit GiftMessage { get; }
			public PXNumberEdit ShippedQty { get; }
			public PXNumberEdit BaseShippedQty { get; }
			public PXNumberEdit OriginalShippedQty { get; }
			public PXNumberEdit OrigOrderQty { get; }
			public PXNumberEdit OpenOrderQty { get; }
			public PXNumberEdit UnassignedQty { get; }
			public PXNumberEdit PackedQty { get; }
			public PXNumberEdit CompleteQtyMin { get; }
			public Selector LotSerialNbr { get; }
			public DropDown ShipComplete { get; }
			public DateSelector ExpireDate { get; }
			public Selector ReasonCode { get; }
			public PXTextEdit TranDesc { get; }
			public PXTextEdit ShipmentType { get; }
                
                public c_grid_row(c_transactions_grid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Availability = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edAvailability", "Availability", grid.Locator, "Availability");
                    Availability.DataField = "Availability";
                    ShipmentNbr = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edShipmentNbr", "Shipment Nbr.", grid.Locator, "ShipmentNbr");
                    ShipmentNbr.DataField = "ShipmentNbr";
                    LineNbr = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edLineNbr", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    OrigOrderType = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edOrigOrderType", "Order Type", grid.Locator, "OrigOrderType");
                    OrigOrderType.DataField = "OrigOrderType";
                    OrigOrderNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edOrigOrderNbr", "Order Nbr.", grid.Locator, "OrigOrderNbr");
                    OrigOrderNbr.DataField = "OrigOrderNbr";
                    OrigLineNbr = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Order Line Nbr.", grid.Locator, "OrigLineNbr");
                    OrigLineNbr.DataField = "OrigLineNbr";
                    InventoryID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edInventoryID", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SubItemID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSubItemID", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    IsFree = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkIsFree", "Free Item", grid.Locator, "IsFree");
                    IsFree.DataField = "IsFree";
                    SiteID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSiteID", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    LocationID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edLocationID", "Location", grid.Locator, "LocationID");
                    LocationID.DataField = "LocationID";
                    UOM = new Selector("_ctl00_phG_tab_t0_grid_lv0_edUOM", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    AssociatedOrderLineNbr = new PXTextEdit("ctl00_phG_tab_t0_grid", "Associated Order Line Nbr.", grid.Locator, "AssociatedOrderLineNbr");
                    AssociatedOrderLineNbr.DataField = "AssociatedOrderLineNbr";
                    GiftMessage = new PXTextEdit("ctl00_phG_tab_t0_grid", "Gift Message", grid.Locator, "GiftMessage");
                    GiftMessage.DataField = "GiftMessage";
                    ShippedQty = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edShippedQty", "Shipped Qty.", grid.Locator, "ShippedQty");
                    ShippedQty.DataField = "ShippedQty";
                    BaseShippedQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Base Shipped Qty.", grid.Locator, "BaseShippedQty");
                    BaseShippedQty.DataField = "BaseShippedQty";
                    OriginalShippedQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Original Qty.", grid.Locator, "OriginalShippedQty");
                    OriginalShippedQty.DataField = "OriginalShippedQty";
                    OrigOrderQty = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edOrigOrderQty", "Ordered Qty.", grid.Locator, "OrigOrderQty");
                    OrigOrderQty.DataField = "OrigOrderQty";
                    OpenOrderQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Open Qty.", grid.Locator, "OpenOrderQty");
                    OpenOrderQty.DataField = "OpenOrderQty";
                    UnassignedQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Unassigned Qty.", grid.Locator, "UnassignedQty");
                    UnassignedQty.DataField = "UnassignedQty";
                    PackedQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Packed Qty.", grid.Locator, "PackedQty");
                    PackedQty.DataField = "PackedQty";
                    CompleteQtyMin = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Undership Threshold (%)", grid.Locator, "CompleteQtyMin");
                    CompleteQtyMin.DataField = "CompleteQtyMin";
                    LotSerialNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edLotSerialNbr", "Lot/Serial Nbr.", grid.Locator, "LotSerialNbr");
                    LotSerialNbr.DataField = "LotSerialNbr";
                    ShipComplete = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edShipComplete", "Shipping Rule", grid.Locator, "ShipComplete");
                    ShipComplete.DataField = "ShipComplete";
                    ShipComplete.Items.Add("C", "Ship Complete");
                    ShipComplete.Items.Add("B", "Back Order Allowed");
                    ShipComplete.Items.Add("L", "Cancel Remainder");
                    ExpireDate = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_edExpireDate", "Expiration Date", grid.Locator, "ExpireDate");
                    ExpireDate.DataField = "ExpireDate";
                    ReasonCode = new Selector("_ctl00_phG_tab_t0_grid_lv0_edReasonCode", "Reason Code", grid.Locator, "ReasonCode");
                    ReasonCode.DataField = "ReasonCode";
                    TranDesc = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edTranDesc", "Description", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    ShipmentType = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edShipmentType", "ShipmentType", grid.Locator, "ShipmentType");
                    ShipmentType.DataField = "ShipmentType";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXTextEditColumnFilter Availability { get; }
				public PXTextEditColumnFilter ShipmentNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXTextEditColumnFilter OrigOrderType { get; }
				public SelectorColumnFilter OrigOrderNbr { get; }
				public PXNumberEditColumnFilter OrigLineNbr { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public CheckBoxColumnFilter IsFree { get; }
				public SelectorColumnFilter SiteID { get; }
				public SelectorColumnFilter LocationID { get; }
				public SelectorColumnFilter UOM { get; }
				public PXTextEditColumnFilter AssociatedOrderLineNbr { get; }
				public PXTextEditColumnFilter GiftMessage { get; }
				public PXNumberEditColumnFilter ShippedQty { get; }
				public PXNumberEditColumnFilter BaseShippedQty { get; }
				public PXNumberEditColumnFilter OriginalShippedQty { get; }
				public PXNumberEditColumnFilter OrigOrderQty { get; }
				public PXNumberEditColumnFilter OpenOrderQty { get; }
				public PXNumberEditColumnFilter UnassignedQty { get; }
				public PXNumberEditColumnFilter PackedQty { get; }
				public PXNumberEditColumnFilter CompleteQtyMin { get; }
				public SelectorColumnFilter LotSerialNbr { get; }
				public DropDownColumnFilter ShipComplete { get; }
				public DateSelectorColumnFilter ExpireDate { get; }
				public SelectorColumnFilter ReasonCode { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public PXTextEditColumnFilter ShipmentType { get; }
                
                public c_grid_header(c_transactions_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Availability = new PXTextEditColumnFilter(grid.Row.Availability);
                    ShipmentNbr = new PXTextEditColumnFilter(grid.Row.ShipmentNbr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    OrigOrderType = new PXTextEditColumnFilter(grid.Row.OrigOrderType);
                    OrigOrderNbr = new SelectorColumnFilter(grid.Row.OrigOrderNbr);
                    OrigLineNbr = new PXNumberEditColumnFilter(grid.Row.OrigLineNbr);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    IsFree = new CheckBoxColumnFilter(grid.Row.IsFree);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    LocationID = new SelectorColumnFilter(grid.Row.LocationID);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    AssociatedOrderLineNbr = new PXTextEditColumnFilter(grid.Row.AssociatedOrderLineNbr);
                    GiftMessage = new PXTextEditColumnFilter(grid.Row.GiftMessage);
                    ShippedQty = new PXNumberEditColumnFilter(grid.Row.ShippedQty);
                    BaseShippedQty = new PXNumberEditColumnFilter(grid.Row.BaseShippedQty);
                    OriginalShippedQty = new PXNumberEditColumnFilter(grid.Row.OriginalShippedQty);
                    OrigOrderQty = new PXNumberEditColumnFilter(grid.Row.OrigOrderQty);
                    OpenOrderQty = new PXNumberEditColumnFilter(grid.Row.OpenOrderQty);
                    UnassignedQty = new PXNumberEditColumnFilter(grid.Row.UnassignedQty);
                    PackedQty = new PXNumberEditColumnFilter(grid.Row.PackedQty);
                    CompleteQtyMin = new PXNumberEditColumnFilter(grid.Row.CompleteQtyMin);
                    LotSerialNbr = new SelectorColumnFilter(grid.Row.LotSerialNbr);
                    ShipComplete = new DropDownColumnFilter(grid.Row.ShipComplete);
                    ExpireDate = new DateSelectorColumnFilter(grid.Row.ExpireDate);
                    ReasonCode = new SelectorColumnFilter(grid.Row.ReasonCode);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    ShipmentType = new PXTextEditColumnFilter(grid.Row.ShipmentType);
                }
            }
        }
        
        public class c_transactions_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit OrigOrderType { get; }
			public Label OrigOrderTypeLabel { get; }
			public Selector OrigOrderNbr { get; }
			public Label OrigOrderNbrLabel { get; }
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public CheckBox IsFree { get; }
			public Label IsFreeLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public Selector LocationID { get; }
			public Label LocationIDLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public PXNumberEdit ShippedQty { get; }
			public Label ShippedQtyLabel { get; }
			public PXNumberEdit OrigOrderQty { get; }
			public Label OrigOrderQtyLabel { get; }
			public PXTextEdit ShipmentNbr { get; }
			public Label ShipmentNbrLabel { get; }
			public PXNumberEdit LineNbr { get; }
			public Label LineNbrLabel { get; }
			public Selector LotSerialNbr { get; }
			public Label LotSerialNbrLabel { get; }
			public DropDown ShipComplete { get; }
			public Label ShipCompleteLabel { get; }
			public DateSelector ExpireDate { get; }
			public Label ExpireDateLabel { get; }
			public Selector ReasonCode { get; }
			public Label ReasonCodeLabel { get; }
			public PXTextEdit TranDesc { get; }
			public Label TranDescLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public PXTextEdit ShipmentType { get; }
			public Label ShipmentTypeLabel { get; }
			public PXTextEdit Availability { get; }
			public Label AvailabilityLabel { get; }
            
            public c_transactions_lv0(string locator, string name) : 
                    base(locator, name)
            {
                OrigOrderType = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edOrigOrderType", "Order Type", locator, null);
                OrigOrderTypeLabel = new Label(OrigOrderType);
                OrigOrderType.DataField = "OrigOrderType";
                OrigOrderNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edOrigOrderNbr", "Order Nbr.", locator, null);
                OrigOrderNbrLabel = new Label(OrigOrderNbr);
                OrigOrderNbr.DataField = "OrigOrderNbr";
                InventoryID = new Selector("ctl00_phG_tab_t0_grid_lv0_edInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                SubItemID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSubItemID", "Subitem", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                IsFree = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkIsFree", "Free Item", locator, null);
                IsFreeLabel = new Label(IsFree);
                IsFree.DataField = "IsFree";
                SiteID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSiteID", "Warehouse", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                LocationID = new Selector("ctl00_phG_tab_t0_grid_lv0_edLocationID", "Location", locator, null);
                LocationIDLabel = new Label(LocationID);
                LocationID.DataField = "LocationID";
                UOM = new Selector("ctl00_phG_tab_t0_grid_lv0_edUOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                ShippedQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edShippedQty", "Shipped Qty.", locator, null);
                ShippedQtyLabel = new Label(ShippedQty);
                ShippedQty.DataField = "ShippedQty";
                OrigOrderQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edOrigOrderQty", "Ordered Qty.", locator, null);
                OrigOrderQtyLabel = new Label(OrigOrderQty);
                OrigOrderQty.DataField = "OrigOrderQty";
                ShipmentNbr = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edShipmentNbr", "Shipment Nbr.", locator, null);
                ShipmentNbrLabel = new Label(ShipmentNbr);
                ShipmentNbr.DataField = "ShipmentNbr";
                LineNbr = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edLineNbr", "Line Nbr.", locator, null);
                LineNbrLabel = new Label(LineNbr);
                LineNbr.DataField = "LineNbr";
                LotSerialNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edLotSerialNbr", "Lot/Serial Nbr.", locator, null);
                LotSerialNbrLabel = new Label(LotSerialNbr);
                LotSerialNbr.DataField = "LotSerialNbr";
                ShipComplete = new DropDown("ctl00_phG_tab_t0_grid_lv0_edShipComplete", "Shipping Rule", locator, null);
                ShipCompleteLabel = new Label(ShipComplete);
                ShipComplete.DataField = "ShipComplete";
                ShipComplete.Items.Add("C", "Ship Complete");
                ShipComplete.Items.Add("B", "Back Order Allowed");
                ShipComplete.Items.Add("L", "Cancel Remainder");
                ExpireDate = new DateSelector("ctl00_phG_tab_t0_grid_lv0_edExpireDate", "Expiration Date", locator, null);
                ExpireDateLabel = new Label(ExpireDate);
                ExpireDate.DataField = "ExpireDate";
                ReasonCode = new Selector("ctl00_phG_tab_t0_grid_lv0_edReasonCode", "Reason Code", locator, null);
                ReasonCodeLabel = new Label(ReasonCode);
                ReasonCode.DataField = "ReasonCode";
                TranDesc = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edTranDesc", "Description", locator, null);
                TranDescLabel = new Label(TranDesc);
                TranDesc.DataField = "TranDesc";
                Es = new Selector("ctl00_phG_tab_t0_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                ShipmentType = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edShipmentType", "Shipment Type", locator, null);
                ShipmentTypeLabel = new Label(ShipmentType);
                ShipmentType.DataField = "ShipmentType";
                Availability = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edAvailability", "Availability", locator, null);
                AvailabilityLabel = new Label(Availability);
                Availability.DataField = "Availability";
                DataMemberName = "Transactions";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void InventoryIDEdit()
            {
                Buttons.InventoryIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button InventoryIDEdit { get; }
                
                public PxButtonCollection()
                {
                    InventoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edInventoryID\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "InventoryIDEdit", "ctl00_phG_tab_t0_grid_lv0");
                    InventoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_shipping_address_formb : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox OverrideAddress { get; }
			public Label OverrideAddressLabel { get; }
			public PXTextEdit AddressLine1 { get; }
			public Label AddressLine1Label { get; }
			public PXTextEdit AddressLine2 { get; }
			public Label AddressLine2Label { get; }
			public PXTextEdit City { get; }
			public Label CityLabel { get; }
			public Selector CountryID { get; }
			public Label CountryIDLabel { get; }
			public Selector State { get; }
			public Label StateLabel { get; }
			public PXTextEdit PostalCode { get; }
			public Label PostalCodeLabel { get; }
			public PXNumberEdit Latitude { get; }
			public Label LatitudeLabel { get; }
			public PXNumberEdit Longitude { get; }
			public Label LongitudeLabel { get; }
			public CheckBox IsValidated { get; }
			public Label IsValidatedLabel { get; }
            
            public c_shipping_address_formb(string locator, string name) : 
                    base(locator, name)
            {
                OverrideAddress = new CheckBox("ctl00_phG_tab_t2_formB_chkOverrideAddress", "Override Address", locator, null);
                OverrideAddressLabel = new Label(OverrideAddress);
                OverrideAddress.DataField = "OverrideAddress";
                AddressLine1 = new PXTextEdit("ctl00_phG_tab_t2_formB_edAddressLine1", "Address Line 1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_tab_t2_formB_edAddressLine2", "Address Line 2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                City = new PXTextEdit("ctl00_phG_tab_t2_formB_edCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                CountryID = new Selector("ctl00_phG_tab_t2_formB_edCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                State = new Selector("ctl00_phG_tab_t2_formB_edState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_tab_t2_formB_edPostalCode", "Postal Code", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                Latitude = new PXNumberEdit("ctl00_phG_tab_t2_formB_edLatitude", "Latitude", locator, null);
                LatitudeLabel = new Label(Latitude);
                Latitude.DataField = "Latitude";
                Longitude = new PXNumberEdit("ctl00_phG_tab_t2_formB_edLongitude", "Longitude", locator, null);
                LongitudeLabel = new Label(Longitude);
                Longitude.DataField = "Longitude";
                IsValidated = new CheckBox("ctl00_phG_tab_t2_formB_chkIsValidated", "Validated", locator, null);
                IsValidatedLabel = new Label(IsValidated);
                IsValidated.DataField = "IsValidated";
                DataMemberName = "Shipping_Address";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ShopforRates()
            {
                Buttons.ShopforRates.Click();
            }
            
            public virtual void Unnamed()
            {
                Buttons.Unnamed.Click();
            }
            
            public virtual void Viewbase()
            {
                Buttons.Viewbase.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button ShopforRates { get; }
			public Button Unnamed { get; }
			public Button Viewbase { get; }
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t2_formB_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_formB");
                    ShopforRates = new Button("ctl00_phG_tab_t2_formF_shopRates", "Shop for Rates", "ctl00_phG_tab_t2_formB");
                    Unnamed = new Button("ctl00_phG_tab_t2_formF_edCury_rateB", "0", "ctl00_phG_tab_t2_formB");
                    Viewbase = new Button("ctl00_phG_tab_t2_formF_edCury_curyB", "View base", "ctl00_phG_tab_t2_formB");
                    Ok = new Button("ctl00_phG_tab_t2_formF_edCury_pnlRate_btnOk", "OK", "ctl00_phG_tab_t2_formB");
                }
            }
        }
        
        public class c_shipping_contact_formd : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox OverrideContact { get; }
			public Label OverrideContactLabel { get; }
			public PXTextEdit FullName { get; }
			public Label FullNameLabel { get; }
			public PXTextEdit Attention { get; }
			public Label AttentionLabel { get; }
			public PXTextEdit Phone1 { get; }
			public Label Phone1Label { get; }
			public EmailEdit Email { get; }
			public Label EmailLabel { get; }
            
            public c_shipping_contact_formd(string locator, string name) : 
                    base(locator, name)
            {
                OverrideContact = new CheckBox("ctl00_phG_tab_t2_formD_chkOverrideContact", "Override Contact", locator, null);
                OverrideContactLabel = new Label(OverrideContact);
                OverrideContact.DataField = "OverrideContact";
                FullName = new PXTextEdit("ctl00_phG_tab_t2_formD_edFullName", "Account Name", locator, null);
                FullNameLabel = new Label(FullName);
                FullName.DataField = "FullName";
                Attention = new PXTextEdit("ctl00_phG_tab_t2_formD_edAttention", "Attention", locator, null);
                AttentionLabel = new Label(Attention);
                Attention.DataField = "Attention";
                Phone1 = new PXTextEdit("ctl00_phG_tab_t2_formD_edPhone1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Email = new EmailEdit("ctl00_phG_tab_t2_formD_edEmail", "Email", locator, null);
                EmailLabel = new Label(Email);
                Email.DataField = "Email";
                DataMemberName = "Shipping_Contact";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ShopforRates()
            {
                Buttons.ShopforRates.Click();
            }
            
            public virtual void Unnamed()
            {
                Buttons.Unnamed.Click();
            }
            
            public virtual void Viewbase()
            {
                Buttons.Viewbase.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button ShopforRates { get; }
			public Button Unnamed { get; }
			public Button Viewbase { get; }
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t2_formB_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_formD");
                    ShopforRates = new Button("ctl00_phG_tab_t2_formF_shopRates", "Shop for Rates", "ctl00_phG_tab_t2_formD");
                    Unnamed = new Button("ctl00_phG_tab_t2_formF_edCury_rateB", "0", "ctl00_phG_tab_t2_formD");
                    Viewbase = new Button("ctl00_phG_tab_t2_formF_edCury_curyB", "View base", "ctl00_phG_tab_t2_formD");
                    Ok = new Button("ctl00_phG_tab_t2_formF_edCury_pnlRate_btnOk", "OK", "ctl00_phG_tab_t2_formD");
                }
            }
        }
        
        public class c_orderlist_grid5 : Grid<c_orderlist_grid5.c_grid_row, c_orderlist_grid5.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_orderlist_grid5(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t1_grid5");
                DataMemberName = "OrderList";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t1_grid5_fe_gf", "FilterForm");
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
            
            public virtual void OrderNbrEdit()
            {
                Buttons.OrderNbrEdit.Click();
            }
            
            public virtual void InvoiceNbrEdit()
            {
                Buttons.InvoiceNbrEdit.Click();
            }
            
            public virtual void InvtRefNbrEdit()
            {
                Buttons.InvtRefNbrEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid5_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid5_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid5_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid5_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid5_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid5_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid5_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid5_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid5_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid5_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_grid5_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button OrderNbrEdit { get; }
			public Button InvoiceNbrEdit { get; }
			public Button InvtRefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    OrderNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_grid5_lv0_edOrderNbr3\'] div[class=\'editBtnCont\'] > d" +
                            "iv > div", "OrderNbrEdit", "ctl00_phG_tab_t1_grid5");
                    OrderNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    InvoiceNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_grid5_lv0_edInvoiceNbr3\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "InvoiceNbrEdit", "ctl00_phG_tab_t1_grid5");
                    InvoiceNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    InvtRefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_grid5_lv0_edInvtRefNbr3\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "InvtRefNbrEdit", "ctl00_phG_tab_t1_grid5");
                    InvtRefNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXTextEdit ShipmentNbr { get; }
			public PXTextEdit OrderType { get; }
			public Selector OrderNbr { get; }
			public PXNumberEdit ShipmentQty { get; }
			public PXNumberEdit ShipmentWeight { get; }
			public PXNumberEdit ShipmentVolume { get; }
			public DropDown InvoiceType { get; }
			public Selector InvoiceNbr { get; }
			public DropDown InvtDocType { get; }
			public Selector InvtRefNbr { get; }
			public PXTextEdit ShippingRefNoteID { get; }
                
                public c_grid_row(c_orderlist_grid5 grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    ShipmentNbr = new PXTextEdit("_ctl00_phG_tab_t1_grid5_lv0_edShipmentNbr3", "Shipment Nbr.", grid.Locator, "ShipmentNbr");
                    ShipmentNbr.DataField = "ShipmentNbr";
                    OrderType = new PXTextEdit("_ctl00_phG_tab_t1_grid5_lv0_edOrderType3", "Order Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderNbr = new Selector("_ctl00_phG_tab_t1_grid5_lv0_edOrderNbr3", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    ShipmentQty = new PXNumberEdit("_ctl00_phG_tab_t1_grid5_lv0_edShipmentQty3", "Shipped Qty.", grid.Locator, "ShipmentQty");
                    ShipmentQty.DataField = "ShipmentQty";
                    ShipmentWeight = new PXNumberEdit("ctl00_phG_tab_t1_grid5_en", "Shipped Weight", grid.Locator, "ShipmentWeight");
                    ShipmentWeight.DataField = "ShipmentWeight";
                    ShipmentVolume = new PXNumberEdit("ctl00_phG_tab_t1_grid5_en", "Shipped Volume", grid.Locator, "ShipmentVolume");
                    ShipmentVolume.DataField = "ShipmentVolume";
                    InvoiceType = new DropDown("_ctl00_phG_tab_t1_grid5_lv0_ec", "Invoice Type", grid.Locator, "InvoiceType");
                    InvoiceType.DataField = "InvoiceType";
                    InvoiceType.Items.Add("INV", "Invoice");
                    InvoiceType.Items.Add("DRM", "Debit Memo");
                    InvoiceType.Items.Add("CRM", "Credit Memo");
                    InvoiceType.Items.Add("PMT", "Payment");
                    InvoiceType.Items.Add("RPM", "Voided Payment");
                    InvoiceType.Items.Add("PPM", "Prepayment");
                    InvoiceType.Items.Add("REF", "Customer Refund");
                    InvoiceType.Items.Add("VRF", "Voided Refund");
                    InvoiceType.Items.Add("FCH", "Overdue Charge");
                    InvoiceType.Items.Add("SMB", "Balance WO");
                    InvoiceType.Items.Add("SMC", "Credit WO");
                    InvoiceType.Items.Add("CSL", "Cash Sale");
                    InvoiceType.Items.Add("RCS", "Cash Return");
                    InvoiceNbr = new Selector("_ctl00_phG_tab_t1_grid5_lv0_edInvoiceNbr3", "Invoice Nbr.", grid.Locator, "InvoiceNbr");
                    InvoiceNbr.DataField = "InvoiceNbr";
                    InvtDocType = new DropDown("_ctl00_phG_tab_t1_grid5_lv0_ec", "Inventory Doc. Type", grid.Locator, "InvtDocType");
                    InvtDocType.DataField = "InvtDocType";
                    InvtDocType.Items.Add("I", "Issue");
                    InvtDocType.Items.Add("R", "Receipt");
                    InvtDocType.Items.Add("T", "Transfer");
                    InvtDocType.Items.Add("A", "Adjustment");
                    InvtDocType.Items.Add("P", "Production");
                    InvtDocType.Items.Add("D", "Disassembly");
                    InvtRefNbr = new Selector("_ctl00_phG_tab_t1_grid5_lv0_edInvtRefNbr3", "Inventory Ref. Nbr.", grid.Locator, "InvtRefNbr");
                    InvtRefNbr.DataField = "InvtRefNbr";
                    ShippingRefNoteID = new PXTextEdit("ctl00_phG_tab_t1_grid5_ei", "ShippingRefNoteID", grid.Locator, "ShippingRefNoteID");
                    ShippingRefNoteID.DataField = "ShippingRefNoteID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXTextEditColumnFilter ShipmentNbr { get; }
				public PXTextEditColumnFilter OrderType { get; }
				public SelectorColumnFilter OrderNbr { get; }
				public PXNumberEditColumnFilter ShipmentQty { get; }
				public PXNumberEditColumnFilter ShipmentWeight { get; }
				public PXNumberEditColumnFilter ShipmentVolume { get; }
				public DropDownColumnFilter InvoiceType { get; }
				public SelectorColumnFilter InvoiceNbr { get; }
				public DropDownColumnFilter InvtDocType { get; }
				public SelectorColumnFilter InvtRefNbr { get; }
				public PXTextEditColumnFilter ShippingRefNoteID { get; }
                
                public c_grid_header(c_orderlist_grid5 grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    ShipmentNbr = new PXTextEditColumnFilter(grid.Row.ShipmentNbr);
                    OrderType = new PXTextEditColumnFilter(grid.Row.OrderType);
                    OrderNbr = new SelectorColumnFilter(grid.Row.OrderNbr);
                    ShipmentQty = new PXNumberEditColumnFilter(grid.Row.ShipmentQty);
                    ShipmentWeight = new PXNumberEditColumnFilter(grid.Row.ShipmentWeight);
                    ShipmentVolume = new PXNumberEditColumnFilter(grid.Row.ShipmentVolume);
                    InvoiceType = new DropDownColumnFilter(grid.Row.InvoiceType);
                    InvoiceNbr = new SelectorColumnFilter(grid.Row.InvoiceNbr);
                    InvtDocType = new DropDownColumnFilter(grid.Row.InvtDocType);
                    InvtRefNbr = new SelectorColumnFilter(grid.Row.InvtRefNbr);
                    ShippingRefNoteID = new PXTextEditColumnFilter(grid.Row.ShippingRefNoteID);
                }
            }
        }
        
        public class c_orderlist_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit OrderType { get; }
			public Label OrderTypeLabel { get; }
			public Selector OrderNbr { get; }
			public Label OrderNbrLabel { get; }
			public PXTextEdit ShipmentNbr { get; }
			public Label ShipmentNbrLabel { get; }
			public Selector InvoiceNbr { get; }
			public Label InvoiceNbrLabel { get; }
			public Selector InvtRefNbr { get; }
			public Label InvtRefNbrLabel { get; }
			public PXNumberEdit ShipmentQty { get; }
			public Label ShipmentQtyLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_orderlist_lv0(string locator, string name) : 
                    base(locator, name)
            {
                OrderType = new PXTextEdit("ctl00_phG_tab_t1_grid5_lv0_edOrderType3", "Order Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                OrderNbr = new Selector("ctl00_phG_tab_t1_grid5_lv0_edOrderNbr3", "Order Nbr.", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                ShipmentNbr = new PXTextEdit("ctl00_phG_tab_t1_grid5_lv0_edShipmentNbr3", "Shipment Nbr.", locator, null);
                ShipmentNbrLabel = new Label(ShipmentNbr);
                ShipmentNbr.DataField = "ShipmentNbr";
                InvoiceNbr = new Selector("ctl00_phG_tab_t1_grid5_lv0_edInvoiceNbr3", "Invoice Nbr", locator, null);
                InvoiceNbrLabel = new Label(InvoiceNbr);
                InvoiceNbr.DataField = "InvoiceNbr";
                InvtRefNbr = new Selector("ctl00_phG_tab_t1_grid5_lv0_edInvtRefNbr3", "Invt Ref Nbr", locator, null);
                InvtRefNbrLabel = new Label(InvtRefNbr);
                InvtRefNbr.DataField = "InvtRefNbr";
                ShipmentQty = new PXNumberEdit("ctl00_phG_tab_t1_grid5_lv0_edShipmentQty3", "Shipped Qty.", locator, null);
                ShipmentQtyLabel = new Label(ShipmentQty);
                ShipmentQty.DataField = "ShipmentQty";
                Es = new Selector("ctl00_phG_tab_t1_grid5_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t1_grid5_lv0_ec", "Ec", locator, null);
                DataMemberName = "OrderList";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void OrderNbrEdit()
            {
                Buttons.OrderNbrEdit.Click();
            }
            
            public virtual void InvoiceNbrEdit()
            {
                Buttons.InvoiceNbrEdit.Click();
            }
            
            public virtual void InvtRefNbrEdit()
            {
                Buttons.InvtRefNbrEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button OrderNbrEdit { get; }
			public Button InvoiceNbrEdit { get; }
			public Button InvtRefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    OrderNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_grid5_lv0_edOrderNbr3\'] div[class=\'editBtnCont\'] > d" +
                            "iv > div", "OrderNbrEdit", "ctl00_phG_tab_t1_grid5_lv0");
                    OrderNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    InvoiceNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_grid5_lv0_edInvoiceNbr3\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "InvoiceNbrEdit", "ctl00_phG_tab_t1_grid5_lv0");
                    InvoiceNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    InvtRefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_grid5_lv0_edInvtRefNbr3\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "InvtRefNbrEdit", "ctl00_phG_tab_t1_grid5_lv0");
                    InvtRefNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_packages_gridpackages : Grid<c_packages_gridpackages.c_grid_row, c_packages_gridpackages.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_packages_gridpackages(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t3_gridPackages");
                DataMemberName = "Packages";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t3_gridPackages_fe_gf", "FilterForm");
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
            
            public virtual void RecalculatePackages()
            {
                ToolBar.RecalculatePackages.Click();
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
			public ToolBarButtonGrid RecalculatePackages { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackages_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackages_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackages_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    RecalculatePackages = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackages_at_tlb div[data-cmd=\'RecalculatePackages\']", "Refresh Packages", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackages_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackages_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackages_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackages_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackages_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackages_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackages_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackages_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox Confirmed { get; }
			public Selector BoxID { get; }
			public DropDown PackageType { get; }
			public PXTextEdit Description { get; }
			public PXNumberEdit Weight { get; }
			public PXTextEdit WeightUOM { get; }
			public PXNumberEdit DeclaredValue { get; }
			public PXNumberEdit COD { get; }
			public DropDown StampsAddOns { get; }
			public PXTextEdit TrackNumber { get; }
			public PXTextEdit TrackUrl { get; }
			public PXTextEdit CustomRefNbr1 { get; }
			public PXTextEdit CustomRefNbr2 { get; }
			public DropDown ContentType { get; }
			public PXTextEdit EELPFC { get; }
			public PXTextEdit ContentTypeDesc { get; }
			public PXTextEdit CertificateNumber { get; }
			public PXTextEdit InvoiceNumber { get; }
			public PXTextEdit LicenseNumber { get; }
			public PXTextEdit ShipmentNbr { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_packages_gridpackages grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Confirmed = new CheckBox("ctl00_phG_tab_t3_gridPackages_ef", "Confirmed", grid.Locator, "Confirmed");
                    Confirmed.DataField = "Confirmed";
                    BoxID = new Selector("_ctl00_phG_tab_t3_gridPackages_lv0_edBoxID", "Box ID", grid.Locator, "BoxID");
                    BoxID.DataField = "BoxID";
                    PackageType = new DropDown("_ctl00_phG_tab_t3_gridPackages_lv0_edType", "Type", grid.Locator, "PackageType");
                    PackageType.DataField = "PackageType";
                    PackageType.Items.Add("A", "Auto");
                    PackageType.Items.Add("M", "Manual");
                    Description = new PXTextEdit("_ctl00_phG_tab_t3_gridPackages_lv0_PXTextEdit3", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                    Weight = new PXNumberEdit("_ctl00_phG_tab_t3_gridPackages_lv0_edWeight", "Weight", grid.Locator, "Weight");
                    Weight.DataField = "Weight";
                    WeightUOM = new PXTextEdit("ctl00_phG_tab_t3_gridPackages_ei", "UOM", grid.Locator, "WeightUOM");
                    WeightUOM.DataField = "WeightUOM";
                    DeclaredValue = new PXNumberEdit("_ctl00_phG_tab_t3_gridPackages_lv0_PXNumberEdit6", "Declared Value", grid.Locator, "DeclaredValue");
                    DeclaredValue.DataField = "DeclaredValue";
                    COD = new PXNumberEdit("_ctl00_phG_tab_t3_gridPackages_lv0_PXNumberEdit5", "C.O.D. Amount", grid.Locator, "COD");
                    COD.DataField = "COD";
                    StampsAddOns = new DropDown("_ctl00_phG_tab_t3_gridPackages_lv0_edStampsAddOns", "Stamps Surcharges", grid.Locator, "StampsAddOns");
                    StampsAddOns.DataField = "StampsAddOns";
                    StampsAddOns.Items.Add("USARD", "USPS Restricted Delivery");
                    StampsAddOns.Items.Add("USAESH", "Priority Mail Express delivery on a Sunday/holiday");
                    StampsAddOns.Items.Add("USANDW", "Priority Mail Express no delivery on Saturday");
                    StampsAddOns.Items.Add("USANND", "USPS notice of non-delivery");
                    StampsAddOns.Items.Add("USALAWS", "Mailable Live Animals with charge");
                    StampsAddOns.Items.Add("USASH", "Fragile items");
                    StampsAddOns.Items.Add("USA1030", "Deliver by 10:30 AM");
                    StampsAddOns.Items.Add("SCAHP", "Hidden Postage");
                    TrackNumber = new PXTextEdit("_ctl00_phG_tab_t3_gridPackages_lv0_edTrackNumber", "Tracking Number", grid.Locator, "TrackNumber");
                    TrackNumber.DataField = "TrackNumber";
                    TrackUrl = new PXTextEdit("ctl00_phG_tab_t3_gridPackages_ei", "Tracking URL", grid.Locator, "TrackUrl");
                    TrackUrl.DataField = "TrackUrl";
                    CustomRefNbr1 = new PXTextEdit("_ctl00_phG_tab_t3_gridPackages_lv0_PXTextEdit1", "Custom Ref. Nbr. 1", grid.Locator, "CustomRefNbr1");
                    CustomRefNbr1.DataField = "CustomRefNbr1";
                    CustomRefNbr2 = new PXTextEdit("_ctl00_phG_tab_t3_gridPackages_lv0_PXTextEdit2", "Custom Ref. Nbr. 2", grid.Locator, "CustomRefNbr2");
                    CustomRefNbr2.DataField = "CustomRefNbr2";
                    ContentType = new DropDown("_ctl00_phG_tab_t3_gridPackages_lv0_ec", "Content Type", grid.Locator, "ContentType");
                    ContentType.DataField = "ContentType";
                    EELPFC = new PXTextEdit("ctl00_phG_tab_t3_gridPackages_ei", "EEL/PFC (EasyPost)", grid.Locator, "EELPFC");
                    EELPFC.DataField = "EELPFC";
                    ContentTypeDesc = new PXTextEdit("ctl00_phG_tab_t3_gridPackages_ea", "Other Content Type Desc.", grid.Locator, "ContentTypeDesc");
                    ContentTypeDesc.DataField = "ContentTypeDesc";
                    CertificateNumber = new PXTextEdit("ctl00_phG_tab_t3_gridPackages_ei", "Certificate Number", grid.Locator, "CertificateNumber");
                    CertificateNumber.DataField = "CertificateNumber";
                    InvoiceNumber = new PXTextEdit("ctl00_phG_tab_t3_gridPackages_ei", "Invoice Number", grid.Locator, "InvoiceNumber");
                    InvoiceNumber.DataField = "InvoiceNumber";
                    LicenseNumber = new PXTextEdit("ctl00_phG_tab_t3_gridPackages_ei", "License Number", grid.Locator, "LicenseNumber");
                    LicenseNumber.DataField = "LicenseNumber";
                    ShipmentNbr = new PXTextEdit("_ctl00_phG_tab_t3_gridPackages_lv0_edShipmentNbr_Pkg", "Shipment Nbr.", grid.Locator, "ShipmentNbr");
                    ShipmentNbr.DataField = "ShipmentNbr";
                    LineNbr = new PXNumberEdit("_ctl00_phG_tab_t3_gridPackages_lv0_edLineNbr_Pkg", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Confirmed { get; }
				public SelectorColumnFilter BoxID { get; }
				public DropDownColumnFilter PackageType { get; }
				public PXTextEditColumnFilter Description { get; }
				public PXNumberEditColumnFilter Weight { get; }
				public PXTextEditColumnFilter WeightUOM { get; }
				public PXNumberEditColumnFilter DeclaredValue { get; }
				public PXNumberEditColumnFilter COD { get; }
				public DropDownColumnFilter StampsAddOns { get; }
				public PXTextEditColumnFilter TrackNumber { get; }
				public PXTextEditColumnFilter TrackUrl { get; }
				public PXTextEditColumnFilter CustomRefNbr1 { get; }
				public PXTextEditColumnFilter CustomRefNbr2 { get; }
				public InputColumnFilter ContentType { get; }
				public PXTextEditColumnFilter EELPFC { get; }
				public PXTextEditColumnFilter ContentTypeDesc { get; }
				public PXTextEditColumnFilter CertificateNumber { get; }
				public PXTextEditColumnFilter InvoiceNumber { get; }
				public PXTextEditColumnFilter LicenseNumber { get; }
				public PXTextEditColumnFilter ShipmentNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_packages_gridpackages grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Confirmed = new CheckBoxColumnFilter(grid.Row.Confirmed);
                    BoxID = new SelectorColumnFilter(grid.Row.BoxID);
                    PackageType = new DropDownColumnFilter(grid.Row.PackageType);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                    Weight = new PXNumberEditColumnFilter(grid.Row.Weight);
                    WeightUOM = new PXTextEditColumnFilter(grid.Row.WeightUOM);
                    DeclaredValue = new PXNumberEditColumnFilter(grid.Row.DeclaredValue);
                    COD = new PXNumberEditColumnFilter(grid.Row.COD);
                    StampsAddOns = new DropDownColumnFilter(grid.Row.StampsAddOns);
                    TrackNumber = new PXTextEditColumnFilter(grid.Row.TrackNumber);
                    TrackUrl = new PXTextEditColumnFilter(grid.Row.TrackUrl);
                    CustomRefNbr1 = new PXTextEditColumnFilter(grid.Row.CustomRefNbr1);
                    CustomRefNbr2 = new PXTextEditColumnFilter(grid.Row.CustomRefNbr2);
                    ContentType = new InputColumnFilter(grid.Row.ContentType);
                    EELPFC = new PXTextEditColumnFilter(grid.Row.EELPFC);
                    ContentTypeDesc = new PXTextEditColumnFilter(grid.Row.ContentTypeDesc);
                    CertificateNumber = new PXTextEditColumnFilter(grid.Row.CertificateNumber);
                    InvoiceNumber = new PXTextEditColumnFilter(grid.Row.InvoiceNumber);
                    LicenseNumber = new PXTextEditColumnFilter(grid.Row.LicenseNumber);
                    ShipmentNbr = new PXTextEditColumnFilter(grid.Row.ShipmentNbr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_packages_lv0 : Container
        {
            
			public PXTextEdit ShipmentNbr { get; }
			public Label ShipmentNbrLabel { get; }
			public Selector BoxID { get; }
			public Label BoxIDLabel { get; }
			public PXNumberEdit LineNbr { get; }
			public Label LineNbrLabel { get; }
			public PXNumberEdit Weight { get; }
			public Label WeightLabel { get; }
			public PXNumberEdit COD { get; }
			public Label CODLabel { get; }
			public PXNumberEdit DeclaredValue { get; }
			public Label DeclaredValueLabel { get; }
			public PXTextEdit TrackNumber { get; }
			public Label TrackNumberLabel { get; }
			public PXTextEdit CustomRefNbr1 { get; }
			public Label CustomRefNbr1Label { get; }
			public PXTextEdit CustomRefNbr2 { get; }
			public Label CustomRefNbr2Label { get; }
			public PXTextEdit Description { get; }
			public Label DescriptionLabel { get; }
			public DropDown PackageType { get; }
			public Label PackageTypeLabel { get; }
			public DropDown StampsAddOns { get; }
			public Label StampsAddOnsLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_packages_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ShipmentNbr = new PXTextEdit("ctl00_phG_tab_t3_gridPackages_lv0_edShipmentNbr_Pkg", "Shipment Nbr.", locator, null);
                ShipmentNbrLabel = new Label(ShipmentNbr);
                ShipmentNbr.DataField = "ShipmentNbr";
                BoxID = new Selector("ctl00_phG_tab_t3_gridPackages_lv0_edBoxID", "Box ID", locator, null);
                BoxIDLabel = new Label(BoxID);
                BoxID.DataField = "BoxID";
                LineNbr = new PXNumberEdit("ctl00_phG_tab_t3_gridPackages_lv0_edLineNbr_Pkg", "Line Nbr.", locator, null);
                LineNbrLabel = new Label(LineNbr);
                LineNbr.DataField = "LineNbr";
                Weight = new PXNumberEdit("ctl00_phG_tab_t3_gridPackages_lv0_edWeight", "Weight", locator, null);
                WeightLabel = new Label(Weight);
                Weight.DataField = "Weight";
                COD = new PXNumberEdit("ctl00_phG_tab_t3_gridPackages_lv0_PXNumberEdit5", "C.O.D. Amount", locator, null);
                CODLabel = new Label(COD);
                COD.DataField = "COD";
                DeclaredValue = new PXNumberEdit("ctl00_phG_tab_t3_gridPackages_lv0_PXNumberEdit6", "Declared Value", locator, null);
                DeclaredValueLabel = new Label(DeclaredValue);
                DeclaredValue.DataField = "DeclaredValue";
                TrackNumber = new PXTextEdit("ctl00_phG_tab_t3_gridPackages_lv0_edTrackNumber", "Tracking Number", locator, null);
                TrackNumberLabel = new Label(TrackNumber);
                TrackNumber.DataField = "TrackNumber";
                CustomRefNbr1 = new PXTextEdit("ctl00_phG_tab_t3_gridPackages_lv0_PXTextEdit1", "Custom Ref. Nbr. 1", locator, null);
                CustomRefNbr1Label = new Label(CustomRefNbr1);
                CustomRefNbr1.DataField = "CustomRefNbr1";
                CustomRefNbr2 = new PXTextEdit("ctl00_phG_tab_t3_gridPackages_lv0_PXTextEdit2", "Custom Ref. Nbr. 2", locator, null);
                CustomRefNbr2Label = new Label(CustomRefNbr2);
                CustomRefNbr2.DataField = "CustomRefNbr2";
                Description = new PXTextEdit("ctl00_phG_tab_t3_gridPackages_lv0_PXTextEdit3", "Description", locator, null);
                DescriptionLabel = new Label(Description);
                Description.DataField = "Description";
                PackageType = new DropDown("ctl00_phG_tab_t3_gridPackages_lv0_edType", "Type", locator, null);
                PackageTypeLabel = new Label(PackageType);
                PackageType.DataField = "PackageType";
                PackageType.Items.Add("A", "Auto");
                PackageType.Items.Add("M", "Manual");
                StampsAddOns = new DropDown("ctl00_phG_tab_t3_gridPackages_lv0_edStampsAddOns", "Stamps Surcharges", locator, null);
                StampsAddOnsLabel = new Label(StampsAddOns);
                StampsAddOns.DataField = "StampsAddOns";
                StampsAddOns.Items.Add("USARD", "USPS Restricted Delivery");
                StampsAddOns.Items.Add("USAESH", "Priority Mail Express delivery on a Sunday/holiday");
                StampsAddOns.Items.Add("USANDW", "Priority Mail Express no delivery on Saturday");
                StampsAddOns.Items.Add("USANND", "USPS notice of non-delivery");
                StampsAddOns.Items.Add("USALAWS", "Mailable Live Animals with charge");
                StampsAddOns.Items.Add("USASH", "Fragile items");
                StampsAddOns.Items.Add("USA1030", "Deliver by 10:30 AM");
                StampsAddOns.Items.Add("SCAHP", "Hidden Postage");
                Es = new Selector("ctl00_phG_tab_t3_gridPackages_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t3_gridPackages_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t3_gridPackages_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t3_gridPackages_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Packages";
            }
        }
        
        public class c_packagesforrates_gridpackagesforrates : Grid<c_packagesforrates_gridpackagesforrates.c_grid_row, c_packagesforrates_gridpackagesforrates.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_packagesforrates_gridpackagesforrates(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelCarrierRates_gridPackagesForRates");
                DataMemberName = "PackagesForRates";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PanelCarrierRates_gridPackagesForRates_fe_gf", "FilterForm");
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
            
            public virtual void RecalculatePackages()
            {
                ToolBar.RecalculatePackages.Click();
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
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid RecalculatePackages { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridPackagesForRates_at_tlb div[data-cmd=\'Refres" +
                            "h\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridPackagesForRates_at_tlb div[data-cmd=\'AddNew" +
                            "\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridPackagesForRates_at_tlb div[data-cmd=\'Delete" +
                            "\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    RecalculatePackages = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridPackagesForRates_at_tlb div[data-cmd=\'Recalc" +
                            "ulatePackages\']", "Refresh Packages", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridPackagesForRates_at_tlb div[data-cmd=\'Adjust" +
                            "Columns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridPackagesForRates_at_tlb div[data-cmd=\'Export" +
                            "Excel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridPackagesForRates_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
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
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_gridPackagesForRates");
                    Prev = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_gridPackagesForRates");
                    Next = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_gridPackagesForRates");
                    Last = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_gridPackagesForRates");
                    First1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_gridPackagesForRates");
                    Prev1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_gridPackagesForRates");
                    Next1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_gridPackagesForRates");
                    Last1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_gridPackagesForRates");
                    Ok = new Button("ctl00_phG_PanelCarrierRates_PXButtonRatesOK", "OK", "ctl00_phG_PanelCarrierRates_gridPackagesForRates");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public Selector BoxID { get; }
			public PXTextEdit BoxDescription { get; }
			public PXTextEdit WeightUOM { get; }
			public PXNumberEdit Weight { get; }
			public PXNumberEdit BoxWeight { get; }
			public PXNumberEdit NetWeight { get; }
			public PXNumberEdit DeclaredValue { get; }
			public PXNumberEdit COD { get; }
			public DropDown StampsAddOns { get; }
			public PXTextEdit ShipmentNbr { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_packagesforrates_gridpackagesforrates grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    BoxID = new Selector("_ctl00_phG_PanelCarrierRates_gridPackagesForRates_lv0_es", "Box ID", grid.Locator, "BoxID");
                    BoxID.DataField = "BoxID";
                    BoxDescription = new PXTextEdit("ctl00_phG_PanelCarrierRates_gridPackagesForRates_ei", "Box Description", grid.Locator, "BoxDescription");
                    BoxDescription.DataField = "BoxDescription";
                    WeightUOM = new PXTextEdit("ctl00_phG_PanelCarrierRates_gridPackagesForRates_ei", "UOM", grid.Locator, "WeightUOM");
                    WeightUOM.DataField = "WeightUOM";
                    Weight = new PXNumberEdit("ctl00_phG_PanelCarrierRates_gridPackagesForRates_en", "Weight", grid.Locator, "Weight");
                    Weight.DataField = "Weight";
                    BoxWeight = new PXNumberEdit("ctl00_phG_PanelCarrierRates_gridPackagesForRates_en", "Box Weight", grid.Locator, "BoxWeight");
                    BoxWeight.DataField = "BoxWeight";
                    NetWeight = new PXNumberEdit("ctl00_phG_PanelCarrierRates_gridPackagesForRates_en", "Net Weight", grid.Locator, "NetWeight");
                    NetWeight.DataField = "NetWeight";
                    DeclaredValue = new PXNumberEdit("ctl00_phG_PanelCarrierRates_gridPackagesForRates_en", "Declared Value", grid.Locator, "DeclaredValue");
                    DeclaredValue.DataField = "DeclaredValue";
                    COD = new PXNumberEdit("ctl00_phG_PanelCarrierRates_gridPackagesForRates_en", "C.O.D. Amount", grid.Locator, "COD");
                    COD.DataField = "COD";
                    StampsAddOns = new DropDown("_ctl00_phG_PanelCarrierRates_gridPackagesForRates_lv0_edStampsAddOns2", "Stamps Surcharges", grid.Locator, "StampsAddOns");
                    StampsAddOns.DataField = "StampsAddOns";
                    StampsAddOns.Items.Add("USARD", "USPS Restricted Delivery");
                    StampsAddOns.Items.Add("USAESH", "Priority Mail Express delivery on a Sunday/holiday");
                    StampsAddOns.Items.Add("USANDW", "Priority Mail Express no delivery on Saturday");
                    StampsAddOns.Items.Add("USANND", "USPS notice of non-delivery");
                    StampsAddOns.Items.Add("USALAWS", "Mailable Live Animals with charge");
                    StampsAddOns.Items.Add("USASH", "Fragile items");
                    StampsAddOns.Items.Add("USA1030", "Deliver by 10:30 AM");
                    StampsAddOns.Items.Add("SCAHP", "Hidden Postage");
                    ShipmentNbr = new PXTextEdit("ctl00_phG_PanelCarrierRates_gridPackagesForRates_em", "Shipment Nbr.", grid.Locator, "ShipmentNbr");
                    ShipmentNbr.DataField = "ShipmentNbr";
                    LineNbr = new PXNumberEdit("ctl00_phG_PanelCarrierRates_gridPackagesForRates_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public SelectorColumnFilter BoxID { get; }
				public PXTextEditColumnFilter BoxDescription { get; }
				public PXTextEditColumnFilter WeightUOM { get; }
				public PXNumberEditColumnFilter Weight { get; }
				public PXNumberEditColumnFilter BoxWeight { get; }
				public PXNumberEditColumnFilter NetWeight { get; }
				public PXNumberEditColumnFilter DeclaredValue { get; }
				public PXNumberEditColumnFilter COD { get; }
				public DropDownColumnFilter StampsAddOns { get; }
				public PXTextEditColumnFilter ShipmentNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_packagesforrates_gridpackagesforrates grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    BoxID = new SelectorColumnFilter(grid.Row.BoxID);
                    BoxDescription = new PXTextEditColumnFilter(grid.Row.BoxDescription);
                    WeightUOM = new PXTextEditColumnFilter(grid.Row.WeightUOM);
                    Weight = new PXNumberEditColumnFilter(grid.Row.Weight);
                    BoxWeight = new PXNumberEditColumnFilter(grid.Row.BoxWeight);
                    NetWeight = new PXNumberEditColumnFilter(grid.Row.NetWeight);
                    DeclaredValue = new PXNumberEditColumnFilter(grid.Row.DeclaredValue);
                    COD = new PXNumberEditColumnFilter(grid.Row.COD);
                    StampsAddOns = new DropDownColumnFilter(grid.Row.StampsAddOns);
                    ShipmentNbr = new PXTextEditColumnFilter(grid.Row.ShipmentNbr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_packagesforrates_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown StampsAddOns { get; }
			public Label StampsAddOnsLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_packagesforrates_lv0(string locator, string name) : 
                    base(locator, name)
            {
                StampsAddOns = new DropDown("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lv0_edStampsAddOns2", "Stamps Surcharges", locator, null);
                StampsAddOnsLabel = new Label(StampsAddOns);
                StampsAddOns.DataField = "StampsAddOns";
                StampsAddOns.Items.Add("USARD", "USPS Restricted Delivery");
                StampsAddOns.Items.Add("USAESH", "Priority Mail Express delivery on a Sunday/holiday");
                StampsAddOns.Items.Add("USANDW", "Priority Mail Express no delivery on Saturday");
                StampsAddOns.Items.Add("USANND", "USPS notice of non-delivery");
                StampsAddOns.Items.Add("USALAWS", "Mailable Live Animals with charge");
                StampsAddOns.Items.Add("USASH", "Fragile items");
                StampsAddOns.Items.Add("USA1030", "Deliver by 10:30 AM");
                StampsAddOns.Items.Add("SCAHP", "Hidden Postage");
                Es = new Selector("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "PackagesForRates";
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
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
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
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_gridPackagesForRates_lv0");
                    Prev = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_gridPackagesForRates_lv0");
                    Next = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_gridPackagesForRates_lv0");
                    Last = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_gridPackagesForRates_lv0");
                    First1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_gridPackagesForRates_lv0");
                    Prev1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_gridPackagesForRates_lv0");
                    Next1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_gridPackagesForRates_lv0");
                    Last1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_gridPackagesForRates_lv0");
                    Ok = new Button("ctl00_phG_PanelCarrierRates_PXButtonRatesOK", "OK", "ctl00_phG_PanelCarrierRates_gridPackagesForRates_lv0");
                }
            }
        }
        
        public class c_splits_grid2 : Grid<c_splits_grid2.c_grid_row, c_splits_grid2.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_splits_grid2(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelLS_grid2");
                DataMemberName = "splits";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PanelLS_grid2_fe_gf", "FilterForm");
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
            
            public virtual void Generate()
            {
                Buttons.Generate.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelLS_grid2_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Generate { get; }
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    Generate = new Button("ctl00_phG_PanelLS_optform_btnGenerate", "Generate", "ctl00_phG_PanelLS_grid2");
                    Ok = new Button("ctl00_phG_PanelLS_btnSave", "OK", "ctl00_phG_PanelLS_grid2");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector InventoryID { get; }
			public Selector SubItemID { get; }
			public Selector LocationID { get; }
			public Selector LotSerialNbr { get; }
			public PXNumberEdit Qty { get; }
			public Selector UOM { get; }
			public DateSelector ExpireDate { get; }
			public PXTextEdit InventoryID_InventoryItem_descr { get; }
			public PXTextEdit ShipmentNbr { get; }
			public PXNumberEdit LineNbr { get; }
			public PXNumberEdit SplitLineNbr { get; }
                
                public c_grid_row(c_splits_grid2 grid) : 
                        base(grid)
                {
                    InventoryID = new Selector("_ctl00_phG_PanelLS_grid2_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SubItemID = new Selector("_ctl00_phG_PanelLS_grid2_lv0_edSubItemID2", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    LocationID = new Selector("_ctl00_phG_PanelLS_grid2_lv0_edLocationID2", "Location", grid.Locator, "LocationID");
                    LocationID.DataField = "LocationID";
                    LotSerialNbr = new Selector("_ctl00_phG_PanelLS_grid2_lv0_edLotSerialNbr2", "Lot/Serial Nbr.", grid.Locator, "LotSerialNbr");
                    LotSerialNbr.DataField = "LotSerialNbr";
                    Qty = new PXNumberEdit("_ctl00_phG_PanelLS_grid2_lv0_edQty2", "Quantity", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    UOM = new Selector("_ctl00_phG_PanelLS_grid2_lv0_edUOM2", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    ExpireDate = new DateSelector("_ctl00_phG_PanelLS_grid2_lv0_edExpireDate2", "Expiration Date", grid.Locator, "ExpireDate");
                    ExpireDate.DataField = "ExpireDate";
                    InventoryID_InventoryItem_descr = new PXTextEdit("ctl00_phG_PanelLS_grid2_ei", "Description", grid.Locator, "InventoryID_InventoryItem_descr");
                    InventoryID_InventoryItem_descr.DataField = "InventoryID_InventoryItem_descr";
                    ShipmentNbr = new PXTextEdit("ctl00_phG_PanelLS_grid2_ei", "ShipmentNbr", grid.Locator, "ShipmentNbr");
                    ShipmentNbr.DataField = "ShipmentNbr";
                    LineNbr = new PXNumberEdit("ctl00_phG_PanelLS_grid2_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    SplitLineNbr = new PXNumberEdit("ctl00_phG_PanelLS_grid2_en", "SplitLineNbr", grid.Locator, "SplitLineNbr");
                    SplitLineNbr.DataField = "SplitLineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public SelectorColumnFilter LocationID { get; }
				public SelectorColumnFilter LotSerialNbr { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public SelectorColumnFilter UOM { get; }
				public DateSelectorColumnFilter ExpireDate { get; }
				public PXTextEditColumnFilter InventoryID_InventoryItem_descr { get; }
				public PXTextEditColumnFilter ShipmentNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXNumberEditColumnFilter SplitLineNbr { get; }
                
                public c_grid_header(c_splits_grid2 grid) : 
                        base(grid)
                {
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    LocationID = new SelectorColumnFilter(grid.Row.LocationID);
                    LotSerialNbr = new SelectorColumnFilter(grid.Row.LotSerialNbr);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    ExpireDate = new DateSelectorColumnFilter(grid.Row.ExpireDate);
                    InventoryID_InventoryItem_descr = new PXTextEditColumnFilter(grid.Row.InventoryID_InventoryItem_descr);
                    ShipmentNbr = new PXTextEditColumnFilter(grid.Row.ShipmentNbr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    SplitLineNbr = new PXNumberEditColumnFilter(grid.Row.SplitLineNbr);
                }
            }
        }
        
        public class c_splits_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public Selector LocationID { get; }
			public Label LocationIDLabel { get; }
			public PXNumberEdit Qty { get; }
			public Label QtyLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public Selector LotSerialNbr { get; }
			public Label LotSerialNbrLabel { get; }
			public DateSelector ExpireDate { get; }
			public Label ExpireDateLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_splits_lv0(string locator, string name) : 
                    base(locator, name)
            {
                SubItemID = new Selector("ctl00_phG_PanelLS_grid2_lv0_edSubItemID2", "Subitem", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                LocationID = new Selector("ctl00_phG_PanelLS_grid2_lv0_edLocationID2", "Location", locator, null);
                LocationIDLabel = new Label(LocationID);
                LocationID.DataField = "LocationID";
                Qty = new PXNumberEdit("ctl00_phG_PanelLS_grid2_lv0_edQty2", "Quantity", locator, null);
                QtyLabel = new Label(Qty);
                Qty.DataField = "Qty";
                UOM = new Selector("ctl00_phG_PanelLS_grid2_lv0_edUOM2", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                LotSerialNbr = new Selector("ctl00_phG_PanelLS_grid2_lv0_edLotSerialNbr2", "Lot/Serial Nbr.", locator, null);
                LotSerialNbrLabel = new Label(LotSerialNbr);
                LotSerialNbr.DataField = "LotSerialNbr";
                ExpireDate = new DateSelector("ctl00_phG_PanelLS_grid2_lv0_edExpireDate2", "Expiration Date", locator, null);
                ExpireDateLabel = new Label(ExpireDate);
                ExpireDate.DataField = "ExpireDate";
                Es = new Selector("ctl00_phG_PanelLS_grid2_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "splits";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Generate()
            {
                Buttons.Generate.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Generate { get; }
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    Generate = new Button("ctl00_phG_PanelLS_optform_btnGenerate", "Generate", "ctl00_phG_PanelLS_grid2_lv0");
                    Ok = new Button("ctl00_phG_PanelLS_btnSave", "OK", "ctl00_phG_PanelLS_grid2_lv0");
                }
            }
        }
        
        public class c_addsofilter_form4 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown Operation { get; }
			public Label OperationLabel { get; }
			public Selector OrderType { get; }
			public Label OrderTypeLabel { get; }
			public Selector OrderNbr { get; }
			public Label OrderNbrLabel { get; }
            
            public c_addsofilter_form4(string locator, string name) : 
                    base(locator, name)
            {
                Operation = new DropDown("ctl00_phG_PanelAddSO_form4_edOperation", "Operation", locator, null);
                OperationLabel = new Label(Operation);
                Operation.DataField = "Operation";
                OrderType = new Selector("ctl00_phG_PanelAddSO_form4_edOrderType4", "Order Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                OrderNbr = new Selector("ctl00_phG_PanelAddSO_form4_edOrderNbr4", "Order Nbr", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                DataMemberName = "addsofilter";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Add()
            {
                Buttons.Add.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddSO_PXButton1", "Add", "ctl00_phG_PanelAddSO_form4");
                    AddClose = new Button("ctl00_phG_PanelAddSO_PXButton2", "Add & Close", "ctl00_phG_PanelAddSO_form4");
                    Cancel = new Button("ctl00_phG_PanelAddSO_PXButton3", "Cancel", "ctl00_phG_PanelAddSO_form4");
                }
            }
        }
        
        public class c_soshipmentplan_grid4 : Grid<c_soshipmentplan_grid4.c_grid_row, c_soshipmentplan_grid4.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_soshipmentplan_grid4(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelAddSO_grid4");
                DataMemberName = "soshipmentplan";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PanelAddSO_grid4_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
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
            
            public virtual void Add()
            {
                Buttons.Add.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSO_grid4_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSO_grid4_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSO_grid4_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSO_grid4_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSO_grid4_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSO_grid4_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSO_grid4_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSO_grid4_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddSO_grid4_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddSO_PXButton1", "Add", "ctl00_phG_PanelAddSO_grid4");
                    AddClose = new Button("ctl00_phG_PanelAddSO_PXButton2", "Add & Close", "ctl00_phG_PanelAddSO_grid4");
                    Cancel = new Button("ctl00_phG_PanelAddSO_PXButton3", "Cancel", "ctl00_phG_PanelAddSO_grid4");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public PXNumberEdit SOLine__LineNbr { get; }
			public Selector SOLine__InventoryID { get; }
			public Selector SOLineSplit__SubItemID { get; }
			public Selector SOLineSplit__UOM { get; }
			public Selector SOLineSplit__LotSerialNbr { get; }
			public DateSelector PlanDate { get; }
			public PXNumberEdit SOLineSplit__Qty { get; }
			public InputLocalizable SOLine__TranDesc { get; }
			public PXTextEdit OrderType { get; }
			public PXTextEdit OrderNbr { get; }
			public PXNumberEdit PlanID { get; }
                
                public c_grid_row(c_soshipmentplan_grid4 grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_PanelAddSO_grid4_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    SOLine__LineNbr = new PXNumberEdit("ctl00_phG_PanelAddSO_grid4_en", "Line Nbr.", grid.Locator, "SOLine__LineNbr");
                    SOLine__LineNbr.DataField = "SOLine__LineNbr";
                    SOLine__InventoryID = new Selector("_ctl00_phG_PanelAddSO_grid4_lv0_es", "Inventory ID", grid.Locator, "SOLine__InventoryID");
                    SOLine__InventoryID.DataField = "SOLine__InventoryID";
                    SOLineSplit__SubItemID = new Selector("_ctl00_phG_PanelAddSO_grid4_lv0_es", "Subitem", grid.Locator, "SOLineSplit__SubItemID");
                    SOLineSplit__SubItemID.DataField = "SOLineSplit__SubItemID";
                    SOLineSplit__UOM = new Selector("_ctl00_phG_PanelAddSO_grid4_lv0_es", "UOM", grid.Locator, "SOLineSplit__UOM");
                    SOLineSplit__UOM.DataField = "SOLineSplit__UOM";
                    SOLineSplit__LotSerialNbr = new Selector("_ctl00_phG_PanelAddSO_grid4_lv0_es", "Lot/Serial Nbr.", grid.Locator, "SOLineSplit__LotSerialNbr");
                    SOLineSplit__LotSerialNbr.DataField = "SOLineSplit__LotSerialNbr";
                    PlanDate = new DateSelector("_ctl00_phG_PanelAddSO_grid4_lv0_ed6", "Sched. Ship. Date", grid.Locator, "PlanDate");
                    PlanDate.DataField = "PlanDate";
                    SOLineSplit__Qty = new PXNumberEdit("ctl00_phG_PanelAddSO_grid4_en", "Quantity", grid.Locator, "SOLineSplit__Qty");
                    SOLineSplit__Qty.DataField = "SOLineSplit__Qty";
                    SOLine__TranDesc = new InputLocalizable("ctl00_phG_PanelAddSO_grid4_ei", "Line Description", grid.Locator, "SOLine__TranDesc");
                    SOLine__TranDesc.DataField = "SOLine__TranDesc";
                    OrderType = new PXTextEdit("ctl00_phG_PanelAddSO_grid4_em", "OrderType", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderNbr = new PXTextEdit("ctl00_phG_PanelAddSO_grid4_ei", "OrderNbr", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    PlanID = new PXNumberEdit("ctl00_phG_PanelAddSO_grid4_en", "PlanID", grid.Locator, "PlanID");
                    PlanID.DataField = "PlanID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXNumberEditColumnFilter SOLine__LineNbr { get; }
				public SelectorColumnFilter SOLine__InventoryID { get; }
				public SelectorColumnFilter SOLineSplit__SubItemID { get; }
				public SelectorColumnFilter SOLineSplit__UOM { get; }
				public SelectorColumnFilter SOLineSplit__LotSerialNbr { get; }
				public DateSelectorColumnFilter PlanDate { get; }
				public PXNumberEditColumnFilter SOLineSplit__Qty { get; }
				public PXTextEditColumnFilter SOLine__TranDesc { get; }
				public PXTextEditColumnFilter OrderType { get; }
				public PXTextEditColumnFilter OrderNbr { get; }
				public PXNumberEditColumnFilter PlanID { get; }
                
                public c_grid_header(c_soshipmentplan_grid4 grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    SOLine__LineNbr = new PXNumberEditColumnFilter(grid.Row.SOLine__LineNbr);
                    SOLine__InventoryID = new SelectorColumnFilter(grid.Row.SOLine__InventoryID);
                    SOLineSplit__SubItemID = new SelectorColumnFilter(grid.Row.SOLineSplit__SubItemID);
                    SOLineSplit__UOM = new SelectorColumnFilter(grid.Row.SOLineSplit__UOM);
                    SOLineSplit__LotSerialNbr = new SelectorColumnFilter(grid.Row.SOLineSplit__LotSerialNbr);
                    PlanDate = new DateSelectorColumnFilter(grid.Row.PlanDate);
                    SOLineSplit__Qty = new PXNumberEditColumnFilter(grid.Row.SOLineSplit__Qty);
                    SOLine__TranDesc = new PXTextEditColumnFilter(grid.Row.SOLine__TranDesc);
                    OrderType = new PXTextEditColumnFilter(grid.Row.OrderType);
                    OrderNbr = new PXTextEditColumnFilter(grid.Row.OrderNbr);
                    PlanID = new PXNumberEditColumnFilter(grid.Row.PlanID);
                }
            }
        }
        
        public class c_soshipmentplan_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_soshipmentplan_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PanelAddSO_grid4_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_PanelAddSO_grid4_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Em = new Selector("ctl00_phG_PanelAddSO_grid4_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "soshipmentplan";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Add()
            {
                Buttons.Add.Click();
            }
            
            public virtual void AddClose()
            {
                Buttons.AddClose.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddSO_PXButton1", "Add", "ctl00_phG_PanelAddSO_grid4_lv0");
                    AddClose = new Button("ctl00_phG_PanelAddSO_PXButton2", "Add & Close", "ctl00_phG_PanelAddSO_grid4_lv0");
                    Cancel = new Button("ctl00_phG_PanelAddSO_PXButton3", "Cancel", "ctl00_phG_PanelAddSO_grid4_lv0");
                }
            }
        }
        
        public class c_carrierrates_gridrates : Grid<c_carrierrates_gridrates.c_grid_row, c_carrierrates_gridrates.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_carrierrates_gridrates(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelCarrierRates_gridRates");
                DataMemberName = "CarrierRates";
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
            
            public virtual void RefreshRates()
            {
                ToolBar.RefreshRates.Click();
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
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid RefreshRates { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridRates_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridRates_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridRates_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    RefreshRates = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridRates_at_tlb div[data-cmd=\'RefreshRates\']", "Refresh Rates", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridRates_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridRates_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelCarrierRates_gridRates_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
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
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_gridRates");
                    Prev = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_gridRates");
                    Next = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_gridRates");
                    Last = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_gridRates");
                    First1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_gridRates");
                    Prev1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_gridRates");
                    Next1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_gridRates");
                    Last1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_gridRates");
                    Ok = new Button("ctl00_phG_PanelCarrierRates_PXButtonRatesOK", "OK", "ctl00_phG_PanelCarrierRates_gridRates");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public PXTextEdit Method { get; }
			public PXTextEdit Description { get; }
			public PXNumberEdit Amount { get; }
			public PXNumberEdit DaysInTransit { get; }
			public DateSelector DeliveryDate { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_carrierrates_gridrates grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_PanelCarrierRates_gridRates_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    Method = new PXTextEdit("ctl00_phG_PanelCarrierRates_gridRates_ei", "Code", grid.Locator, "Method");
                    Method.DataField = "Method";
                    Description = new PXTextEdit("ctl00_phG_PanelCarrierRates_gridRates_ei", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                    Amount = new PXNumberEdit("ctl00_phG_PanelCarrierRates_gridRates_en", "Amount", grid.Locator, "Amount");
                    Amount.DataField = "Amount";
                    DaysInTransit = new PXNumberEdit("ctl00_phG_PanelCarrierRates_gridRates_en", "Days in Transit", grid.Locator, "DaysInTransit");
                    DaysInTransit.DataField = "DaysInTransit";
                    DeliveryDate = new DateSelector("_ctl00_phG_PanelCarrierRates_gridRates_lv0_ed5", "Delivery Date", grid.Locator, "DeliveryDate");
                    DeliveryDate.DataField = "DeliveryDate";
                    LineNbr = new PXNumberEdit("ctl00_phG_PanelCarrierRates_gridRates_en", "LineNbr", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter Method { get; }
				public PXTextEditColumnFilter Description { get; }
				public PXNumberEditColumnFilter Amount { get; }
				public PXNumberEditColumnFilter DaysInTransit { get; }
				public DateSelectorColumnFilter DeliveryDate { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_carrierrates_gridrates grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    Method = new PXTextEditColumnFilter(grid.Row.Method);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                    Amount = new PXNumberEditColumnFilter(grid.Row.Amount);
                    DaysInTransit = new PXNumberEditColumnFilter(grid.Row.DaysInTransit);
                    DeliveryDate = new DateSelectorColumnFilter(grid.Row.DeliveryDate);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_carrierrates_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
            
            public c_carrierrates_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_PanelCarrierRates_gridRates_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                DataMemberName = "CarrierRates";
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
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
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
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    First = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_gridRates_lv0");
                    Prev = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_gridRates_lv0");
                    Next = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_gridRates_lv0");
                    Last = new Button("ctl00_phG_PanelCarrierRates_gridRates_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_gridRates_lv0");
                    First1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfFirst0", "First", "ctl00_phG_PanelCarrierRates_gridRates_lv0");
                    Prev1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfPrev0", "Prev", "ctl00_phG_PanelCarrierRates_gridRates_lv0");
                    Next1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfNext0", "Next", "ctl00_phG_PanelCarrierRates_gridRates_lv0");
                    Last1 = new Button("ctl00_phG_PanelCarrierRates_gridPackagesForRates_lfLast0", "Last", "ctl00_phG_PanelCarrierRates_gridRates_lv0");
                    Ok = new Button("ctl00_phG_PanelCarrierRates_PXButtonRatesOK", "OK", "ctl00_phG_PanelCarrierRates_gridRates_lv0");
                }
            }
        }
        
        public class c_packagedetailsplit_gridpackagedetailsplit : Grid<c_packagedetailsplit_gridpackagedetailsplit.c_grid_row, c_packagedetailsplit_gridpackagedetailsplit.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_packagedetailsplit_gridpackagedetailsplit(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t3_gridPackageDetailSplit");
                DataMemberName = "PackageDetailSplit";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t3_gridPackageDetailSplit_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackageDetailSplit_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackageDetailSplit_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackageDetailSplit_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackageDetailSplit_at_tlb div[data-cmd=\'AdjustColumns\']" +
                            "", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackageDetailSplit_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackageDetailSplit_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackageDetailSplit_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackageDetailSplit_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackageDetailSplit_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackageDetailSplit_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_gridPackageDetailSplit_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector ShipmentSplitLineNbr { get; }
			public Selector InventoryID { get; }
			public Selector SubItemID { get; }
			public PXTextEdit LotSerialNbr { get; }
			public PXTextEdit UOM { get; }
			public PXNumberEdit PackedQty { get; }
			public PXNumberEdit RecordID { get; }
                
                public c_grid_row(c_packagedetailsplit_gridpackagedetailsplit grid) : 
                        base(grid)
                {
                    ShipmentSplitLineNbr = new Selector("_ctl00_phG_tab_t3_gridPackageDetailSplit_lv0_edShipmentSplitLineNbr", "Shipment Split Line Nbr.", grid.Locator, "ShipmentSplitLineNbr");
                    ShipmentSplitLineNbr.DataField = "ShipmentSplitLineNbr";
                    InventoryID = new Selector("_ctl00_phG_tab_t3_gridPackageDetailSplit_lv0_edInventoryIDSplit", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SubItemID = new Selector("_ctl00_phG_tab_t3_gridPackageDetailSplit_lv0_edSubItemIDSplit", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    LotSerialNbr = new PXTextEdit("_ctl00_phG_tab_t3_gridPackageDetailSplit_lv0_edLotSerialNbrSplit", "Lot/Serial Nbr.", grid.Locator, "LotSerialNbr");
                    LotSerialNbr.DataField = "LotSerialNbr";
                    UOM = new PXTextEdit("_ctl00_phG_tab_t3_gridPackageDetailSplit_lv0_edUOMSplit", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    PackedQty = new PXNumberEdit("_ctl00_phG_tab_t3_gridPackageDetailSplit_lv0_edQtySplit", "Quantity", grid.Locator, "PackedQty");
                    PackedQty.DataField = "PackedQty";
                    RecordID = new PXNumberEdit("ctl00_phG_tab_t3_gridPackageDetailSplit_en", "RecordID", grid.Locator, "RecordID");
                    RecordID.DataField = "RecordID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter ShipmentSplitLineNbr { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public PXTextEditColumnFilter LotSerialNbr { get; }
				public PXTextEditColumnFilter UOM { get; }
				public PXNumberEditColumnFilter PackedQty { get; }
				public PXNumberEditColumnFilter RecordID { get; }
                
                public c_grid_header(c_packagedetailsplit_gridpackagedetailsplit grid) : 
                        base(grid)
                {
                    ShipmentSplitLineNbr = new SelectorColumnFilter(grid.Row.ShipmentSplitLineNbr);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    LotSerialNbr = new PXTextEditColumnFilter(grid.Row.LotSerialNbr);
                    UOM = new PXTextEditColumnFilter(grid.Row.UOM);
                    PackedQty = new PXNumberEditColumnFilter(grid.Row.PackedQty);
                    RecordID = new PXNumberEditColumnFilter(grid.Row.RecordID);
                }
            }
        }
        
        public class c_packagedetailsplit_lv0 : Container
        {
            
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public PXTextEdit LotSerialNbr { get; }
			public Label LotSerialNbrLabel { get; }
			public PXNumberEdit PackedQty { get; }
			public Label PackedQtyLabel { get; }
			public PXTextEdit UOM { get; }
			public Label UOMLabel { get; }
			public Selector ShipmentSplitLineNbr { get; }
			public Label ShipmentSplitLineNbrLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_packagedetailsplit_lv0(string locator, string name) : 
                    base(locator, name)
            {
                InventoryID = new Selector("ctl00_phG_tab_t3_gridPackageDetailSplit_lv0_edInventoryIDSplit", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                SubItemID = new Selector("ctl00_phG_tab_t3_gridPackageDetailSplit_lv0_edSubItemIDSplit", "Subitem", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                LotSerialNbr = new PXTextEdit("ctl00_phG_tab_t3_gridPackageDetailSplit_lv0_edLotSerialNbrSplit", "Lot/Serial Nbr.", locator, null);
                LotSerialNbrLabel = new Label(LotSerialNbr);
                LotSerialNbr.DataField = "LotSerialNbr";
                PackedQty = new PXNumberEdit("ctl00_phG_tab_t3_gridPackageDetailSplit_lv0_edQtySplit", "Quantity", locator, null);
                PackedQtyLabel = new Label(PackedQty);
                PackedQty.DataField = "PackedQty";
                UOM = new PXTextEdit("ctl00_phG_tab_t3_gridPackageDetailSplit_lv0_edUOMSplit", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                ShipmentSplitLineNbr = new Selector("ctl00_phG_tab_t3_gridPackageDetailSplit_lv0_edShipmentSplitLineNbr", "Shipment Split Line Nbr.", locator, null);
                ShipmentSplitLineNbrLabel = new Label(ShipmentSplitLineNbr);
                ShipmentSplitLineNbr.DataField = "ShipmentSplitLineNbr";
                Es = new Selector("ctl00_phG_tab_t3_gridPackageDetailSplit_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "PackageDetailSplit";
            }
        }
        
        public class c_addresslookupfilter_addresslookuppanelformaddress : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit SearchAddress { get; }
			public Label SearchAddressLabel { get; }
			public PXTextEdit ViewName { get; }
			public Label ViewNameLabel { get; }
			public PXTextEdit AddressLine1 { get; }
			public Label AddressLine1Label { get; }
			public PXTextEdit AddressLine2 { get; }
			public Label AddressLine2Label { get; }
			public PXTextEdit AddressLine3 { get; }
			public Label AddressLine3Label { get; }
			public PXTextEdit City { get; }
			public Label CityLabel { get; }
			public PXTextEdit CountryID { get; }
			public Label CountryIDLabel { get; }
			public PXTextEdit State { get; }
			public Label StateLabel { get; }
			public PXTextEdit PostalCode { get; }
			public Label PostalCodeLabel { get; }
			public PXTextEdit Latitude { get; }
			public Label LatitudeLabel { get; }
			public PXTextEdit Longitude { get; }
			public Label LongitudeLabel { get; }
            
            public c_addresslookupfilter_addresslookuppanelformaddress(string locator, string name) : 
                    base(locator, name)
            {
                SearchAddress = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_searchBox", "Search Address", locator, null);
                SearchAddressLabel = new Label(SearchAddress);
                SearchAddress.DataField = "SearchAddress";
                ViewName = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_addressLookupViewName", "ViewName", locator, null);
                ViewNameLabel = new Label(ViewName);
                ViewName.DataField = "ViewName";
                AddressLine1 = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseAddressL" +
                        "ine1", "AddressLine1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseAddressL" +
                        "ine2", "AddressLine2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                AddressLine3 = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseAddressL" +
                        "ine3", "AddressLine3", locator, null);
                AddressLine3Label = new Label(AddressLine3);
                AddressLine3.DataField = "AddressLine3";
                City = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                CountryID = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseCountry", "CountryID", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                State = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponsePostalCo" +
                        "de", "PostalCode", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                Latitude = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseLatitude" +
                        "", "Latitude", locator, null);
                LatitudeLabel = new Label(Latitude);
                Latitude.DataField = "Latitude";
                Longitude = new PXTextEdit("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress_SearchResponseLongitud" +
                        "e", "Longitude", locator, null);
                LongitudeLabel = new Label(Longitude);
                Longitude.DataField = "Longitude";
                DataMemberName = "AddressLookupFilter";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Select()
            {
                Buttons.Select.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Select { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Select = new Button("ctl00_phG_AddressLookupPanel_AddressLookupSelectAction", "Select", "ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress");
                    Cancel = new Button("ctl00_phG_AddressLookupPanel_AddressEntityBtnCancel", "Cancel", "ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress");
                }
            }
        }
        
        public class c_lssoshipline_lotseropts_optform : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit UnassignedQty { get; }
			public Label UnassignedQtyLabel { get; }
			public PXNumberEdit Qty { get; }
			public Label QtyLabel { get; }
			public PXTextEdit StartNumVal { get; }
			public Label StartNumValLabel { get; }
            
            public c_lssoshipline_lotseropts_optform(string locator, string name) : 
                    base(locator, name)
            {
                UnassignedQty = new PXNumberEdit("ctl00_phG_PanelLS_optform_edUnassignedQty", "Unassigned Qty.", locator, null);
                UnassignedQtyLabel = new Label(UnassignedQty);
                UnassignedQty.DataField = "UnassignedQty";
                Qty = new PXNumberEdit("ctl00_phG_PanelLS_optform_edQty", "Quantity to Generate", locator, null);
                QtyLabel = new Label(Qty);
                Qty.DataField = "Qty";
                StartNumVal = new PXTextEdit("ctl00_phG_PanelLS_optform_edStartNumVal", "Start Lot/Serial Number", locator, null);
                StartNumValLabel = new Label(StartNumVal);
                StartNumVal.DataField = "StartNumVal";
                DataMemberName = "LSSOShipLine_lotseropts";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Generate()
            {
                Buttons.Generate.Click();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Generate { get; }
			public Button Ok { get; }
                
                public PxButtonCollection()
                {
                    Generate = new Button("ctl00_phG_PanelLS_optform_btnGenerate", "Generate", "ctl00_phG_PanelLS_optform");
                    Ok = new Button("ctl00_phG_PanelLS_btnSave", "OK", "ctl00_phG_PanelLS_optform");
                }
            }
        }
        
        public class c_picklistentries_picklistheader : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit SOPickingJob__PickListNbr { get; }
			public Label SOPickingJob__PickListNbrLabel { get; }
			public DropDown SOPickingJob__Status { get; }
			public Label SOPickingJob__StatusLabel { get; }
			public DropDown SOPickingJob__Priority { get; }
			public Label SOPickingJob__PriorityLabel { get; }
			public CheckBox SOPickingJob__AutomaticShipmentConfirmation { get; }
			public Label SOPickingJob__AutomaticShipmentConfirmationLabel { get; }
			public PXNumberEdit SOPicker__PathLength { get; }
			public Label SOPicker__PathLengthLabel { get; }
			public Selector SOPickingJob__PreferredAssigneeID { get; }
			public Label SOPickingJob__PreferredAssigneeIDLabel { get; }
			public Selector SOPickingJob__ActualAssigneeID { get; }
			public Label SOPickingJob__ActualAssigneeIDLabel { get; }
			public Selector SOPickerToShipmentLink__ToteID { get; }
			public Label SOPickerToShipmentLink__ToteIDLabel { get; }
            
            public c_picklistentries_picklistheader(string locator, string name) : 
                    base(locator, name)
            {
                SOPickingJob__PickListNbr = new PXTextEdit("ctl00_phG_PanelPickList_PickListHeader_edListNbr", "SO Picking Job __ Pick List Nbr", locator, null);
                SOPickingJob__PickListNbrLabel = new Label(SOPickingJob__PickListNbr);
                SOPickingJob__PickListNbr.DataField = "SOPickingJob__PickListNbr";
                SOPickingJob__Status = new DropDown("ctl00_phG_PanelPickList_PickListHeader_edStatus", "SO Picking Job __ Status", locator, null);
                SOPickingJob__StatusLabel = new Label(SOPickingJob__Status);
                SOPickingJob__Status.DataField = "SOPickingJob__Status";
                SOPickingJob__Priority = new DropDown("ctl00_phG_PanelPickList_PickListHeader_edPriority", "SO Picking Job __ Priority", locator, null);
                SOPickingJob__PriorityLabel = new Label(SOPickingJob__Priority);
                SOPickingJob__Priority.DataField = "SOPickingJob__Priority";
                SOPickingJob__AutomaticShipmentConfirmation = new CheckBox("ctl00_phG_PanelPickList_PickListHeader_edAutomaticShipmentConfirmation", "SO Picking Job __ Automatic Shipment Confirmation", locator, null);
                SOPickingJob__AutomaticShipmentConfirmationLabel = new Label(SOPickingJob__AutomaticShipmentConfirmation);
                SOPickingJob__AutomaticShipmentConfirmation.DataField = "SOPickingJob__AutomaticShipmentConfirmation";
                SOPicker__PathLength = new PXNumberEdit("ctl00_phG_PanelPickList_PickListHeader_edPathLength", "SO Picker __ Path Length", locator, null);
                SOPicker__PathLengthLabel = new Label(SOPicker__PathLength);
                SOPicker__PathLength.DataField = "SOPicker__PathLength";
                SOPickingJob__PreferredAssigneeID = new Selector("ctl00_phG_PanelPickList_PickListHeader_PXPrefPicker", "SO Picking Job __ Preferred Assignee ID", locator, null);
                SOPickingJob__PreferredAssigneeIDLabel = new Label(SOPickingJob__PreferredAssigneeID);
                SOPickingJob__PreferredAssigneeID.DataField = "SOPickingJob__PreferredAssigneeID";
                SOPickingJob__ActualAssigneeID = new Selector("ctl00_phG_PanelPickList_PickListHeader_edActPicker", "SO Picking Job __ Actual Assignee ID", locator, null);
                SOPickingJob__ActualAssigneeIDLabel = new Label(SOPickingJob__ActualAssigneeID);
                SOPickingJob__ActualAssigneeID.DataField = "SOPickingJob__ActualAssigneeID";
                SOPickerToShipmentLink__ToteID = new Selector("ctl00_phG_PanelPickList_PickListHeader_edTote", "SO Picker To Shipment Link __ Tote ID", locator, null);
                SOPickerToShipmentLink__ToteIDLabel = new Label(SOPickerToShipmentLink__ToteID);
                SOPickerToShipmentLink__ToteID.DataField = "SOPickerToShipmentLink__ToteID";
                DataMemberName = "PickListEntries";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void PXButtonDeletePickList()
            {
                Buttons.PXButtonDeletePickList.Click();
            }
            
            public virtual void Close()
            {
                Buttons.Close.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button PXButtonDeletePickList { get; }
			public Button Close { get; }
                
                public PxButtonCollection()
                {
                    PXButtonDeletePickList = new Button("ctl00_phG_PanelPickList_PXButtonDeletePickList", "PXButtonDeletePickList", "ctl00_phG_PanelPickList_PickListHeader");
                    Close = new Button("ctl00_phG_PanelPickList_PXButtonPickListClose", "Close", "ctl00_phG_PanelPickList_PickListHeader");
                }
            }
        }
        
        public class c_picklistentries_gridpicklist : Grid<c_picklistentries_gridpicklist.c_grid_row, c_picklistentries_gridpicklist.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_picklistentries_gridpicklist(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelPickList_gridPickList");
                DataMemberName = "PickListEntries";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PanelPickList_gridPickList_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
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
            
            public virtual void PXButtonDeletePickList()
            {
                Buttons.PXButtonDeletePickList.Click();
            }
            
            public virtual void Close()
            {
                Buttons.Close.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelPickList_gridPickList_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelPickList_gridPickList_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelPickList_gridPickList_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelPickList_gridPickList_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelPickList_gridPickList_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelPickList_gridPickList_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelPickList_gridPickList_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelPickList_gridPickList_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelPickList_gridPickList_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button PXButtonDeletePickList { get; }
			public Button Close { get; }
                
                public PxButtonCollection()
                {
                    PXButtonDeletePickList = new Button("ctl00_phG_PanelPickList_PXButtonDeletePickList", "PXButtonDeletePickList", "ctl00_phG_PanelPickList_gridPickList");
                    Close = new Button("ctl00_phG_PanelPickList_PXButtonPickListClose", "Close", "ctl00_phG_PanelPickList_gridPickList");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector LocationID { get; }
			public PXTextEdit InventoryID { get; }
			public Selector SubItemID { get; }
			public PXTextEdit LotSerialNbr { get; }
			public PXNumberEdit Qty { get; }
			public Selector UOM { get; }
			public DateSelector ExpireDate { get; }
			public PXNumberEdit PickedQty { get; }
                
                public c_grid_row(c_picklistentries_gridpicklist grid) : 
                        base(grid)
                {
                    LocationID = new Selector("_ctl00_phG_PanelPickList_gridPickList_lv0_edPick_LocationID", "Location ID", grid.Locator, "LocationID");
                    LocationID.DataField = "LocationID";
                    InventoryID = new PXTextEdit("ctl00_phG_PanelPickList_gridPickList_ei", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SubItemID = new Selector("_ctl00_phG_PanelPickList_gridPickList_lv0_edPick_SubItemID", "Sub Item ID", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    LotSerialNbr = new PXTextEdit("_ctl00_phG_PanelPickList_gridPickList_lv0_edPick_LotSerialNbr", "Lot Serial Nbr", grid.Locator, "LotSerialNbr");
                    LotSerialNbr.DataField = "LotSerialNbr";
                    Qty = new PXNumberEdit("_ctl00_phG_PanelPickList_gridPickList_lv0_edPick_Qty", "Qty", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    UOM = new Selector("_ctl00_phG_PanelPickList_gridPickList_lv0_edPick_UOM", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    ExpireDate = new DateSelector("_ctl00_phG_PanelPickList_gridPickList_lv0_edPick_ExpireDate", "Expire Date", grid.Locator, "ExpireDate");
                    ExpireDate.DataField = "ExpireDate";
                    PickedQty = new PXNumberEdit("_ctl00_phG_PanelPickList_gridPickList_lv0_edPick_PickedQty", "Picked Qty", grid.Locator, "PickedQty");
                    PickedQty.DataField = "PickedQty";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter LocationID { get; }
				public PXTextEditColumnFilter InventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public PXTextEditColumnFilter LotSerialNbr { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public SelectorColumnFilter UOM { get; }
				public DateSelectorColumnFilter ExpireDate { get; }
				public PXNumberEditColumnFilter PickedQty { get; }
                
                public c_grid_header(c_picklistentries_gridpicklist grid) : 
                        base(grid)
                {
                    LocationID = new SelectorColumnFilter(grid.Row.LocationID);
                    InventoryID = new PXTextEditColumnFilter(grid.Row.InventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    LotSerialNbr = new PXTextEditColumnFilter(grid.Row.LotSerialNbr);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    ExpireDate = new DateSelectorColumnFilter(grid.Row.ExpireDate);
                    PickedQty = new PXNumberEditColumnFilter(grid.Row.PickedQty);
                }
            }
        }
        
        public class c_picklistentries_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector LocationID { get; }
			public Label LocationIDLabel { get; }
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public PXNumberEdit Qty { get; }
			public Label QtyLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public PXTextEdit LotSerialNbr { get; }
			public Label LotSerialNbrLabel { get; }
			public DateSelector ExpireDate { get; }
			public Label ExpireDateLabel { get; }
			public PXNumberEdit PickedQty { get; }
			public Label PickedQtyLabel { get; }
            
            public c_picklistentries_lv0(string locator, string name) : 
                    base(locator, name)
            {
                LocationID = new Selector("ctl00_phG_PanelPickList_gridPickList_lv0_edPick_LocationID", "Location ID", locator, null);
                LocationIDLabel = new Label(LocationID);
                LocationID.DataField = "LocationID";
                SubItemID = new Selector("ctl00_phG_PanelPickList_gridPickList_lv0_edPick_SubItemID", "Sub Item ID", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                Qty = new PXNumberEdit("ctl00_phG_PanelPickList_gridPickList_lv0_edPick_Qty", "Qty", locator, null);
                QtyLabel = new Label(Qty);
                Qty.DataField = "Qty";
                UOM = new Selector("ctl00_phG_PanelPickList_gridPickList_lv0_edPick_UOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                LotSerialNbr = new PXTextEdit("ctl00_phG_PanelPickList_gridPickList_lv0_edPick_LotSerialNbr", "Lot Serial Nbr", locator, null);
                LotSerialNbrLabel = new Label(LotSerialNbr);
                LotSerialNbr.DataField = "LotSerialNbr";
                ExpireDate = new DateSelector("ctl00_phG_PanelPickList_gridPickList_lv0_edPick_ExpireDate", "Expire Date", locator, null);
                ExpireDateLabel = new Label(ExpireDate);
                ExpireDate.DataField = "ExpireDate";
                PickedQty = new PXNumberEdit("ctl00_phG_PanelPickList_gridPickList_lv0_edPick_PickedQty", "Picked Qty", locator, null);
                PickedQtyLabel = new Label(PickedQty);
                PickedQty.DataField = "PickedQty";
                DataMemberName = "PickListEntries";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void PXButtonDeletePickList()
            {
                Buttons.PXButtonDeletePickList.Click();
            }
            
            public virtual void Close()
            {
                Buttons.Close.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button PXButtonDeletePickList { get; }
			public Button Close { get; }
                
                public PxButtonCollection()
                {
                    PXButtonDeletePickList = new Button("ctl00_phG_PanelPickList_PXButtonDeletePickList", "PXButtonDeletePickList", "ctl00_phG_PanelPickList_gridPickList_lv0");
                    Close = new Button("ctl00_phG_PanelPickList_PXButtonPickListClose", "Close", "ctl00_phG_PanelPickList_gridPickList_lv0");
                }
            }
        }
        
        public class c_workflowview_workflowfictivediagram : Container
        {
            
            public PxButtonCollection Buttons;
            
			public UnknownControl Layout { get; }
			public Label LayoutLabel { get; }
            
            public c_workflowview_workflowfictivediagram(string locator, string name) : 
                    base(locator, name)
            {
                Layout = new UnknownControl("ctl00_usrCaption_WorkflowDiagram_pnlWorkFlow_WorkflowFictiveDiagram_diagram", "Layout", locator, null);
                LayoutLabel = new Label(Layout);
                Layout.DataField = "Layout";
                DataMemberName = "WorkflowView";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Customize()
            {
                Buttons.Customize.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Customize { get; }
                
                public PxButtonCollection()
                {
                    Customize = new Button("ctl00_usrCaption_WorkflowDiagram_pnlWorkFlow_PXButtonCustomize", "Customize", "ctl00_usrCaption_WorkflowDiagram_pnlWorkFlow_WorkflowFictiveDiagram");
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
        
        public class c_attributes : Container
        {
            
            public c_attributes(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = null;
            }
        }
    }
}
