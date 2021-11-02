using Api;
using Controls;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.EmailEdit;
using Controls.Editors.LinkEdit;
using Controls.Editors.QuickSearch;
using Controls.Editors.Selector;
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
using Controls.RichTextEdit;
using Controls.ToolBarButton;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace GeneratedWrappers.Acumatica
{
    
    
    public class AP303000_VendorMaint : Wrapper
    {
        
        public Note NotePanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
        protected c_baccount_baccount BAccount_BAccount { get; } = new c_baccount_baccount("ctl00_phF_BAccount", "BAccount_BAccount");
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
        protected c_locations_grdlocations Locations_grdLocations { get; } = new c_locations_grdlocations("ctl00_phG_tab_t6_grdLocations", "Locations_grdLocations");
        protected c_locations_lv0 Locations_lv0 { get; } = new c_locations_lv0("ctl00_phG_tab_t6_grdLocations_lv0", "Locations_lv0");
        protected c_deflocation_deflocationpayment DefLocation_DefLocationPayment { get; } = new c_deflocation_deflocationpayment("ctl00_phG_tab_t2_DefLocationPayment", "DefLocation_DefLocationPayment");
        protected c_currentvendor_deflocationpayment CurrentVendor_DefLocationPayment { get; } = new c_currentvendor_deflocationpayment("ctl00_phG_tab_t2_DefLocationPayment", "CurrentVendor_DefLocationPayment");
        protected c_deflocation_deflocation DefLocation_DefLocation { get; } = new c_deflocation_deflocation("ctl00_phG_tab_t3_DefLocation", "DefLocation_DefLocation");
        protected c_deflocationbranchsettings_deflocation DefLocationBranchSettings_DefLocation { get; } = new c_deflocationbranchsettings_deflocation("ctl00_phG_tab_t3_DefLocation", "DefLocationBranchSettings_DefLocation");
        protected c_deflocation_deflocationglaccounts DefLocation_DefLocationGLAccounts { get; } = new c_deflocation_deflocationglaccounts("ctl00_phG_tab_t9_DefLocationGLAccounts", "DefLocation_DefLocationGLAccounts");
        protected c_deflocation_formretainage DefLocation_formRetainage { get; } = new c_deflocation_formretainage("ctl00_phG_tab_t9_formRetainage", "DefLocation_formRetainage");
        protected c_defaddress_defaddress DefAddress_DefAddress { get; } = new c_defaddress_defaddress("ctl00_phG_tab_t0_DefAddress", "DefAddress_DefAddress");
        protected c_deflocationaddress_deflocationaddress DefLocationAddress_DefLocationAddress { get; } = new c_deflocationaddress_deflocationaddress("ctl00_phG_tab_t3_DefLocation_DefLocationAddress", "DefLocationAddress_DefLocationAddress");
        protected c_remitaddress_remitaddress RemitAddress_RemitAddress { get; } = new c_remitaddress_remitaddress("ctl00_phG_tab_t2_DefLocationPayment_RemitAddress", "RemitAddress_RemitAddress");
        protected c_contacts_grdcontacts Contacts_grdContacts { get; } = new c_contacts_grdcontacts("ctl00_phG_tab_t7_grdContacts", "Contacts_grdContacts");
        protected c_contacts_lv0 Contacts_lv0 { get; } = new c_contacts_lv0("ctl00_phG_tab_t7_grdContacts_lv0", "Contacts_lv0");
        protected c_defcontact_defcontact1 DefContact_DefContact1 { get; } = new c_defcontact_defcontact1("ctl00_phG_tab_t0_DefContact1", "DefContact_DefContact1");
        protected c_defcontact_defcontact2 DefContact_DefContact2 { get; } = new c_defcontact_defcontact2("ctl00_phG_tab_t0_DefContact2", "DefContact_DefContact2");
        protected c_deflocationcontact_deflocationcontact DefLocationContact_DefLocationContact { get; } = new c_deflocationcontact_deflocationcontact("ctl00_phG_tab_t3_DefLocation_DefLocationContact", "DefLocationContact_DefLocationContact");
        protected c_remitcontact_remitcontact RemitContact_RemitContact { get; } = new c_remitcontact_remitcontact("ctl00_phG_tab_t2_DefLocationPayment_RemitContact", "RemitContact_RemitContact");
        protected c_primarycontactcurrent_frmprimarycontact PrimaryContactCurrent_frmPrimaryContact { get; } = new c_primarycontactcurrent_frmprimarycontact("ctl00_phG_tab_t0_frmPrimaryContact", "PrimaryContactCurrent_frmPrimaryContact");
        protected c_vendorbalance_vendorbalance VendorBalance_VendorBalance { get; } = new c_vendorbalance_vendorbalance("ctl00_phF_BAccount_t0_VendorBalance", "VendorBalance_VendorBalance");
        protected c_vendorbalancebybasecurrency_pxgrid1 VendorBalanceByBaseCurrency_PXGrid1 { get; } = new c_vendorbalancebybasecurrency_pxgrid1("ctl00_phG_tab_t4_PXGrid1", "VendorBalanceByBaseCurrency_PXGrid1");
        protected c_vendorbalancebybasecurrency_lv0 VendorBalanceByBaseCurrency_lv0 { get; } = new c_vendorbalancebybasecurrency_lv0("ctl00_phG_tab_t4_PXGrid1_lv0", "VendorBalanceByBaseCurrency_lv0");
        protected c_notificationsources_gridns NotificationSources_gridNS { get; } = new c_notificationsources_gridns("ctl00_phG_tab_t11_sp1_gridNS", "NotificationSources_gridNS");
        protected c_notificationsources_lv0 NotificationSources_lv0 { get; } = new c_notificationsources_lv0("ctl00_phG_tab_t11_sp1_gridNS_lv0", "NotificationSources_lv0");
        protected c_notificationrecipients_gridnr NotificationRecipients_gridNR { get; } = new c_notificationrecipients_gridnr("ctl00_phG_tab_t11_sp1_gridNR", "NotificationRecipients_gridNR");
        protected c_notificationrecipients_lv0 NotificationRecipients_lv0 { get; } = new c_notificationrecipients_lv0("ctl00_phG_tab_t11_sp1_gridNR_lv0", "NotificationRecipients_lv0");
        protected c_activities_activities_grid Activities_Activities_grid { get; } = new c_activities_activities_grid("ctl00_phG_tab_t8_gridActivities_Activities_grid", "Activities_Activities_grid");
        protected c_activities_lv0 Activities_lv0 { get; } = new c_activities_lv0("ctl00_phG_tab_t8_gridActivities_Activities_grid_lv0", "Activities_lv0");
        protected c_activities_preview_activities_form Activities_Preview_Activities_form { get; } = new c_activities_preview_activities_form("ctl00_phG_tab_t8_gridActivities_Activities_form", "Activities$Preview_Activities_form");
        protected c_answers_pxgridanswers Answers_PXGridAnswers { get; } = new c_answers_pxgridanswers("ctl00_phG_tab_t5_PXGridAnswers", "Answers_PXGridAnswers");
        protected c_answers_lv0 Answers_lv0 { get; } = new c_answers_lv0("ctl00_phG_tab_t5_PXGridAnswers_lv0", "Answers_lv0");
        protected c_suppliedbyvendors_pxgridsuppliedbyvendors SuppliedByVendors_PXGridSuppliedByVendors { get; } = new c_suppliedbyvendors_pxgridsuppliedbyvendors("ctl00_phG_tab_t12_PXGridSuppliedByVendors", "SuppliedByVendors_PXGridSuppliedByVendors");
        protected c_suppliedbyvendors_lv0 SuppliedByVendors_lv0 { get; } = new c_suppliedbyvendors_lv0("ctl00_phG_tab_t12_PXGridSuppliedByVendors_lv0", "SuppliedByVendors_lv0");
        protected c_contactinfo_formcreatecontact ContactInfo_formCreateContact { get; } = new c_contactinfo_formcreatecontact("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact", "ContactInfo_formCreateContact");
        protected c_contactinfo_tabcreatecontact ContactInfo_tabCreateContact { get; } = new c_contactinfo_tabcreatecontact("ctl00_phG_PanelCreateContact_tabCreateContact", "ContactInfo_tabCreateContact");
        protected c_contactinfoattributes_grdcontactinfoattributes ContactInfoAttributes_grdContactInfoAttributes { get; } = new c_contactinfoattributes_grdcontactinfoattributes("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes", "ContactInfoAttributes_grdContactInfoAttributes");
        protected c_contactinfoattributes_lv0 ContactInfoAttributes_lv0 { get; } = new c_contactinfoattributes_lv0("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lv0", "ContactInfoAttributes_lv0");
        protected c_contactinfoudf_grdcontactinfoudf ContactInfoUDF_grdContactInfoUDF { get; } = new c_contactinfoudf_grdcontactinfoudf("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF", "ContactInfoUDF_grdContactInfoUDF");
        protected c_contactinfoudf_lv0 ContactInfoUDF_lv0 { get; } = new c_contactinfoudf_lv0("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lv0", "ContactInfoUDF_lv0");
        protected c_paymentdetails_grdpaymentdetails PaymentDetails_grdPaymentDetails { get; } = new c_paymentdetails_grdpaymentdetails("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails", "PaymentDetails_grdPaymentDetails");
        protected c_paymentdetails_lv0 PaymentDetails_lv0 { get; } = new c_paymentdetails_lv0("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lv0", "PaymentDetails_lv0");
        protected c_addresslookupfilter_addresslookuppanelformaddress AddressLookupFilter_AddressLookupPanelformAddress { get; } = new c_addresslookupfilter_addresslookuppanelformaddress("ctl00_phG_AddressLookupPanel_AddressLookupPanelformAddress", "AddressLookupFilter_AddressLookupPanelformAddress");
        protected c_currentvendor_tab CurrentVendor_tab { get; } = new c_currentvendor_tab("ctl00_phG_tab", "CurrentVendor_tab");
        protected c_currentvendor_currentvendor2 CurrentVendor_CurrentVendor2 { get; } = new c_currentvendor_currentvendor2("ctl00_phG_tab_t0_CurrentVendor2", "CurrentVendor_CurrentVendor2");
        protected c_currentvendor_vendordefaults CurrentVendor_VendorDefaults { get; } = new c_currentvendor_vendordefaults("ctl00_phG_tab_t0_VendorDefaults", "CurrentVendor_VendorDefaults");
        protected c_currentvendor_pxformview1 CurrentVendor_PXFormView1 { get; } = new c_currentvendor_pxformview1("ctl00_phG_tab_t3_DefLocation_PXFormView1", "CurrentVendor_PXFormView1");
        protected c_changeiddialog_formchangeid ChangeIDDialog_formChangeID { get; } = new c_changeiddialog_formchangeid("ctl00_phF_pnlChangeID_formChangeID", "ChangeIDDialog_formChangeID");
        protected c_compliancedocuments_grdcompliancedocuments ComplianceDocuments_grdComplianceDocuments { get; } = new c_compliancedocuments_grdcompliancedocuments("ctl00_phG_tab_t13_grdComplianceDocuments", "ComplianceDocuments_grdComplianceDocuments");
        protected c_compliancedocuments_lv0 ComplianceDocuments_lv0 { get; } = new c_compliancedocuments_lv0("ctl00_phG_tab_t13_grdComplianceDocuments_lv0", "ComplianceDocuments_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        public c_attributes Attributes { get; } = new c_attributes("ctl00_phF_BAccount_t1", "Attributes");
        
        public AP303000_VendorMaint()
        {
            ScreenId = "AP303000";
            ScreenUrl = "/Pages/AP/AP303000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual AP303000_VendorMaint ReadOne(Gate gate, string AcctCD)
        {
            new BiObject<AP303000_VendorMaint>(gate).ReadOne(this, AcctCD);
            return this;
        }
        
        public virtual AP303000_VendorMaint ReadOne(string AcctCD)
        {
            return this.ReadOne(ApiConnection.Source, AcctCD);
        }
        
        public virtual void SyncTOC()
        {
            ToolBar.SyncTOC.Click();
        }
        
        public virtual void Note()
        {
            ToolBar.Note.Click();
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
        
        public virtual void CreateContact()
        {
            ToolBar.CreateContact.Click();
        }
        
        public virtual void CreateContact(bool status, string message = null)
        {
            ToolBar.CreateContact.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.CreateContact.Click();
        }
        
        public virtual void ExtendToCustomer()
        {
            ToolBar.ExtendToCustomer.Click();
        }
        
        public virtual void NewBillAdjustment()
        {
            ToolBar.NewBillAdjustment.Click();
        }
        
        public virtual void NewManualCheck()
        {
            ToolBar.NewManualCheck.Click();
        }
        
        public virtual void ApproveBillsForPayments()
        {
            ToolBar.ApproveBillsForPayments.Click();
        }
        
        public virtual void PayBills()
        {
            ToolBar.PayBills.Click();
        }
        
        public virtual void ChangeID()
        {
            ToolBar.ChangeID.Click();
        }
        
        public virtual void ValidateAddresses()
        {
            ToolBar.ValidateAddresses.Click();
        }
        
        public virtual void ViewBusnessAccount()
        {
            ToolBar.ViewBusnessAccount.Click();
        }
        
        public virtual void ViewCustomer()
        {
            ToolBar.ViewCustomer.Click();
        }
        
        public virtual void ViewRestrictionGroups()
        {
            ToolBar.ViewRestrictionGroups.Click();
        }
        
        public virtual void VendorDetails()
        {
            ToolBar.VendorDetails.Click();
        }
        
        public virtual void VendorPrice()
        {
            ToolBar.VendorPrice.Click();
        }
        
        public virtual void BalanceByVendor()
        {
            ToolBar.BalanceByVendor.Click();
        }
        
        public virtual void APDocumentRegister()
        {
            ToolBar.APDocumentRegister.Click();
        }
        
        public virtual void VendorHistory()
        {
            ToolBar.VendorHistory.Click();
        }
        
        public virtual void APAgedPastDue()
        {
            ToolBar.APAgedPastDue.Click();
        }
        
        public virtual void APAgedOutstanding()
        {
            ToolBar.APAgedOutstanding.Click();
        }
        
        public virtual void RepVendorDetails()
        {
            ToolBar.RepVendorDetails.Click();
        }
        
        public virtual void ViewactivityWorkflow()
        {
            ToolBar.ViewactivityWorkflow.Click();
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
        
        public virtual void Action()
        {
            ToolBar.Action.Click();
        }
        
        public virtual void VendorManagement()
        {
            ToolBar.VendorManagement.Click();
        }
        
        public virtual void DocumentProcessing()
        {
            ToolBar.DocumentProcessing.Click();
        }
        
        public virtual void CustomOther()
        {
            ToolBar.CustomOther.Click();
        }
        
        public virtual void Inquiry()
        {
            ToolBar.Inquiry.Click();
        }
        
        public virtual void Report()
        {
            ToolBar.Report.Click();
        }
        
        public virtual void RefreshContact()
        {
            ToolBar.RefreshContact.Click();
        }
        
        public virtual void ViewContact()
        {
            ToolBar.ViewContact.Click();
        }
        
        public virtual void CreateContactRedirect()
        {
            ToolBar.CreateContactRedirect.Click();
        }
        
        public virtual void AddNewPrimaryContact()
        {
            ToolBar.AddNewPrimaryContact.Click();
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
			public ToolBarButton FilesMenuShow { get; }
			public ToolBarButton Custom { get; }
			public ToolBarButton ActionSelectWorkingProject { get; }
			public ToolBarButton InspectElementCtrlAltClick { get; }
			public ToolBarButton ManageAttributes { get; }
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
			public ToolBarButton CreateContact { get; }
			public ToolBarButton ExtendToCustomer { get; }
			public ToolBarButton NewBillAdjustment { get; }
			public ToolBarButton NewManualCheck { get; }
			public ToolBarButton ApproveBillsForPayments { get; }
			public ToolBarButton PayBills { get; }
			public ToolBarButton ChangeID { get; }
			public ToolBarButton ValidateAddresses { get; }
			public ToolBarButton ViewBusnessAccount { get; }
			public ToolBarButton ViewCustomer { get; }
			public ToolBarButton ViewRestrictionGroups { get; }
			public ToolBarButton VendorDetails { get; }
			public ToolBarButton VendorPrice { get; }
			public ToolBarButton BalanceByVendor { get; }
			public ToolBarButton APDocumentRegister { get; }
			public ToolBarButton VendorHistory { get; }
			public ToolBarButton APAgedPastDue { get; }
			public ToolBarButton APAgedOutstanding { get; }
			public ToolBarButton RepVendorDetails { get; }
			public ToolBarButton ViewactivityWorkflow { get; }
			public ToolBarButton OpenactivityownerWorkflow { get; }
			public ToolBarButton ViewAllActivities { get; }
			public ToolBarButton ViewallactivitiesWorkflow { get; }
			public ToolBarButton Action { get; }
			public ToolBarButton VendorManagement { get; }
			public ToolBarButton DocumentProcessing { get; }
			public ToolBarButton CustomOther { get; }
			public ToolBarButton Inquiry { get; }
			public ToolBarButton Report { get; }
			public ToolBarButton RefreshContact { get; }
			public ToolBarButton ViewContact { get; }
			public ToolBarButton CreateContactRedirect { get; }
			public ToolBarButton AddNewPrimaryContact { get; }
			public ToolBarButton LongRun { get; }
			public ToolBarButton LongrunCancel { get; }
			public ToolBarButton LongrunTimer { get; }
            
            public PxToolBar(string locator)
            {
                SyncTOC = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
                Note = new ToolBarButton("css=#ctl00_usrCaption_tlbDataView div[data-cmd=\'NoteShow\']", "Add Note", locator, null);
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
                Delete.ConfirmAction = () => Alert.AlertToException("The current Vendor record will be deleted.");
                CopyPaste = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CopyPaste", "Clipboard", locator, null);
                CopyDocument = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@CopyDocument\']", "CopyDocument", locator, CopyPaste);
                PasteDocument = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@PasteDocument\']", "PasteDocument", locator, CopyPaste);
                SaveTemplate = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@SaveTemplate\']", "SaveTemplate", locator, CopyPaste);
                First = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_First", "Go to First Record", locator, null);
                Previous = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Previous", "Go to Previous Record (PgUp)", locator, null);
                Next = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Next", "Go to Next Record (PgDn)", locator, null);
                Last = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Last", "Go to Last Record", locator, null);
                CreateContact = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_createContact,#ctl00_phDS_ds_ToolBar_createContact_ite" +
                        "m", "Create Contact", locator, MenuOpener);
                CreateContact.WaitAction = Wait.WaitForLongOperationToComplete;
                ExtendToCustomer = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ExtendToCustomer,#ctl00_phDS_ds_ToolBar_ExtendToCustom" +
                        "er_item", "Extend as Customer", locator, MenuOpener);
                NewBillAdjustment = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_NewBillAdjustment,#ctl00_phDS_ds_ToolBar_NewBillAdjust" +
                        "ment_item", "Create Bill", locator, MenuOpener);
                NewManualCheck = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_NewManualCheck,#ctl00_phDS_ds_ToolBar_NewManualCheck_i" +
                        "tem", "Create Payment", locator, MenuOpener);
                ApproveBillsForPayments = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ApproveBillsForPayments,#ctl00_phDS_ds_ToolBar_Approve" +
                        "BillsForPayments_item", "Approve Bills for Payment", locator, MenuOpener);
                PayBills = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PayBills,#ctl00_phDS_ds_ToolBar_PayBills_item", "Pay Bills", locator, MenuOpener);
                ChangeID = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ChangeID,#ctl00_phDS_ds_ToolBar_ChangeID_item", "Change ID", locator, MenuOpener);
                ValidateAddresses = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_validateAddresses,#ctl00_phDS_ds_ToolBar_validateAddre" +
                        "sses_item", "Validate Addresses", locator, MenuOpener);
                ViewBusnessAccount = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewBusnessAccount,#ctl00_phDS_ds_ToolBar_ViewBusnessA" +
                        "ccount_item", "View Account", locator, MenuOpener);
                ViewCustomer = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewCustomer,#ctl00_phDS_ds_ToolBar_ViewCustomer_item", "View Customer", locator, MenuOpener);
                ViewRestrictionGroups = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewRestrictionGroups,#ctl00_phDS_ds_ToolBar_ViewRestr" +
                        "ictionGroups_item", "Manage Restriction Groups", locator, MenuOpener);
                VendorDetails = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_VendorDetails,#ctl00_phDS_ds_ToolBar_VendorDetails_ite" +
                        "m", "Vendor Details", locator, MenuOpener);
                VendorPrice = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_VendorPrice,#ctl00_phDS_ds_ToolBar_VendorPrice_item", "Vendor Prices", locator, MenuOpener);
                BalanceByVendor = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_BalanceByVendor,#ctl00_phDS_ds_ToolBar_BalanceByVendor" +
                        "_item", "AP Balance by Vendor", locator, MenuOpener);
                APDocumentRegister = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_APDocumentRegister,#ctl00_phDS_ds_ToolBar_APDocumentRe" +
                        "gister_item", "AP Register", locator, MenuOpener);
                VendorHistory = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_VendorHistory,#ctl00_phDS_ds_ToolBar_VendorHistory_ite" +
                        "m", "Vendor History", locator, MenuOpener);
                APAgedPastDue = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_APAgedPastDue,#ctl00_phDS_ds_ToolBar_APAgedPastDue_ite" +
                        "m", "AP Aging", locator, MenuOpener);
                APAgedOutstanding = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_APAgedOutstanding,#ctl00_phDS_ds_ToolBar_APAgedOutstan" +
                        "ding_item", "AP Coming Due", locator, MenuOpener);
                RepVendorDetails = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_RepVendorDetails,#ctl00_phDS_ds_ToolBar_RepVendorDetai" +
                        "ls_item", "Vendor Profile", locator, MenuOpener);
                ViewactivityWorkflow = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewActivity_Workflow,#ctl00_phDS_ds_ToolBar_ViewActiv" +
                        "ity_Workflow_item", "Details", locator, MenuOpener);
                OpenactivityownerWorkflow = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_OpenActivityOwner_Workflow,#ctl00_phDS_ds_ToolBar_Open" +
                        "ActivityOwner_Workflow_item", "OpenActivityOwner_Workflow", locator, MenuOpener);
                ViewAllActivities = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewAllActivities,#ctl00_phDS_ds_ToolBar_ViewAllActivi" +
                        "ties_item", "View Activities", locator, MenuOpener);
                ViewallactivitiesWorkflow = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewAllActivities_Workflow,#ctl00_phDS_ds_ToolBar_View" +
                        "AllActivities_Workflow_item", "View Activities", locator, MenuOpener);
                Action = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Action", "Actions", locator, MenuOpener);
                VendorManagement = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_VendorManagement", "Vendor Management", locator, MenuOpener);
                DocumentProcessing = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_DocumentProcessing", "Document Processing", locator, MenuOpener);
                CustomOther = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CustomOther", "Other", locator, MenuOpener);
                Inquiry = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Inquiry", "Inquiries", locator, MenuOpener);
                Report = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Report", "Reports", locator, MenuOpener);
                RefreshContact = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_refreshContact,#ctl00_phDS_ds_ToolBar_refreshContact_i" +
                        "tem", "refreshContact", locator, MenuOpener);
                ViewContact = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_viewContact,#ctl00_phDS_ds_ToolBar_viewContact_item", "Contact Details", locator, MenuOpener);
                CreateContactRedirect = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_createContactRedirect,#ctl00_phDS_ds_ToolBar_createCon" +
                        "tactRedirect_item", "Create Contact with Redirect", locator, MenuOpener);
                AddNewPrimaryContact = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_addNewPrimaryContact,#ctl00_phDS_ds_ToolBar_addNewPrim" +
                        "aryContact_item", "New Contact", locator, MenuOpener);
                LongRun = new ToolBarButton("css=qp-long-run", "Nothing in progress", locator, null);
                LongrunCancel = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_cancel", "Cancel", locator, null);
                LongrunTimer = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_timer", "Elapsed Time", locator, null);
            }
        }
        
        public class c_baccount_baccount : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector AcctCD { get; }
			public Label AcctCDLabel { get; }
			public DropDown VStatus { get; }
			public Label VStatusLabel { get; }
			public Selector VendorClassID { get; }
			public Label VendorClassIDLabel { get; }
			public Label Ctl02_ { get; }
            
            public c_baccount_baccount(string locator, string name) : 
                    base(locator, name)
            {
                AcctCD = new Selector("ctl00_phF_BAccount_t0_edAcctCD", "Vendor ID", locator, null);
                AcctCDLabel = new Label(AcctCD);
                AcctCD.DataField = "AcctCD";
                VStatus = new DropDown("ctl00_phF_BAccount_t0_edVStatus", "Vendor Status", locator, null);
                VStatusLabel = new Label(VStatus);
                VStatus.DataField = "VStatus";
                VStatus.Items.Add("A", "Active");
                VStatus.Items.Add("H", "On Hold");
                VStatus.Items.Add("P", "Hold Payments");
                VStatus.Items.Add("T", "One-Time");
                VStatus.Items.Add("I", "Inactive");
                VendorClassID = new Selector("ctl00_phF_BAccount_t0_edVendorClassID", "Vendor Class", locator, null);
                VendorClassIDLabel = new Label(VendorClassID);
                VendorClassID.DataField = "VendorClassID";
                Ctl02_ = new Label("ctl00_phF_BAccount_t1_ctl02", "No user-defined fields have been found.", locator, null);
                DataMemberName = "BAccount";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void VendorClassIDEdit()
            {
                Buttons.VendorClassIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button VendorClassIDEdit { get; }
                
                public PxButtonCollection()
                {
                    VendorClassIDEdit = new Button("css=div[id=\'ctl00_phF_BAccount_t0_edVendorClassID\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "VendorClassIDEdit", "ctl00_phF_BAccount");
                    VendorClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
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
        
        public class c_locations_grdlocations : Grid<c_locations_grdlocations.c_grid_row, c_locations_grdlocations.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public DropDown PredefinedFilter { get; }
			public QuickSearch QuickSearch { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_locations_grdlocations(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t6_grdLocations");
                DataMemberName = "Locations";
                PredefinedFilter = new DropDown("ctl00_phG_tab_t6_grdLocations_at_tlb_fs", "Predefined Filter", locator, null);
                PredefinedFilter.Items.Add("00000000-0000-0000-0000-000000000000", "All Records");
                QuickSearch = new QuickSearch("ctl00_phG_tab_t6_grdLocations_at_tlb_fb", "QuickSearch", locator, null);
                FilterForm = new c_grid_filter("ctl00_phG_tab_t6_grdLocations_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void NewLocation()
            {
                ToolBar.NewLocation.Click();
            }
            
            public virtual void LocationDetails()
            {
                ToolBar.LocationDetails.Click();
            }
            
            public virtual void SetDefaultLocation()
            {
                ToolBar.SetDefaultLocation.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Filter()
            {
                ToolBar.Filter.Click();
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
			public ToolBarButtonGrid NewLocation { get; }
			public ToolBarButtonGrid LocationDetails { get; }
			public ToolBarButtonGrid SetDefaultLocation { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Filter { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdLocations_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    NewLocation = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdLocations_at_tlb div[data-cmd=\'NewLocation\']", "Add New Location", locator, null);
                    LocationDetails = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdLocations_at_tlb div[data-cmd=\'cmdViewLocation\']", "Location Details", locator, null);
                    SetDefaultLocation = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdLocations_at_tlb div[data-cmd=\'SetDefaultLocation\']", "Set as Default", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdLocations_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdLocations_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Filter = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdLocations_at_tlb div[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdLocations_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdLocations_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdLocations_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdLocations_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdLocations_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t6_grdLocations_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox IsActive { get; }
			public Selector LocationCD { get; }
			public PXTextEdit Descr { get; }
			public CheckBox IsDefault { get; }
			public PXTextEdit Address__City { get; }
			public Selector Address__State { get; }
			public Selector Address__CountryID { get; }
			public PXTextEdit Address__PostalCode { get; }
			public PXTextEdit Address__State_description { get; }
			public PXTextEdit Address__CountryID_description { get; }
			public Selector VExpenseAcctID { get; }
			public Selector VExpenseSubID { get; }
			public PXTextEdit PaymentMethodID { get; }
			public PXTextEdit PaymentLeadTime { get; }
			public Selector VBranchID { get; }
			public PXTextEdit VBranchID_description { get; }
			public PXTextEdit CreatedByID_Description { get; }
			public DateSelector CreatedDateTime { get; }
			public PXTextEdit LastModifiedByID_Description { get; }
			public DateSelector LastModifiedDateTime { get; }
			public PXTextEdit TaxRegistrationID { get; }
			public Selector VTaxZoneID { get; }
			public DropDown VTaxCalcMode { get; }
			public Selector VSiteID { get; }
			public Selector VCarrierID { get; }
			public Selector VShipTermsID { get; }
			public Selector VFOBPointID { get; }
			public PXNumberEdit VLeadTime { get; }
			public PXTextEdit VAllowAPBillBeforeReceipt { get; }
			public PXNumberEdit VRcptQtyMin { get; }
			public PXNumberEdit VRcptQtyMax { get; }
			public PXNumberEdit VRcptQtyThreshold { get; }
			public DropDown VRcptQtyAction { get; }
			public PXNumberEdit BAccountID { get; }
                
                public c_grid_row(c_locations_grdlocations grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    IsActive = new CheckBox("ctl00_phG_tab_t6_grdLocations_ef", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    LocationCD = new Selector("_ctl00_phG_tab_t6_grdLocations_lv0_es", "Location ID", grid.Locator, "LocationCD");
                    LocationCD.DataField = "LocationCD";
                    Descr = new PXTextEdit("ctl00_phG_tab_t6_grdLocations_ei", "Location Name", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    IsDefault = new CheckBox("ctl00_phG_tab_t6_grdLocations", "Default", grid.Locator, "IsDefault");
                    IsDefault.DataField = "IsDefault";
                    Address__City = new PXTextEdit("ctl00_phG_tab_t6_grdLocations_ei", "City", grid.Locator, "Address__City");
                    Address__City.DataField = "Address__City";
                    Address__State = new Selector("_ctl00_phG_tab_t6_grdLocations_lv0_es", "State", grid.Locator, "Address__State");
                    Address__State.DataField = "Address__State";
                    Address__CountryID = new Selector("_ctl00_phG_tab_t6_grdLocations_lv0_es", "Country", grid.Locator, "Address__CountryID");
                    Address__CountryID.DataField = "Address__CountryID";
                    Address__PostalCode = new PXTextEdit("ctl00_phG_tab_t6_grdLocations_ei", "Postal Code", grid.Locator, "Address__PostalCode");
                    Address__PostalCode.DataField = "Address__PostalCode";
                    Address__State_description = new PXTextEdit("ctl00_phG_tab_t6_grdLocations_ei", "State Name", grid.Locator, "Address__State_description");
                    Address__State_description.DataField = "Address__State_description";
                    Address__CountryID_description = new PXTextEdit("ctl00_phG_tab_t6_grdLocations_ei", "Country Name", grid.Locator, "Address__CountryID_description");
                    Address__CountryID_description.DataField = "Address__CountryID_description";
                    VExpenseAcctID = new Selector("_ctl00_phG_tab_t6_grdLocations_lv0_es", "Expense Account", grid.Locator, "VExpenseAcctID");
                    VExpenseAcctID.DataField = "VExpenseAcctID";
                    VExpenseSubID = new Selector("_ctl00_phG_tab_t6_grdLocations_lv0_es", "Expense Sub.", grid.Locator, "VExpenseSubID");
                    VExpenseSubID.DataField = "VExpenseSubID";
                    PaymentMethodID = new PXTextEdit("ctl00_phG_tab_t6_grdLocations_ei", "Payment Method ID", grid.Locator, "PaymentMethodID");
                    PaymentMethodID.DataField = "PaymentMethodID";
                    PaymentLeadTime = new PXTextEdit("ctl00_phG_tab_t6_grdLocations_ei", "Payment Lead Time", grid.Locator, "PaymentLeadTime");
                    PaymentLeadTime.DataField = "PaymentLeadTime";
                    VBranchID = new Selector("_ctl00_phG_tab_t6_grdLocations_lv0_es", "Default Branch", grid.Locator, "VBranchID");
                    VBranchID.DataField = "VBranchID";
                    VBranchID_description = new PXTextEdit("ctl00_phG_tab_t6_grdLocations_ei", "Branch Name", grid.Locator, "VBranchID_description");
                    VBranchID_description.DataField = "VBranchID_description";
                    CreatedByID_Description = new PXTextEdit("ctl00_phG_tab_t6_grdLocations_ei", "Created By", grid.Locator, "CreatedByID_Description");
                    CreatedByID_Description.DataField = "CreatedByID_Description";
                    CreatedDateTime = new DateSelector("_ctl00_phG_tab_t6_grdLocations_lv0_ed19", "CreatedDateTime", grid.Locator, "CreatedDateTime");
                    CreatedDateTime.DataField = "CreatedDateTime";
                    LastModifiedByID_Description = new PXTextEdit("ctl00_phG_tab_t6_grdLocations_ei", "Last Modified By", grid.Locator, "LastModifiedByID_Description");
                    LastModifiedByID_Description.DataField = "LastModifiedByID_Description";
                    LastModifiedDateTime = new DateSelector("_ctl00_phG_tab_t6_grdLocations_lv0_ed21", "LastModifiedDateTime", grid.Locator, "LastModifiedDateTime");
                    LastModifiedDateTime.DataField = "LastModifiedDateTime";
                    TaxRegistrationID = new PXTextEdit("ctl00_phG_tab_t6_grdLocations_ei", "Tax Registration ID", grid.Locator, "TaxRegistrationID");
                    TaxRegistrationID.DataField = "TaxRegistrationID";
                    VTaxZoneID = new Selector("_ctl00_phG_tab_t6_grdLocations_lv0_es", "Tax Zone", grid.Locator, "VTaxZoneID");
                    VTaxZoneID.DataField = "VTaxZoneID";
                    VTaxCalcMode = new DropDown("_ctl00_phG_tab_t6_grdLocations_lv0_ec", "Tax Calculation Mode", grid.Locator, "VTaxCalcMode");
                    VTaxCalcMode.DataField = "VTaxCalcMode";
                    VTaxCalcMode.Items.Add("T", "Tax Settings");
                    VTaxCalcMode.Items.Add("G", "Gross");
                    VTaxCalcMode.Items.Add("N", "Net");
                    VSiteID = new Selector("_ctl00_phG_tab_t6_grdLocations_lv0_es", "Warehouse", grid.Locator, "VSiteID");
                    VSiteID.DataField = "VSiteID";
                    VCarrierID = new Selector("_ctl00_phG_tab_t6_grdLocations_lv0_es", "Ship Via", grid.Locator, "VCarrierID");
                    VCarrierID.DataField = "VCarrierID";
                    VShipTermsID = new Selector("_ctl00_phG_tab_t6_grdLocations_lv0_es", "Shipping Terms", grid.Locator, "VShipTermsID");
                    VShipTermsID.DataField = "VShipTermsID";
                    VFOBPointID = new Selector("_ctl00_phG_tab_t6_grdLocations_lv0_es", "FOB Point", grid.Locator, "VFOBPointID");
                    VFOBPointID.DataField = "VFOBPointID";
                    VLeadTime = new PXNumberEdit("ctl00_phG_tab_t6_grdLocations_en", "Lead Time (Days)", grid.Locator, "VLeadTime");
                    VLeadTime.DataField = "VLeadTime";
                    VAllowAPBillBeforeReceipt = new PXTextEdit("ctl00_phG_tab_t6_grdLocations_ef", "Allow AP Bill Before Receipt", grid.Locator, "VAllowAPBillBeforeReceipt");
                    VAllowAPBillBeforeReceipt.DataField = "VAllowAPBillBeforeReceipt";
                    VRcptQtyMin = new PXNumberEdit("ctl00_phG_tab_t6_grdLocations_en", "Min. Receipt (%)", grid.Locator, "VRcptQtyMin");
                    VRcptQtyMin.DataField = "VRcptQtyMin";
                    VRcptQtyMax = new PXNumberEdit("ctl00_phG_tab_t6_grdLocations_en", "Max. Receipt (%)", grid.Locator, "VRcptQtyMax");
                    VRcptQtyMax.DataField = "VRcptQtyMax";
                    VRcptQtyThreshold = new PXNumberEdit("ctl00_phG_tab_t6_grdLocations_en", "Threshold Receipt (%)", grid.Locator, "VRcptQtyThreshold");
                    VRcptQtyThreshold.DataField = "VRcptQtyThreshold";
                    VRcptQtyAction = new DropDown("_ctl00_phG_tab_t6_grdLocations_lv0_ec", "Receipt Action", grid.Locator, "VRcptQtyAction");
                    VRcptQtyAction.DataField = "VRcptQtyAction";
                    VRcptQtyAction.Items.Add("R", "Reject");
                    VRcptQtyAction.Items.Add("W", "Accept but Warn");
                    VRcptQtyAction.Items.Add("A", "Accept");
                    BAccountID = new PXNumberEdit("ctl00_phG_tab_t6_grdLocations_en", "BAccountID", grid.Locator, "BAccountID");
                    BAccountID.DataField = "BAccountID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter IsActive { get; }
				public SelectorColumnFilter LocationCD { get; }
				public PXTextEditColumnFilter Descr { get; }
				public CheckBoxColumnFilter IsDefault { get; }
				public PXTextEditColumnFilter Address__City { get; }
				public SelectorColumnFilter Address__State { get; }
				public SelectorColumnFilter Address__CountryID { get; }
				public PXTextEditColumnFilter Address__PostalCode { get; }
				public PXTextEditColumnFilter Address__State_description { get; }
				public PXTextEditColumnFilter Address__CountryID_description { get; }
				public SelectorColumnFilter VExpenseAcctID { get; }
				public SelectorColumnFilter VExpenseSubID { get; }
				public PXTextEditColumnFilter PaymentMethodID { get; }
				public PXTextEditColumnFilter PaymentLeadTime { get; }
				public SelectorColumnFilter VBranchID { get; }
				public PXTextEditColumnFilter VBranchID_description { get; }
				public PXTextEditColumnFilter CreatedByID_Description { get; }
				public DateSelectorColumnFilter CreatedDateTime { get; }
				public PXTextEditColumnFilter LastModifiedByID_Description { get; }
				public DateSelectorColumnFilter LastModifiedDateTime { get; }
				public PXTextEditColumnFilter TaxRegistrationID { get; }
				public SelectorColumnFilter VTaxZoneID { get; }
				public DropDownColumnFilter VTaxCalcMode { get; }
				public SelectorColumnFilter VSiteID { get; }
				public SelectorColumnFilter VCarrierID { get; }
				public SelectorColumnFilter VShipTermsID { get; }
				public SelectorColumnFilter VFOBPointID { get; }
				public PXNumberEditColumnFilter VLeadTime { get; }
				public PXTextEditColumnFilter VAllowAPBillBeforeReceipt { get; }
				public PXNumberEditColumnFilter VRcptQtyMin { get; }
				public PXNumberEditColumnFilter VRcptQtyMax { get; }
				public PXNumberEditColumnFilter VRcptQtyThreshold { get; }
				public DropDownColumnFilter VRcptQtyAction { get; }
				public PXNumberEditColumnFilter BAccountID { get; }
                
                public c_grid_header(c_locations_grdlocations grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    LocationCD = new SelectorColumnFilter(grid.Row.LocationCD);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    IsDefault = new CheckBoxColumnFilter(grid.Row.IsDefault);
                    Address__City = new PXTextEditColumnFilter(grid.Row.Address__City);
                    Address__State = new SelectorColumnFilter(grid.Row.Address__State);
                    Address__CountryID = new SelectorColumnFilter(grid.Row.Address__CountryID);
                    Address__PostalCode = new PXTextEditColumnFilter(grid.Row.Address__PostalCode);
                    Address__State_description = new PXTextEditColumnFilter(grid.Row.Address__State_description);
                    Address__CountryID_description = new PXTextEditColumnFilter(grid.Row.Address__CountryID_description);
                    VExpenseAcctID = new SelectorColumnFilter(grid.Row.VExpenseAcctID);
                    VExpenseSubID = new SelectorColumnFilter(grid.Row.VExpenseSubID);
                    PaymentMethodID = new PXTextEditColumnFilter(grid.Row.PaymentMethodID);
                    PaymentLeadTime = new PXTextEditColumnFilter(grid.Row.PaymentLeadTime);
                    VBranchID = new SelectorColumnFilter(grid.Row.VBranchID);
                    VBranchID_description = new PXTextEditColumnFilter(grid.Row.VBranchID_description);
                    CreatedByID_Description = new PXTextEditColumnFilter(grid.Row.CreatedByID_Description);
                    CreatedDateTime = new DateSelectorColumnFilter(grid.Row.CreatedDateTime);
                    LastModifiedByID_Description = new PXTextEditColumnFilter(grid.Row.LastModifiedByID_Description);
                    LastModifiedDateTime = new DateSelectorColumnFilter(grid.Row.LastModifiedDateTime);
                    TaxRegistrationID = new PXTextEditColumnFilter(grid.Row.TaxRegistrationID);
                    VTaxZoneID = new SelectorColumnFilter(grid.Row.VTaxZoneID);
                    VTaxCalcMode = new DropDownColumnFilter(grid.Row.VTaxCalcMode);
                    VSiteID = new SelectorColumnFilter(grid.Row.VSiteID);
                    VCarrierID = new SelectorColumnFilter(grid.Row.VCarrierID);
                    VShipTermsID = new SelectorColumnFilter(grid.Row.VShipTermsID);
                    VFOBPointID = new SelectorColumnFilter(grid.Row.VFOBPointID);
                    VLeadTime = new PXNumberEditColumnFilter(grid.Row.VLeadTime);
                    VAllowAPBillBeforeReceipt = new PXTextEditColumnFilter(grid.Row.VAllowAPBillBeforeReceipt);
                    VRcptQtyMin = new PXNumberEditColumnFilter(grid.Row.VRcptQtyMin);
                    VRcptQtyMax = new PXNumberEditColumnFilter(grid.Row.VRcptQtyMax);
                    VRcptQtyThreshold = new PXNumberEditColumnFilter(grid.Row.VRcptQtyThreshold);
                    VRcptQtyAction = new DropDownColumnFilter(grid.Row.VRcptQtyAction);
                    BAccountID = new PXNumberEditColumnFilter(grid.Row.BAccountID);
                }
            }
        }
        
        public class c_locations_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_locations_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t6_grdLocations_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t6_grdLocations_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t6_grdLocations_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t6_grdLocations_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Locations";
            }
        }
        
        public class c_deflocation_deflocationpayment : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox OverrideRemitAddress { get; }
			public Label OverrideRemitAddressLabel { get; }
			public CheckBox OverrideRemitContact { get; }
			public Label OverrideRemitContactLabel { get; }
			public Selector VPaymentMethodID { get; }
			public Label VPaymentMethodIDLabel { get; }
			public Selector VCashAccountID { get; }
			public Label VCashAccountIDLabel { get; }
			public DropDown VPaymentByType { get; }
			public Label VPaymentByTypeLabel { get; }
			public PXNumberEdit VPaymentLeadTime { get; }
			public Label VPaymentLeadTimeLabel { get; }
			public CheckBox VSeparateCheck { get; }
			public Label VSeparateCheckLabel { get; }
			public PXNumberEdit VPrepaymentPct { get; }
			public Label VPrepaymentPctLabel { get; }
			public Label LblPhone1_ { get; }
			public Label LblPhone2_ { get; }
			public Label LblFax_ { get; }
            
            public c_deflocation_deflocationpayment(string locator, string name) : 
                    base(locator, name)
            {
                OverrideRemitAddress = new CheckBox("ctl00_phG_tab_t2_DefLocationPayment_chkOverrideRemitAddress", "Override", locator, null);
                OverrideRemitAddressLabel = new Label(OverrideRemitAddress);
                OverrideRemitAddress.DataField = "OverrideRemitAddress";
                OverrideRemitContact = new CheckBox("ctl00_phG_tab_t2_DefLocationPayment_chkOverrideRemitContact", "Override", locator, null);
                OverrideRemitContactLabel = new Label(OverrideRemitContact);
                OverrideRemitContact.DataField = "OverrideRemitContact";
                VPaymentMethodID = new Selector("ctl00_phG_tab_t2_DefLocationPayment_edVPaymentMethodID", "Payment Method", locator, null);
                VPaymentMethodIDLabel = new Label(VPaymentMethodID);
                VPaymentMethodID.DataField = "VPaymentMethodID";
                VCashAccountID = new Selector("ctl00_phG_tab_t2_DefLocationPayment_edVCashAccountID", "Cash Account", locator, null);
                VCashAccountIDLabel = new Label(VCashAccountID);
                VCashAccountID.DataField = "VCashAccountID";
                VPaymentByType = new DropDown("ctl00_phG_tab_t2_DefLocationPayment_edVPaymentByType", "Payment By", locator, null);
                VPaymentByTypeLabel = new Label(VPaymentByType);
                VPaymentByType.DataField = "VPaymentByType";
                VPaymentByType.Items.Add("0", "Due Date");
                VPaymentByType.Items.Add("1", "Discount Date");
                VPaymentLeadTime = new PXNumberEdit("ctl00_phG_tab_t2_DefLocationPayment_edVPaymentLeadTime", "Payment Lead Time (Days)", locator, null);
                VPaymentLeadTimeLabel = new Label(VPaymentLeadTime);
                VPaymentLeadTime.DataField = "VPaymentLeadTime";
                VSeparateCheck = new CheckBox("ctl00_phG_tab_t2_DefLocationPayment_chkVSeparateCheck", "Pay Separately", locator, null);
                VSeparateCheckLabel = new Label(VSeparateCheck);
                VSeparateCheck.DataField = "VSeparateCheck";
                VPrepaymentPct = new PXNumberEdit("ctl00_phG_tab_t2_DefLocationPayment_edVPrepaymentPct", "Prepayment Percent", locator, null);
                VPrepaymentPctLabel = new Label(VPrepaymentPct);
                VPrepaymentPct.DataField = "VPrepaymentPct";
                LblPhone1_ = new Label("ctl00_phG_tab_t2_DefLocationPayment_RemitContact_lblPhone1", "Lbl Phone 1_", locator, null);
                LblPhone2_ = new Label("ctl00_phG_tab_t2_DefLocationPayment_RemitContact_lblPhone2", "Lbl Phone 2_", locator, null);
                LblFax_ = new Label("ctl00_phG_tab_t2_DefLocationPayment_RemitContact_lblFax", "Lbl Fax _", locator, null);
                DataMemberName = "DefLocation";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void CurrentVendorPayToVendorIDEdit()
            {
                Buttons.CurrentVendorPayToVendorIDEdit.Click();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
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
                
			public Button CurrentVendorPayToVendorIDEdit { get; }
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    CurrentVendorPayToVendorIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_DefLocationPayment_edPayToVendorID\'] div[class=\'edit" +
                            "BtnCont\'] > div > div", "CurrentVendor.PayToVendorIDEdit", "ctl00_phG_tab_t2_DefLocationPayment");
                    CurrentVendorPayToVendorIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    AddressLookup = new Button("ctl00_phG_tab_t2_DefLocationPayment_RemitAddress_btnRemitAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_DefLocationPayment");
                    ViewonMap = new Button("ctl00_phG_tab_t2_DefLocationPayment_RemitAddress_btnViewRemitOnMap", "View on Map", "ctl00_phG_tab_t2_DefLocationPayment");
                    First = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfFirst0", "First", "ctl00_phG_tab_t2_DefLocationPayment");
                    Prev = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfPrev0", "Prev", "ctl00_phG_tab_t2_DefLocationPayment");
                    Next = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfNext0", "Next", "ctl00_phG_tab_t2_DefLocationPayment");
                    Last = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfLast0", "Last", "ctl00_phG_tab_t2_DefLocationPayment");
                }
            }
        }
        
        public class c_currentvendor_deflocationpayment : Container
        {
            
			public Selector PayToVendorID { get; }
			public Label PayToVendorIDLabel { get; }
			public CheckBox PaymentsByLinesAllowed { get; }
			public Label PaymentsByLinesAllowedLabel { get; }
            
            public c_currentvendor_deflocationpayment(string locator, string name) : 
                    base(locator, name)
            {
                PayToVendorID = new Selector("ctl00_phG_tab_t2_DefLocationPayment_edPayToVendorID", "Pay-to Vendor", locator, null);
                PayToVendorIDLabel = new Label(PayToVendorID);
                PayToVendorID.DataField = "PayToVendorID";
                PaymentsByLinesAllowed = new CheckBox("ctl00_phG_tab_t2_DefLocationPayment_chkPaymentsByLinesAllowed", "Pay by Line", locator, null);
                PaymentsByLinesAllowedLabel = new Label(PaymentsByLinesAllowed);
                PaymentsByLinesAllowed.DataField = "PaymentsByLinesAllowed";
                DataMemberName = "CurrentVendor";
            }
        }
        
        public class c_deflocation_deflocation : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox OverrideAddress { get; }
			public Label OverrideAddressLabel { get; }
			public CheckBox OverrideContact { get; }
			public Label OverrideContactLabel { get; }
			public Selector VBranchID { get; }
			public Label VBranchIDLabel { get; }
			public CheckBox VPrintOrder { get; }
			public Label VPrintOrderLabel { get; }
			public CheckBox VEmailOrder { get; }
			public Label VEmailOrderLabel { get; }
			public PXTextEdit TaxRegistrationID { get; }
			public Label TaxRegistrationIDLabel { get; }
			public Selector VTaxZoneID { get; }
			public Label VTaxZoneIDLabel { get; }
			public DropDown VTaxCalcMode { get; }
			public Label VTaxCalcModeLabel { get; }
			public Selector VSiteID { get; }
			public Label VSiteIDLabel { get; }
			public Selector VCarrierID { get; }
			public Label VCarrierIDLabel { get; }
			public Selector VShipTermsID { get; }
			public Label VShipTermsIDLabel { get; }
			public Selector VFOBPointID { get; }
			public Label VFOBPointIDLabel { get; }
			public PXNumberEdit VLeadTime { get; }
			public Label VLeadTimeLabel { get; }
			public CheckBox VAllowAPBillBeforeReceipt { get; }
			public Label VAllowAPBillBeforeReceiptLabel { get; }
			public PXNumberEdit VRcptQtyMin { get; }
			public Label VRcptQtyMinLabel { get; }
			public PXNumberEdit VRcptQtyMax { get; }
			public Label VRcptQtyMaxLabel { get; }
			public PXNumberEdit VRcptQtyThreshold { get; }
			public Label VRcptQtyThresholdLabel { get; }
			public DropDown VRcptQtyAction { get; }
			public Label VRcptQtyActionLabel { get; }
			public Label LblPhone1_ { get; }
			public Label LblPhone2_ { get; }
			public Label LblFax_ { get; }
            
            public c_deflocation_deflocation(string locator, string name) : 
                    base(locator, name)
            {
                OverrideAddress = new CheckBox("ctl00_phG_tab_t3_DefLocation_chkOverrideAddress", "Override", locator, null);
                OverrideAddressLabel = new Label(OverrideAddress);
                OverrideAddress.DataField = "OverrideAddress";
                OverrideContact = new CheckBox("ctl00_phG_tab_t3_DefLocation_chkOverrideContact", "Override", locator, null);
                OverrideContactLabel = new Label(OverrideContact);
                OverrideContact.DataField = "OverrideContact";
                VBranchID = new Selector("ctl00_phG_tab_t3_DefLocation_edVBranchID", "Default Branch", locator, null);
                VBranchIDLabel = new Label(VBranchID);
                VBranchID.DataField = "VBranchID";
                VPrintOrder = new CheckBox("ctl00_phG_tab_t3_DefLocation_chkVPrintOrder", "Print Order", locator, null);
                VPrintOrderLabel = new Label(VPrintOrder);
                VPrintOrder.DataField = "VPrintOrder";
                VEmailOrder = new CheckBox("ctl00_phG_tab_t3_DefLocation_chkVEmailOrder", "Email Order", locator, null);
                VEmailOrderLabel = new Label(VEmailOrder);
                VEmailOrder.DataField = "VEmailOrder";
                TaxRegistrationID = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_edTaxRegistrationID", "Tax Registration ID", locator, null);
                TaxRegistrationIDLabel = new Label(TaxRegistrationID);
                TaxRegistrationID.DataField = "TaxRegistrationID";
                VTaxZoneID = new Selector("ctl00_phG_tab_t3_DefLocation_edTaxZoneID", "Tax Zone", locator, null);
                VTaxZoneIDLabel = new Label(VTaxZoneID);
                VTaxZoneID.DataField = "VTaxZoneID";
                VTaxCalcMode = new DropDown("ctl00_phG_tab_t3_DefLocation_edTaxCalcMode", "Tax Calculation Mode", locator, null);
                VTaxCalcModeLabel = new Label(VTaxCalcMode);
                VTaxCalcMode.DataField = "VTaxCalcMode";
                VTaxCalcMode.Items.Add("T", "Tax Settings");
                VTaxCalcMode.Items.Add("G", "Gross");
                VTaxCalcMode.Items.Add("N", "Net");
                VSiteID = new Selector("ctl00_phG_tab_t3_DefLocation_edVSiteID", "Warehouse", locator, null);
                VSiteIDLabel = new Label(VSiteID);
                VSiteID.DataField = "VSiteID";
                VCarrierID = new Selector("ctl00_phG_tab_t3_DefLocation_edVCarrierID", "Ship Via", locator, null);
                VCarrierIDLabel = new Label(VCarrierID);
                VCarrierID.DataField = "VCarrierID";
                VShipTermsID = new Selector("ctl00_phG_tab_t3_DefLocation_edShipTermsID", "Shipping Terms", locator, null);
                VShipTermsIDLabel = new Label(VShipTermsID);
                VShipTermsID.DataField = "VShipTermsID";
                VFOBPointID = new Selector("ctl00_phG_tab_t3_DefLocation_edFOBPointID", "FOB Point", locator, null);
                VFOBPointIDLabel = new Label(VFOBPointID);
                VFOBPointID.DataField = "VFOBPointID";
                VLeadTime = new PXNumberEdit("ctl00_phG_tab_t3_DefLocation_edLeadTime", "Lead Time (Days)", locator, null);
                VLeadTimeLabel = new Label(VLeadTime);
                VLeadTime.DataField = "VLeadTime";
                VAllowAPBillBeforeReceipt = new CheckBox("ctl00_phG_tab_t3_DefLocation_chkVAllowAPBillBeforeReceipt", "Allow AP Bill Before Receipt", locator, null);
                VAllowAPBillBeforeReceiptLabel = new Label(VAllowAPBillBeforeReceipt);
                VAllowAPBillBeforeReceipt.DataField = "VAllowAPBillBeforeReceipt";
                VRcptQtyMin = new PXNumberEdit("ctl00_phG_tab_t3_DefLocation_edVRcptQtyMin", "Min. Receipt (%)", locator, null);
                VRcptQtyMinLabel = new Label(VRcptQtyMin);
                VRcptQtyMin.DataField = "VRcptQtyMin";
                VRcptQtyMax = new PXNumberEdit("ctl00_phG_tab_t3_DefLocation_edVRcptQtyMax", "Max. Receipt (%)", locator, null);
                VRcptQtyMaxLabel = new Label(VRcptQtyMax);
                VRcptQtyMax.DataField = "VRcptQtyMax";
                VRcptQtyThreshold = new PXNumberEdit("ctl00_phG_tab_t3_DefLocation_edVRcptQtyThreshold", "Threshold Receipt (%)", locator, null);
                VRcptQtyThresholdLabel = new Label(VRcptQtyThreshold);
                VRcptQtyThreshold.DataField = "VRcptQtyThreshold";
                VRcptQtyAction = new DropDown("ctl00_phG_tab_t3_DefLocation_edVRcptQtyAction", "Receipt Action", locator, null);
                VRcptQtyActionLabel = new Label(VRcptQtyAction);
                VRcptQtyAction.DataField = "VRcptQtyAction";
                VRcptQtyAction.Items.Add("R", "Reject");
                VRcptQtyAction.Items.Add("W", "Accept but Warn");
                VRcptQtyAction.Items.Add("A", "Accept");
                LblPhone1_ = new Label("ctl00_phG_tab_t3_DefLocation_DefLocationContact_lblPhone1", "Lbl Phone 1_", locator, null);
                LblPhone2_ = new Label("ctl00_phG_tab_t3_DefLocation_DefLocationContact_lblPhone2", "Lbl Phone 2_", locator, null);
                LblFax_ = new Label("ctl00_phG_tab_t3_DefLocation_DefLocationContact_lblFax", "Lbl Fax _", locator, null);
                DataMemberName = "DefLocation";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void VBranchIDEdit()
            {
                Buttons.VBranchIDEdit.Click();
            }
            
            public virtual void VTaxZoneIDEdit()
            {
                Buttons.VTaxZoneIDEdit.Click();
            }
            
            public virtual void VSiteIDEdit()
            {
                Buttons.VSiteIDEdit.Click();
            }
            
            public virtual void DefLocationBranchSettingsVSiteIDEdit()
            {
                Buttons.DefLocationBranchSettingsVSiteIDEdit.Click();
            }
            
            public virtual void VCarrierIDEdit()
            {
                Buttons.VCarrierIDEdit.Click();
            }
            
            public virtual void VShipTermsIDEdit()
            {
                Buttons.VShipTermsIDEdit.Click();
            }
            
            public virtual void VFOBPointIDEdit()
            {
                Buttons.VFOBPointIDEdit.Click();
            }
            
            public virtual void BtnDefLocationAddressLookup()
            {
                Buttons.BtnDefLocationAddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button VBranchIDEdit { get; }
			public Button VTaxZoneIDEdit { get; }
			public Button VSiteIDEdit { get; }
			public Button DefLocationBranchSettingsVSiteIDEdit { get; }
			public Button VCarrierIDEdit { get; }
			public Button VShipTermsIDEdit { get; }
			public Button VFOBPointIDEdit { get; }
			public Button BtnDefLocationAddressLookup { get; }
			public Button ViewonMap { get; }
                
                public PxButtonCollection()
                {
                    VBranchIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edVBranchID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "VBranchIDEdit", "ctl00_phG_tab_t3_DefLocation");
                    VBranchIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    VTaxZoneIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edTaxZoneID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "VTaxZoneIDEdit", "ctl00_phG_tab_t3_DefLocation");
                    VTaxZoneIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    VSiteIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edVSiteID\'] div[class=\'editBtnCont\'] > d" +
                            "iv > div", "VSiteIDEdit", "ctl00_phG_tab_t3_DefLocation");
                    VSiteIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DefLocationBranchSettingsVSiteIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edVSiteIDIntercompany\'] div[class=\'editB" +
                            "tnCont\'] > div > div", "DefLocationBranchSettings.VSiteIDEdit", "ctl00_phG_tab_t3_DefLocation");
                    DefLocationBranchSettingsVSiteIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    VCarrierIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edVCarrierID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "VCarrierIDEdit", "ctl00_phG_tab_t3_DefLocation");
                    VCarrierIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    VShipTermsIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edShipTermsID\'] div[class=\'editBtnCont\']" +
                            " > div > div", "VShipTermsIDEdit", "ctl00_phG_tab_t3_DefLocation");
                    VShipTermsIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    VFOBPointIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edFOBPointID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "VFOBPointIDEdit", "ctl00_phG_tab_t3_DefLocation");
                    VFOBPointIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    BtnDefLocationAddressLookup = new Button("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_btnDefLocationAddressLookup", "btnDefLocationAddressLookup", "ctl00_phG_tab_t3_DefLocation");
                    ViewonMap = new Button("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_btnViewDefLocationAddressOnMap", "View on Map", "ctl00_phG_tab_t3_DefLocation");
                }
            }
        }
        
        public class c_deflocationbranchsettings_deflocation : Container
        {
            
			public Selector VSiteID { get; }
			public Label VSiteIDLabel { get; }
            
            public c_deflocationbranchsettings_deflocation(string locator, string name) : 
                    base(locator, name)
            {
                VSiteID = new Selector("ctl00_phG_tab_t3_DefLocation_edVSiteIDIntercompany", "Warehouse", locator, null);
                VSiteIDLabel = new Label(VSiteID);
                VSiteID.DataField = "VSiteID";
                DataMemberName = "DefLocationBranchSettings";
            }
        }
        
        public class c_deflocation_deflocationglaccounts : Container
        {
            
			public Selector VAPAccountID { get; }
			public Label VAPAccountIDLabel { get; }
			public Selector VAPSubID { get; }
			public Label VAPSubIDLabel { get; }
			public Selector VExpenseAcctID { get; }
			public Label VExpenseAcctIDLabel { get; }
			public Selector VExpenseSubID { get; }
			public Label VExpenseSubIDLabel { get; }
			public Selector VDiscountAcctID { get; }
			public Label VDiscountAcctIDLabel { get; }
			public Selector VDiscountSubID { get; }
			public Label VDiscountSubIDLabel { get; }
            
            public c_deflocation_deflocationglaccounts(string locator, string name) : 
                    base(locator, name)
            {
                VAPAccountID = new Selector("ctl00_phG_tab_t9_DefLocationGLAccounts_edVAPAccountID", "AP Account", locator, null);
                VAPAccountIDLabel = new Label(VAPAccountID);
                VAPAccountID.DataField = "VAPAccountID";
                VAPSubID = new Selector("ctl00_phG_tab_t9_DefLocationGLAccounts_edVAPSubID", "AP Sub.", locator, null);
                VAPSubIDLabel = new Label(VAPSubID);
                VAPSubID.DataField = "VAPSubID";
                VExpenseAcctID = new Selector("ctl00_phG_tab_t9_DefLocationGLAccounts_edVExpenseAcctID", "Expense Account", locator, null);
                VExpenseAcctIDLabel = new Label(VExpenseAcctID);
                VExpenseAcctID.DataField = "VExpenseAcctID";
                VExpenseSubID = new Selector("ctl00_phG_tab_t9_DefLocationGLAccounts_edVExpenseSubID", "Expense Sub.", locator, null);
                VExpenseSubIDLabel = new Label(VExpenseSubID);
                VExpenseSubID.DataField = "VExpenseSubID";
                VDiscountAcctID = new Selector("ctl00_phG_tab_t9_DefLocationGLAccounts_edVDiscountAcctID", "Discount Account", locator, null);
                VDiscountAcctIDLabel = new Label(VDiscountAcctID);
                VDiscountAcctID.DataField = "VDiscountAcctID";
                VDiscountSubID = new Selector("ctl00_phG_tab_t9_DefLocationGLAccounts_edVDiscountSubID", "Discount Sub.", locator, null);
                VDiscountSubIDLabel = new Label(VDiscountSubID);
                VDiscountSubID.DataField = "VDiscountSubID";
                DataMemberName = "DefLocation";
            }
        }
        
        public class c_deflocation_formretainage : Container
        {
            
			public Selector VRetainageAcctID { get; }
			public Label VRetainageAcctIDLabel { get; }
			public Selector VRetainageSubID { get; }
			public Label VRetainageSubIDLabel { get; }
            
            public c_deflocation_formretainage(string locator, string name) : 
                    base(locator, name)
            {
                VRetainageAcctID = new Selector("ctl00_phG_tab_t9_formRetainage_edVRetainageAcctID", "Retainage Payable Account", locator, null);
                VRetainageAcctIDLabel = new Label(VRetainageAcctID);
                VRetainageAcctID.DataField = "VRetainageAcctID";
                VRetainageSubID = new Selector("ctl00_phG_tab_t9_formRetainage_edVRetainageSubID", "Retainage Payable Sub.", locator, null);
                VRetainageSubIDLabel = new Label(VRetainageSubID);
                VRetainageSubID.DataField = "VRetainageSubID";
                DataMemberName = "DefLocation";
            }
        }
        
        public class c_defaddress_defaddress : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AddressLine1 { get; }
			public Label AddressLine1Label { get; }
			public PXTextEdit AddressLine2 { get; }
			public Label AddressLine2Label { get; }
			public PXTextEdit City { get; }
			public Label CityLabel { get; }
			public Selector State { get; }
			public Label StateLabel { get; }
			public PXTextEdit PostalCode { get; }
			public Label PostalCodeLabel { get; }
			public Selector CountryID { get; }
			public Label CountryIDLabel { get; }
			public CheckBox IsValidated { get; }
			public Label IsValidatedLabel { get; }
            
            public c_defaddress_defaddress(string locator, string name) : 
                    base(locator, name)
            {
                AddressLine1 = new PXTextEdit("ctl00_phG_tab_t0_DefAddress_edDefAddressAddressLine1", "Address Line 1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_tab_t0_DefAddress_edDefAddressAddressLine2", "Address Line 2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                City = new PXTextEdit("ctl00_phG_tab_t0_DefAddress_edDefAddressCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                State = new Selector("ctl00_phG_tab_t0_DefAddress_edDefAddressState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_tab_t0_DefAddress_edDefAddressPostalCode", "Postal Code", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                CountryID = new Selector("ctl00_phG_tab_t0_DefAddress_edDefAddressCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                IsValidated = new CheckBox("ctl00_phG_tab_t0_DefAddress_edDefAddressIsValidated", "Validated", locator, null);
                IsValidatedLabel = new Label(IsValidated);
                IsValidated.DataField = "IsValidated";
                DataMemberName = "DefAddress";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void PrimaryContactIDEdit()
            {
                Buttons.PrimaryContactIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button PrimaryContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t0_DefAddress_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t0_DefAddress");
                    ViewonMap = new Button("ctl00_phG_tab_t0_DefAddress_btnViewMainOnMap", "View on Map", "ctl00_phG_tab_t0_DefAddress");
                    PrimaryContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPrmCntID\'] div[class=\'editBtnCont\'] > div > div", "PrimaryContactIDEdit", "ctl00_phG_tab_t0_DefAddress");
                    PrimaryContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_deflocationaddress_deflocationaddress : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AddressLine1 { get; }
			public Label AddressLine1Label { get; }
			public PXTextEdit AddressLine2 { get; }
			public Label AddressLine2Label { get; }
			public PXTextEdit City { get; }
			public Label CityLabel { get; }
			public Selector State { get; }
			public Label StateLabel { get; }
			public PXTextEdit PostalCode { get; }
			public Label PostalCodeLabel { get; }
			public Selector CountryID { get; }
			public Label CountryIDLabel { get; }
			public PXNumberEdit Latitude { get; }
			public Label LatitudeLabel { get; }
			public PXNumberEdit Longitude { get; }
			public Label LongitudeLabel { get; }
			public CheckBox IsValidated { get; }
			public Label IsValidatedLabel { get; }
            
            public c_deflocationaddress_deflocationaddress(string locator, string name) : 
                    base(locator, name)
            {
                AddressLine1 = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_edDefLocationAddressAddressLine1", "Address Line 1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_edDefLocationAddressAddressLine2", "Address Line 2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                City = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_edDefLocationAddressCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                State = new Selector("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_edDefLocationAddressState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_edPostalCode", "Postal Code", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                CountryID = new Selector("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_edDefLocationAddressCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                Latitude = new PXNumberEdit("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_edLatitude", "Latitude", locator, null);
                LatitudeLabel = new Label(Latitude);
                Latitude.DataField = "Latitude";
                Longitude = new PXNumberEdit("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_edLongitude", "Longitude", locator, null);
                LongitudeLabel = new Label(Longitude);
                Longitude.DataField = "Longitude";
                IsValidated = new CheckBox("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_edDefLocationAddressIsValidated", "Validated", locator, null);
                IsValidatedLabel = new Label(IsValidated);
                IsValidated.DataField = "IsValidated";
                DataMemberName = "DefLocationAddress";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void BtnDefLocationAddressLookup()
            {
                Buttons.BtnDefLocationAddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void VBranchIDEdit()
            {
                Buttons.VBranchIDEdit.Click();
            }
            
            public virtual void VTaxZoneIDEdit()
            {
                Buttons.VTaxZoneIDEdit.Click();
            }
            
            public virtual void VCarrierIDEdit()
            {
                Buttons.VCarrierIDEdit.Click();
            }
            
            public virtual void VShipTermsIDEdit()
            {
                Buttons.VShipTermsIDEdit.Click();
            }
            
            public virtual void VFOBPointIDEdit()
            {
                Buttons.VFOBPointIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button BtnDefLocationAddressLookup { get; }
			public Button ViewonMap { get; }
			public Button VBranchIDEdit { get; }
			public Button VTaxZoneIDEdit { get; }
			public Button VCarrierIDEdit { get; }
			public Button VShipTermsIDEdit { get; }
			public Button VFOBPointIDEdit { get; }
                
                public PxButtonCollection()
                {
                    BtnDefLocationAddressLookup = new Button("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_btnDefLocationAddressLookup", "btnDefLocationAddressLookup", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    ViewonMap = new Button("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_btnViewDefLocationAddressOnMap", "View on Map", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    VBranchIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edVBranchID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "VBranchIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    VBranchIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    VTaxZoneIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edTaxZoneID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "VTaxZoneIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    VTaxZoneIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    VCarrierIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edVCarrierID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "VCarrierIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    VCarrierIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    VShipTermsIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edShipTermsID\'] div[class=\'editBtnCont\']" +
                            " > div > div", "VShipTermsIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    VShipTermsIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    VFOBPointIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edFOBPointID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "VFOBPointIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationAddress");
                    VFOBPointIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_remitaddress_remitaddress : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AddressLine1 { get; }
			public Label AddressLine1Label { get; }
			public PXTextEdit AddressLine2 { get; }
			public Label AddressLine2Label { get; }
			public PXTextEdit City { get; }
			public Label CityLabel { get; }
			public Selector State { get; }
			public Label StateLabel { get; }
			public PXTextEdit PostalCode { get; }
			public Label PostalCodeLabel { get; }
			public Selector CountryID { get; }
			public Label CountryIDLabel { get; }
			public CheckBox IsValidated { get; }
			public Label IsValidatedLabel { get; }
            
            public c_remitaddress_remitaddress(string locator, string name) : 
                    base(locator, name)
            {
                AddressLine1 = new PXTextEdit("ctl00_phG_tab_t2_DefLocationPayment_RemitAddress_edAddressLine1", "Address Line 1", locator, null);
                AddressLine1Label = new Label(AddressLine1);
                AddressLine1.DataField = "AddressLine1";
                AddressLine2 = new PXTextEdit("ctl00_phG_tab_t2_DefLocationPayment_RemitAddress_edAddressLine2", "Address Line 2", locator, null);
                AddressLine2Label = new Label(AddressLine2);
                AddressLine2.DataField = "AddressLine2";
                City = new PXTextEdit("ctl00_phG_tab_t2_DefLocationPayment_RemitAddress_edCity", "City", locator, null);
                CityLabel = new Label(City);
                City.DataField = "City";
                State = new Selector("ctl00_phG_tab_t2_DefLocationPayment_RemitAddress_edState", "State", locator, null);
                StateLabel = new Label(State);
                State.DataField = "State";
                PostalCode = new PXTextEdit("ctl00_phG_tab_t2_DefLocationPayment_RemitAddress_edPostalCode", "Postal Code", locator, null);
                PostalCodeLabel = new Label(PostalCode);
                PostalCode.DataField = "PostalCode";
                CountryID = new Selector("ctl00_phG_tab_t2_DefLocationPayment_RemitAddress_edCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                IsValidated = new CheckBox("ctl00_phG_tab_t2_DefLocationPayment_RemitAddress_edIsValidated", "Validated", locator, null);
                IsValidatedLabel = new Label(IsValidated);
                IsValidated.DataField = "IsValidated";
                DataMemberName = "RemitAddress";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
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
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t2_DefLocationPayment_RemitAddress_btnRemitAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_DefLocationPayment_RemitAddress");
                    ViewonMap = new Button("ctl00_phG_tab_t2_DefLocationPayment_RemitAddress_btnViewRemitOnMap", "View on Map", "ctl00_phG_tab_t2_DefLocationPayment_RemitAddress");
                    First = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfFirst0", "First", "ctl00_phG_tab_t2_DefLocationPayment_RemitAddress");
                    Prev = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfPrev0", "Prev", "ctl00_phG_tab_t2_DefLocationPayment_RemitAddress");
                    Next = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfNext0", "Next", "ctl00_phG_tab_t2_DefLocationPayment_RemitAddress");
                    Last = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfLast0", "Last", "ctl00_phG_tab_t2_DefLocationPayment_RemitAddress");
                }
            }
        }
        
        public class c_contacts_grdcontacts : Grid<c_contacts_grdcontacts.c_grid_row, c_contacts_grdcontacts.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public DropDown PredefinedFilter { get; }
			public QuickSearch QuickSearch { get; }
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_contacts_grdcontacts(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t7_grdContacts");
                DataMemberName = "Contacts";
                PredefinedFilter = new DropDown("ctl00_phG_tab_t7_grdContacts_at_tlb_fs", "Predefined Filter", locator, null);
                PredefinedFilter.Items.Add("00000000-0000-0000-0000-000000000000", "All Records");
                QuickSearch = new QuickSearch("ctl00_phG_tab_t7_grdContacts_at_tlb_fb", "QuickSearch", locator, null);
                FilterForm = new c_grid_filter("ctl00_phG_tab_t7_grdContacts_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void CreateContactToolBar()
            {
                ToolBar.CreateContactToolBar.Click();
            }
            
            public virtual void ContactDetails()
            {
                ToolBar.ContactDetails.Click();
            }
            
            public virtual void MakeContactPrimary()
            {
                ToolBar.MakeContactPrimary.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Filter()
            {
                ToolBar.Filter.Click();
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
			public ToolBarButtonGrid CreateContactToolBar { get; }
			public ToolBarButtonGrid ContactDetails { get; }
			public ToolBarButtonGrid MakeContactPrimary { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Filter { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdContacts_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    CreateContactToolBar = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdContacts_at_tlb div[data-cmd=\'CreateContactToolBar\']", "Add New Contact", locator, null);
                    ContactDetails = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdContacts_at_tlb div[data-cmd=\'cmdViewContact\']", "Contact Details", locator, null);
                    MakeContactPrimary = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdContacts_at_tlb div[data-cmd=\'MakeContactPrimary\']", "Set as Primary", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdContacts_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdContacts_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Filter = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdContacts_at_tlb div[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdContacts_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdContacts_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdContacts_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdContacts_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdContacts_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t7_grdContacts_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox IsActive { get; }
			public Selector DisplayName { get; }
			public PXTextEdit Salutation { get; }
			public CheckBox IsPrimary { get; }
			public PXTextEdit EMail { get; }
			public PXTextEdit Phone1 { get; }
			public Selector OwnerID { get; }
			public PXTextEdit FullName { get; }
			public Selector ClassID { get; }
			public DateSelector LastModifiedDateTime { get; }
			public DateSelector CreatedDateTime { get; }
			public DropDown Source { get; }
			public DateSelector AssignDate { get; }
			public DropDown DuplicateStatus { get; }
			public PXTextEdit Phone2 { get; }
			public PXTextEdit Phone3 { get; }
			public DateSelector DateOfBirth { get; }
			public PXTextEdit Fax { get; }
			public DropDown Gender { get; }
			public DropDown Method { get; }
			public CheckBox NoCall { get; }
			public CheckBox NoEMail { get; }
			public CheckBox NoFax { get; }
			public CheckBox NoMail { get; }
			public CheckBox NoMarketing { get; }
			public CheckBox NoMassMail { get; }
			public Selector CampaignID { get; }
			public DropDown Phone1Type { get; }
			public DropDown Phone2Type { get; }
			public DropDown Phone3Type { get; }
			public DropDown FaxType { get; }
			public DropDown MaritalStatus { get; }
			public PXTextEdit Spouse { get; }
			public DropDown Status { get; }
			public DropDown Resolution { get; }
			public Selector LanguageID { get; }
			public Selector Address__CountryID { get; }
			public Selector Address__State { get; }
			public PXTextEdit Address__City { get; }
			public PXTextEdit Address__AddressLine1 { get; }
			public PXTextEdit Address__AddressLine2 { get; }
			public PXTextEdit Address__PostalCode { get; }
			public CheckBox CanBeMadePrimary { get; }
			public Selector ContactID { get; }
                
                public c_grid_row(c_contacts_grdcontacts grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    IsActive = new CheckBox("ctl00_phG_tab_t7_grdContacts", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    DisplayName = new Selector("_ctl00_phG_tab_t7_grdContacts_lv0_es", "Contact", grid.Locator, "DisplayName");
                    DisplayName.DataField = "DisplayName";
                    Salutation = new PXTextEdit("ctl00_phG_tab_t7_grdContacts_ei", "Job Title", grid.Locator, "Salutation");
                    Salutation.DataField = "Salutation";
                    IsPrimary = new CheckBox("ctl00_phG_tab_t7_grdContacts", "Primary", grid.Locator, "IsPrimary");
                    IsPrimary.DataField = "IsPrimary";
                    EMail = new PXTextEdit("ctl00_phG_tab_t7_grdContacts_ei", "Email", grid.Locator, "EMail");
                    EMail.DataField = "EMail";
                    Phone1 = new PXTextEdit("ctl00_phG_tab_t7_grdContacts_ei", "Phone 1", grid.Locator, "Phone1");
                    Phone1.DataField = "Phone1";
                    OwnerID = new Selector("_ctl00_phG_tab_t7_grdContacts_lv0_es", "Owner", grid.Locator, "OwnerID");
                    OwnerID.DataField = "OwnerID";
                    FullName = new PXTextEdit("ctl00_phG_tab_t7_grdContacts_ei", "Account Name", grid.Locator, "FullName");
                    FullName.DataField = "FullName";
                    ClassID = new Selector("_ctl00_phG_tab_t7_grdContacts_lv0_es", "Class ID", grid.Locator, "ClassID");
                    ClassID.DataField = "ClassID";
                    LastModifiedDateTime = new DateSelector("_ctl00_phG_tab_t7_grdContacts_lv0_ed11", "Last Modified On", grid.Locator, "LastModifiedDateTime");
                    LastModifiedDateTime.DataField = "LastModifiedDateTime";
                    CreatedDateTime = new DateSelector("_ctl00_phG_tab_t7_grdContacts_lv0_ed12", "Created On", grid.Locator, "CreatedDateTime");
                    CreatedDateTime.DataField = "CreatedDateTime";
                    Source = new DropDown("_ctl00_phG_tab_t7_grdContacts_lv0_ec", "Source", grid.Locator, "Source");
                    Source.DataField = "Source";
                    Source.Items.Add("S", "Organic Search");
                    Source.Items.Add("C", "Campaign");
                    Source.Items.Add("R", "Referral");
                    Source.Items.Add("O", "Other");
                    Source.Items.Add("W", "Web");
                    Source.Items.Add("H", "Phone Inquiry");
                    Source.Items.Add("L", "Purchased List");
                    AssignDate = new DateSelector("_ctl00_phG_tab_t7_grdContacts_lv0_ed14", "Assignment Date", grid.Locator, "AssignDate");
                    AssignDate.DataField = "AssignDate";
                    DuplicateStatus = new DropDown("_ctl00_phG_tab_t7_grdContacts_lv0_ec", "Duplicate", grid.Locator, "DuplicateStatus");
                    DuplicateStatus.DataField = "DuplicateStatus";
                    DuplicateStatus.Items.Add("NV", "Not Validated");
                    DuplicateStatus.Items.Add("VA", "Validated");
                    DuplicateStatus.Items.Add("PD", "Possible Duplicate");
                    DuplicateStatus.Items.Add("DD", "Duplicated");
                    Phone2 = new PXTextEdit("ctl00_phG_tab_t7_grdContacts_ei", "Phone 2", grid.Locator, "Phone2");
                    Phone2.DataField = "Phone2";
                    Phone3 = new PXTextEdit("ctl00_phG_tab_t7_grdContacts_ei", "Phone 3", grid.Locator, "Phone3");
                    Phone3.DataField = "Phone3";
                    DateOfBirth = new DateSelector("_ctl00_phG_tab_t7_grdContacts_lv0_ed18", "Date Of Birth", grid.Locator, "DateOfBirth");
                    DateOfBirth.DataField = "DateOfBirth";
                    Fax = new PXTextEdit("ctl00_phG_tab_t7_grdContacts_ei", "Fax", grid.Locator, "Fax");
                    Fax.DataField = "Fax";
                    Gender = new DropDown("_ctl00_phG_tab_t7_grdContacts_lv0_ec", "Gender", grid.Locator, "Gender");
                    Gender.DataField = "Gender";
                    Gender.Items.Add("M", "Male");
                    Gender.Items.Add("F", "Female");
                    Method = new DropDown("_ctl00_phG_tab_t7_grdContacts_lv0_ec", "Contact Method", grid.Locator, "Method");
                    Method.DataField = "Method";
                    Method.Items.Add("A", "Any");
                    Method.Items.Add("E", "Email");
                    Method.Items.Add("M", "Mail");
                    Method.Items.Add("F", "Fax");
                    Method.Items.Add("P", "Phone");
                    NoCall = new CheckBox("ctl00_phG_tab_t7_grdContacts_ef", "Do Not Call", grid.Locator, "NoCall");
                    NoCall.DataField = "NoCall";
                    NoEMail = new CheckBox("ctl00_phG_tab_t7_grdContacts_ef", "Do Not Email", grid.Locator, "NoEMail");
                    NoEMail.DataField = "NoEMail";
                    NoFax = new CheckBox("ctl00_phG_tab_t7_grdContacts_ef", "Do Not Fax", grid.Locator, "NoFax");
                    NoFax.DataField = "NoFax";
                    NoMail = new CheckBox("ctl00_phG_tab_t7_grdContacts_ef", "Do Not Mail", grid.Locator, "NoMail");
                    NoMail.DataField = "NoMail";
                    NoMarketing = new CheckBox("ctl00_phG_tab_t7_grdContacts_ef", "No Marketing", grid.Locator, "NoMarketing");
                    NoMarketing.DataField = "NoMarketing";
                    NoMassMail = new CheckBox("ctl00_phG_tab_t7_grdContacts_ef", "No Mass Mail", grid.Locator, "NoMassMail");
                    NoMassMail.DataField = "NoMassMail";
                    CampaignID = new Selector("_ctl00_phG_tab_t7_grdContacts_lv0_es", "Source Campaign", grid.Locator, "CampaignID");
                    CampaignID.DataField = "CampaignID";
                    Phone1Type = new DropDown("_ctl00_phG_tab_t7_grdContacts_lv0_ec", "Phone 1 Type", grid.Locator, "Phone1Type");
                    Phone1Type.DataField = "Phone1Type";
                    Phone1Type.Items.Add("B1", "Business 1");
                    Phone1Type.Items.Add("B2", "Business 2");
                    Phone1Type.Items.Add("B3", "Business 3");
                    Phone1Type.Items.Add("C", "Cell");
                    Phone1Type.Items.Add("BA1", "Assistant");
                    Phone1Type.Items.Add("BF", "Fax");
                    Phone1Type.Items.Add("H1", "Home");
                    Phone1Type.Items.Add("HF", "Home Fax");
                    Phone2Type = new DropDown("_ctl00_phG_tab_t7_grdContacts_lv0_ec", "Phone 2 Type", grid.Locator, "Phone2Type");
                    Phone2Type.DataField = "Phone2Type";
                    Phone2Type.Items.Add("B1", "Business 1");
                    Phone2Type.Items.Add("B2", "Business 2");
                    Phone2Type.Items.Add("B3", "Business 3");
                    Phone2Type.Items.Add("C", "Cell");
                    Phone2Type.Items.Add("BA1", "Assistant");
                    Phone2Type.Items.Add("BF", "Fax");
                    Phone2Type.Items.Add("H1", "Home");
                    Phone2Type.Items.Add("HF", "Home Fax");
                    Phone3Type = new DropDown("_ctl00_phG_tab_t7_grdContacts_lv0_ec", "Phone 3 Type", grid.Locator, "Phone3Type");
                    Phone3Type.DataField = "Phone3Type";
                    Phone3Type.Items.Add("B1", "Business 1");
                    Phone3Type.Items.Add("B2", "Business 2");
                    Phone3Type.Items.Add("B3", "Business 3");
                    Phone3Type.Items.Add("C", "Cell");
                    Phone3Type.Items.Add("BA1", "Assistant");
                    Phone3Type.Items.Add("BF", "Fax");
                    Phone3Type.Items.Add("H1", "Home");
                    Phone3Type.Items.Add("HF", "Home Fax");
                    FaxType = new DropDown("_ctl00_phG_tab_t7_grdContacts_lv0_ec", "Fax Type", grid.Locator, "FaxType");
                    FaxType.DataField = "FaxType";
                    FaxType.Items.Add("B1", "Business 1");
                    FaxType.Items.Add("B2", "Business 2");
                    FaxType.Items.Add("B3", "Business 3");
                    FaxType.Items.Add("C", "Cell");
                    FaxType.Items.Add("BA1", "Assistant");
                    FaxType.Items.Add("BF", "Fax");
                    FaxType.Items.Add("H1", "Home");
                    FaxType.Items.Add("HF", "Home Fax");
                    MaritalStatus = new DropDown("_ctl00_phG_tab_t7_grdContacts_lv0_ec", "Marital Status", grid.Locator, "MaritalStatus");
                    MaritalStatus.DataField = "MaritalStatus";
                    MaritalStatus.Items.Add("S", "Single");
                    MaritalStatus.Items.Add("M", "Married");
                    MaritalStatus.Items.Add("D", "Divorced");
                    MaritalStatus.Items.Add("W", "Widowed");
                    Spouse = new PXTextEdit("ctl00_phG_tab_t7_grdContacts_ei", "Spouse/Partner Name", grid.Locator, "Spouse");
                    Spouse.DataField = "Spouse";
                    Status = new DropDown("_ctl00_phG_tab_t7_grdContacts_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("A", "Active");
                    Status.Items.Add("I", "Inactive");
                    Resolution = new DropDown("_ctl00_phG_tab_t7_grdContacts_lv0_ec", "Reason", grid.Locator, "Resolution");
                    Resolution.DataField = "Resolution";
                    Resolution.Items.Add("AS", "Assign");
                    Resolution.Items.Add("IN", "In Process");
                    Resolution.Items.Add("OU", "Nurture");
                    Resolution.Items.Add("CA", "Abandoned");
                    Resolution.Items.Add("CD", "Duplicate");
                    Resolution.Items.Add("CL", "Unable to contact");
                    Resolution.Items.Add("EX", "External");
                    Resolution.Items.Add("RJ", "Disqualified");
                    Resolution.Items.Add("CU", "Unknown");
                    LanguageID = new Selector("_ctl00_phG_tab_t7_grdContacts_lv0_es", "Language/Locale", grid.Locator, "LanguageID");
                    LanguageID.DataField = "LanguageID";
                    Address__CountryID = new Selector("_ctl00_phG_tab_t7_grdContacts_lv0_es", "Country", grid.Locator, "Address__CountryID");
                    Address__CountryID.DataField = "Address__CountryID";
                    Address__State = new Selector("_ctl00_phG_tab_t7_grdContacts_lv0_es", "State", grid.Locator, "Address__State");
                    Address__State.DataField = "Address__State";
                    Address__City = new PXTextEdit("ctl00_phG_tab_t7_grdContacts_ei", "City", grid.Locator, "Address__City");
                    Address__City.DataField = "Address__City";
                    Address__AddressLine1 = new PXTextEdit("ctl00_phG_tab_t7_grdContacts_ei", "Address Line 1", grid.Locator, "Address__AddressLine1");
                    Address__AddressLine1.DataField = "Address__AddressLine1";
                    Address__AddressLine2 = new PXTextEdit("ctl00_phG_tab_t7_grdContacts_ei", "Address Line 2", grid.Locator, "Address__AddressLine2");
                    Address__AddressLine2.DataField = "Address__AddressLine2";
                    Address__PostalCode = new PXTextEdit("ctl00_phG_tab_t7_grdContacts_ei", "Postal Code", grid.Locator, "Address__PostalCode");
                    Address__PostalCode.DataField = "Address__PostalCode";
                    CanBeMadePrimary = new CheckBox("ctl00_phG_tab_t7_grdContacts", "Can be made Primary", grid.Locator, "CanBeMadePrimary");
                    CanBeMadePrimary.DataField = "CanBeMadePrimary";
                    ContactID = new Selector("_ctl00_phG_tab_t7_grdContacts_lv0_es", "Contact ID", grid.Locator, "ContactID");
                    ContactID.DataField = "ContactID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter IsActive { get; }
				public SelectorColumnFilter DisplayName { get; }
				public PXTextEditColumnFilter Salutation { get; }
				public CheckBoxColumnFilter IsPrimary { get; }
				public PXTextEditColumnFilter EMail { get; }
				public PXTextEditColumnFilter Phone1 { get; }
				public SelectorColumnFilter OwnerID { get; }
				public PXTextEditColumnFilter FullName { get; }
				public SelectorColumnFilter ClassID { get; }
				public DateSelectorColumnFilter LastModifiedDateTime { get; }
				public DateSelectorColumnFilter CreatedDateTime { get; }
				public DropDownColumnFilter Source { get; }
				public DateSelectorColumnFilter AssignDate { get; }
				public DropDownColumnFilter DuplicateStatus { get; }
				public PXTextEditColumnFilter Phone2 { get; }
				public PXTextEditColumnFilter Phone3 { get; }
				public DateSelectorColumnFilter DateOfBirth { get; }
				public PXTextEditColumnFilter Fax { get; }
				public DropDownColumnFilter Gender { get; }
				public DropDownColumnFilter Method { get; }
				public CheckBoxColumnFilter NoCall { get; }
				public CheckBoxColumnFilter NoEMail { get; }
				public CheckBoxColumnFilter NoFax { get; }
				public CheckBoxColumnFilter NoMail { get; }
				public CheckBoxColumnFilter NoMarketing { get; }
				public CheckBoxColumnFilter NoMassMail { get; }
				public SelectorColumnFilter CampaignID { get; }
				public DropDownColumnFilter Phone1Type { get; }
				public DropDownColumnFilter Phone2Type { get; }
				public DropDownColumnFilter Phone3Type { get; }
				public DropDownColumnFilter FaxType { get; }
				public DropDownColumnFilter MaritalStatus { get; }
				public PXTextEditColumnFilter Spouse { get; }
				public DropDownColumnFilter Status { get; }
				public DropDownColumnFilter Resolution { get; }
				public SelectorColumnFilter LanguageID { get; }
				public SelectorColumnFilter Address__CountryID { get; }
				public SelectorColumnFilter Address__State { get; }
				public PXTextEditColumnFilter Address__City { get; }
				public PXTextEditColumnFilter Address__AddressLine1 { get; }
				public PXTextEditColumnFilter Address__AddressLine2 { get; }
				public PXTextEditColumnFilter Address__PostalCode { get; }
				public CheckBoxColumnFilter CanBeMadePrimary { get; }
				public SelectorColumnFilter ContactID { get; }
                
                public c_grid_header(c_contacts_grdcontacts grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    DisplayName = new SelectorColumnFilter(grid.Row.DisplayName);
                    Salutation = new PXTextEditColumnFilter(grid.Row.Salutation);
                    IsPrimary = new CheckBoxColumnFilter(grid.Row.IsPrimary);
                    EMail = new PXTextEditColumnFilter(grid.Row.EMail);
                    Phone1 = new PXTextEditColumnFilter(grid.Row.Phone1);
                    OwnerID = new SelectorColumnFilter(grid.Row.OwnerID);
                    FullName = new PXTextEditColumnFilter(grid.Row.FullName);
                    ClassID = new SelectorColumnFilter(grid.Row.ClassID);
                    LastModifiedDateTime = new DateSelectorColumnFilter(grid.Row.LastModifiedDateTime);
                    CreatedDateTime = new DateSelectorColumnFilter(grid.Row.CreatedDateTime);
                    Source = new DropDownColumnFilter(grid.Row.Source);
                    AssignDate = new DateSelectorColumnFilter(grid.Row.AssignDate);
                    DuplicateStatus = new DropDownColumnFilter(grid.Row.DuplicateStatus);
                    Phone2 = new PXTextEditColumnFilter(grid.Row.Phone2);
                    Phone3 = new PXTextEditColumnFilter(grid.Row.Phone3);
                    DateOfBirth = new DateSelectorColumnFilter(grid.Row.DateOfBirth);
                    Fax = new PXTextEditColumnFilter(grid.Row.Fax);
                    Gender = new DropDownColumnFilter(grid.Row.Gender);
                    Method = new DropDownColumnFilter(grid.Row.Method);
                    NoCall = new CheckBoxColumnFilter(grid.Row.NoCall);
                    NoEMail = new CheckBoxColumnFilter(grid.Row.NoEMail);
                    NoFax = new CheckBoxColumnFilter(grid.Row.NoFax);
                    NoMail = new CheckBoxColumnFilter(grid.Row.NoMail);
                    NoMarketing = new CheckBoxColumnFilter(grid.Row.NoMarketing);
                    NoMassMail = new CheckBoxColumnFilter(grid.Row.NoMassMail);
                    CampaignID = new SelectorColumnFilter(grid.Row.CampaignID);
                    Phone1Type = new DropDownColumnFilter(grid.Row.Phone1Type);
                    Phone2Type = new DropDownColumnFilter(grid.Row.Phone2Type);
                    Phone3Type = new DropDownColumnFilter(grid.Row.Phone3Type);
                    FaxType = new DropDownColumnFilter(grid.Row.FaxType);
                    MaritalStatus = new DropDownColumnFilter(grid.Row.MaritalStatus);
                    Spouse = new PXTextEditColumnFilter(grid.Row.Spouse);
                    Status = new DropDownColumnFilter(grid.Row.Status);
                    Resolution = new DropDownColumnFilter(grid.Row.Resolution);
                    LanguageID = new SelectorColumnFilter(grid.Row.LanguageID);
                    Address__CountryID = new SelectorColumnFilter(grid.Row.Address__CountryID);
                    Address__State = new SelectorColumnFilter(grid.Row.Address__State);
                    Address__City = new PXTextEditColumnFilter(grid.Row.Address__City);
                    Address__AddressLine1 = new PXTextEditColumnFilter(grid.Row.Address__AddressLine1);
                    Address__AddressLine2 = new PXTextEditColumnFilter(grid.Row.Address__AddressLine2);
                    Address__PostalCode = new PXTextEditColumnFilter(grid.Row.Address__PostalCode);
                    CanBeMadePrimary = new CheckBoxColumnFilter(grid.Row.CanBeMadePrimary);
                    ContactID = new SelectorColumnFilter(grid.Row.ContactID);
                }
            }
        }
        
        public class c_contacts_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_contacts_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t7_grdContacts_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t7_grdContacts_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t7_grdContacts_lv0_ec", "Ec", locator, null);
                DataMemberName = "Contacts";
            }
        }
        
        public class c_defcontact_defcontact1 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown Phone1Type { get; }
			public Label Phone1TypeLabel { get; }
			public PXTextEdit Phone1 { get; }
			public Label Phone1Label { get; }
			public DropDown Phone2Type { get; }
			public Label Phone2TypeLabel { get; }
			public PXTextEdit Phone2 { get; }
			public Label Phone2Label { get; }
			public DropDown FaxType { get; }
			public Label FaxTypeLabel { get; }
			public PXTextEdit Fax { get; }
			public Label FaxLabel { get; }
			public EmailEdit EMail { get; }
			public Label EMailLabel { get; }
			public LinkEdit WebSite { get; }
			public Label WebSiteLabel { get; }
			public Label EdDefContactlblPhone1_ { get; }
			public Label EdDefContactlblPhone2_ { get; }
			public Label EdDefContactlblFax_ { get; }
			public Label LblDefContactAccountEmail_ { get; }
            
            public c_defcontact_defcontact1(string locator, string name) : 
                    base(locator, name)
            {
                Phone1Type = new DropDown("ctl00_phG_tab_t0_DefContact1_edDefContactPhone1Type", "Phone 1 Type", locator, null);
                Phone1TypeLabel = new Label(Phone1Type);
                Phone1Type.DataField = "Phone1Type";
                Phone1Type.Items.Add("B1", "Business 1");
                Phone1Type.Items.Add("B2", "Business 2");
                Phone1Type.Items.Add("B3", "Business 3");
                Phone1Type.Items.Add("C", "Cell");
                Phone1Type.Items.Add("BA1", "Assistant");
                Phone1Type.Items.Add("BF", "Fax");
                Phone1Type.Items.Add("H1", "Home");
                Phone1Type.Items.Add("HF", "Home Fax");
                Phone1 = new PXTextEdit("ctl00_phG_tab_t0_DefContact1_edDefContactPXMaskEdit1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Phone2Type = new DropDown("ctl00_phG_tab_t0_DefContact1_edDefContactPhone2Type", "Phone 2 Type", locator, null);
                Phone2TypeLabel = new Label(Phone2Type);
                Phone2Type.DataField = "Phone2Type";
                Phone2Type.Items.Add("B1", "Business 1");
                Phone2Type.Items.Add("B2", "Business 2");
                Phone2Type.Items.Add("B3", "Business 3");
                Phone2Type.Items.Add("C", "Cell");
                Phone2Type.Items.Add("BA1", "Assistant");
                Phone2Type.Items.Add("BF", "Fax");
                Phone2Type.Items.Add("H1", "Home");
                Phone2Type.Items.Add("HF", "Home Fax");
                Phone2 = new PXTextEdit("ctl00_phG_tab_t0_DefContact1_edDefContactPXMaskEdit2", "Phone 2", locator, null);
                Phone2Label = new Label(Phone2);
                Phone2.DataField = "Phone2";
                FaxType = new DropDown("ctl00_phG_tab_t0_DefContact1_edDefContactFaxType", "Fax Type", locator, null);
                FaxTypeLabel = new Label(FaxType);
                FaxType.DataField = "FaxType";
                FaxType.Items.Add("B1", "Business 1");
                FaxType.Items.Add("B2", "Business 2");
                FaxType.Items.Add("B3", "Business 3");
                FaxType.Items.Add("C", "Cell");
                FaxType.Items.Add("BA1", "Assistant");
                FaxType.Items.Add("BF", "Fax");
                FaxType.Items.Add("H1", "Home");
                FaxType.Items.Add("HF", "Home Fax");
                Fax = new PXTextEdit("ctl00_phG_tab_t0_DefContact1_edDefContactPXMaskEdit3", "Fax", locator, null);
                FaxLabel = new Label(Fax);
                Fax.DataField = "Fax";
                EMail = new EmailEdit("ctl00_phG_tab_t0_DefContact1_edDefContactEMail", "Account Email", locator, null);
                EMailLabel = new Label(EMail);
                EMail.DataField = "EMail";
                WebSite = new LinkEdit("ctl00_phG_tab_t0_DefContact1_edDefContactWebSite", "Web", locator, null);
                WebSiteLabel = new Label(WebSite);
                WebSite.DataField = "WebSite";
                EdDefContactlblPhone1_ = new Label("ctl00_phG_tab_t0_DefContact1_edDefContactlblPhone1", "Ed Def Contactlbl Phone 1_", locator, null);
                EdDefContactlblPhone2_ = new Label("ctl00_phG_tab_t0_DefContact1_edDefContactlblPhone2", "Ed Def Contactlbl Phone 2_", locator, null);
                EdDefContactlblFax_ = new Label("ctl00_phG_tab_t0_DefContact1_edDefContactlblFax", "Ed Def Contactlbl Fax _", locator, null);
                LblDefContactAccountEmail_ = new Label("ctl00_phG_tab_t0_DefContact1_lblDefContactAccountEmail", "Account Email:", locator, null);
                DataMemberName = "DefContact";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void PrimaryContactIDEdit()
            {
                Buttons.PrimaryContactIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button PrimaryContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t0_DefAddress_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t0_DefContact1");
                    ViewonMap = new Button("ctl00_phG_tab_t0_DefAddress_btnViewMainOnMap", "View on Map", "ctl00_phG_tab_t0_DefContact1");
                    PrimaryContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPrmCntID\'] div[class=\'editBtnCont\'] > div > div", "PrimaryContactIDEdit", "ctl00_phG_tab_t0_DefContact1");
                    PrimaryContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_defcontact_defcontact2 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox ConsentAgreement { get; }
			public Label ConsentAgreementLabel { get; }
			public DateSelector ConsentDate { get; }
			public Label ConsentDateLabel { get; }
			public DateSelector ConsentExpirationDate { get; }
			public Label ConsentExpirationDateLabel { get; }
            
            public c_defcontact_defcontact2(string locator, string name) : 
                    base(locator, name)
            {
                ConsentAgreement = new CheckBox("ctl00_phG_tab_t0_DefContact2_edDefContactConsentAgreement", "Consented to the Processing of Personal Data", locator, null);
                ConsentAgreementLabel = new Label(ConsentAgreement);
                ConsentAgreement.DataField = "ConsentAgreement";
                ConsentDate = new DateSelector("ctl00_phG_tab_t0_DefContact2_edDefContactConsentDate", "Date of Consent", locator, null);
                ConsentDateLabel = new Label(ConsentDate);
                ConsentDate.DataField = "ConsentDate";
                ConsentExpirationDate = new DateSelector("ctl00_phG_tab_t0_DefContact2_edDefContactConsentExpirationDate", "Consent Expires", locator, null);
                ConsentExpirationDateLabel = new Label(ConsentExpirationDate);
                ConsentExpirationDate.DataField = "ConsentExpirationDate";
                DataMemberName = "DefContact";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void PrimaryContactIDEdit()
            {
                Buttons.PrimaryContactIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button PrimaryContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t0_DefAddress_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t0_DefContact2");
                    ViewonMap = new Button("ctl00_phG_tab_t0_DefAddress_btnViewMainOnMap", "View on Map", "ctl00_phG_tab_t0_DefContact2");
                    PrimaryContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPrmCntID\'] div[class=\'editBtnCont\'] > div > div", "PrimaryContactIDEdit", "ctl00_phG_tab_t0_DefContact2");
                    PrimaryContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_deflocationcontact_deflocationcontact : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit FullName { get; }
			public Label FullNameLabel { get; }
			public PXTextEdit Attention { get; }
			public Label AttentionLabel { get; }
			public DropDown Phone1Type { get; }
			public Label Phone1TypeLabel { get; }
			public PXTextEdit Phone1 { get; }
			public Label Phone1Label { get; }
			public DropDown Phone2Type { get; }
			public Label Phone2TypeLabel { get; }
			public PXTextEdit Phone2 { get; }
			public Label Phone2Label { get; }
			public DropDown FaxType { get; }
			public Label FaxTypeLabel { get; }
			public PXTextEdit Fax { get; }
			public Label FaxLabel { get; }
			public EmailEdit EMail { get; }
			public Label EMailLabel { get; }
			public LinkEdit WebSite { get; }
			public Label WebSiteLabel { get; }
			public Label LblPhone1_ { get; }
			public Label LblPhone2_ { get; }
			public Label LblFax_ { get; }
            
            public c_deflocationcontact_deflocationcontact(string locator, string name) : 
                    base(locator, name)
            {
                FullName = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_DefLocationContact_edDefLocationContactFullName", "Account Name", locator, null);
                FullNameLabel = new Label(FullName);
                FullName.DataField = "FullName";
                Attention = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_DefLocationContact_edDefLocationContactAttention", "Attention", locator, null);
                AttentionLabel = new Label(Attention);
                Attention.DataField = "Attention";
                Phone1Type = new DropDown("ctl00_phG_tab_t3_DefLocation_DefLocationContact_Phone1Type", "Phone 1 Type", locator, null);
                Phone1TypeLabel = new Label(Phone1Type);
                Phone1Type.DataField = "Phone1Type";
                Phone1Type.Items.Add("B1", "Business 1");
                Phone1Type.Items.Add("B2", "Business 2");
                Phone1Type.Items.Add("B3", "Business 3");
                Phone1Type.Items.Add("C", "Cell");
                Phone1Type.Items.Add("BA1", "Assistant");
                Phone1Type.Items.Add("BF", "Fax");
                Phone1Type.Items.Add("H1", "Home");
                Phone1Type.Items.Add("HF", "Home Fax");
                Phone1 = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_DefLocationContact_PXMaskEdit1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Phone2Type = new DropDown("ctl00_phG_tab_t3_DefLocation_DefLocationContact_Phone2Type", "Phone 2 Type", locator, null);
                Phone2TypeLabel = new Label(Phone2Type);
                Phone2Type.DataField = "Phone2Type";
                Phone2Type.Items.Add("B1", "Business 1");
                Phone2Type.Items.Add("B2", "Business 2");
                Phone2Type.Items.Add("B3", "Business 3");
                Phone2Type.Items.Add("C", "Cell");
                Phone2Type.Items.Add("BA1", "Assistant");
                Phone2Type.Items.Add("BF", "Fax");
                Phone2Type.Items.Add("H1", "Home");
                Phone2Type.Items.Add("HF", "Home Fax");
                Phone2 = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_DefLocationContact_PXMaskEdit2", "Phone 2", locator, null);
                Phone2Label = new Label(Phone2);
                Phone2.DataField = "Phone2";
                FaxType = new DropDown("ctl00_phG_tab_t3_DefLocation_DefLocationContact_FaxType", "Fax Type", locator, null);
                FaxTypeLabel = new Label(FaxType);
                FaxType.DataField = "FaxType";
                FaxType.Items.Add("B1", "Business 1");
                FaxType.Items.Add("B2", "Business 2");
                FaxType.Items.Add("B3", "Business 3");
                FaxType.Items.Add("C", "Cell");
                FaxType.Items.Add("BA1", "Assistant");
                FaxType.Items.Add("BF", "Fax");
                FaxType.Items.Add("H1", "Home");
                FaxType.Items.Add("HF", "Home Fax");
                Fax = new PXTextEdit("ctl00_phG_tab_t3_DefLocation_DefLocationContact_PXMaskEdit3", "Fax", locator, null);
                FaxLabel = new Label(Fax);
                Fax.DataField = "Fax";
                EMail = new EmailEdit("ctl00_phG_tab_t3_DefLocation_DefLocationContact_edDefLocationContactEMail", "Email", locator, null);
                EMailLabel = new Label(EMail);
                EMail.DataField = "EMail";
                WebSite = new LinkEdit("ctl00_phG_tab_t3_DefLocation_DefLocationContact_edDefLocationContactWebSite", "Web", locator, null);
                WebSiteLabel = new Label(WebSite);
                WebSite.DataField = "WebSite";
                LblPhone1_ = new Label("ctl00_phG_tab_t3_DefLocation_DefLocationContact_lblPhone1", "Lbl Phone 1_", locator, null);
                LblPhone2_ = new Label("ctl00_phG_tab_t3_DefLocation_DefLocationContact_lblPhone2", "Lbl Phone 2_", locator, null);
                LblFax_ = new Label("ctl00_phG_tab_t3_DefLocation_DefLocationContact_lblFax", "Lbl Fax _", locator, null);
                DataMemberName = "DefLocationContact";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void BtnDefLocationAddressLookup()
            {
                Buttons.BtnDefLocationAddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void VBranchIDEdit()
            {
                Buttons.VBranchIDEdit.Click();
            }
            
            public virtual void VTaxZoneIDEdit()
            {
                Buttons.VTaxZoneIDEdit.Click();
            }
            
            public virtual void VCarrierIDEdit()
            {
                Buttons.VCarrierIDEdit.Click();
            }
            
            public virtual void VShipTermsIDEdit()
            {
                Buttons.VShipTermsIDEdit.Click();
            }
            
            public virtual void VFOBPointIDEdit()
            {
                Buttons.VFOBPointIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button BtnDefLocationAddressLookup { get; }
			public Button ViewonMap { get; }
			public Button VBranchIDEdit { get; }
			public Button VTaxZoneIDEdit { get; }
			public Button VCarrierIDEdit { get; }
			public Button VShipTermsIDEdit { get; }
			public Button VFOBPointIDEdit { get; }
                
                public PxButtonCollection()
                {
                    BtnDefLocationAddressLookup = new Button("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_btnDefLocationAddressLookup", "btnDefLocationAddressLookup", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    ViewonMap = new Button("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_btnViewDefLocationAddressOnMap", "View on Map", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    VBranchIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edVBranchID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "VBranchIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    VBranchIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    VTaxZoneIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edTaxZoneID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "VTaxZoneIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    VTaxZoneIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    VCarrierIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edVCarrierID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "VCarrierIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    VCarrierIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    VShipTermsIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edShipTermsID\'] div[class=\'editBtnCont\']" +
                            " > div > div", "VShipTermsIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    VShipTermsIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    VFOBPointIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edFOBPointID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "VFOBPointIDEdit", "ctl00_phG_tab_t3_DefLocation_DefLocationContact");
                    VFOBPointIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_remitcontact_remitcontact : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit FullName { get; }
			public Label FullNameLabel { get; }
			public PXTextEdit Attention { get; }
			public Label AttentionLabel { get; }
			public DropDown Phone1Type { get; }
			public Label Phone1TypeLabel { get; }
			public PXTextEdit Phone1 { get; }
			public Label Phone1Label { get; }
			public DropDown Phone2Type { get; }
			public Label Phone2TypeLabel { get; }
			public PXTextEdit Phone2 { get; }
			public Label Phone2Label { get; }
			public DropDown FaxType { get; }
			public Label FaxTypeLabel { get; }
			public PXTextEdit Fax { get; }
			public Label FaxLabel { get; }
			public EmailEdit EMail { get; }
			public Label EMailLabel { get; }
			public LinkEdit WebSite { get; }
			public Label WebSiteLabel { get; }
			public Label LblPhone1_ { get; }
			public Label LblPhone2_ { get; }
			public Label LblFax_ { get; }
            
            public c_remitcontact_remitcontact(string locator, string name) : 
                    base(locator, name)
            {
                FullName = new PXTextEdit("ctl00_phG_tab_t2_DefLocationPayment_RemitContact_edFullName", "Account Name", locator, null);
                FullNameLabel = new Label(FullName);
                FullName.DataField = "FullName";
                Attention = new PXTextEdit("ctl00_phG_tab_t2_DefLocationPayment_RemitContact_edAttention", "Attention", locator, null);
                AttentionLabel = new Label(Attention);
                Attention.DataField = "Attention";
                Phone1Type = new DropDown("ctl00_phG_tab_t2_DefLocationPayment_RemitContact_Phone1Type", "Phone 1 Type", locator, null);
                Phone1TypeLabel = new Label(Phone1Type);
                Phone1Type.DataField = "Phone1Type";
                Phone1Type.Items.Add("B1", "Business 1");
                Phone1Type.Items.Add("B2", "Business 2");
                Phone1Type.Items.Add("B3", "Business 3");
                Phone1Type.Items.Add("C", "Cell");
                Phone1Type.Items.Add("BA1", "Assistant");
                Phone1Type.Items.Add("BF", "Fax");
                Phone1Type.Items.Add("H1", "Home");
                Phone1Type.Items.Add("HF", "Home Fax");
                Phone1 = new PXTextEdit("ctl00_phG_tab_t2_DefLocationPayment_RemitContact_PXMaskEdit1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Phone2Type = new DropDown("ctl00_phG_tab_t2_DefLocationPayment_RemitContact_Phone2Type", "Phone 2 Type", locator, null);
                Phone2TypeLabel = new Label(Phone2Type);
                Phone2Type.DataField = "Phone2Type";
                Phone2Type.Items.Add("B1", "Business 1");
                Phone2Type.Items.Add("B2", "Business 2");
                Phone2Type.Items.Add("B3", "Business 3");
                Phone2Type.Items.Add("C", "Cell");
                Phone2Type.Items.Add("BA1", "Assistant");
                Phone2Type.Items.Add("BF", "Fax");
                Phone2Type.Items.Add("H1", "Home");
                Phone2Type.Items.Add("HF", "Home Fax");
                Phone2 = new PXTextEdit("ctl00_phG_tab_t2_DefLocationPayment_RemitContact_PXMaskEdit2", "Phone 2", locator, null);
                Phone2Label = new Label(Phone2);
                Phone2.DataField = "Phone2";
                FaxType = new DropDown("ctl00_phG_tab_t2_DefLocationPayment_RemitContact_FaxType", "Fax Type", locator, null);
                FaxTypeLabel = new Label(FaxType);
                FaxType.DataField = "FaxType";
                FaxType.Items.Add("B1", "Business 1");
                FaxType.Items.Add("B2", "Business 2");
                FaxType.Items.Add("B3", "Business 3");
                FaxType.Items.Add("C", "Cell");
                FaxType.Items.Add("BA1", "Assistant");
                FaxType.Items.Add("BF", "Fax");
                FaxType.Items.Add("H1", "Home");
                FaxType.Items.Add("HF", "Home Fax");
                Fax = new PXTextEdit("ctl00_phG_tab_t2_DefLocationPayment_RemitContact_PXMaskEdit3", "Fax", locator, null);
                FaxLabel = new Label(Fax);
                Fax.DataField = "Fax";
                EMail = new EmailEdit("ctl00_phG_tab_t2_DefLocationPayment_RemitContact_edEMail", "Email", locator, null);
                EMailLabel = new Label(EMail);
                EMail.DataField = "EMail";
                WebSite = new LinkEdit("ctl00_phG_tab_t2_DefLocationPayment_RemitContact_edWebSite", "Web", locator, null);
                WebSiteLabel = new Label(WebSite);
                WebSite.DataField = "WebSite";
                LblPhone1_ = new Label("ctl00_phG_tab_t2_DefLocationPayment_RemitContact_lblPhone1", "Lbl Phone 1_", locator, null);
                LblPhone2_ = new Label("ctl00_phG_tab_t2_DefLocationPayment_RemitContact_lblPhone2", "Lbl Phone 2_", locator, null);
                LblFax_ = new Label("ctl00_phG_tab_t2_DefLocationPayment_RemitContact_lblFax", "Lbl Fax _", locator, null);
                DataMemberName = "RemitContact";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
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
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t2_DefLocationPayment_RemitAddress_btnRemitAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_DefLocationPayment_RemitContact");
                    ViewonMap = new Button("ctl00_phG_tab_t2_DefLocationPayment_RemitAddress_btnViewRemitOnMap", "View on Map", "ctl00_phG_tab_t2_DefLocationPayment_RemitContact");
                    First = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfFirst0", "First", "ctl00_phG_tab_t2_DefLocationPayment_RemitContact");
                    Prev = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfPrev0", "Prev", "ctl00_phG_tab_t2_DefLocationPayment_RemitContact");
                    Next = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfNext0", "Next", "ctl00_phG_tab_t2_DefLocationPayment_RemitContact");
                    Last = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfLast0", "Last", "ctl00_phG_tab_t2_DefLocationPayment_RemitContact");
                }
            }
        }
        
        public class c_primarycontactcurrent_frmprimarycontact : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit FirstName { get; }
			public Label FirstNameLabel { get; }
			public PXTextEdit LastName { get; }
			public Label LastNameLabel { get; }
			public PXTextEdit Salutation { get; }
			public Label SalutationLabel { get; }
			public EmailEdit EMail { get; }
			public Label EMailLabel { get; }
			public DropDown Phone1Type { get; }
			public Label Phone1TypeLabel { get; }
			public PXTextEdit Phone1 { get; }
			public Label Phone1Label { get; }
			public DropDown Phone2Type { get; }
			public Label Phone2TypeLabel { get; }
			public PXTextEdit Phone2 { get; }
			public Label Phone2Label { get; }
			public CheckBox ConsentAgreement { get; }
			public Label ConsentAgreementLabel { get; }
			public DateSelector ConsentDate { get; }
			public Label ConsentDateLabel { get; }
			public DateSelector ConsentExpirationDate { get; }
			public Label ConsentExpirationDateLabel { get; }
			public Label LblPrimaryContactName_ { get; }
			public Label LblPrmCntPhone1_ { get; }
			public Label LblPrmCntPhone2_ { get; }
            
            public c_primarycontactcurrent_frmprimarycontact(string locator, string name) : 
                    base(locator, name)
            {
                FirstName = new PXTextEdit("ctl00_phG_tab_t0_frmPrimaryContact_edPrmCntFirstName", "Name", locator, null);
                FirstNameLabel = new Label(FirstName);
                FirstName.DataField = "FirstName";
                LastName = new PXTextEdit("ctl00_phG_tab_t0_frmPrimaryContact_edPrmCntLastName", "Last Name", locator, null);
                LastNameLabel = new Label(LastName);
                LastName.DataField = "LastName";
                Salutation = new PXTextEdit("ctl00_phG_tab_t0_frmPrimaryContact_edPrmCntJobTitle", "Job Title", locator, null);
                SalutationLabel = new Label(Salutation);
                Salutation.DataField = "Salutation";
                EMail = new EmailEdit("ctl00_phG_tab_t0_frmPrimaryContact_edPrmCntEmail", "Email", locator, null);
                EMailLabel = new Label(EMail);
                EMail.DataField = "EMail";
                Phone1Type = new DropDown("ctl00_phG_tab_t0_frmPrimaryContact_ddPrmCntPhone1Type", "Phone 1 Type", locator, null);
                Phone1TypeLabel = new Label(Phone1Type);
                Phone1Type.DataField = "Phone1Type";
                Phone1Type.Items.Add("B1", "Business 1");
                Phone1Type.Items.Add("B2", "Business 2");
                Phone1Type.Items.Add("B3", "Business 3");
                Phone1Type.Items.Add("C", "Cell");
                Phone1Type.Items.Add("BA1", "Assistant");
                Phone1Type.Items.Add("BF", "Fax");
                Phone1Type.Items.Add("H1", "Home");
                Phone1Type.Items.Add("HF", "Home Fax");
                Phone1 = new PXTextEdit("ctl00_phG_tab_t0_frmPrimaryContact_mePrmCntPhone1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Phone2Type = new DropDown("ctl00_phG_tab_t0_frmPrimaryContact_ddPrmCntPhone2Type", "Phone 2 Type", locator, null);
                Phone2TypeLabel = new Label(Phone2Type);
                Phone2Type.DataField = "Phone2Type";
                Phone2Type.Items.Add("B1", "Business 1");
                Phone2Type.Items.Add("B2", "Business 2");
                Phone2Type.Items.Add("B3", "Business 3");
                Phone2Type.Items.Add("C", "Cell");
                Phone2Type.Items.Add("BA1", "Assistant");
                Phone2Type.Items.Add("BF", "Fax");
                Phone2Type.Items.Add("H1", "Home");
                Phone2Type.Items.Add("HF", "Home Fax");
                Phone2 = new PXTextEdit("ctl00_phG_tab_t0_frmPrimaryContact_mePrmCntPhone2", "Phone 2", locator, null);
                Phone2Label = new Label(Phone2);
                Phone2.DataField = "Phone2";
                ConsentAgreement = new CheckBox("ctl00_phG_tab_t0_frmPrimaryContact_cbPrmCntConsent", "Consented to the Processing of Personal Data", locator, null);
                ConsentAgreementLabel = new Label(ConsentAgreement);
                ConsentAgreement.DataField = "ConsentAgreement";
                ConsentDate = new DateSelector("ctl00_phG_tab_t0_frmPrimaryContact_edPrmCntConsentDate", "Date of Consent", locator, null);
                ConsentDateLabel = new Label(ConsentDate);
                ConsentDate.DataField = "ConsentDate";
                ConsentExpirationDate = new DateSelector("ctl00_phG_tab_t0_frmPrimaryContact_edPrmCntConsentExpDate", "Consent Expires", locator, null);
                ConsentExpirationDateLabel = new Label(ConsentExpirationDate);
                ConsentExpirationDate.DataField = "ConsentExpirationDate";
                LblPrimaryContactName_ = new Label("ctl00_phG_tab_t0_frmPrimaryContact_lblPrimaryContactName", "Name:", locator, null);
                LblPrmCntPhone1_ = new Label("ctl00_phG_tab_t0_frmPrimaryContact_lblPrmCntPhone1", "Lbl Prm Cnt Phone 1_", locator, null);
                LblPrmCntPhone2_ = new Label("ctl00_phG_tab_t0_frmPrimaryContact_lblPrmCntPhone2", "Lbl Prm Cnt Phone 2_", locator, null);
                DataMemberName = "PrimaryContactCurrent";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void PrimaryContactIDEdit()
            {
                Buttons.PrimaryContactIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button PrimaryContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t0_DefAddress_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t0_frmPrimaryContact");
                    ViewonMap = new Button("ctl00_phG_tab_t0_DefAddress_btnViewMainOnMap", "View on Map", "ctl00_phG_tab_t0_frmPrimaryContact");
                    PrimaryContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPrmCntID\'] div[class=\'editBtnCont\'] > div > div", "PrimaryContactIDEdit", "ctl00_phG_tab_t0_frmPrimaryContact");
                    PrimaryContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_vendorbalance_vendorbalance : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit Balance_Label { get; }
			public Label Balance_LabelLabel { get; }
			public PXNumberEdit Balance { get; }
			public Label BalanceLabel { get; }
			public PXTextEdit DepositsBalance_Label { get; }
			public Label DepositsBalance_LabelLabel { get; }
			public PXNumberEdit DepositsBalance { get; }
			public Label DepositsBalanceLabel { get; }
			public PXTextEdit RetainageBalance_Label { get; }
			public Label RetainageBalance_LabelLabel { get; }
			public PXNumberEdit RetainageBalance { get; }
			public Label RetainageBalanceLabel { get; }
            
            public c_vendorbalance_vendorbalance(string locator, string name) : 
                    base(locator, name)
            {
                Balance_Label = new PXTextEdit("ctl00_phF_BAccount_t0_VendorBalance_edBalanceLabel", "Balance _ Label", locator, null);
                Balance_LabelLabel = new Label(Balance_Label);
                Balance_Label.DataField = "Balance_Label";
                Balance = new PXNumberEdit("ctl00_phF_BAccount_t0_VendorBalance_edBBalance", "Balance", locator, null);
                BalanceLabel = new Label(Balance);
                Balance.DataField = "Balance";
                DepositsBalance_Label = new PXTextEdit("ctl00_phF_BAccount_t0_VendorBalance_edDepositsBalanceLabel", "Deposits Balance _ Label", locator, null);
                DepositsBalance_LabelLabel = new Label(DepositsBalance_Label);
                DepositsBalance_Label.DataField = "DepositsBalance_Label";
                DepositsBalance = new PXNumberEdit("ctl00_phF_BAccount_t0_VendorBalance_edBDepositsBalance", "Deposits Balance", locator, null);
                DepositsBalanceLabel = new Label(DepositsBalance);
                DepositsBalance.DataField = "DepositsBalance";
                RetainageBalance_Label = new PXTextEdit("ctl00_phF_BAccount_t0_VendorBalance_edRetainageBalanceLabel", "Retainage Balance _ Label", locator, null);
                RetainageBalance_LabelLabel = new Label(RetainageBalance_Label);
                RetainageBalance_Label.DataField = "RetainageBalance_Label";
                RetainageBalance = new PXNumberEdit("ctl00_phF_BAccount_t0_VendorBalance_edBRetainageBalance", "Retainage Balance", locator, null);
                RetainageBalanceLabel = new Label(RetainageBalance);
                RetainageBalance.DataField = "RetainageBalance";
                DataMemberName = "VendorBalance";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void VendorClassIDEdit()
            {
                Buttons.VendorClassIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button VendorClassIDEdit { get; }
                
                public PxButtonCollection()
                {
                    VendorClassIDEdit = new Button("css=div[id=\'ctl00_phF_BAccount_t0_edVendorClassID\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "VendorClassIDEdit", "ctl00_phF_BAccount_t0_VendorBalance");
                    VendorClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_vendorbalancebybasecurrency_pxgrid1 : Grid<c_vendorbalancebybasecurrency_pxgrid1.c_grid_row, c_vendorbalancebybasecurrency_pxgrid1.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_vendorbalancebybasecurrency_pxgrid1(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t4_PXGrid1");
                DataMemberName = "VendorBalanceByBaseCurrency";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t4_PXGrid1_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_PXGrid1_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_PXGrid1_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_PXGrid1_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_PXGrid1_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_PXGrid1_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_PXGrid1_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_PXGrid1_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_PXGrid1_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_PXGrid1_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit BaseCuryID { get; }
			public PXNumberEdit Balance { get; }
			public PXNumberEdit DepositsBalance { get; }
			public PXNumberEdit RetainageBalance { get; }
                
                public c_grid_row(c_vendorbalancebybasecurrency_pxgrid1 grid) : 
                        base(grid)
                {
                    BaseCuryID = new PXTextEdit("_ctl00_phG_tab_t4_PXGrid1_lv0_edBaseCuryID", "Currency", grid.Locator, "BaseCuryID");
                    BaseCuryID.DataField = "BaseCuryID";
                    Balance = new PXNumberEdit("_ctl00_phG_tab_t4_PXGrid1_lv0_edBalance", "Balance", grid.Locator, "Balance");
                    Balance.DataField = "Balance";
                    DepositsBalance = new PXNumberEdit("_ctl00_phG_tab_t4_PXGrid1_lv0_edDepositsBalance", "Prepayment Balance", grid.Locator, "DepositsBalance");
                    DepositsBalance.DataField = "DepositsBalance";
                    RetainageBalance = new PXNumberEdit("_ctl00_phG_tab_t4_PXGrid1_lv0_edRetainageBalance", "Retained Balance", grid.Locator, "RetainageBalance");
                    RetainageBalance.DataField = "RetainageBalance";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter BaseCuryID { get; }
				public PXNumberEditColumnFilter Balance { get; }
				public PXNumberEditColumnFilter DepositsBalance { get; }
				public PXNumberEditColumnFilter RetainageBalance { get; }
                
                public c_grid_header(c_vendorbalancebybasecurrency_pxgrid1 grid) : 
                        base(grid)
                {
                    BaseCuryID = new PXTextEditColumnFilter(grid.Row.BaseCuryID);
                    Balance = new PXNumberEditColumnFilter(grid.Row.Balance);
                    DepositsBalance = new PXNumberEditColumnFilter(grid.Row.DepositsBalance);
                    RetainageBalance = new PXNumberEditColumnFilter(grid.Row.RetainageBalance);
                }
            }
        }
        
        public class c_vendorbalancebybasecurrency_lv0 : Container
        {
            
			public PXTextEdit BaseCuryID { get; }
			public Label BaseCuryIDLabel { get; }
			public PXNumberEdit Balance { get; }
			public Label BalanceLabel { get; }
			public PXNumberEdit DepositsBalance { get; }
			public Label DepositsBalanceLabel { get; }
			public PXNumberEdit RetainageBalance { get; }
			public Label RetainageBalanceLabel { get; }
            
            public c_vendorbalancebybasecurrency_lv0(string locator, string name) : 
                    base(locator, name)
            {
                BaseCuryID = new PXTextEdit("ctl00_phG_tab_t4_PXGrid1_lv0_edBaseCuryID", "Currency", locator, null);
                BaseCuryIDLabel = new Label(BaseCuryID);
                BaseCuryID.DataField = "BaseCuryID";
                Balance = new PXNumberEdit("ctl00_phG_tab_t4_PXGrid1_lv0_edBalance", "Balance", locator, null);
                BalanceLabel = new Label(Balance);
                Balance.DataField = "Balance";
                DepositsBalance = new PXNumberEdit("ctl00_phG_tab_t4_PXGrid1_lv0_edDepositsBalance", "Prepayment Balance", locator, null);
                DepositsBalanceLabel = new Label(DepositsBalance);
                DepositsBalance.DataField = "DepositsBalance";
                RetainageBalance = new PXNumberEdit("ctl00_phG_tab_t4_PXGrid1_lv0_edRetainageBalance", "Retained Balance", locator, null);
                RetainageBalanceLabel = new Label(RetainageBalance);
                RetainageBalance.DataField = "RetainageBalance";
                DataMemberName = "VendorBalanceByBaseCurrency";
            }
        }
        
        public class c_notificationsources_gridns : Grid<c_notificationsources_gridns.c_grid_row, c_notificationsources_gridns.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_notificationsources_gridns(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t11_sp1_gridNS");
                DataMemberName = "NotificationSources";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t11_sp1_gridNS_fe_gf", "FilterForm");
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
            
            public virtual void ContactIDEdit()
            {
                Buttons.ContactIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNS_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNS_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNS_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNS_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNS_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNS_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNS_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNS_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNS_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNS_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNS_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "ContactIDEdit", "ctl00_phG_tab_t11_sp1_gridNS");
                    ContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Active { get; }
			public CheckBox OverrideSource { get; }
			public Selector SetupID { get; }
			public Selector NBranchID { get; }
			public Selector EMailAccountID { get; }
			public Selector ReportID { get; }
			public Selector NotificationID { get; }
			public DropDown Format { get; }
			public DropDown RecipientsBehavior { get; }
			public PXNumberEdit SourceID { get; }
                
                public c_grid_row(c_notificationsources_gridns grid) : 
                        base(grid)
                {
                    Active = new CheckBox("_ctl00_phG_tab_t11_sp1_gridNS_lv0_chkActive", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    OverrideSource = new CheckBox("ctl00_phG_tab_t11_sp1_gridNS_ef", "Overridden", grid.Locator, "OverrideSource");
                    OverrideSource.DataField = "OverrideSource";
                    SetupID = new Selector("_ctl00_phG_tab_t11_sp1_gridNS_lv0_edSetupID", "Mailing ID", grid.Locator, "SetupID");
                    SetupID.DataField = "SetupID";
                    NBranchID = new Selector("_ctl00_phG_tab_t11_sp1_gridNS_lv0_edNBranchID", "Branch", grid.Locator, "NBranchID");
                    NBranchID.DataField = "NBranchID";
                    EMailAccountID = new Selector("_ctl00_phG_tab_t11_sp1_gridNS_lv0_edEMailAccountID", "Email Account", grid.Locator, "EMailAccountID");
                    EMailAccountID.DataField = "EMailAccountID";
                    ReportID = new Selector("_ctl00_phG_tab_t11_sp1_gridNS_lv0_edReportID", "Report", grid.Locator, "ReportID");
                    ReportID.DataField = "ReportID";
                    NotificationID = new Selector("_ctl00_phG_tab_t11_sp1_gridNS_lv0_edNotificationID", "Notification Template", grid.Locator, "NotificationID");
                    NotificationID.DataField = "NotificationID";
                    Format = new DropDown("_ctl00_phG_tab_t11_sp1_gridNS_lv0_edFormat", "Format", grid.Locator, "Format");
                    Format.DataField = "Format";
                    Format.Items.Add("H", "Html");
                    Format.Items.Add("E", "Excel");
                    Format.Items.Add("P", "PDF");
                    RecipientsBehavior = new DropDown("_ctl00_phG_tab_t11_sp1_gridNS_lv0_ec", "Recipients", grid.Locator, "RecipientsBehavior");
                    RecipientsBehavior.DataField = "RecipientsBehavior";
                    RecipientsBehavior.Items.Add("O", "Override Recipients");
                    RecipientsBehavior.Items.Add("A", "Add Recipients");
                    SourceID = new PXNumberEdit("ctl00_phG_tab_t11_sp1_gridNS_en", "SourceID", grid.Locator, "SourceID");
                    SourceID.DataField = "SourceID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Active { get; }
				public CheckBoxColumnFilter OverrideSource { get; }
				public SelectorColumnFilter SetupID { get; }
				public SelectorColumnFilter NBranchID { get; }
				public SelectorColumnFilter EMailAccountID { get; }
				public SelectorColumnFilter ReportID { get; }
				public SelectorColumnFilter NotificationID { get; }
				public DropDownColumnFilter Format { get; }
				public DropDownColumnFilter RecipientsBehavior { get; }
				public PXNumberEditColumnFilter SourceID { get; }
                
                public c_grid_header(c_notificationsources_gridns grid) : 
                        base(grid)
                {
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    OverrideSource = new CheckBoxColumnFilter(grid.Row.OverrideSource);
                    SetupID = new SelectorColumnFilter(grid.Row.SetupID);
                    NBranchID = new SelectorColumnFilter(grid.Row.NBranchID);
                    EMailAccountID = new SelectorColumnFilter(grid.Row.EMailAccountID);
                    ReportID = new SelectorColumnFilter(grid.Row.ReportID);
                    NotificationID = new SelectorColumnFilter(grid.Row.NotificationID);
                    Format = new DropDownColumnFilter(grid.Row.Format);
                    RecipientsBehavior = new DropDownColumnFilter(grid.Row.RecipientsBehavior);
                    SourceID = new PXNumberEditColumnFilter(grid.Row.SourceID);
                }
            }
        }
        
        public class c_notificationsources_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown Format { get; }
			public Label FormatLabel { get; }
			public Selector NBranchID { get; }
			public Label NBranchIDLabel { get; }
			public CheckBox Active { get; }
			public Label ActiveLabel { get; }
			public Selector SetupID { get; }
			public Label SetupIDLabel { get; }
			public Selector ReportID { get; }
			public Label ReportIDLabel { get; }
			public Selector NotificationID { get; }
			public Label NotificationIDLabel { get; }
			public Selector EMailAccountID { get; }
			public Label EMailAccountIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_notificationsources_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Format = new DropDown("ctl00_phG_tab_t11_sp1_gridNS_lv0_edFormat", "Format", locator, null);
                FormatLabel = new Label(Format);
                Format.DataField = "Format";
                Format.Items.Add("H", "Html");
                Format.Items.Add("E", "Excel");
                Format.Items.Add("P", "PDF");
                NBranchID = new Selector("ctl00_phG_tab_t11_sp1_gridNS_lv0_edNBranchID", "Branch", locator, null);
                NBranchIDLabel = new Label(NBranchID);
                NBranchID.DataField = "NBranchID";
                Active = new CheckBox("ctl00_phG_tab_t11_sp1_gridNS_lv0_chkActive", "Active", locator, null);
                ActiveLabel = new Label(Active);
                Active.DataField = "Active";
                SetupID = new Selector("ctl00_phG_tab_t11_sp1_gridNS_lv0_edSetupID", "Mailing ID", locator, null);
                SetupIDLabel = new Label(SetupID);
                SetupID.DataField = "SetupID";
                ReportID = new Selector("ctl00_phG_tab_t11_sp1_gridNS_lv0_edReportID", "Report", locator, null);
                ReportIDLabel = new Label(ReportID);
                ReportID.DataField = "ReportID";
                NotificationID = new Selector("ctl00_phG_tab_t11_sp1_gridNS_lv0_edNotificationID", "Notification Template", locator, null);
                NotificationIDLabel = new Label(NotificationID);
                NotificationID.DataField = "NotificationID";
                EMailAccountID = new Selector("ctl00_phG_tab_t11_sp1_gridNS_lv0_edEMailAccountID", "Email Account", locator, null);
                EMailAccountIDLabel = new Label(EMailAccountID);
                EMailAccountID.DataField = "EMailAccountID";
                Es = new Selector("ctl00_phG_tab_t11_sp1_gridNS_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t11_sp1_gridNS_lv0_ec", "Ec", locator, null);
                DataMemberName = "NotificationSources";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ContactIDEdit()
            {
                Buttons.ContactIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "ContactIDEdit", "ctl00_phG_tab_t11_sp1_gridNS_lv0");
                    ContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_notificationrecipients_gridnr : Grid<c_notificationrecipients_gridnr.c_grid_row, c_notificationrecipients_gridnr.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_notificationrecipients_gridnr(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t11_sp1_gridNR");
                DataMemberName = "NotificationRecipients";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t11_sp1_gridNR_fe_gf", "FilterForm");
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
            
            public virtual void ContactIDEdit()
            {
                Buttons.ContactIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNR_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNR_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNR_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNR_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNR_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNR_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNR_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNR_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNR_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNR_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t11_sp1_gridNR_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "ContactIDEdit", "ctl00_phG_tab_t11_sp1_gridNR");
                    ContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Active { get; }
			public DropDown ContactType { get; }
			public PXNumberEdit OriginalContactID { get; }
			public Selector ContactID { get; }
			public PXTextEdit Email { get; }
			public DropDown Format { get; }
			public DropDown AddTo { get; }
			public PXNumberEdit NotificationID { get; }
                
                public c_grid_row(c_notificationrecipients_gridnr grid) : 
                        base(grid)
                {
                    Active = new CheckBox("ctl00_phG_tab_t11_sp1_gridNR_ef", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    ContactType = new DropDown("_ctl00_phG_tab_t11_sp1_gridNR_lv0_edContactType", "Contact Type", grid.Locator, "ContactType");
                    ContactType.DataField = "ContactType";
                    ContactType.Items.Add("P", "Primary");
                    ContactType.Items.Add("R", "Remittance");
                    ContactType.Items.Add("S", "Shipping");
                    ContactType.Items.Add("E", "Employee");
                    ContactType.Items.Add("C", "Contact");
                    OriginalContactID = new PXNumberEdit("ctl00_phG_tab_t11_sp1_gridNR_en", "OriginalContactID", grid.Locator, "OriginalContactID");
                    OriginalContactID.DataField = "OriginalContactID";
                    ContactID = new Selector("_ctl00_phG_tab_t11_sp1_gridNR_lv0_edContactID", "Contact ID", grid.Locator, "ContactID");
                    ContactID.DataField = "ContactID";
                    Email = new PXTextEdit("ctl00_phG_tab_t11_sp1_gridNR_ei", "Email", grid.Locator, "Email");
                    Email.DataField = "Email";
                    Format = new DropDown("_ctl00_phG_tab_t11_sp1_gridNR_lv0_ec", "Format", grid.Locator, "Format");
                    Format.DataField = "Format";
                    Format.Items.Add("H", "Html");
                    Format.Items.Add("E", "Excel");
                    Format.Items.Add("P", "PDF");
                    AddTo = new DropDown("_ctl00_phG_tab_t11_sp1_gridNR_lv0_ec", "Add To", grid.Locator, "AddTo");
                    AddTo.DataField = "AddTo";
                    AddTo.Items.Add("T", "To");
                    AddTo.Items.Add("C", "Cc");
                    AddTo.Items.Add("B", "Bcc");
                    NotificationID = new PXNumberEdit("ctl00_phG_tab_t11_sp1_gridNR_en", "NotificationID", grid.Locator, "NotificationID");
                    NotificationID.DataField = "NotificationID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Active { get; }
				public DropDownColumnFilter ContactType { get; }
				public PXNumberEditColumnFilter OriginalContactID { get; }
				public SelectorColumnFilter ContactID { get; }
				public PXTextEditColumnFilter Email { get; }
				public DropDownColumnFilter Format { get; }
				public DropDownColumnFilter AddTo { get; }
				public PXNumberEditColumnFilter NotificationID { get; }
                
                public c_grid_header(c_notificationrecipients_gridnr grid) : 
                        base(grid)
                {
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    ContactType = new DropDownColumnFilter(grid.Row.ContactType);
                    OriginalContactID = new PXNumberEditColumnFilter(grid.Row.OriginalContactID);
                    ContactID = new SelectorColumnFilter(grid.Row.ContactID);
                    Email = new PXTextEditColumnFilter(grid.Row.Email);
                    Format = new DropDownColumnFilter(grid.Row.Format);
                    AddTo = new DropDownColumnFilter(grid.Row.AddTo);
                    NotificationID = new PXNumberEditColumnFilter(grid.Row.NotificationID);
                }
            }
        }
        
        public class c_notificationrecipients_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown ContactType { get; }
			public Label ContactTypeLabel { get; }
			public Selector ContactID { get; }
			public Label ContactIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_notificationrecipients_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ContactType = new DropDown("ctl00_phG_tab_t11_sp1_gridNR_lv0_edContactType", "Contact Type", locator, null);
                ContactTypeLabel = new Label(ContactType);
                ContactType.DataField = "ContactType";
                ContactType.Items.Add("P", "Primary");
                ContactType.Items.Add("R", "Remittance");
                ContactType.Items.Add("S", "Shipping");
                ContactType.Items.Add("E", "Employee");
                ContactType.Items.Add("C", "Contact");
                ContactID = new Selector("ctl00_phG_tab_t11_sp1_gridNR_lv0_edContactID", "Contact ID", locator, null);
                ContactIDLabel = new Label(ContactID);
                ContactID.DataField = "ContactID";
                Es = new Selector("ctl00_phG_tab_t11_sp1_gridNR_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t11_sp1_gridNR_lv0_ec", "Ec", locator, null);
                DataMemberName = "NotificationRecipients";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ContactIDEdit()
            {
                Buttons.ContactIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t11_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont" +
                            "\'] > div > div", "ContactIDEdit", "ctl00_phG_tab_t11_sp1_gridNR_lv0");
                    ContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_activities_activities_grid : Grid<c_activities_activities_grid.c_grid_row, c_activities_activities_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_activities_activities_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t8_gridActivities_Activities_grid");
                DataMemberName = "Activities";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t8_gridActivities_Activities_grid_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void CreateTask()
            {
                ToolBar.CreateTask.Click();
            }
            
            public virtual void CreateEvent()
            {
                ToolBar.CreateEvent.Click();
            }
            
            public virtual void CreateEmail()
            {
                ToolBar.CreateEmail.Click();
            }
            
            public virtual void CreateActivity()
            {
                ToolBar.CreateActivity.Click();
            }
            
            public virtual void NewActivityN()
            {
                ToolBar.NewActivityN.Click();
            }
            
            public virtual void NewActivityC()
            {
                ToolBar.NewActivityC.Click();
            }
            
            public virtual void NewActivityE()
            {
                ToolBar.NewActivityE.Click();
            }
            
            public virtual void NewActivityES()
            {
                ToolBar.NewActivityES.Click();
            }
            
            public virtual void NewActivityM()
            {
                ToolBar.NewActivityM.Click();
            }
            
            public virtual void NewActivityP()
            {
                ToolBar.NewActivityP.Click();
            }
            
            public virtual void NewActivityW()
            {
                ToolBar.NewActivityW.Click();
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
			public ToolBarButtonGrid CreateTask { get; }
			public ToolBarButtonGrid CreateEvent { get; }
			public ToolBarButtonGrid CreateEmail { get; }
			public ToolBarButtonGrid CreateActivity { get; }
			public ToolBarButtonGrid NewActivityN { get; }
			public ToolBarButtonGrid NewActivityC { get; }
			public ToolBarButtonGrid NewActivityE { get; }
			public ToolBarButtonGrid NewActivityES { get; }
			public ToolBarButtonGrid NewActivityM { get; }
			public ToolBarButtonGrid NewActivityP { get; }
			public ToolBarButtonGrid NewActivityW { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridActivities_Activities_grid_at_tlb div[data-cmd=\'Refresh" +
                            "\']", "Refresh", locator, null);
                    CreateTask = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridActivities_Activities_grid_at_tlb div[data-cmd=\'cmdAddT" +
                            "ask\']", "Create Task", locator, null);
                    CreateEvent = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridActivities_Activities_grid_at_tlb div[data-cmd=\'cmdAddE" +
                            "vent\']", "Create Event", locator, null);
                    CreateEmail = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridActivities_Activities_grid_at_tlb div[data-cmd=\'cmdAddE" +
                            "mail\']", "Create Email", locator, null);
                    CreateActivity = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridActivities_Activities_grid_at_tlb div[data-cmd=\'cmdAddA" +
                            "ctivity\']", "Create Activity", locator, null);
                    NewActivityN = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t8_gridActivities_Activities_grid_at_tlb_menucmdAddActivity" +
                            " li[data-cmd=\'NewActivity@NewActivityN\']", "Create Note", locator, CreateActivity);
                    NewActivityC = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t8_gridActivities_Activities_grid_at_tlb_menucmdAddActivity" +
                            " li[data-cmd=\'NewActivity@NewActivityC\']", "Create Chat", locator, CreateActivity);
                    NewActivityE = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t8_gridActivities_Activities_grid_at_tlb_menucmdAddActivity" +
                            " li[data-cmd=\'NewActivity@NewActivityE\']", "Create Appointment", locator, CreateActivity);
                    NewActivityES = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t8_gridActivities_Activities_grid_at_tlb_menucmdAddActivity" +
                            " li[data-cmd=\'NewActivity@NewActivityES\']", "Create Escalation", locator, CreateActivity);
                    NewActivityM = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t8_gridActivities_Activities_grid_at_tlb_menucmdAddActivity" +
                            " li[data-cmd=\'NewActivity@NewActivityM\']", "Create Message", locator, CreateActivity);
                    NewActivityP = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t8_gridActivities_Activities_grid_at_tlb_menucmdAddActivity" +
                            " li[data-cmd=\'NewActivity@NewActivityP\']", "Create Phone Call", locator, CreateActivity);
                    NewActivityW = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t8_gridActivities_Activities_grid_at_tlb_menucmdAddActivity" +
                            " li[data-cmd=\'NewActivity@NewActivityW\']", "Create Work Item", locator, CreateActivity);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridActivities_Activities_grid_at_tlb div[data-cmd=\'AdjustC" +
                            "olumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridActivities_Activities_grid_at_tlb div[data-cmd=\'ExportE" +
                            "xcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridActivities_Activities_grid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridActivities_Activities_grid_ab_tlb div[data-cmd=\'PageFir" +
                            "st\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridActivities_Activities_grid_ab_tlb div[data-cmd=\'PagePre" +
                            "v\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridActivities_Activities_grid_ab_tlb div[data-cmd=\'PageNex" +
                            "t\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridActivities_Activities_grid_ab_tlb div[data-cmd=\'PageLas" +
                            "t\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t8_gridActivities_Activities_grid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXTextEdit IsCompleteIcon { get; }
			public PXTextEdit PriorityIcon { get; }
			public PXTextEdit CRReminder__ReminderIcon { get; }
			public PXTextEdit ClassIcon { get; }
			public PXTextEdit ClassInfo { get; }
			public PXTextEdit RefNoteID { get; }
			public Selector Subject { get; }
			public DropDown UIStatus { get; }
			public CheckBox Released { get; }
			public DateSelector StartDate { get; }
			public DateSelector CreatedDateTime { get; }
			public DropDown TimeSpent { get; }
			public Selector CreatedByID { get; }
			public PXTextEdit CreatedByID_Creator_Username { get; }
			public Selector WorkgroupID { get; }
			public Selector OwnerID { get; }
			public Selector ProjectID { get; }
			public Selector ProjectTaskID { get; }
			public PXTextEdit Source { get; }
			public PXTextEdit NoteID { get; }
                
                public c_grid_row(c_activities_activities_grid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    IsCompleteIcon = new PXTextEdit("ctl00_phG_tab_t8_gridActivities_Activities_grid_ei", "Complete Icon", grid.Locator, "IsCompleteIcon");
                    IsCompleteIcon.DataField = "IsCompleteIcon";
                    PriorityIcon = new PXTextEdit("ctl00_phG_tab_t8_gridActivities_Activities_grid_ei", "Priority Icon", grid.Locator, "PriorityIcon");
                    PriorityIcon.DataField = "PriorityIcon";
                    CRReminder__ReminderIcon = new PXTextEdit("ctl00_phG_tab_t8_gridActivities_Activities_grid_ei", "Reminder Icon", grid.Locator, "CRReminder__ReminderIcon");
                    CRReminder__ReminderIcon.DataField = "CRReminder__ReminderIcon";
                    ClassIcon = new PXTextEdit("ctl00_phG_tab_t8_gridActivities_Activities_grid_ei", "Class Icon", grid.Locator, "ClassIcon");
                    ClassIcon.DataField = "ClassIcon";
                    ClassInfo = new PXTextEdit("ctl00_phG_tab_t8_gridActivities_Activities_grid_ei", "Type", grid.Locator, "ClassInfo");
                    ClassInfo.DataField = "ClassInfo";
                    RefNoteID = new PXTextEdit("ctl00_phG_tab_t8_gridActivities_Activities_grid_ei", "RefNoteID", grid.Locator, "RefNoteID");
                    RefNoteID.DataField = "RefNoteID";
                    Subject = new Selector("_ctl00_phG_tab_t8_gridActivities_Activities_grid_lv0_es", "Summary", grid.Locator, "Subject");
                    Subject.DataField = "Subject";
                    UIStatus = new DropDown("_ctl00_phG_tab_t8_gridActivities_Activities_grid_lv0_ec", "Status", grid.Locator, "UIStatus");
                    UIStatus.DataField = "UIStatus";
                    UIStatus.Items.Add("DR", "Draft");
                    UIStatus.Items.Add("OP", "Open");
                    UIStatus.Items.Add("IP", "Processing");
                    UIStatus.Items.Add("CD", "Completed");
                    UIStatus.Items.Add("AP", "Approved");
                    UIStatus.Items.Add("RJ", "Rejected");
                    UIStatus.Items.Add("CL", "Canceled");
                    UIStatus.Items.Add("PA", "Pending Approval");
                    UIStatus.Items.Add("RL", "Released");
                    Released = new CheckBox("ctl00_phG_tab_t8_gridActivities_Activities_grid", "Released", grid.Locator, "Released");
                    Released.DataField = "Released";
                    StartDate = new DateSelector("_ctl00_phG_tab_t8_gridActivities_Activities_grid_lv0_ed11", "Start Date", grid.Locator, "StartDate");
                    StartDate.DataField = "StartDate";
                    CreatedDateTime = new DateSelector("_ctl00_phG_tab_t8_gridActivities_Activities_grid_lv0_ed12", "Created At", grid.Locator, "CreatedDateTime");
                    CreatedDateTime.DataField = "CreatedDateTime";
                    TimeSpent = new DropDown("_ctl00_phG_tab_t8_gridActivities_Activities_grid_lv0_ec", "Time Spent", grid.Locator, "TimeSpent");
                    TimeSpent.DataField = "TimeSpent";
                    TimeSpent.Items.Add("0", "00:00");
                    TimeSpent.Items.Add("30", "00:30");
                    TimeSpent.Items.Add("60", "01:00");
                    TimeSpent.Items.Add("90", "01:30");
                    TimeSpent.Items.Add("120", "02:00");
                    TimeSpent.Items.Add("150", "02:30");
                    TimeSpent.Items.Add("180", "03:00");
                    TimeSpent.Items.Add("210", "03:30");
                    TimeSpent.Items.Add("240", "04:00");
                    TimeSpent.Items.Add("270", "04:30");
                    TimeSpent.Items.Add("300", "05:00");
                    TimeSpent.Items.Add("330", "05:30");
                    TimeSpent.Items.Add("360", "06:00");
                    TimeSpent.Items.Add("390", "06:30");
                    TimeSpent.Items.Add("420", "07:00");
                    TimeSpent.Items.Add("450", "07:30");
                    TimeSpent.Items.Add("480", "08:00");
                    TimeSpent.Items.Add("510", "08:30");
                    TimeSpent.Items.Add("540", "09:00");
                    TimeSpent.Items.Add("570", "09:30");
                    TimeSpent.Items.Add("600", "10:00");
                    TimeSpent.Items.Add("630", "10:30");
                    TimeSpent.Items.Add("660", "11:00");
                    TimeSpent.Items.Add("690", "11:30");
                    TimeSpent.Items.Add("720", "12:00");
                    TimeSpent.Items.Add("750", "12:30");
                    TimeSpent.Items.Add("780", "13:00");
                    TimeSpent.Items.Add("810", "13:30");
                    TimeSpent.Items.Add("840", "14:00");
                    TimeSpent.Items.Add("870", "14:30");
                    TimeSpent.Items.Add("900", "15:00");
                    TimeSpent.Items.Add("930", "15:30");
                    TimeSpent.Items.Add("960", "16:00");
                    TimeSpent.Items.Add("990", "16:30");
                    TimeSpent.Items.Add("1020", "17:00");
                    TimeSpent.Items.Add("1050", "17:30");
                    TimeSpent.Items.Add("1080", "18:00");
                    TimeSpent.Items.Add("1110", "18:30");
                    TimeSpent.Items.Add("1140", "19:00");
                    TimeSpent.Items.Add("1170", "19:30");
                    TimeSpent.Items.Add("1200", "20:00");
                    TimeSpent.Items.Add("1230", "20:30");
                    TimeSpent.Items.Add("1260", "21:00");
                    TimeSpent.Items.Add("1290", "21:30");
                    TimeSpent.Items.Add("1320", "22:00");
                    TimeSpent.Items.Add("1350", "22:30");
                    TimeSpent.Items.Add("1380", "23:00");
                    TimeSpent.Items.Add("1410", "23:30");
                    CreatedByID = new Selector("_ctl00_phG_tab_t8_gridActivities_Activities_grid_lv0_es", "CreatedByID", grid.Locator, "CreatedByID");
                    CreatedByID.DataField = "CreatedByID";
                    CreatedByID_Creator_Username = new PXTextEdit("ctl00_phG_tab_t8_gridActivities_Activities_grid_ei", "Created By", grid.Locator, "CreatedByID_Creator_Username");
                    CreatedByID_Creator_Username.DataField = "CreatedByID_Creator_Username";
                    WorkgroupID = new Selector("_ctl00_phG_tab_t8_gridActivities_Activities_grid_lv0_es", "Workgroup", grid.Locator, "WorkgroupID");
                    WorkgroupID.DataField = "WorkgroupID";
                    OwnerID = new Selector("_ctl00_phG_tab_t8_gridActivities_Activities_grid_lv0_es", "Owner", grid.Locator, "OwnerID");
                    OwnerID.DataField = "OwnerID";
                    ProjectID = new Selector("_ctl00_phG_tab_t8_gridActivities_Activities_grid_lv0_es", "Project", grid.Locator, "ProjectID");
                    ProjectID.DataField = "ProjectID";
                    ProjectTaskID = new Selector("_ctl00_phG_tab_t8_gridActivities_Activities_grid_lv0_es", "Project Task", grid.Locator, "ProjectTaskID");
                    ProjectTaskID.DataField = "ProjectTaskID";
                    Source = new PXTextEdit("ctl00_phG_tab_t8_gridActivities_Activities_grid_ei", "Related Entity Description", grid.Locator, "Source");
                    Source.DataField = "Source";
                    NoteID = new PXTextEdit("ctl00_phG_tab_t8_gridActivities_Activities_grid_ei", "NoteID", grid.Locator, "NoteID");
                    NoteID.DataField = "NoteID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXTextEditColumnFilter IsCompleteIcon { get; }
				public PXTextEditColumnFilter PriorityIcon { get; }
				public PXTextEditColumnFilter CRReminder__ReminderIcon { get; }
				public PXTextEditColumnFilter ClassIcon { get; }
				public PXTextEditColumnFilter ClassInfo { get; }
				public PXTextEditColumnFilter RefNoteID { get; }
				public SelectorColumnFilter Subject { get; }
				public DropDownColumnFilter UIStatus { get; }
				public CheckBoxColumnFilter Released { get; }
				public DateSelectorColumnFilter StartDate { get; }
				public DateSelectorColumnFilter CreatedDateTime { get; }
				public DropDownColumnFilter TimeSpent { get; }
				public SelectorColumnFilter CreatedByID { get; }
				public PXTextEditColumnFilter CreatedByID_Creator_Username { get; }
				public SelectorColumnFilter WorkgroupID { get; }
				public SelectorColumnFilter OwnerID { get; }
				public SelectorColumnFilter ProjectID { get; }
				public SelectorColumnFilter ProjectTaskID { get; }
				public PXTextEditColumnFilter Source { get; }
				public PXTextEditColumnFilter NoteID { get; }
                
                public c_grid_header(c_activities_activities_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    IsCompleteIcon = new PXTextEditColumnFilter(grid.Row.IsCompleteIcon);
                    PriorityIcon = new PXTextEditColumnFilter(grid.Row.PriorityIcon);
                    CRReminder__ReminderIcon = new PXTextEditColumnFilter(grid.Row.CRReminder__ReminderIcon);
                    ClassIcon = new PXTextEditColumnFilter(grid.Row.ClassIcon);
                    ClassInfo = new PXTextEditColumnFilter(grid.Row.ClassInfo);
                    RefNoteID = new PXTextEditColumnFilter(grid.Row.RefNoteID);
                    Subject = new SelectorColumnFilter(grid.Row.Subject);
                    UIStatus = new DropDownColumnFilter(grid.Row.UIStatus);
                    Released = new CheckBoxColumnFilter(grid.Row.Released);
                    StartDate = new DateSelectorColumnFilter(grid.Row.StartDate);
                    CreatedDateTime = new DateSelectorColumnFilter(grid.Row.CreatedDateTime);
                    TimeSpent = new DropDownColumnFilter(grid.Row.TimeSpent);
                    CreatedByID = new SelectorColumnFilter(grid.Row.CreatedByID);
                    CreatedByID_Creator_Username = new PXTextEditColumnFilter(grid.Row.CreatedByID_Creator_Username);
                    WorkgroupID = new SelectorColumnFilter(grid.Row.WorkgroupID);
                    OwnerID = new SelectorColumnFilter(grid.Row.OwnerID);
                    ProjectID = new SelectorColumnFilter(grid.Row.ProjectID);
                    ProjectTaskID = new SelectorColumnFilter(grid.Row.ProjectTaskID);
                    Source = new PXTextEditColumnFilter(grid.Row.Source);
                    NoteID = new PXTextEditColumnFilter(grid.Row.NoteID);
                }
            }
        }
        
        public class c_activities_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_activities_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t8_gridActivities_Activities_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t8_gridActivities_Activities_grid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t8_gridActivities_Activities_grid_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t8_gridActivities_Activities_grid_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Activities";
            }
        }
        
        public class c_activities_preview_activities_form : Container
        {
            
			public RichTextEdit Body { get; }
			public Label BodyLabel { get; }
            
            public c_activities_preview_activities_form(string locator, string name) : 
                    base(locator, name)
            {
                Body = new RichTextEdit("ctl00_phG_tab_t8_gridActivities_Activities_form_edBody", "Body", locator, null);
                BodyLabel = new Label(Body);
                Body.DataField = "body";
                DataMemberName = "Activities$Preview";
            }
        }
        
        public class c_answers_pxgridanswers : Grid<c_answers_pxgridanswers.c_grid_row, c_answers_pxgridanswers.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_answers_pxgridanswers(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t5_PXGridAnswers");
                DataMemberName = "Answers";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t5_PXGridAnswers_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridAnswers_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridAnswers_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridAnswers_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridAnswers_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridAnswers_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridAnswers_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridAnswers_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridAnswers_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_PXGridAnswers_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public Selector AttributeID { get; }
			public CheckBox IsRequired { get; }
			public PXTextEdit Value { get; }
			public PXTextEdit RefNoteID { get; }
                
                public c_grid_row(c_answers_pxgridanswers grid) : 
                        base(grid)
                {
                    AttributeID = new Selector("_ctl00_phG_tab_t5_PXGridAnswers_lv0_es", "Attribute", grid.Locator, "AttributeID");
                    AttributeID.DataField = "AttributeID";
                    IsRequired = new CheckBox("ctl00_phG_tab_t5_PXGridAnswers", "Required", grid.Locator, "isRequired");
                    IsRequired.DataField = "isRequired";
                    Value = new PXTextEdit("ctl00_phG_tab_t5_PXGridAnswers_ei", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                    RefNoteID = new PXTextEdit("ctl00_phG_tab_t5_PXGridAnswers_ei", "RefNoteID", grid.Locator, "RefNoteID");
                    RefNoteID.DataField = "RefNoteID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public SelectorColumnFilter AttributeID { get; }
				public CheckBoxColumnFilter IsRequired { get; }
				public PXTextEditColumnFilter Value { get; }
				public PXTextEditColumnFilter RefNoteID { get; }
                
                public c_grid_header(c_answers_pxgridanswers grid) : 
                        base(grid)
                {
                    AttributeID = new SelectorColumnFilter(grid.Row.AttributeID);
                    IsRequired = new CheckBoxColumnFilter(grid.Row.IsRequired);
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                    RefNoteID = new PXTextEditColumnFilter(grid.Row.RefNoteID);
                }
            }
        }
        
        public class c_answers_lv0 : Container
        {
            
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
                Es = new Selector("ctl00_phG_tab_t5_PXGridAnswers_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t5_PXGridAnswers_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t5_PXGridAnswers_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t5_PXGridAnswers_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Answers";
            }
        }
        
        public class c_suppliedbyvendors_pxgridsuppliedbyvendors : Grid<c_suppliedbyvendors_pxgridsuppliedbyvendors.c_grid_row, c_suppliedbyvendors_pxgridsuppliedbyvendors.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_suppliedbyvendors_pxgridsuppliedbyvendors(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t12_PXGridSuppliedByVendors");
                DataMemberName = "SuppliedByVendors";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t12_PXGridSuppliedByVendors_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_PXGridSuppliedByVendors_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_PXGridSuppliedByVendors_at_tlb div[data-cmd=\'AdjustColumns" +
                            "\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_PXGridSuppliedByVendors_at_tlb div[data-cmd=\'ExportExcel\']" +
                            "", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_PXGridSuppliedByVendors_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_PXGridSuppliedByVendors_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_PXGridSuppliedByVendors_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_PXGridSuppliedByVendors_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_PXGridSuppliedByVendors_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t12_PXGridSuppliedByVendors_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public Selector AcctCD { get; }
			public PXTextEdit AcctName { get; }
                
                public c_grid_row(c_suppliedbyvendors_pxgridsuppliedbyvendors grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    AcctCD = new Selector("_ctl00_phG_tab_t12_PXGridSuppliedByVendors_lv0_es", "Vendor", grid.Locator, "AcctCD");
                    AcctCD.DataField = "AcctCD";
                    AcctName = new PXTextEdit("ctl00_phG_tab_t12_PXGridSuppliedByVendors_ei", "Vendor Name", grid.Locator, "AcctName");
                    AcctName.DataField = "AcctName";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public SelectorColumnFilter AcctCD { get; }
				public PXTextEditColumnFilter AcctName { get; }
                
                public c_grid_header(c_suppliedbyvendors_pxgridsuppliedbyvendors grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    AcctCD = new SelectorColumnFilter(grid.Row.AcctCD);
                    AcctName = new PXTextEditColumnFilter(grid.Row.AcctName);
                }
            }
        }
        
        public class c_suppliedbyvendors_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_suppliedbyvendors_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t12_PXGridSuppliedByVendors_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "SuppliedByVendors";
            }
        }
        
        public class c_contactinfo_formcreatecontact : Container
        {
            
			public PXTextEdit FirstName { get; }
			public Label FirstNameLabel { get; }
			public PXTextEdit LastName { get; }
			public Label LastNameLabel { get; }
			public PXTextEdit FullName { get; }
			public Label FullNameLabel { get; }
			public PXTextEdit Salutation { get; }
			public Label SalutationLabel { get; }
			public DropDown Phone1Type { get; }
			public Label Phone1TypeLabel { get; }
			public PXTextEdit Phone1 { get; }
			public Label Phone1Label { get; }
			public DropDown Phone2Type { get; }
			public Label Phone2TypeLabel { get; }
			public PXTextEdit Phone2 { get; }
			public Label Phone2Label { get; }
			public PXTextEdit Email { get; }
			public Label EmailLabel { get; }
			public Selector ContactClass { get; }
			public Label ContactClassLabel { get; }
			public Label LblPhone1_ { get; }
			public Label LblPhone2_ { get; }
            
            public c_contactinfo_formcreatecontact(string locator, string name) : 
                    base(locator, name)
            {
                FirstName = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edFirstName", "First Name", locator, null);
                FirstNameLabel = new Label(FirstName);
                FirstName.DataField = "FirstName";
                LastName = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edLastName", "Last Name", locator, null);
                LastNameLabel = new Label(LastName);
                LastName.DataField = "LastName";
                FullName = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edFullName", "Full Name", locator, null);
                FullNameLabel = new Label(FullName);
                FullName.DataField = "FullName";
                Salutation = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edSalutation", "Salutation", locator, null);
                SalutationLabel = new Label(Salutation);
                Salutation.DataField = "Salutation";
                Phone1Type = new DropDown("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edPhone1Type", "Phone 1 Type", locator, null);
                Phone1TypeLabel = new Label(Phone1Type);
                Phone1Type.DataField = "Phone1Type";
                Phone1 = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edPhone1", "Phone 1", locator, null);
                Phone1Label = new Label(Phone1);
                Phone1.DataField = "Phone1";
                Phone2Type = new DropDown("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edPhone2Type", "Phone 2 Type", locator, null);
                Phone2TypeLabel = new Label(Phone2Type);
                Phone2Type.DataField = "Phone2Type";
                Phone2 = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edPhone2", "Phone 2", locator, null);
                Phone2Label = new Label(Phone2);
                Phone2.DataField = "Phone2";
                Email = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edEmail", "Email", locator, null);
                EmailLabel = new Label(Email);
                Email.DataField = "Email";
                ContactClass = new Selector("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_edContactClass" +
                        "", "Contact Class", locator, null);
                ContactClassLabel = new Label(ContactClass);
                ContactClass.DataField = "ContactClass";
                LblPhone1_ = new Label("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_lblPhone1", "Lbl Phone 1_", locator, null);
                LblPhone2_ = new Label("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_lblPhone2", "Lbl Phone 2_", locator, null);
                DataMemberName = "ContactInfo";
            }
        }
        
        public class c_contactinfo_tabcreatecontact : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Label LblPhone1_ { get; }
			public Label LblPhone2_ { get; }
            
            public c_contactinfo_tabcreatecontact(string locator, string name) : 
                    base(locator, name)
            {
                LblPhone1_ = new Label("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_lblPhone1", "Lbl Phone 1_", locator, null);
                LblPhone2_ = new Label("ctl00_phG_PanelCreateContact_tabCreateContact_t0_formCreateContact_lblPhone2", "Lbl Phone 2_", locator, null);
                DataMemberName = "ContactInfo";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Unnamed()
            {
                Buttons.Unnamed.Click();
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
            
            public virtual void Createandreview()
            {
                Buttons.Createandreview.Click();
            }
            
            public virtual void Create()
            {
                Buttons.Create.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Unnamed { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button First1 { get; }
			public Button Prev1 { get; }
			public Button Next1 { get; }
			public Button Last1 { get; }
			public Button Createandreview { get; }
			public Button Create { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Unnamed = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_oi", "", "ctl00_phG_PanelCreateContact_tabCreateContact");
                    First = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfFirst" +
                            "0", "First", "ctl00_phG_PanelCreateContact_tabCreateContact");
                    Prev = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfPrev0" +
                            "", "Prev", "ctl00_phG_PanelCreateContact_tabCreateContact");
                    Next = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfNext0" +
                            "", "Next", "ctl00_phG_PanelCreateContact_tabCreateContact");
                    Last = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfLast0" +
                            "", "Last", "ctl00_phG_PanelCreateContact_tabCreateContact");
                    First1 = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lfFirst0", "First", "ctl00_phG_PanelCreateContact_tabCreateContact");
                    Prev1 = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lfPrev0", "Prev", "ctl00_phG_PanelCreateContact_tabCreateContact");
                    Next1 = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lfNext0", "Next", "ctl00_phG_PanelCreateContact_tabCreateContact");
                    Last1 = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lfLast0", "Last", "ctl00_phG_PanelCreateContact_tabCreateContact");
                    Createandreview = new Button("ctl00_phG_PanelCreateContact_CreateContactBtnReview", "Create and review", "ctl00_phG_PanelCreateContact_tabCreateContact");
                    Create = new Button("ctl00_phG_PanelCreateContact_CreateContactBtnConvert", "Create", "ctl00_phG_PanelCreateContact_tabCreateContact");
                    Cancel = new Button("ctl00_phG_PanelCreateContact_CreateContactBtnCancel", "Cancel", "ctl00_phG_PanelCreateContact_tabCreateContact");
                }
            }
        }
        
        public class c_contactinfoattributes_grdcontactinfoattributes : Grid<c_contactinfoattributes_grdcontactinfoattributes.c_grid_row, c_contactinfoattributes_grdcontactinfoattributes.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_contactinfoattributes_grdcontactinfoattributes(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "ContactInfoAttributes";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_fe_gf", "FilterForm");
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
                    First = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfFirst" +
                            "0", "First", "ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes");
                    Prev = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfPrev0" +
                            "", "Prev", "ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes");
                    Next = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfNext0" +
                            "", "Next", "ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes");
                    Last = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfLast0" +
                            "", "Last", "ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit DisplayName { get; }
			public PXTextEdit Value { get; }
			public PXTextEdit Name { get; }
			public PXTextEdit CacheName { get; }
                
                public c_grid_row(c_contactinfoattributes_grdcontactinfoattributes grid) : 
                        base(grid)
                {
                    DisplayName = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_ei", "Name", grid.Locator, "DisplayName");
                    DisplayName.DataField = "DisplayName";
                    Value = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_ei", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                    Name = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_ei", "Name", grid.Locator, "Name");
                    Name.DataField = "Name";
                    CacheName = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_ei", "CacheName", grid.Locator, "CacheName");
                    CacheName.DataField = "CacheName";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter DisplayName { get; }
				public PXTextEditColumnFilter Value { get; }
				public PXTextEditColumnFilter Name { get; }
				public PXTextEditColumnFilter CacheName { get; }
                
                public c_grid_header(c_contactinfoattributes_grdcontactinfoattributes grid) : 
                        base(grid)
                {
                    DisplayName = new PXTextEditColumnFilter(grid.Row.DisplayName);
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                    Name = new PXTextEditColumnFilter(grid.Row.Name);
                    CacheName = new PXTextEditColumnFilter(grid.Row.CacheName);
                }
            }
        }
        
        public class c_contactinfoattributes_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_contactinfoattributes_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "ContactInfoAttributes";
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
                    First = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfFirst" +
                            "0", "First", "ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lv0");
                    Prev = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfPrev0" +
                            "", "Prev", "ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lv0");
                    Next = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfNext0" +
                            "", "Next", "ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lv0");
                    Last = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lfLast0" +
                            "", "Last", "ctl00_phG_PanelCreateContact_tabCreateContact_t1_grdContactInfoAttributes_lv0");
                }
            }
        }
        
        public class c_contactinfoudf_grdcontactinfoudf : Grid<c_contactinfoudf_grdcontactinfoudf.c_grid_row, c_contactinfoudf_grdcontactinfoudf.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_contactinfoudf_grdcontactinfoudf(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "ContactInfoUDF";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_fe_gf", "FilterForm");
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
                    First = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lfFirst0", "First", "ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF");
                    Prev = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lfPrev0", "Prev", "ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF");
                    Next = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lfNext0", "Next", "ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF");
                    Last = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lfLast0", "Last", "ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit DisplayName { get; }
			public PXTextEdit Value { get; }
			public PXTextEdit Name { get; }
			public PXTextEdit ScreenID { get; }
                
                public c_grid_row(c_contactinfoudf_grdcontactinfoudf grid) : 
                        base(grid)
                {
                    DisplayName = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_ei", "Name", grid.Locator, "DisplayName");
                    DisplayName.DataField = "DisplayName";
                    Value = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_ei", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                    Name = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_ei", "Name", grid.Locator, "Name");
                    Name.DataField = "Name";
                    ScreenID = new PXTextEdit("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_ei", "ScreenID", grid.Locator, "ScreenID");
                    ScreenID.DataField = "ScreenID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter DisplayName { get; }
				public PXTextEditColumnFilter Value { get; }
				public PXTextEditColumnFilter Name { get; }
				public PXTextEditColumnFilter ScreenID { get; }
                
                public c_grid_header(c_contactinfoudf_grdcontactinfoudf grid) : 
                        base(grid)
                {
                    DisplayName = new PXTextEditColumnFilter(grid.Row.DisplayName);
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                    Name = new PXTextEditColumnFilter(grid.Row.Name);
                    ScreenID = new PXTextEditColumnFilter(grid.Row.ScreenID);
                }
            }
        }
        
        public class c_contactinfoudf_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_contactinfoudf_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Ed = new DateSelector("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "ContactInfoUDF";
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
                    First = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lfFirst0", "First", "ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lv0");
                    Prev = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lfPrev0", "Prev", "ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lv0");
                    Next = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lfNext0", "Next", "ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lv0");
                    Last = new Button("ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lfLast0", "Last", "ctl00_phG_PanelCreateContact_tabCreateContact_t2_grdContactInfoUDF_lv0");
                }
            }
        }
        
        public class c_paymentdetails_grdpaymentdetails : Grid<c_paymentdetails_grdpaymentdetails.c_grid_row, c_paymentdetails_grdpaymentdetails.c_grid_header>
        {
            
            public PxButtonCollection Buttons;
            
            public c_paymentdetails_grdpaymentdetails(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "PaymentDetails";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
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
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t2_DefLocationPayment_RemitAddress_btnRemitAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails");
                    ViewonMap = new Button("ctl00_phG_tab_t2_DefLocationPayment_RemitAddress_btnViewRemitOnMap", "View on Map", "ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails");
                    First = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfFirst0", "First", "ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails");
                    Prev = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfPrev0", "Prev", "ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails");
                    Next = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfNext0", "Next", "ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails");
                    Last = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfLast0", "Last", "ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public InputLocalizable PaymentMethodDetail__descr { get; }
			public PXTextEdit DetailValue { get; }
			public PXNumberEdit BAccountID { get; }
			public PXNumberEdit LocationID { get; }
			public Selector PaymentMethodID { get; }
			public Selector DetailID { get; }
                
                public c_grid_row(c_paymentdetails_grdpaymentdetails grid) : 
                        base(grid)
                {
                    PaymentMethodDetail__descr = new InputLocalizable("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_ei", "Description", grid.Locator, "PaymentMethodDetail__descr");
                    PaymentMethodDetail__descr.DataField = "PaymentMethodDetail__descr";
                    DetailValue = new PXTextEdit("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_ei", "Value", grid.Locator, "DetailValue");
                    DetailValue.DataField = "DetailValue";
                    BAccountID = new PXNumberEdit("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_en", "BAccountID", grid.Locator, "BAccountID");
                    BAccountID.DataField = "BAccountID";
                    LocationID = new PXNumberEdit("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_en", "LocationID", grid.Locator, "LocationID");
                    LocationID.DataField = "LocationID";
                    PaymentMethodID = new Selector("_ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lv0_es", "Payment Method", grid.Locator, "PaymentMethodID");
                    PaymentMethodID.DataField = "PaymentMethodID";
                    DetailID = new Selector("_ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lv0_es", "ID", grid.Locator, "DetailID");
                    DetailID.DataField = "DetailID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter PaymentMethodDetail__descr { get; }
				public PXTextEditColumnFilter DetailValue { get; }
				public PXNumberEditColumnFilter BAccountID { get; }
				public PXNumberEditColumnFilter LocationID { get; }
				public SelectorColumnFilter PaymentMethodID { get; }
				public SelectorColumnFilter DetailID { get; }
                
                public c_grid_header(c_paymentdetails_grdpaymentdetails grid) : 
                        base(grid)
                {
                    PaymentMethodDetail__descr = new PXTextEditColumnFilter(grid.Row.PaymentMethodDetail__descr);
                    DetailValue = new PXTextEditColumnFilter(grid.Row.DetailValue);
                    BAccountID = new PXNumberEditColumnFilter(grid.Row.BAccountID);
                    LocationID = new PXNumberEditColumnFilter(grid.Row.LocationID);
                    PaymentMethodID = new SelectorColumnFilter(grid.Row.PaymentMethodID);
                    DetailID = new SelectorColumnFilter(grid.Row.DetailID);
                }
            }
        }
        
        public class c_paymentdetails_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_paymentdetails_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "PaymentDetails";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
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
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t2_DefLocationPayment_RemitAddress_btnRemitAddressLookup", "Address Lookup", "ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lv0");
                    ViewonMap = new Button("ctl00_phG_tab_t2_DefLocationPayment_RemitAddress_btnViewRemitOnMap", "View on Map", "ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lv0");
                    First = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfFirst0", "First", "ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lv0");
                    Prev = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfPrev0", "Prev", "ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lv0");
                    Next = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfNext0", "Next", "ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lv0");
                    Last = new Button("ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lfLast0", "Last", "ctl00_phG_tab_t2_DefLocationPayment_grdPaymentDetails_lv0");
                }
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
        
        public class c_currentvendor_tab : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AcctName { get; }
			public Label AcctNameLabel { get; }
			public Selector PrimaryContactID { get; }
			public Label PrimaryContactIDLabel { get; }
			public CheckBox LandedCostVendor { get; }
			public Label LandedCostVendorLabel { get; }
			public CheckBox TaxAgency { get; }
			public Label TaxAgencyLabel { get; }
			public CheckBox IsLaborUnion { get; }
			public Label IsLaborUnionLabel { get; }
			public CheckBox Vendor1099 { get; }
			public Label Vendor1099Label { get; }
			public CheckBox VendorT5018 { get; }
			public Label VendorT5018Label { get; }
			public DropDown BoxT5018 { get; }
			public Label BoxT5018Label { get; }
			public PXTextEdit SocialInsNum { get; }
			public Label SocialInsNumLabel { get; }
			public PXTextEdit BusinessNum { get; }
			public Label BusinessNumLabel { get; }
			public Selector Box1099 { get; }
			public Label Box1099Label { get; }
			public CheckBox ForeignEntity { get; }
			public Label ForeignEntityLabel { get; }
			public CheckBox FATCA { get; }
			public Label FATCALabel { get; }
			public CheckBox SDEnabled { get; }
			public Label SDEnabledLabel { get; }
			public Selector TermsID { get; }
			public Label TermsIDLabel { get; }
			public PXBranchSelector VOrgBAccountID { get; }
			public Label VOrgBAccountIDLabel { get; }
			public Selector CuryID { get; }
			public Label CuryIDLabel { get; }
			public CheckBox AllowOverrideCury { get; }
			public Label AllowOverrideCuryLabel { get; }
			public Selector CuryRateTypeID { get; }
			public Label CuryRateTypeIDLabel { get; }
			public CheckBox AllowOverrideRate { get; }
			public Label AllowOverrideRateLabel { get; }
			public CheckBox RetainageApply { get; }
			public Label RetainageApplyLabel { get; }
			public PXNumberEdit RetainagePct { get; }
			public Label RetainagePctLabel { get; }
			public CheckBox ShouldGenerateLienWaivers { get; }
			public Label ShouldGenerateLienWaiversLabel { get; }
			public Selector DiscTakenAcctID { get; }
			public Label DiscTakenAcctIDLabel { get; }
			public Selector DiscTakenSubID { get; }
			public Label DiscTakenSubIDLabel { get; }
			public Selector PrepaymentAcctID { get; }
			public Label PrepaymentAcctIDLabel { get; }
			public Selector PrepaymentSubID { get; }
			public Label PrepaymentSubIDLabel { get; }
			public Selector POAccrualAcctID { get; }
			public Label POAccrualAcctIDLabel { get; }
			public Selector POAccrualSubID { get; }
			public Label POAccrualSubIDLabel { get; }
			public Selector PrebookAcctID { get; }
			public Label PrebookAcctIDLabel { get; }
			public Selector PrebookSubID { get; }
			public Label PrebookSubIDLabel { get; }
			public Selector SalesTaxAcctID { get; }
			public Label SalesTaxAcctIDLabel { get; }
			public Selector SalesTaxSubID { get; }
			public Label SalesTaxSubIDLabel { get; }
			public Selector PurchTaxAcctID { get; }
			public Label PurchTaxAcctIDLabel { get; }
			public Selector PurchTaxSubID { get; }
			public Label PurchTaxSubIDLabel { get; }
			public Selector TaxExpenseAcctID { get; }
			public Label TaxExpenseAcctIDLabel { get; }
			public Selector TaxExpenseSubID { get; }
			public Label TaxExpenseSubIDLabel { get; }
			public DropDown SVATReversalMethod { get; }
			public Label SVATReversalMethodLabel { get; }
			public DropDown SVATInputTaxEntryRefNbr { get; }
			public Label SVATInputTaxEntryRefNbrLabel { get; }
			public DropDown SVATOutputTaxEntryRefNbr { get; }
			public Label SVATOutputTaxEntryRefNbrLabel { get; }
			public Selector SVATTaxInvoiceNumberingID { get; }
			public Label SVATTaxInvoiceNumberingIDLabel { get; }
			public DropDown TaxPeriodType { get; }
			public Label TaxPeriodTypeLabel { get; }
			public CheckBox TaxReportFinPeriod { get; }
			public Label TaxReportFinPeriodLabel { get; }
			public CheckBox UpdClosedTaxPeriods { get; }
			public Label UpdClosedTaxPeriodsLabel { get; }
			public CheckBox AutoGenerateTaxBill { get; }
			public Label AutoGenerateTaxBillLabel { get; }
			public DropDown TaxReportRounding { get; }
			public Label TaxReportRoundingLabel { get; }
			public PXNumberEdit TaxReportPrecision { get; }
			public Label TaxReportPrecisionLabel { get; }
			public CheckBox TaxUseVendorCurPrecision { get; }
			public Label TaxUseVendorCurPrecisionLabel { get; }
			public Label EdDefContactlblPhone1_ { get; }
			public Label EdDefContactlblPhone2_ { get; }
			public Label EdDefContactlblFax_ { get; }
			public Label LblDefContactAccountEmail_ { get; }
			public Label LblPrimaryContactName_ { get; }
			public Label LblPrmCntPhone1_ { get; }
			public Label LblPrmCntPhone2_ { get; }
			public Label LblPhone1_ { get; }
			public Label LblPhone2_ { get; }
			public Label LblFax_ { get; }
			public Label LblPhone1_2 { get; }
			public Label LblPhone2_2 { get; }
			public Label LblFax_2 { get; }
            
            public c_currentvendor_tab(string locator, string name) : 
                    base(locator, name)
            {
                AcctName = new PXTextEdit("ctl00_phG_tab_t0_edAcctName", "Account Name", locator, null);
                AcctNameLabel = new Label(AcctName);
                AcctName.DataField = "AcctName";
                PrimaryContactID = new Selector("ctl00_phG_tab_t0_edPrmCntID", "Name", locator, null);
                PrimaryContactIDLabel = new Label(PrimaryContactID);
                PrimaryContactID.DataField = "PrimaryContactID";
                LandedCostVendor = new CheckBox("ctl00_phG_tab_t0_chkLandedCostVendor", "Landed Cost Vendor", locator, null);
                LandedCostVendorLabel = new Label(LandedCostVendor);
                LandedCostVendor.DataField = "LandedCostVendor";
                TaxAgency = new CheckBox("ctl00_phG_tab_t0_chkTaxAgency", "Vendor is Tax Agency", locator, null);
                TaxAgencyLabel = new Label(TaxAgency);
                TaxAgency.DataField = "TaxAgency";
                IsLaborUnion = new CheckBox("ctl00_phG_tab_t0_chkLaborUnion", "Vendor is Labor Union", locator, null);
                IsLaborUnionLabel = new Label(IsLaborUnion);
                IsLaborUnion.DataField = "IsLaborUnion";
                Vendor1099 = new CheckBox("ctl00_phG_tab_t0_chkVendor1099", "1099 Vendor", locator, null);
                Vendor1099Label = new Label(Vendor1099);
                Vendor1099.DataField = "Vendor1099";
                VendorT5018 = new CheckBox("ctl00_phG_tab_t0_chkBoxT5018", "T5018 Vendor", locator, null);
                VendorT5018Label = new Label(VendorT5018);
                VendorT5018.DataField = "VendorT5018";
                BoxT5018 = new DropDown("ctl00_phG_tab_t0_edBoxT5018", "T5018 Box", locator, null);
                BoxT5018Label = new Label(BoxT5018);
                BoxT5018.DataField = "BoxT5018";
                SocialInsNum = new PXTextEdit("ctl00_phG_tab_t0_edSIN", "SIN", locator, null);
                SocialInsNumLabel = new Label(SocialInsNum);
                SocialInsNum.DataField = "SocialInsNum";
                BusinessNum = new PXTextEdit("ctl00_phG_tab_t0_edBusinessNum", "Program Account Number", locator, null);
                BusinessNumLabel = new Label(BusinessNum);
                BusinessNum.DataField = "BusinessNum";
                Box1099 = new Selector("ctl00_phG_tab_t0_edBox1099", "1099 Box", locator, null);
                Box1099Label = new Label(Box1099);
                Box1099.DataField = "Box1099";
                ForeignEntity = new CheckBox("ctl00_phG_tab_t0_edForeignEntity", "Foreign Entity", locator, null);
                ForeignEntityLabel = new Label(ForeignEntity);
                ForeignEntity.DataField = "ForeignEntity";
                FATCA = new CheckBox("ctl00_phG_tab_t0_chkFATCA", "FATCA", locator, null);
                FATCALabel = new Label(FATCA);
                FATCA.DataField = "FATCA";
                SDEnabled = new CheckBox("ctl00_phG_tab_t0_edSDEnabled", "Staff Member in Service Management", locator, null);
                SDEnabledLabel = new Label(SDEnabled);
                SDEnabled.DataField = "SDEnabled";
                TermsID = new Selector("ctl00_phG_tab_t1_edTermsID", "Terms", locator, null);
                TermsIDLabel = new Label(TermsID);
                TermsID.DataField = "TermsID";
                VOrgBAccountID = new PXBranchSelector("ctl00_phG_tab_t1_edVOrgBAccountID", "Restrict Visibility To", locator, null);
                VOrgBAccountIDLabel = new Label(VOrgBAccountID);
                VOrgBAccountID.DataField = "VOrgBAccountID";
                CuryID = new Selector("ctl00_phG_tab_t1_edCuryID", "Currency ID", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                AllowOverrideCury = new CheckBox("ctl00_phG_tab_t1_chkAllowOverrideCury", "Enable Currency Override", locator, null);
                AllowOverrideCuryLabel = new Label(AllowOverrideCury);
                AllowOverrideCury.DataField = "AllowOverrideCury";
                CuryRateTypeID = new Selector("ctl00_phG_tab_t1_edCuryRateTypeID", "Curr. Rate Type", locator, null);
                CuryRateTypeIDLabel = new Label(CuryRateTypeID);
                CuryRateTypeID.DataField = "CuryRateTypeID";
                AllowOverrideRate = new CheckBox("ctl00_phG_tab_t1_chkAllowOverrideRate", "Enable Rate Override", locator, null);
                AllowOverrideRateLabel = new Label(AllowOverrideRate);
                AllowOverrideRate.DataField = "AllowOverrideRate";
                RetainageApply = new CheckBox("ctl00_phG_tab_t1_edRetainageApply", "Apply Retainage", locator, null);
                RetainageApplyLabel = new Label(RetainageApply);
                RetainageApply.DataField = "RetainageApply";
                RetainagePct = new PXNumberEdit("ctl00_phG_tab_t1_edRetainagePct", "Retainage Percent", locator, null);
                RetainagePctLabel = new Label(RetainagePct);
                RetainagePct.DataField = "RetainagePct";
                ShouldGenerateLienWaivers = new CheckBox("ctl00_phG_tab_t1_chkShouldGenerateLienWaivers", "Generate Lien Waivers based on Project settings", locator, null);
                ShouldGenerateLienWaiversLabel = new Label(ShouldGenerateLienWaivers);
                ShouldGenerateLienWaivers.DataField = "ShouldGenerateLienWaivers";
                DiscTakenAcctID = new Selector("ctl00_phG_tab_t9_edDiscTakenAcctID", "Cash Discount Account", locator, null);
                DiscTakenAcctIDLabel = new Label(DiscTakenAcctID);
                DiscTakenAcctID.DataField = "DiscTakenAcctID";
                DiscTakenSubID = new Selector("ctl00_phG_tab_t9_edDiscTakenSubID", "Cash Discount Sub.", locator, null);
                DiscTakenSubIDLabel = new Label(DiscTakenSubID);
                DiscTakenSubID.DataField = "DiscTakenSubID";
                PrepaymentAcctID = new Selector("ctl00_phG_tab_t9_edPrepaymentAcctID", "Prepayment Account", locator, null);
                PrepaymentAcctIDLabel = new Label(PrepaymentAcctID);
                PrepaymentAcctID.DataField = "PrepaymentAcctID";
                PrepaymentSubID = new Selector("ctl00_phG_tab_t9_edPrepaymentSubID", "Prepayment Sub.", locator, null);
                PrepaymentSubIDLabel = new Label(PrepaymentSubID);
                PrepaymentSubID.DataField = "PrepaymentSubID";
                POAccrualAcctID = new Selector("ctl00_phG_tab_t9_edPOAccrualAcctID", "PO Accrual Account", locator, null);
                POAccrualAcctIDLabel = new Label(POAccrualAcctID);
                POAccrualAcctID.DataField = "POAccrualAcctID";
                POAccrualSubID = new Selector("ctl00_phG_tab_t9_edPOAccrualSubID", "PO Accrual Sub.", locator, null);
                POAccrualSubIDLabel = new Label(POAccrualSubID);
                POAccrualSubID.DataField = "POAccrualSubID";
                PrebookAcctID = new Selector("ctl00_phG_tab_t9_edPrebookAcctID", "Reclassification Account", locator, null);
                PrebookAcctIDLabel = new Label(PrebookAcctID);
                PrebookAcctID.DataField = "PrebookAcctID";
                PrebookSubID = new Selector("ctl00_phG_tab_t9_edPrebookSubID", "Reclassification Subaccount", locator, null);
                PrebookSubIDLabel = new Label(PrebookSubID);
                PrebookSubID.DataField = "PrebookSubID";
                SalesTaxAcctID = new Selector("ctl00_phG_tab_t10_edSalesTaxAcctID", "Tax Payable Account", locator, null);
                SalesTaxAcctIDLabel = new Label(SalesTaxAcctID);
                SalesTaxAcctID.DataField = "SalesTaxAcctID";
                SalesTaxSubID = new Selector("ctl00_phG_tab_t10_edSalesTaxSubID", "Tax Payable Sub.", locator, null);
                SalesTaxSubIDLabel = new Label(SalesTaxSubID);
                SalesTaxSubID.DataField = "SalesTaxSubID";
                PurchTaxAcctID = new Selector("ctl00_phG_tab_t10_edPurchTaxAcctID", "Tax Claimable Account", locator, null);
                PurchTaxAcctIDLabel = new Label(PurchTaxAcctID);
                PurchTaxAcctID.DataField = "PurchTaxAcctID";
                PurchTaxSubID = new Selector("ctl00_phG_tab_t10_edPurchTaxSubID", "Tax Claimable Sub.", locator, null);
                PurchTaxSubIDLabel = new Label(PurchTaxSubID);
                PurchTaxSubID.DataField = "PurchTaxSubID";
                TaxExpenseAcctID = new Selector("ctl00_phG_tab_t10_edTaxExpenseAcctID", "Tax Expense Account", locator, null);
                TaxExpenseAcctIDLabel = new Label(TaxExpenseAcctID);
                TaxExpenseAcctID.DataField = "TaxExpenseAcctID";
                TaxExpenseSubID = new Selector("ctl00_phG_tab_t10_edTaxExpenseSubID", "Tax Expense Sub.", locator, null);
                TaxExpenseSubIDLabel = new Label(TaxExpenseSubID);
                TaxExpenseSubID.DataField = "TaxExpenseSubID";
                SVATReversalMethod = new DropDown("ctl00_phG_tab_t10_edSVATReversalMethod", "VAT Recognition Method", locator, null);
                SVATReversalMethodLabel = new Label(SVATReversalMethod);
                SVATReversalMethod.DataField = "SVATReversalMethod";
                SVATReversalMethod.Items.Add("P", "On Payments");
                SVATReversalMethod.Items.Add("D", "On Documents");
                SVATInputTaxEntryRefNbr = new DropDown("ctl00_phG_tab_t10_edSVATInputTaxEntryRefNbr", "Input Tax Entry Ref. Nbr.", locator, null);
                SVATInputTaxEntryRefNbrLabel = new Label(SVATInputTaxEntryRefNbr);
                SVATInputTaxEntryRefNbr.DataField = "SVATInputTaxEntryRefNbr";
                SVATInputTaxEntryRefNbr.Items.Add("D", "Document Ref. Nbr.");
                SVATInputTaxEntryRefNbr.Items.Add("P", "Payment Ref. Nbr.");
                SVATInputTaxEntryRefNbr.Items.Add("M", "Manually Entered");
                SVATOutputTaxEntryRefNbr = new DropDown("ctl00_phG_tab_t10_edSVATOutputTaxEntryRefNbr", "Output Tax Entry Ref. Nbr.", locator, null);
                SVATOutputTaxEntryRefNbrLabel = new Label(SVATOutputTaxEntryRefNbr);
                SVATOutputTaxEntryRefNbr.DataField = "SVATOutputTaxEntryRefNbr";
                SVATOutputTaxEntryRefNbr.Items.Add("D", "Document Ref. Nbr.");
                SVATOutputTaxEntryRefNbr.Items.Add("P", "Payment Ref. Nbr.");
                SVATOutputTaxEntryRefNbr.Items.Add("T", "Tax Invoice Nbr.");
                SVATOutputTaxEntryRefNbr.Items.Add("M", "Manually Entered");
                SVATTaxInvoiceNumberingID = new Selector("ctl00_phG_tab_t10_edSVATTaxInvoiceNumberingID", "Tax Invoice Numbering", locator, null);
                SVATTaxInvoiceNumberingIDLabel = new Label(SVATTaxInvoiceNumberingID);
                SVATTaxInvoiceNumberingID.DataField = "SVATTaxInvoiceNumberingID";
                TaxPeriodType = new DropDown("ctl00_phG_tab_t10_edTaxPeriodType", "Default Tax Period Type", locator, null);
                TaxPeriodTypeLabel = new Label(TaxPeriodType);
                TaxPeriodType.DataField = "TaxPeriodType";
                TaxPeriodType.Items.Add("B", "Half a Month");
                TaxPeriodType.Items.Add("M", "Month");
                TaxPeriodType.Items.Add("E", "Two Months");
                TaxPeriodType.Items.Add("Q", "Quarter");
                TaxPeriodType.Items.Add("H", "Half a Year");
                TaxPeriodType.Items.Add("Y", "Year");
                TaxPeriodType.Items.Add("F", "Financial Period");
                TaxReportFinPeriod = new CheckBox("ctl00_phG_tab_t10_chktaxReportFinPeriod", "Define Tax Period by End Date of Financial Period", locator, null);
                TaxReportFinPeriodLabel = new Label(TaxReportFinPeriod);
                TaxReportFinPeriod.DataField = "TaxReportFinPeriod";
                UpdClosedTaxPeriods = new CheckBox("ctl00_phG_tab_t10_chkUpdClosedTaxPeriods", "Update Closed Tax Periods", locator, null);
                UpdClosedTaxPeriodsLabel = new Label(UpdClosedTaxPeriods);
                UpdClosedTaxPeriods.DataField = "UpdClosedTaxPeriods";
                AutoGenerateTaxBill = new CheckBox("ctl00_phG_tab_t10_chkAutoGenerateTaxBill", "Automatically Generate Tax Bill", locator, null);
                AutoGenerateTaxBillLabel = new Label(AutoGenerateTaxBill);
                AutoGenerateTaxBill.DataField = "AutoGenerateTaxBill";
                TaxReportRounding = new DropDown("ctl00_phG_tab_t10_edTaxReportRounding", "Tax Report Rounding", locator, null);
                TaxReportRoundingLabel = new Label(TaxReportRounding);
                TaxReportRounding.DataField = "TaxReportRounding";
                TaxReportRounding.Items.Add("R", "Mathematical");
                TaxReportRounding.Items.Add("C", "Ceiling");
                TaxReportRounding.Items.Add("F", "Floor");
                TaxReportPrecision = new PXNumberEdit("ctl00_phG_tab_t10_edTaxReportPrecision", "Tax Report Precision", locator, null);
                TaxReportPrecisionLabel = new Label(TaxReportPrecision);
                TaxReportPrecision.DataField = "TaxReportPrecision";
                TaxUseVendorCurPrecision = new CheckBox("ctl00_phG_tab_t10_chkTaxUseVendorCurPrecision", "Use Currency Precision", locator, null);
                TaxUseVendorCurPrecisionLabel = new Label(TaxUseVendorCurPrecision);
                TaxUseVendorCurPrecision.DataField = "TaxUseVendorCurPrecision";
                EdDefContactlblPhone1_ = new Label("ctl00_phG_tab_t0_DefContact1_edDefContactlblPhone1", "Ed Def Contactlbl Phone 1_", locator, null);
                EdDefContactlblPhone2_ = new Label("ctl00_phG_tab_t0_DefContact1_edDefContactlblPhone2", "Ed Def Contactlbl Phone 2_", locator, null);
                EdDefContactlblFax_ = new Label("ctl00_phG_tab_t0_DefContact1_edDefContactlblFax", "Ed Def Contactlbl Fax _", locator, null);
                LblDefContactAccountEmail_ = new Label("ctl00_phG_tab_t0_DefContact1_lblDefContactAccountEmail", "Account Email:", locator, null);
                LblPrimaryContactName_ = new Label("ctl00_phG_tab_t0_frmPrimaryContact_lblPrimaryContactName", "Name:", locator, null);
                LblPrmCntPhone1_ = new Label("ctl00_phG_tab_t0_frmPrimaryContact_lblPrmCntPhone1", "Lbl Prm Cnt Phone 1_", locator, null);
                LblPrmCntPhone2_ = new Label("ctl00_phG_tab_t0_frmPrimaryContact_lblPrmCntPhone2", "Lbl Prm Cnt Phone 2_", locator, null);
                LblPhone1_ = new Label("ctl00_phG_tab_t2_DefLocationPayment_RemitContact_lblPhone1", "Lbl Phone 1_", locator, null);
                LblPhone2_ = new Label("ctl00_phG_tab_t2_DefLocationPayment_RemitContact_lblPhone2", "Lbl Phone 2_", locator, null);
                LblFax_ = new Label("ctl00_phG_tab_t2_DefLocationPayment_RemitContact_lblFax", "Lbl Fax _", locator, null);
                LblPhone1_2 = new Label("ctl00_phG_tab_t3_DefLocation_DefLocationContact_lblPhone1", "Lbl Phone 1_2", locator, null);
                LblPhone2_2 = new Label("ctl00_phG_tab_t3_DefLocation_DefLocationContact_lblPhone2", "Lbl Phone 2_2", locator, null);
                LblFax_2 = new Label("ctl00_phG_tab_t3_DefLocation_DefLocationContact_lblFax", "Lbl Fax _2", locator, null);
                DataMemberName = "CurrentVendor";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void PrimaryContactIDEdit()
            {
                Buttons.PrimaryContactIDEdit.Click();
            }
            
            public virtual void TermsIDEdit()
            {
                Buttons.TermsIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button PrimaryContactIDEdit { get; }
			public Button TermsIDEdit { get; }
                
                public PxButtonCollection()
                {
                    PrimaryContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPrmCntID\'] div[class=\'editBtnCont\'] > div > div", "PrimaryContactIDEdit", "ctl00_phG_tab");
                    PrimaryContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    TermsIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_edTermsID\'] div[class=\'editBtnCont\'] > div > div", "TermsIDEdit", "ctl00_phG_tab");
                    TermsIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_currentvendor_currentvendor2 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AcctReferenceNbr { get; }
			public Label AcctReferenceNbrLabel { get; }
			public Selector ParentBAccountID { get; }
			public Label ParentBAccountIDLabel { get; }
			public Selector LocaleName { get; }
			public Label LocaleNameLabel { get; }
            
            public c_currentvendor_currentvendor2(string locator, string name) : 
                    base(locator, name)
            {
                AcctReferenceNbr = new PXTextEdit("ctl00_phG_tab_t0_CurrentVendor2_edAcctReferenceNbr", "Ext Ref Nbr", locator, null);
                AcctReferenceNbrLabel = new Label(AcctReferenceNbr);
                AcctReferenceNbr.DataField = "AcctReferenceNbr";
                ParentBAccountID = new Selector("ctl00_phG_tab_t0_CurrentVendor2_edParentBAccountID", "Parent Account", locator, null);
                ParentBAccountIDLabel = new Label(ParentBAccountID);
                ParentBAccountID.DataField = "ParentBAccountID";
                LocaleName = new Selector("ctl00_phG_tab_t0_CurrentVendor2_edLocaleName", "Locale", locator, null);
                LocaleNameLabel = new Label(LocaleName);
                LocaleName.DataField = "LocaleName";
                DataMemberName = "CurrentVendor";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void PrimaryContactIDEdit()
            {
                Buttons.PrimaryContactIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button PrimaryContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t0_DefAddress_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t0_CurrentVendor2");
                    ViewonMap = new Button("ctl00_phG_tab_t0_DefAddress_btnViewMainOnMap", "View on Map", "ctl00_phG_tab_t0_CurrentVendor2");
                    PrimaryContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPrmCntID\'] div[class=\'editBtnCont\'] > div > div", "PrimaryContactIDEdit", "ctl00_phG_tab_t0_CurrentVendor2");
                    PrimaryContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_currentvendor_vendordefaults : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector VendorDefaultCostCodeId { get; }
			public Label VendorDefaultCostCodeIdLabel { get; }
			public Selector VendorDefaultInventoryId { get; }
			public Label VendorDefaultInventoryIdLabel { get; }
            
            public c_currentvendor_vendordefaults(string locator, string name) : 
                    base(locator, name)
            {
                VendorDefaultCostCodeId = new Selector("ctl00_phG_tab_t0_VendorDefaults_edVendorDefaultCostCodeId", "Cost Code", locator, null);
                VendorDefaultCostCodeIdLabel = new Label(VendorDefaultCostCodeId);
                VendorDefaultCostCodeId.DataField = "VendorDefaultCostCodeId";
                VendorDefaultInventoryId = new Selector("ctl00_phG_tab_t0_VendorDefaults_edVendorDefaultInventoryId", "Inventory ID", locator, null);
                VendorDefaultInventoryIdLabel = new Label(VendorDefaultInventoryId);
                VendorDefaultInventoryId.DataField = "VendorDefaultInventoryId";
                DataMemberName = "CurrentVendor";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AddressLookup()
            {
                Buttons.AddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void PrimaryContactIDEdit()
            {
                Buttons.PrimaryContactIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddressLookup { get; }
			public Button ViewonMap { get; }
			public Button PrimaryContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    AddressLookup = new Button("ctl00_phG_tab_t0_DefAddress_btnAddressLookup", "Address Lookup", "ctl00_phG_tab_t0_VendorDefaults");
                    ViewonMap = new Button("ctl00_phG_tab_t0_DefAddress_btnViewMainOnMap", "View on Map", "ctl00_phG_tab_t0_VendorDefaults");
                    PrimaryContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPrmCntID\'] div[class=\'editBtnCont\'] > div > div", "PrimaryContactIDEdit", "ctl00_phG_tab_t0_VendorDefaults");
                    PrimaryContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_currentvendor_pxformview1 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown TinType { get; }
			public Label TinTypeLabel { get; }
            
            public c_currentvendor_pxformview1(string locator, string name) : 
                    base(locator, name)
            {
                TinType = new DropDown("ctl00_phG_tab_t3_DefLocation_PXFormView1_edTinType", "Type of TIN", locator, null);
                TinTypeLabel = new Label(TinType);
                TinType.DataField = "TinType";
                TinType.Items.Add("E", "EIN");
                TinType.Items.Add("S", "SSN");
                TinType.Items.Add("I", "ITIN");
                TinType.Items.Add("A", "ATIN");
                DataMemberName = "CurrentVendor";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void BtnDefLocationAddressLookup()
            {
                Buttons.BtnDefLocationAddressLookup.Click();
            }
            
            public virtual void ViewonMap()
            {
                Buttons.ViewonMap.Click();
            }
            
            public virtual void VBranchIDEdit()
            {
                Buttons.VBranchIDEdit.Click();
            }
            
            public virtual void VTaxZoneIDEdit()
            {
                Buttons.VTaxZoneIDEdit.Click();
            }
            
            public virtual void VCarrierIDEdit()
            {
                Buttons.VCarrierIDEdit.Click();
            }
            
            public virtual void VShipTermsIDEdit()
            {
                Buttons.VShipTermsIDEdit.Click();
            }
            
            public virtual void VFOBPointIDEdit()
            {
                Buttons.VFOBPointIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button BtnDefLocationAddressLookup { get; }
			public Button ViewonMap { get; }
			public Button VBranchIDEdit { get; }
			public Button VTaxZoneIDEdit { get; }
			public Button VCarrierIDEdit { get; }
			public Button VShipTermsIDEdit { get; }
			public Button VFOBPointIDEdit { get; }
                
                public PxButtonCollection()
                {
                    BtnDefLocationAddressLookup = new Button("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_btnDefLocationAddressLookup", "btnDefLocationAddressLookup", "ctl00_phG_tab_t3_DefLocation_PXFormView1");
                    ViewonMap = new Button("ctl00_phG_tab_t3_DefLocation_DefLocationAddress_btnViewDefLocationAddressOnMap", "View on Map", "ctl00_phG_tab_t3_DefLocation_PXFormView1");
                    VBranchIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edVBranchID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "VBranchIDEdit", "ctl00_phG_tab_t3_DefLocation_PXFormView1");
                    VBranchIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    VTaxZoneIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edTaxZoneID\'] div[class=\'editBtnCont\'] >" +
                            " div > div", "VTaxZoneIDEdit", "ctl00_phG_tab_t3_DefLocation_PXFormView1");
                    VTaxZoneIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    VCarrierIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edVCarrierID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "VCarrierIDEdit", "ctl00_phG_tab_t3_DefLocation_PXFormView1");
                    VCarrierIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    VShipTermsIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edShipTermsID\'] div[class=\'editBtnCont\']" +
                            " > div > div", "VShipTermsIDEdit", "ctl00_phG_tab_t3_DefLocation_PXFormView1");
                    VShipTermsIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    VFOBPointIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_DefLocation_edFOBPointID\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "VFOBPointIDEdit", "ctl00_phG_tab_t3_DefLocation_PXFormView1");
                    VFOBPointIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
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
                CD = new Selector("ctl00_phF_pnlChangeID_formChangeID_edAcctCD", "Vendor ID", locator, null);
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
        
        public class c_compliancedocuments_grdcompliancedocuments : Grid<c_compliancedocuments_grdcompliancedocuments.c_grid_row, c_compliancedocuments_grdcompliancedocuments.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_compliancedocuments_grdcompliancedocuments(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t13_grdComplianceDocuments");
                DataMemberName = "ComplianceDocuments";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t13_grdComplianceDocuments_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grdComplianceDocuments_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grdComplianceDocuments_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grdComplianceDocuments_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grdComplianceDocuments_at_tlb div[data-cmd=\'AdjustColumns\'" +
                            "]", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grdComplianceDocuments_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grdComplianceDocuments_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grdComplianceDocuments_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grdComplianceDocuments_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grdComplianceDocuments_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grdComplianceDocuments_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t13_grdComplianceDocuments_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit ExpirationDate { get; }
			public PXTextEdit DocumentType { get; }
			public PXTextEdit CreationDate { get; }
			public PXTextEdit Status { get; }
			public CheckBox Required { get; }
			public CheckBox Received { get; }
			public PXTextEdit ReceivedDate { get; }
			public CheckBox IsProcessed { get; }
			public CheckBox IsVoided { get; }
			public CheckBox IsCreatedAutomatically { get; }
			public PXTextEdit SentDate { get; }
			public Selector ProjectID { get; }
			public Selector CostTaskID { get; }
			public Selector RevenueTaskID { get; }
			public Selector CostCodeID { get; }
			public PXTextEdit VendorID { get; }
			public PXTextEdit VendorName { get; }
			public Selector BillID { get; }
			public PXTextEdit BillAmount { get; }
			public PXTextEdit AccountID { get; }
			public Selector ApCheckID { get; }
			public PXTextEdit CheckNumber { get; }
			public Selector ArPaymentID { get; }
			public PXTextEdit CertificateNumber { get; }
			public PXTextEdit CreatedByID { get; }
			public PXTextEdit CustomerID { get; }
			public PXTextEdit CustomerName { get; }
			public PXTextEdit DateIssued { get; }
			public PXTextEdit EffectiveDate { get; }
			public PXTextEdit InsuranceCompany { get; }
			public PXTextEdit InvoiceAmount { get; }
			public Selector InvoiceID { get; }
			public CheckBox IsExpired { get; }
			public CheckBox IsRequiredJointCheck { get; }
			public PXTextEdit JointAmount { get; }
			public PXTextEdit JointRelease { get; }
			public CheckBox JointReleaseReceived { get; }
			public PXTextEdit JointVendorInternalId { get; }
			public PXTextEdit JointVendorExternalName { get; }
			public PXTextEdit LastModifiedByID { get; }
			public PXTextEdit LienWaiverAmount { get; }
			public PXTextEdit Limit { get; }
			public PXTextEdit MethodSent { get; }
			public PXTextEdit PaymentDate { get; }
			public PXTextEdit ArPaymentMethodID { get; }
			public PXTextEdit ApPaymentMethodID { get; }
			public PXTextEdit Policy { get; }
			public Selector ProjectTransactionID { get; }
			public Selector PurchaseOrder { get; }
			public Selector PurchaseOrderLineItem { get; }
			public Selector Subcontract { get; }
			public Selector SubcontractLineItem { get; }
			public Selector ChangeOrderNumber { get; }
			public PXTextEdit ReceiptDate { get; }
			public PXTextEdit ReceiveDate { get; }
			public PXTextEdit ReceivedBy { get; }
			public PXTextEdit SecondaryVendorID { get; }
			public PXTextEdit SecondaryVendorName { get; }
			public PXTextEdit SourceType { get; }
			public PXTextEdit SponsorOrganization { get; }
			public PXTextEdit ThroughDate { get; }
			public Selector DocumentTypeValue { get; }
                
                public c_grid_row(c_compliancedocuments_grdcompliancedocuments grid) : 
                        base(grid)
                {
                    ExpirationDate = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Expiration Date", grid.Locator, "ExpirationDate");
                    ExpirationDate.DataField = "ExpirationDate";
                    DocumentType = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Document Type", grid.Locator, "DocumentType");
                    DocumentType.DataField = "DocumentType";
                    CreationDate = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Creation Date", grid.Locator, "CreationDate");
                    CreationDate.DataField = "CreationDate";
                    Status = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Required = new CheckBox("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Required", grid.Locator, "Required");
                    Required.DataField = "Required";
                    Received = new CheckBox("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Received", grid.Locator, "Received");
                    Received.DataField = "Received";
                    ReceivedDate = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Received Date", grid.Locator, "ReceivedDate");
                    ReceivedDate.DataField = "ReceivedDate";
                    IsProcessed = new CheckBox("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Is Processed", grid.Locator, "IsProcessed");
                    IsProcessed.DataField = "IsProcessed";
                    IsVoided = new CheckBox("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Is Voided", grid.Locator, "IsVoided");
                    IsVoided.DataField = "IsVoided";
                    IsCreatedAutomatically = new CheckBox("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Is Created Automatically", grid.Locator, "IsCreatedAutomatically");
                    IsCreatedAutomatically.DataField = "IsCreatedAutomatically";
                    SentDate = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Sent Date", grid.Locator, "SentDate");
                    SentDate.DataField = "SentDate";
                    ProjectID = new Selector("_ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edProjectID", "Project ID", grid.Locator, "ProjectID");
                    ProjectID.DataField = "ProjectID";
                    CostTaskID = new Selector("_ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edCostTaskID", "Cost Task ID", grid.Locator, "CostTaskID");
                    CostTaskID.DataField = "CostTaskID";
                    RevenueTaskID = new Selector("_ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edRevenueTaskID", "Revenue Task ID", grid.Locator, "RevenueTaskID");
                    RevenueTaskID.DataField = "RevenueTaskID";
                    CostCodeID = new Selector("_ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edCostCode2", "Cost Code ID", grid.Locator, "CostCodeID");
                    CostCodeID.DataField = "CostCodeID";
                    VendorID = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Vendor ID", grid.Locator, "VendorID");
                    VendorID.DataField = "VendorID";
                    VendorName = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Vendor Name", grid.Locator, "VendorName");
                    VendorName.DataField = "VendorName";
                    BillID = new Selector("_ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edBillID", "Bill ID", grid.Locator, "BillID");
                    BillID.DataField = "BillID";
                    BillAmount = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Bill Amount", grid.Locator, "BillAmount");
                    BillAmount.DataField = "BillAmount";
                    AccountID = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Account ID", grid.Locator, "AccountID");
                    AccountID.DataField = "AccountID";
                    ApCheckID = new Selector("_ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edApCheckID", "Ap Check ID", grid.Locator, "ApCheckID");
                    ApCheckID.DataField = "ApCheckID";
                    CheckNumber = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Check Number", grid.Locator, "CheckNumber");
                    CheckNumber.DataField = "CheckNumber";
                    ArPaymentID = new Selector("_ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edArPaymentID", "Ar Payment ID", grid.Locator, "ArPaymentID");
                    ArPaymentID.DataField = "ArPaymentID";
                    CertificateNumber = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Certificate Number", grid.Locator, "CertificateNumber");
                    CertificateNumber.DataField = "CertificateNumber";
                    CreatedByID = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Created By ID", grid.Locator, "CreatedByID");
                    CreatedByID.DataField = "CreatedByID";
                    CustomerID = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Customer ID", grid.Locator, "CustomerID");
                    CustomerID.DataField = "CustomerID";
                    CustomerName = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Customer Name", grid.Locator, "CustomerName");
                    CustomerName.DataField = "CustomerName";
                    DateIssued = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Date Issued", grid.Locator, "DateIssued");
                    DateIssued.DataField = "DateIssued";
                    EffectiveDate = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Effective Date", grid.Locator, "EffectiveDate");
                    EffectiveDate.DataField = "EffectiveDate";
                    InsuranceCompany = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Insurance Company", grid.Locator, "InsuranceCompany");
                    InsuranceCompany.DataField = "InsuranceCompany";
                    InvoiceAmount = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Invoice Amount", grid.Locator, "InvoiceAmount");
                    InvoiceAmount.DataField = "InvoiceAmount";
                    InvoiceID = new Selector("_ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edInvoiceID", "Invoice ID", grid.Locator, "InvoiceID");
                    InvoiceID.DataField = "InvoiceID";
                    IsExpired = new CheckBox("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Is Expired", grid.Locator, "IsExpired");
                    IsExpired.DataField = "IsExpired";
                    IsRequiredJointCheck = new CheckBox("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Is Required Joint Check", grid.Locator, "IsRequiredJointCheck");
                    IsRequiredJointCheck.DataField = "IsRequiredJointCheck";
                    JointAmount = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Joint Amount", grid.Locator, "JointAmount");
                    JointAmount.DataField = "JointAmount";
                    JointRelease = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Joint Release", grid.Locator, "JointRelease");
                    JointRelease.DataField = "JointRelease";
                    JointReleaseReceived = new CheckBox("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Joint Release Received", grid.Locator, "JointReleaseReceived");
                    JointReleaseReceived.DataField = "JointReleaseReceived";
                    JointVendorInternalId = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Joint Vendor Internal Id", grid.Locator, "JointVendorInternalId");
                    JointVendorInternalId.DataField = "JointVendorInternalId";
                    JointVendorExternalName = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Joint Vendor External Name", grid.Locator, "JointVendorExternalName");
                    JointVendorExternalName.DataField = "JointVendorExternalName";
                    LastModifiedByID = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Last Modified By ID", grid.Locator, "LastModifiedByID");
                    LastModifiedByID.DataField = "LastModifiedByID";
                    LienWaiverAmount = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Lien Waiver Amount", grid.Locator, "LienWaiverAmount");
                    LienWaiverAmount.DataField = "LienWaiverAmount";
                    Limit = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Limit", grid.Locator, "Limit");
                    Limit.DataField = "Limit";
                    MethodSent = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Method Sent", grid.Locator, "MethodSent");
                    MethodSent.DataField = "MethodSent";
                    PaymentDate = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Payment Date", grid.Locator, "PaymentDate");
                    PaymentDate.DataField = "PaymentDate";
                    ArPaymentMethodID = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Ar Payment Method ID", grid.Locator, "ArPaymentMethodID");
                    ArPaymentMethodID.DataField = "ArPaymentMethodID";
                    ApPaymentMethodID = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Ap Payment Method ID", grid.Locator, "ApPaymentMethodID");
                    ApPaymentMethodID.DataField = "ApPaymentMethodID";
                    Policy = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Policy", grid.Locator, "Policy");
                    Policy.DataField = "Policy";
                    ProjectTransactionID = new Selector("_ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edProjectTransactionID", "Project Transaction ID", grid.Locator, "ProjectTransactionID");
                    ProjectTransactionID.DataField = "ProjectTransactionID";
                    PurchaseOrder = new Selector("_ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edPurchaseOrder", "Purchase Order", grid.Locator, "PurchaseOrder");
                    PurchaseOrder.DataField = "PurchaseOrder";
                    PurchaseOrderLineItem = new Selector("_ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edPurchaseOrderLineItem", "Purchase Order Line Item", grid.Locator, "PurchaseOrderLineItem");
                    PurchaseOrderLineItem.DataField = "PurchaseOrderLineItem";
                    Subcontract = new Selector("_ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edSubcontract", "Subcontract", grid.Locator, "Subcontract");
                    Subcontract.DataField = "Subcontract";
                    SubcontractLineItem = new Selector("_ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edSubcontractLineItem", "Subcontract Line Item", grid.Locator, "SubcontractLineItem");
                    SubcontractLineItem.DataField = "SubcontractLineItem";
                    ChangeOrderNumber = new Selector("_ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edChangeOrderNumber", "Change Order Number", grid.Locator, "ChangeOrderNumber");
                    ChangeOrderNumber.DataField = "ChangeOrderNumber";
                    ReceiptDate = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Receipt Date", grid.Locator, "ReceiptDate");
                    ReceiptDate.DataField = "ReceiptDate";
                    ReceiveDate = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Receive Date", grid.Locator, "ReceiveDate");
                    ReceiveDate.DataField = "ReceiveDate";
                    ReceivedBy = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Received By", grid.Locator, "ReceivedBy");
                    ReceivedBy.DataField = "ReceivedBy";
                    SecondaryVendorID = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Secondary Vendor ID", grid.Locator, "SecondaryVendorID");
                    SecondaryVendorID.DataField = "SecondaryVendorID";
                    SecondaryVendorName = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Secondary Vendor Name", grid.Locator, "SecondaryVendorName");
                    SecondaryVendorName.DataField = "SecondaryVendorName";
                    SourceType = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Source Type", grid.Locator, "SourceType");
                    SourceType.DataField = "SourceType";
                    SponsorOrganization = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Sponsor Organization", grid.Locator, "SponsorOrganization");
                    SponsorOrganization.DataField = "SponsorOrganization";
                    ThroughDate = new PXTextEdit("ctl00_phG_tab_t13_grdComplianceDocuments_ei", "Through Date", grid.Locator, "ThroughDate");
                    ThroughDate.DataField = "ThroughDate";
                    DocumentTypeValue = new Selector("_ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edDocumentTypeValue", "Document Type Value", grid.Locator, "DocumentTypeValue");
                    DocumentTypeValue.DataField = "DocumentTypeValue";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter ExpirationDate { get; }
				public PXTextEditColumnFilter DocumentType { get; }
				public PXTextEditColumnFilter CreationDate { get; }
				public PXTextEditColumnFilter Status { get; }
				public CheckBoxColumnFilter Required { get; }
				public CheckBoxColumnFilter Received { get; }
				public PXTextEditColumnFilter ReceivedDate { get; }
				public CheckBoxColumnFilter IsProcessed { get; }
				public CheckBoxColumnFilter IsVoided { get; }
				public CheckBoxColumnFilter IsCreatedAutomatically { get; }
				public PXTextEditColumnFilter SentDate { get; }
				public SelectorColumnFilter ProjectID { get; }
				public SelectorColumnFilter CostTaskID { get; }
				public SelectorColumnFilter RevenueTaskID { get; }
				public SelectorColumnFilter CostCodeID { get; }
				public PXTextEditColumnFilter VendorID { get; }
				public PXTextEditColumnFilter VendorName { get; }
				public InputColumnFilter BillID { get; }
				public PXTextEditColumnFilter BillAmount { get; }
				public PXTextEditColumnFilter AccountID { get; }
				public InputColumnFilter ApCheckID { get; }
				public PXTextEditColumnFilter CheckNumber { get; }
				public InputColumnFilter ArPaymentID { get; }
				public PXTextEditColumnFilter CertificateNumber { get; }
				public PXTextEditColumnFilter CreatedByID { get; }
				public PXTextEditColumnFilter CustomerID { get; }
				public PXTextEditColumnFilter CustomerName { get; }
				public PXTextEditColumnFilter DateIssued { get; }
				public PXTextEditColumnFilter EffectiveDate { get; }
				public PXTextEditColumnFilter InsuranceCompany { get; }
				public PXTextEditColumnFilter InvoiceAmount { get; }
				public InputColumnFilter InvoiceID { get; }
				public CheckBoxColumnFilter IsExpired { get; }
				public CheckBoxColumnFilter IsRequiredJointCheck { get; }
				public PXTextEditColumnFilter JointAmount { get; }
				public PXTextEditColumnFilter JointRelease { get; }
				public CheckBoxColumnFilter JointReleaseReceived { get; }
				public PXTextEditColumnFilter JointVendorInternalId { get; }
				public PXTextEditColumnFilter JointVendorExternalName { get; }
				public PXTextEditColumnFilter LastModifiedByID { get; }
				public PXTextEditColumnFilter LienWaiverAmount { get; }
				public PXTextEditColumnFilter Limit { get; }
				public PXTextEditColumnFilter MethodSent { get; }
				public PXTextEditColumnFilter PaymentDate { get; }
				public PXTextEditColumnFilter ArPaymentMethodID { get; }
				public PXTextEditColumnFilter ApPaymentMethodID { get; }
				public PXTextEditColumnFilter Policy { get; }
				public InputColumnFilter ProjectTransactionID { get; }
				public InputColumnFilter PurchaseOrder { get; }
				public SelectorColumnFilter PurchaseOrderLineItem { get; }
				public SelectorColumnFilter Subcontract { get; }
				public SelectorColumnFilter SubcontractLineItem { get; }
				public SelectorColumnFilter ChangeOrderNumber { get; }
				public PXTextEditColumnFilter ReceiptDate { get; }
				public PXTextEditColumnFilter ReceiveDate { get; }
				public PXTextEditColumnFilter ReceivedBy { get; }
				public PXTextEditColumnFilter SecondaryVendorID { get; }
				public PXTextEditColumnFilter SecondaryVendorName { get; }
				public PXTextEditColumnFilter SourceType { get; }
				public PXTextEditColumnFilter SponsorOrganization { get; }
				public PXTextEditColumnFilter ThroughDate { get; }
				public SelectorColumnFilter DocumentTypeValue { get; }
                
                public c_grid_header(c_compliancedocuments_grdcompliancedocuments grid) : 
                        base(grid)
                {
                    ExpirationDate = new PXTextEditColumnFilter(grid.Row.ExpirationDate);
                    DocumentType = new PXTextEditColumnFilter(grid.Row.DocumentType);
                    CreationDate = new PXTextEditColumnFilter(grid.Row.CreationDate);
                    Status = new PXTextEditColumnFilter(grid.Row.Status);
                    Required = new CheckBoxColumnFilter(grid.Row.Required);
                    Received = new CheckBoxColumnFilter(grid.Row.Received);
                    ReceivedDate = new PXTextEditColumnFilter(grid.Row.ReceivedDate);
                    IsProcessed = new CheckBoxColumnFilter(grid.Row.IsProcessed);
                    IsVoided = new CheckBoxColumnFilter(grid.Row.IsVoided);
                    IsCreatedAutomatically = new CheckBoxColumnFilter(grid.Row.IsCreatedAutomatically);
                    SentDate = new PXTextEditColumnFilter(grid.Row.SentDate);
                    ProjectID = new SelectorColumnFilter(grid.Row.ProjectID);
                    CostTaskID = new SelectorColumnFilter(grid.Row.CostTaskID);
                    RevenueTaskID = new SelectorColumnFilter(grid.Row.RevenueTaskID);
                    CostCodeID = new SelectorColumnFilter(grid.Row.CostCodeID);
                    VendorID = new PXTextEditColumnFilter(grid.Row.VendorID);
                    VendorName = new PXTextEditColumnFilter(grid.Row.VendorName);
                    BillID = new InputColumnFilter(grid.Row.BillID);
                    BillAmount = new PXTextEditColumnFilter(grid.Row.BillAmount);
                    AccountID = new PXTextEditColumnFilter(grid.Row.AccountID);
                    ApCheckID = new InputColumnFilter(grid.Row.ApCheckID);
                    CheckNumber = new PXTextEditColumnFilter(grid.Row.CheckNumber);
                    ArPaymentID = new InputColumnFilter(grid.Row.ArPaymentID);
                    CertificateNumber = new PXTextEditColumnFilter(grid.Row.CertificateNumber);
                    CreatedByID = new PXTextEditColumnFilter(grid.Row.CreatedByID);
                    CustomerID = new PXTextEditColumnFilter(grid.Row.CustomerID);
                    CustomerName = new PXTextEditColumnFilter(grid.Row.CustomerName);
                    DateIssued = new PXTextEditColumnFilter(grid.Row.DateIssued);
                    EffectiveDate = new PXTextEditColumnFilter(grid.Row.EffectiveDate);
                    InsuranceCompany = new PXTextEditColumnFilter(grid.Row.InsuranceCompany);
                    InvoiceAmount = new PXTextEditColumnFilter(grid.Row.InvoiceAmount);
                    InvoiceID = new InputColumnFilter(grid.Row.InvoiceID);
                    IsExpired = new CheckBoxColumnFilter(grid.Row.IsExpired);
                    IsRequiredJointCheck = new CheckBoxColumnFilter(grid.Row.IsRequiredJointCheck);
                    JointAmount = new PXTextEditColumnFilter(grid.Row.JointAmount);
                    JointRelease = new PXTextEditColumnFilter(grid.Row.JointRelease);
                    JointReleaseReceived = new CheckBoxColumnFilter(grid.Row.JointReleaseReceived);
                    JointVendorInternalId = new PXTextEditColumnFilter(grid.Row.JointVendorInternalId);
                    JointVendorExternalName = new PXTextEditColumnFilter(grid.Row.JointVendorExternalName);
                    LastModifiedByID = new PXTextEditColumnFilter(grid.Row.LastModifiedByID);
                    LienWaiverAmount = new PXTextEditColumnFilter(grid.Row.LienWaiverAmount);
                    Limit = new PXTextEditColumnFilter(grid.Row.Limit);
                    MethodSent = new PXTextEditColumnFilter(grid.Row.MethodSent);
                    PaymentDate = new PXTextEditColumnFilter(grid.Row.PaymentDate);
                    ArPaymentMethodID = new PXTextEditColumnFilter(grid.Row.ArPaymentMethodID);
                    ApPaymentMethodID = new PXTextEditColumnFilter(grid.Row.ApPaymentMethodID);
                    Policy = new PXTextEditColumnFilter(grid.Row.Policy);
                    ProjectTransactionID = new InputColumnFilter(grid.Row.ProjectTransactionID);
                    PurchaseOrder = new InputColumnFilter(grid.Row.PurchaseOrder);
                    PurchaseOrderLineItem = new SelectorColumnFilter(grid.Row.PurchaseOrderLineItem);
                    Subcontract = new SelectorColumnFilter(grid.Row.Subcontract);
                    SubcontractLineItem = new SelectorColumnFilter(grid.Row.SubcontractLineItem);
                    ChangeOrderNumber = new SelectorColumnFilter(grid.Row.ChangeOrderNumber);
                    ReceiptDate = new PXTextEditColumnFilter(grid.Row.ReceiptDate);
                    ReceiveDate = new PXTextEditColumnFilter(grid.Row.ReceiveDate);
                    ReceivedBy = new PXTextEditColumnFilter(grid.Row.ReceivedBy);
                    SecondaryVendorID = new PXTextEditColumnFilter(grid.Row.SecondaryVendorID);
                    SecondaryVendorName = new PXTextEditColumnFilter(grid.Row.SecondaryVendorName);
                    SourceType = new PXTextEditColumnFilter(grid.Row.SourceType);
                    SponsorOrganization = new PXTextEditColumnFilter(grid.Row.SponsorOrganization);
                    ThroughDate = new PXTextEditColumnFilter(grid.Row.ThroughDate);
                    DocumentTypeValue = new SelectorColumnFilter(grid.Row.DocumentTypeValue);
                }
            }
        }
        
        public class c_compliancedocuments_lv0 : Container
        {
            
			public Selector CostCodeID { get; }
			public Label CostCodeIDLabel { get; }
			public Selector DocumentTypeValue { get; }
			public Label DocumentTypeValueLabel { get; }
			public Selector BillID { get; }
			public Label BillIDLabel { get; }
			public Selector InvoiceID { get; }
			public Label InvoiceIDLabel { get; }
			public Selector ApCheckID { get; }
			public Label ApCheckIDLabel { get; }
			public Selector ArPaymentID { get; }
			public Label ArPaymentIDLabel { get; }
			public Selector ProjectTransactionID { get; }
			public Label ProjectTransactionIDLabel { get; }
			public Selector PurchaseOrder { get; }
			public Label PurchaseOrderLabel { get; }
			public Selector PurchaseOrderLineItem { get; }
			public Label PurchaseOrderLineItemLabel { get; }
			public Selector Subcontract { get; }
			public Label SubcontractLabel { get; }
			public Selector SubcontractLineItem { get; }
			public Label SubcontractLineItemLabel { get; }
			public Selector ChangeOrderNumber { get; }
			public Label ChangeOrderNumberLabel { get; }
			public Selector CostTaskID { get; }
			public Label CostTaskIDLabel { get; }
			public Selector RevenueTaskID { get; }
			public Label RevenueTaskIDLabel { get; }
			public Selector ProjectID { get; }
			public Label ProjectIDLabel { get; }
            
            public c_compliancedocuments_lv0(string locator, string name) : 
                    base(locator, name)
            {
                CostCodeID = new Selector("ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edCostCode2", "Cost Code ID", locator, null);
                CostCodeIDLabel = new Label(CostCodeID);
                CostCodeID.DataField = "CostCodeID";
                DocumentTypeValue = new Selector("ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edDocumentTypeValue", "Document Type Value", locator, null);
                DocumentTypeValueLabel = new Label(DocumentTypeValue);
                DocumentTypeValue.DataField = "DocumentTypeValue";
                BillID = new Selector("ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edBillID", "Bill ID", locator, null);
                BillIDLabel = new Label(BillID);
                BillID.DataField = "BillID";
                InvoiceID = new Selector("ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edInvoiceID", "Invoice ID", locator, null);
                InvoiceIDLabel = new Label(InvoiceID);
                InvoiceID.DataField = "InvoiceID";
                ApCheckID = new Selector("ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edApCheckID", "Ap Check ID", locator, null);
                ApCheckIDLabel = new Label(ApCheckID);
                ApCheckID.DataField = "ApCheckID";
                ArPaymentID = new Selector("ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edArPaymentID", "Ar Payment ID", locator, null);
                ArPaymentIDLabel = new Label(ArPaymentID);
                ArPaymentID.DataField = "ArPaymentID";
                ProjectTransactionID = new Selector("ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edProjectTransactionID", "Project Transaction ID", locator, null);
                ProjectTransactionIDLabel = new Label(ProjectTransactionID);
                ProjectTransactionID.DataField = "ProjectTransactionID";
                PurchaseOrder = new Selector("ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edPurchaseOrder", "Purchase Order", locator, null);
                PurchaseOrderLabel = new Label(PurchaseOrder);
                PurchaseOrder.DataField = "PurchaseOrder";
                PurchaseOrderLineItem = new Selector("ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edPurchaseOrderLineItem", "Purchase Order Line Item", locator, null);
                PurchaseOrderLineItemLabel = new Label(PurchaseOrderLineItem);
                PurchaseOrderLineItem.DataField = "PurchaseOrderLineItem";
                Subcontract = new Selector("ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edSubcontract", "Subcontract", locator, null);
                SubcontractLabel = new Label(Subcontract);
                Subcontract.DataField = "Subcontract";
                SubcontractLineItem = new Selector("ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edSubcontractLineItem", "Subcontract Line Item", locator, null);
                SubcontractLineItemLabel = new Label(SubcontractLineItem);
                SubcontractLineItem.DataField = "SubcontractLineItem";
                ChangeOrderNumber = new Selector("ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edChangeOrderNumber", "Change Order Number", locator, null);
                ChangeOrderNumberLabel = new Label(ChangeOrderNumber);
                ChangeOrderNumber.DataField = "ChangeOrderNumber";
                CostTaskID = new Selector("ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edCostTaskID", "Cost Task ID", locator, null);
                CostTaskIDLabel = new Label(CostTaskID);
                CostTaskID.DataField = "CostTaskID";
                RevenueTaskID = new Selector("ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edRevenueTaskID", "Revenue Task ID", locator, null);
                RevenueTaskIDLabel = new Label(RevenueTaskID);
                RevenueTaskID.DataField = "RevenueTaskID";
                ProjectID = new Selector("ctl00_phG_tab_t13_grdComplianceDocuments_lv0_edProjectID", "Project ID", locator, null);
                ProjectIDLabel = new Label(ProjectID);
                ProjectID.DataField = "ProjectID";
                DataMemberName = "ComplianceDocuments";
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
