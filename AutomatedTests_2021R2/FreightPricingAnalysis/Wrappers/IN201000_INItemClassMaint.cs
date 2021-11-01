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
using Controls.TreeView;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace GeneratedWrappers.Acumatica
{
    
    
    public class IN201000_INItemClassMaint : Wrapper
    {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
        protected c_itemclass_form Itemclass_form { get; } = new c_itemclass_form("ctl00_phG_sp1_scrollForm_form", "itemclass_form");
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
        protected c_itemclasssettings_tab Itemclasssettings_tab { get; } = new c_itemclasssettings_tab("ctl00_phG_sp1_scrollForm_tab", "itemclasssettings_tab");
        protected c_itemclasssettings_pxformview3 Itemclasssettings_pxformview3 { get; } = new c_itemclasssettings_pxformview3("ctl00_phG_sp1_scrollForm_tab_t1_PXFormView3", "itemclasssettings_PXFormView3");
        protected c_itemclasssettings_formequipment Itemclasssettings_formequipment { get; } = new c_itemclasssettings_formequipment("ctl00_phG_sp1_scrollForm_tab_t4_formEquipment", "itemclasssettings_formEquipment");
        protected c_treeviewandprimaryviewsynchronizationhelper_syncform TreeViewAndPrimaryViewSynchronizationHelper_syncForm { get; } = new c_treeviewandprimaryviewsynchronizationhelper_syncform("ctl00_phG_syncForm", "TreeViewAndPrimaryViewSynchronizationHelper_syncForm");
        protected c_itemclasscurysettings_curysettingsformdefaultsite Itemclasscurysettings_curysettingsformdefaultsite { get; } = new c_itemclasscurysettings_curysettingsformdefaultsite("ctl00_phG_sp1_scrollForm_tab_t0_CurySettingsFormDefaultSite", "itemclasscurysettings_CurySettingsFormDefaultSite");
        protected c_classunits_gridunits Classunits_gridunits { get; } = new c_classunits_gridunits("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits", "classunits_gridUnits");
        protected c_classunits_lv0 Classunits_lv0 { get; } = new c_classunits_lv0("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0", "classunits_lv0");
        protected c_mapping_attributesgrid Mapping_AttributesGrid { get; } = new c_mapping_attributesgrid("ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid", "Mapping_AttributesGrid");
        protected c_mapping_lv0 Mapping_lv0 { get; } = new c_mapping_lv0("ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_lv0", "Mapping_lv0");
        protected c_replenishment_repgrid Replenishment_repgrid { get; } = new c_replenishment_repgrid("ctl00_phG_sp1_scrollForm_tab_t1_repGrid", "replenishment_repGrid");
        protected c_replenishment_lv0 Replenishment_lv0 { get; } = new c_replenishment_lv0("ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0", "replenishment_lv0");
        protected c_groups_grid Groups_grid { get; } = new c_groups_grid("ctl00_phG_sp1_scrollForm_tab_t2_grid", "Groups_grid");
        protected c_groups_lv0 Groups_lv0 { get; } = new c_groups_lv0("ctl00_phG_sp1_scrollForm_tab_t2_grid_lv0", "Groups_lv0");
        protected c_itemclasstree ItemClassTree { get; } = new c_itemclasstree("ctl00_phG_sp1_tree", "ItemClassTree");
        protected c_idgenerationrules_pxgrididgenerationrules IdGenerationRules_PXGridIdGenerationRules { get; } = new c_idgenerationrules_pxgrididgenerationrules("ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules", "IdGenerationRules_PXGridIdGenerationRules");
        protected c_idgenerationrules_lv0 IdGenerationRules_lv0 { get; } = new c_idgenerationrules_lv0("ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_lv0", "IdGenerationRules_lv0");
        protected c_descriptiongenerationrules_pxgriddescriptiongenerationrules DescriptionGenerationRules_PXGridDescriptionGenerationRules { get; } = new c_descriptiongenerationrules_pxgriddescriptiongenerationrules("ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules", "DescriptionGenerationRules_PXGridDescriptionGenerationRules");
        protected c_descriptiongenerationrules_lv0 DescriptionGenerationRules_lv0 { get; } = new c_descriptiongenerationrules_lv0("ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_lv0", "DescriptionGenerationRules_lv0");
        protected c_changeiddialog_formchangeid ChangeIDDialog_formChangeID { get; } = new c_changeiddialog_formchangeid("ctl00_phG_pnlChangeID_formChangeID", "ChangeIDDialog_formChangeID");
        protected c_modeltemplatecomponentrecords_modeltemplatecomponents ModelTemplateComponentRecords_ModelTemplateComponents { get; } = new c_modeltemplatecomponentrecords_modeltemplatecomponents("ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents", "ModelTemplateComponentRecords_ModelTemplateComponents");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        
        public IN201000_INItemClassMaint()
        {
            ScreenId = "IN201000";
            ScreenUrl = "/Pages/IN/IN201000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual IN201000_INItemClassMaint ReadOne(Gate gate, string ItemClassCD)
        {
            new BiObject<IN201000_INItemClassMaint>(gate).ReadOne(this, ItemClassCD);
            return this;
        }
        
        public virtual IN201000_INItemClassMaint ReadOne(string ItemClassCD)
        {
            return this.ReadOne(ApiConnection.Source, ItemClassCD);
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
        
        public virtual void ApplyToChildren()
        {
            ToolBar.ApplyToChildren.Click();
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
        
        public virtual void ViewRestrictionGroups()
        {
            ToolBar.ViewRestrictionGroups.Click();
        }
        
        public virtual void ChangeID()
        {
            ToolBar.ChangeID.Click();
        }
        
        public virtual void Action()
        {
            ToolBar.Action.Click();
        }
        
        public virtual void OtherCategory()
        {
            ToolBar.OtherCategory.Click();
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
			public ToolBarButton ApplyToChildren { get; }
			public ToolBarButton ResetGroup { get; }
			public ToolBarButton ViewRestrictionGroups { get; }
			public ToolBarButton ChangeID { get; }
			public ToolBarButton Action { get; }
			public ToolBarButton OtherCategory { get; }
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
                Save = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Save", "Save (Ctrl+S).", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Cancel", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                Insert = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Insert", "Add New Record (Ctrl+Ins)", locator, null);
                Delete = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_delete", "Delete (Ctrl+Del).", locator, null);
                Delete.ConfirmAction = () => Alert.AlertToException("The current record will be deleted.");
                CopyPaste = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CopyPaste", "Clipboard", locator, null);
                CopyDocument = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@CopyDocument\']", "CopyDocument", locator, CopyPaste);
                PasteDocument = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@PasteDocument\']", "PasteDocument", locator, CopyPaste);
                SaveTemplate = new ToolBarButton("css=[id=\'ctl00_phDS_ds_ToolBar_CopyPaste@SaveTemplate\']", "SaveTemplate", locator, CopyPaste);
                First = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_First", "Go to First Record", locator, null);
                Previous = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Previous", "Go to Previous Record (PgUp)", locator, null);
                Next = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Next", "Go to Next Record (PgDn)", locator, null);
                Last = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Last", "Go to Last Record", locator, null);
                ApplyToChildren = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ApplyToChildren,#ctl00_phDS_ds_ToolBar_ApplyToChildren" +
                        "_item", "Apply to Children", locator, MenuOpener);
                ResetGroup = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ResetGroup,#ctl00_phDS_ds_ToolBar_ResetGroup_item", "Apply Restriction Settings to All Inventory Items", locator, MenuOpener);
                ResetGroup.WaitAction = Wait.WaitForLongOperationToComplete;
                ViewRestrictionGroups = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ViewRestrictionGroups,#ctl00_phDS_ds_ToolBar_ViewRestr" +
                        "ictionGroups_item", "Manage Restriction Groups", locator, MenuOpener);
                ChangeID = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_ChangeID,#ctl00_phDS_ds_ToolBar_ChangeID_item", "Change ID", locator, MenuOpener);
                Action = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Action", "Actions", locator, MenuOpener);
                OtherCategory = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Other_Category", "Other", locator, MenuOpener);
                LongRun = new ToolBarButton("css=qp-long-run", "Nothing in progress", locator, null);
                LongrunCancel = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_cancel", "Cancel", locator, null);
                LongrunTimer = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_timer", "Elapsed Time", locator, null);
            }
        }
        
        public class c_itemclass_form : Container
        {
            
			public Selector ItemClassCD { get; }
			public Label ItemClassCDLabel { get; }
			public InputLocalizable Descr { get; }
			public Label DescrLabel { get; }
			public CheckBox ChkServiceManagement { get; }
			public Label ChkServiceManagementLabel { get; }
            
            public c_itemclass_form(string locator, string name) : 
                    base(locator, name)
            {
                ItemClassCD = new Selector("ctl00_phG_sp1_scrollForm_form_edItemClassID", "Class ID", locator, null);
                ItemClassCDLabel = new Label(ItemClassCD);
                ItemClassCD.DataField = "ItemClassCD";
                Descr = new InputLocalizable("ctl00_phG_sp1_scrollForm_form_edDescr", "Description", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                ChkServiceManagement = new CheckBox("ctl00_phG_sp1_scrollForm_form_chkServiceManagement", "chkServiceManagement", locator, null);
                ChkServiceManagementLabel = new Label(ChkServiceManagement);
                ChkServiceManagement.DataField = "ChkServiceManagement";
                DataMemberName = "itemclass";
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
                    Delete.ConfirmAction = () => Alert.AlertToException("The current record will be deleted.");
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
        
        public class c_itemclasssettings_tab : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox StkItem { get; }
			public Label StkItemLabel { get; }
			public CheckBox NegQty { get; }
			public Label NegQtyLabel { get; }
			public CheckBox AccrueCost { get; }
			public Label AccrueCostLabel { get; }
			public CheckBox ExportToExternal { get; }
			public Label ExportToExternalLabel { get; }
			public DropDown ItemType { get; }
			public Label ItemTypeLabel { get; }
			public DropDown ValMethod { get; }
			public Label ValMethodLabel { get; }
			public DropDown AMReplenishmentSource { get; }
			public Label AMReplenishmentSourceLabel { get; }
			public Selector TaxCategoryID { get; }
			public Label TaxCategoryIDLabel { get; }
			public DropDown TaxCalcMode { get; }
			public Label TaxCalcModeLabel { get; }
			public Selector PostClassID { get; }
			public Label PostClassIDLabel { get; }
			public Selector LotSerClassID { get; }
			public Label LotSerClassIDLabel { get; }
			public Selector PriceClassID { get; }
			public Label PriceClassIDLabel { get; }
			public Selector AvailabilitySchemeID { get; }
			public Label AvailabilitySchemeIDLabel { get; }
			public Selector CountryOfOrigin { get; }
			public Label CountryOfOriginLabel { get; }
			public PXTextEdit HSTariffCode { get; }
			public Label HSTariffCodeLabel { get; }
			public PXNumberEdit UndershipThreshold { get; }
			public Label UndershipThresholdLabel { get; }
			public PXNumberEdit OvershipThreshold { get; }
			public Label OvershipThresholdLabel { get; }
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
			public TreeSelector PriceWorkgroupID { get; }
			public Label PriceWorkgroupIDLabel { get; }
			public Selector PriceManagerID { get; }
			public Label PriceManagerIDLabel { get; }
			public PXNumberEdit MinGrossProfitPct { get; }
			public Label MinGrossProfitPctLabel { get; }
			public PXNumberEdit MarkupPct { get; }
			public Label MarkupPctLabel { get; }
			public Selector DefaultColumnMatrixAttributeID { get; }
			public Label DefaultColumnMatrixAttributeIDLabel { get; }
			public Selector DefaultRowMatrixAttributeID { get; }
			public Label DefaultRowMatrixAttributeIDLabel { get; }
            
            public c_itemclasssettings_tab(string locator, string name) : 
                    base(locator, name)
            {
                StkItem = new CheckBox("ctl00_phG_sp1_scrollForm_tab_t0_chkStkItem", "Stock Item", locator, null);
                StkItemLabel = new Label(StkItem);
                StkItem.DataField = "StkItem";
                NegQty = new CheckBox("ctl00_phG_sp1_scrollForm_tab_t0_chkNegQty", "Allow Negative Quantity", locator, null);
                NegQtyLabel = new Label(NegQty);
                NegQty.DataField = "NegQty";
                AccrueCost = new CheckBox("ctl00_phG_sp1_scrollForm_tab_t0_chkAccrueCost", "Accrue Cost", locator, null);
                AccrueCostLabel = new Label(AccrueCost);
                AccrueCost.DataField = "AccrueCost";
                ExportToExternal = new CheckBox("ctl00_phG_sp1_scrollForm_tab_t0_edExportToExternal", "Export to External System", locator, null);
                ExportToExternalLabel = new Label(ExportToExternal);
                ExportToExternal.DataField = "ExportToExternal";
                ItemType = new DropDown("ctl00_phG_sp1_scrollForm_tab_t0_edItemType", "Item Type", locator, null);
                ItemTypeLabel = new Label(ItemType);
                ItemType.DataField = "ItemType";
                ItemType.Items.Add("F", "Finished Good");
                ItemType.Items.Add("M", "Component Part");
                ItemType.Items.Add("A", "Subassembly");
                ValMethod = new DropDown("ctl00_phG_sp1_scrollForm_tab_t0_edValMethod", "Valuation Method", locator, null);
                ValMethodLabel = new Label(ValMethod);
                ValMethod.DataField = "ValMethod";
                ValMethod.Items.Add("T", "Standard");
                ValMethod.Items.Add("A", "Average");
                ValMethod.Items.Add("F", "FIFO");
                ValMethod.Items.Add("S", "Specific");
                AMReplenishmentSource = new DropDown("ctl00_phG_sp1_scrollForm_tab_t0_edAMReplenishmentSource", "Replenishment Source", locator, null);
                AMReplenishmentSourceLabel = new Label(AMReplenishmentSource);
                AMReplenishmentSource.DataField = "AMReplenishmentSource";
                TaxCategoryID = new Selector("ctl00_phG_sp1_scrollForm_tab_t0_edTaxCategoryID", "Tax Category", locator, null);
                TaxCategoryIDLabel = new Label(TaxCategoryID);
                TaxCategoryID.DataField = "TaxCategoryID";
                TaxCalcMode = new DropDown("ctl00_phG_sp1_scrollForm_tab_t0_edTaxCalcMode", "Tax Calculation Mode", locator, null);
                TaxCalcModeLabel = new Label(TaxCalcMode);
                TaxCalcMode.DataField = "TaxCalcMode";
                TaxCalcMode.Items.Add("T", "Tax Settings");
                TaxCalcMode.Items.Add("G", "Gross");
                TaxCalcMode.Items.Add("N", "Net");
                PostClassID = new Selector("ctl00_phG_sp1_scrollForm_tab_t0_edPostClassID", "Posting Class", locator, null);
                PostClassIDLabel = new Label(PostClassID);
                PostClassID.DataField = "PostClassID";
                LotSerClassID = new Selector("ctl00_phG_sp1_scrollForm_tab_t0_edLotSerClassID", "Lot/Serial Class", locator, null);
                LotSerClassIDLabel = new Label(LotSerClassID);
                LotSerClassID.DataField = "LotSerClassID";
                PriceClassID = new Selector("ctl00_phG_sp1_scrollForm_tab_t0_edPriceClassID", "Price Class", locator, null);
                PriceClassIDLabel = new Label(PriceClassID);
                PriceClassID.DataField = "PriceClassID";
                AvailabilitySchemeID = new Selector("ctl00_phG_sp1_scrollForm_tab_t0_edAvailabilitySchemeID", "Availability Calculation Rule", locator, null);
                AvailabilitySchemeIDLabel = new Label(AvailabilitySchemeID);
                AvailabilitySchemeID.DataField = "AvailabilitySchemeID";
                CountryOfOrigin = new Selector("ctl00_phG_sp1_scrollForm_tab_t0_edCountryOfOrigin", "Country Of Origin", locator, null);
                CountryOfOriginLabel = new Label(CountryOfOrigin);
                CountryOfOrigin.DataField = "CountryOfOrigin";
                HSTariffCode = new PXTextEdit("ctl00_phG_sp1_scrollForm_tab_t0_edHSTariffCode", "Tariff Code", locator, null);
                HSTariffCodeLabel = new Label(HSTariffCode);
                HSTariffCode.DataField = "HSTariffCode";
                UndershipThreshold = new PXNumberEdit("ctl00_phG_sp1_scrollForm_tab_t0_edUndershipThreshold", "Undership Threshold (%)", locator, null);
                UndershipThresholdLabel = new Label(UndershipThreshold);
                UndershipThreshold.DataField = "UndershipThreshold";
                OvershipThreshold = new PXNumberEdit("ctl00_phG_sp1_scrollForm_tab_t0_edOvershipThreshold", "Overship Threshold (%)", locator, null);
                OvershipThresholdLabel = new Label(OvershipThreshold);
                OvershipThreshold.DataField = "OvershipThreshold";
                BaseUnit = new Selector("ctl00_phG_sp1_scrollForm_tab_t0_edBaseUnit", "Base Unit", locator, null);
                BaseUnitLabel = new Label(BaseUnit);
                BaseUnit.DataField = "BaseUnit";
                DecimalBaseUnit = new CheckBox("ctl00_phG_sp1_scrollForm_tab_t0_chkDecimalBaseUnit", "Divisible Unit", locator, null);
                DecimalBaseUnitLabel = new Label(DecimalBaseUnit);
                DecimalBaseUnit.DataField = "DecimalBaseUnit";
                SalesUnit = new Selector("ctl00_phG_sp1_scrollForm_tab_t0_edSalesUnit", "Sales Unit", locator, null);
                SalesUnitLabel = new Label(SalesUnit);
                SalesUnit.DataField = "SalesUnit";
                DecimalSalesUnit = new CheckBox("ctl00_phG_sp1_scrollForm_tab_t0_chkDecimalSalesUnit", "Divisible Unit", locator, null);
                DecimalSalesUnitLabel = new Label(DecimalSalesUnit);
                DecimalSalesUnit.DataField = "DecimalSalesUnit";
                PurchaseUnit = new Selector("ctl00_phG_sp1_scrollForm_tab_t0_edPurchaseUnit", "Purchase Unit", locator, null);
                PurchaseUnitLabel = new Label(PurchaseUnit);
                PurchaseUnit.DataField = "PurchaseUnit";
                DecimalPurchaseUnit = new CheckBox("ctl00_phG_sp1_scrollForm_tab_t0_chkDecimalPurchaseUnit", "Divisible Unit", locator, null);
                DecimalPurchaseUnitLabel = new Label(DecimalPurchaseUnit);
                DecimalPurchaseUnit.DataField = "DecimalPurchaseUnit";
                PriceWorkgroupID = new TreeSelector("ctl00_phG_sp1_scrollForm_tab_t0_edPriceWorkgroupID", "Price Workgroup", locator, null);
                PriceWorkgroupIDLabel = new Label(PriceWorkgroupID);
                PriceWorkgroupID.DataField = "PriceWorkgroupID";
                PriceManagerID = new Selector("ctl00_phG_sp1_scrollForm_tab_t0_edPriceManagerID", "Price Manager", locator, null);
                PriceManagerIDLabel = new Label(PriceManagerID);
                PriceManagerID.DataField = "PriceManagerID";
                MinGrossProfitPct = new PXNumberEdit("ctl00_phG_sp1_scrollForm_tab_t0_edMinGrossProfitPct", "Min. Markup %", locator, null);
                MinGrossProfitPctLabel = new Label(MinGrossProfitPct);
                MinGrossProfitPct.DataField = "MinGrossProfitPct";
                MarkupPct = new PXNumberEdit("ctl00_phG_sp1_scrollForm_tab_t0_edMarkupPct", "Markup %", locator, null);
                MarkupPctLabel = new Label(MarkupPct);
                MarkupPct.DataField = "MarkupPct";
                DefaultColumnMatrixAttributeID = new Selector("ctl00_phG_sp1_scrollForm_tab_t3_edDefaultColumnMatrixAttributeID", "Default Column Attribute ID", locator, null);
                DefaultColumnMatrixAttributeIDLabel = new Label(DefaultColumnMatrixAttributeID);
                DefaultColumnMatrixAttributeID.DataField = "DefaultColumnMatrixAttributeID";
                DefaultRowMatrixAttributeID = new Selector("ctl00_phG_sp1_scrollForm_tab_t3_edDefaultRowMatrixAttributeID", "Default Row Attribute ID", locator, null);
                DefaultRowMatrixAttributeIDLabel = new Label(DefaultRowMatrixAttributeID);
                DefaultRowMatrixAttributeID.DataField = "DefaultRowMatrixAttributeID";
                DataMemberName = "itemclasssettings";
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
            
            public virtual void PriceClassIDEdit()
            {
                Buttons.PriceClassIDEdit.Click();
            }
            
            public virtual void AvailabilitySchemeIDEdit()
            {
                Buttons.AvailabilitySchemeIDEdit.Click();
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
            
            public virtual void PriceManagerIDEdit()
            {
                Buttons.PriceManagerIDEdit.Click();
            }
            
            public virtual void DefaultColumnMatrixAttributeIDEdit()
            {
                Buttons.DefaultColumnMatrixAttributeIDEdit.Click();
            }
            
            public virtual void DefaultRowMatrixAttributeIDEdit()
            {
                Buttons.DefaultRowMatrixAttributeIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button TaxCategoryIDEdit { get; }
			public Button PostClassIDEdit { get; }
			public Button LotSerClassIDEdit { get; }
			public Button PriceClassIDEdit { get; }
			public Button AvailabilitySchemeIDEdit { get; }
			public Button BaseUnitEdit { get; }
			public Button SalesUnitEdit { get; }
			public Button PurchaseUnitEdit { get; }
			public Button PriceManagerIDEdit { get; }
			public Button DefaultColumnMatrixAttributeIDEdit { get; }
			public Button DefaultRowMatrixAttributeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edTaxCategoryID\'] div[class=\'editBtnC" +
                            "ont\'] > div > div", "TaxCategoryIDEdit", "ctl00_phG_sp1_scrollForm_tab");
                    TaxCategoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PostClassIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edPostClassID\'] div[class=\'editBtnCon" +
                            "t\'] > div > div", "PostClassIDEdit", "ctl00_phG_sp1_scrollForm_tab");
                    PostClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    LotSerClassIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edLotSerClassID\'] div[class=\'editBtnC" +
                            "ont\'] > div > div", "LotSerClassIDEdit", "ctl00_phG_sp1_scrollForm_tab");
                    LotSerClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PriceClassIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edPriceClassID\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "PriceClassIDEdit", "ctl00_phG_sp1_scrollForm_tab");
                    PriceClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    AvailabilitySchemeIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edAvailabilitySchemeID\'] div[class=\'e" +
                            "ditBtnCont\'] > div > div", "AvailabilitySchemeIDEdit", "ctl00_phG_sp1_scrollForm_tab");
                    AvailabilitySchemeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    BaseUnitEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edBaseUnit\'] div[class=\'editBtnCont\']" +
                            " > div > div", "BaseUnitEdit", "ctl00_phG_sp1_scrollForm_tab");
                    BaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    SalesUnitEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edSalesUnit\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "SalesUnitEdit", "ctl00_phG_sp1_scrollForm_tab");
                    SalesUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PurchaseUnitEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edPurchaseUnit\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "PurchaseUnitEdit", "ctl00_phG_sp1_scrollForm_tab");
                    PurchaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PriceManagerIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edPriceManagerID\'] div[class=\'editBtn" +
                            "Cont\'] > div > div", "PriceManagerIDEdit", "ctl00_phG_sp1_scrollForm_tab");
                    PriceManagerIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DefaultColumnMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t3_edDefaultColumnMatrixAttributeID\'] di" +
                            "v[class=\'editBtnCont\'] > div > div", "DefaultColumnMatrixAttributeIDEdit", "ctl00_phG_sp1_scrollForm_tab");
                    DefaultColumnMatrixAttributeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DefaultRowMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t3_edDefaultRowMatrixAttributeID\'] div[c" +
                            "lass=\'editBtnCont\'] > div > div", "DefaultRowMatrixAttributeIDEdit", "ctl00_phG_sp1_scrollForm_tab");
                    DefaultRowMatrixAttributeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_itemclasssettings_pxformview3 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown DemandCalculation { get; }
			public Label DemandCalculationLabel { get; }
            
            public c_itemclasssettings_pxformview3(string locator, string name) : 
                    base(locator, name)
            {
                DemandCalculation = new DropDown("ctl00_phG_sp1_scrollForm_tab_t1_PXFormView3_edDemandCalculation", "Demand Calculation", locator, null);
                DemandCalculationLabel = new Label(DemandCalculation);
                DemandCalculation.DataField = "DemandCalculation";
                DemandCalculation.Items.Add("I", "Item Class Settings");
                DemandCalculation.Items.Add("H", "Hard Demand Only");
                DataMemberName = "itemclasssettings";
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
                    ReplenishmentClassIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edReplenishmentClassID\'] " +
                            "div[class=\'editBtnCont\'] > div > div", "ReplenishmentClassIDEdit", "ctl00_phG_sp1_scrollForm_tab_t1_PXFormView3");
                    ReplenishmentClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ReplenishmentPolicyIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edReplenishmentPolicyID\']" +
                            " div[class=\'editBtnCont\'] > div > div", "ReplenishmentPolicyIDEdit", "ctl00_phG_sp1_scrollForm_tab_t1_PXFormView3");
                    ReplenishmentPolicyIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_itemclasssettings_formequipment : Container
        {
            
			public DropDown DfltBillingRule { get; }
			public Label DfltBillingRuleLabel { get; }
			public CheckBox RequireRoute { get; }
			public Label RequireRouteLabel { get; }
			public GroupBox EquipmentItemClass { get; }
			public Label EquipmentItemClassLabel { get; }
			public CheckBox Mem_ShowComponent { get; }
			public Label Mem_ShowComponentLabel { get; }
            
            public c_itemclasssettings_formequipment(string locator, string name) : 
                    base(locator, name)
            {
                DfltBillingRule = new DropDown("ctl00_phG_sp1_scrollForm_tab_t4_formEquipment_edDfltBillingRule", "Default Billing Rule", locator, null);
                DfltBillingRuleLabel = new Label(DfltBillingRule);
                DfltBillingRule.DataField = "DfltBillingRule";
                RequireRoute = new CheckBox("ctl00_phG_sp1_scrollForm_tab_t4_formEquipment_edRequireRoute", "Route Service Class", locator, null);
                RequireRouteLabel = new Label(RequireRoute);
                RequireRoute.DataField = "RequireRoute";
                EquipmentItemClass = new GroupBox("ctl00_phG_sp1_scrollForm_tab_t4_formEquipment_edEquipmentItemClass", "Equipment Item Class", locator, null);
                EquipmentItemClassLabel = new Label(EquipmentItemClass);
                EquipmentItemClass.DataField = "EquipmentItemClass";
                Mem_ShowComponent = new CheckBox("ctl00_phG_sp1_scrollForm_tab_t4_formEquipment_edMem_ShowComponent", "Mem_ShowComponent", locator, null);
                Mem_ShowComponentLabel = new Label(Mem_ShowComponent);
                Mem_ShowComponent.DataField = "Mem_ShowComponent";
                DataMemberName = "itemclasssettings";
            }
        }
        
        public class c_treeviewandprimaryviewsynchronizationhelper_syncform : Container
        {
            
			public InputLocalizable Descr { get; }
			public Label DescrLabel { get; }
            
            public c_treeviewandprimaryviewsynchronizationhelper_syncform(string locator, string name) : 
                    base(locator, name)
            {
                Descr = new InputLocalizable("ctl00_phG_syncForm_edDescrHelper", "Description", locator, null);
                DescrLabel = new Label(Descr);
                Descr.DataField = "Descr";
                DataMemberName = "TreeViewAndPrimaryViewSynchronizationHelper";
            }
        }
        
        public class c_itemclasscurysettings_curysettingsformdefaultsite : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector DfltSiteID { get; }
			public Label DfltSiteIDLabel { get; }
            
            public c_itemclasscurysettings_curysettingsformdefaultsite(string locator, string name) : 
                    base(locator, name)
            {
                DfltSiteID = new Selector("ctl00_phG_sp1_scrollForm_tab_t0_CurySettingsFormDefaultSite_edDfltSiteID", "Default Warehouse", locator, null);
                DfltSiteIDLabel = new Label(DfltSiteID);
                DfltSiteID.DataField = "DfltSiteID";
                DataMemberName = "itemclasscurysettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void DfltSiteIDEdit()
            {
                Buttons.DfltSiteIDEdit.Click();
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
            
            public virtual void PriceClassIDEdit()
            {
                Buttons.PriceClassIDEdit.Click();
            }
            
            public virtual void AvailabilitySchemeIDEdit()
            {
                Buttons.AvailabilitySchemeIDEdit.Click();
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
            
            public virtual void PriceManagerIDEdit()
            {
                Buttons.PriceManagerIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DfltSiteIDEdit { get; }
			public Button TaxCategoryIDEdit { get; }
			public Button PostClassIDEdit { get; }
			public Button LotSerClassIDEdit { get; }
			public Button PriceClassIDEdit { get; }
			public Button AvailabilitySchemeIDEdit { get; }
			public Button BaseUnitEdit { get; }
			public Button SalesUnitEdit { get; }
			public Button PurchaseUnitEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button PriceManagerIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DfltSiteIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_CurySettingsFormDefaultSite_edDfltSit" +
                            "eID\'] div[class=\'editBtnCont\'] > div > div", "DfltSiteIDEdit", "ctl00_phG_sp1_scrollForm_tab_t0_CurySettingsFormDefaultSite");
                    DfltSiteIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edTaxCategoryID\'] div[class=\'editBtnC" +
                            "ont\'] > div > div", "TaxCategoryIDEdit", "ctl00_phG_sp1_scrollForm_tab_t0_CurySettingsFormDefaultSite");
                    TaxCategoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PostClassIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edPostClassID\'] div[class=\'editBtnCon" +
                            "t\'] > div > div", "PostClassIDEdit", "ctl00_phG_sp1_scrollForm_tab_t0_CurySettingsFormDefaultSite");
                    PostClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    LotSerClassIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edLotSerClassID\'] div[class=\'editBtnC" +
                            "ont\'] > div > div", "LotSerClassIDEdit", "ctl00_phG_sp1_scrollForm_tab_t0_CurySettingsFormDefaultSite");
                    LotSerClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PriceClassIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edPriceClassID\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "PriceClassIDEdit", "ctl00_phG_sp1_scrollForm_tab_t0_CurySettingsFormDefaultSite");
                    PriceClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    AvailabilitySchemeIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edAvailabilitySchemeID\'] div[class=\'e" +
                            "ditBtnCont\'] > div > div", "AvailabilitySchemeIDEdit", "ctl00_phG_sp1_scrollForm_tab_t0_CurySettingsFormDefaultSite");
                    AvailabilitySchemeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    BaseUnitEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edBaseUnit\'] div[class=\'editBtnCont\']" +
                            " > div > div", "BaseUnitEdit", "ctl00_phG_sp1_scrollForm_tab_t0_CurySettingsFormDefaultSite");
                    BaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    SalesUnitEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edSalesUnit\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "SalesUnitEdit", "ctl00_phG_sp1_scrollForm_tab_t0_CurySettingsFormDefaultSite");
                    SalesUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PurchaseUnitEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edPurchaseUnit\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "PurchaseUnitEdit", "ctl00_phG_sp1_scrollForm_tab_t0_CurySettingsFormDefaultSite");
                    PurchaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    First = new Button("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lfFirst0", "First", "ctl00_phG_sp1_scrollForm_tab_t0_CurySettingsFormDefaultSite");
                    Prev = new Button("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lfPrev0", "Prev", "ctl00_phG_sp1_scrollForm_tab_t0_CurySettingsFormDefaultSite");
                    Next = new Button("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lfNext0", "Next", "ctl00_phG_sp1_scrollForm_tab_t0_CurySettingsFormDefaultSite");
                    Last = new Button("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lfLast0", "Last", "ctl00_phG_sp1_scrollForm_tab_t0_CurySettingsFormDefaultSite");
                    PriceManagerIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edPriceManagerID\'] div[class=\'editBtn" +
                            "Cont\'] > div > div", "PriceManagerIDEdit", "ctl00_phG_sp1_scrollForm_tab_t0_CurySettingsFormDefaultSite");
                    PriceManagerIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_classunits_gridunits : Grid<c_classunits_gridunits.c_grid_row, c_classunits_gridunits.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_classunits_gridunits(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits");
                DataMemberName = "classunits";
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
            
            public virtual void PriceClassIDEdit()
            {
                Buttons.PriceClassIDEdit.Click();
            }
            
            public virtual void AvailabilitySchemeIDEdit()
            {
                Buttons.AvailabilitySchemeIDEdit.Click();
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
            
            public virtual void PriceManagerIDEdit()
            {
                Buttons.PriceManagerIDEdit.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current record will be deleted.");
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button TaxCategoryIDEdit { get; }
			public Button PostClassIDEdit { get; }
			public Button LotSerClassIDEdit { get; }
			public Button PriceClassIDEdit { get; }
			public Button AvailabilitySchemeIDEdit { get; }
			public Button BaseUnitEdit { get; }
			public Button SalesUnitEdit { get; }
			public Button PurchaseUnitEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button PriceManagerIDEdit { get; }
                
                public PxButtonCollection()
                {
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edTaxCategoryID\'] div[class=\'editBtnC" +
                            "ont\'] > div > div", "TaxCategoryIDEdit", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits");
                    TaxCategoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PostClassIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edPostClassID\'] div[class=\'editBtnCon" +
                            "t\'] > div > div", "PostClassIDEdit", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits");
                    PostClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    LotSerClassIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edLotSerClassID\'] div[class=\'editBtnC" +
                            "ont\'] > div > div", "LotSerClassIDEdit", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits");
                    LotSerClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PriceClassIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edPriceClassID\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "PriceClassIDEdit", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits");
                    PriceClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    AvailabilitySchemeIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edAvailabilitySchemeID\'] div[class=\'e" +
                            "ditBtnCont\'] > div > div", "AvailabilitySchemeIDEdit", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits");
                    AvailabilitySchemeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    BaseUnitEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edBaseUnit\'] div[class=\'editBtnCont\']" +
                            " > div > div", "BaseUnitEdit", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits");
                    BaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    SalesUnitEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edSalesUnit\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "SalesUnitEdit", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits");
                    SalesUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PurchaseUnitEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edPurchaseUnit\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "PurchaseUnitEdit", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits");
                    PurchaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    First = new Button("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lfFirst0", "First", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits");
                    Prev = new Button("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lfPrev0", "Prev", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits");
                    Next = new Button("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lfNext0", "Next", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits");
                    Last = new Button("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lfLast0", "Last", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits");
                    PriceManagerIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edPriceManagerID\'] div[class=\'editBtn" +
                            "Cont\'] > div > div", "PriceManagerIDEdit", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits");
                    PriceManagerIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
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
			public Selector ToUnit { get; }
                
                public c_grid_row(c_classunits_gridunits grid) : 
                        base(grid)
                {
                    UnitType = new DropDown("_ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0_edUnitType", "Unit Type", grid.Locator, "UnitType");
                    UnitType.DataField = "UnitType";
                    UnitType.Items.Add("1", "Inventory Item");
                    UnitType.Items.Add("2", "Item Class");
                    UnitType.Items.Add("3", "Global");
                    ItemClassID = new PXNumberEdit("_ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0_edItemClassID2", "Item Class ID", grid.Locator, "ItemClassID");
                    ItemClassID.DataField = "ItemClassID";
                    InventoryID = new PXNumberEdit("_ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0_edInventoryID", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    FromUnit = new PXTextEdit("_ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0_edFromUnit", "From Unit", grid.Locator, "FromUnit");
                    FromUnit.DataField = "FromUnit";
                    UnitMultDiv = new DropDown("_ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0_edUnitMultDiv", "Multiply/Divide", grid.Locator, "UnitMultDiv");
                    UnitMultDiv.DataField = "UnitMultDiv";
                    UnitMultDiv.Items.Add("M", "Multiply");
                    UnitMultDiv.Items.Add("D", "Divide");
                    UnitRate = new PXNumberEdit("_ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0_edUnitRate", "Conversion Factor", grid.Locator, "UnitRate");
                    UnitRate.DataField = "UnitRate";
                    SampleToUnit = new PXTextEdit("_ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0_edSampleToUnit", "To Unit", grid.Locator, "SampleToUnit");
                    SampleToUnit.DataField = "SampleToUnit";
                    ToUnit = new Selector("_ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0_es", "To Unit", grid.Locator, "ToUnit");
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
				public SelectorColumnFilter ToUnit { get; }
                
                public c_grid_header(c_classunits_gridunits grid) : 
                        base(grid)
                {
                    UnitType = new DropDownColumnFilter(grid.Row.UnitType);
                    ItemClassID = new PXNumberEditColumnFilter(grid.Row.ItemClassID);
                    InventoryID = new PXNumberEditColumnFilter(grid.Row.InventoryID);
                    FromUnit = new PXTextEditColumnFilter(grid.Row.FromUnit);
                    UnitMultDiv = new DropDownColumnFilter(grid.Row.UnitMultDiv);
                    UnitRate = new PXNumberEditColumnFilter(grid.Row.UnitRate);
                    SampleToUnit = new PXTextEditColumnFilter(grid.Row.SampleToUnit);
                    ToUnit = new SelectorColumnFilter(grid.Row.ToUnit);
                }
            }
        }
        
        public class c_classunits_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown UnitType { get; }
			public Label UnitTypeLabel { get; }
			public PXNumberEdit ItemClassID { get; }
			public Label ItemClassIDLabel { get; }
			public PXNumberEdit InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public PXTextEdit FromUnit { get; }
			public Label FromUnitLabel { get; }
			public PXTextEdit SampleToUnit { get; }
			public Label SampleToUnitLabel { get; }
			public DropDown UnitMultDiv { get; }
			public Label UnitMultDivLabel { get; }
			public PXNumberEdit UnitRate { get; }
			public Label UnitRateLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_classunits_lv0(string locator, string name) : 
                    base(locator, name)
            {
                UnitType = new DropDown("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0_edUnitType", "Unit Type", locator, null);
                UnitTypeLabel = new Label(UnitType);
                UnitType.DataField = "UnitType";
                UnitType.Items.Add("1", "Inventory Item");
                UnitType.Items.Add("2", "Item Class");
                UnitType.Items.Add("3", "Global");
                ItemClassID = new PXNumberEdit("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0_edItemClassID2", "Item Class ID", locator, null);
                ItemClassIDLabel = new Label(ItemClassID);
                ItemClassID.DataField = "ItemClassID";
                InventoryID = new PXNumberEdit("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0_edInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                FromUnit = new PXTextEdit("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0_edFromUnit", "From Unit", locator, null);
                FromUnitLabel = new Label(FromUnit);
                FromUnit.DataField = "FromUnit";
                SampleToUnit = new PXTextEdit("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0_edSampleToUnit", "To Unit", locator, null);
                SampleToUnitLabel = new Label(SampleToUnit);
                SampleToUnit.DataField = "SampleToUnit";
                UnitMultDiv = new DropDown("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0_edUnitMultDiv", "Multiply/Divide", locator, null);
                UnitMultDivLabel = new Label(UnitMultDiv);
                UnitMultDiv.DataField = "UnitMultDiv";
                UnitMultDiv.Items.Add("M", "Multiply");
                UnitMultDiv.Items.Add("D", "Divide");
                UnitRate = new PXNumberEdit("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0_edUnitRate", "Conversion Factor", locator, null);
                UnitRateLabel = new Label(UnitRate);
                UnitRate.DataField = "UnitRate";
                Es = new Selector("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "classunits";
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
            
            public virtual void PriceClassIDEdit()
            {
                Buttons.PriceClassIDEdit.Click();
            }
            
            public virtual void AvailabilitySchemeIDEdit()
            {
                Buttons.AvailabilitySchemeIDEdit.Click();
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
            
            public virtual void PriceManagerIDEdit()
            {
                Buttons.PriceManagerIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button TaxCategoryIDEdit { get; }
			public Button PostClassIDEdit { get; }
			public Button LotSerClassIDEdit { get; }
			public Button PriceClassIDEdit { get; }
			public Button AvailabilitySchemeIDEdit { get; }
			public Button BaseUnitEdit { get; }
			public Button SalesUnitEdit { get; }
			public Button PurchaseUnitEdit { get; }
			public Button First { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Last { get; }
			public Button PriceManagerIDEdit { get; }
                
                public PxButtonCollection()
                {
                    TaxCategoryIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edTaxCategoryID\'] div[class=\'editBtnC" +
                            "ont\'] > div > div", "TaxCategoryIDEdit", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0");
                    TaxCategoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PostClassIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edPostClassID\'] div[class=\'editBtnCon" +
                            "t\'] > div > div", "PostClassIDEdit", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0");
                    PostClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    LotSerClassIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edLotSerClassID\'] div[class=\'editBtnC" +
                            "ont\'] > div > div", "LotSerClassIDEdit", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0");
                    LotSerClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PriceClassIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edPriceClassID\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "PriceClassIDEdit", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0");
                    PriceClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    AvailabilitySchemeIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edAvailabilitySchemeID\'] div[class=\'e" +
                            "ditBtnCont\'] > div > div", "AvailabilitySchemeIDEdit", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0");
                    AvailabilitySchemeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    BaseUnitEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edBaseUnit\'] div[class=\'editBtnCont\']" +
                            " > div > div", "BaseUnitEdit", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0");
                    BaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    SalesUnitEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edSalesUnit\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "SalesUnitEdit", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0");
                    SalesUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PurchaseUnitEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edPurchaseUnit\'] div[class=\'editBtnCo" +
                            "nt\'] > div > div", "PurchaseUnitEdit", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0");
                    PurchaseUnitEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    First = new Button("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lfFirst0", "First", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0");
                    Prev = new Button("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lfPrev0", "Prev", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0");
                    Next = new Button("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lfNext0", "Next", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0");
                    Last = new Button("ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lfLast0", "Last", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0");
                    PriceManagerIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t0_edPriceManagerID\'] div[class=\'editBtn" +
                            "Cont\'] > div > div", "PriceManagerIDEdit", "ctl00_phG_sp1_scrollForm_tab_t0_gridUnits_lv0");
                    PriceManagerIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_mapping_attributesgrid : Grid<c_mapping_attributesgrid.c_grid_row, c_mapping_attributesgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_mapping_attributesgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid");
                DataMemberName = "Mapping";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_fe_gf", "FilterForm");
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
            
            public virtual void DefaultColumnMatrixAttributeIDEdit()
            {
                Buttons.DefaultColumnMatrixAttributeIDEdit.Click();
            }
            
            public virtual void DefaultRowMatrixAttributeIDEdit()
            {
                Buttons.DefaultRowMatrixAttributeIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_at_tlb div[data-cmd=\'Refresh\'" +
                            "]", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_at_tlb div[data-cmd=\'AddNew\']" +
                            "", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_at_tlb div[data-cmd=\'Delete\']" +
                            "", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_at_tlb div[data-cmd=\'AdjustCo" +
                            "lumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_at_tlb div[data-cmd=\'ExportEx" +
                            "cel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_ab_tlb div[data-cmd=\'PageFirs" +
                            "t\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_ab_tlb div[data-cmd=\'PagePrev" +
                            "\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_ab_tlb div[data-cmd=\'PageNext" +
                            "\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_ab_tlb div[data-cmd=\'PageLast" +
                            "\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DefaultColumnMatrixAttributeIDEdit { get; }
			public Button DefaultRowMatrixAttributeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DefaultColumnMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t3_edDefaultColumnMatrixAttributeID\'] di" +
                            "v[class=\'editBtnCont\'] > div > div", "DefaultColumnMatrixAttributeIDEdit", "ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid");
                    DefaultColumnMatrixAttributeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DefaultRowMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t3_edDefaultRowMatrixAttributeID\'] div[c" +
                            "lass=\'editBtnCont\'] > div > div", "DefaultRowMatrixAttributeIDEdit", "ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid");
                    DefaultRowMatrixAttributeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox IsActive { get; }
			public Selector AttributeID { get; }
			public PXTextEdit Description { get; }
			public PXNumberEdit SortOrder { get; }
			public CheckBox Required { get; }
			public DropDown ControlType { get; }
			public DropDown AttributeCategory { get; }
			public PXTextEdit EntityClassID { get; }
			public PXTextEdit EntityType { get; }
                
                public c_grid_row(c_mapping_attributesgrid grid) : 
                        base(grid)
                {
                    IsActive = new CheckBox("ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_ef", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    AttributeID = new Selector("_ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_lv0_edCRAttributeID", "Attribute ID", grid.Locator, "AttributeID");
                    AttributeID.DataField = "AttributeID";
                    Description = new PXTextEdit("_ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_lv0_edDescription2", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                    SortOrder = new PXNumberEdit("_ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_lv0_edSortOrder", "Sort Order", grid.Locator, "SortOrder");
                    SortOrder.DataField = "SortOrder";
                    Required = new CheckBox("_ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_lv0_chkRequired", "Required", grid.Locator, "Required");
                    Required.DataField = "Required";
                    ControlType = new DropDown("_ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_lv0_ec", "Control Type", grid.Locator, "ControlType");
                    ControlType.DataField = "ControlType";
                    ControlType.Items.Add("1", "Text");
                    ControlType.Items.Add("2", "Combo");
                    ControlType.Items.Add("6", "Multi Select Combo");
                    ControlType.Items.Add("3", "Lookup");
                    ControlType.Items.Add("4", "Checkbox");
                    ControlType.Items.Add("5", "Datetime");
                    AttributeCategory = new DropDown("_ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_lv0_ec", "Category", grid.Locator, "AttributeCategory");
                    AttributeCategory.DataField = "AttributeCategory";
                    AttributeCategory.Items.Add("A", "Attribute");
                    AttributeCategory.Items.Add("V", "Variant");
                    EntityClassID = new PXTextEdit("ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_ei", "Entity Class ID", grid.Locator, "EntityClassID");
                    EntityClassID.DataField = "EntityClassID";
                    EntityType = new PXTextEdit("ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_ei", "Type", grid.Locator, "EntityType");
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
				public DropDownColumnFilter ControlType { get; }
				public DropDownColumnFilter AttributeCategory { get; }
				public PXTextEditColumnFilter EntityClassID { get; }
				public PXTextEditColumnFilter EntityType { get; }
                
                public c_grid_header(c_mapping_attributesgrid grid) : 
                        base(grid)
                {
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    AttributeID = new SelectorColumnFilter(grid.Row.AttributeID);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                    SortOrder = new PXNumberEditColumnFilter(grid.Row.SortOrder);
                    Required = new CheckBoxColumnFilter(grid.Row.Required);
                    ControlType = new DropDownColumnFilter(grid.Row.ControlType);
                    AttributeCategory = new DropDownColumnFilter(grid.Row.AttributeCategory);
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
			public PXTextEdit Description { get; }
			public Label DescriptionLabel { get; }
			public CheckBox Required { get; }
			public Label RequiredLabel { get; }
			public PXNumberEdit SortOrder { get; }
			public Label SortOrderLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_mapping_lv0(string locator, string name) : 
                    base(locator, name)
            {
                AttributeID = new Selector("ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_lv0_edCRAttributeID", "Attribute ID", locator, null);
                AttributeIDLabel = new Label(AttributeID);
                AttributeID.DataField = "AttributeID";
                Description = new PXTextEdit("ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_lv0_edDescription2", "Description", locator, null);
                DescriptionLabel = new Label(Description);
                Description.DataField = "Description";
                Required = new CheckBox("ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_lv0_chkRequired", "Required", locator, null);
                RequiredLabel = new Label(Required);
                Required.DataField = "Required";
                SortOrder = new PXNumberEdit("ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_lv0_edSortOrder", "Sort Order", locator, null);
                SortOrderLabel = new Label(SortOrder);
                SortOrder.DataField = "SortOrder";
                Es = new Selector("ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "Mapping";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void DefaultColumnMatrixAttributeIDEdit()
            {
                Buttons.DefaultColumnMatrixAttributeIDEdit.Click();
            }
            
            public virtual void DefaultRowMatrixAttributeIDEdit()
            {
                Buttons.DefaultRowMatrixAttributeIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DefaultColumnMatrixAttributeIDEdit { get; }
			public Button DefaultRowMatrixAttributeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DefaultColumnMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t3_edDefaultColumnMatrixAttributeID\'] di" +
                            "v[class=\'editBtnCont\'] > div > div", "DefaultColumnMatrixAttributeIDEdit", "ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_lv0");
                    DefaultColumnMatrixAttributeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DefaultRowMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t3_edDefaultRowMatrixAttributeID\'] div[c" +
                            "lass=\'editBtnCont\'] > div > div", "DefaultRowMatrixAttributeIDEdit", "ctl00_phG_sp1_scrollForm_tab_t3_AttributesGrid_lv0");
                    DefaultRowMatrixAttributeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
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
                ToolBar = new PxToolBar("ctl00_phG_sp1_scrollForm_tab_t1_repGrid");
                DataMemberName = "replenishment";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_sp1_scrollForm_tab_t1_repGrid_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t1_repGrid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t1_repGrid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t1_repGrid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t1_repGrid_at_tlb div[data-cmd=\'AdjustColumns\']" +
                            "", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t1_repGrid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t1_repGrid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t1_repGrid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t1_repGrid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t1_repGrid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t1_repGrid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t1_repGrid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ReplenishmentClassIDEdit { get; }
			public Button ReplenishmentPolicyIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ReplenishmentClassIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edReplenishmentClassID\'] " +
                            "div[class=\'editBtnCont\'] > div > div", "ReplenishmentClassIDEdit", "ctl00_phG_sp1_scrollForm_tab_t1_repGrid");
                    ReplenishmentClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ReplenishmentPolicyIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edReplenishmentPolicyID\']" +
                            " div[class=\'editBtnCont\'] > div > div", "ReplenishmentPolicyIDEdit", "ctl00_phG_sp1_scrollForm_tab_t1_repGrid");
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
			public PXNumberEdit TransferLeadTime { get; }
			public PXNumberEdit TransferERQ { get; }
			public DropDown ForecastModelType { get; }
			public DropDown ForecastPeriodType { get; }
			public PXNumberEdit HistoryDepth { get; }
			public DateSelector LaunchDate { get; }
			public DateSelector TerminationDate { get; }
			public PXNumberEdit ServiceLevelPct { get; }
			public PXNumberEdit ItemClassID { get; }
			public Selector CuryID { get; }
                
                public c_grid_row(c_replenishment_repgrid grid) : 
                        base(grid)
                {
                    ReplenishmentClassID = new Selector("_ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edReplenishmentClassID", "Replenishment Class ID", grid.Locator, "ReplenishmentClassID");
                    ReplenishmentClassID.DataField = "ReplenishmentClassID";
                    ReplenishmentPolicyID = new Selector("_ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edReplenishmentPolicyID", "Seasonality", grid.Locator, "ReplenishmentPolicyID");
                    ReplenishmentPolicyID.DataField = "ReplenishmentPolicyID";
                    ReplenishmentSource = new DropDown("_ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edReplenishmentSource", "Source", grid.Locator, "ReplenishmentSource");
                    ReplenishmentSource.DataField = "ReplenishmentSource";
                    ReplenishmentSource.Items.Add("N", "None");
                    ReplenishmentSource.Items.Add("P", "Purchase");
                    ReplenishmentSource.Items.Add("M", "Manufacturing");
                    ReplenishmentSource.Items.Add("T", "Transfer");
                    ReplenishmentSource.Items.Add("D", "Drop-Shipment");
                    ReplenishmentSource.Items.Add("O", "Purchase to Order");
                    ReplenishmentMethod = new DropDown("_ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edReplenishmentMethod", "Method", grid.Locator, "ReplenishmentMethod");
                    ReplenishmentMethod.DataField = "ReplenishmentMethod";
                    ReplenishmentMethod.Items.Add("N", "None");
                    ReplenishmentMethod.Items.Add("M", "Min./Max.");
                    ReplenishmentMethod.Items.Add("F", "Fixed Reorder Qty");
                    ReplenishmentSourceSiteID = new Selector("_ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edReplenishmentSourceSiteID", "Replenishment Warehouse", grid.Locator, "ReplenishmentSourceSiteID");
                    ReplenishmentSourceSiteID.DataField = "ReplenishmentSourceSiteID";
                    TransferLeadTime = new PXNumberEdit("_ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edTransferLeadTime", "Transfer Lead Time", grid.Locator, "TransferLeadTime");
                    TransferLeadTime.DataField = "TransferLeadTime";
                    TransferERQ = new PXNumberEdit("_ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edTransferERQ", "Transfer ERQ", grid.Locator, "TransferERQ");
                    TransferERQ.DataField = "TransferERQ";
                    ForecastModelType = new DropDown("_ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_ec", "Demand Forecast Model", grid.Locator, "ForecastModelType");
                    ForecastModelType.DataField = "ForecastModelType";
                    ForecastModelType.Items.Add("NNN", "None");
                    ForecastModelType.Items.Add("CMA", "Moving Average");
                    ForecastPeriodType = new DropDown("_ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_ec", "Forecast Period Type", grid.Locator, "ForecastPeriodType");
                    ForecastPeriodType.DataField = "ForecastPeriodType";
                    ForecastPeriodType.Items.Add("QT", "Quarter");
                    ForecastPeriodType.Items.Add("MT", "Month");
                    ForecastPeriodType.Items.Add("WK", "Week");
                    ForecastPeriodType.Items.Add("DY", "Day");
                    HistoryDepth = new PXNumberEdit("_ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edHistoryDepth", "Periods to Analyze", grid.Locator, "HistoryDepth");
                    HistoryDepth.DataField = "HistoryDepth";
                    LaunchDate = new DateSelector("_ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edLaunchDate", "Launch Date", grid.Locator, "LaunchDate");
                    LaunchDate.DataField = "LaunchDate";
                    TerminationDate = new DateSelector("_ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edTerminationDate", "Termination Date", grid.Locator, "TerminationDate");
                    TerminationDate.DataField = "TerminationDate";
                    ServiceLevelPct = new PXNumberEdit("_ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edServiceLevelPct", "Service Level (%)", grid.Locator, "ServiceLevelPct");
                    ServiceLevelPct.DataField = "ServiceLevelPct";
                    ItemClassID = new PXNumberEdit("ctl00_phG_sp1_scrollForm_tab_t1_repGrid_en", "Class ID", grid.Locator, "ItemClassID");
                    ItemClassID.DataField = "ItemClassID";
                    CuryID = new Selector("_ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_es", "Currency", grid.Locator, "CuryID");
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
				public PXNumberEditColumnFilter TransferLeadTime { get; }
				public PXNumberEditColumnFilter TransferERQ { get; }
				public DropDownColumnFilter ForecastModelType { get; }
				public DropDownColumnFilter ForecastPeriodType { get; }
				public PXNumberEditColumnFilter HistoryDepth { get; }
				public DateSelectorColumnFilter LaunchDate { get; }
				public DateSelectorColumnFilter TerminationDate { get; }
				public PXNumberEditColumnFilter ServiceLevelPct { get; }
				public PXNumberEditColumnFilter ItemClassID { get; }
				public SelectorColumnFilter CuryID { get; }
                
                public c_grid_header(c_replenishment_repgrid grid) : 
                        base(grid)
                {
                    ReplenishmentClassID = new SelectorColumnFilter(grid.Row.ReplenishmentClassID);
                    ReplenishmentPolicyID = new SelectorColumnFilter(grid.Row.ReplenishmentPolicyID);
                    ReplenishmentSource = new DropDownColumnFilter(grid.Row.ReplenishmentSource);
                    ReplenishmentMethod = new DropDownColumnFilter(grid.Row.ReplenishmentMethod);
                    ReplenishmentSourceSiteID = new SelectorColumnFilter(grid.Row.ReplenishmentSourceSiteID);
                    TransferLeadTime = new PXNumberEditColumnFilter(grid.Row.TransferLeadTime);
                    TransferERQ = new PXNumberEditColumnFilter(grid.Row.TransferERQ);
                    ForecastModelType = new DropDownColumnFilter(grid.Row.ForecastModelType);
                    ForecastPeriodType = new DropDownColumnFilter(grid.Row.ForecastPeriodType);
                    HistoryDepth = new PXNumberEditColumnFilter(grid.Row.HistoryDepth);
                    LaunchDate = new DateSelectorColumnFilter(grid.Row.LaunchDate);
                    TerminationDate = new DateSelectorColumnFilter(grid.Row.TerminationDate);
                    ServiceLevelPct = new PXNumberEditColumnFilter(grid.Row.ServiceLevelPct);
                    ItemClassID = new PXNumberEditColumnFilter(grid.Row.ItemClassID);
                    CuryID = new SelectorColumnFilter(grid.Row.CuryID);
                }
            }
        }
        
        public class c_replenishment_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector ReplenishmentClassID { get; }
			public Label ReplenishmentClassIDLabel { get; }
			public DropDown ReplenishmentMethod { get; }
			public Label ReplenishmentMethodLabel { get; }
			public DropDown ReplenishmentSource { get; }
			public Label ReplenishmentSourceLabel { get; }
			public Selector ReplenishmentSourceSiteID { get; }
			public Label ReplenishmentSourceSiteIDLabel { get; }
			public Selector ReplenishmentPolicyID { get; }
			public Label ReplenishmentPolicyIDLabel { get; }
			public PXNumberEdit TransferLeadTime { get; }
			public Label TransferLeadTimeLabel { get; }
			public PXNumberEdit TransferERQ { get; }
			public Label TransferERQLabel { get; }
			public PXNumberEdit HistoryDepth { get; }
			public Label HistoryDepthLabel { get; }
			public DateSelector LaunchDate { get; }
			public Label LaunchDateLabel { get; }
			public DateSelector TerminationDate { get; }
			public Label TerminationDateLabel { get; }
			public PXNumberEdit ServiceLevelPct { get; }
			public Label ServiceLevelPctLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_replenishment_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ReplenishmentClassID = new Selector("ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edReplenishmentClassID", "Replenishment Class ID", locator, null);
                ReplenishmentClassIDLabel = new Label(ReplenishmentClassID);
                ReplenishmentClassID.DataField = "ReplenishmentClassID";
                ReplenishmentMethod = new DropDown("ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edReplenishmentMethod", "Method", locator, null);
                ReplenishmentMethodLabel = new Label(ReplenishmentMethod);
                ReplenishmentMethod.DataField = "ReplenishmentMethod";
                ReplenishmentMethod.Items.Add("N", "None");
                ReplenishmentMethod.Items.Add("M", "Min./Max.");
                ReplenishmentMethod.Items.Add("F", "Fixed Reorder Qty");
                ReplenishmentSource = new DropDown("ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edReplenishmentSource", "Source", locator, null);
                ReplenishmentSourceLabel = new Label(ReplenishmentSource);
                ReplenishmentSource.DataField = "ReplenishmentSource";
                ReplenishmentSource.Items.Add("N", "None");
                ReplenishmentSource.Items.Add("P", "Purchase");
                ReplenishmentSource.Items.Add("M", "Manufacturing");
                ReplenishmentSource.Items.Add("T", "Transfer");
                ReplenishmentSource.Items.Add("D", "Drop-Shipment");
                ReplenishmentSource.Items.Add("O", "Purchase to Order");
                ReplenishmentSourceSiteID = new Selector("ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edReplenishmentSourceSiteID", "Replenishment Warehouse", locator, null);
                ReplenishmentSourceSiteIDLabel = new Label(ReplenishmentSourceSiteID);
                ReplenishmentSourceSiteID.DataField = "ReplenishmentSourceSiteID";
                ReplenishmentPolicyID = new Selector("ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edReplenishmentPolicyID", "Seasonality", locator, null);
                ReplenishmentPolicyIDLabel = new Label(ReplenishmentPolicyID);
                ReplenishmentPolicyID.DataField = "ReplenishmentPolicyID";
                TransferLeadTime = new PXNumberEdit("ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edTransferLeadTime", "Transfer Lead Time", locator, null);
                TransferLeadTimeLabel = new Label(TransferLeadTime);
                TransferLeadTime.DataField = "TransferLeadTime";
                TransferERQ = new PXNumberEdit("ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edTransferERQ", "Transfer ERQ", locator, null);
                TransferERQLabel = new Label(TransferERQ);
                TransferERQ.DataField = "TransferERQ";
                HistoryDepth = new PXNumberEdit("ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edHistoryDepth", "Periods to Analyze", locator, null);
                HistoryDepthLabel = new Label(HistoryDepth);
                HistoryDepth.DataField = "HistoryDepth";
                LaunchDate = new DateSelector("ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edLaunchDate", "Launch Date", locator, null);
                LaunchDateLabel = new Label(LaunchDate);
                LaunchDate.DataField = "LaunchDate";
                TerminationDate = new DateSelector("ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edTerminationDate", "Termination Date", locator, null);
                TerminationDateLabel = new Label(TerminationDate);
                TerminationDate.DataField = "TerminationDate";
                ServiceLevelPct = new PXNumberEdit("ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edServiceLevelPct", "Service Level (%)", locator, null);
                ServiceLevelPctLabel = new Label(ServiceLevelPct);
                ServiceLevelPct.DataField = "ServiceLevelPct";
                Es = new Selector("ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_ec", "Ec", locator, null);
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
                    ReplenishmentClassIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edReplenishmentClassID\'] " +
                            "div[class=\'editBtnCont\'] > div > div", "ReplenishmentClassIDEdit", "ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0");
                    ReplenishmentClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ReplenishmentPolicyIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0_edReplenishmentPolicyID\']" +
                            " div[class=\'editBtnCont\'] > div > div", "ReplenishmentPolicyIDEdit", "ctl00_phG_sp1_scrollForm_tab_t1_repGrid_lv0");
                    ReplenishmentPolicyIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_groups_grid : Grid<c_groups_grid.c_grid_row, c_groups_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_groups_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_sp1_scrollForm_tab_t2_grid");
                DataMemberName = "Groups";
                FilterForm = new c_grid_filter("ctl00_phG_sp1_scrollForm_tab_t2_grid_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t2_grid_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t2_grid_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t2_grid_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current record will be deleted.");
                    ViewGroupDetails = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t2_grid_at_tlb div[data-cmd=\'ViewGroupDetails\']" +
                            "", "Group Details", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t2_grid_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t2_grid_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t2_grid_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t2_grid_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t2_grid_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t2_grid_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t2_grid_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t2_grid_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
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
                
                public c_grid_row(c_groups_grid grid) : 
                        base(grid)
                {
                    Included = new CheckBox("_ctl00_phG_sp1_scrollForm_tab_t2_grid_lv0_chkSelected", "Included", grid.Locator, "Included");
                    Included.DataField = "Included";
                    GroupName = new Selector("_ctl00_phG_sp1_scrollForm_tab_t2_grid_lv0_edGroupName", "Group Name", grid.Locator, "GroupName");
                    GroupName.DataField = "GroupName";
                    SpecificType = new DropDown("_ctl00_phG_sp1_scrollForm_tab_t2_grid_lv0_ec", "Specific Type", grid.Locator, "SpecificType");
                    SpecificType.DataField = "SpecificType";
                    SpecificType.Items.Add("PX.Objects.CS.SegmentValue", "Subitem");
                    SpecificType.Items.Add("PX.Objects.IN.InventoryItem", "Inventory Item Restriction");
                    Description = new PXTextEdit("_ctl00_phG_sp1_scrollForm_tab_t2_grid_lv0_edDescription", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                    Active = new CheckBox("_ctl00_phG_sp1_scrollForm_tab_t2_grid_lv0_chkActive", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    GroupType = new DropDown("_ctl00_phG_sp1_scrollForm_tab_t2_grid_lv0_edGroupType", "Group Type", grid.Locator, "GroupType");
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
                
                public c_grid_header(c_groups_grid grid) : 
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
                Included = new CheckBox("ctl00_phG_sp1_scrollForm_tab_t2_grid_lv0_chkSelected", "Included", locator, null);
                IncludedLabel = new Label(Included);
                Included.DataField = "Included";
                GroupName = new Selector("ctl00_phG_sp1_scrollForm_tab_t2_grid_lv0_edGroupName", "Group Name", locator, null);
                GroupNameLabel = new Label(GroupName);
                GroupName.DataField = "GroupName";
                Description = new PXTextEdit("ctl00_phG_sp1_scrollForm_tab_t2_grid_lv0_edDescription", "Description", locator, null);
                DescriptionLabel = new Label(Description);
                Description.DataField = "Description";
                Active = new CheckBox("ctl00_phG_sp1_scrollForm_tab_t2_grid_lv0_chkActive", "Active", locator, null);
                ActiveLabel = new Label(Active);
                Active.DataField = "Active";
                GroupType = new DropDown("ctl00_phG_sp1_scrollForm_tab_t2_grid_lv0_edGroupType", "Group Type", locator, null);
                GroupTypeLabel = new Label(GroupType);
                GroupType.DataField = "GroupType";
                GroupType.Items.Add("IE", "B");
                GroupType.Items.Add("EE", "B Inverse");
                GroupType.Items.Add("IO", "A");
                GroupType.Items.Add("EO", "A Inverse");
                Es = new Selector("ctl00_phG_sp1_scrollForm_tab_t2_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_sp1_scrollForm_tab_t2_grid_lv0_ec", "Ec", locator, null);
                DataMemberName = "Groups";
            }
        }
        
        public class c_itemclasstree : Container
        {
            
			public TreeView ItemClassTree { get; }
			public Label ItemClassTreeLabel { get; }
            
            public c_itemclasstree(string locator, string name) : 
                    base(locator, name)
            {
                ItemClassTree = new TreeView("ctl00_phG_sp1_tree", "Item Class Tree", locator, null);
                ItemClassTreeLabel = new Label(ItemClassTree);
                ItemClassTree.DataField = "ItemClassTree";
                DataMemberName = "ItemClassNodes";
            }
        }
        
        public class c_idgenerationrules_pxgrididgenerationrules : Grid<c_idgenerationrules_pxgrididgenerationrules.c_grid_row, c_idgenerationrules_pxgrididgenerationrules.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_idgenerationrules_pxgrididgenerationrules(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules");
                DataMemberName = "IdGenerationRules";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_fe_gf", "FilterForm");
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
            
            public virtual void IdRowUp()
            {
                ToolBar.IdRowUp.Click();
            }
            
            public virtual void IdRowDown()
            {
                ToolBar.IdRowDown.Click();
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
            
            public virtual void DefaultColumnMatrixAttributeIDEdit()
            {
                Buttons.DefaultColumnMatrixAttributeIDEdit.Click();
            }
            
            public virtual void DefaultRowMatrixAttributeIDEdit()
            {
                Buttons.DefaultRowMatrixAttributeIDEdit.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid IdRowUp { get; }
			public ToolBarButtonGrid IdRowDown { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_at_tlb div[data-cmd=" +
                            "\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_at_tlb div[data-cmd=" +
                            "\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_at_tlb div[data-cmd=" +
                            "\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current record will be deleted.");
                    IdRowUp = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_at_tlb div[data-cmd=" +
                            "\'IdRowUp\']", "IdRowUp", locator, null);
                    IdRowDown = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_at_tlb div[data-cmd=" +
                            "\'IdRowDown\']", "IdRowDown", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_at_tlb div[data-cmd=" +
                            "\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_at_tlb div[data-cmd=" +
                            "\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_at_tlb div[data-cmd=" +
                            "\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_ab_tlb div[data-cmd=" +
                            "\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_ab_tlb div[data-cmd=" +
                            "\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_ab_tlb div[data-cmd=" +
                            "\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_ab_tlb div[data-cmd=" +
                            "\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_ab_tlb div[data-cmd=" +
                            "\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DefaultColumnMatrixAttributeIDEdit { get; }
			public Button DefaultRowMatrixAttributeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DefaultColumnMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t3_edDefaultColumnMatrixAttributeID\'] di" +
                            "v[class=\'editBtnCont\'] > div > div", "DefaultColumnMatrixAttributeIDEdit", "ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules");
                    DefaultColumnMatrixAttributeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DefaultRowMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t3_edDefaultRowMatrixAttributeID\'] div[c" +
                            "lass=\'editBtnCont\'] > div > div", "DefaultRowMatrixAttributeIDEdit", "ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules");
                    DefaultRowMatrixAttributeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public DropDown SegmentType { get; }
			public Selector AttributeID { get; }
			public PXTextEdit Constant { get; }
			public Selector NumberingID { get; }
			public PXNumberEdit NumberOfCharacters { get; }
			public CheckBox UseSpaceAsSeparator { get; }
			public PXTextEdit Separator { get; }
			public CheckBox AddSpaces { get; }
			public DropDown ParentType { get; }
			public PXNumberEdit ParentID { get; }
			public DropDown Type { get; }
			public PXNumberEdit LineNbr { get; }
			public PXTextEdit Sample { get; }
                
                public c_grid_row(c_idgenerationrules_pxgrididgenerationrules grid) : 
                        base(grid)
                {
                    SegmentType = new DropDown("_ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_lv0_ec", "Segment Type", grid.Locator, "SegmentType");
                    SegmentType.DataField = "SegmentType";
                    SegmentType.Items.Add("TI", "Template ID");
                    SegmentType.Items.Add("TD", "Template Description");
                    SegmentType.Items.Add("AC", "Attribute Caption");
                    SegmentType.Items.Add("AV", "Attribute Value");
                    SegmentType.Items.Add("CO", "Constant");
                    SegmentType.Items.Add("SP", "Space");
                    SegmentType.Items.Add("AN", "Auto Number");
                    AttributeID = new Selector("_ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_lv0_edIDAttributeID", "Attribute ID", grid.Locator, "AttributeID");
                    AttributeID.DataField = "AttributeID";
                    Constant = new PXTextEdit("ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_ei", "Constant", grid.Locator, "Constant");
                    Constant.DataField = "Constant";
                    NumberingID = new Selector("_ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_lv0_es", "Numbering ID", grid.Locator, "NumberingID");
                    NumberingID.DataField = "NumberingID";
                    NumberOfCharacters = new PXNumberEdit("ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_en", "Number of Characters", grid.Locator, "NumberOfCharacters");
                    NumberOfCharacters.DataField = "NumberOfCharacters";
                    UseSpaceAsSeparator = new CheckBox("ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_ef", "Use Space as Separator", grid.Locator, "UseSpaceAsSeparator");
                    UseSpaceAsSeparator.DataField = "UseSpaceAsSeparator";
                    Separator = new PXTextEdit("ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_ei", "Separator", grid.Locator, "Separator");
                    Separator.DataField = "Separator";
                    AddSpaces = new CheckBox("ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_ef", "Add Spaces", grid.Locator, "AddSpaces");
                    AddSpaces.DataField = "AddSpaces";
                    ParentType = new DropDown("_ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_lv0_ec", "ParentType", grid.Locator, "ParentType");
                    ParentType.DataField = "ParentType";
                    ParentType.Items.Add("T", "Template Inventory Item");
                    ParentType.Items.Add("C", "Item Class");
                    ParentID = new PXNumberEdit("ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_en", "ParentID", grid.Locator, "ParentID");
                    ParentID.DataField = "ParentID";
                    Type = new DropDown("_ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_lv0_ec", "Type", grid.Locator, "Type");
                    Type.DataField = "Type";
                    Type.Items.Add("I", "ID");
                    Type.Items.Add("D", "Description");
                    LineNbr = new PXNumberEdit("ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    Sample = new PXTextEdit("ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_ei", "Sample", grid.Locator, "Sample");
                    Sample.DataField = "Sample";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public DropDownColumnFilter SegmentType { get; }
				public SelectorColumnFilter AttributeID { get; }
				public PXTextEditColumnFilter Constant { get; }
				public SelectorColumnFilter NumberingID { get; }
				public PXNumberEditColumnFilter NumberOfCharacters { get; }
				public CheckBoxColumnFilter UseSpaceAsSeparator { get; }
				public PXTextEditColumnFilter Separator { get; }
				public CheckBoxColumnFilter AddSpaces { get; }
				public DropDownColumnFilter ParentType { get; }
				public PXNumberEditColumnFilter ParentID { get; }
				public DropDownColumnFilter Type { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXTextEditColumnFilter Sample { get; }
                
                public c_grid_header(c_idgenerationrules_pxgrididgenerationrules grid) : 
                        base(grid)
                {
                    SegmentType = new DropDownColumnFilter(grid.Row.SegmentType);
                    AttributeID = new SelectorColumnFilter(grid.Row.AttributeID);
                    Constant = new PXTextEditColumnFilter(grid.Row.Constant);
                    NumberingID = new SelectorColumnFilter(grid.Row.NumberingID);
                    NumberOfCharacters = new PXNumberEditColumnFilter(grid.Row.NumberOfCharacters);
                    UseSpaceAsSeparator = new CheckBoxColumnFilter(grid.Row.UseSpaceAsSeparator);
                    Separator = new PXTextEditColumnFilter(grid.Row.Separator);
                    AddSpaces = new CheckBoxColumnFilter(grid.Row.AddSpaces);
                    ParentType = new DropDownColumnFilter(grid.Row.ParentType);
                    ParentID = new PXNumberEditColumnFilter(grid.Row.ParentID);
                    Type = new DropDownColumnFilter(grid.Row.Type);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    Sample = new PXTextEditColumnFilter(grid.Row.Sample);
                }
            }
        }
        
        public class c_idgenerationrules_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector AttributeID { get; }
			public Label AttributeIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_idgenerationrules_lv0(string locator, string name) : 
                    base(locator, name)
            {
                AttributeID = new Selector("ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_lv0_edIDAttributeID", "Attribute ID", locator, null);
                AttributeIDLabel = new Label(AttributeID);
                AttributeID.DataField = "AttributeID";
                Es = new Selector("ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_lv0_ec", "Ec", locator, null);
                DataMemberName = "IdGenerationRules";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void DefaultColumnMatrixAttributeIDEdit()
            {
                Buttons.DefaultColumnMatrixAttributeIDEdit.Click();
            }
            
            public virtual void DefaultRowMatrixAttributeIDEdit()
            {
                Buttons.DefaultRowMatrixAttributeIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DefaultColumnMatrixAttributeIDEdit { get; }
			public Button DefaultRowMatrixAttributeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DefaultColumnMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t3_edDefaultColumnMatrixAttributeID\'] di" +
                            "v[class=\'editBtnCont\'] > div > div", "DefaultColumnMatrixAttributeIDEdit", "ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_lv0");
                    DefaultColumnMatrixAttributeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DefaultRowMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t3_edDefaultRowMatrixAttributeID\'] div[c" +
                            "lass=\'editBtnCont\'] > div > div", "DefaultRowMatrixAttributeIDEdit", "ctl00_phG_sp1_scrollForm_tab_t3_PXGridIdGenerationRules_lv0");
                    DefaultRowMatrixAttributeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_descriptiongenerationrules_pxgriddescriptiongenerationrules : Grid<c_descriptiongenerationrules_pxgriddescriptiongenerationrules.c_grid_row, c_descriptiongenerationrules_pxgriddescriptiongenerationrules.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_descriptiongenerationrules_pxgriddescriptiongenerationrules(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules");
                DataMemberName = "DescriptionGenerationRules";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_fe_gf", "FilterForm");
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
            
            public virtual void DescriptionRowUp()
            {
                ToolBar.DescriptionRowUp.Click();
            }
            
            public virtual void DescriptionRowDown()
            {
                ToolBar.DescriptionRowDown.Click();
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
            
            public virtual void DefaultColumnMatrixAttributeIDEdit()
            {
                Buttons.DefaultColumnMatrixAttributeIDEdit.Click();
            }
            
            public virtual void DefaultRowMatrixAttributeIDEdit()
            {
                Buttons.DefaultRowMatrixAttributeIDEdit.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid DescriptionRowUp { get; }
			public ToolBarButtonGrid DescriptionRowDown { get; }
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_at_tlb div[" +
                            "data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_at_tlb div[" +
                            "data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_at_tlb div[" +
                            "data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current record will be deleted.");
                    DescriptionRowUp = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_at_tlb div[" +
                            "data-cmd=\'DescriptionRowUp\']", "DescriptionRowUp", locator, null);
                    DescriptionRowDown = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_at_tlb div[" +
                            "data-cmd=\'DescriptionRowDown\']", "DescriptionRowDown", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_at_tlb div[" +
                            "data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_at_tlb div[" +
                            "data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_at_tlb div[" +
                            "data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_ab_tlb div[" +
                            "data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_ab_tlb div[" +
                            "data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_ab_tlb div[" +
                            "data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_ab_tlb div[" +
                            "data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_ab_tlb div[" +
                            "data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DefaultColumnMatrixAttributeIDEdit { get; }
			public Button DefaultRowMatrixAttributeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DefaultColumnMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t3_edDefaultColumnMatrixAttributeID\'] di" +
                            "v[class=\'editBtnCont\'] > div > div", "DefaultColumnMatrixAttributeIDEdit", "ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules");
                    DefaultColumnMatrixAttributeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DefaultRowMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t3_edDefaultRowMatrixAttributeID\'] div[c" +
                            "lass=\'editBtnCont\'] > div > div", "DefaultRowMatrixAttributeIDEdit", "ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules");
                    DefaultRowMatrixAttributeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public DropDown SegmentType { get; }
			public Selector AttributeID { get; }
			public PXTextEdit Constant { get; }
			public Selector NumberingID { get; }
			public PXNumberEdit NumberOfCharacters { get; }
			public CheckBox UseSpaceAsSeparator { get; }
			public PXTextEdit Separator { get; }
			public CheckBox AddSpaces { get; }
			public DropDown ParentType { get; }
			public PXNumberEdit ParentID { get; }
			public DropDown Type { get; }
			public PXNumberEdit LineNbr { get; }
			public PXTextEdit Sample { get; }
                
                public c_grid_row(c_descriptiongenerationrules_pxgriddescriptiongenerationrules grid) : 
                        base(grid)
                {
                    SegmentType = new DropDown("_ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_lv0_ec", "Segment Type", grid.Locator, "SegmentType");
                    SegmentType.DataField = "SegmentType";
                    SegmentType.Items.Add("TI", "Template ID");
                    SegmentType.Items.Add("TD", "Template Description");
                    SegmentType.Items.Add("AC", "Attribute Caption");
                    SegmentType.Items.Add("AV", "Attribute Value");
                    SegmentType.Items.Add("CO", "Constant");
                    SegmentType.Items.Add("SP", "Space");
                    SegmentType.Items.Add("AN", "Auto Number");
                    AttributeID = new Selector("_ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_lv0_edDescripti" +
                            "onAttributeID", "Attribute ID", grid.Locator, "AttributeID");
                    AttributeID.DataField = "AttributeID";
                    Constant = new PXTextEdit("ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_ei", "Constant", grid.Locator, "Constant");
                    Constant.DataField = "Constant";
                    NumberingID = new Selector("_ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_lv0_es", "Numbering ID", grid.Locator, "NumberingID");
                    NumberingID.DataField = "NumberingID";
                    NumberOfCharacters = new PXNumberEdit("ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_en", "Number of Characters", grid.Locator, "NumberOfCharacters");
                    NumberOfCharacters.DataField = "NumberOfCharacters";
                    UseSpaceAsSeparator = new CheckBox("ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_ef", "Use Space as Separator", grid.Locator, "UseSpaceAsSeparator");
                    UseSpaceAsSeparator.DataField = "UseSpaceAsSeparator";
                    Separator = new PXTextEdit("ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_ei", "Separator", grid.Locator, "Separator");
                    Separator.DataField = "Separator";
                    AddSpaces = new CheckBox("ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_ef", "Add Spaces", grid.Locator, "AddSpaces");
                    AddSpaces.DataField = "AddSpaces";
                    ParentType = new DropDown("_ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_lv0_ec", "ParentType", grid.Locator, "ParentType");
                    ParentType.DataField = "ParentType";
                    ParentType.Items.Add("T", "Template Inventory Item");
                    ParentType.Items.Add("C", "Item Class");
                    ParentID = new PXNumberEdit("ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_en", "ParentID", grid.Locator, "ParentID");
                    ParentID.DataField = "ParentID";
                    Type = new DropDown("_ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_lv0_ec", "Type", grid.Locator, "Type");
                    Type.DataField = "Type";
                    Type.Items.Add("I", "ID");
                    Type.Items.Add("D", "Description");
                    LineNbr = new PXNumberEdit("ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    Sample = new PXTextEdit("ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_ei", "Sample", grid.Locator, "Sample");
                    Sample.DataField = "Sample";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public DropDownColumnFilter SegmentType { get; }
				public SelectorColumnFilter AttributeID { get; }
				public PXTextEditColumnFilter Constant { get; }
				public SelectorColumnFilter NumberingID { get; }
				public PXNumberEditColumnFilter NumberOfCharacters { get; }
				public CheckBoxColumnFilter UseSpaceAsSeparator { get; }
				public PXTextEditColumnFilter Separator { get; }
				public CheckBoxColumnFilter AddSpaces { get; }
				public DropDownColumnFilter ParentType { get; }
				public PXNumberEditColumnFilter ParentID { get; }
				public DropDownColumnFilter Type { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXTextEditColumnFilter Sample { get; }
                
                public c_grid_header(c_descriptiongenerationrules_pxgriddescriptiongenerationrules grid) : 
                        base(grid)
                {
                    SegmentType = new DropDownColumnFilter(grid.Row.SegmentType);
                    AttributeID = new SelectorColumnFilter(grid.Row.AttributeID);
                    Constant = new PXTextEditColumnFilter(grid.Row.Constant);
                    NumberingID = new SelectorColumnFilter(grid.Row.NumberingID);
                    NumberOfCharacters = new PXNumberEditColumnFilter(grid.Row.NumberOfCharacters);
                    UseSpaceAsSeparator = new CheckBoxColumnFilter(grid.Row.UseSpaceAsSeparator);
                    Separator = new PXTextEditColumnFilter(grid.Row.Separator);
                    AddSpaces = new CheckBoxColumnFilter(grid.Row.AddSpaces);
                    ParentType = new DropDownColumnFilter(grid.Row.ParentType);
                    ParentID = new PXNumberEditColumnFilter(grid.Row.ParentID);
                    Type = new DropDownColumnFilter(grid.Row.Type);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    Sample = new PXTextEditColumnFilter(grid.Row.Sample);
                }
            }
        }
        
        public class c_descriptiongenerationrules_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector AttributeID { get; }
			public Label AttributeIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_descriptiongenerationrules_lv0(string locator, string name) : 
                    base(locator, name)
            {
                AttributeID = new Selector("ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_lv0_edDescriptio" +
                        "nAttributeID", "Attribute ID", locator, null);
                AttributeIDLabel = new Label(AttributeID);
                AttributeID.DataField = "AttributeID";
                Es = new Selector("ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_lv0_ec", "Ec", locator, null);
                DataMemberName = "DescriptionGenerationRules";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void DefaultColumnMatrixAttributeIDEdit()
            {
                Buttons.DefaultColumnMatrixAttributeIDEdit.Click();
            }
            
            public virtual void DefaultRowMatrixAttributeIDEdit()
            {
                Buttons.DefaultRowMatrixAttributeIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button DefaultColumnMatrixAttributeIDEdit { get; }
			public Button DefaultRowMatrixAttributeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    DefaultColumnMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t3_edDefaultColumnMatrixAttributeID\'] di" +
                            "v[class=\'editBtnCont\'] > div > div", "DefaultColumnMatrixAttributeIDEdit", "ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_lv0");
                    DefaultColumnMatrixAttributeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DefaultRowMatrixAttributeIDEdit = new Button("css=div[id=\'ctl00_phG_sp1_scrollForm_tab_t3_edDefaultRowMatrixAttributeID\'] div[c" +
                            "lass=\'editBtnCont\'] > div > div", "DefaultRowMatrixAttributeIDEdit", "ctl00_phG_sp1_scrollForm_tab_t3_PXGridDescriptionGenerationRules_lv0");
                    DefaultRowMatrixAttributeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_changeiddialog_formchangeid : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit CD { get; }
			public Label CDLabel { get; }
            
            public c_changeiddialog_formchangeid(string locator, string name) : 
                    base(locator, name)
            {
                CD = new PXTextEdit("ctl00_phG_pnlChangeID_formChangeID_edAcctCD", "Class ID", locator, null);
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
                    Ok = new Button("ctl00_phG_pnlChangeID_btnOK", "OK", "ctl00_phG_pnlChangeID_formChangeID");
                    Cancel = new Button("ctl00_phG_pnlChangeID_btnCancel", "Cancel", "ctl00_phG_pnlChangeID_formChangeID");
                }
            }
        }
        
        public class c_modeltemplatecomponentrecords_modeltemplatecomponents : Grid<c_modeltemplatecomponentrecords_modeltemplatecomponents.c_grid_row, c_modeltemplatecomponentrecords_modeltemplatecomponents.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_modeltemplatecomponentrecords_modeltemplatecomponents(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents");
                DataMemberName = "ModelTemplateComponentRecords";
                FilterForm = new c_grid_filter("ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents_at_tlb div[data-cmd=" +
                            "\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents_at_tlb div[data-cmd=" +
                            "\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents_at_tlb div[data-cmd=" +
                            "\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents_at_tlb div[data-cmd=" +
                            "\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents_at_tlb div[data-cmd=" +
                            "\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents_at_tlb div[data-cmd=" +
                            "\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents_ab_tlb div[data-cmd=" +
                            "\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents_ab_tlb div[data-cmd=" +
                            "\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents_ab_tlb div[data-cmd=" +
                            "\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents_ab_tlb div[data-cmd=" +
                            "\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents_ab_tlb div[data-cmd=" +
                            "\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit ComponentCD { get; }
			public CheckBox Active { get; }
			public CheckBox Optional { get; }
			public PXTextEdit Qty { get; }
			public InputLocalizable Descr { get; }
			public PXTextEdit ClassID { get; }
                
                public c_grid_row(c_modeltemplatecomponentrecords_modeltemplatecomponents grid) : 
                        base(grid)
                {
                    ComponentCD = new PXTextEdit("ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents_ei", "Component CD", grid.Locator, "ComponentCD");
                    ComponentCD.DataField = "ComponentCD";
                    Active = new CheckBox("ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents_ei", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    Optional = new CheckBox("ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents_ei", "Optional", grid.Locator, "Optional");
                    Optional.DataField = "Optional";
                    Qty = new PXTextEdit("ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents_ei", "Qty", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    Descr = new InputLocalizable("ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents_ei", "Descr", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    ClassID = new PXTextEdit("ctl00_phG_sp1_scrollForm_tab_t4_ModelTemplateComponents_ei", "Class ID", grid.Locator, "ClassID");
                    ClassID.DataField = "ClassID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter ComponentCD { get; }
				public CheckBoxColumnFilter Active { get; }
				public CheckBoxColumnFilter Optional { get; }
				public PXTextEditColumnFilter Qty { get; }
				public PXTextEditColumnFilter Descr { get; }
				public PXTextEditColumnFilter ClassID { get; }
                
                public c_grid_header(c_modeltemplatecomponentrecords_modeltemplatecomponents grid) : 
                        base(grid)
                {
                    ComponentCD = new PXTextEditColumnFilter(grid.Row.ComponentCD);
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    Optional = new CheckBoxColumnFilter(grid.Row.Optional);
                    Qty = new PXTextEditColumnFilter(grid.Row.Qty);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    ClassID = new PXTextEditColumnFilter(grid.Row.ClassID);
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
