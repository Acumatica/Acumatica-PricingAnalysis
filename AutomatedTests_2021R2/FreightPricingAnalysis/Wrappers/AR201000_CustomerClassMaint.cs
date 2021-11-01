using Api;
using Controls;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;
using Controls.Grid;
using Controls.Grid.Filter;
using Controls.Grid.Upload;
using Controls.GroupBox;
using Controls.Input;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.PxControlCollection;
using Controls.ToolBarButton;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace GeneratedWrappers.Acumatica
{
    
    
    public class AR201000_CustomerClassMaint : Wrapper
    {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
        protected c_customerclassrecord_form CustomerClassRecord_form { get; } = new c_customerclassrecord_form("ctl00_phF_form", "CustomerClassRecord_form");
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
        protected c_curcustomerclassrecord_tab CurCustomerClassRecord_tab { get; } = new c_curcustomerclassrecord_tab("ctl00_phG_tab", "CurCustomerClassRecord_tab");
        protected c_customerclassrecord_tab CustomerClassRecord_tab { get; } = new c_customerclassrecord_tab("ctl00_phG_tab", "CustomerClassRecord_tab");
        protected c_mapping_grid Mapping_grid { get; } = new c_mapping_grid("ctl00_phG_tab_t2_grid", "Mapping_grid");
        protected c_mapping_lv0 Mapping_lv0 { get; } = new c_mapping_lv0("ctl00_phG_tab_t2_grid_lv0", "Mapping_lv0");
        protected c_notificationsources_gridns NotificationSources_gridNS { get; } = new c_notificationsources_gridns("ctl00_phG_tab_t3_sp1_gridNS", "NotificationSources_gridNS");
        protected c_notificationsources_lv0 NotificationSources_lv0 { get; } = new c_notificationsources_lv0("ctl00_phG_tab_t3_sp1_gridNS_lv0", "NotificationSources_lv0");
        protected c_notificationrecipients_gridnr NotificationRecipients_gridNR { get; } = new c_notificationrecipients_gridnr("ctl00_phG_tab_t3_sp1_gridNR", "NotificationRecipients_gridNR");
        protected c_notificationrecipients_lv0 NotificationRecipients_lv0 { get; } = new c_notificationrecipients_lv0("ctl00_phG_tab_t3_sp1_gridNR_lv0", "NotificationRecipients_lv0");
        protected c_billingcycles_gridbillingcycles BillingCycles_gridBillingCycles { get; } = new c_billingcycles_gridbillingcycles("ctl00_phG_tab_t4_gridBillingCycles", "BillingCycles_gridBillingCycles");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        
        public AR201000_CustomerClassMaint()
        {
            ScreenId = "AR201000";
            ScreenUrl = "/Pages/AR/AR201000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual AR201000_CustomerClassMaint ReadOne(Gate gate, string CustomerClassID)
        {
            new BiObject<AR201000_CustomerClassMaint>(gate).ReadOne(this, CustomerClassID);
            return this;
        }
        
        public virtual AR201000_CustomerClassMaint ReadOne(string CustomerClassID)
        {
            return this.ReadOne(ApiConnection.Source, CustomerClassID);
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
        
        public virtual void ActionsMenu()
        {
            ToolBar.ActionsMenu.Click();
        }
        
        public virtual void ResetGroup()
        {
            ToolBar.ResetGroup.Click();
        }
        
        public virtual void ResetGroup(bool status, string message = null)
        {
            ToolBar.ResetGroup.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.ResetGroup.Click();
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
			public ToolBarButton ActionsMenu { get; }
			public ToolBarButton ResetGroup { get; }
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
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Cancel", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                Insert = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Insert", "Add New Record (Ctrl+Ins)", locator, null);
                Delete = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Delete", "Delete (Ctrl+Del).", locator, null);
                Delete.ConfirmAction = () => Alert.AlertToException("The current Customer Class record will be deleted.");
                CopyPaste = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CopyPaste", "Clipboard", locator, null);
                CopyDocument = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@CopyDocument\']", "CopyDocument", locator, CopyPaste);
                PasteDocument = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@PasteDocument\']", "PasteDocument", locator, CopyPaste);
                SaveTemplate = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@SaveTemplate\']", "SaveTemplate", locator, CopyPaste);
                First = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_First", "Go to First Record", locator, null);
                Previous = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Previous", "Go to Previous Record (PgUp)", locator, null);
                Next = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Next", "Go to Next Record (PgDn)", locator, null);
                Last = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Last", "Go to Last Record", locator, null);
                ActionsMenu = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ActionsMenu", "Actions", locator, MenuOpener);
                ResetGroup = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ResetGroup", "Include Customers in Restriction Group", locator, null);
                ResetGroup.WaitAction = Wait.WaitForLongOperationToComplete;
                LongRun = new ToolBarButton("css=qp-long-run", "Nothing in progress", locator, null);
                LongrunCancel = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_cancel", "Cancel", locator, null);
                LongrunTimer = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_timer", "Elapsed Time", locator, null);
            }
        }
        
        public class c_customerclassrecord_form : Container
        {
            
			public Selector CustomerClassID { get; }
			public Label CustomerClassIDLabel { get; }
			public InputLocalizable Descr { get; }
			public Label DescrLabel { get; }
			public CheckBox ChkServiceManagement { get; }
			public Label ChkServiceManagementLabel { get; }
            
            public c_customerclassrecord_form(string locator, string name) : 
                    base(locator, name)
            {
                CustomerClassID = new Selector("ctl00_phF_form_edCustomerClassID", "Class ID", locator, null);
                CustomerClassIDLabel = new Label(CustomerClassID);
                CustomerClassID.DataField = "CustomerClassID";
                Descr = new InputLocalizable("ctl00_phF_form_edDescr", "Description", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                ChkServiceManagement = new CheckBox("ctl00_phF_form_chkServiceManagement", "chkServiceManagement", locator, null);
                ChkServiceManagementLabel = new Label(ChkServiceManagement);
                ChkServiceManagement.DataField = "ChkServiceManagement";
                DataMemberName = "CustomerClassRecord";
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
        
        public class c_curcustomerclassrecord_tab : Container
        {
            
			public Selector CountryID { get; }
			public Label CountryIDLabel { get; }
			public PXBranchSelector OrgBAccountID { get; }
			public Label OrgBAccountIDLabel { get; }
			public Selector TaxZoneID { get; }
			public Label TaxZoneIDLabel { get; }
			public CheckBox RequireTaxZone { get; }
			public Label RequireTaxZoneLabel { get; }
			public DropDown TaxCalcMode { get; }
			public Label TaxCalcModeLabel { get; }
			public DropDown AvalaraCustomerUsageType { get; }
			public Label AvalaraCustomerUsageTypeLabel { get; }
			public CheckBox RequireAvalaraCustomerUsageType { get; }
			public Label RequireAvalaraCustomerUsageTypeLabel { get; }
			public CheckBox DefaultLocationCDFromBranch { get; }
			public Label DefaultLocationCDFromBranchLabel { get; }
			public Selector PriceClassID { get; }
			public Label PriceClassIDLabel { get; }
			public Selector GroupMask { get; }
			public Label GroupMaskLabel { get; }
			public Selector SalesPersonID { get; }
			public Label SalesPersonIDLabel { get; }
			public Selector ShipVia { get; }
			public Label ShipViaLabel { get; }
			public Selector ShipTermsID { get; }
			public Label ShipTermsIDLabel { get; }
			public DropDown ShipComplete { get; }
			public Label ShipCompleteLabel { get; }
			public DropDown CreditRule { get; }
			public Label CreditRuleLabel { get; }
			public PXNumberEdit CreditLimit { get; }
			public Label CreditLimitLabel { get; }
			public PXNumberEdit OverLimitAmount { get; }
			public Label OverLimitAmountLabel { get; }
			public PXNumberEdit CreditDaysPastDue { get; }
			public Label CreditDaysPastDueLabel { get; }
			public Selector DfltBillingCycleID { get; }
			public Label DfltBillingCycleIDLabel { get; }
			public DropDown SendInvoicesTo { get; }
			public Label SendInvoicesToLabel { get; }
			public DropDown BillShipmentSource { get; }
			public Label BillShipmentSourceLabel { get; }
			public DropDown DefaultBillingCustomerSource { get; }
			public Label DefaultBillingCustomerSourceLabel { get; }
			public Selector BillCustomerID { get; }
			public Label BillCustomerIDLabel { get; }
			public Selector BillLocationID { get; }
			public Label BillLocationIDLabel { get; }
			public Selector TermsID { get; }
			public Label TermsIDLabel { get; }
			public Selector StatementCycleId { get; }
			public Label StatementCycleIdLabel { get; }
			public Selector DefPaymentMethodID { get; }
			public Label DefPaymentMethodIDLabel { get; }
			public CheckBox AutoApplyPayments { get; }
			public Label AutoApplyPaymentsLabel { get; }
			public CheckBox FinChargeApply { get; }
			public Label FinChargeApplyLabel { get; }
			public Selector FinChargeID { get; }
			public Label FinChargeIDLabel { get; }
			public CheckBox SmallBalanceAllow { get; }
			public Label SmallBalanceAllowLabel { get; }
			public PXNumberEdit SmallBalanceLimit { get; }
			public Label SmallBalanceLimitLabel { get; }
			public Selector CuryID { get; }
			public Label CuryIDLabel { get; }
			public CheckBox AllowOverrideCury { get; }
			public Label AllowOverrideCuryLabel { get; }
			public Selector CuryRateTypeID { get; }
			public Label CuryRateTypeIDLabel { get; }
			public CheckBox AllowOverrideRate { get; }
			public Label AllowOverrideRateLabel { get; }
			public PXNumberEdit DiscountLimit { get; }
			public Label DiscountLimitLabel { get; }
			public CheckBox PaymentsByLinesAllowed { get; }
			public Label PaymentsByLinesAllowedLabel { get; }
			public CheckBox RetainageApply { get; }
			public Label RetainageApplyLabel { get; }
			public CheckBox MailInvoices { get; }
			public Label MailInvoicesLabel { get; }
			public CheckBox PrintInvoices { get; }
			public Label PrintInvoicesLabel { get; }
			public CheckBox MailDunningLetters { get; }
			public Label MailDunningLettersLabel { get; }
			public CheckBox PrintDunningLetters { get; }
			public Label PrintDunningLettersLabel { get; }
			public CheckBox SendStatementByEmail { get; }
			public Label SendStatementByEmailLabel { get; }
			public CheckBox PrintStatements { get; }
			public Label PrintStatementsLabel { get; }
			public DropDown StatementType { get; }
			public Label StatementTypeLabel { get; }
			public CheckBox PrintCuryStatements { get; }
			public Label PrintCuryStatementsLabel { get; }
			public DropDown SavePaymentProfiles { get; }
			public Label SavePaymentProfilesLabel { get; }
			public Selector ARAcctID { get; }
			public Label ARAcctIDLabel { get; }
			public Selector ARSubID { get; }
			public Label ARSubIDLabel { get; }
			public Selector SalesAcctID { get; }
			public Label SalesAcctIDLabel { get; }
			public Selector SalesSubID { get; }
			public Label SalesSubIDLabel { get; }
			public Selector DiscountAcctID { get; }
			public Label DiscountAcctIDLabel { get; }
			public Selector DiscountSubID { get; }
			public Label DiscountSubIDLabel { get; }
			public Selector FreightAcctID { get; }
			public Label FreightAcctIDLabel { get; }
			public Selector FreightSubID { get; }
			public Label FreightSubIDLabel { get; }
			public Selector DiscTakenAcctID { get; }
			public Label DiscTakenAcctIDLabel { get; }
			public Selector DiscTakenSubID { get; }
			public Label DiscTakenSubIDLabel { get; }
			public Selector PrepaymentAcctID { get; }
			public Label PrepaymentAcctIDLabel { get; }
			public Selector PrepaymentSubID { get; }
			public Label PrepaymentSubIDLabel { get; }
			public Selector COGSAcctID { get; }
			public Label COGSAcctIDLabel { get; }
			public Selector COGSSubID { get; }
			public Label COGSSubIDLabel { get; }
			public Selector MiscAcctID { get; }
			public Label MiscAcctIDLabel { get; }
			public Selector MiscSubID { get; }
			public Label MiscSubIDLabel { get; }
			public Selector UnrealizedGainAcctID { get; }
			public Label UnrealizedGainAcctIDLabel { get; }
			public Selector UnrealizedGainSubID { get; }
			public Label UnrealizedGainSubIDLabel { get; }
			public Selector UnrealizedLossAcctID { get; }
			public Label UnrealizedLossAcctIDLabel { get; }
			public Selector UnrealizedLossSubID { get; }
			public Label UnrealizedLossSubIDLabel { get; }
			public Selector RetainageAcctID { get; }
			public Label RetainageAcctIDLabel { get; }
			public Selector RetainageSubID { get; }
			public Label RetainageSubIDLabel { get; }
            
            public c_curcustomerclassrecord_tab(string locator, string name) : 
                    base(locator, name)
            {
                CountryID = new Selector("ctl00_phG_tab_t0_edCountryID", "Country", locator, null);
                CountryIDLabel = new Label(CountryID);
                CountryID.DataField = "CountryID";
                OrgBAccountID = new PXBranchSelector("ctl00_phG_tab_t0_edOrgBAccountID", "Restrict Visibility To", locator, null);
                OrgBAccountIDLabel = new Label(OrgBAccountID);
                OrgBAccountID.DataField = "OrgBAccountID";
                TaxZoneID = new Selector("ctl00_phG_tab_t0_edTaxZoneID", "Tax Zone ID", locator, null);
                TaxZoneIDLabel = new Label(TaxZoneID);
                TaxZoneID.DataField = "TaxZoneID";
                RequireTaxZone = new CheckBox("ctl00_phG_tab_t0_chkRequireTaxZone", "Require Tax Zone", locator, null);
                RequireTaxZoneLabel = new Label(RequireTaxZone);
                RequireTaxZone.DataField = "RequireTaxZone";
                TaxCalcMode = new DropDown("ctl00_phG_tab_t0_edTaxCalcMode", "Tax Calculation Mode", locator, null);
                TaxCalcModeLabel = new Label(TaxCalcMode);
                TaxCalcMode.DataField = "TaxCalcMode";
                TaxCalcMode.Items.Add("T", "Tax Settings");
                TaxCalcMode.Items.Add("G", "Gross");
                TaxCalcMode.Items.Add("N", "Net");
                AvalaraCustomerUsageType = new DropDown("ctl00_phG_tab_t0_edAvalaraCustomerUsageType", "Entity Usage Type", locator, null);
                AvalaraCustomerUsageTypeLabel = new Label(AvalaraCustomerUsageType);
                AvalaraCustomerUsageType.DataField = "AvalaraCustomerUsageType";
                AvalaraCustomerUsageType.Items.Add("A", "Federal Government");
                AvalaraCustomerUsageType.Items.Add("B", "State/Local Govt.");
                AvalaraCustomerUsageType.Items.Add("C", "Tribal Government");
                AvalaraCustomerUsageType.Items.Add("D", "Foreign Diplomat");
                AvalaraCustomerUsageType.Items.Add("E", "Charitable Organization");
                AvalaraCustomerUsageType.Items.Add("F", "Religious");
                AvalaraCustomerUsageType.Items.Add("G", "Resale");
                AvalaraCustomerUsageType.Items.Add("H", "Agricultural Production");
                AvalaraCustomerUsageType.Items.Add("I", "Industrial Prod/Mfg.");
                AvalaraCustomerUsageType.Items.Add("J", "Direct Pay Permit");
                AvalaraCustomerUsageType.Items.Add("K", "Direct Mail");
                AvalaraCustomerUsageType.Items.Add("L", "Other");
                AvalaraCustomerUsageType.Items.Add("M", "Education");
                AvalaraCustomerUsageType.Items.Add("N", "Local Government");
                AvalaraCustomerUsageType.Items.Add("P", "Commercial Aquaculture");
                AvalaraCustomerUsageType.Items.Add("Q", "Commercial Fishery");
                AvalaraCustomerUsageType.Items.Add("R", "Non-resident");
                AvalaraCustomerUsageType.Items.Add("0", "Default");
                RequireAvalaraCustomerUsageType = new CheckBox("ctl00_phG_tab_t0_chkAvalaraCustomerUsageType", "Require Entity Usage Type", locator, null);
                RequireAvalaraCustomerUsageTypeLabel = new Label(RequireAvalaraCustomerUsageType);
                RequireAvalaraCustomerUsageType.DataField = "RequireAvalaraCustomerUsageType";
                DefaultLocationCDFromBranch = new CheckBox("ctl00_phG_tab_t0_chkDefaultLocationCDFromBranch", "Default Location ID from Branch", locator, null);
                DefaultLocationCDFromBranchLabel = new Label(DefaultLocationCDFromBranch);
                DefaultLocationCDFromBranch.DataField = "DefaultLocationCDFromBranch";
                PriceClassID = new Selector("ctl00_phG_tab_t0_edPriceClassID", "Price Class", locator, null);
                PriceClassIDLabel = new Label(PriceClassID);
                PriceClassID.DataField = "PriceClassID";
                GroupMask = new Selector("ctl00_phG_tab_t0_edGroupMask", "Default Restriction Group", locator, null);
                GroupMaskLabel = new Label(GroupMask);
                GroupMask.DataField = "GroupMask";
                SalesPersonID = new Selector("ctl00_phG_tab_t0_edSalesPersonID", "Salesperson ID", locator, null);
                SalesPersonIDLabel = new Label(SalesPersonID);
                SalesPersonID.DataField = "SalesPersonID";
                ShipVia = new Selector("ctl00_phG_tab_t0_edShipVia", "Ship Via", locator, null);
                ShipViaLabel = new Label(ShipVia);
                ShipVia.DataField = "ShipVia";
                ShipTermsID = new Selector("ctl00_phG_tab_t0_edShipTermsID", "Shipping Terms", locator, null);
                ShipTermsIDLabel = new Label(ShipTermsID);
                ShipTermsID.DataField = "ShipTermsID";
                ShipComplete = new DropDown("ctl00_phG_tab_t0_edShipComplete", "Shipping Rule", locator, null);
                ShipCompleteLabel = new Label(ShipComplete);
                ShipComplete.DataField = "ShipComplete";
                ShipComplete.Items.Add("C", "Ship Complete");
                ShipComplete.Items.Add("B", "Back Order Allowed");
                ShipComplete.Items.Add("L", "Cancel Remainder");
                CreditRule = new DropDown("ctl00_phG_tab_t0_edCreditRule", "Credit Verification", locator, null);
                CreditRuleLabel = new Label(CreditRule);
                CreditRule.DataField = "CreditRule";
                CreditRule.Items.Add("D", "Days Past Due");
                CreditRule.Items.Add("C", "Credit Limit");
                CreditRule.Items.Add("B", "Limit and Days Past Due");
                CreditRule.Items.Add("N", "Disabled");
                CreditLimit = new PXNumberEdit("ctl00_phG_tab_t0_edCreditLimit", "Credit Limit", locator, null);
                CreditLimitLabel = new Label(CreditLimit);
                CreditLimit.DataField = "CreditLimit";
                OverLimitAmount = new PXNumberEdit("ctl00_phG_tab_t0_edOverLimitAmount", "Over-Limit Amount", locator, null);
                OverLimitAmountLabel = new Label(OverLimitAmount);
                OverLimitAmount.DataField = "OverLimitAmount";
                CreditDaysPastDue = new PXNumberEdit("ctl00_phG_tab_t0_edCreditDaysPastDue", "Credit Days Past Due", locator, null);
                CreditDaysPastDueLabel = new Label(CreditDaysPastDue);
                CreditDaysPastDue.DataField = "CreditDaysPastDue";
                DfltBillingCycleID = new Selector("ctl00_phG_tab_t0_edDfltBillingCycleID", "Billing Cycle", locator, null);
                DfltBillingCycleIDLabel = new Label(DfltBillingCycleID);
                DfltBillingCycleID.DataField = "DfltBillingCycleID";
                SendInvoicesTo = new DropDown("ctl00_phG_tab_t0_edSendInvoicesTo", "Bill-To Address", locator, null);
                SendInvoicesToLabel = new Label(SendInvoicesTo);
                SendInvoicesTo.DataField = "SendInvoicesTo";
                BillShipmentSource = new DropDown("ctl00_phG_tab_t0_edBillShipmentSource", "Ship-To Address", locator, null);
                BillShipmentSourceLabel = new Label(BillShipmentSource);
                BillShipmentSource.DataField = "BillShipmentSource";
                DefaultBillingCustomerSource = new DropDown("ctl00_phG_tab_t0_edDefaultBillingCustomerSource", "Default Billing Customer", locator, null);
                DefaultBillingCustomerSourceLabel = new Label(DefaultBillingCustomerSource);
                DefaultBillingCustomerSource.DataField = "DefaultBillingCustomerSource";
                BillCustomerID = new Selector("ctl00_phG_tab_t0_edBillCustomerID", "Billing Customer", locator, null);
                BillCustomerIDLabel = new Label(BillCustomerID);
                BillCustomerID.DataField = "BillCustomerID";
                BillLocationID = new Selector("ctl00_phG_tab_t0_edBillLocationID", "Billing Location", locator, null);
                BillLocationIDLabel = new Label(BillLocationID);
                BillLocationID.DataField = "BillLocationID";
                TermsID = new Selector("ctl00_phG_tab_t0_edTermsID", "Terms", locator, null);
                TermsIDLabel = new Label(TermsID);
                TermsID.DataField = "TermsID";
                StatementCycleId = new Selector("ctl00_phG_tab_t0_edStatementCycleId", "Statement Cycle ID", locator, null);
                StatementCycleIdLabel = new Label(StatementCycleId);
                StatementCycleId.DataField = "StatementCycleId";
                DefPaymentMethodID = new Selector("ctl00_phG_tab_t0_edDefPaymentMethodID", "Payment Method", locator, null);
                DefPaymentMethodIDLabel = new Label(DefPaymentMethodID);
                DefPaymentMethodID.DataField = "DefPaymentMethodID";
                AutoApplyPayments = new CheckBox("ctl00_phG_tab_t0_chkAutoApplyPayments", "Auto-Apply Payments", locator, null);
                AutoApplyPaymentsLabel = new Label(AutoApplyPayments);
                AutoApplyPayments.DataField = "AutoApplyPayments";
                FinChargeApply = new CheckBox("ctl00_phG_tab_t0_chkFinChargeApply", "Apply Overdue Charges", locator, null);
                FinChargeApplyLabel = new Label(FinChargeApply);
                FinChargeApply.DataField = "FinChargeApply";
                FinChargeID = new Selector("ctl00_phG_tab_t0_edFinChargeID", "Overdue Charge ID", locator, null);
                FinChargeIDLabel = new Label(FinChargeID);
                FinChargeID.DataField = "FinChargeID";
                SmallBalanceAllow = new CheckBox("ctl00_phG_tab_t0_chkSmallBalanceAllow", "Enable Write-Offs", locator, null);
                SmallBalanceAllowLabel = new Label(SmallBalanceAllow);
                SmallBalanceAllow.DataField = "SmallBalanceAllow";
                SmallBalanceLimit = new PXNumberEdit("ctl00_phG_tab_t0_edSmallBalanceLimit", "Write-Off Limit", locator, null);
                SmallBalanceLimitLabel = new Label(SmallBalanceLimit);
                SmallBalanceLimit.DataField = "SmallBalanceLimit";
                CuryID = new Selector("ctl00_phG_tab_t0_edCuryID", "Currency ID", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                AllowOverrideCury = new CheckBox("ctl00_phG_tab_t0_chkAllowOverrideCury", "Enable Currency Override", locator, null);
                AllowOverrideCuryLabel = new Label(AllowOverrideCury);
                AllowOverrideCury.DataField = "AllowOverrideCury";
                CuryRateTypeID = new Selector("ctl00_phG_tab_t0_edCuryRateTypeID", "Currency Rate Type", locator, null);
                CuryRateTypeIDLabel = new Label(CuryRateTypeID);
                CuryRateTypeID.DataField = "CuryRateTypeID";
                AllowOverrideRate = new CheckBox("ctl00_phG_tab_t0_chkAllowOverrideRate", "Enable Rate Override", locator, null);
                AllowOverrideRateLabel = new Label(AllowOverrideRate);
                AllowOverrideRate.DataField = "AllowOverrideRate";
                DiscountLimit = new PXNumberEdit("ctl00_phG_tab_t0_edDiscountLimit", "Group/Document Discount Limit (%)", locator, null);
                DiscountLimitLabel = new Label(DiscountLimit);
                DiscountLimit.DataField = "DiscountLimit";
                PaymentsByLinesAllowed = new CheckBox("ctl00_phG_tab_t0_chkPaymentsByLinesAllowed", "Pay by Line", locator, null);
                PaymentsByLinesAllowedLabel = new Label(PaymentsByLinesAllowed);
                PaymentsByLinesAllowed.DataField = "PaymentsByLinesAllowed";
                RetainageApply = new CheckBox("ctl00_phG_tab_t0_chkRetainageApply", "Apply Retainage", locator, null);
                RetainageApplyLabel = new Label(RetainageApply);
                RetainageApply.DataField = "RetainageApply";
                MailInvoices = new CheckBox("ctl00_phG_tab_t0_chkMailInvoices", "Send Invoices by Email", locator, null);
                MailInvoicesLabel = new Label(MailInvoices);
                MailInvoices.DataField = "MailInvoices";
                PrintInvoices = new CheckBox("ctl00_phG_tab_t0_chkPrintInvoices", "Print Invoices", locator, null);
                PrintInvoicesLabel = new Label(PrintInvoices);
                PrintInvoices.DataField = "PrintInvoices";
                MailDunningLetters = new CheckBox("ctl00_phG_tab_t0_chkMailDunningLetters", "Send Dunning Letters by Email", locator, null);
                MailDunningLettersLabel = new Label(MailDunningLetters);
                MailDunningLetters.DataField = "MailDunningLetters";
                PrintDunningLetters = new CheckBox("ctl00_phG_tab_t0_chkPrintDunningLetters", "Print Dunning Letters", locator, null);
                PrintDunningLettersLabel = new Label(PrintDunningLetters);
                PrintDunningLetters.DataField = "PrintDunningLetters";
                SendStatementByEmail = new CheckBox("ctl00_phG_tab_t0_chkSendStatementByEmail", "Send Statements by Email", locator, null);
                SendStatementByEmailLabel = new Label(SendStatementByEmail);
                SendStatementByEmail.DataField = "SendStatementByEmail";
                PrintStatements = new CheckBox("ctl00_phG_tab_t0_chkPrintStatements", "Print Statements", locator, null);
                PrintStatementsLabel = new Label(PrintStatements);
                PrintStatements.DataField = "PrintStatements";
                StatementType = new DropDown("ctl00_phG_tab_t0_edStatementType", "Statement Type", locator, null);
                StatementTypeLabel = new Label(StatementType);
                StatementType.DataField = "StatementType";
                StatementType.Items.Add("O", "Open Item");
                StatementType.Items.Add("B", "Balance Brought Forward");
                PrintCuryStatements = new CheckBox("ctl00_phG_tab_t0_chkPrintCuryStatements", "Multi-Currency Statements", locator, null);
                PrintCuryStatementsLabel = new Label(PrintCuryStatements);
                PrintCuryStatements.DataField = "PrintCuryStatements";
                SavePaymentProfiles = new DropDown("ctl00_phG_tab_t0_cmbSavePaymentProfiles", "Save Payment Profiles", locator, null);
                SavePaymentProfilesLabel = new Label(SavePaymentProfiles);
                SavePaymentProfiles.DataField = "SavePaymentProfiles";
                SavePaymentProfiles.Items.Add("A", "Upon Confirmation");
                SavePaymentProfiles.Items.Add("F", "Always");
                SavePaymentProfiles.Items.Add("P", "Never");
                ARAcctID = new Selector("ctl00_phG_tab_t1_edARAcctID", "AR Account", locator, null);
                ARAcctIDLabel = new Label(ARAcctID);
                ARAcctID.DataField = "ARAcctID";
                ARSubID = new Selector("ctl00_phG_tab_t1_edARSubID", "AR Sub.", locator, null);
                ARSubIDLabel = new Label(ARSubID);
                ARSubID.DataField = "ARSubID";
                SalesAcctID = new Selector("ctl00_phG_tab_t1_edSalesAcctID", "Sales Account", locator, null);
                SalesAcctIDLabel = new Label(SalesAcctID);
                SalesAcctID.DataField = "SalesAcctID";
                SalesSubID = new Selector("ctl00_phG_tab_t1_edSalesSubID", "Sales Sub.", locator, null);
                SalesSubIDLabel = new Label(SalesSubID);
                SalesSubID.DataField = "SalesSubID";
                DiscountAcctID = new Selector("ctl00_phG_tab_t1_edDiscountAcctID", "Discount Account", locator, null);
                DiscountAcctIDLabel = new Label(DiscountAcctID);
                DiscountAcctID.DataField = "DiscountAcctID";
                DiscountSubID = new Selector("ctl00_phG_tab_t1_edDiscountSubID", "Discount Sub.", locator, null);
                DiscountSubIDLabel = new Label(DiscountSubID);
                DiscountSubID.DataField = "DiscountSubID";
                FreightAcctID = new Selector("ctl00_phG_tab_t1_edFreightAcctID", "Freight Account", locator, null);
                FreightAcctIDLabel = new Label(FreightAcctID);
                FreightAcctID.DataField = "FreightAcctID";
                FreightSubID = new Selector("ctl00_phG_tab_t1_edFreightSubID", "Freight Sub.", locator, null);
                FreightSubIDLabel = new Label(FreightSubID);
                FreightSubID.DataField = "FreightSubID";
                DiscTakenAcctID = new Selector("ctl00_phG_tab_t1_edDiscTakenAcctID", "Cash Discount Account", locator, null);
                DiscTakenAcctIDLabel = new Label(DiscTakenAcctID);
                DiscTakenAcctID.DataField = "DiscTakenAcctID";
                DiscTakenSubID = new Selector("ctl00_phG_tab_t1_edDiscTakenSubID", "Cash Discount Sub.", locator, null);
                DiscTakenSubIDLabel = new Label(DiscTakenSubID);
                DiscTakenSubID.DataField = "DiscTakenSubID";
                PrepaymentAcctID = new Selector("ctl00_phG_tab_t1_edPrepaymentAcctID", "Prepayment Account", locator, null);
                PrepaymentAcctIDLabel = new Label(PrepaymentAcctID);
                PrepaymentAcctID.DataField = "PrepaymentAcctID";
                PrepaymentSubID = new Selector("ctl00_phG_tab_t1_edPrepaymentSubID", "Prepayment Sub.", locator, null);
                PrepaymentSubIDLabel = new Label(PrepaymentSubID);
                PrepaymentSubID.DataField = "PrepaymentSubID";
                COGSAcctID = new Selector("ctl00_phG_tab_t1_edCOGSAcctID", "COGS Account", locator, null);
                COGSAcctIDLabel = new Label(COGSAcctID);
                COGSAcctID.DataField = "COGSAcctID";
                COGSSubID = new Selector("ctl00_phG_tab_t1_edCOGSSubID", "COGS Sub.", locator, null);
                COGSSubIDLabel = new Label(COGSSubID);
                COGSSubID.DataField = "COGSSubID";
                MiscAcctID = new Selector("ctl00_phG_tab_t1_edMiscAcctID", "Misc. Account", locator, null);
                MiscAcctIDLabel = new Label(MiscAcctID);
                MiscAcctID.DataField = "MiscAcctID";
                MiscSubID = new Selector("ctl00_phG_tab_t1_edMiscSubID", "Misc. Sub.", locator, null);
                MiscSubIDLabel = new Label(MiscSubID);
                MiscSubID.DataField = "MiscSubID";
                UnrealizedGainAcctID = new Selector("ctl00_phG_tab_t1_edUnrealizedGainAcctID", "Unrealized Gain Account", locator, null);
                UnrealizedGainAcctIDLabel = new Label(UnrealizedGainAcctID);
                UnrealizedGainAcctID.DataField = "UnrealizedGainAcctID";
                UnrealizedGainSubID = new Selector("ctl00_phG_tab_t1_edUnrealizedGainSubID", "Unrealized Gain Sub.", locator, null);
                UnrealizedGainSubIDLabel = new Label(UnrealizedGainSubID);
                UnrealizedGainSubID.DataField = "UnrealizedGainSubID";
                UnrealizedLossAcctID = new Selector("ctl00_phG_tab_t1_edUnrealizedLossAcctID", "Unrealized Loss Account", locator, null);
                UnrealizedLossAcctIDLabel = new Label(UnrealizedLossAcctID);
                UnrealizedLossAcctID.DataField = "UnrealizedLossAcctID";
                UnrealizedLossSubID = new Selector("ctl00_phG_tab_t1_edUnrealizedLossSubID", "Unrealized Loss Sub.", locator, null);
                UnrealizedLossSubIDLabel = new Label(UnrealizedLossSubID);
                UnrealizedLossSubID.DataField = "UnrealizedLossSubID";
                RetainageAcctID = new Selector("ctl00_phG_tab_t1_edRetainageAcctID", "Retainage Receivable Account", locator, null);
                RetainageAcctIDLabel = new Label(RetainageAcctID);
                RetainageAcctID.DataField = "RetainageAcctID";
                RetainageSubID = new Selector("ctl00_phG_tab_t1_edRetainageSubID", "Retainage Receivable Sub.", locator, null);
                RetainageSubIDLabel = new Label(RetainageSubID);
                RetainageSubID.DataField = "RetainageSubID";
                DataMemberName = "CurCustomerClassRecord";
            }
        }
        
        public class c_customerclassrecord_tab : Container
        {
            
			public Selector LocaleName { get; }
			public Label LocaleNameLabel { get; }
            
            public c_customerclassrecord_tab(string locator, string name) : 
                    base(locator, name)
            {
                LocaleName = new Selector("ctl00_phG_tab_t0_edLocale", "Locale", locator, null);
                LocaleNameLabel = new Label(LocaleName);
                LocaleName.DataField = "LocaleName";
                DataMemberName = "CustomerClassRecord";
            }
        }
        
        public class c_mapping_grid : Grid<c_mapping_grid.c_grid_row, c_mapping_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_mapping_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t2_grid");
                DataMemberName = "Mapping";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t2_grid_fe_gf", "FilterForm");
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
            
            public virtual void AttributeIDEdit()
            {
                Buttons.AttributeIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_grid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AttributeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    AttributeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_grid_lv0_edAttributeID\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "AttributeIDEdit", "ctl00_phG_tab_t2_grid");
                    AttributeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox IsActive { get; }
			public Selector AttributeID { get; }
			public PXTextEdit Description { get; }
			public PXNumberEdit SortOrder { get; }
			public CheckBox Required { get; }
			public CheckBox CSAttribute__IsInternal { get; }
			public DropDown ControlType { get; }
			public PXTextEdit DefaultValue { get; }
			public PXTextEdit EntityClassID { get; }
			public PXTextEdit EntityType { get; }
                
                public c_grid_row(c_mapping_grid grid) : 
                        base(grid)
                {
                    IsActive = new CheckBox("ctl00_phG_tab_t2_grid_ef", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    AttributeID = new Selector("_ctl00_phG_tab_t2_grid_lv0_edAttributeID", "Attribute ID", grid.Locator, "AttributeID");
                    AttributeID.DataField = "AttributeID";
                    Description = new PXTextEdit("ctl00_phG_tab_t2_grid_ei", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                    SortOrder = new PXNumberEdit("ctl00_phG_tab_t2_grid_en", "Sort Order", grid.Locator, "SortOrder");
                    SortOrder.DataField = "SortOrder";
                    Required = new CheckBox("ctl00_phG_tab_t2_grid_ef", "Required", grid.Locator, "Required");
                    Required.DataField = "Required";
                    CSAttribute__IsInternal = new CheckBox("ctl00_phG_tab_t2_grid", "Internal", grid.Locator, "CSAttribute__IsInternal");
                    CSAttribute__IsInternal.DataField = "CSAttribute__IsInternal";
                    ControlType = new DropDown("_ctl00_phG_tab_t2_grid_lv0_ec", "Control Type", grid.Locator, "ControlType");
                    ControlType.DataField = "ControlType";
                    ControlType.Items.Add("1", "Text");
                    ControlType.Items.Add("2", "Combo");
                    ControlType.Items.Add("6", "Multi Select Combo");
                    ControlType.Items.Add("3", "Lookup");
                    ControlType.Items.Add("4", "Checkbox");
                    ControlType.Items.Add("5", "Datetime");
                    DefaultValue = new PXTextEdit("ctl00_phG_tab_t2_grid_ei", "Default Value", grid.Locator, "DefaultValue");
                    DefaultValue.DataField = "DefaultValue";
                    EntityClassID = new PXTextEdit("ctl00_phG_tab_t2_grid_ei", "Entity Class ID", grid.Locator, "EntityClassID");
                    EntityClassID.DataField = "EntityClassID";
                    EntityType = new PXTextEdit("ctl00_phG_tab_t2_grid_ei", "Type", grid.Locator, "EntityType");
                    EntityType.DataField = "EntityType";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter IsActive { get; }
				public SelectorColumnFilter AttributeID { get; }
				public PXTextEditColumnFilter Description { get; }
				public PXNumberEditColumnFilter SortOrder { get; }
				public CheckBoxColumnFilter Required { get; }
				public CheckBoxColumnFilter CSAttribute__IsInternal { get; }
				public DropDownColumnFilter ControlType { get; }
				public PXTextEditColumnFilter DefaultValue { get; }
				public PXTextEditColumnFilter EntityClassID { get; }
				public PXTextEditColumnFilter EntityType { get; }
                
                public c_grid_header(c_mapping_grid grid) : 
                        base(grid)
                {
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    AttributeID = new SelectorColumnFilter(grid.Row.AttributeID);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                    SortOrder = new PXNumberEditColumnFilter(grid.Row.SortOrder);
                    Required = new CheckBoxColumnFilter(grid.Row.Required);
                    CSAttribute__IsInternal = new CheckBoxColumnFilter(grid.Row.CSAttribute__IsInternal);
                    ControlType = new DropDownColumnFilter(grid.Row.ControlType);
                    DefaultValue = new PXTextEditColumnFilter(grid.Row.DefaultValue);
                    EntityClassID = new PXTextEditColumnFilter(grid.Row.EntityClassID);
                    EntityType = new PXTextEditColumnFilter(grid.Row.EntityType);
                }
            }
        }
        
        public class c_mapping_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector AttributeID { get; }
			public Label AttributeIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_mapping_lv0(string locator, string name) : 
                    base(locator, name)
            {
                AttributeID = new Selector("ctl00_phG_tab_t2_grid_lv0_edAttributeID", "Attribute ID", locator, null);
                AttributeIDLabel = new Label(AttributeID);
                AttributeID.DataField = "AttributeID";
                Es = new Selector("ctl00_phG_tab_t2_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t2_grid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t2_grid_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_tab_t2_grid_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "Mapping";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AttributeIDEdit()
            {
                Buttons.AttributeIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AttributeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    AttributeIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_grid_lv0_edAttributeID\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "AttributeIDEdit", "ctl00_phG_tab_t2_grid_lv0");
                    AttributeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
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
                ToolBar = new PxToolBar("ctl00_phG_tab_t3_sp1_gridNS");
                DataMemberName = "NotificationSources";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t3_sp1_gridNS_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNS_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNS_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNS_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNS_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNS_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNS_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNS_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNS_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNS_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNS_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNS_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phG_tab_t3_sp1_gridNS");
                    ContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Active { get; }
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
                    Active = new CheckBox("_ctl00_phG_tab_t3_sp1_gridNS_lv0_chkActive", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    SetupID = new Selector("_ctl00_phG_tab_t3_sp1_gridNS_lv0_edSetupID", "Mailing ID", grid.Locator, "SetupID");
                    SetupID.DataField = "SetupID";
                    NBranchID = new Selector("_ctl00_phG_tab_t3_sp1_gridNS_lv0_edNBranchID", "Branch", grid.Locator, "NBranchID");
                    NBranchID.DataField = "NBranchID";
                    EMailAccountID = new Selector("_ctl00_phG_tab_t3_sp1_gridNS_lv0_edEMailAccountID", "Email Account", grid.Locator, "EMailAccountID");
                    EMailAccountID.DataField = "EMailAccountID";
                    ReportID = new Selector("_ctl00_phG_tab_t3_sp1_gridNS_lv0_edReportID", "Report", grid.Locator, "ReportID");
                    ReportID.DataField = "ReportID";
                    NotificationID = new Selector("_ctl00_phG_tab_t3_sp1_gridNS_lv0_edNotificationID", "Notification Template", grid.Locator, "NotificationID");
                    NotificationID.DataField = "NotificationID";
                    Format = new DropDown("_ctl00_phG_tab_t3_sp1_gridNS_lv0_edFormat", "Format", grid.Locator, "Format");
                    Format.DataField = "Format";
                    Format.Items.Add("H", "Html");
                    Format.Items.Add("E", "Excel");
                    Format.Items.Add("P", "PDF");
                    RecipientsBehavior = new DropDown("_ctl00_phG_tab_t3_sp1_gridNS_lv0_ec", "Recipients", grid.Locator, "RecipientsBehavior");
                    RecipientsBehavior.DataField = "RecipientsBehavior";
                    RecipientsBehavior.Items.Add("O", "Override Recipients");
                    RecipientsBehavior.Items.Add("A", "Add Recipients");
                    SourceID = new PXNumberEdit("ctl00_phG_tab_t3_sp1_gridNS_en", "SourceID", grid.Locator, "SourceID");
                    SourceID.DataField = "SourceID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Active { get; }
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
                Format = new DropDown("ctl00_phG_tab_t3_sp1_gridNS_lv0_edFormat", "Format", locator, null);
                FormatLabel = new Label(Format);
                Format.DataField = "Format";
                Format.Items.Add("H", "Html");
                Format.Items.Add("E", "Excel");
                Format.Items.Add("P", "PDF");
                NBranchID = new Selector("ctl00_phG_tab_t3_sp1_gridNS_lv0_edNBranchID", "Branch", locator, null);
                NBranchIDLabel = new Label(NBranchID);
                NBranchID.DataField = "NBranchID";
                Active = new CheckBox("ctl00_phG_tab_t3_sp1_gridNS_lv0_chkActive", "Active", locator, null);
                ActiveLabel = new Label(Active);
                Active.DataField = "Active";
                SetupID = new Selector("ctl00_phG_tab_t3_sp1_gridNS_lv0_edSetupID", "Mailing ID", locator, null);
                SetupIDLabel = new Label(SetupID);
                SetupID.DataField = "SetupID";
                ReportID = new Selector("ctl00_phG_tab_t3_sp1_gridNS_lv0_edReportID", "Report", locator, null);
                ReportIDLabel = new Label(ReportID);
                ReportID.DataField = "ReportID";
                NotificationID = new Selector("ctl00_phG_tab_t3_sp1_gridNS_lv0_edNotificationID", "Notification Template", locator, null);
                NotificationIDLabel = new Label(NotificationID);
                NotificationID.DataField = "NotificationID";
                EMailAccountID = new Selector("ctl00_phG_tab_t3_sp1_gridNS_lv0_edEMailAccountID", "Email Account", locator, null);
                EMailAccountIDLabel = new Label(EMailAccountID);
                EMailAccountID.DataField = "EMailAccountID";
                Es = new Selector("ctl00_phG_tab_t3_sp1_gridNS_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t3_sp1_gridNS_lv0_ec", "Ec", locator, null);
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
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phG_tab_t3_sp1_gridNS_lv0");
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
                ToolBar = new PxToolBar("ctl00_phG_tab_t3_sp1_gridNR");
                DataMemberName = "NotificationRecipients";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t3_sp1_gridNR_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNR_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNR_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNR_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNR_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNR_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNR_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNR_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNR_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNR_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNR_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_sp1_gridNR_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phG_tab_t3_sp1_gridNR");
                    ContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Active { get; }
			public DropDown ContactType { get; }
			public PXNumberEdit OriginalContactID { get; }
			public Selector ContactID { get; }
			public DropDown Format { get; }
			public DropDown AddTo { get; }
			public PXNumberEdit NotificationID { get; }
                
                public c_grid_row(c_notificationrecipients_gridnr grid) : 
                        base(grid)
                {
                    Active = new CheckBox("ctl00_phG_tab_t3_sp1_gridNR_ef", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    ContactType = new DropDown("_ctl00_phG_tab_t3_sp1_gridNR_lv0_ec", "Contact Type", grid.Locator, "ContactType");
                    ContactType.DataField = "ContactType";
                    ContactType.Items.Add("P", "Primary");
                    ContactType.Items.Add("B", "Billing");
                    ContactType.Items.Add("S", "Shipping");
                    ContactType.Items.Add("E", "Employee");
                    OriginalContactID = new PXNumberEdit("ctl00_phG_tab_t3_sp1_gridNR_en", "OriginalContactID", grid.Locator, "OriginalContactID");
                    OriginalContactID.DataField = "OriginalContactID";
                    ContactID = new Selector("_ctl00_phG_tab_t3_sp1_gridNR_lv0_edContactID", "Contact ID", grid.Locator, "ContactID");
                    ContactID.DataField = "ContactID";
                    Format = new DropDown("_ctl00_phG_tab_t3_sp1_gridNR_lv0_ec", "Format", grid.Locator, "Format");
                    Format.DataField = "Format";
                    Format.Items.Add("H", "Html");
                    Format.Items.Add("E", "Excel");
                    Format.Items.Add("P", "PDF");
                    AddTo = new DropDown("_ctl00_phG_tab_t3_sp1_gridNR_lv0_ec", "Add To", grid.Locator, "AddTo");
                    AddTo.DataField = "AddTo";
                    AddTo.Items.Add("T", "To");
                    AddTo.Items.Add("C", "Cc");
                    AddTo.Items.Add("B", "Bcc");
                    NotificationID = new PXNumberEdit("ctl00_phG_tab_t3_sp1_gridNR_en", "NotificationID", grid.Locator, "NotificationID");
                    NotificationID.DataField = "NotificationID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Active { get; }
				public DropDownColumnFilter ContactType { get; }
				public PXNumberEditColumnFilter OriginalContactID { get; }
				public SelectorColumnFilter ContactID { get; }
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
                    Format = new DropDownColumnFilter(grid.Row.Format);
                    AddTo = new DropDownColumnFilter(grid.Row.AddTo);
                    NotificationID = new PXNumberEditColumnFilter(grid.Row.NotificationID);
                }
            }
        }
        
        public class c_notificationrecipients_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector ContactID { get; }
			public Label ContactIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_notificationrecipients_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ContactID = new Selector("ctl00_phG_tab_t3_sp1_gridNR_lv0_edContactID", "Contact ID", locator, null);
                ContactIDLabel = new Label(ContactID);
                ContactID.DataField = "ContactID";
                Es = new Selector("ctl00_phG_tab_t3_sp1_gridNR_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t3_sp1_gridNR_lv0_ec", "Ec", locator, null);
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
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phG_tab_t3_sp1_gridNR_lv0");
                    ContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_billingcycles_gridbillingcycles : Grid<c_billingcycles_gridbillingcycles.c_grid_row, c_billingcycles_gridbillingcycles.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_billingcycles_gridbillingcycles(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t4_gridBillingCycles");
                DataMemberName = "BillingCycles";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t4_gridBillingCycles_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridBillingCycles_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridBillingCycles_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridBillingCycles_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridBillingCycles_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridBillingCycles_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridBillingCycles_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridBillingCycles_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridBillingCycles_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridBillingCycles_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridBillingCycles_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_gridBillingCycles_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit SrvOrdType { get; }
			public PXTextEdit BillingCycleID { get; }
			public PXTextEdit SendInvoicesTo { get; }
			public PXTextEdit BillShipmentSource { get; }
			public PXTextEdit FrequencyType { get; }
                
                public c_grid_row(c_billingcycles_gridbillingcycles grid) : 
                        base(grid)
                {
                    SrvOrdType = new PXTextEdit("ctl00_phG_tab_t4_gridBillingCycles_ei", "Srv Ord Type", grid.Locator, "SrvOrdType");
                    SrvOrdType.DataField = "SrvOrdType";
                    BillingCycleID = new PXTextEdit("ctl00_phG_tab_t4_gridBillingCycles_ei", "Billing Cycle ID", grid.Locator, "BillingCycleID");
                    BillingCycleID.DataField = "BillingCycleID";
                    SendInvoicesTo = new PXTextEdit("ctl00_phG_tab_t4_gridBillingCycles_ei", "Send Invoices To", grid.Locator, "SendInvoicesTo");
                    SendInvoicesTo.DataField = "SendInvoicesTo";
                    BillShipmentSource = new PXTextEdit("ctl00_phG_tab_t4_gridBillingCycles_ei", "Bill Shipment Source", grid.Locator, "BillShipmentSource");
                    BillShipmentSource.DataField = "BillShipmentSource";
                    FrequencyType = new PXTextEdit("ctl00_phG_tab_t4_gridBillingCycles_ei", "Frequency Type", grid.Locator, "FrequencyType");
                    FrequencyType.DataField = "FrequencyType";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter SrvOrdType { get; }
				public PXTextEditColumnFilter BillingCycleID { get; }
				public PXTextEditColumnFilter SendInvoicesTo { get; }
				public PXTextEditColumnFilter BillShipmentSource { get; }
				public PXTextEditColumnFilter FrequencyType { get; }
                
                public c_grid_header(c_billingcycles_gridbillingcycles grid) : 
                        base(grid)
                {
                    SrvOrdType = new PXTextEditColumnFilter(grid.Row.SrvOrdType);
                    BillingCycleID = new PXTextEditColumnFilter(grid.Row.BillingCycleID);
                    SendInvoicesTo = new PXTextEditColumnFilter(grid.Row.SendInvoicesTo);
                    BillShipmentSource = new PXTextEditColumnFilter(grid.Row.BillShipmentSource);
                    FrequencyType = new PXTextEditColumnFilter(grid.Row.FrequencyType);
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
    }
}
