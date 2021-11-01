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
    
    
    public class AP201000_VendorClassMaint : Wrapper
    {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        protected c_vendorclassrecord_form VendorClassRecord_form { get; } = new c_vendorclassrecord_form("ctl00_phF_form", "VendorClassRecord_form");
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
        protected c_curvendorclassrecord_tab CurVendorClassRecord_tab { get; } = new c_curvendorclassrecord_tab("ctl00_phG_tab", "CurVendorClassRecord_tab");
        protected c_vendorclassrecord_tab VendorClassRecord_tab { get; } = new c_vendorclassrecord_tab("ctl00_phG_tab", "VendorClassRecord_tab");
        protected c_mapping_grid Mapping_grid { get; } = new c_mapping_grid("ctl00_phG_tab_t2_grid", "Mapping_grid");
        protected c_mapping_lv0 Mapping_lv0 { get; } = new c_mapping_lv0("ctl00_phG_tab_t2_grid_lv0", "Mapping_lv0");
        protected c_notificationsources_gridns NotificationSources_gridNS { get; } = new c_notificationsources_gridns("ctl00_phG_tab_t3_sp1_gridNS", "NotificationSources_gridNS");
        protected c_notificationsources_lv0 NotificationSources_lv0 { get; } = new c_notificationsources_lv0("ctl00_phG_tab_t3_sp1_gridNS_lv0", "NotificationSources_lv0");
        protected c_notificationrecipients_gridnr NotificationRecipients_gridNR { get; } = new c_notificationrecipients_gridnr("ctl00_phG_tab_t3_sp1_gridNR", "NotificationRecipients_gridNR");
        protected c_notificationrecipients_lv0 NotificationRecipients_lv0 { get; } = new c_notificationrecipients_lv0("ctl00_phG_tab_t3_sp1_gridNR_lv0", "NotificationRecipients_lv0");
        protected c_lienwaiverrecipientprojects_pxgridprojects LienWaiverRecipientProjects_PXGridProjects { get; } = new c_lienwaiverrecipientprojects_pxgridprojects("ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects", "LienWaiverRecipientProjects_PXGridProjects");
        protected c_lienwaiverrecipientprojects_lv0 LienWaiverRecipientProjects_lv0 { get; } = new c_lienwaiverrecipientprojects_lv0("ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_lv0", "LienWaiverRecipientProjects_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        
        public AP201000_VendorClassMaint()
        {
            ScreenId = "AP201000";
            ScreenUrl = "/Pages/AP/AP201000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual AP201000_VendorClassMaint ReadOne(Gate gate, string VendorClassID)
        {
            new BiObject<AP201000_VendorClassMaint>(gate).ReadOne(this, VendorClassID);
            return this;
        }
        
        public virtual AP201000_VendorClassMaint ReadOne(string VendorClassID)
        {
            return this.ReadOne(ApiConnection.Source, VendorClassID);
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
        
        public virtual void Edit()
        {
            ToolBar.Edit.Click();
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
        
        public virtual void Delete()
        {
            ToolBar.Delete.Click();
        }
        
        public virtual void First()
        {
            ToolBar.First.Click();
        }
        
        public virtual void Prev()
        {
            ToolBar.Prev.Click();
        }
        
        public virtual void Next()
        {
            ToolBar.Next.Click();
        }
        
        public virtual void Last()
        {
            ToolBar.Last.Click();
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
        
        public virtual void ActionsMenu()
        {
            ToolBar.ActionsMenu.Click();
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
			public ToolBarButton Edit { get; }
			public ToolBarButton CopyDocument { get; }
			public ToolBarButton PasteDocument { get; }
			public ToolBarButton SaveTemplate { get; }
			public ToolBarButton Delete { get; }
			public ToolBarButton First { get; }
			public ToolBarButton Prev { get; }
			public ToolBarButton Next { get; }
			public ToolBarButton Last { get; }
			public ToolBarButton ResetGroup { get; }
			public ToolBarButton ActionsMenu { get; }
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
                Edit = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Edit", "Clipboard", locator, null);
                CopyDocument = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_Edit@CopyDocument\']", "CopyDocument", locator, Edit);
                PasteDocument = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_Edit@PasteDocument\']", "PasteDocument", locator, Edit);
                SaveTemplate = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_Edit@SaveTemplate\']", "SaveTemplate", locator, Edit);
                Delete = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Delete", "Delete (Ctrl+Del).", locator, null);
                Delete.ConfirmAction = () => Alert.AlertToException("The current Vendor Class record will be deleted.");
                First = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_First", "Go to First Record", locator, null);
                Prev = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Prev", "Go to Previous Record (PgUp)", locator, null);
                Next = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Next", "Go to Next Record (PgDn)", locator, null);
                Last = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Last", "Go to Last Record", locator, null);
                ResetGroup = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ResetGroup", "Include Vendors in Restriction Group", locator, null);
                ResetGroup.WaitAction = Wait.WaitForLongOperationToComplete;
                ActionsMenu = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ActionsMenu", "Actions", locator, MenuOpener);
                LongRun = new ToolBarButton("css=qp-long-run", "Nothing in progress", locator, null);
                LongrunCancel = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_cancel", "Cancel", locator, null);
                LongrunTimer = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_timer", "Elapsed Time", locator, null);
            }
        }
        
        public class c_vendorclassrecord_form : Container
        {
            
			public Selector VendorClassID { get; }
			public Label VendorClassIDLabel { get; }
			public PXTextEdit Descr { get; }
			public Label DescrLabel { get; }
            
            public c_vendorclassrecord_form(string locator, string name) : 
                    base(locator, name)
            {
                VendorClassID = new Selector("ctl00_phF_form_edVendorClassID", "Class ID", locator, null);
                VendorClassIDLabel = new Label(VendorClassID);
                VendorClassID.DataField = "VendorClassID";
                Descr = new PXTextEdit("ctl00_phF_form_edDescr", "Description", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                DataMemberName = "VendorClassRecord";
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
        
        public class c_curvendorclassrecord_tab : Container
        {
            
            public PxButtonCollection Buttons;
            
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
			public CheckBox DefaultLocationCDFromBranch { get; }
			public Label DefaultLocationCDFromBranchLabel { get; }
			public Selector GroupMask { get; }
			public Label GroupMaskLabel { get; }
			public Selector ShipTermsID { get; }
			public Label ShipTermsIDLabel { get; }
			public DropDown RcptQtyAction { get; }
			public Label RcptQtyActionLabel { get; }
			public Selector TermsID { get; }
			public Label TermsIDLabel { get; }
			public Selector PaymentMethodID { get; }
			public Label PaymentMethodIDLabel { get; }
			public Selector CashAcctID { get; }
			public Label CashAcctIDLabel { get; }
			public DropDown PaymentByType { get; }
			public Label PaymentByTypeLabel { get; }
			public Selector CuryID { get; }
			public Label CuryIDLabel { get; }
			public CheckBox AllowOverrideCury { get; }
			public Label AllowOverrideCuryLabel { get; }
			public Selector CuryRateTypeID { get; }
			public Label CuryRateTypeIDLabel { get; }
			public CheckBox AllowOverrideRate { get; }
			public Label AllowOverrideRateLabel { get; }
			public CheckBox PaymentsByLinesAllowed { get; }
			public Label PaymentsByLinesAllowedLabel { get; }
			public CheckBox RetainageApply { get; }
			public Label RetainageApplyLabel { get; }
			public CheckBox PrintPO { get; }
			public Label PrintPOLabel { get; }
			public CheckBox EmailPO { get; }
			public Label EmailPOLabel { get; }
			public CheckBox ShouldGenerateLienWaivers { get; }
			public Label ShouldGenerateLienWaiversLabel { get; }
			public Selector APAcctID { get; }
			public Label APAcctIDLabel { get; }
			public Selector APSubID { get; }
			public Label APSubIDLabel { get; }
			public Selector ExpenseAcctID { get; }
			public Label ExpenseAcctIDLabel { get; }
			public Selector ExpenseSubID { get; }
			public Label ExpenseSubIDLabel { get; }
			public Selector DiscountAcctID { get; }
			public Label DiscountAcctIDLabel { get; }
			public Selector DiscountSubID { get; }
			public Label DiscountSubIDLabel { get; }
			public Selector DiscTakenAcctID { get; }
			public Label DiscTakenAcctIDLabel { get; }
			public Selector DiscTakenSubID { get; }
			public Label DiscTakenSubIDLabel { get; }
			public Selector PrepaymentAcctID { get; }
			public Label PrepaymentAcctIDLabel { get; }
			public Selector PrepaymentSubID { get; }
			public Label PrepaymentSubIDLabel { get; }
			public Selector PrebookAcctID { get; }
			public Label PrebookAcctIDLabel { get; }
			public Selector PrebookSubID { get; }
			public Label PrebookSubIDLabel { get; }
			public Selector POAccrualAcctID { get; }
			public Label POAccrualAcctIDLabel { get; }
			public Selector POAccrualSubID { get; }
			public Label POAccrualSubIDLabel { get; }
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
            
            public c_curvendorclassrecord_tab(string locator, string name) : 
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
                DefaultLocationCDFromBranch = new CheckBox("ctl00_phG_tab_t0_chkDefaultLocationCDFromBranch", "Default Location ID from Branch", locator, null);
                DefaultLocationCDFromBranchLabel = new Label(DefaultLocationCDFromBranch);
                DefaultLocationCDFromBranch.DataField = "DefaultLocationCDFromBranch";
                GroupMask = new Selector("ctl00_phG_tab_t0_edGroupMask", "Default Restriction Group", locator, null);
                GroupMaskLabel = new Label(GroupMask);
                GroupMask.DataField = "GroupMask";
                ShipTermsID = new Selector("ctl00_phG_tab_t0_edShipTermsID", "Shipping Terms", locator, null);
                ShipTermsIDLabel = new Label(ShipTermsID);
                ShipTermsID.DataField = "ShipTermsID";
                RcptQtyAction = new DropDown("ctl00_phG_tab_t0_edRcptQtyAction", "Receipt Action", locator, null);
                RcptQtyActionLabel = new Label(RcptQtyAction);
                RcptQtyAction.DataField = "RcptQtyAction";
                RcptQtyAction.Items.Add("R", "Reject");
                RcptQtyAction.Items.Add("W", "Accept but Warn");
                RcptQtyAction.Items.Add("A", "Accept");
                TermsID = new Selector("ctl00_phG_tab_t0_edTermsID", "Terms", locator, null);
                TermsIDLabel = new Label(TermsID);
                TermsID.DataField = "TermsID";
                PaymentMethodID = new Selector("ctl00_phG_tab_t0_edPaymentMethodID", "Payment Method", locator, null);
                PaymentMethodIDLabel = new Label(PaymentMethodID);
                PaymentMethodID.DataField = "PaymentMethodID";
                CashAcctID = new Selector("ctl00_phG_tab_t0_edCashAcctID", "Cash Account", locator, null);
                CashAcctIDLabel = new Label(CashAcctID);
                CashAcctID.DataField = "CashAcctID";
                PaymentByType = new DropDown("ctl00_phG_tab_t0_edPaymentByType", "Payment By", locator, null);
                PaymentByTypeLabel = new Label(PaymentByType);
                PaymentByType.DataField = "PaymentByType";
                PaymentByType.Items.Add("0", "Due Date");
                PaymentByType.Items.Add("1", "Discount Date");
                CuryID = new Selector("ctl00_phG_tab_t0_edCuryID", "Currency ID", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                AllowOverrideCury = new CheckBox("ctl00_phG_tab_t0_chkAllowOverrideCury", "Enable Currency Override", locator, null);
                AllowOverrideCuryLabel = new Label(AllowOverrideCury);
                AllowOverrideCury.DataField = "AllowOverrideCury";
                CuryRateTypeID = new Selector("ctl00_phG_tab_t0_edCuryRateTypeID", "Curr. Rate Type", locator, null);
                CuryRateTypeIDLabel = new Label(CuryRateTypeID);
                CuryRateTypeID.DataField = "CuryRateTypeID";
                AllowOverrideRate = new CheckBox("ctl00_phG_tab_t0_chkAllowOverrideRate", "Enable Rate Override", locator, null);
                AllowOverrideRateLabel = new Label(AllowOverrideRate);
                AllowOverrideRate.DataField = "AllowOverrideRate";
                PaymentsByLinesAllowed = new CheckBox("ctl00_phG_tab_t0_chkPaymentsByLinesAllowed", "Pay by Line", locator, null);
                PaymentsByLinesAllowedLabel = new Label(PaymentsByLinesAllowed);
                PaymentsByLinesAllowed.DataField = "PaymentsByLinesAllowed";
                RetainageApply = new CheckBox("ctl00_phG_tab_t0_chkRetainageApply", "Apply Retainage", locator, null);
                RetainageApplyLabel = new Label(RetainageApply);
                RetainageApply.DataField = "RetainageApply";
                PrintPO = new CheckBox("ctl00_phG_tab_t0_chkPrintPO", "Print Orders", locator, null);
                PrintPOLabel = new Label(PrintPO);
                PrintPO.DataField = "PrintPO";
                EmailPO = new CheckBox("ctl00_phG_tab_t0_chkEmailPO", "Send Orders by Email", locator, null);
                EmailPOLabel = new Label(EmailPO);
                EmailPO.DataField = "EmailPO";
                ShouldGenerateLienWaivers = new CheckBox("ctl00_phG_tab_t0_chkShouldGenerateLienWaivers", "Generate Lien Waivers Automatically", locator, null);
                ShouldGenerateLienWaiversLabel = new Label(ShouldGenerateLienWaivers);
                ShouldGenerateLienWaivers.DataField = "ShouldGenerateLienWaivers";
                APAcctID = new Selector("ctl00_phG_tab_t1_edAPAcctID", "AP Account", locator, null);
                APAcctIDLabel = new Label(APAcctID);
                APAcctID.DataField = "APAcctID";
                APSubID = new Selector("ctl00_phG_tab_t1_edAPSubID", "AP Subaccount", locator, null);
                APSubIDLabel = new Label(APSubID);
                APSubID.DataField = "APSubID";
                ExpenseAcctID = new Selector("ctl00_phG_tab_t1_edExpenseAcctID", "Expense Account", locator, null);
                ExpenseAcctIDLabel = new Label(ExpenseAcctID);
                ExpenseAcctID.DataField = "ExpenseAcctID";
                ExpenseSubID = new Selector("ctl00_phG_tab_t1_edExpenseSubID", "Expense Subaccount", locator, null);
                ExpenseSubIDLabel = new Label(ExpenseSubID);
                ExpenseSubID.DataField = "ExpenseSubID";
                DiscountAcctID = new Selector("ctl00_phG_tab_t1_edDiscountAcctID", "Discount Account", locator, null);
                DiscountAcctIDLabel = new Label(DiscountAcctID);
                DiscountAcctID.DataField = "DiscountAcctID";
                DiscountSubID = new Selector("ctl00_phG_tab_t1_edDiscountSubID", "Discount Subaccount", locator, null);
                DiscountSubIDLabel = new Label(DiscountSubID);
                DiscountSubID.DataField = "DiscountSubID";
                DiscTakenAcctID = new Selector("ctl00_phG_tab_t1_edDiscTakenAcctID", "Cash Discount Account", locator, null);
                DiscTakenAcctIDLabel = new Label(DiscTakenAcctID);
                DiscTakenAcctID.DataField = "DiscTakenAcctID";
                DiscTakenSubID = new Selector("ctl00_phG_tab_t1_edDiscTakenSubID", "Cash Discount Sub.", locator, null);
                DiscTakenSubIDLabel = new Label(DiscTakenSubID);
                DiscTakenSubID.DataField = "DiscTakenSubID";
                PrepaymentAcctID = new Selector("ctl00_phG_tab_t1_edPrepaymentAcctID", "Prepayment Account", locator, null);
                PrepaymentAcctIDLabel = new Label(PrepaymentAcctID);
                PrepaymentAcctID.DataField = "PrepaymentAcctID";
                PrepaymentSubID = new Selector("ctl00_phG_tab_t1_edPrepaymentSubID", "Prepayment Subaccount", locator, null);
                PrepaymentSubIDLabel = new Label(PrepaymentSubID);
                PrepaymentSubID.DataField = "PrepaymentSubID";
                PrebookAcctID = new Selector("ctl00_phG_tab_t1_edPrebookAcctID", "Reclassification Account", locator, null);
                PrebookAcctIDLabel = new Label(PrebookAcctID);
                PrebookAcctID.DataField = "PrebookAcctID";
                PrebookSubID = new Selector("ctl00_phG_tab_t1_edPrebookSubID", "Reclassification Subaccount", locator, null);
                PrebookSubIDLabel = new Label(PrebookSubID);
                PrebookSubID.DataField = "PrebookSubID";
                POAccrualAcctID = new Selector("ctl00_phG_tab_t1_edPOAccrualAcctID", "PO Accrual Account", locator, null);
                POAccrualAcctIDLabel = new Label(POAccrualAcctID);
                POAccrualAcctID.DataField = "POAccrualAcctID";
                POAccrualSubID = new Selector("ctl00_phG_tab_t1_edPOAccrualSubID", "PO Accrual Subaccount", locator, null);
                POAccrualSubIDLabel = new Label(POAccrualSubID);
                POAccrualSubID.DataField = "POAccrualSubID";
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
                RetainageAcctID = new Selector("ctl00_phG_tab_t1_edRetainageAcctID", "Retainage Payable Account", locator, null);
                RetainageAcctIDLabel = new Label(RetainageAcctID);
                RetainageAcctID.DataField = "RetainageAcctID";
                RetainageSubID = new Selector("ctl00_phG_tab_t1_edRetainageSubID", "Retainage Payable Sub.", locator, null);
                RetainageSubIDLabel = new Label(RetainageSubID);
                RetainageSubID.DataField = "RetainageSubID";
                DataMemberName = "CurVendorClassRecord";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void CountryIDEdit()
            {
                Buttons.CountryIDEdit.Click();
            }
            
            public virtual void TaxZoneIDEdit()
            {
                Buttons.TaxZoneIDEdit.Click();
            }
            
            public virtual void TermsIDEdit()
            {
                Buttons.TermsIDEdit.Click();
            }
            
            public virtual void PaymentMethodIDEdit()
            {
                Buttons.PaymentMethodIDEdit.Click();
            }
            
            public virtual void CashAcctIDEdit()
            {
                Buttons.CashAcctIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button CountryIDEdit { get; }
			public Button TaxZoneIDEdit { get; }
			public Button TermsIDEdit { get; }
			public Button PaymentMethodIDEdit { get; }
			public Button CashAcctIDEdit { get; }
                
                public PxButtonCollection()
                {
                    CountryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edCountryID\'] div[class=\'editBtnCont\'] > div > div", "CountryIDEdit", "ctl00_phG_tab");
                    CountryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    TaxZoneIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edTaxZoneID\'] div[class=\'editBtnCont\'] > div > div", "TaxZoneIDEdit", "ctl00_phG_tab");
                    TaxZoneIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    TermsIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edTermsID\'] div[class=\'editBtnCont\'] > div > div", "TermsIDEdit", "ctl00_phG_tab");
                    TermsIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PaymentMethodIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edPaymentMethodID\'] div[class=\'editBtnCont\'] > div >" +
                            " div", "PaymentMethodIDEdit", "ctl00_phG_tab");
                    PaymentMethodIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    CashAcctIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_edCashAcctID\'] div[class=\'editBtnCont\'] > div > div", "CashAcctIDEdit", "ctl00_phG_tab");
                    CashAcctIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_vendorclassrecord_tab : Container
        {
            
			public Selector LocaleName { get; }
			public Label LocaleNameLabel { get; }
            
            public c_vendorclassrecord_tab(string locator, string name) : 
                    base(locator, name)
            {
                LocaleName = new Selector("ctl00_phG_tab_t0_edLocale", "Locale", locator, null);
                LocaleNameLabel = new Label(LocaleName);
                LocaleName.DataField = "LocaleName";
                DataMemberName = "VendorClassRecord";
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
                    ContactType.Items.Add("R", "Remittance");
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
        
        public class c_lienwaiverrecipientprojects_pxgridprojects : Grid<c_lienwaiverrecipientprojects_pxgridprojects.c_grid_row, c_lienwaiverrecipientprojects_pxgridprojects.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_lienwaiverrecipientprojects_pxgridprojects(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects");
                DataMemberName = "LienWaiverRecipientProjects";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_at_tlb div[data-c" +
                            "md=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_at_tlb div[data-c" +
                            "md=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_at_tlb div[data-c" +
                            "md=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_at_tlb div[data-c" +
                            "md=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_ab_tlb div[data-c" +
                            "md=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_ab_tlb div[data-c" +
                            "md=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_ab_tlb div[data-c" +
                            "md=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_ab_tlb div[data-c" +
                            "md=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_ab_tlb div[data-c" +
                            "md=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_LienWaiverRecipientProjectsDialog_btnOK", "Add", "ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects");
                    Cancel = new Button("ctl00_phG_LienWaiverRecipientProjectsDialog_btnCancel", "Cancel", "ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public PXTextEdit PMProject__ContractCD { get; }
			public PXTextEdit PMProject__Status { get; }
			public PXTextEdit PMProject__CustomerID { get; }
			public PXTextEdit PMProject__Description { get; }
			public PXTextEdit PMProject__CustomerID_Customer_acctName { get; }
			public PXTextEdit PMProject__CuryID { get; }
			public PXNumberEdit MinimumCommitmentAmount { get; }
                
                public c_grid_row(c_lienwaiverrecipientprojects_pxgridprojects grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_ei", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    PMProject__ContractCD = new PXTextEdit("ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_ei", "PM Project __ Contract CD", grid.Locator, "PMProject__ContractCD");
                    PMProject__ContractCD.DataField = "PMProject__ContractCD";
                    PMProject__Status = new PXTextEdit("ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_ei", "PM Project __ Status", grid.Locator, "PMProject__Status");
                    PMProject__Status.DataField = "PMProject__Status";
                    PMProject__CustomerID = new PXTextEdit("ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_ei", "PM Project __ Customer ID", grid.Locator, "PMProject__CustomerID");
                    PMProject__CustomerID.DataField = "PMProject__CustomerID";
                    PMProject__Description = new PXTextEdit("ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_ei", "PM Project __ Description", grid.Locator, "PMProject__Description");
                    PMProject__Description.DataField = "PMProject__Description";
                    PMProject__CustomerID_Customer_acctName = new PXTextEdit("ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_ei", "PM Project __ Customer ID _ Customer _acct Name", grid.Locator, "PMProject__CustomerID_Customer_acctName");
                    PMProject__CustomerID_Customer_acctName.DataField = "PMProject__CustomerID_Customer_acctName";
                    PMProject__CuryID = new PXTextEdit("ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_ei", "PM Project __ Cury ID", grid.Locator, "PMProject__CuryID");
                    PMProject__CuryID.DataField = "PMProject__CuryID";
                    MinimumCommitmentAmount = new PXNumberEdit("_ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_lv0_PXNumberEdit3", "Minimum Commitment Amount", grid.Locator, "MinimumCommitmentAmount");
                    MinimumCommitmentAmount.DataField = "MinimumCommitmentAmount";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter PMProject__ContractCD { get; }
				public PXTextEditColumnFilter PMProject__Status { get; }
				public PXTextEditColumnFilter PMProject__CustomerID { get; }
				public PXTextEditColumnFilter PMProject__Description { get; }
				public PXTextEditColumnFilter PMProject__CustomerID_Customer_acctName { get; }
				public PXTextEditColumnFilter PMProject__CuryID { get; }
				public PXNumberEditColumnFilter MinimumCommitmentAmount { get; }
                
                public c_grid_header(c_lienwaiverrecipientprojects_pxgridprojects grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    PMProject__ContractCD = new PXTextEditColumnFilter(grid.Row.PMProject__ContractCD);
                    PMProject__Status = new PXTextEditColumnFilter(grid.Row.PMProject__Status);
                    PMProject__CustomerID = new PXTextEditColumnFilter(grid.Row.PMProject__CustomerID);
                    PMProject__Description = new PXTextEditColumnFilter(grid.Row.PMProject__Description);
                    PMProject__CustomerID_Customer_acctName = new PXTextEditColumnFilter(grid.Row.PMProject__CustomerID_Customer_acctName);
                    PMProject__CuryID = new PXTextEditColumnFilter(grid.Row.PMProject__CuryID);
                    MinimumCommitmentAmount = new PXNumberEditColumnFilter(grid.Row.MinimumCommitmentAmount);
                }
            }
        }
        
        public class c_lienwaiverrecipientprojects_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit MinimumCommitmentAmount { get; }
			public Label MinimumCommitmentAmountLabel { get; }
            
            public c_lienwaiverrecipientprojects_lv0(string locator, string name) : 
                    base(locator, name)
            {
                MinimumCommitmentAmount = new PXNumberEdit("ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_lv0_PXNumberEdit3", "Minimum Commitment Amount", locator, null);
                MinimumCommitmentAmountLabel = new Label(MinimumCommitmentAmount);
                MinimumCommitmentAmount.DataField = "MinimumCommitmentAmount";
                DataMemberName = "LienWaiverRecipientProjects";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Add()
            {
                Buttons.Add.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_LienWaiverRecipientProjectsDialog_btnOK", "Add", "ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_lv0");
                    Cancel = new Button("ctl00_phG_LienWaiverRecipientProjectsDialog_btnCancel", "Cancel", "ctl00_phG_LienWaiverRecipientProjectsDialog_PXGridProjects_lv0");
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
