using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.CheckBoxButton;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
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
using Controls.ToolBarButton;
using Controls.UnknownControl;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace GeneratedWrappers.Acumatica
{
    
    
    public class PO302000_POReceiptEntry : Wrapper
    {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
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
        protected c__poreceipt_currencyinfo__rf _POReceipt_CurrencyInfo__rf { get; } = new c__poreceipt_currencyinfo__rf("ctl00_phF_form_t0_edCury_pnlRate_rf", "_POReceipt_CurrencyInfo__rf");
        protected c_currentdocument_tab CurrentDocument_tab { get; } = new c_currentdocument_tab("ctl00_phG_tab", "CurrentDocument_tab");
        protected c_transactions_grid Transactions_grid { get; } = new c_transactions_grid("ctl00_phG_tab_t0_grid", "transactions_grid");
        protected c_transactions_lv0 Transactions_lv0 { get; } = new c_transactions_lv0("ctl00_phG_tab_t0_grid_lv0", "transactions_lv0");
        protected c_receiptorderslink_formorders ReceiptOrdersLink_formOrders { get; } = new c_receiptorderslink_formorders("ctl00_phG_tab_t1_formOrders", "ReceiptOrdersLink_formOrders");
        protected c_receiptorderslink_lv0 ReceiptOrdersLink_lv0 { get; } = new c_receiptorderslink_lv0("ctl00_phG_tab_t1_formOrders_lv0", "ReceiptOrdersLink_lv0");
        protected c_relatedtransfers_formtransfers RelatedTransfers_formTransfers { get; } = new c_relatedtransfers_formtransfers("ctl00_phG_tab_t2_formTransfers", "RelatedTransfers_formTransfers");
        protected c_relatedtransfers_lv0 RelatedTransfers_lv0 { get; } = new c_relatedtransfers_lv0("ctl00_phG_tab_t2_formTransfers_lv0", "RelatedTransfers_lv0");
        protected c_splits_grid2 Splits_grid2 { get; } = new c_splits_grid2("ctl00_phG_PanelLS_grid2", "splits_grid2");
        protected c_splits_lv0 Splits_lv0 { get; } = new c_splits_lv0("ctl00_phG_PanelLS_grid2_lv0", "splits_lv0");
        protected c_opentransfers_gridopentransfers Opentransfers_gridopentransfers { get; } = new c_opentransfers_gridopentransfers("ctl00_phG_PanelAddTransfer_gridOpenTransfers", "openTransfers_gridOpenTransfers");
        protected c_opentransfers_lv0 Opentransfers_lv0 { get; } = new c_opentransfers_lv0("ctl00_phG_PanelAddTransfer_gridOpenTransfers_lv0", "openTransfers_lv0");
        protected c_landedcosts_gridlandedcosts Landedcosts_gridlandedcosts { get; } = new c_landedcosts_gridlandedcosts("ctl00_phG_tab_t5_gridLandedCosts", "landedCosts_gridLandedCosts");
        protected c_landedcosts_lv0 Landedcosts_lv0 { get; } = new c_landedcosts_lv0("ctl00_phG_tab_t5_gridLandedCosts_lv0", "landedCosts_lv0");
        protected c_apdocs_formbasecurrencymessage Apdocs_formbasecurrencymessage { get; } = new c_apdocs_formbasecurrencymessage("ctl00_phG_tab_t4_formBaseCurrencyMessage", "apDocs_formBaseCurrencyMessage");
        protected c_apdocs_formbillinghistory ApDocs_formBillingHistory { get; } = new c_apdocs_formbillinghistory("ctl00_phG_tab_t4_formBillingHistory", "ApDocs_formBillingHistory");
        protected c_apdocs_lv0 ApDocs_lv0 { get; } = new c_apdocs_lv0("ctl00_phG_tab_t4_formBillingHistory_lv0", "ApDocs_lv0");
        protected c_receipthistory_formprhistory ReceiptHistory_formPRHistory { get; } = new c_receipthistory_formprhistory("ctl00_phG_tab_t3_formPRHistory", "ReceiptHistory_formPRHistory");
        protected c_receipthistory_lv0 ReceiptHistory_lv0 { get; } = new c_receipthistory_lv0("ctl00_phG_tab_t3_formPRHistory_lv0", "ReceiptHistory_lv0");
        protected c_filter_frmpofilter Filter_frmpofilter { get; } = new c_filter_frmpofilter("ctl00_phG_PanelAddPOLine_frmPOFilter", "filter_frmPOFilter");
        protected c_filter_frmorderfilter1 Filter_frmorderfilter1 { get; } = new c_filter_frmorderfilter1("ctl00_phG_PanelAddPO_frmOrderFilter1", "filter_frmOrderFilter1");
        protected c_filter_formtransferfilter1 Filter_formtransferfilter1 { get; } = new c_filter_formtransferfilter1("ctl00_phG_PanelAddTransfer_formTransferFilter1", "filter_formTransferFilter1");
        protected c_filter_frmtransferfilter Filter_frmtransferfilter { get; } = new c_filter_frmtransferfilter("ctl00_phG_PanelAddINTran_frmTransferFilter", "filter_frmTransferFilter");
        protected c_addreceipt_frmreceipt Addreceipt_frmreceipt { get; } = new c_addreceipt_frmreceipt("ctl00_phG_PanelAddRL_frmReceipt", "addReceipt_frmReceipt");
        protected c_intranselection_pxgrid1 Intranselection_pxgrid1 { get; } = new c_intranselection_pxgrid1("ctl00_phG_PanelAddINTran_PXGrid1", "intranSelection_PXGrid1");
        protected c_intranselection_lv0 Intranselection_lv0 { get; } = new c_intranselection_lv0("ctl00_phG_PanelAddINTran_PXGrid1_lv0", "intranSelection_lv0");
        protected c_returnfilter_frmreceiptreturnfilter Returnfilter_frmreceiptreturnfilter { get; } = new c_returnfilter_frmreceiptreturnfilter("ctl00_phG_panelAddReceiptReturn_frmReceiptReturnFilter", "returnFilter_frmReceiptReturnFilter");
        protected c_returnfilter_frmreceiptreturnlinefilter Returnfilter_frmreceiptreturnlinefilter { get; } = new c_returnfilter_frmreceiptreturnlinefilter("ctl00_phG_panelAddReceiptLineReturn_frmReceiptReturnLineFilter", "returnFilter_frmReceiptReturnLineFilter");
        protected c_lsporeceiptline_lotseropts_optform LSPOReceiptLine_lotseropts_optform { get; } = new c_lsporeceiptline_lotseropts_optform("ctl00_phG_PanelLS_optform", "LSPOReceiptLine_lotseropts_optform");
        protected c_polinesselection_gridol Polinesselection_gridol { get; } = new c_polinesselection_gridol("ctl00_phG_PanelAddPOLine_gridOL", "poLinesSelection_gridOL");
        protected c_polinesselection_lv0 Polinesselection_lv0 { get; } = new c_polinesselection_lv0("ctl00_phG_PanelAddPOLine_gridOL_lv0", "poLinesSelection_lv0");
        protected c_openorders_grdopenorders Openorders_grdopenorders { get; } = new c_openorders_grdopenorders("ctl00_phG_PanelAddPO_grdOpenOrders", "openOrders_grdOpenOrders");
        protected c_openorders_lv0 Openorders_lv0 { get; } = new c_openorders_lv0("ctl00_phG_PanelAddPO_grdOpenOrders_lv0", "openOrders_lv0");
        protected c_poreceiptreturn_grdreceiptreturn Poreceiptreturn_grdreceiptreturn { get; } = new c_poreceiptreturn_grdreceiptreturn("ctl00_phG_panelAddReceiptReturn_grdReceiptReturn", "poReceiptReturn_grdReceiptReturn");
        protected c_poreceiptreturn_lv0 Poreceiptreturn_lv0 { get; } = new c_poreceiptreturn_lv0("ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_lv0", "poReceiptReturn_lv0");
        protected c_poreceiptlinereturn_grdreceiptlinereturn Poreceiptlinereturn_grdreceiptlinereturn { get; } = new c_poreceiptlinereturn_grdreceiptlinereturn("ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn", "poReceiptLineReturn_grdReceiptLineReturn");
        protected c_poreceiptlinereturn_lv0 Poreceiptlinereturn_lv0 { get; } = new c_poreceiptlinereturn_lv0("ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_lv0", "poReceiptLineReturn_lv0");
        protected c_workflowview_workflowfictivediagram WorkflowView_WorkflowFictiveDiagram { get; } = new c_workflowview_workflowfictivediagram("ctl00_usrCaption_WorkflowDiagram_pnlWorkFlow_WorkflowFictiveDiagram", "WorkflowView_WorkflowFictiveDiagram");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        public c_attributes Attributes { get; } = new c_attributes("ctl00_phF_form_t1", "Attributes");
        
        public PO302000_POReceiptEntry()
        {
            ScreenId = "PO302000";
            ScreenUrl = "/Pages/PO/PO302000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual PO302000_POReceiptEntry ReadOne(Gate gate, string ReceiptType, string ReceiptNbr)
        {
            new BiObject<PO302000_POReceiptEntry>(gate).ReadOne(this, ReceiptType, ReceiptNbr);
            return this;
        }
        
        public virtual PO302000_POReceiptEntry ReadOne(string ReceiptType, string ReceiptNbr)
        {
            return this.ReadOne(ApiConnection.Source, ReceiptType, ReceiptNbr);
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
        
        public virtual void PutOnHold()
        {
            ToolBar.PutOnHold.Click();
        }
        
        public virtual void Release()
        {
            ToolBar.Release.Click();
        }
        
        public virtual void Release(bool status, string message = null)
        {
            ToolBar.Release.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.Release.Click();
        }
        
        public virtual void CreateAPDocument()
        {
            ToolBar.CreateAPDocument.Click();
        }
        
        public virtual void CreateAPDocument(bool status, string message = null)
        {
            ToolBar.CreateAPDocument.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.CreateAPDocument.Click();
        }
        
        public virtual void CreateLCDocument()
        {
            ToolBar.CreateLCDocument.Click();
        }
        
        public virtual void CreateLCDocument(bool status, string message = null)
        {
            ToolBar.CreateLCDocument.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.CreateLCDocument.Click();
        }
        
        public virtual void CreateReturn()
        {
            ToolBar.CreateReturn.Click();
        }
        
        public virtual void GenerateSalesReturn()
        {
            ToolBar.GenerateSalesReturn.Click();
        }
        
        public virtual void PrintPurchaseReceipt()
        {
            ToolBar.PrintPurchaseReceipt.Click();
        }
        
        public virtual void EmailPurchaseReceipt()
        {
            ToolBar.EmailPurchaseReceipt.Click();
        }
        
        public virtual void Assign()
        {
            ToolBar.Assign.Click();
        }
        
        public virtual void PrintBillingDetail()
        {
            ToolBar.PrintBillingDetail.Click();
        }
        
        public virtual void PrintAllocated()
        {
            ToolBar.PrintAllocated.Click();
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
        
        public virtual void Notification()
        {
            ToolBar.Notification.Click();
        }
        
        public virtual void Notification(bool status, string message = null)
        {
            ToolBar.Notification.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.Notification.Click();
        }
        
        public virtual void AddINTran()
        {
            ToolBar.AddINTran.Click();
        }
        
        public virtual void AddINTran2()
        {
            ToolBar.AddINTran2.Click();
        }
        
        public virtual void SoordershipmentDisplayshippingrefnoteidLink()
        {
            ToolBar.SoordershipmentDisplayshippingrefnoteidLink.Click();
        }
        
        public virtual void ProcessingCategory()
        {
            ToolBar.ProcessingCategory.Click();
        }
        
        public virtual void IntercompanyCategory()
        {
            ToolBar.IntercompanyCategory.Click();
        }
        
        public virtual void PrintingAndEmailingCategory()
        {
            ToolBar.PrintingAndEmailingCategory.Click();
        }
        
        public virtual void OtherCategory()
        {
            ToolBar.OtherCategory.Click();
        }
        
        public virtual void Report()
        {
            ToolBar.Report.Click();
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
			public ToolBarButton PutOnHold { get; }
			public ToolBarButton Release { get; }
			public ToolBarButton CreateAPDocument { get; }
			public ToolBarButton CreateLCDocument { get; }
			public ToolBarButton CreateReturn { get; }
			public ToolBarButton GenerateSalesReturn { get; }
			public ToolBarButton PrintPurchaseReceipt { get; }
			public ToolBarButton EmailPurchaseReceipt { get; }
			public ToolBarButton Assign { get; }
			public ToolBarButton PrintBillingDetail { get; }
			public ToolBarButton PrintAllocated { get; }
			public ToolBarButton ViewActivity { get; }
			public ToolBarButton ViewactivityWorkflow { get; }
			public ToolBarButton OpenActivityOwner { get; }
			public ToolBarButton OpenactivityownerWorkflow { get; }
			public ToolBarButton ViewAllActivities { get; }
			public ToolBarButton ViewallactivitiesWorkflow { get; }
			public ToolBarButton Notification { get; }
			public ToolBarButton AddINTran { get; }
			public ToolBarButton AddINTran2 { get; }
			public ToolBarButton SoordershipmentDisplayshippingrefnoteidLink { get; }
			public ToolBarButton ProcessingCategory { get; }
			public ToolBarButton IntercompanyCategory { get; }
			public ToolBarButton PrintingAndEmailingCategory { get; }
			public ToolBarButton OtherCategory { get; }
			public ToolBarButton Report { get; }
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
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_cancel", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                Insert = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Insert", "Add New Record (Ctrl+Ins)", locator, null);
                Delete = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Delete", "Delete (Ctrl+Del).", locator, null);
                Delete.ConfirmAction = () => Alert.AlertToException("The current Purchase Receipt record will be deleted.");
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
                PutOnHold = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PutOnHold,#ctl00_phDS_ds_ToolBar_PutOnHold_item", "Hold", locator, MenuOpener);
                Release = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Release,#ctl00_phDS_ds_ToolBar_Release_item", "Release", locator, MenuOpener);
                Release.WaitAction = Wait.WaitForLongOperationToComplete;
                CreateAPDocument = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CreateAPDocument,#ctl00_phDS_ds_ToolBar_CreateAPDocume" +
                        "nt_item", "Enter AP Bill", locator, MenuOpener);
                CreateAPDocument.WaitAction = Wait.WaitForLongOperationToComplete;
                CreateLCDocument = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CreateLCDocument,#ctl00_phDS_ds_ToolBar_CreateLCDocume" +
                        "nt_item", "Enter Landed Costs", locator, MenuOpener);
                CreateLCDocument.WaitAction = Wait.WaitForLongOperationToComplete;
                CreateReturn = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_CreateReturn,#ctl00_phDS_ds_ToolBar_CreateReturn_item", "Return", locator, MenuOpener);
                GenerateSalesReturn = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_GenerateSalesReturn,#ctl00_phDS_ds_ToolBar_GenerateSal" +
                        "esReturn_item", "Generate Sales Return", locator, MenuOpener);
                PrintPurchaseReceipt = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PrintPurchaseReceipt,#ctl00_phDS_ds_ToolBar_PrintPurch" +
                        "aseReceipt_item", "Print Purchase Receipt", locator, MenuOpener);
                EmailPurchaseReceipt = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_EmailPurchaseReceipt,#ctl00_phDS_ds_ToolBar_EmailPurch" +
                        "aseReceipt_item", "Email Purchase Receipt", locator, MenuOpener);
                Assign = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Assign,#ctl00_phDS_ds_ToolBar_Assign_item", "Apply Assignment Rules", locator, MenuOpener);
                PrintBillingDetail = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PrintBillingDetail,#ctl00_phDS_ds_ToolBar_PrintBilling" +
                        "Detail_item", "Purchase Receipt Billing History", locator, MenuOpener);
                PrintAllocated = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_PrintAllocated,#ctl00_phDS_ds_ToolBar_PrintAllocated_i" +
                        "tem", "Purchase Receipt Allocated and Backordered", locator, MenuOpener);
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
                Notification = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Notification,#ctl00_phDS_ds_ToolBar_Notification_item", "Notifications", locator, MenuOpener);
                Notification.WaitAction = Wait.WaitForLongOperationToComplete;
                AddINTran = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_AddINTran,#ctl00_phDS_ds_ToolBar_AddINTran_item", "Add Transfer Line", locator, MenuOpener);
                AddINTran2 = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_AddINTran2,#ctl00_phDS_ds_ToolBar_AddINTran2_item", "Add Transfer Line", locator, MenuOpener);
                SoordershipmentDisplayshippingrefnoteidLink = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_SOOrderShipment~DisplayShippingRefNoteID~Link,#ctl00_p" +
                        "hDS_ds_ToolBar_SOOrderShipment~DisplayShippingRefNoteID~Link_item", "SOOrderShipment\r\nDisplayShippingRefNoteID\r\nLink", locator, MenuOpener);
                ProcessingCategory = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Processing_Category", "Processing", locator, MenuOpener);
                IntercompanyCategory = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Intercompany_Category", "Intercompany", locator, MenuOpener);
                PrintingAndEmailingCategory = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Printing_and_Emailing_Category", "Printing and Emailing", locator, MenuOpener);
                OtherCategory = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Other_Category", "Other", locator, MenuOpener);
                Report = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Report", "Reports", locator, MenuOpener);
                LongRun = new ToolBarButton("css=qp-long-run", "Nothing in progress", locator, null);
                LongrunCancel = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_cancel", "Cancel", locator, null);
                LongrunTimer = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_timer", "Elapsed Time", locator, null);
            }
        }
        
        public class c_document_form : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown ReceiptType { get; }
			public Label ReceiptTypeLabel { get; }
			public Selector ReceiptNbr { get; }
			public Label ReceiptNbrLabel { get; }
			public DropDown Status { get; }
			public Label StatusLabel { get; }
			public DateSelector ReceiptDate { get; }
			public Label ReceiptDateLabel { get; }
			public Selector FinPeriodID { get; }
			public Label FinPeriodIDLabel { get; }
			public Selector VendorID { get; }
			public Label VendorIDLabel { get; }
			public Selector VendorLocationID { get; }
			public Label VendorLocationIDLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public Selector ProjectID { get; }
			public Label ProjectIDLabel { get; }
			public Selector CuryID { get; }
			public Label CuryIDLabel { get; }
			public CheckBoxButton CuryViewState { get; }
			public Label CuryViewStateLabel { get; }
			public CheckBox AutoCreateInvoice { get; }
			public Label AutoCreateInvoiceLabel { get; }
			public DropDown ReturnInventoryCostMode { get; }
			public Label ReturnInventoryCostModeLabel { get; }
			public PXTextEdit InvoiceNbr { get; }
			public Label InvoiceNbrLabel { get; }
			public Selector WorkgroupID { get; }
			public Label WorkgroupIDLabel { get; }
			public Selector OwnerID { get; }
			public Label OwnerIDLabel { get; }
			public PXNumberEdit OrderQty { get; }
			public Label OrderQtyLabel { get; }
			public PXNumberEdit ControlQty { get; }
			public Label ControlQtyLabel { get; }
			public PXNumberEdit UnbilledQty { get; }
			public Label UnbilledQtyLabel { get; }
			public PXNumberEdit CuryOrderTotal { get; }
			public Label CuryOrderTotalLabel { get; }
			public CheckBox ShowPurchaseOrdersTab { get; }
			public Label ShowPurchaseOrdersTabLabel { get; }
			public CheckBox ShowPutAwayHistoryTab { get; }
			public Label ShowPutAwayHistoryTabLabel { get; }
			public CheckBox ShowLandedCostsTab { get; }
			public Label ShowLandedCostsTabLabel { get; }
			public Label LblCount_ { get; }
			public Label LblEQ_ { get; }
			public Label LblCount2_ { get; }
			public Label LblEQ2_ { get; }
			public Label Ctl02_ { get; }
            
            public c_document_form(string locator, string name) : 
                    base(locator, name)
            {
                ReceiptType = new DropDown("ctl00_phF_form_t0_edReceiptType", "Type", locator, null);
                ReceiptTypeLabel = new Label(ReceiptType);
                ReceiptType.DataField = "ReceiptType";
                ReceiptType.Items.Add("RT", "Receipt");
                ReceiptType.Items.Add("RN", "Return");
                ReceiptType.Items.Add("RX", "Transfer Receipt");
                ReceiptNbr = new Selector("ctl00_phF_form_t0_edReceiptNbr", "Receipt Nbr.", locator, null);
                ReceiptNbrLabel = new Label(ReceiptNbr);
                ReceiptNbr.DataField = "ReceiptNbr";
                Status = new DropDown("ctl00_phF_form_t0_edStatus", "Status", locator, null);
                StatusLabel = new Label(Status);
                Status.DataField = "Status";
                Status.Items.Add("H", "On Hold");
                Status.Items.Add("B", "Balanced");
                Status.Items.Add("R", "Released");
                ReceiptDate = new DateSelector("ctl00_phF_form_t0_edReceiptDate", "Date", locator, null);
                ReceiptDateLabel = new Label(ReceiptDate);
                ReceiptDate.DataField = "ReceiptDate";
                FinPeriodID = new Selector("ctl00_phF_form_t0_edFinPeriodID", "Post Period", locator, null);
                FinPeriodIDLabel = new Label(FinPeriodID);
                FinPeriodID.DataField = "FinPeriodID";
                VendorID = new Selector("ctl00_phF_form_t0_edVendorID", "Vendor", locator, null);
                VendorIDLabel = new Label(VendorID);
                VendorID.DataField = "VendorID";
                VendorLocationID = new Selector("ctl00_phF_form_t0_edVendorLocationID", "Location", locator, null);
                VendorLocationIDLabel = new Label(VendorLocationID);
                VendorLocationID.DataField = "VendorLocationID";
                SiteID = new Selector("ctl00_phF_form_t0_edSiteID", "Warehouse", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                ProjectID = new Selector("ctl00_phF_form_t0_edHeadProjectID", "Project", locator, null);
                ProjectIDLabel = new Label(ProjectID);
                ProjectID.DataField = "ProjectID";
                CuryID = new Selector("ctl00_phF_form_t0_edCury_cury", "Cury ID", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                CuryViewState = new CheckBoxButton("ctl00_phF_form_t0_edCury_curyB", "CuryViewState", locator, null);
                CuryViewStateLabel = new Label(CuryViewState);
                CuryViewState.DataField = "CuryViewState";
                AutoCreateInvoice = new CheckBox("ctl00_phF_form_t0_chkAutoCreateInvoice", "Create Bill", locator, null);
                AutoCreateInvoiceLabel = new Label(AutoCreateInvoice);
                AutoCreateInvoice.DataField = "AutoCreateInvoice";
                ReturnInventoryCostMode = new DropDown("ctl00_phF_form_t0_edReturnInventoryCostMode", "Cost of Inventory Return From", locator, null);
                ReturnInventoryCostModeLabel = new Label(ReturnInventoryCostMode);
                ReturnInventoryCostMode.DataField = "ReturnInventoryCostMode";
                ReturnInventoryCostMode.Items.Add("O", "Original Cost from Receipt");
                ReturnInventoryCostMode.Items.Add("I", "Cost by Issue Strategy");
                ReturnInventoryCostMode.Items.Add("M", "Manual Cost Input");
                InvoiceNbr = new PXTextEdit("ctl00_phF_form_t0_edInvoiceNbr", "Vendor Ref.", locator, null);
                InvoiceNbrLabel = new Label(InvoiceNbr);
                InvoiceNbr.DataField = "InvoiceNbr";
                WorkgroupID = new Selector("ctl00_phF_form_t0_trsWorkgroupID", "Workgroup", locator, null);
                WorkgroupIDLabel = new Label(WorkgroupID);
                WorkgroupID.DataField = "WorkgroupID";
                OwnerID = new Selector("ctl00_phF_form_t0_edOwnerID", "Owner", locator, null);
                OwnerIDLabel = new Label(OwnerID);
                OwnerID.DataField = "OwnerID";
                OrderQty = new PXNumberEdit("ctl00_phF_form_t0_edOrderQty", "Total Qty.", locator, null);
                OrderQtyLabel = new Label(OrderQty);
                OrderQty.DataField = "OrderQty";
                ControlQty = new PXNumberEdit("ctl00_phF_form_t0_edControlQty", "Control Qty.", locator, null);
                ControlQtyLabel = new Label(ControlQty);
                ControlQty.DataField = "ControlQty";
                UnbilledQty = new PXNumberEdit("ctl00_phF_form_t0_edUnbilledQty", "Unbilled Quantity", locator, null);
                UnbilledQtyLabel = new Label(UnbilledQty);
                UnbilledQty.DataField = "UnbilledQty";
                CuryOrderTotal = new PXNumberEdit("ctl00_phF_form_t0_edCuryOrderTotal", "Total Cost", locator, null);
                CuryOrderTotalLabel = new Label(CuryOrderTotal);
                CuryOrderTotal.DataField = "CuryOrderTotal";
                ShowPurchaseOrdersTab = new CheckBox("ctl00_phF_form_t0_chkShowPurchaseOrdersTab", "ShowPurchaseOrdersTab", locator, null);
                ShowPurchaseOrdersTabLabel = new Label(ShowPurchaseOrdersTab);
                ShowPurchaseOrdersTab.DataField = "ShowPurchaseOrdersTab";
                ShowPutAwayHistoryTab = new CheckBox("ctl00_phF_form_t0_chkShowPutAwayHistoryTab", "ShowPutAwayHistoryTab", locator, null);
                ShowPutAwayHistoryTabLabel = new Label(ShowPutAwayHistoryTab);
                ShowPutAwayHistoryTab.DataField = "ShowPutAwayHistoryTab";
                ShowLandedCostsTab = new CheckBox("ctl00_phF_form_t0_chkShowLandedCostsTab", "ShowLandedCostsTab", locator, null);
                ShowLandedCostsTabLabel = new Label(ShowLandedCostsTab);
                ShowLandedCostsTab.DataField = "ShowLandedCostsTab";
                LblCount_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblCount", "1.000", locator, null);
                LblEQ_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblEQ", "=", locator, null);
                LblCount2_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblCount2", "1.000", locator, null);
                LblEQ2_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblEQ2", "=", locator, null);
                Ctl02_ = new Label("ctl00_phF_form_t1_ctl02", "No user-defined fields have been found.", locator, null);
                DataMemberName = "Document";
                Buttons = new PxButtonCollection();
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
            
            public virtual void VendorIDEdit()
            {
                Buttons.VendorIDEdit.Click();
            }
            
            public virtual void SiteIDEdit()
            {
                Buttons.SiteIDEdit.Click();
            }
            
            public virtual void ProjectIDEdit()
            {
                Buttons.ProjectIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Unnamed { get; }
			public Button Viewbase { get; }
			public Button Ok { get; }
			public Button VendorIDEdit { get; }
			public Button SiteIDEdit { get; }
			public Button ProjectIDEdit { get; }
                
                public PxButtonCollection()
                {
                    Unnamed = new Button("ctl00_phF_form_t0_edCury_rateB", "0", "ctl00_phF_form");
                    Viewbase = new Button("ctl00_phF_form_t0_edCury_curyB", "View base", "ctl00_phF_form");
                    Ok = new Button("ctl00_phF_form_t0_edCury_pnlRate_btnOk", "OK", "ctl00_phF_form");
                    VendorIDEdit = new Button("css=div[id=\'ctl00_phF_form_t0_edVendorID\'] div[class=\'editBtnCont\'] > div > div", "VendorIDEdit", "ctl00_phF_form");
                    VendorIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    SiteIDEdit = new Button("css=div[id=\'ctl00_phF_form_t0_edSiteID\'] div[class=\'editBtnCont\'] > div > div", "SiteIDEdit", "ctl00_phF_form");
                    SiteIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    ProjectIDEdit = new Button("css=div[id=\'ctl00_phF_form_t0_edHeadProjectID\'] div[class=\'editBtnCont\'] > div > " +
                            "div", "ProjectIDEdit", "ctl00_phF_form");
                    ProjectIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
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
        
        public class c__poreceipt_currencyinfo__rf : Container
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
            
            public c__poreceipt_currencyinfo__rf(string locator, string name) : 
                    base(locator, name)
            {
                CuryRateTypeID = new Selector("ctl00_phF_form_t0_edCury_pnlRate_rf_edRateType", "Curr. Rate Type ID", locator, null);
                CuryRateTypeIDLabel = new Label(CuryRateTypeID);
                CuryRateTypeID.DataField = "CuryRateTypeID";
                CuryEffDate = new DateSelector("ctl00_phF_form_t0_edCury_pnlRate_rf_edEffDate", "Effective Date", locator, null);
                CuryEffDateLabel = new Label(CuryEffDate);
                CuryEffDate.DataField = "CuryEffDate";
                DisplayCuryID = new PXTextEdit("ctl00_phF_form_t0_edCury_pnlRate_rf_txtCury", "Display Cury ID", locator, null);
                DisplayCuryIDLabel = new Label(DisplayCuryID);
                DisplayCuryID.DataField = "DisplayCuryID";
                SampleCuryRate = new PXNumberEdit("ctl00_phF_form_t0_edCury_pnlRate_rf_txtCuryRate", "Sample Cury Rate", locator, null);
                SampleCuryRateLabel = new Label(SampleCuryRate);
                SampleCuryRate.DataField = "SampleCuryRate";
                BaseCuryID = new PXTextEdit("ctl00_phF_form_t0_edCury_pnlRate_rf_txtBaseCury", "Base Cury ID", locator, null);
                BaseCuryIDLabel = new Label(BaseCuryID);
                BaseCuryID.DataField = "BaseCuryID";
                BaseCuryID2 = new PXTextEdit("ctl00_phF_form_t0_edCury_pnlRate_rf_txtBaseCury2", "Base Cury ID 2", locator, null);
                BaseCuryID2Label = new Label(BaseCuryID2);
                BaseCuryID2.DataField = "BaseCuryID";
                SampleRecipRate = new PXNumberEdit("ctl00_phF_form_t0_edCury_pnlRate_rf_txtCuryRate2", "Sample Recip Rate", locator, null);
                SampleRecipRateLabel = new Label(SampleRecipRate);
                SampleRecipRate.DataField = "SampleRecipRate";
                DisplayCuryID2 = new PXTextEdit("ctl00_phF_form_t0_edCury_pnlRate_rf_txtCury2", "Display Cury ID 2", locator, null);
                DisplayCuryID2Label = new Label(DisplayCuryID2);
                DisplayCuryID2.DataField = "DisplayCuryID";
                LblCount_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblCount", "1.000", locator, null);
                LblEQ_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblEQ", "=", locator, null);
                LblCount2_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblCount2", "1.000", locator, null);
                LblEQ2_ = new Label("ctl00_phF_form_t0_edCury_pnlRate_rf_lblEQ2", "=", locator, null);
                DataMemberName = "_POReceipt_CurrencyInfo_";
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
                    Ok = new Button("ctl00_phF_form_t0_edCury_pnlRate_btnOk", "OK", "ctl00_phF_form_t0_edCury_pnlRate_rf");
                }
            }
        }
        
        public class c_currentdocument_tab : Container
        {
            
			public Selector InventoryRefNbr { get; }
			public Label InventoryRefNbrLabel { get; }
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
			public PXTextEdit BranchBaseCuryID { get; }
			public Label BranchBaseCuryIDLabel { get; }
			public DateSelector InvoiceDate { get; }
			public Label InvoiceDateLabel { get; }
			public Selector SOOrderNbr { get; }
			public Label SOOrderNbrLabel { get; }
			public Selector IntercompanyShipmentNbr { get; }
			public Label IntercompanyShipmentNbrLabel { get; }
			public Selector IntercompanySOType { get; }
			public Label IntercompanySOTypeLabel { get; }
			public Selector IntercompanySONbr { get; }
			public Label IntercompanySONbrLabel { get; }
			public CheckBox ExcludeFromIntercompanyProc { get; }
			public Label ExcludeFromIntercompanyProcLabel { get; }
			public Label LblAmountsCurrency_ { get; }
            
            public c_currentdocument_tab(string locator, string name) : 
                    base(locator, name)
            {
                InventoryRefNbr = new Selector("ctl00_phG_tab_t6_edInventoryRefNbr", "IN Ref. Nbr.", locator, null);
                InventoryRefNbrLabel = new Label(InventoryRefNbr);
                InventoryRefNbr.DataField = "InventoryRefNbr";
                BranchID = new Selector("ctl00_phG_tab_t6_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                BranchBaseCuryID = new PXTextEdit("ctl00_phG_tab_t6_edBranchBaseCuryID", "Base Currency", locator, null);
                BranchBaseCuryIDLabel = new Label(BranchBaseCuryID);
                BranchBaseCuryID.DataField = "BranchBaseCuryID";
                InvoiceDate = new DateSelector("ctl00_phG_tab_t6_edInvoiceDate", "Bill Date", locator, null);
                InvoiceDateLabel = new Label(InvoiceDate);
                InvoiceDate.DataField = "InvoiceDate";
                SOOrderNbr = new Selector("ctl00_phG_tab_t6_edSOOrderNbr", "SO Return", locator, null);
                SOOrderNbrLabel = new Label(SOOrderNbr);
                SOOrderNbr.DataField = "SOOrderNbr";
                IntercompanyShipmentNbr = new Selector("ctl00_phG_tab_t6_edIntercompanyShipmentNbr", "Related Shipment Nbr.", locator, null);
                IntercompanyShipmentNbrLabel = new Label(IntercompanyShipmentNbr);
                IntercompanyShipmentNbr.DataField = "IntercompanyShipmentNbr";
                IntercompanySOType = new Selector("ctl00_phG_tab_t6_edIntercompanySOType", "Related Order Type", locator, null);
                IntercompanySOTypeLabel = new Label(IntercompanySOType);
                IntercompanySOType.DataField = "IntercompanySOType";
                IntercompanySONbr = new Selector("ctl00_phG_tab_t6_edIntercompanySONbr", "Related Order Nbr.", locator, null);
                IntercompanySONbrLabel = new Label(IntercompanySONbr);
                IntercompanySONbr.DataField = "IntercompanySONbr";
                ExcludeFromIntercompanyProc = new CheckBox("ctl00_phG_tab_t6_chkExcludeFromIntercompanyProc", "Exclude from Intercompany Processing", locator, null);
                ExcludeFromIntercompanyProcLabel = new Label(ExcludeFromIntercompanyProc);
                ExcludeFromIntercompanyProc.DataField = "ExcludeFromIntercompanyProc";
                LblAmountsCurrency_ = new Label("ctl00_phG_tab_t4_formBaseCurrencyMessage_lblAmountsCurrency", "The values in the Billed Amt., Accrued Amt., and PPV Amt columns are always shown" +
                        " in the base currency.", locator, null);
                DataMemberName = "CurrentDocument";
            }
        }
        
        public class c_transactions_grid : Grid<c_transactions_grid.c_grid_row, c_transactions_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            private Label _StatusBar = new Label("ctl00_phG_tab_t0_grid_ab_tlb_ul", "Status Bar", "ctl00_phG_tab_t0_grid", null);
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_transactions_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t0_grid");
                DataMemberName = "transactions";
                Buttons = new PxButtonCollection();
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
            
            public virtual void AddLine()
            {
                ToolBar.AddLine.Click();
            }
            
            public virtual void AddPo()
            {
                ToolBar.AddPo.Click();
            }
            
            public virtual void AddPoLine()
            {
                ToolBar.AddPoLine.Click();
            }
            
            public virtual void AddPr()
            {
                ToolBar.AddPr.Click();
            }
            
            public virtual void AddPrLine()
            {
                ToolBar.AddPrLine.Click();
            }
            
            public virtual void AddTransfer()
            {
                ToolBar.AddTransfer.Click();
            }
            
            public virtual void ViewPo()
            {
                ToolBar.ViewPo.Click();
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
            
            public virtual void PONbrEdit()
            {
                Buttons.PONbrEdit.Click();
            }
            
            public virtual void SOOrderNbrEdit()
            {
                Buttons.SOOrderNbrEdit.Click();
            }
            
            public virtual void SOShipmentNbrEdit()
            {
                Buttons.SOShipmentNbrEdit.Click();
            }
            
            public virtual void OrigReceiptNbrEdit()
            {
                Buttons.OrigReceiptNbrEdit.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid FormView { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid LineDetails { get; }
			public ToolBarButtonGrid AddLine { get; }
			public ToolBarButtonGrid AddPo { get; }
			public ToolBarButtonGrid AddPoLine { get; }
			public ToolBarButtonGrid AddPr { get; }
			public ToolBarButtonGrid AddPrLine { get; }
			public ToolBarButtonGrid AddTransfer { get; }
			public ToolBarButtonGrid ViewPo { get; }
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
                    AddLine = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdAddReceiptLine\']", "Add Line", locator, null);
                    AddPo = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdPO\']", "Add PO", locator, null);
                    AddPoLine = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdAddPOLine\']", "Add PO Line", locator, null);
                    AddPr = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdPOReceiptReturn\']", "Add PR", locator, null);
                    AddPrLine = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdPOReceiptLineReturn\']", "Add PR Line", locator, null);
                    AddTransfer = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdAddTransfer\']", "Add Transfer", locator, null);
                    ViewPo = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_grid_at_tlb div[data-cmd=\'cmdViewPOOrder\']", "View PO", locator, null);
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
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button PONbrEdit { get; }
			public Button SOOrderNbrEdit { get; }
			public Button SOShipmentNbrEdit { get; }
			public Button OrigReceiptNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    PONbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edPONbr\'] div[class=\'editBtnCont\'] > div > " +
                            "div", "PONbrEdit", "ctl00_phG_tab_t0_grid");
                    PONbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    SOOrderNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edSOOrderNbr\'] div[class=\'editBtnCont\'] > d" +
                            "iv > div", "SOOrderNbrEdit", "ctl00_phG_tab_t0_grid");
                    SOOrderNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    SOShipmentNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edSOShipmentNbr\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "SOShipmentNbrEdit", "ctl00_phG_tab_t0_grid");
                    SOShipmentNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    OrigReceiptNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edOrigReceiptNbr\'] div[class=\'editBtnCont\']" +
                            " > div > div", "OrigReceiptNbrEdit", "ctl00_phG_tab_t0_grid");
                    OrigReceiptNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXTextEdit Availability { get; }
			public CheckBox Selected { get; }
			public Selector BranchID { get; }
			public Selector InventoryID { get; }
			public DropDown LineType { get; }
			public Selector SubItemID { get; }
			public Selector SiteID { get; }
			public Selector LocationID { get; }
			public PXTextEdit TranDesc { get; }
			public Selector UOM { get; }
			public PXNumberEdit OrigOrderQty { get; }
			public PXNumberEdit OpenOrderQty { get; }
			public PXNumberEdit ReceiptQty { get; }
			public PXNumberEdit BaseReceiptQty { get; }
			public Selector OrigReceiptNbr { get; }
			public PXNumberEdit OrigReceiptLineNbr { get; }
			public Selector ExpenseAcctID { get; }
			public PXTextEdit ExpenseAcctID_Account_description { get; }
			public Selector ExpenseSubID { get; }
			public Selector POAccrualAcctID { get; }
			public Selector POAccrualSubID { get; }
			public Selector ProjectID { get; }
			public Selector TaskID { get; }
			public Selector CostCodeID { get; }
			public DateSelector ExpireDate { get; }
			public PXNumberEdit LineNbr { get; }
			public PXNumberEdit SortOrder { get; }
			public Selector LotSerialNbr { get; }
			public DropDown POType { get; }
			public Selector PONbr { get; }
			public PXNumberEdit POLineNbr { get; }
			public PXTextEdit SOOrderType { get; }
			public Selector SOOrderNbr { get; }
			public PXNumberEdit SOOrderLineNbr { get; }
			public Selector SOShipmentNbr { get; }
			public CheckBox AllowComplete { get; }
			public CheckBox AllowOpen { get; }
			public PXNumberEdit ReturnedQty { get; }
			public Selector ReasonCode { get; }
			public CheckBox AllowEditUnitCost { get; }
			public PXNumberEdit CuryUnitCost { get; }
			public PXNumberEdit CuryExtCost { get; }
			public PXNumberEdit TranCost { get; }
			public PXNumberEdit TranCostFinal { get; }
			public PXTextEdit ReceiptNbr { get; }
                
                public c_grid_row(c_transactions_grid grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Availability = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edAvailability", "Availability", grid.Locator, "Availability");
                    Availability.DataField = "Availability";
                    Selected = new CheckBox("ctl00_phG_tab_t0_grid", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    BranchID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edBranchID", "Branch", grid.Locator, "BranchID");
                    BranchID.DataField = "BranchID";
                    InventoryID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edInventoryID", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    LineType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edLineType", "Line Type", grid.Locator, "LineType");
                    LineType.DataField = "LineType";
                    LineType.Items.Add("GI", "Goods for IN");
                    LineType.Items.Add("NS", "Non-Stock");
                    LineType.Items.Add("SV", "Service");
                    LineType.Items.Add("FT", "Freight");
                    SubItemID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSubItemID", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    SiteID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSiteID", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    LocationID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edLocationID", "Location", grid.Locator, "LocationID");
                    LocationID.DataField = "LocationID";
                    TranDesc = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edTranDesc", "Transaction Descr.", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    UOM = new Selector("_ctl00_phG_tab_t0_grid_lv0_edUOM", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    OrigOrderQty = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edOrigOrderQty", "Ordered Qty.", grid.Locator, "OrigOrderQty");
                    OrigOrderQty.DataField = "OrigOrderQty";
                    OpenOrderQty = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edOperOrderQty", "Open Qty.", grid.Locator, "OpenOrderQty");
                    OpenOrderQty.DataField = "OpenOrderQty";
                    ReceiptQty = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edReceiptQty", "Receipt Qty.", grid.Locator, "ReceiptQty");
                    ReceiptQty.DataField = "ReceiptQty";
                    BaseReceiptQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Base Receipt Qty.", grid.Locator, "BaseReceiptQty");
                    BaseReceiptQty.DataField = "BaseReceiptQty";
                    OrigReceiptNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edOrigReceiptNbr", "PO Receipt Nbr.", grid.Locator, "OrigReceiptNbr");
                    OrigReceiptNbr.DataField = "OrigReceiptNbr";
                    OrigReceiptLineNbr = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "PO Receipt Line Nbr.", grid.Locator, "OrigReceiptLineNbr");
                    OrigReceiptLineNbr.DataField = "OrigReceiptLineNbr";
                    ExpenseAcctID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edExpenseAcctID", "Account", grid.Locator, "ExpenseAcctID");
                    ExpenseAcctID.DataField = "ExpenseAcctID";
                    ExpenseAcctID_Account_description = new PXTextEdit("ctl00_phG_tab_t0_grid_ei", "Description", grid.Locator, "ExpenseAcctID_Account_description");
                    ExpenseAcctID_Account_description.DataField = "ExpenseAcctID_Account_description";
                    ExpenseSubID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edExpenseSubID", "Sub.", grid.Locator, "ExpenseSubID");
                    ExpenseSubID.DataField = "ExpenseSubID";
                    POAccrualAcctID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edPOAccrualAcctID", "Accrual Account", grid.Locator, "POAccrualAcctID");
                    POAccrualAcctID.DataField = "POAccrualAcctID";
                    POAccrualSubID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edPOAccrualSubID", "Accrual Sub.", grid.Locator, "POAccrualSubID");
                    POAccrualSubID.DataField = "POAccrualSubID";
                    ProjectID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edProjectID", "Project", grid.Locator, "ProjectID");
                    ProjectID.DataField = "ProjectID";
                    TaskID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edTaskID", "Project Task", grid.Locator, "TaskID");
                    TaskID.DataField = "TaskID";
                    CostCodeID = new Selector("_ctl00_phG_tab_t0_grid_lv0_edCostCodeID", "Cost Code", grid.Locator, "CostCodeID");
                    CostCodeID.DataField = "CostCodeID";
                    ExpireDate = new DateSelector("_ctl00_phG_tab_t0_grid_lv0_edExpireDate", "Expiration Date", grid.Locator, "ExpireDate");
                    ExpireDate.DataField = "ExpireDate";
                    LineNbr = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edLineNbr", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    SortOrder = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Line Order", grid.Locator, "SortOrder");
                    SortOrder.DataField = "SortOrder";
                    LotSerialNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edLotSerialNbr", "Lot/Serial Nbr.", grid.Locator, "LotSerialNbr");
                    LotSerialNbr.DataField = "LotSerialNbr";
                    POType = new DropDown("_ctl00_phG_tab_t0_grid_lv0_edPOType", "PO Order Type", grid.Locator, "POType");
                    POType.DataField = "POType";
                    POType.Items.Add("RO", "Normal");
                    POType.Items.Add("DP", "Drop-Ship");
                    POType.Items.Add("PD", "Project Drop-Ship");
                    POType.Items.Add("BL", "Blanket");
                    POType.Items.Add("SB", "Standard");
                    PONbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edPONbr", "PO Order Nbr.", grid.Locator, "PONbr");
                    PONbr.DataField = "PONbr";
                    POLineNbr = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edPOLineNbr", "PO Line Nbr.", grid.Locator, "POLineNbr");
                    POLineNbr.DataField = "POLineNbr";
                    SOOrderType = new PXTextEdit("ctl00_phG_tab_t0_grid_ei", "Transfer Order Type", grid.Locator, "SOOrderType");
                    SOOrderType.DataField = "SOOrderType";
                    SOOrderNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSOOrderNbr", "Transfer Order Nbr.", grid.Locator, "SOOrderNbr");
                    SOOrderNbr.DataField = "SOOrderNbr";
                    SOOrderLineNbr = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Transfer Line Nbr.", grid.Locator, "SOOrderLineNbr");
                    SOOrderLineNbr.DataField = "SOOrderLineNbr";
                    SOShipmentNbr = new Selector("_ctl00_phG_tab_t0_grid_lv0_edSOShipmentNbr", "Transfer Shipment Nbr.", grid.Locator, "SOShipmentNbr");
                    SOShipmentNbr.DataField = "SOShipmentNbr";
                    AllowComplete = new CheckBox("_ctl00_phG_tab_t0_grid_lv0_chkAllowComplete", "Complete PO Line", grid.Locator, "AllowComplete");
                    AllowComplete.DataField = "AllowComplete";
                    AllowOpen = new CheckBox("ctl00_phG_tab_t0_grid", "Open PO Line", grid.Locator, "AllowOpen");
                    AllowOpen.DataField = "AllowOpen";
                    ReturnedQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_en", "Returned Qty.", grid.Locator, "ReturnedQty");
                    ReturnedQty.DataField = "ReturnedQty";
                    ReasonCode = new Selector("_ctl00_phG_tab_t0_grid_lv0_edReasonCode", "Reason Code", grid.Locator, "ReasonCode");
                    ReasonCode.DataField = "ReasonCode";
                    AllowEditUnitCost = new CheckBox("ctl00_phG_tab_t0_grid", "Editable Unit Cost", grid.Locator, "AllowEditUnitCost");
                    AllowEditUnitCost.DataField = "AllowEditUnitCost";
                    CuryUnitCost = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryUnitCost", "Unit Cost", grid.Locator, "CuryUnitCost");
                    CuryUnitCost.DataField = "CuryUnitCost";
                    CuryExtCost = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edCuryExtCost", "Ext. Cost", grid.Locator, "CuryExtCost");
                    CuryExtCost.DataField = "CuryExtCost";
                    TranCost = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edTranCost", "Estimated IN Ext. Cost", grid.Locator, "TranCost");
                    TranCost.DataField = "TranCost";
                    TranCostFinal = new PXNumberEdit("_ctl00_phG_tab_t0_grid_lv0_edTranCostFinal", "Final IN Ext. Cost", grid.Locator, "TranCostFinal");
                    TranCostFinal.DataField = "TranCostFinal";
                    ReceiptNbr = new PXTextEdit("_ctl00_phG_tab_t0_grid_lv0_edReceiptNbr", "Receipt Nbr.", grid.Locator, "ReceiptNbr");
                    ReceiptNbr.DataField = "ReceiptNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXTextEditColumnFilter Availability { get; }
				public CheckBoxColumnFilter Selected { get; }
				public SelectorColumnFilter BranchID { get; }
				public SelectorColumnFilter InventoryID { get; }
				public DropDownColumnFilter LineType { get; }
				public SelectorColumnFilter SubItemID { get; }
				public SelectorColumnFilter SiteID { get; }
				public SelectorColumnFilter LocationID { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter OrigOrderQty { get; }
				public PXNumberEditColumnFilter OpenOrderQty { get; }
				public PXNumberEditColumnFilter ReceiptQty { get; }
				public PXNumberEditColumnFilter BaseReceiptQty { get; }
				public SelectorColumnFilter OrigReceiptNbr { get; }
				public PXNumberEditColumnFilter OrigReceiptLineNbr { get; }
				public SelectorColumnFilter ExpenseAcctID { get; }
				public PXTextEditColumnFilter ExpenseAcctID_Account_description { get; }
				public SelectorColumnFilter ExpenseSubID { get; }
				public SelectorColumnFilter POAccrualAcctID { get; }
				public SelectorColumnFilter POAccrualSubID { get; }
				public SelectorColumnFilter ProjectID { get; }
				public SelectorColumnFilter TaskID { get; }
				public SelectorColumnFilter CostCodeID { get; }
				public DateSelectorColumnFilter ExpireDate { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXNumberEditColumnFilter SortOrder { get; }
				public SelectorColumnFilter LotSerialNbr { get; }
				public DropDownColumnFilter POType { get; }
				public SelectorColumnFilter PONbr { get; }
				public PXNumberEditColumnFilter POLineNbr { get; }
				public PXTextEditColumnFilter SOOrderType { get; }
				public SelectorColumnFilter SOOrderNbr { get; }
				public PXNumberEditColumnFilter SOOrderLineNbr { get; }
				public SelectorColumnFilter SOShipmentNbr { get; }
				public CheckBoxColumnFilter AllowComplete { get; }
				public CheckBoxColumnFilter AllowOpen { get; }
				public PXNumberEditColumnFilter ReturnedQty { get; }
				public SelectorColumnFilter ReasonCode { get; }
				public CheckBoxColumnFilter AllowEditUnitCost { get; }
				public PXNumberEditColumnFilter CuryUnitCost { get; }
				public PXNumberEditColumnFilter CuryExtCost { get; }
				public PXNumberEditColumnFilter TranCost { get; }
				public PXNumberEditColumnFilter TranCostFinal { get; }
				public PXTextEditColumnFilter ReceiptNbr { get; }
                
                public c_grid_header(c_transactions_grid grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Availability = new PXTextEditColumnFilter(grid.Row.Availability);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    BranchID = new SelectorColumnFilter(grid.Row.BranchID);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    LineType = new DropDownColumnFilter(grid.Row.LineType);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    LocationID = new SelectorColumnFilter(grid.Row.LocationID);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    OrigOrderQty = new PXNumberEditColumnFilter(grid.Row.OrigOrderQty);
                    OpenOrderQty = new PXNumberEditColumnFilter(grid.Row.OpenOrderQty);
                    ReceiptQty = new PXNumberEditColumnFilter(grid.Row.ReceiptQty);
                    BaseReceiptQty = new PXNumberEditColumnFilter(grid.Row.BaseReceiptQty);
                    OrigReceiptNbr = new SelectorColumnFilter(grid.Row.OrigReceiptNbr);
                    OrigReceiptLineNbr = new PXNumberEditColumnFilter(grid.Row.OrigReceiptLineNbr);
                    ExpenseAcctID = new SelectorColumnFilter(grid.Row.ExpenseAcctID);
                    ExpenseAcctID_Account_description = new PXTextEditColumnFilter(grid.Row.ExpenseAcctID_Account_description);
                    ExpenseSubID = new SelectorColumnFilter(grid.Row.ExpenseSubID);
                    POAccrualAcctID = new SelectorColumnFilter(grid.Row.POAccrualAcctID);
                    POAccrualSubID = new SelectorColumnFilter(grid.Row.POAccrualSubID);
                    ProjectID = new SelectorColumnFilter(grid.Row.ProjectID);
                    TaskID = new SelectorColumnFilter(grid.Row.TaskID);
                    CostCodeID = new SelectorColumnFilter(grid.Row.CostCodeID);
                    ExpireDate = new DateSelectorColumnFilter(grid.Row.ExpireDate);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    SortOrder = new PXNumberEditColumnFilter(grid.Row.SortOrder);
                    LotSerialNbr = new SelectorColumnFilter(grid.Row.LotSerialNbr);
                    POType = new DropDownColumnFilter(grid.Row.POType);
                    PONbr = new SelectorColumnFilter(grid.Row.PONbr);
                    POLineNbr = new PXNumberEditColumnFilter(grid.Row.POLineNbr);
                    SOOrderType = new PXTextEditColumnFilter(grid.Row.SOOrderType);
                    SOOrderNbr = new SelectorColumnFilter(grid.Row.SOOrderNbr);
                    SOOrderLineNbr = new PXNumberEditColumnFilter(grid.Row.SOOrderLineNbr);
                    SOShipmentNbr = new SelectorColumnFilter(grid.Row.SOShipmentNbr);
                    AllowComplete = new CheckBoxColumnFilter(grid.Row.AllowComplete);
                    AllowOpen = new CheckBoxColumnFilter(grid.Row.AllowOpen);
                    ReturnedQty = new PXNumberEditColumnFilter(grid.Row.ReturnedQty);
                    ReasonCode = new SelectorColumnFilter(grid.Row.ReasonCode);
                    AllowEditUnitCost = new CheckBoxColumnFilter(grid.Row.AllowEditUnitCost);
                    CuryUnitCost = new PXNumberEditColumnFilter(grid.Row.CuryUnitCost);
                    CuryExtCost = new PXNumberEditColumnFilter(grid.Row.CuryExtCost);
                    TranCost = new PXNumberEditColumnFilter(grid.Row.TranCost);
                    TranCostFinal = new PXNumberEditColumnFilter(grid.Row.TranCostFinal);
                    ReceiptNbr = new PXTextEditColumnFilter(grid.Row.ReceiptNbr);
                }
            }
        }
        
        public class c_transactions_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown LineType { get; }
			public Label LineTypeLabel { get; }
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public Selector LocationID { get; }
			public Label LocationIDLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public PXNumberEdit OrigOrderQty { get; }
			public Label OrigOrderQtyLabel { get; }
			public PXNumberEdit OpenOrderQty { get; }
			public Label OpenOrderQtyLabel { get; }
			public PXNumberEdit ReceiptQty { get; }
			public Label ReceiptQtyLabel { get; }
			public PXNumberEdit CuryUnitCost { get; }
			public Label CuryUnitCostLabel { get; }
			public PXNumberEdit CuryExtCost { get; }
			public Label CuryExtCostLabel { get; }
			public PXNumberEdit TranCost { get; }
			public Label TranCostLabel { get; }
			public PXNumberEdit TranCostFinal { get; }
			public Label TranCostFinalLabel { get; }
			public DropDown POType { get; }
			public Label POTypeLabel { get; }
			public Selector PONbr { get; }
			public Label PONbrLabel { get; }
			public Selector SOOrderNbr { get; }
			public Label SOOrderNbrLabel { get; }
			public Selector SOShipmentNbr { get; }
			public Label SOShipmentNbrLabel { get; }
			public PXNumberEdit POLineNbr { get; }
			public Label POLineNbrLabel { get; }
			public CheckBox AllowComplete { get; }
			public Label AllowCompleteLabel { get; }
			public Selector OrigReceiptNbr { get; }
			public Label OrigReceiptNbrLabel { get; }
			public Selector BranchID { get; }
			public Label BranchIDLabel { get; }
			public Selector ExpenseAcctID { get; }
			public Label ExpenseAcctIDLabel { get; }
			public Selector ExpenseSubID { get; }
			public Label ExpenseSubIDLabel { get; }
			public Selector POAccrualAcctID { get; }
			public Label POAccrualAcctIDLabel { get; }
			public Selector POAccrualSubID { get; }
			public Label POAccrualSubIDLabel { get; }
			public Selector LotSerialNbr { get; }
			public Label LotSerialNbrLabel { get; }
			public DateSelector ExpireDate { get; }
			public Label ExpireDateLabel { get; }
			public Selector ReasonCode { get; }
			public Label ReasonCodeLabel { get; }
			public Selector ProjectID { get; }
			public Label ProjectIDLabel { get; }
			public Selector TaskID { get; }
			public Label TaskIDLabel { get; }
			public Selector CostCodeID { get; }
			public Label CostCodeIDLabel { get; }
			public PXTextEdit TranDesc { get; }
			public Label TranDescLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public PXTextEdit ReceiptNbr { get; }
			public Label ReceiptNbrLabel { get; }
			public PXNumberEdit LineNbr { get; }
			public Label LineNbrLabel { get; }
			public PXTextEdit Availability { get; }
			public Label AvailabilityLabel { get; }
            
            public c_transactions_lv0(string locator, string name) : 
                    base(locator, name)
            {
                LineType = new DropDown("ctl00_phG_tab_t0_grid_lv0_edLineType", "Line Type", locator, null);
                LineTypeLabel = new Label(LineType);
                LineType.DataField = "LineType";
                LineType.Items.Add("GI", "Goods for IN");
                LineType.Items.Add("NS", "Non-Stock");
                LineType.Items.Add("SV", "Service");
                LineType.Items.Add("FT", "Freight");
                InventoryID = new Selector("ctl00_phG_tab_t0_grid_lv0_edInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                SubItemID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSubItemID", "Subitem", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                SiteID = new Selector("ctl00_phG_tab_t0_grid_lv0_edSiteID", "Warehouse", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                LocationID = new Selector("ctl00_phG_tab_t0_grid_lv0_edLocationID", "Location", locator, null);
                LocationIDLabel = new Label(LocationID);
                LocationID.DataField = "LocationID";
                UOM = new Selector("ctl00_phG_tab_t0_grid_lv0_edUOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                OrigOrderQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edOrigOrderQty", "Ordered Qty.", locator, null);
                OrigOrderQtyLabel = new Label(OrigOrderQty);
                OrigOrderQty.DataField = "OrigOrderQty";
                OpenOrderQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edOperOrderQty", "Open Qty.", locator, null);
                OpenOrderQtyLabel = new Label(OpenOrderQty);
                OpenOrderQty.DataField = "OpenOrderQty";
                ReceiptQty = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edReceiptQty", "Receipt Qty.", locator, null);
                ReceiptQtyLabel = new Label(ReceiptQty);
                ReceiptQty.DataField = "ReceiptQty";
                CuryUnitCost = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryUnitCost", "Unit Cost", locator, null);
                CuryUnitCostLabel = new Label(CuryUnitCost);
                CuryUnitCost.DataField = "CuryUnitCost";
                CuryExtCost = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edCuryExtCost", "Ext. Cost", locator, null);
                CuryExtCostLabel = new Label(CuryExtCost);
                CuryExtCost.DataField = "CuryExtCost";
                TranCost = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edTranCost", "Estimated IN Ext. Cost", locator, null);
                TranCostLabel = new Label(TranCost);
                TranCost.DataField = "TranCost";
                TranCostFinal = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edTranCostFinal", "Final IN Ext. Cost", locator, null);
                TranCostFinalLabel = new Label(TranCostFinal);
                TranCostFinal.DataField = "TranCostFinal";
                POType = new DropDown("ctl00_phG_tab_t0_grid_lv0_edPOType", "PO Order Type", locator, null);
                POTypeLabel = new Label(POType);
                POType.DataField = "POType";
                POType.Items.Add("RO", "Normal");
                POType.Items.Add("DP", "Drop-Ship");
                POType.Items.Add("PD", "Project Drop-Ship");
                POType.Items.Add("BL", "Blanket");
                POType.Items.Add("SB", "Standard");
                PONbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edPONbr", "PO Order Nbr.", locator, null);
                PONbrLabel = new Label(PONbr);
                PONbr.DataField = "PONbr";
                SOOrderNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edSOOrderNbr", "Transfer Order Nbr.", locator, null);
                SOOrderNbrLabel = new Label(SOOrderNbr);
                SOOrderNbr.DataField = "SOOrderNbr";
                SOShipmentNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edSOShipmentNbr", "Transfer Shipment Nbr.", locator, null);
                SOShipmentNbrLabel = new Label(SOShipmentNbr);
                SOShipmentNbr.DataField = "SOShipmentNbr";
                POLineNbr = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edPOLineNbr", "PO Line Nbr.", locator, null);
                POLineNbrLabel = new Label(POLineNbr);
                POLineNbr.DataField = "POLineNbr";
                AllowComplete = new CheckBox("ctl00_phG_tab_t0_grid_lv0_chkAllowComplete", "Complete PO Line", locator, null);
                AllowCompleteLabel = new Label(AllowComplete);
                AllowComplete.DataField = "AllowComplete";
                OrigReceiptNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edOrigReceiptNbr", "PO Receipt Nbr.", locator, null);
                OrigReceiptNbrLabel = new Label(OrigReceiptNbr);
                OrigReceiptNbr.DataField = "OrigReceiptNbr";
                BranchID = new Selector("ctl00_phG_tab_t0_grid_lv0_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                ExpenseAcctID = new Selector("ctl00_phG_tab_t0_grid_lv0_edExpenseAcctID", "Account", locator, null);
                ExpenseAcctIDLabel = new Label(ExpenseAcctID);
                ExpenseAcctID.DataField = "ExpenseAcctID";
                ExpenseSubID = new Selector("ctl00_phG_tab_t0_grid_lv0_edExpenseSubID", "Sub.", locator, null);
                ExpenseSubIDLabel = new Label(ExpenseSubID);
                ExpenseSubID.DataField = "ExpenseSubID";
                POAccrualAcctID = new Selector("ctl00_phG_tab_t0_grid_lv0_edPOAccrualAcctID", "Accrual Account", locator, null);
                POAccrualAcctIDLabel = new Label(POAccrualAcctID);
                POAccrualAcctID.DataField = "POAccrualAcctID";
                POAccrualSubID = new Selector("ctl00_phG_tab_t0_grid_lv0_edPOAccrualSubID", "Accrual Sub.", locator, null);
                POAccrualSubIDLabel = new Label(POAccrualSubID);
                POAccrualSubID.DataField = "POAccrualSubID";
                LotSerialNbr = new Selector("ctl00_phG_tab_t0_grid_lv0_edLotSerialNbr", "Lot/Serial Nbr.", locator, null);
                LotSerialNbrLabel = new Label(LotSerialNbr);
                LotSerialNbr.DataField = "LotSerialNbr";
                ExpireDate = new DateSelector("ctl00_phG_tab_t0_grid_lv0_edExpireDate", "Expiration Date", locator, null);
                ExpireDateLabel = new Label(ExpireDate);
                ExpireDate.DataField = "ExpireDate";
                ReasonCode = new Selector("ctl00_phG_tab_t0_grid_lv0_edReasonCode", "Reason Code", locator, null);
                ReasonCodeLabel = new Label(ReasonCode);
                ReasonCode.DataField = "ReasonCode";
                ProjectID = new Selector("ctl00_phG_tab_t0_grid_lv0_edProjectID", "Project", locator, null);
                ProjectIDLabel = new Label(ProjectID);
                ProjectID.DataField = "ProjectID";
                TaskID = new Selector("ctl00_phG_tab_t0_grid_lv0_edTaskID", "Project Task", locator, null);
                TaskIDLabel = new Label(TaskID);
                TaskID.DataField = "TaskID";
                CostCodeID = new Selector("ctl00_phG_tab_t0_grid_lv0_edCostCodeID", "Cost Code", locator, null);
                CostCodeIDLabel = new Label(CostCodeID);
                CostCodeID.DataField = "CostCodeID";
                TranDesc = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edTranDesc", "Transaction Descr.", locator, null);
                TranDescLabel = new Label(TranDesc);
                TranDesc.DataField = "TranDesc";
                Es = new Selector("ctl00_phG_tab_t0_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                ReceiptNbr = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edReceiptNbr", "Receipt Nbr", locator, null);
                ReceiptNbrLabel = new Label(ReceiptNbr);
                ReceiptNbr.DataField = "ReceiptNbr";
                LineNbr = new PXNumberEdit("ctl00_phG_tab_t0_grid_lv0_edLineNbr", "Line Nbr", locator, null);
                LineNbrLabel = new Label(LineNbr);
                LineNbr.DataField = "LineNbr";
                Availability = new PXTextEdit("ctl00_phG_tab_t0_grid_lv0_edAvailability", "Availability", locator, null);
                AvailabilityLabel = new Label(Availability);
                Availability.DataField = "Availability";
                DataMemberName = "transactions";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void InventoryIDEdit()
            {
                Buttons.InventoryIDEdit.Click();
            }
            
            public virtual void PONbrEdit()
            {
                Buttons.PONbrEdit.Click();
            }
            
            public virtual void SOOrderNbrEdit()
            {
                Buttons.SOOrderNbrEdit.Click();
            }
            
            public virtual void SOShipmentNbrEdit()
            {
                Buttons.SOShipmentNbrEdit.Click();
            }
            
            public virtual void OrigReceiptNbrEdit()
            {
                Buttons.OrigReceiptNbrEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button InventoryIDEdit { get; }
			public Button PONbrEdit { get; }
			public Button SOOrderNbrEdit { get; }
			public Button SOShipmentNbrEdit { get; }
			public Button OrigReceiptNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    InventoryIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edInventoryID\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "InventoryIDEdit", "ctl00_phG_tab_t0_grid_lv0");
                    InventoryIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PONbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edPONbr\'] div[class=\'editBtnCont\'] > div > " +
                            "div", "PONbrEdit", "ctl00_phG_tab_t0_grid_lv0");
                    PONbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    SOOrderNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edSOOrderNbr\'] div[class=\'editBtnCont\'] > d" +
                            "iv > div", "SOOrderNbrEdit", "ctl00_phG_tab_t0_grid_lv0");
                    SOOrderNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    SOShipmentNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edSOShipmentNbr\'] div[class=\'editBtnCont\'] " +
                            "> div > div", "SOShipmentNbrEdit", "ctl00_phG_tab_t0_grid_lv0");
                    SOShipmentNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    OrigReceiptNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t0_grid_lv0_edOrigReceiptNbr\'] div[class=\'editBtnCont\']" +
                            " > div > div", "OrigReceiptNbrEdit", "ctl00_phG_tab_t0_grid_lv0");
                    OrigReceiptNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_receiptorderslink_formorders : Grid<c_receiptorderslink_formorders.c_grid_row, c_receiptorderslink_formorders.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_receiptorderslink_formorders(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t1_formOrders");
                DataMemberName = "ReceiptOrdersLink";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t1_formOrders_fe_gf", "FilterForm");
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
            
            public virtual void PONbrEdit()
            {
                Buttons.PONbrEdit.Click();
            }
            
            public virtual void PayToVendorIDEdit()
            {
                Buttons.PayToVendorIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_formOrders_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_formOrders_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_formOrders_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_formOrders_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_formOrders_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_formOrders_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_formOrders_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_formOrders_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_formOrders_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button PONbrEdit { get; }
			public Button PayToVendorIDEdit { get; }
                
                public PxButtonCollection()
                {
                    PONbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_formOrders_lv0_edPONumber\'] div[class=\'editBtnCont\']" +
                            " > div > div", "PONbrEdit", "ctl00_phG_tab_t1_formOrders");
                    PONbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PayToVendorIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_formOrders_lv0_edPayToVendor\'] div[class=\'editBtnCon" +
                            "t\'] > div > div", "PayToVendorIDEdit", "ctl00_phG_tab_t1_formOrders");
                    PayToVendorIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public DropDown POType { get; }
			public Selector PONbr { get; }
			public PXTextEdit CuryID { get; }
			public PXTextEdit TaxZoneID { get; }
			public DropDown TaxCalcMode { get; }
			public Selector PayToVendorID { get; }
			public DropDown Status { get; }
			public PXTextEdit ReceiptNbr { get; }
                
                public c_grid_row(c_receiptorderslink_formorders grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    POType = new DropDown("_ctl00_phG_tab_t1_formOrders_lv0_ec", "Type", grid.Locator, "POType");
                    POType.DataField = "POType";
                    POType.Items.Add("RO", "Normal");
                    POType.Items.Add("DP", "Drop-Ship");
                    POType.Items.Add("PD", "Project Drop-Ship");
                    POType.Items.Add("BL", "Blanket");
                    POType.Items.Add("SB", "Standard");
                    PONbr = new Selector("_ctl00_phG_tab_t1_formOrders_lv0_edPONumber", "Order Nbr.", grid.Locator, "PONbr");
                    PONbr.DataField = "PONbr";
                    CuryID = new PXTextEdit("ctl00_phG_tab_t1_formOrders_em", "Currency", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    TaxZoneID = new PXTextEdit("ctl00_phG_tab_t1_formOrders_ei", "Vendor Tax Zone", grid.Locator, "TaxZoneID");
                    TaxZoneID.DataField = "TaxZoneID";
                    TaxCalcMode = new DropDown("_ctl00_phG_tab_t1_formOrders_lv0_ec", "Tax Calculation Mode", grid.Locator, "TaxCalcMode");
                    TaxCalcMode.DataField = "TaxCalcMode";
                    TaxCalcMode.Items.Add("T", "Tax Settings");
                    TaxCalcMode.Items.Add("G", "Gross");
                    TaxCalcMode.Items.Add("N", "Net");
                    PayToVendorID = new Selector("_ctl00_phG_tab_t1_formOrders_lv0_edPayToVendor", "Pay-to Vendor", grid.Locator, "PayToVendorID");
                    PayToVendorID.DataField = "PayToVendorID";
                    Status = new DropDown("_ctl00_phG_tab_t1_formOrders_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("H", "On Hold");
                    Status.Items.Add("B", "Pending Approval");
                    Status.Items.Add("V", "Rejected");
                    Status.Items.Add("N", "Open");
                    Status.Items.Add("A", "Awaiting Link");
                    Status.Items.Add("D", "Pending Printing");
                    Status.Items.Add("E", "Pending Email");
                    Status.Items.Add("L", "Canceled");
                    Status.Items.Add("M", "Completed");
                    Status.Items.Add("C", "Closed");
                    Status.Items.Add("P", "Printed");
                    ReceiptNbr = new PXTextEdit("ctl00_phG_tab_t1_formOrders_ei", "ReceiptNbr", grid.Locator, "ReceiptNbr");
                    ReceiptNbr.DataField = "ReceiptNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public DropDownColumnFilter POType { get; }
				public SelectorColumnFilter PONbr { get; }
				public PXTextEditColumnFilter CuryID { get; }
				public PXTextEditColumnFilter TaxZoneID { get; }
				public DropDownColumnFilter TaxCalcMode { get; }
				public SelectorColumnFilter PayToVendorID { get; }
				public DropDownColumnFilter Status { get; }
				public PXTextEditColumnFilter ReceiptNbr { get; }
                
                public c_grid_header(c_receiptorderslink_formorders grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    POType = new DropDownColumnFilter(grid.Row.POType);
                    PONbr = new SelectorColumnFilter(grid.Row.PONbr);
                    CuryID = new PXTextEditColumnFilter(grid.Row.CuryID);
                    TaxZoneID = new PXTextEditColumnFilter(grid.Row.TaxZoneID);
                    TaxCalcMode = new DropDownColumnFilter(grid.Row.TaxCalcMode);
                    PayToVendorID = new SelectorColumnFilter(grid.Row.PayToVendorID);
                    Status = new DropDownColumnFilter(grid.Row.Status);
                    ReceiptNbr = new PXTextEditColumnFilter(grid.Row.ReceiptNbr);
                }
            }
        }
        
        public class c_receiptorderslink_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector PONbr { get; }
			public Label PONbrLabel { get; }
			public Selector PayToVendorID { get; }
			public Label PayToVendorIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_receiptorderslink_lv0(string locator, string name) : 
                    base(locator, name)
            {
                PONbr = new Selector("ctl00_phG_tab_t1_formOrders_lv0_edPONumber", "Order Nbr.", locator, null);
                PONbrLabel = new Label(PONbr);
                PONbr.DataField = "PONbr";
                PayToVendorID = new Selector("ctl00_phG_tab_t1_formOrders_lv0_edPayToVendor", "Pay-to Vendor", locator, null);
                PayToVendorIDLabel = new Label(PayToVendorID);
                PayToVendorID.DataField = "PayToVendorID";
                Es = new Selector("ctl00_phG_tab_t1_formOrders_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_tab_t1_formOrders_lv0_ec", "Ec", locator, null);
                DataMemberName = "ReceiptOrdersLink";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void PONbrEdit()
            {
                Buttons.PONbrEdit.Click();
            }
            
            public virtual void PayToVendorIDEdit()
            {
                Buttons.PayToVendorIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button PONbrEdit { get; }
			public Button PayToVendorIDEdit { get; }
                
                public PxButtonCollection()
                {
                    PONbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_formOrders_lv0_edPONumber\'] div[class=\'editBtnCont\']" +
                            " > div > div", "PONbrEdit", "ctl00_phG_tab_t1_formOrders_lv0");
                    PONbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PayToVendorIDEdit = new Button("css=div[id=\'ctl00_phG_tab_t1_formOrders_lv0_edPayToVendor\'] div[class=\'editBtnCon" +
                            "t\'] > div > div", "PayToVendorIDEdit", "ctl00_phG_tab_t1_formOrders_lv0");
                    PayToVendorIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_relatedtransfers_formtransfers : Grid<c_relatedtransfers_formtransfers.c_grid_row, c_relatedtransfers_formtransfers.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_relatedtransfers_formtransfers(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t2_formTransfers");
                DataMemberName = "RelatedTransfers";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t2_formTransfers_fe_gf", "FilterForm");
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
            
            public virtual void RefNbrEdit()
            {
                Buttons.RefNbrEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_formTransfers_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_formTransfers_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_formTransfers_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_formTransfers_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_formTransfers_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_formTransfers_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_formTransfers_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_formTransfers_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_formTransfers_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button RefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    RefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_formTransfers_lv0_edTransferRefNbr\'] div[class=\'edit" +
                            "BtnCont\'] > div > div", "RefNbrEdit", "ctl00_phG_tab_t2_formTransfers");
                    RefNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public Selector RefNbr { get; }
			public DropDown Status { get; }
			public DropDown TransferType { get; }
			public DateSelector TranDate { get; }
			public Selector FinPeriodID { get; }
			public Selector SiteID { get; }
			public PXNumberEdit TotalQty { get; }
			public Selector BatchNbr { get; }
			public DropDown DocType { get; }
                
                public c_grid_row(c_relatedtransfers_formtransfers grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    RefNbr = new Selector("_ctl00_phG_tab_t2_formTransfers_lv0_edTransferRefNbr", "Reference Nbr.", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    Status = new DropDown("_ctl00_phG_tab_t2_formTransfers_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("H", "On Hold");
                    Status.Items.Add("B", "Balanced");
                    Status.Items.Add("R", "Released");
                    TransferType = new DropDown("_ctl00_phG_tab_t2_formTransfers_lv0_ec", "Transfer Type", grid.Locator, "TransferType");
                    TransferType.DataField = "TransferType";
                    TransferType.Items.Add("1", "1-Step");
                    TransferType.Items.Add("2", "2-Step");
                    TranDate = new DateSelector("_ctl00_phG_tab_t2_formTransfers_lv0_ed5", "Date", grid.Locator, "TranDate");
                    TranDate.DataField = "TranDate";
                    FinPeriodID = new Selector("_ctl00_phG_tab_t2_formTransfers_lv0_es", "Post Period", grid.Locator, "FinPeriodID");
                    FinPeriodID.DataField = "FinPeriodID";
                    SiteID = new Selector("_ctl00_phG_tab_t2_formTransfers_lv0_es", "From Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    TotalQty = new PXNumberEdit("ctl00_phG_tab_t2_formTransfers_en", "Total Qty.", grid.Locator, "TotalQty");
                    TotalQty.DataField = "TotalQty";
                    BatchNbr = new Selector("_ctl00_phG_tab_t2_formTransfers_lv0_es", "Batch Nbr.", grid.Locator, "BatchNbr");
                    BatchNbr.DataField = "BatchNbr";
                    DocType = new DropDown("_ctl00_phG_tab_t2_formTransfers_lv0_ec", "Document Type", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    DocType.Items.Add("I", "Issue");
                    DocType.Items.Add("R", "Receipt");
                    DocType.Items.Add("T", "Transfer");
                    DocType.Items.Add("A", "Adjustment");
                    DocType.Items.Add("P", "Production");
                    DocType.Items.Add("D", "Disassembly");
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public SelectorColumnFilter RefNbr { get; }
				public DropDownColumnFilter Status { get; }
				public DropDownColumnFilter TransferType { get; }
				public DateSelectorColumnFilter TranDate { get; }
				public SelectorColumnFilter FinPeriodID { get; }
				public SelectorColumnFilter SiteID { get; }
				public PXNumberEditColumnFilter TotalQty { get; }
				public SelectorColumnFilter BatchNbr { get; }
				public DropDownColumnFilter DocType { get; }
                
                public c_grid_header(c_relatedtransfers_formtransfers grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    RefNbr = new SelectorColumnFilter(grid.Row.RefNbr);
                    Status = new DropDownColumnFilter(grid.Row.Status);
                    TransferType = new DropDownColumnFilter(grid.Row.TransferType);
                    TranDate = new DateSelectorColumnFilter(grid.Row.TranDate);
                    FinPeriodID = new SelectorColumnFilter(grid.Row.FinPeriodID);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    TotalQty = new PXNumberEditColumnFilter(grid.Row.TotalQty);
                    BatchNbr = new SelectorColumnFilter(grid.Row.BatchNbr);
                    DocType = new DropDownColumnFilter(grid.Row.DocType);
                }
            }
        }
        
        public class c_relatedtransfers_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector RefNbr { get; }
			public Label RefNbrLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_relatedtransfers_lv0(string locator, string name) : 
                    base(locator, name)
            {
                RefNbr = new Selector("ctl00_phG_tab_t2_formTransfers_lv0_edTransferRefNbr", "Reference Nbr.", locator, null);
                RefNbrLabel = new Label(RefNbr);
                RefNbr.DataField = "RefNbr";
                Es = new Selector("ctl00_phG_tab_t2_formTransfers_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t2_formTransfers_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t2_formTransfers_lv0_ec", "Ec", locator, null);
                DataMemberName = "RelatedTransfers";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void RefNbrEdit()
            {
                Buttons.RefNbrEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button RefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    RefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t2_formTransfers_lv0_edTransferRefNbr\'] div[class=\'edit" +
                            "BtnCont\'] > div > div", "RefNbrEdit", "ctl00_phG_tab_t2_formTransfers_lv0");
                    RefNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
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
			public PXTextEdit ReceiptNbr { get; }
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
                    ReceiptNbr = new PXTextEdit("ctl00_phG_PanelLS_grid2_ei", "Receipt Nbr.", grid.Locator, "ReceiptNbr");
                    ReceiptNbr.DataField = "ReceiptNbr";
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
				public PXTextEditColumnFilter ReceiptNbr { get; }
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
                    ReceiptNbr = new PXTextEditColumnFilter(grid.Row.ReceiptNbr);
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
        
        public class c_opentransfers_gridopentransfers : Grid<c_opentransfers_gridopentransfers.c_grid_row, c_opentransfers_gridopentransfers.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_opentransfers_gridopentransfers(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelAddTransfer_gridOpenTransfers");
                DataMemberName = "openTransfers";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PanelAddTransfer_gridOpenTransfers_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddTransfer_gridOpenTransfers_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddTransfer_gridOpenTransfers_at_tlb div[data-cmd=\'AdjustColu" +
                            "mns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddTransfer_gridOpenTransfers_at_tlb div[data-cmd=\'ExportExce" +
                            "l\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddTransfer_gridOpenTransfers_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddTransfer_gridOpenTransfers_ab_tlb div[data-cmd=\'PageFirst\'" +
                            "]", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddTransfer_gridOpenTransfers_ab_tlb div[data-cmd=\'PagePrev\']" +
                            "", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddTransfer_gridOpenTransfers_ab_tlb div[data-cmd=\'PageNext\']" +
                            "", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddTransfer_gridOpenTransfers_ab_tlb div[data-cmd=\'PageLast\']" +
                            "", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddTransfer_gridOpenTransfers_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddTransfer_PXButton11", "Add", "ctl00_phG_PanelAddTransfer_gridOpenTransfers");
                    AddClose = new Button("ctl00_phG_PanelAddTransfer_PXButton12", "Add & Close", "ctl00_phG_PanelAddTransfer_gridOpenTransfers");
                    Cancel = new Button("ctl00_phG_PanelAddTransfer_PXButton13", "Cancel", "ctl00_phG_PanelAddTransfer_gridOpenTransfers");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox Selected { get; }
			public Selector OrderType { get; }
			public Selector OrderNbr { get; }
			public PXTextEdit ShipmentNbr { get; }
			public Selector INRegister__SiteID { get; }
			public Selector INRegister__ToSiteID { get; }
			public DateSelector INRegister__TranDate { get; }
			public PXTextEdit INRegister__TranDesc { get; }
			public PXTextEdit ShippingRefNoteID { get; }
                
                public c_grid_row(c_opentransfers_gridopentransfers grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phG_PanelAddTransfer_gridOpenTransfers_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    OrderType = new Selector("_ctl00_phG_PanelAddTransfer_gridOpenTransfers_lv0_es", "Order Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderNbr = new Selector("_ctl00_phG_PanelAddTransfer_gridOpenTransfers_lv0_es", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    ShipmentNbr = new PXTextEdit("ctl00_phG_PanelAddTransfer_gridOpenTransfers_ei", "Shipment Nbr.", grid.Locator, "ShipmentNbr");
                    ShipmentNbr.DataField = "ShipmentNbr";
                    INRegister__SiteID = new Selector("_ctl00_phG_PanelAddTransfer_gridOpenTransfers_lv0_es", "From Warehouse", grid.Locator, "INRegister__SiteID");
                    INRegister__SiteID.DataField = "INRegister__SiteID";
                    INRegister__ToSiteID = new Selector("_ctl00_phG_PanelAddTransfer_gridOpenTransfers_lv0_es", "To Warehouse", grid.Locator, "INRegister__ToSiteID");
                    INRegister__ToSiteID.DataField = "INRegister__ToSiteID";
                    INRegister__TranDate = new DateSelector("_ctl00_phG_PanelAddTransfer_gridOpenTransfers_lv0_ed8", "Date", grid.Locator, "INRegister__TranDate");
                    INRegister__TranDate.DataField = "INRegister__TranDate";
                    INRegister__TranDesc = new PXTextEdit("ctl00_phG_PanelAddTransfer_gridOpenTransfers_ei", "Description", grid.Locator, "INRegister__TranDesc");
                    INRegister__TranDesc.DataField = "INRegister__TranDesc";
                    ShippingRefNoteID = new PXTextEdit("ctl00_phG_PanelAddTransfer_gridOpenTransfers_ei", "ShippingRefNoteID", grid.Locator, "ShippingRefNoteID");
                    ShippingRefNoteID.DataField = "ShippingRefNoteID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public SelectorColumnFilter OrderType { get; }
				public SelectorColumnFilter OrderNbr { get; }
				public PXTextEditColumnFilter ShipmentNbr { get; }
				public SelectorColumnFilter INRegister__SiteID { get; }
				public SelectorColumnFilter INRegister__ToSiteID { get; }
				public DateSelectorColumnFilter INRegister__TranDate { get; }
				public PXTextEditColumnFilter INRegister__TranDesc { get; }
				public PXTextEditColumnFilter ShippingRefNoteID { get; }
                
                public c_grid_header(c_opentransfers_gridopentransfers grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    OrderType = new SelectorColumnFilter(grid.Row.OrderType);
                    OrderNbr = new SelectorColumnFilter(grid.Row.OrderNbr);
                    ShipmentNbr = new PXTextEditColumnFilter(grid.Row.ShipmentNbr);
                    INRegister__SiteID = new SelectorColumnFilter(grid.Row.INRegister__SiteID);
                    INRegister__ToSiteID = new SelectorColumnFilter(grid.Row.INRegister__ToSiteID);
                    INRegister__TranDate = new DateSelectorColumnFilter(grid.Row.INRegister__TranDate);
                    INRegister__TranDesc = new PXTextEditColumnFilter(grid.Row.INRegister__TranDesc);
                    ShippingRefNoteID = new PXTextEditColumnFilter(grid.Row.ShippingRefNoteID);
                }
            }
        }
        
        public class c_opentransfers_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
            
            public c_opentransfers_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PanelAddTransfer_gridOpenTransfers_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_PanelAddTransfer_gridOpenTransfers_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                DataMemberName = "openTransfers";
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
                    Add = new Button("ctl00_phG_PanelAddTransfer_PXButton11", "Add", "ctl00_phG_PanelAddTransfer_gridOpenTransfers_lv0");
                    AddClose = new Button("ctl00_phG_PanelAddTransfer_PXButton12", "Add & Close", "ctl00_phG_PanelAddTransfer_gridOpenTransfers_lv0");
                    Cancel = new Button("ctl00_phG_PanelAddTransfer_PXButton13", "Cancel", "ctl00_phG_PanelAddTransfer_gridOpenTransfers_lv0");
                }
            }
        }
        
        public class c_landedcosts_gridlandedcosts : Grid<c_landedcosts_gridlandedcosts.c_grid_row, c_landedcosts_gridlandedcosts.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_landedcosts_gridlandedcosts(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t5_gridLandedCosts");
                DataMemberName = "landedCosts";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t5_gridLandedCosts_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridLandedCosts_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridLandedCosts_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = () => Alert.AlertToException("The current {0} record will be deleted.");
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridLandedCosts_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridLandedCosts_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridLandedCosts_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridLandedCosts_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridLandedCosts_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridLandedCosts_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridLandedCosts_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t5_gridLandedCosts_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public DropDown LCDocType { get; }
			public Selector LCRefNbr { get; }
			public DateSelector DocDate { get; }
			public DropDown Status { get; }
			public Selector VendorID { get; }
			public Selector LandedCostCodeID { get; }
			public PXNumberEdit CuryLineAmt { get; }
			public Selector CuryID { get; }
			public Selector APRefNbr { get; }
			public Selector INRefNbr { get; }
			public PXTextEdit POReceiptType { get; }
			public Selector POReceiptNbr { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_landedcosts_gridlandedcosts grid) : 
                        base(grid)
                {
                    LCDocType = new DropDown("_ctl00_phG_tab_t5_gridLandedCosts_lv0_ec", "Landed Cost Type", grid.Locator, "LCDocType");
                    LCDocType.DataField = "LCDocType";
                    LCDocType.Items.Add("L", "Landed Cost");
                    LCDocType.Items.Add("C", "Correction");
                    LCDocType.Items.Add("R", "Reversal");
                    LCRefNbr = new Selector("_ctl00_phG_tab_t5_gridLandedCosts_lv0_es", "Landed Cost Nbr.", grid.Locator, "LCRefNbr");
                    LCRefNbr.DataField = "LCRefNbr";
                    DocDate = new DateSelector("_ctl00_phG_tab_t5_gridLandedCosts_lv0_ed2", "Date", grid.Locator, "DocDate");
                    DocDate.DataField = "DocDate";
                    Status = new DropDown("_ctl00_phG_tab_t5_gridLandedCosts_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("H", "On Hold");
                    Status.Items.Add("B", "Balanced");
                    Status.Items.Add("R", "Released");
                    VendorID = new Selector("_ctl00_phG_tab_t5_gridLandedCosts_lv0_es", "Vendor", grid.Locator, "VendorID");
                    VendorID.DataField = "VendorID";
                    LandedCostCodeID = new Selector("_ctl00_phG_tab_t5_gridLandedCosts_lv0_es", "Landed Cost Code", grid.Locator, "LandedCostCodeID");
                    LandedCostCodeID.DataField = "LandedCostCodeID";
                    CuryLineAmt = new PXNumberEdit("ctl00_phG_tab_t5_gridLandedCosts_en", "Amount", grid.Locator, "CuryLineAmt");
                    CuryLineAmt.DataField = "CuryLineAmt";
                    CuryID = new Selector("_ctl00_phG_tab_t5_gridLandedCosts_lv0_es", "Currency", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    APRefNbr = new Selector("_ctl00_phG_tab_t5_gridLandedCosts_lv0_es", "AP Ref. Nbr.", grid.Locator, "APRefNbr");
                    APRefNbr.DataField = "APRefNbr";
                    INRefNbr = new Selector("_ctl00_phG_tab_t5_gridLandedCosts_lv0_es", "IN Ref. Nbr.", grid.Locator, "INRefNbr");
                    INRefNbr.DataField = "INRefNbr";
                    POReceiptType = new PXTextEdit("ctl00_phG_tab_t5_gridLandedCosts_ei", "PO Receipt Type", grid.Locator, "POReceiptType");
                    POReceiptType.DataField = "POReceiptType";
                    POReceiptNbr = new Selector("_ctl00_phG_tab_t5_gridLandedCosts_lv0_es", "PO Receipt Nbr.", grid.Locator, "POReceiptNbr");
                    POReceiptNbr.DataField = "POReceiptNbr";
                    LineNbr = new PXNumberEdit("ctl00_phG_tab_t5_gridLandedCosts_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public DropDownColumnFilter LCDocType { get; }
				public SelectorColumnFilter LCRefNbr { get; }
				public DateSelectorColumnFilter DocDate { get; }
				public DropDownColumnFilter Status { get; }
				public SelectorColumnFilter VendorID { get; }
				public SelectorColumnFilter LandedCostCodeID { get; }
				public PXNumberEditColumnFilter CuryLineAmt { get; }
				public SelectorColumnFilter CuryID { get; }
				public SelectorColumnFilter APRefNbr { get; }
				public SelectorColumnFilter INRefNbr { get; }
				public PXTextEditColumnFilter POReceiptType { get; }
				public SelectorColumnFilter POReceiptNbr { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_landedcosts_gridlandedcosts grid) : 
                        base(grid)
                {
                    LCDocType = new DropDownColumnFilter(grid.Row.LCDocType);
                    LCRefNbr = new SelectorColumnFilter(grid.Row.LCRefNbr);
                    DocDate = new DateSelectorColumnFilter(grid.Row.DocDate);
                    Status = new DropDownColumnFilter(grid.Row.Status);
                    VendorID = new SelectorColumnFilter(grid.Row.VendorID);
                    LandedCostCodeID = new SelectorColumnFilter(grid.Row.LandedCostCodeID);
                    CuryLineAmt = new PXNumberEditColumnFilter(grid.Row.CuryLineAmt);
                    CuryID = new SelectorColumnFilter(grid.Row.CuryID);
                    APRefNbr = new SelectorColumnFilter(grid.Row.APRefNbr);
                    INRefNbr = new SelectorColumnFilter(grid.Row.INRefNbr);
                    POReceiptType = new PXTextEditColumnFilter(grid.Row.POReceiptType);
                    POReceiptNbr = new SelectorColumnFilter(grid.Row.POReceiptNbr);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_landedcosts_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_landedcosts_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t5_gridLandedCosts_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t5_gridLandedCosts_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t5_gridLandedCosts_lv0_ec", "Ec", locator, null);
                DataMemberName = "landedCosts";
            }
        }
        
        public class c_apdocs_formbasecurrencymessage : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Label LblAmountsCurrency_ { get; }
            
            public c_apdocs_formbasecurrencymessage(string locator, string name) : 
                    base(locator, name)
            {
                LblAmountsCurrency_ = new Label("ctl00_phG_tab_t4_formBaseCurrencyMessage_lblAmountsCurrency", "The values in the Billed Amt., Accrued Amt., and PPV Amt columns are always shown" +
                        " in the base currency.", locator, null);
                DataMemberName = "apDocs";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void RefNbrEdit()
            {
                Buttons.RefNbrEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button RefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    RefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_formBillingHistory_lv0_edRefNbr\'] div[class=\'editBtn" +
                            "Cont\'] > div > div", "RefNbrEdit", "ctl00_phG_tab_t4_formBaseCurrencyMessage");
                    RefNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_apdocs_formbillinghistory : Grid<c_apdocs_formbillinghistory.c_grid_row, c_apdocs_formbillinghistory.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_apdocs_formbillinghistory(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t4_formBillingHistory");
                DataMemberName = "ApDocs";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t4_formBillingHistory_fe_gf", "FilterForm");
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
            
            public virtual void RefNbrEdit()
            {
                Buttons.RefNbrEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formBillingHistory_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formBillingHistory_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formBillingHistory_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formBillingHistory_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formBillingHistory_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formBillingHistory_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formBillingHistory_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formBillingHistory_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t4_formBillingHistory_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button RefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    RefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_formBillingHistory_lv0_edRefNbr\'] div[class=\'editBtn" +
                            "Cont\'] > div > div", "RefNbrEdit", "ctl00_phG_tab_t4_formBillingHistory");
                    RefNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public DropDown DocType { get; }
			public Selector RefNbr { get; }
			public DateSelector DocDate { get; }
			public DropDown Status { get; }
			public PXNumberEdit TotalQty { get; }
			public PXNumberEdit TotalAmt { get; }
			public PXNumberEdit AccruedQty { get; }
			public PXNumberEdit AccruedAmt { get; }
			public PXNumberEdit TotalPPVAmt { get; }
			public PXTextEdit StatusText { get; }
                
                public c_grid_row(c_apdocs_formbillinghistory grid) : 
                        base(grid)
                {
                    DocType = new DropDown("_ctl00_phG_tab_t4_formBillingHistory_lv0_ec", "Type", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    DocType.Items.Add("INV", "Bill");
                    DocType.Items.Add("ACR", "Credit Adj.");
                    DocType.Items.Add("ADR", "Debit Adj.");
                    DocType.Items.Add("CHK", "Check");
                    DocType.Items.Add("VCK", "Voided Check");
                    DocType.Items.Add("PPM", "Prepayment");
                    DocType.Items.Add("REF", "Vendor Refund");
                    DocType.Items.Add("VRF", "Voided Refund");
                    DocType.Items.Add("QCK", "Quick Check");
                    DocType.Items.Add("VQC", "Void Quick Check");
                    DocType.Items.Add("PPR", "Prepayment Req.");
                    RefNbr = new Selector("_ctl00_phG_tab_t4_formBillingHistory_lv0_edRefNbr", "Reference Nbr.", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    DocDate = new DateSelector("_ctl00_phG_tab_t4_formBillingHistory_lv0_ed2", "Date", grid.Locator, "DocDate");
                    DocDate.DataField = "DocDate";
                    Status = new DropDown("_ctl00_phG_tab_t4_formBillingHistory_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("H", "On Hold");
                    Status.Items.Add("B", "Balanced");
                    Status.Items.Add("V", "Voided");
                    Status.Items.Add("S", "Scheduled");
                    Status.Items.Add("N", "Open");
                    Status.Items.Add("C", "Closed");
                    Status.Items.Add("P", "Printed");
                    Status.Items.Add("K", "Pre-Released");
                    Status.Items.Add("E", "Pending Approval");
                    Status.Items.Add("R", "Rejected");
                    Status.Items.Add("Z", "Reserved");
                    Status.Items.Add("G", "Pending Print");
                    Status.Items.Add("X", "Under Reclassification");
                    TotalQty = new PXNumberEdit("ctl00_phG_tab_t4_formBillingHistory_en", "Billed Qty.", grid.Locator, "TotalQty");
                    TotalQty.DataField = "TotalQty";
                    TotalAmt = new PXNumberEdit("ctl00_phG_tab_t4_formBillingHistory_en", "Billed Amt.", grid.Locator, "TotalAmt");
                    TotalAmt.DataField = "TotalAmt";
                    AccruedQty = new PXNumberEdit("ctl00_phG_tab_t4_formBillingHistory_en", "Accrued Qty.", grid.Locator, "AccruedQty");
                    AccruedQty.DataField = "AccruedQty";
                    AccruedAmt = new PXNumberEdit("ctl00_phG_tab_t4_formBillingHistory_en", "Accrued Amt.", grid.Locator, "AccruedAmt");
                    AccruedAmt.DataField = "AccruedAmt";
                    TotalPPVAmt = new PXNumberEdit("ctl00_phG_tab_t4_formBillingHistory_en", "PPV Amt", grid.Locator, "TotalPPVAmt");
                    TotalPPVAmt.DataField = "TotalPPVAmt";
                    StatusText = new PXTextEdit("ctl00_phG_tab_t4_formBillingHistory_ei", "StatusText", grid.Locator, "StatusText");
                    StatusText.DataField = "StatusText";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public DropDownColumnFilter DocType { get; }
				public SelectorColumnFilter RefNbr { get; }
				public DateSelectorColumnFilter DocDate { get; }
				public DropDownColumnFilter Status { get; }
				public PXNumberEditColumnFilter TotalQty { get; }
				public PXNumberEditColumnFilter TotalAmt { get; }
				public PXNumberEditColumnFilter AccruedQty { get; }
				public PXNumberEditColumnFilter AccruedAmt { get; }
				public PXNumberEditColumnFilter TotalPPVAmt { get; }
				public PXTextEditColumnFilter StatusText { get; }
                
                public c_grid_header(c_apdocs_formbillinghistory grid) : 
                        base(grid)
                {
                    DocType = new DropDownColumnFilter(grid.Row.DocType);
                    RefNbr = new SelectorColumnFilter(grid.Row.RefNbr);
                    DocDate = new DateSelectorColumnFilter(grid.Row.DocDate);
                    Status = new DropDownColumnFilter(grid.Row.Status);
                    TotalQty = new PXNumberEditColumnFilter(grid.Row.TotalQty);
                    TotalAmt = new PXNumberEditColumnFilter(grid.Row.TotalAmt);
                    AccruedQty = new PXNumberEditColumnFilter(grid.Row.AccruedQty);
                    AccruedAmt = new PXNumberEditColumnFilter(grid.Row.AccruedAmt);
                    TotalPPVAmt = new PXNumberEditColumnFilter(grid.Row.TotalPPVAmt);
                    StatusText = new PXTextEditColumnFilter(grid.Row.StatusText);
                }
            }
        }
        
        public class c_apdocs_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector RefNbr { get; }
			public Label RefNbrLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_apdocs_lv0(string locator, string name) : 
                    base(locator, name)
            {
                RefNbr = new Selector("ctl00_phG_tab_t4_formBillingHistory_lv0_edRefNbr", "Ref Nbr", locator, null);
                RefNbrLabel = new Label(RefNbr);
                RefNbr.DataField = "RefNbr";
                Es = new Selector("ctl00_phG_tab_t4_formBillingHistory_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t4_formBillingHistory_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t4_formBillingHistory_lv0_ec", "Ec", locator, null);
                DataMemberName = "ApDocs";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void RefNbrEdit()
            {
                Buttons.RefNbrEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button RefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    RefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t4_formBillingHistory_lv0_edRefNbr\'] div[class=\'editBtn" +
                            "Cont\'] > div > div", "RefNbrEdit", "ctl00_phG_tab_t4_formBillingHistory_lv0");
                    RefNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_receipthistory_formprhistory : Grid<c_receipthistory_formprhistory.c_grid_row, c_receipthistory_formprhistory.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_receipthistory_formprhistory(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t3_formPRHistory");
                DataMemberName = "ReceiptHistory";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_tab_t3_formPRHistory_fe_gf", "FilterForm");
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
            
            public virtual void ReceiptNbrEdit()
            {
                Buttons.ReceiptNbrEdit.Click();
            }
            
            public virtual void InvtRefNbrEdit()
            {
                Buttons.InvtRefNbrEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_formPRHistory_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_formPRHistory_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_formPRHistory_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_formPRHistory_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_formPRHistory_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_formPRHistory_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_formPRHistory_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_formPRHistory_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t3_formPRHistory_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ReceiptNbrEdit { get; }
			public Button InvtRefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    ReceiptNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_formPRHistory_lv0_edReceiptNbr\'] div[class=\'editBtnC" +
                            "ont\'] > div > div", "ReceiptNbrEdit", "ctl00_phG_tab_t3_formPRHistory");
                    ReceiptNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    InvtRefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_formPRHistory_lv0_edInvtRefNbr\'] div[class=\'editBtnC" +
                            "ont\'] > div > div", "InvtRefNbrEdit", "ctl00_phG_tab_t3_formPRHistory");
                    InvtRefNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public DropDown ReceiptType { get; }
			public Selector ReceiptNbr { get; }
			public DateSelector DocDate { get; }
			public PXTextEdit FinPeriodID { get; }
			public DropDown Status { get; }
			public PXNumberEdit TotalQty { get; }
			public DropDown InvtDocType { get; }
			public Selector InvtRefNbr { get; }
                
                public c_grid_row(c_receipthistory_formprhistory grid) : 
                        base(grid)
                {
                    ReceiptType = new DropDown("_ctl00_phG_tab_t3_formPRHistory_lv0_ec", "PR Type", grid.Locator, "ReceiptType");
                    ReceiptType.DataField = "ReceiptType";
                    ReceiptType.Items.Add("RT", "Receipt");
                    ReceiptType.Items.Add("RN", "Return");
                    ReceiptType.Items.Add("RX", "Transfer Receipt");
                    ReceiptNbr = new Selector("_ctl00_phG_tab_t3_formPRHistory_lv0_edReceiptNbr", "PR Nbr.", grid.Locator, "ReceiptNbr");
                    ReceiptNbr.DataField = "ReceiptNbr";
                    DocDate = new DateSelector("_ctl00_phG_tab_t3_formPRHistory_lv0_ed2", "Date", grid.Locator, "DocDate");
                    DocDate.DataField = "DocDate";
                    FinPeriodID = new PXTextEdit("ctl00_phG_tab_t3_formPRHistory_em", "Post Period", grid.Locator, "FinPeriodID");
                    FinPeriodID.DataField = "FinPeriodID";
                    Status = new DropDown("_ctl00_phG_tab_t3_formPRHistory_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("H", "On Hold");
                    Status.Items.Add("B", "Balanced");
                    Status.Items.Add("R", "Released");
                    TotalQty = new PXNumberEdit("ctl00_phG_tab_t3_formPRHistory_en", "Total Qty.", grid.Locator, "TotalQty");
                    TotalQty.DataField = "TotalQty";
                    InvtDocType = new DropDown("_ctl00_phG_tab_t3_formPRHistory_lv0_ec", "IN Doc. Type", grid.Locator, "InvtDocType");
                    InvtDocType.DataField = "InvtDocType";
                    InvtDocType.Items.Add("I", "Issue");
                    InvtDocType.Items.Add("R", "Receipt");
                    InvtDocType.Items.Add("T", "Transfer");
                    InvtDocType.Items.Add("A", "Adjustment");
                    InvtDocType.Items.Add("P", "Production");
                    InvtDocType.Items.Add("D", "Disassembly");
                    InvtRefNbr = new Selector("_ctl00_phG_tab_t3_formPRHistory_lv0_edInvtRefNbr", "IN Ref. Nbr.", grid.Locator, "InvtRefNbr");
                    InvtRefNbr.DataField = "InvtRefNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public DropDownColumnFilter ReceiptType { get; }
				public SelectorColumnFilter ReceiptNbr { get; }
				public DateSelectorColumnFilter DocDate { get; }
				public PXTextEditColumnFilter FinPeriodID { get; }
				public DropDownColumnFilter Status { get; }
				public PXNumberEditColumnFilter TotalQty { get; }
				public DropDownColumnFilter InvtDocType { get; }
				public SelectorColumnFilter InvtRefNbr { get; }
                
                public c_grid_header(c_receipthistory_formprhistory grid) : 
                        base(grid)
                {
                    ReceiptType = new DropDownColumnFilter(grid.Row.ReceiptType);
                    ReceiptNbr = new SelectorColumnFilter(grid.Row.ReceiptNbr);
                    DocDate = new DateSelectorColumnFilter(grid.Row.DocDate);
                    FinPeriodID = new PXTextEditColumnFilter(grid.Row.FinPeriodID);
                    Status = new DropDownColumnFilter(grid.Row.Status);
                    TotalQty = new PXNumberEditColumnFilter(grid.Row.TotalQty);
                    InvtDocType = new DropDownColumnFilter(grid.Row.InvtDocType);
                    InvtRefNbr = new SelectorColumnFilter(grid.Row.InvtRefNbr);
                }
            }
        }
        
        public class c_receipthistory_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector ReceiptNbr { get; }
			public Label ReceiptNbrLabel { get; }
			public Selector InvtRefNbr { get; }
			public Label InvtRefNbrLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_receipthistory_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ReceiptNbr = new Selector("ctl00_phG_tab_t3_formPRHistory_lv0_edReceiptNbr", "Receipt Nbr", locator, null);
                ReceiptNbrLabel = new Label(ReceiptNbr);
                ReceiptNbr.DataField = "ReceiptNbr";
                InvtRefNbr = new Selector("ctl00_phG_tab_t3_formPRHistory_lv0_edInvtRefNbr", "Invt Ref Nbr", locator, null);
                InvtRefNbrLabel = new Label(InvtRefNbr);
                InvtRefNbr.DataField = "InvtRefNbr";
                Es = new Selector("ctl00_phG_tab_t3_formPRHistory_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t3_formPRHistory_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_tab_t3_formPRHistory_lv0_ec", "Ec", locator, null);
                DataMemberName = "ReceiptHistory";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void ReceiptNbrEdit()
            {
                Buttons.ReceiptNbrEdit.Click();
            }
            
            public virtual void InvtRefNbrEdit()
            {
                Buttons.InvtRefNbrEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ReceiptNbrEdit { get; }
			public Button InvtRefNbrEdit { get; }
                
                public PxButtonCollection()
                {
                    ReceiptNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_formPRHistory_lv0_edReceiptNbr\'] div[class=\'editBtnC" +
                            "ont\'] > div > div", "ReceiptNbrEdit", "ctl00_phG_tab_t3_formPRHistory_lv0");
                    ReceiptNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    InvtRefNbrEdit = new Button("css=div[id=\'ctl00_phG_tab_t3_formPRHistory_lv0_edInvtRefNbr\'] div[class=\'editBtnC" +
                            "ont\'] > div > div", "InvtRefNbrEdit", "ctl00_phG_tab_t3_formPRHistory_lv0");
                    InvtRefNbrEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_filter_frmpofilter : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown OrderType { get; }
			public Label OrderTypeLabel { get; }
			public Selector OrderNbr { get; }
			public Label OrderNbrLabel { get; }
            
            public c_filter_frmpofilter(string locator, string name) : 
                    base(locator, name)
            {
                OrderType = new DropDown("ctl00_phG_PanelAddPOLine_frmPOFilter_edOrderType", "Order Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                OrderNbr = new Selector("ctl00_phG_PanelAddPOLine_frmPOFilter_edOrderNbr", "Order Nbr", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                DataMemberName = "filter";
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
                    Add = new Button("ctl00_phG_PanelAddPOLine_PXButton1", "Add", "ctl00_phG_PanelAddPOLine_frmPOFilter");
                    AddClose = new Button("ctl00_phG_PanelAddPOLine_PXButton2", "Add & Close", "ctl00_phG_PanelAddPOLine_frmPOFilter");
                    Cancel = new Button("ctl00_phG_PanelAddPOLine_PXButton9", "Cancel", "ctl00_phG_PanelAddPOLine_frmPOFilter");
                }
            }
        }
        
        public class c_filter_frmorderfilter1 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown OrderType { get; }
			public Label OrderTypeLabel { get; }
			public Selector ShipToBAccountID { get; }
			public Label ShipToBAccountIDLabel { get; }
			public Selector ShipToLocationID { get; }
			public Label ShipToLocationIDLabel { get; }
            
            public c_filter_frmorderfilter1(string locator, string name) : 
                    base(locator, name)
            {
                OrderType = new DropDown("ctl00_phG_PanelAddPO_frmOrderFilter1_edOrderType", "Order Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                ShipToBAccountID = new Selector("ctl00_phG_PanelAddPO_frmOrderFilter1_edShipToBAccountID", "Ship To B Account ID", locator, null);
                ShipToBAccountIDLabel = new Label(ShipToBAccountID);
                ShipToBAccountID.DataField = "ShipToBAccountID";
                ShipToLocationID = new Selector("ctl00_phG_PanelAddPO_frmOrderFilter1_edShipToLocationID", "Ship To Location ID", locator, null);
                ShipToLocationIDLabel = new Label(ShipToLocationID);
                ShipToLocationID.DataField = "ShipToLocationID";
                DataMemberName = "filter";
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
                    Add = new Button("ctl00_phG_PanelAddPO_PXButton8", "Add", "ctl00_phG_PanelAddPO_frmOrderFilter1");
                    AddClose = new Button("ctl00_phG_PanelAddPO_PXButton3", "Add & Close", "ctl00_phG_PanelAddPO_frmOrderFilter1");
                    Cancel = new Button("ctl00_phG_PanelAddPO_PXButton4", "Cancel", "ctl00_phG_PanelAddPO_frmOrderFilter1");
                }
            }
        }
        
        public class c_filter_formtransferfilter1 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector ShipFromSiteID { get; }
			public Label ShipFromSiteIDLabel { get; }
            
            public c_filter_formtransferfilter1(string locator, string name) : 
                    base(locator, name)
            {
                ShipFromSiteID = new Selector("ctl00_phG_PanelAddTransfer_formTransferFilter1_edShipFromSiteID", "Ship From Site ID", locator, null);
                ShipFromSiteIDLabel = new Label(ShipFromSiteID);
                ShipFromSiteID.DataField = "ShipFromSiteID";
                DataMemberName = "filter";
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
                    Add = new Button("ctl00_phG_PanelAddTransfer_PXButton11", "Add", "ctl00_phG_PanelAddTransfer_formTransferFilter1");
                    AddClose = new Button("ctl00_phG_PanelAddTransfer_PXButton12", "Add & Close", "ctl00_phG_PanelAddTransfer_formTransferFilter1");
                    Cancel = new Button("ctl00_phG_PanelAddTransfer_PXButton13", "Cancel", "ctl00_phG_PanelAddTransfer_formTransferFilter1");
                }
            }
        }
        
        public class c_filter_frmtransferfilter : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector ShipFromSiteID { get; }
			public Label ShipFromSiteIDLabel { get; }
			public Selector SOOrderNbr { get; }
			public Label SOOrderNbrLabel { get; }
            
            public c_filter_frmtransferfilter(string locator, string name) : 
                    base(locator, name)
            {
                ShipFromSiteID = new Selector("ctl00_phG_PanelAddINTran_frmTransferFilter_edShipFromSiteID", "Ship From Site ID", locator, null);
                ShipFromSiteIDLabel = new Label(ShipFromSiteID);
                ShipFromSiteID.DataField = "ShipFromSiteID";
                SOOrderNbr = new Selector("ctl00_phG_PanelAddINTran_frmTransferFilter_edSOOrderNbr", "SO Order Nbr", locator, null);
                SOOrderNbrLabel = new Label(SOOrderNbr);
                SOOrderNbr.DataField = "SOOrderNbr";
                DataMemberName = "filter";
                Buttons = new PxButtonCollection();
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
                
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    AddClose = new Button("ctl00_phG_PanelAddINTran_PXButton15", "Add & Close", "ctl00_phG_PanelAddINTran_frmTransferFilter");
                    Cancel = new Button("ctl00_phG_PanelAddINTran_PXButton16", "Cancel", "ctl00_phG_PanelAddINTran_frmTransferFilter");
                }
            }
        }
        
        public class c_addreceipt_frmreceipt : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit BarCode { get; }
			public Label BarCodeLabel { get; }
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
			public Selector SubItemID { get; }
			public Label SubItemIDLabel { get; }
			public PXTextEdit LotSerialNbr { get; }
			public Label LotSerialNbrLabel { get; }
			public Selector SiteID { get; }
			public Label SiteIDLabel { get; }
			public Selector LocationID { get; }
			public Label LocationIDLabel { get; }
			public DateSelector ExpireDate { get; }
			public Label ExpireDateLabel { get; }
			public PXNumberEdit ReceiptQty { get; }
			public Label ReceiptQtyLabel { get; }
			public Selector UOM { get; }
			public Label UOMLabel { get; }
			public Selector VendorID { get; }
			public Label VendorIDLabel { get; }
			public Selector VendorLocationID { get; }
			public Label VendorLocationIDLabel { get; }
			public DropDown POType { get; }
			public Label POTypeLabel { get; }
			public Selector PONbr { get; }
			public Label PONbrLabel { get; }
			public PXNumberEdit POLineNbr { get; }
			public Label POLineNbrLabel { get; }
			public Selector ShipFromSiteID { get; }
			public Label ShipFromSiteIDLabel { get; }
			public Selector SOOrderType { get; }
			public Label SOOrderTypeLabel { get; }
			public Selector SOOrderNbr { get; }
			public Label SOOrderNbrLabel { get; }
			public PXNumberEdit SOOrderLineNbr { get; }
			public Label SOOrderLineNbrLabel { get; }
			public Selector SOShipmentNbr { get; }
			public Label SOShipmentNbrLabel { get; }
			public PXNumberEdit UnitCost { get; }
			public Label UnitCostLabel { get; }
			public CheckBox ByOne { get; }
			public Label ByOneLabel { get; }
			public CheckBox AutoAddLine { get; }
			public Label AutoAddLineLabel { get; }
			public PXTextEdit Description { get; }
			public Label DescriptionLabel { get; }
            
            public c_addreceipt_frmreceipt(string locator, string name) : 
                    base(locator, name)
            {
                BarCode = new PXTextEdit("ctl00_phG_PanelAddRL_frmReceipt_edBarCodePnl", "Bar Code", locator, null);
                BarCodeLabel = new Label(BarCode);
                BarCode.DataField = "BarCode";
                InventoryID = new Selector("ctl00_phG_PanelAddRL_frmReceipt_edInventoryIDPnl", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                SubItemID = new Selector("ctl00_phG_PanelAddRL_frmReceipt_edSubItemIDPnl", "Sub Item ID", locator, null);
                SubItemIDLabel = new Label(SubItemID);
                SubItemID.DataField = "SubItemID";
                LotSerialNbr = new PXTextEdit("ctl00_phG_PanelAddRL_frmReceipt_edLotSerialNbrPnl", "Lot Serial Nbr", locator, null);
                LotSerialNbrLabel = new Label(LotSerialNbr);
                LotSerialNbr.DataField = "LotSerialNbr";
                SiteID = new Selector("ctl00_phG_PanelAddRL_frmReceipt_edSiteID", "Site ID", locator, null);
                SiteIDLabel = new Label(SiteID);
                SiteID.DataField = "SiteID";
                LocationID = new Selector("ctl00_phG_PanelAddRL_frmReceipt_edLocationIDPnl", "Location ID", locator, null);
                LocationIDLabel = new Label(LocationID);
                LocationID.DataField = "LocationID";
                ExpireDate = new DateSelector("ctl00_phG_PanelAddRL_frmReceipt_edExpireDate", "Expire Date", locator, null);
                ExpireDateLabel = new Label(ExpireDate);
                ExpireDate.DataField = "ExpireDate";
                ReceiptQty = new PXNumberEdit("ctl00_phG_PanelAddRL_frmReceipt_edReceiptQty", "Receipt Qty", locator, null);
                ReceiptQtyLabel = new Label(ReceiptQty);
                ReceiptQty.DataField = "ReceiptQty";
                UOM = new Selector("ctl00_phG_PanelAddRL_frmReceipt_edUOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                VendorID = new Selector("ctl00_phG_PanelAddRL_frmReceipt_edVendorID", "Vendor ID", locator, null);
                VendorIDLabel = new Label(VendorID);
                VendorID.DataField = "VendorID";
                VendorLocationID = new Selector("ctl00_phG_PanelAddRL_frmReceipt_edVendorLocationID", "Vendor Location ID", locator, null);
                VendorLocationIDLabel = new Label(VendorLocationID);
                VendorLocationID.DataField = "VendorLocationID";
                POType = new DropDown("ctl00_phG_PanelAddRL_frmReceipt_edPOType", "PO Type", locator, null);
                POTypeLabel = new Label(POType);
                POType.DataField = "POType";
                PONbr = new Selector("ctl00_phG_PanelAddRL_frmReceipt_edPONbr", "PO Nbr", locator, null);
                PONbrLabel = new Label(PONbr);
                PONbr.DataField = "PONbr";
                POLineNbr = new PXNumberEdit("ctl00_phG_PanelAddRL_frmReceipt_edPOLineNbr", "PO Line Nbr", locator, null);
                POLineNbrLabel = new Label(POLineNbr);
                POLineNbr.DataField = "POLineNbr";
                ShipFromSiteID = new Selector("ctl00_phG_PanelAddRL_frmReceipt_edShipFromSiteID", "Ship From Site ID", locator, null);
                ShipFromSiteIDLabel = new Label(ShipFromSiteID);
                ShipFromSiteID.DataField = "ShipFromSiteID";
                SOOrderType = new Selector("ctl00_phG_PanelAddRL_frmReceipt_edSOOrderType", "SO Order Type", locator, null);
                SOOrderTypeLabel = new Label(SOOrderType);
                SOOrderType.DataField = "SOOrderType";
                SOOrderNbr = new Selector("ctl00_phG_PanelAddRL_frmReceipt_edSOOrderNbr", "SO Order Nbr", locator, null);
                SOOrderNbrLabel = new Label(SOOrderNbr);
                SOOrderNbr.DataField = "SOOrderNbr";
                SOOrderLineNbr = new PXNumberEdit("ctl00_phG_PanelAddRL_frmReceipt_edSOOrderLineNbr", "SO Order Line Nbr", locator, null);
                SOOrderLineNbrLabel = new Label(SOOrderLineNbr);
                SOOrderLineNbr.DataField = "SOOrderLineNbr";
                SOShipmentNbr = new Selector("ctl00_phG_PanelAddRL_frmReceipt_edSOShipmentNbr", "SO Shipment Nbr", locator, null);
                SOShipmentNbrLabel = new Label(SOShipmentNbr);
                SOShipmentNbr.DataField = "SOShipmentNbr";
                UnitCost = new PXNumberEdit("ctl00_phG_PanelAddRL_frmReceipt_edUnitCost", "Unit Cost", locator, null);
                UnitCostLabel = new Label(UnitCost);
                UnitCost.DataField = "UnitCost";
                ByOne = new CheckBox("ctl00_phG_PanelAddRL_frmReceipt_chkByOne", "By One", locator, null);
                ByOneLabel = new Label(ByOne);
                ByOne.DataField = "ByOne";
                AutoAddLine = new CheckBox("ctl00_phG_PanelAddRL_frmReceipt_chkAutoAddLine", "Auto Add Line", locator, null);
                AutoAddLineLabel = new Label(AutoAddLine);
                AutoAddLine.DataField = "AutoAddLine";
                Description = new PXTextEdit("ctl00_phG_PanelAddRL_frmReceipt_edDescriptionPnl", "Description", locator, null);
                DescriptionLabel = new Label(Description);
                Description.DataField = "Description";
                DataMemberName = "addReceipt";
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
            
            public virtual void Close()
            {
                Buttons.Close.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Close { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddRL_PXButton7", "Add", "ctl00_phG_PanelAddRL_frmReceipt");
                    AddClose = new Button("ctl00_phG_PanelAddRL_PXButton5", "Add & Close", "ctl00_phG_PanelAddRL_frmReceipt");
                    Close = new Button("ctl00_phG_PanelAddRL_PXButton6", "Close", "ctl00_phG_PanelAddRL_frmReceipt");
                }
            }
        }
        
        public class c_intranselection_pxgrid1 : Grid<c_intranselection_pxgrid1.c_grid_row, c_intranselection_pxgrid1.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_intranselection_pxgrid1(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelAddINTran_PXGrid1");
                DataMemberName = "intranSelection";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PanelAddINTran_PXGrid1_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddINTran_PXGrid1_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddINTran_PXGrid1_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddINTran_PXGrid1_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddINTran_PXGrid1_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddINTran_PXGrid1_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddINTran_PXGrid1_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddINTran_PXGrid1_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddINTran_PXGrid1_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddINTran_PXGrid1_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    AddClose = new Button("ctl00_phG_PanelAddINTran_PXButton15", "Add & Close", "ctl00_phG_PanelAddINTran_PXGrid1");
                    Cancel = new Button("ctl00_phG_PanelAddINTran_PXButton16", "Cancel", "ctl00_phG_PanelAddINTran_PXGrid1");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox Selected { get; }
			public PXTextEdit RefNbr { get; }
			public Selector InventoryID { get; }
			public Selector SubItemID { get; }
			public Selector UOM { get; }
			public PXNumberEdit Qty { get; }
			public PXTextEdit TranDesc { get; }
			public PXNumberEdit LineNbr { get; }
			public DropDown DocType { get; }
                
                public c_grid_row(c_intranselection_pxgrid1 grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phG_PanelAddINTran_PXGrid1_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    RefNbr = new PXTextEdit("ctl00_phG_PanelAddINTran_PXGrid1_em", "Reference Nbr.", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    InventoryID = new Selector("_ctl00_phG_PanelAddINTran_PXGrid1_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SubItemID = new Selector("_ctl00_phG_PanelAddINTran_PXGrid1_lv0_es", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    UOM = new Selector("_ctl00_phG_PanelAddINTran_PXGrid1_lv0_es", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    Qty = new PXNumberEdit("ctl00_phG_PanelAddINTran_PXGrid1_en", "Quantity", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    TranDesc = new PXTextEdit("ctl00_phG_PanelAddINTran_PXGrid1_ei", "Description", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    LineNbr = new PXNumberEdit("ctl00_phG_PanelAddINTran_PXGrid1_en", "Line Number", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    DocType = new DropDown("_ctl00_phG_PanelAddINTran_PXGrid1_lv0_ec", "Document Type", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    DocType.Items.Add("I", "Issue");
                    DocType.Items.Add("R", "Receipt");
                    DocType.Items.Add("T", "Transfer");
                    DocType.Items.Add("A", "Adjustment");
                    DocType.Items.Add("P", "Production");
                    DocType.Items.Add("D", "Disassembly");
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter RefNbr { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter Qty { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public DropDownColumnFilter DocType { get; }
                
                public c_grid_header(c_intranselection_pxgrid1 grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    DocType = new DropDownColumnFilter(grid.Row.DocType);
                }
            }
        }
        
        public class c_intranselection_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_intranselection_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PanelAddINTran_PXGrid1_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_PanelAddINTran_PXGrid1_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_PanelAddINTran_PXGrid1_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "intranSelection";
                Buttons = new PxButtonCollection();
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
                
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    AddClose = new Button("ctl00_phG_PanelAddINTran_PXButton15", "Add & Close", "ctl00_phG_PanelAddINTran_PXGrid1_lv0");
                    Cancel = new Button("ctl00_phG_PanelAddINTran_PXButton16", "Cancel", "ctl00_phG_PanelAddINTran_PXGrid1_lv0");
                }
            }
        }
        
        public class c_returnfilter_frmreceiptreturnfilter : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown OrderType { get; }
			public Label OrderTypeLabel { get; }
			public Selector OrderNbr { get; }
			public Label OrderNbrLabel { get; }
			public Selector ReceiptNbr { get; }
			public Label ReceiptNbrLabel { get; }
            
            public c_returnfilter_frmreceiptreturnfilter(string locator, string name) : 
                    base(locator, name)
            {
                OrderType = new DropDown("ctl00_phG_panelAddReceiptReturn_frmReceiptReturnFilter_edOrderType", "Order Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                OrderNbr = new Selector("ctl00_phG_panelAddReceiptReturn_frmReceiptReturnFilter_edOrderNbr", "Order Nbr", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                ReceiptNbr = new Selector("ctl00_phG_panelAddReceiptReturn_frmReceiptReturnFilter_edReceiptNbr", "Receipt Nbr", locator, null);
                ReceiptNbrLabel = new Label(ReceiptNbr);
                ReceiptNbr.DataField = "ReceiptNbr";
                DataMemberName = "returnFilter";
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
                    Add = new Button("ctl00_phG_panelAddReceiptReturn_PXButton14", "Add", "ctl00_phG_panelAddReceiptReturn_frmReceiptReturnFilter");
                    AddClose = new Button("ctl00_phG_panelAddReceiptReturn_PXButton17", "Add & Close", "ctl00_phG_panelAddReceiptReturn_frmReceiptReturnFilter");
                    Cancel = new Button("ctl00_phG_panelAddReceiptReturn_PXButton18", "Cancel", "ctl00_phG_panelAddReceiptReturn_frmReceiptReturnFilter");
                }
            }
        }
        
        public class c_returnfilter_frmreceiptreturnlinefilter : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown OrderType { get; }
			public Label OrderTypeLabel { get; }
			public Selector OrderNbr { get; }
			public Label OrderNbrLabel { get; }
			public Selector ReceiptNbr { get; }
			public Label ReceiptNbrLabel { get; }
			public Selector InventoryID { get; }
			public Label InventoryIDLabel { get; }
            
            public c_returnfilter_frmreceiptreturnlinefilter(string locator, string name) : 
                    base(locator, name)
            {
                OrderType = new DropDown("ctl00_phG_panelAddReceiptLineReturn_frmReceiptReturnLineFilter_edOrderType", "Order Type", locator, null);
                OrderTypeLabel = new Label(OrderType);
                OrderType.DataField = "OrderType";
                OrderNbr = new Selector("ctl00_phG_panelAddReceiptLineReturn_frmReceiptReturnLineFilter_edOrderNbr", "Order Nbr", locator, null);
                OrderNbrLabel = new Label(OrderNbr);
                OrderNbr.DataField = "OrderNbr";
                ReceiptNbr = new Selector("ctl00_phG_panelAddReceiptLineReturn_frmReceiptReturnLineFilter_edReceiptNbr", "Receipt Nbr", locator, null);
                ReceiptNbrLabel = new Label(ReceiptNbr);
                ReceiptNbr.DataField = "ReceiptNbr";
                InventoryID = new Selector("ctl00_phG_panelAddReceiptLineReturn_frmReceiptReturnLineFilter_edInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                DataMemberName = "returnFilter";
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
                    Add = new Button("ctl00_phG_panelAddReceiptLineReturn_PXButton19", "Add", "ctl00_phG_panelAddReceiptLineReturn_frmReceiptReturnLineFilter");
                    AddClose = new Button("ctl00_phG_panelAddReceiptLineReturn_PXButton20", "Add & Close", "ctl00_phG_panelAddReceiptLineReturn_frmReceiptReturnLineFilter");
                    Cancel = new Button("ctl00_phG_panelAddReceiptLineReturn_PXButton21", "Cancel", "ctl00_phG_panelAddReceiptLineReturn_frmReceiptReturnLineFilter");
                }
            }
        }
        
        public class c_lsporeceiptline_lotseropts_optform : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXNumberEdit UnassignedQty { get; }
			public Label UnassignedQtyLabel { get; }
			public PXNumberEdit Qty { get; }
			public Label QtyLabel { get; }
			public PXTextEdit StartNumVal { get; }
			public Label StartNumValLabel { get; }
            
            public c_lsporeceiptline_lotseropts_optform(string locator, string name) : 
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
                DataMemberName = "LSPOReceiptLine_lotseropts";
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
        
        public class c_polinesselection_gridol : Grid<c_polinesselection_gridol.c_grid_row, c_polinesselection_gridol.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_polinesselection_gridol(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelAddPOLine_gridOL");
                DataMemberName = "poLinesSelection";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PanelAddPOLine_gridOL_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOLine_gridOL_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOLine_gridOL_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOLine_gridOL_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOLine_gridOL_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOLine_gridOL_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOLine_gridOL_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOLine_gridOL_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOLine_gridOL_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPOLine_gridOL_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddPOLine_PXButton1", "Add", "ctl00_phG_PanelAddPOLine_gridOL");
                    AddClose = new Button("ctl00_phG_PanelAddPOLine_PXButton2", "Add & Close", "ctl00_phG_PanelAddPOLine_gridOL");
                    Cancel = new Button("ctl00_phG_PanelAddPOLine_PXButton9", "Cancel", "ctl00_phG_PanelAddPOLine_gridOL");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox Selected { get; }
			public PXTextEdit OrderNbr { get; }
			public Selector VendorID { get; }
			public DropDown LineType { get; }
			public Selector InventoryID { get; }
			public Selector SubItemID { get; }
			public Selector UOM { get; }
			public PXNumberEdit OrderQty { get; }
			public PXNumberEdit ReceivedQty { get; }
			public PXNumberEdit LeftToReceiveQty { get; }
			public PXTextEdit TranDesc { get; }
			public DateSelector PromisedDate { get; }
			public PXNumberEdit RcptQtyMin { get; }
			public PXNumberEdit RcptQtyMax { get; }
			public DropDown RcptQtyAction { get; }
			public PXNumberEdit LineNbr { get; }
			public PXTextEdit OrderType { get; }
                
                public c_grid_row(c_polinesselection_gridol grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phG_PanelAddPOLine_gridOL_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    OrderNbr = new PXTextEdit("ctl00_phG_PanelAddPOLine_gridOL_em", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    VendorID = new Selector("_ctl00_phG_PanelAddPOLine_gridOL_lv0_es", "Vendor", grid.Locator, "VendorID");
                    VendorID.DataField = "VendorID";
                    LineType = new DropDown("_ctl00_phG_PanelAddPOLine_gridOL_lv0_ec", "Line Type", grid.Locator, "LineType");
                    LineType.DataField = "LineType";
                    LineType.Items.Add("GI", "Goods for IN");
                    LineType.Items.Add("GS", "Goods for SO");
                    LineType.Items.Add("GF", "Goods for FS");
                    LineType.Items.Add("GR", "Goods for RP");
                    LineType.Items.Add("GP", "Goods for Drop-Ship");
                    LineType.Items.Add("NP", "Non-Stock for Drop-Ship");
                    LineType.Items.Add("PG", "Goods for Project");
                    LineType.Items.Add("PN", "Non-Stock for Project");
                    LineType.Items.Add("NO", "Non-Stock for SO");
                    LineType.Items.Add("NF", "Non-Stock for FS");
                    LineType.Items.Add("NS", "Non-Stock");
                    LineType.Items.Add("SV", "Service");
                    LineType.Items.Add("FT", "Freight");
                    LineType.Items.Add("DN", "Description");
                    InventoryID = new Selector("_ctl00_phG_PanelAddPOLine_gridOL_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SubItemID = new Selector("_ctl00_phG_PanelAddPOLine_gridOL_lv0_es", "Subitem", grid.Locator, "SubItemID");
                    SubItemID.DataField = "SubItemID";
                    UOM = new Selector("_ctl00_phG_PanelAddPOLine_gridOL_lv0_es", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    OrderQty = new PXNumberEdit("ctl00_phG_PanelAddPOLine_gridOL_en", "Order Qty.", grid.Locator, "OrderQty");
                    OrderQty.DataField = "OrderQty";
                    ReceivedQty = new PXNumberEdit("ctl00_phG_PanelAddPOLine_gridOL_en", "Qty. On Receipts", grid.Locator, "ReceivedQty");
                    ReceivedQty.DataField = "ReceivedQty";
                    LeftToReceiveQty = new PXNumberEdit("ctl00_phG_PanelAddPOLine_gridOL_en", "Open Qty.", grid.Locator, "LeftToReceiveQty");
                    LeftToReceiveQty.DataField = "LeftToReceiveQty";
                    TranDesc = new PXTextEdit("ctl00_phG_PanelAddPOLine_gridOL_ei", "Line Description", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    PromisedDate = new DateSelector("_ctl00_phG_PanelAddPOLine_gridOL_lv0_ed13", "Promised Date", grid.Locator, "PromisedDate");
                    PromisedDate.DataField = "PromisedDate";
                    RcptQtyMin = new PXNumberEdit("ctl00_phG_PanelAddPOLine_gridOL_en", "Min. Receipt (%)", grid.Locator, "RcptQtyMin");
                    RcptQtyMin.DataField = "RcptQtyMin";
                    RcptQtyMax = new PXNumberEdit("ctl00_phG_PanelAddPOLine_gridOL_en", "Max. Receipt (%)", grid.Locator, "RcptQtyMax");
                    RcptQtyMax.DataField = "RcptQtyMax";
                    RcptQtyAction = new DropDown("_ctl00_phG_PanelAddPOLine_gridOL_lv0_ec", "Receipt Action", grid.Locator, "RcptQtyAction");
                    RcptQtyAction.DataField = "RcptQtyAction";
                    RcptQtyAction.Items.Add("R", "Reject");
                    RcptQtyAction.Items.Add("W", "Accept but Warn");
                    RcptQtyAction.Items.Add("A", "Accept");
                    LineNbr = new PXNumberEdit("ctl00_phG_PanelAddPOLine_gridOL_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    OrderType = new PXTextEdit("ctl00_phG_PanelAddPOLine_gridOL_ei", "Order Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter OrderNbr { get; }
				public SelectorColumnFilter VendorID { get; }
				public DropDownColumnFilter LineType { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SubItemID { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter OrderQty { get; }
				public PXNumberEditColumnFilter ReceivedQty { get; }
				public PXNumberEditColumnFilter LeftToReceiveQty { get; }
				public PXTextEditColumnFilter TranDesc { get; }
				public DateSelectorColumnFilter PromisedDate { get; }
				public PXNumberEditColumnFilter RcptQtyMin { get; }
				public PXNumberEditColumnFilter RcptQtyMax { get; }
				public DropDownColumnFilter RcptQtyAction { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
				public PXTextEditColumnFilter OrderType { get; }
                
                public c_grid_header(c_polinesselection_gridol grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    OrderNbr = new PXTextEditColumnFilter(grid.Row.OrderNbr);
                    VendorID = new SelectorColumnFilter(grid.Row.VendorID);
                    LineType = new DropDownColumnFilter(grid.Row.LineType);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SubItemID = new SelectorColumnFilter(grid.Row.SubItemID);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    OrderQty = new PXNumberEditColumnFilter(grid.Row.OrderQty);
                    ReceivedQty = new PXNumberEditColumnFilter(grid.Row.ReceivedQty);
                    LeftToReceiveQty = new PXNumberEditColumnFilter(grid.Row.LeftToReceiveQty);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    PromisedDate = new DateSelectorColumnFilter(grid.Row.PromisedDate);
                    RcptQtyMin = new PXNumberEditColumnFilter(grid.Row.RcptQtyMin);
                    RcptQtyMax = new PXNumberEditColumnFilter(grid.Row.RcptQtyMax);
                    RcptQtyAction = new DropDownColumnFilter(grid.Row.RcptQtyAction);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    OrderType = new PXTextEditColumnFilter(grid.Row.OrderType);
                }
            }
        }
        
        public class c_polinesselection_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
			public Selector Em { get; }
			public Label EmLabel { get; }
            
            public c_polinesselection_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PanelAddPOLine_gridOL_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_PanelAddPOLine_gridOL_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_PanelAddPOLine_gridOL_lv0_ec", "Ec", locator, null);
                Em = new Selector("ctl00_phG_PanelAddPOLine_gridOL_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "poLinesSelection";
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
                    Add = new Button("ctl00_phG_PanelAddPOLine_PXButton1", "Add", "ctl00_phG_PanelAddPOLine_gridOL_lv0");
                    AddClose = new Button("ctl00_phG_PanelAddPOLine_PXButton2", "Add & Close", "ctl00_phG_PanelAddPOLine_gridOL_lv0");
                    Cancel = new Button("ctl00_phG_PanelAddPOLine_PXButton9", "Cancel", "ctl00_phG_PanelAddPOLine_gridOL_lv0");
                }
            }
        }
        
        public class c_openorders_grdopenorders : Grid<c_openorders_grdopenorders.c_grid_row, c_openorders_grdopenorders.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_openorders_grdopenorders(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_PanelAddPO_grdOpenOrders");
                DataMemberName = "openOrders";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_PanelAddPO_grdOpenOrders_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPO_grdOpenOrders_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPO_grdOpenOrders_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPO_grdOpenOrders_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPO_grdOpenOrders_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPO_grdOpenOrders_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPO_grdOpenOrders_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPO_grdOpenOrders_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPO_grdOpenOrders_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_PanelAddPO_grdOpenOrders_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_PanelAddPO_PXButton8", "Add", "ctl00_phG_PanelAddPO_grdOpenOrders");
                    AddClose = new Button("ctl00_phG_PanelAddPO_PXButton3", "Add & Close", "ctl00_phG_PanelAddPO_grdOpenOrders");
                    Cancel = new Button("ctl00_phG_PanelAddPO_PXButton4", "Cancel", "ctl00_phG_PanelAddPO_grdOpenOrders");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox Selected { get; }
			public DropDown OrderType { get; }
			public Selector OrderNbr { get; }
			public DateSelector OrderDate { get; }
			public DropDown Status { get; }
			public Selector CuryID { get; }
			public PXNumberEdit CuryOrderTotal { get; }
			public PXTextEdit VendorRefNbr { get; }
			public Selector TermsID { get; }
			public PXTextEdit OrderDesc { get; }
			public PXNumberEdit ReceivedQty { get; }
			public PXNumberEdit LeftToReceiveQty { get; }
                
                public c_grid_row(c_openorders_grdopenorders grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phG_PanelAddPO_grdOpenOrders_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    OrderType = new DropDown("_ctl00_phG_PanelAddPO_grdOpenOrders_lv0_ec", "Type", grid.Locator, "OrderType");
                    OrderType.DataField = "OrderType";
                    OrderType.Items.Add("RO", "Normal");
                    OrderType.Items.Add("DP", "Drop-Ship");
                    OrderType.Items.Add("PD", "Project Drop-Ship");
                    OrderType.Items.Add("BL", "Blanket");
                    OrderType.Items.Add("SB", "Standard");
                    OrderNbr = new Selector("_ctl00_phG_PanelAddPO_grdOpenOrders_lv0_es", "Order Nbr.", grid.Locator, "OrderNbr");
                    OrderNbr.DataField = "OrderNbr";
                    OrderDate = new DateSelector("_ctl00_phG_PanelAddPO_grdOpenOrders_lv0_ed5", "Date", grid.Locator, "OrderDate");
                    OrderDate.DataField = "OrderDate";
                    Status = new DropDown("_ctl00_phG_PanelAddPO_grdOpenOrders_lv0_ec", "Status", grid.Locator, "Status");
                    Status.DataField = "Status";
                    Status.Items.Add("H", "On Hold");
                    Status.Items.Add("B", "Pending Approval");
                    Status.Items.Add("V", "Rejected");
                    Status.Items.Add("N", "Open");
                    Status.Items.Add("A", "Awaiting Link");
                    Status.Items.Add("D", "Pending Printing");
                    Status.Items.Add("E", "Pending Email");
                    Status.Items.Add("L", "Canceled");
                    Status.Items.Add("M", "Completed");
                    Status.Items.Add("C", "Closed");
                    Status.Items.Add("P", "Printed");
                    CuryID = new Selector("_ctl00_phG_PanelAddPO_grdOpenOrders_lv0_es", "Currency", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    CuryOrderTotal = new PXNumberEdit("ctl00_phG_PanelAddPO_grdOpenOrders_en", "Order Total", grid.Locator, "CuryOrderTotal");
                    CuryOrderTotal.DataField = "CuryOrderTotal";
                    VendorRefNbr = new PXTextEdit("ctl00_phG_PanelAddPO_grdOpenOrders_ei", "Vendor Ref.", grid.Locator, "VendorRefNbr");
                    VendorRefNbr.DataField = "VendorRefNbr";
                    TermsID = new Selector("_ctl00_phG_PanelAddPO_grdOpenOrders_lv0_es", "Terms", grid.Locator, "TermsID");
                    TermsID.DataField = "TermsID";
                    OrderDesc = new PXTextEdit("ctl00_phG_PanelAddPO_grdOpenOrders_ei", "Description", grid.Locator, "OrderDesc");
                    OrderDesc.DataField = "OrderDesc";
                    ReceivedQty = new PXNumberEdit("ctl00_phG_PanelAddPO_grdOpenOrders_en", "Received Qty.", grid.Locator, "ReceivedQty");
                    ReceivedQty.DataField = "ReceivedQty";
                    LeftToReceiveQty = new PXNumberEdit("ctl00_phG_PanelAddPO_grdOpenOrders_en", "Open Qty.", grid.Locator, "LeftToReceiveQty");
                    LeftToReceiveQty.DataField = "LeftToReceiveQty";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public DropDownColumnFilter OrderType { get; }
				public SelectorColumnFilter OrderNbr { get; }
				public DateSelectorColumnFilter OrderDate { get; }
				public DropDownColumnFilter Status { get; }
				public SelectorColumnFilter CuryID { get; }
				public PXNumberEditColumnFilter CuryOrderTotal { get; }
				public PXTextEditColumnFilter VendorRefNbr { get; }
				public SelectorColumnFilter TermsID { get; }
				public PXTextEditColumnFilter OrderDesc { get; }
				public PXNumberEditColumnFilter ReceivedQty { get; }
				public PXNumberEditColumnFilter LeftToReceiveQty { get; }
                
                public c_grid_header(c_openorders_grdopenorders grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    OrderType = new DropDownColumnFilter(grid.Row.OrderType);
                    OrderNbr = new SelectorColumnFilter(grid.Row.OrderNbr);
                    OrderDate = new DateSelectorColumnFilter(grid.Row.OrderDate);
                    Status = new DropDownColumnFilter(grid.Row.Status);
                    CuryID = new SelectorColumnFilter(grid.Row.CuryID);
                    CuryOrderTotal = new PXNumberEditColumnFilter(grid.Row.CuryOrderTotal);
                    VendorRefNbr = new PXTextEditColumnFilter(grid.Row.VendorRefNbr);
                    TermsID = new SelectorColumnFilter(grid.Row.TermsID);
                    OrderDesc = new PXTextEditColumnFilter(grid.Row.OrderDesc);
                    ReceivedQty = new PXNumberEditColumnFilter(grid.Row.ReceivedQty);
                    LeftToReceiveQty = new PXNumberEditColumnFilter(grid.Row.LeftToReceiveQty);
                }
            }
        }
        
        public class c_openorders_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_openorders_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_PanelAddPO_grdOpenOrders_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_PanelAddPO_grdOpenOrders_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_PanelAddPO_grdOpenOrders_lv0_ec", "Ec", locator, null);
                DataMemberName = "openOrders";
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
                    Add = new Button("ctl00_phG_PanelAddPO_PXButton8", "Add", "ctl00_phG_PanelAddPO_grdOpenOrders_lv0");
                    AddClose = new Button("ctl00_phG_PanelAddPO_PXButton3", "Add & Close", "ctl00_phG_PanelAddPO_grdOpenOrders_lv0");
                    Cancel = new Button("ctl00_phG_PanelAddPO_PXButton4", "Cancel", "ctl00_phG_PanelAddPO_grdOpenOrders_lv0");
                }
            }
        }
        
        public class c_poreceiptreturn_grdreceiptreturn : Grid<c_poreceiptreturn_grdreceiptreturn.c_grid_row, c_poreceiptreturn_grdreceiptreturn.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_poreceiptreturn_grdreceiptreturn(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_panelAddReceiptReturn_grdReceiptReturn");
                DataMemberName = "poReceiptReturn";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_at_tlb div[data-cmd=\'Refres" +
                            "h\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_at_tlb div[data-cmd=\'Adjust" +
                            "Columns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_at_tlb div[data-cmd=\'Export" +
                            "Excel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_ab_tlb div[data-cmd=\'PageFi" +
                            "rst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_ab_tlb div[data-cmd=\'PagePr" +
                            "ev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_ab_tlb div[data-cmd=\'PageNe" +
                            "xt\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_ab_tlb div[data-cmd=\'PageLa" +
                            "st\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_panelAddReceiptReturn_PXButton14", "Add", "ctl00_phG_panelAddReceiptReturn_grdReceiptReturn");
                    AddClose = new Button("ctl00_phG_panelAddReceiptReturn_PXButton17", "Add & Close", "ctl00_phG_panelAddReceiptReturn_grdReceiptReturn");
                    Cancel = new Button("ctl00_phG_panelAddReceiptReturn_PXButton18", "Cancel", "ctl00_phG_panelAddReceiptReturn_grdReceiptReturn");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public Selector ReceiptNbr { get; }
			public DropDown ReceiptType { get; }
			public Selector VendorID { get; }
			public Selector VendorLocationID { get; }
			public PXTextEdit CuryID { get; }
			public DateSelector ReceiptDate { get; }
			public PXNumberEdit OrderQty { get; }
                
                public c_grid_row(c_poreceiptreturn_grdreceiptreturn grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    ReceiptNbr = new Selector("_ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_lv0_es", "Receipt Nbr.", grid.Locator, "ReceiptNbr");
                    ReceiptNbr.DataField = "ReceiptNbr";
                    ReceiptType = new DropDown("_ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_lv0_ec", "Type", grid.Locator, "ReceiptType");
                    ReceiptType.DataField = "ReceiptType";
                    ReceiptType.Items.Add("RT", "Receipt");
                    ReceiptType.Items.Add("RN", "Return");
                    ReceiptType.Items.Add("RX", "Transfer Receipt");
                    VendorID = new Selector("_ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_lv0_es", "Vendor", grid.Locator, "VendorID");
                    VendorID.DataField = "VendorID";
                    VendorLocationID = new Selector("_ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_lv0_es", "Location", grid.Locator, "VendorLocationID");
                    VendorLocationID.DataField = "VendorLocationID";
                    CuryID = new PXTextEdit("ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_em", "Currency", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    ReceiptDate = new DateSelector("_ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_lv0_ed6", "Date", grid.Locator, "ReceiptDate");
                    ReceiptDate.DataField = "ReceiptDate";
                    OrderQty = new PXNumberEdit("ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_en", "Total Qty.", grid.Locator, "OrderQty");
                    OrderQty.DataField = "OrderQty";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public SelectorColumnFilter ReceiptNbr { get; }
				public DropDownColumnFilter ReceiptType { get; }
				public SelectorColumnFilter VendorID { get; }
				public SelectorColumnFilter VendorLocationID { get; }
				public PXTextEditColumnFilter CuryID { get; }
				public DateSelectorColumnFilter ReceiptDate { get; }
				public PXNumberEditColumnFilter OrderQty { get; }
                
                public c_grid_header(c_poreceiptreturn_grdreceiptreturn grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    ReceiptNbr = new SelectorColumnFilter(grid.Row.ReceiptNbr);
                    ReceiptType = new DropDownColumnFilter(grid.Row.ReceiptType);
                    VendorID = new SelectorColumnFilter(grid.Row.VendorID);
                    VendorLocationID = new SelectorColumnFilter(grid.Row.VendorLocationID);
                    CuryID = new PXTextEditColumnFilter(grid.Row.CuryID);
                    ReceiptDate = new DateSelectorColumnFilter(grid.Row.ReceiptDate);
                    OrderQty = new PXNumberEditColumnFilter(grid.Row.OrderQty);
                }
            }
        }
        
        public class c_poreceiptreturn_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_poreceiptreturn_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_lv0_ec", "Ec", locator, null);
                DataMemberName = "poReceiptReturn";
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
                    Add = new Button("ctl00_phG_panelAddReceiptReturn_PXButton14", "Add", "ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_lv0");
                    AddClose = new Button("ctl00_phG_panelAddReceiptReturn_PXButton17", "Add & Close", "ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_lv0");
                    Cancel = new Button("ctl00_phG_panelAddReceiptReturn_PXButton18", "Cancel", "ctl00_phG_panelAddReceiptReturn_grdReceiptReturn_lv0");
                }
            }
        }
        
        public class c_poreceiptlinereturn_grdreceiptlinereturn : Grid<c_poreceiptlinereturn_grdreceiptlinereturn.c_grid_row, c_poreceiptlinereturn_grdreceiptlinereturn.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_poreceiptlinereturn_grdreceiptlinereturn(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn");
                DataMemberName = "poReceiptLineReturn";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_at_tlb div[data-cmd" +
                            "=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_at_tlb div[data-cmd" +
                            "=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_at_tlb div[data-cmd" +
                            "=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_at_tlb div[data-cmd" +
                            "=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_ab_tlb div[data-cmd" +
                            "=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_ab_tlb div[data-cmd" +
                            "=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_ab_tlb div[data-cmd" +
                            "=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_ab_tlb div[data-cmd" +
                            "=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_ab_tlb div[data-cmd" +
                            "=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Add { get; }
			public Button AddClose { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Add = new Button("ctl00_phG_panelAddReceiptLineReturn_PXButton19", "Add", "ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn");
                    AddClose = new Button("ctl00_phG_panelAddReceiptLineReturn_PXButton20", "Add & Close", "ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn");
                    Cancel = new Button("ctl00_phG_panelAddReceiptLineReturn_PXButton21", "Cancel", "ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public Selector PONbr { get; }
			public DropDown POType { get; }
			public Selector ReceiptNbr { get; }
			public PXTextEdit CuryID { get; }
			public PXTextEdit InvoiceNbr { get; }
			public Selector InventoryID { get; }
			public Selector SiteID { get; }
			public Selector UOM { get; }
			public PXNumberEdit ReceiptQty { get; }
			public PXNumberEdit ReturnedQty { get; }
			public PXNumberEdit LineNbr { get; }
                
                public c_grid_row(c_poreceiptlinereturn_grdreceiptlinereturn grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    PONbr = new Selector("_ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_lv0_es", "Order Nbr.", grid.Locator, "PONbr");
                    PONbr.DataField = "PONbr";
                    POType = new DropDown("_ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_lv0_ec", "Order Type", grid.Locator, "POType");
                    POType.DataField = "POType";
                    POType.Items.Add("RO", "Normal");
                    POType.Items.Add("DP", "Drop-Ship");
                    POType.Items.Add("PD", "Project Drop-Ship");
                    POType.Items.Add("BL", "Blanket");
                    POType.Items.Add("SB", "Standard");
                    ReceiptNbr = new Selector("_ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_lv0_es", "Receipt Nbr.", grid.Locator, "ReceiptNbr");
                    ReceiptNbr.DataField = "ReceiptNbr";
                    CuryID = new PXTextEdit("ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_em", "Currency", grid.Locator, "CuryID");
                    CuryID.DataField = "CuryID";
                    InvoiceNbr = new PXTextEdit("ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_ei", "Vendor Ref.", grid.Locator, "InvoiceNbr");
                    InvoiceNbr.DataField = "InvoiceNbr";
                    InventoryID = new Selector("_ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_lv0_es", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    SiteID = new Selector("_ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_lv0_es", "Warehouse", grid.Locator, "SiteID");
                    SiteID.DataField = "SiteID";
                    UOM = new Selector("_ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_lv0_es", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    ReceiptQty = new PXNumberEdit("ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_en", "Receipt Qty.", grid.Locator, "ReceiptQty");
                    ReceiptQty.DataField = "ReceiptQty";
                    ReturnedQty = new PXNumberEdit("ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_en", "Returned Qty.", grid.Locator, "ReturnedQty");
                    ReturnedQty.DataField = "ReturnedQty";
                    LineNbr = new PXNumberEdit("ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_en", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public SelectorColumnFilter PONbr { get; }
				public DropDownColumnFilter POType { get; }
				public SelectorColumnFilter ReceiptNbr { get; }
				public PXTextEditColumnFilter CuryID { get; }
				public PXTextEditColumnFilter InvoiceNbr { get; }
				public SelectorColumnFilter InventoryID { get; }
				public SelectorColumnFilter SiteID { get; }
				public SelectorColumnFilter UOM { get; }
				public PXNumberEditColumnFilter ReceiptQty { get; }
				public PXNumberEditColumnFilter ReturnedQty { get; }
				public PXNumberEditColumnFilter LineNbr { get; }
                
                public c_grid_header(c_poreceiptlinereturn_grdreceiptlinereturn grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    PONbr = new SelectorColumnFilter(grid.Row.PONbr);
                    POType = new DropDownColumnFilter(grid.Row.POType);
                    ReceiptNbr = new SelectorColumnFilter(grid.Row.ReceiptNbr);
                    CuryID = new PXTextEditColumnFilter(grid.Row.CuryID);
                    InvoiceNbr = new PXTextEditColumnFilter(grid.Row.InvoiceNbr);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    SiteID = new SelectorColumnFilter(grid.Row.SiteID);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    ReceiptQty = new PXNumberEditColumnFilter(grid.Row.ReceiptQty);
                    ReturnedQty = new PXNumberEditColumnFilter(grid.Row.ReturnedQty);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                }
            }
        }
        
        public class c_poreceiptlinereturn_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_poreceiptlinereturn_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_lv0_ec", "Ec", locator, null);
                DataMemberName = "poReceiptLineReturn";
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
                    Add = new Button("ctl00_phG_panelAddReceiptLineReturn_PXButton19", "Add", "ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_lv0");
                    AddClose = new Button("ctl00_phG_panelAddReceiptLineReturn_PXButton20", "Add & Close", "ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_lv0");
                    Cancel = new Button("ctl00_phG_panelAddReceiptLineReturn_PXButton21", "Cancel", "ctl00_phG_panelAddReceiptLineReturn_grdReceiptLineReturn_lv0");
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
