using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
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
    
    
    public class AR101000_ARSetupMaint : Wrapper
    {
        
        public Note NotePanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        public Container Translations { get; } = new Container("ctl00_L10nEditor", "Translations");
        protected c_arsetuprecord_tab ARSetupRecord_tab { get; } = new c_arsetuprecord_tab("ctl00_phF_tab", "ARSetupRecord_tab");
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
        protected c_notifications_gridns Notifications_gridNS { get; } = new c_notifications_gridns("ctl00_phF_tab_t4_sp1_gridNS", "Notifications_gridNS");
        protected c_notifications_lv0 Notifications_lv0 { get; } = new c_notifications_lv0("ctl00_phF_tab_t4_sp1_gridNS_lv0", "Notifications_lv0");
        protected c_recipients_gridnr Recipients_gridNR { get; } = new c_recipients_gridnr("ctl00_phF_tab_t4_sp1_gridNR", "Recipients_gridNR");
        protected c_recipients_lv0 Recipients_lv0 { get; } = new c_recipients_lv0("ctl00_phF_tab_t4_sp1_gridNR_lv0", "Recipients_lv0");
        protected c_dunningsetup_gridns DunningSetup_gridNS { get; } = new c_dunningsetup_gridns("ctl00_phF_tab_t3_gridNS", "DunningSetup_gridNS");
        protected c_setupapproval_gridapproval SetupApproval_gridApproval { get; } = new c_setupapproval_gridapproval("ctl00_phF_tab_t2_gridApproval", "SetupApproval_gridApproval");
        protected c_setupapproval_lv0 SetupApproval_lv0 { get; } = new c_setupapproval_lv0("ctl00_phF_tab_t2_gridApproval_lv0", "SetupApproval_lv0");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        
        public AR101000_ARSetupMaint()
        {
            ScreenId = "AR101000";
            ScreenUrl = "/Pages/AR/AR101000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        public virtual AR101000_ARSetupMaint ReadOne(Gate gate)
        {
            new BiObject<AR101000_ARSetupMaint>(gate).ReadOne(this);
            return this;
        }
        
        public virtual AR101000_ARSetupMaint ReadOne()
        {
            return this.ReadOne(ApiConnection.Source);
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
        
        public virtual void Save()
        {
            ToolBar.Save.Click();
        }
        
        public virtual void Cancel()
        {
            ToolBar.Cancel.Click();
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
			public ToolBarButton MenuEditProj { get; }
			public ToolBarButton ManageCustomizations { get; }
			public ToolBarButton KeyBtnRefresh { get; }
			public ToolBarButton Help { get; }
			public ToolBarButton Save { get; }
			public ToolBarButton Cancel { get; }
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
                MenuEditProj = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "menuEditProj\']", "Edit Project...", locator, Custom);
                ManageCustomizations = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li.menuItem d" +
                        "iv:textEqual(\"Manage Customizations...\")", "Manage Customizations...", locator, Custom);
                KeyBtnRefresh = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'keyBtnRefresh\']", "Click to refresh page.", locator, null);
                Help = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'help\']", "View Tools", locator, null);
                Save = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Save", "Save (Ctrl+S).", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Cancel", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                LongRun = new ToolBarButton("css=qp-long-run", "Nothing in progress", locator, null);
                LongrunCancel = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_cancel", "Cancel", locator, null);
                LongrunTimer = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_timer", "Elapsed Time", locator, null);
            }
        }
        
        public class c_arsetuprecord_tab : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector BatchNumberingID { get; }
			public Label BatchNumberingIDLabel { get; }
			public Selector InvoiceNumberingID { get; }
			public Label InvoiceNumberingIDLabel { get; }
			public Selector PaymentNumberingID { get; }
			public Label PaymentNumberingIDLabel { get; }
			public Selector DebitAdjNumberingID { get; }
			public Label DebitAdjNumberingIDLabel { get; }
			public Selector CreditAdjNumberingID { get; }
			public Label CreditAdjNumberingIDLabel { get; }
			public Selector WriteOffNumberingID { get; }
			public Label WriteOffNumberingIDLabel { get; }
			public Selector FinChargeNumberingID { get; }
			public Label FinChargeNumberingIDLabel { get; }
			public Selector PriceWSNumberingID { get; }
			public Label PriceWSNumberingIDLabel { get; }
			public Selector DunningFeeNumberingID { get; }
			public Label DunningFeeNumberingIDLabel { get; }
			public CheckBox AutoPost { get; }
			public Label AutoPostLabel { get; }
			public CheckBox SummaryPost { get; }
			public Label SummaryPostLabel { get; }
			public CheckBox MigrationMode { get; }
			public Label MigrationModeLabel { get; }
			public Selector DfltCustomerClassID { get; }
			public Label DfltCustomerClassIDLabel { get; }
			public Selector SalesSubMask { get; }
			public Label SalesSubMaskLabel { get; }
			public DropDown IntercompanySalesAccountDefault { get; }
			public Label IntercompanySalesAccountDefaultLabel { get; }
			public DropDown InvoiceRounding { get; }
			public Label InvoiceRoundingLabel { get; }
			public DropDown InvoicePrecision { get; }
			public Label InvoicePrecisionLabel { get; }
			public CheckBox HoldEntry { get; }
			public Label HoldEntryLabel { get; }
			public CheckBox RequireControlTotal { get; }
			public Label RequireControlTotalLabel { get; }
			public CheckBox RequireExtRef { get; }
			public Label RequireExtRefLabel { get; }
			public CheckBox CreditCheckError { get; }
			public Label CreditCheckErrorLabel { get; }
			public CheckBox PrintBeforeRelease { get; }
			public Label PrintBeforeReleaseLabel { get; }
			public CheckBox EmailBeforeRelease { get; }
			public Label EmailBeforeReleaseLabel { get; }
			public CheckBox IntegratedCCProcessing { get; }
			public Label IntegratedCCProcessingLabel { get; }
			public CheckBox AgeCredits { get; }
			public Label AgeCreditsLabel { get; }
			public CheckBox DefFinChargeFromCycle { get; }
			public Label DefFinChargeFromCycleLabel { get; }
			public CheckBox FinChargeOnCharge { get; }
			public Label FinChargeOnChargeLabel { get; }
			public CheckBox FinChargeFirst { get; }
			public Label FinChargeFirstLabel { get; }
			public DropDown SPCommnCalcType { get; }
			public Label SPCommnCalcTypeLabel { get; }
			public DropDown SPCommnPeriodType { get; }
			public Label SPCommnPeriodTypeLabel { get; }
			public DropDown PrepareStatements { get; }
			public Label PrepareStatementsLabel { get; }
			public Selector StatementBranchID { get; }
			public Label StatementBranchIDLabel { get; }
			public CheckBox ConsolidatedDunningLetter { get; }
			public Label ConsolidatedDunningLetterLabel { get; }
			public Selector DunningLetterBranchID { get; }
			public Label DunningLetterBranchIDLabel { get; }
			public Selector BalanceWriteOff { get; }
			public Label BalanceWriteOffLabel { get; }
			public Selector CreditWriteOff { get; }
			public Label CreditWriteOffLabel { get; }
			public CheckBox AutoReleasePPDCreditMemo { get; }
			public Label AutoReleasePPDCreditMemoLabel { get; }
			public InputLocalizable PPDCreditMemoDescr { get; }
			public Label PPDCreditMemoDescrLabel { get; }
			public CheckBox RetainTaxes { get; }
			public Label RetainTaxesLabel { get; }
			public CheckBox RetainageInvoicesAutoRelease { get; }
			public Label RetainageInvoicesAutoReleaseLabel { get; }
			public Selector DefaultRateTypeID { get; }
			public Label DefaultRateTypeIDLabel { get; }
			public CheckBox AlwaysFromBaseCury { get; }
			public Label AlwaysFromBaseCuryLabel { get; }
			public CheckBox LoadSalesPricesUsingAlternateID { get; }
			public Label LoadSalesPricesUsingAlternateIDLabel { get; }
			public DropDown RetentionType { get; }
			public Label RetentionTypeLabel { get; }
			public PXNumberEdit NumberOfMonths { get; }
			public Label NumberOfMonthsLabel { get; }
			public DropDown LineDiscountTarget { get; }
			public Label LineDiscountTargetLabel { get; }
			public DropDown ApplyQuantityDiscountBy { get; }
			public Label ApplyQuantityDiscountByLabel { get; }
			public PXTextEdit ApplyDiscountToLabelOnly { get; }
			public Label ApplyDiscountToLabelOnlyLabel { get; }
			public CheckBox ApplyLineDiscountsIfCustomerPriceDefined { get; }
			public Label ApplyLineDiscountsIfCustomerPriceDefinedLabel { get; }
			public CheckBox ApplyLineDiscountsIfCustomerClassPriceDefined { get; }
			public Label ApplyLineDiscountsIfCustomerClassPriceDefinedLabel { get; }
			public DropDown UsrDefAdjustmentType { get; }
			public Label UsrDefAdjustmentTypeLabel { get; }
			public DropDown UsrDefPricingType { get; }
			public Label UsrDefPricingTypeLabel { get; }
			public DropDown DunningLetterProcessType { get; }
			public Label DunningLetterProcessTypeLabel { get; }
			public CheckBox AutoReleaseDunningLetter { get; }
			public Label AutoReleaseDunningLetterLabel { get; }
			public CheckBox IncludeNonOverdueDunning { get; }
			public Label IncludeNonOverdueDunningLabel { get; }
			public Selector DunningFeeInventoryID { get; }
			public Label DunningFeeInventoryIDLabel { get; }
			public Selector DunningFeeTermID { get; }
			public Label DunningFeeTermIDLabel { get; }
			public CheckBox AutoReleaseDunningFee { get; }
			public Label AutoReleaseDunningFeeLabel { get; }
            
            public c_arsetuprecord_tab(string locator, string name) : 
                    base(locator, name)
            {
                BatchNumberingID = new Selector("ctl00_phF_tab_t0_edBatchNumberingID", "GL Batch Numbering Sequence", locator, null);
                BatchNumberingIDLabel = new Label(BatchNumberingID);
                BatchNumberingID.DataField = "BatchNumberingID";
                InvoiceNumberingID = new Selector("ctl00_phF_tab_t0_edInvoiceNumberingID", "Invoice Numbering Sequence", locator, null);
                InvoiceNumberingIDLabel = new Label(InvoiceNumberingID);
                InvoiceNumberingID.DataField = "InvoiceNumberingID";
                PaymentNumberingID = new Selector("ctl00_phF_tab_t0_edPaymentNumberingID", "Payment Numbering Sequence", locator, null);
                PaymentNumberingIDLabel = new Label(PaymentNumberingID);
                PaymentNumberingID.DataField = "PaymentNumberingID";
                DebitAdjNumberingID = new Selector("ctl00_phF_tab_t0_edDebitAdjNumberingID", "Debit Memo Numbering Sequence", locator, null);
                DebitAdjNumberingIDLabel = new Label(DebitAdjNumberingID);
                DebitAdjNumberingID.DataField = "DebitAdjNumberingID";
                CreditAdjNumberingID = new Selector("ctl00_phF_tab_t0_edCreditAdjNumberingID", "Credit Memo Numbering Sequence", locator, null);
                CreditAdjNumberingIDLabel = new Label(CreditAdjNumberingID);
                CreditAdjNumberingID.DataField = "CreditAdjNumberingID";
                WriteOffNumberingID = new Selector("ctl00_phF_tab_t0_edWriteOffNumberingID", "Write-Off Numbering Sequence", locator, null);
                WriteOffNumberingIDLabel = new Label(WriteOffNumberingID);
                WriteOffNumberingID.DataField = "WriteOffNumberingID";
                FinChargeNumberingID = new Selector("ctl00_phF_tab_t0_edFinChargeNumberingID", "Overdue Charge Numbering Sequence", locator, null);
                FinChargeNumberingIDLabel = new Label(FinChargeNumberingID);
                FinChargeNumberingID.DataField = "FinChargeNumberingID";
                PriceWSNumberingID = new Selector("ctl00_phF_tab_t0_edPriceWSNumberingID", "Price Worksheet Numbering Sequence", locator, null);
                PriceWSNumberingIDLabel = new Label(PriceWSNumberingID);
                PriceWSNumberingID.DataField = "PriceWSNumberingID";
                DunningFeeNumberingID = new Selector("ctl00_phF_tab_t0_edDunningNumberingID", "Dunning Fee Numbering Sequence", locator, null);
                DunningFeeNumberingIDLabel = new Label(DunningFeeNumberingID);
                DunningFeeNumberingID.DataField = "DunningFeeNumberingID";
                AutoPost = new CheckBox("ctl00_phF_tab_t0_chkAutoPost", "Automatically Post on Release", locator, null);
                AutoPostLabel = new Label(AutoPost);
                AutoPost.DataField = "AutoPost";
                SummaryPost = new CheckBox("ctl00_phF_tab_t0_chkSummaryPost", "Post Summary on Updating GL", locator, null);
                SummaryPostLabel = new Label(SummaryPost);
                SummaryPost.DataField = "SummaryPost";
                MigrationMode = new CheckBox("ctl00_phF_tab_t0_chkMigrationMode", "Activate Migration Mode", locator, null);
                MigrationModeLabel = new Label(MigrationMode);
                MigrationMode.DataField = "MigrationMode";
                DfltCustomerClassID = new Selector("ctl00_phF_tab_t0_edDfltCustomerClassID", "Default Customer Class ID", locator, null);
                DfltCustomerClassIDLabel = new Label(DfltCustomerClassID);
                DfltCustomerClassID.DataField = "DfltCustomerClassID";
                SalesSubMask = new Selector("ctl00_phF_tab_t0_edSalesSubMask", "Combine Sales Sub. From", locator, null);
                SalesSubMaskLabel = new Label(SalesSubMask);
                SalesSubMask.DataField = "SalesSubMask";
                IntercompanySalesAccountDefault = new DropDown("ctl00_phF_tab_t0_edIntercompanySalesAccountDefault", "Use Intercompany Sales Account From", locator, null);
                IntercompanySalesAccountDefaultLabel = new Label(IntercompanySalesAccountDefault);
                IntercompanySalesAccountDefault.DataField = "IntercompanySalesAccountDefault";
                IntercompanySalesAccountDefault.Items.Add("L", "Customer Location");
                IntercompanySalesAccountDefault.Items.Add("I", "Inventory Item");
                InvoiceRounding = new DropDown("ctl00_phF_tab_t0_edInvoiceRounding", "Rounding Rule for Invoices", locator, null);
                InvoiceRoundingLabel = new Label(InvoiceRounding);
                InvoiceRounding.DataField = "InvoiceRounding";
                InvoiceRounding.Items.Add("N", "Use Currency Precision");
                InvoiceRounding.Items.Add("R", "Nearest");
                InvoiceRounding.Items.Add("C", "Up");
                InvoiceRounding.Items.Add("F", "Down");
                InvoicePrecision = new DropDown("ctl00_phF_tab_t0_edInvoicePrecision", "Rounding Precision", locator, null);
                InvoicePrecisionLabel = new Label(InvoicePrecision);
                InvoicePrecision.DataField = "InvoicePrecision";
                InvoicePrecision.Items.Add("0.05", "0.05");
                InvoicePrecision.Items.Add("0.10", "0.10");
                InvoicePrecision.Items.Add("0.50", "0.50");
                InvoicePrecision.Items.Add("1.00", "1.00");
                InvoicePrecision.Items.Add("10.00", "10.00");
                InvoicePrecision.Items.Add("100.00", "100.00");
                HoldEntry = new CheckBox("ctl00_phF_tab_t0_chkHoldEntry", "Hold Documents on Entry", locator, null);
                HoldEntryLabel = new Label(HoldEntry);
                HoldEntry.DataField = "HoldEntry";
                RequireControlTotal = new CheckBox("ctl00_phF_tab_t0_chkRequireControlTotal", "Validate Document Totals on Entry", locator, null);
                RequireControlTotalLabel = new Label(RequireControlTotal);
                RequireControlTotal.DataField = "RequireControlTotal";
                RequireExtRef = new CheckBox("ctl00_phF_tab_t0_chkRequireExtRef", "Require Payment Reference on Entry", locator, null);
                RequireExtRefLabel = new Label(RequireExtRef);
                RequireExtRef.DataField = "RequireExtRef";
                CreditCheckError = new CheckBox("ctl00_phF_tab_t0_chkCreditCheckError", "Hold Document on Failed Credit Check", locator, null);
                CreditCheckErrorLabel = new Label(CreditCheckError);
                CreditCheckError.DataField = "CreditCheckError";
                PrintBeforeRelease = new CheckBox("ctl00_phF_tab_t0_chkPrintBeforeRelease", "Require Invoice/Memo Printing Before Release", locator, null);
                PrintBeforeReleaseLabel = new Label(PrintBeforeRelease);
                PrintBeforeRelease.DataField = "PrintBeforeRelease";
                EmailBeforeRelease = new CheckBox("ctl00_phF_tab_t0_chkEmailBeforeRelease", "Require Invoice/Memo Emailing Before Release", locator, null);
                EmailBeforeReleaseLabel = new Label(EmailBeforeRelease);
                EmailBeforeRelease.DataField = "EmailBeforeRelease";
                IntegratedCCProcessing = new CheckBox("ctl00_phF_tab_t0_chkIntegratedCCProcessing", "Enable Integrated CC Processing", locator, null);
                IntegratedCCProcessingLabel = new Label(IntegratedCCProcessing);
                IntegratedCCProcessing.DataField = "IntegratedCCProcessing";
                AgeCredits = new CheckBox("ctl00_phF_tab_t0_chkAgeCredits", "Age Credits", locator, null);
                AgeCreditsLabel = new Label(AgeCredits);
                AgeCredits.DataField = "AgeCredits";
                DefFinChargeFromCycle = new CheckBox("ctl00_phF_tab_t0_chkDefFinChargeFromCycle", "Set Default Overdue Charges by Statement Cycle", locator, null);
                DefFinChargeFromCycleLabel = new Label(DefFinChargeFromCycle);
                DefFinChargeFromCycle.DataField = "DefFinChargeFromCycle";
                FinChargeOnCharge = new CheckBox("ctl00_phF_tab_t0_chkFinChargeOnCharge", "Calculate on Overdue Charge Documents", locator, null);
                FinChargeOnChargeLabel = new Label(FinChargeOnCharge);
                FinChargeOnCharge.DataField = "FinChargeOnCharge";
                FinChargeFirst = new CheckBox("ctl00_phF_tab_t0_chkFinChargeFirst", "Apply Payments to Overdue Charges First", locator, null);
                FinChargeFirstLabel = new Label(FinChargeFirst);
                FinChargeFirst.DataField = "FinChargeFirst";
                SPCommnCalcType = new DropDown("ctl00_phF_tab_t0_edSPCommnCalcType", "Salesperson Commission by", locator, null);
                SPCommnCalcTypeLabel = new Label(SPCommnCalcType);
                SPCommnCalcType.DataField = "SPCommnCalcType";
                SPCommnCalcType.Items.Add("I", "Invoice");
                SPCommnCalcType.Items.Add("P", "Payment");
                SPCommnPeriodType = new DropDown("ctl00_phF_tab_t0_edSPCommnPeriodType", "Commission Period Type", locator, null);
                SPCommnPeriodTypeLabel = new Label(SPCommnPeriodType);
                SPCommnPeriodType.DataField = "SPCommnPeriodType";
                SPCommnPeriodType.Items.Add("M", "Monthly");
                SPCommnPeriodType.Items.Add("Q", "Quarterly");
                SPCommnPeriodType.Items.Add("Y", "Yearly");
                SPCommnPeriodType.Items.Add("F", "By Financial Period");
                PrepareStatements = new DropDown("ctl00_phF_tab_t0_edPrepareStatements", "Prepare Statements", locator, null);
                PrepareStatementsLabel = new Label(PrepareStatements);
                PrepareStatements.DataField = "PrepareStatements";
                PrepareStatements.Items.Add("B", "For Each Branch");
                PrepareStatements.Items.Add("C", "Consolidated for Company");
                PrepareStatements.Items.Add("A", "Consolidated for All Companies");
                StatementBranchID = new Selector("ctl00_phF_tab_t0_edStatementBranchID", "Statement from Branch", locator, null);
                StatementBranchIDLabel = new Label(StatementBranchID);
                StatementBranchID.DataField = "StatementBranchID";
                ConsolidatedDunningLetter = new CheckBox("ctl00_phF_tab_t0_chkConsolidatedDunningLetter", "Consolidate Dunning Letters for all Branches", locator, null);
                ConsolidatedDunningLetterLabel = new Label(ConsolidatedDunningLetter);
                ConsolidatedDunningLetter.DataField = "ConsolidatedDunningLetter";
                DunningLetterBranchID = new Selector("ctl00_phF_tab_t0_edDunningLetterBranchID", "Dunning Letter from Branch", locator, null);
                DunningLetterBranchIDLabel = new Label(DunningLetterBranchID);
                DunningLetterBranchID.DataField = "DunningLetterBranchID";
                BalanceWriteOff = new Selector("ctl00_phF_tab_t0_PXSelector1", "Balance Write-Off Reason Code", locator, null);
                BalanceWriteOffLabel = new Label(BalanceWriteOff);
                BalanceWriteOff.DataField = "BalanceWriteOff";
                CreditWriteOff = new Selector("ctl00_phF_tab_t0_PXSelector2", "Credit Write-Off Reason Code", locator, null);
                CreditWriteOffLabel = new Label(CreditWriteOff);
                CreditWriteOff.DataField = "CreditWriteOff";
                AutoReleasePPDCreditMemo = new CheckBox("ctl00_phF_tab_t0_chkAutoReleasePPDCreditMemo", "Automatically Release Credit Memos", locator, null);
                AutoReleasePPDCreditMemoLabel = new Label(AutoReleasePPDCreditMemo);
                AutoReleasePPDCreditMemo.DataField = "AutoReleasePPDCreditMemo";
                PPDCreditMemoDescr = new InputLocalizable("ctl00_phF_tab_t0_edPPDCreditMemoDescr", "Credit Memo Description", locator, null);
                PPDCreditMemoDescrLabel = new Label(PPDCreditMemoDescr);
                PPDCreditMemoDescr.DataField = "PPDCreditMemoDescr";
                RetainTaxes = new CheckBox("ctl00_phF_tab_t0_chkRetainTaxes", "Retain Taxes", locator, null);
                RetainTaxesLabel = new Label(RetainTaxes);
                RetainTaxes.DataField = "RetainTaxes";
                RetainageInvoicesAutoRelease = new CheckBox("ctl00_phF_tab_t0_chkRetainageInvoicesAutoRelease", "Automatically Release Retainage Documents", locator, null);
                RetainageInvoicesAutoReleaseLabel = new Label(RetainageInvoicesAutoRelease);
                RetainageInvoicesAutoRelease.DataField = "RetainageInvoicesAutoRelease";
                DefaultRateTypeID = new Selector("ctl00_phF_tab_t1_edDefaultRateTypeID", "Default Rate Type", locator, null);
                DefaultRateTypeIDLabel = new Label(DefaultRateTypeID);
                DefaultRateTypeID.DataField = "DefaultRateTypeID";
                AlwaysFromBaseCury = new CheckBox("ctl00_phF_tab_t1_chkAlwaysFromBaseCury", "Always Calculate Price from Base Currency Price", locator, null);
                AlwaysFromBaseCuryLabel = new Label(AlwaysFromBaseCury);
                AlwaysFromBaseCury.DataField = "AlwaysFromBaseCury";
                LoadSalesPricesUsingAlternateID = new CheckBox("ctl00_phF_tab_t1_chkLoadSalesPricesUsingAlternateID", "Load Sales Prices by Alternate ID", locator, null);
                LoadSalesPricesUsingAlternateIDLabel = new Label(LoadSalesPricesUsingAlternateID);
                LoadSalesPricesUsingAlternateID.DataField = "LoadSalesPricesUsingAlternateID";
                RetentionType = new DropDown("ctl00_phF_tab_t1_edRetentionType", "Retention Type", locator, null);
                RetentionTypeLabel = new Label(RetentionType);
                RetentionType.DataField = "RetentionType";
                RetentionType.Items.Add("L", "Last Price");
                RetentionType.Items.Add("F", "Fixed Number of Months");
                NumberOfMonths = new PXNumberEdit("ctl00_phF_tab_t1_edNumberOfMonths", "Number of Months", locator, null);
                NumberOfMonthsLabel = new Label(NumberOfMonths);
                NumberOfMonths.DataField = "NumberOfMonths";
                LineDiscountTarget = new DropDown("ctl00_phF_tab_t1_edLineDiscountTarget", "Line Discount Basis", locator, null);
                LineDiscountTargetLabel = new Label(LineDiscountTarget);
                LineDiscountTarget.DataField = "LineDiscountTarget";
                LineDiscountTarget.Items.Add("E", "Ext. Price");
                LineDiscountTarget.Items.Add("S", "Unit Price");
                ApplyQuantityDiscountBy = new DropDown("ctl00_phF_tab_t1_edApplyQuantityDiscountBy", "Apply Quantity Discounts To", locator, null);
                ApplyQuantityDiscountByLabel = new Label(ApplyQuantityDiscountBy);
                ApplyQuantityDiscountBy.DataField = "ApplyQuantityDiscountBy";
                ApplyQuantityDiscountBy.Items.Add("L", "Document Line UOM");
                ApplyQuantityDiscountBy.Items.Add("B", "Base UOM");
                ApplyDiscountToLabelOnly = new PXTextEdit("ctl00_phF_tab_t1_edApplyDiscountToLabelOnly", "Apply Line Discount to Prices Specific To", locator, null);
                ApplyDiscountToLabelOnlyLabel = new Label(ApplyDiscountToLabelOnly);
                ApplyDiscountToLabelOnly.DataField = "ApplyDiscountToLabelOnly";
                ApplyLineDiscountsIfCustomerPriceDefined = new CheckBox("ctl00_phF_tab_t1_chkApplyLineDiscountsIfCustomerPriceDefined", "Customer", locator, null);
                ApplyLineDiscountsIfCustomerPriceDefinedLabel = new Label(ApplyLineDiscountsIfCustomerPriceDefined);
                ApplyLineDiscountsIfCustomerPriceDefined.DataField = "ApplyLineDiscountsIfCustomerPriceDefined";
                ApplyLineDiscountsIfCustomerClassPriceDefined = new CheckBox("ctl00_phF_tab_t1_chkApplyLineDiscountsIfCustomerClassPriceDefined", "Customer Price Class", locator, null);
                ApplyLineDiscountsIfCustomerClassPriceDefinedLabel = new Label(ApplyLineDiscountsIfCustomerClassPriceDefined);
                ApplyLineDiscountsIfCustomerClassPriceDefined.DataField = "ApplyLineDiscountsIfCustomerClassPriceDefined";
                UsrDefAdjustmentType = new DropDown("ctl00_phF_tab_t1_edUsrDefAdjustmentType", "Default Adjustment Type", locator, null);
                UsrDefAdjustmentTypeLabel = new Label(UsrDefAdjustmentType);
                UsrDefAdjustmentType.DataField = "UsrDefAdjustmentType";
                UsrDefAdjustmentType.Items.Add("P", "Price");
                UsrDefAdjustmentType.Items.Add("D", "Discount");
                UsrDefPricingType = new DropDown("ctl00_phF_tab_t1_edUsrDefPricingType", "Default Pricing By", locator, null);
                UsrDefPricingTypeLabel = new Label(UsrDefPricingType);
                UsrDefPricingType.DataField = "UsrDefPricingType";
                UsrDefPricingType.Items.Add("MG", "Margin");
                UsrDefPricingType.Items.Add("MU", "Markup");
                DunningLetterProcessType = new DropDown("ctl00_phF_tab_t3_edDunningLetterProcessType", "Dunning Process", locator, null);
                DunningLetterProcessTypeLabel = new Label(DunningLetterProcessType);
                DunningLetterProcessType.DataField = "DunningLetterProcessType";
                DunningLetterProcessType.Items.Add("0", "By Customer");
                DunningLetterProcessType.Items.Add("1", "By Document");
                AutoReleaseDunningLetter = new CheckBox("ctl00_phF_tab_t3_chkAutoReleaseDunningLetter", "Automatically Release Dunning Letters", locator, null);
                AutoReleaseDunningLetterLabel = new Label(AutoReleaseDunningLetter);
                AutoReleaseDunningLetter.DataField = "AutoReleaseDunningLetter";
                IncludeNonOverdueDunning = new CheckBox("ctl00_phF_tab_t3_chkIncludeNonOverdueDunning", "Include Other Unpaid Documents", locator, null);
                IncludeNonOverdueDunningLabel = new Label(IncludeNonOverdueDunning);
                IncludeNonOverdueDunning.DataField = "IncludeNonOverdueDunning";
                DunningFeeInventoryID = new Selector("ctl00_phF_tab_t3_edDunningFeeInventoryID", "Dunning Fee Item", locator, null);
                DunningFeeInventoryIDLabel = new Label(DunningFeeInventoryID);
                DunningFeeInventoryID.DataField = "DunningFeeInventoryID";
                DunningFeeTermID = new Selector("ctl00_phF_tab_t3_edDunningFeeTermID", "Terms", locator, null);
                DunningFeeTermIDLabel = new Label(DunningFeeTermID);
                DunningFeeTermID.DataField = "DunningFeeTermID";
                AutoReleaseDunningFee = new CheckBox("ctl00_phF_tab_t3_chkAutoReleaseDunningFee", "Automatically Release Dunning Fee Documents", locator, null);
                AutoReleaseDunningFeeLabel = new Label(AutoReleaseDunningFee);
                AutoReleaseDunningFee.DataField = "AutoReleaseDunningFee";
                DataMemberName = "ARSetupRecord";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void BatchNumberingIDEdit()
            {
                Buttons.BatchNumberingIDEdit.Click();
            }
            
            public virtual void InvoiceNumberingIDEdit()
            {
                Buttons.InvoiceNumberingIDEdit.Click();
            }
            
            public virtual void PaymentNumberingIDEdit()
            {
                Buttons.PaymentNumberingIDEdit.Click();
            }
            
            public virtual void DebitAdjNumberingIDEdit()
            {
                Buttons.DebitAdjNumberingIDEdit.Click();
            }
            
            public virtual void CreditAdjNumberingIDEdit()
            {
                Buttons.CreditAdjNumberingIDEdit.Click();
            }
            
            public virtual void WriteOffNumberingIDEdit()
            {
                Buttons.WriteOffNumberingIDEdit.Click();
            }
            
            public virtual void FinChargeNumberingIDEdit()
            {
                Buttons.FinChargeNumberingIDEdit.Click();
            }
            
            public virtual void PriceWSNumberingIDEdit()
            {
                Buttons.PriceWSNumberingIDEdit.Click();
            }
            
            public virtual void DunningFeeNumberingIDEdit()
            {
                Buttons.DunningFeeNumberingIDEdit.Click();
            }
            
            public virtual void DfltCustomerClassIDEdit()
            {
                Buttons.DfltCustomerClassIDEdit.Click();
            }
            
            public virtual void BalanceWriteOffEdit()
            {
                Buttons.BalanceWriteOffEdit.Click();
            }
            
            public virtual void CreditWriteOffEdit()
            {
                Buttons.CreditWriteOffEdit.Click();
            }
            
            public virtual void DefaultRateTypeIDEdit()
            {
                Buttons.DefaultRateTypeIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button BatchNumberingIDEdit { get; }
			public Button InvoiceNumberingIDEdit { get; }
			public Button PaymentNumberingIDEdit { get; }
			public Button DebitAdjNumberingIDEdit { get; }
			public Button CreditAdjNumberingIDEdit { get; }
			public Button WriteOffNumberingIDEdit { get; }
			public Button FinChargeNumberingIDEdit { get; }
			public Button PriceWSNumberingIDEdit { get; }
			public Button DunningFeeNumberingIDEdit { get; }
			public Button DfltCustomerClassIDEdit { get; }
			public Button BalanceWriteOffEdit { get; }
			public Button CreditWriteOffEdit { get; }
			public Button DefaultRateTypeIDEdit { get; }
                
                public PxButtonCollection()
                {
                    BatchNumberingIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edBatchNumberingID\'] div[class=\'editBtnCont\'] > div " +
                            "> div", "BatchNumberingIDEdit", "ctl00_phF_tab");
                    BatchNumberingIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    InvoiceNumberingIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edInvoiceNumberingID\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "InvoiceNumberingIDEdit", "ctl00_phF_tab");
                    InvoiceNumberingIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PaymentNumberingIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edPaymentNumberingID\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "PaymentNumberingIDEdit", "ctl00_phF_tab");
                    PaymentNumberingIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DebitAdjNumberingIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edDebitAdjNumberingID\'] div[class=\'editBtnCont\'] > d" +
                            "iv > div", "DebitAdjNumberingIDEdit", "ctl00_phF_tab");
                    DebitAdjNumberingIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    CreditAdjNumberingIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edCreditAdjNumberingID\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "CreditAdjNumberingIDEdit", "ctl00_phF_tab");
                    CreditAdjNumberingIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    WriteOffNumberingIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edWriteOffNumberingID\'] div[class=\'editBtnCont\'] > d" +
                            "iv > div", "WriteOffNumberingIDEdit", "ctl00_phF_tab");
                    WriteOffNumberingIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    FinChargeNumberingIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edFinChargeNumberingID\'] div[class=\'editBtnCont\'] > " +
                            "div > div", "FinChargeNumberingIDEdit", "ctl00_phF_tab");
                    FinChargeNumberingIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    PriceWSNumberingIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edPriceWSNumberingID\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "PriceWSNumberingIDEdit", "ctl00_phF_tab");
                    PriceWSNumberingIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DunningFeeNumberingIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edDunningNumberingID\'] div[class=\'editBtnCont\'] > di" +
                            "v > div", "DunningFeeNumberingIDEdit", "ctl00_phF_tab");
                    DunningFeeNumberingIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DfltCustomerClassIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_edDfltCustomerClassID\'] div[class=\'editBtnCont\'] > d" +
                            "iv > div", "DfltCustomerClassIDEdit", "ctl00_phF_tab");
                    DfltCustomerClassIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    BalanceWriteOffEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_PXSelector1\'] div[class=\'editBtnCont\'] > div > div", "BalanceWriteOffEdit", "ctl00_phF_tab");
                    BalanceWriteOffEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    CreditWriteOffEdit = new Button("css=div[id=\'ctl00_phF_tab_t0_PXSelector2\'] div[class=\'editBtnCont\'] > div > div", "CreditWriteOffEdit", "ctl00_phF_tab");
                    CreditWriteOffEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                    DefaultRateTypeIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t1_edDefaultRateTypeID\'] div[class=\'editBtnCont\'] > div" +
                            " > div", "DefaultRateTypeIDEdit", "ctl00_phF_tab");
                    DefaultRateTypeIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
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
        
        public class c_notifications_gridns : Grid<c_notifications_gridns.c_grid_row, c_notifications_gridns.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_notifications_gridns(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phF_tab_t4_sp1_gridNS");
                DataMemberName = "Notifications";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phF_tab_t4_sp1_gridNS_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNS_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t4_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phF_tab_t4_sp1_gridNS");
                    ContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Active { get; }
			public PXTextEdit NotificationCD { get; }
			public Selector NBranchID { get; }
			public Selector EMailAccountID { get; }
			public Selector DefaultPrinterID { get; }
			public Selector ReportID { get; }
			public Selector NotificationID { get; }
			public DropDown Format { get; }
			public DropDown RecipientsBehavior { get; }
			public PXTextEdit SetupID { get; }
			public PXTextEdit Module { get; }
			public PXTextEdit SourceCD { get; }
                
                public c_grid_row(c_notifications_gridns grid) : 
                        base(grid)
                {
                    Active = new CheckBox("_ctl00_phF_tab_t4_sp1_gridNS_lv0_chkActive", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    NotificationCD = new PXTextEdit("_ctl00_phF_tab_t4_sp1_gridNS_lv0_edNotificationCD", "Mailing ID", grid.Locator, "NotificationCD");
                    NotificationCD.DataField = "NotificationCD";
                    NBranchID = new Selector("_ctl00_phF_tab_t4_sp1_gridNS_lv0_edNBranchID", "Branch", grid.Locator, "NBranchID");
                    NBranchID.DataField = "NBranchID";
                    EMailAccountID = new Selector("_ctl00_phF_tab_t4_sp1_gridNS_lv0_edEMailAccount", "Default Email Account", grid.Locator, "EMailAccountID");
                    EMailAccountID.DataField = "EMailAccountID";
                    DefaultPrinterID = new Selector("_ctl00_phF_tab_t4_sp1_gridNS_lv0_edDefPrinterID", "Default Printer", grid.Locator, "DefaultPrinterID");
                    DefaultPrinterID.DataField = "DefaultPrinterID";
                    ReportID = new Selector("_ctl00_phF_tab_t4_sp1_gridNS_lv0_edReportID", "Report", grid.Locator, "ReportID");
                    ReportID.DataField = "ReportID";
                    NotificationID = new Selector("_ctl00_phF_tab_t4_sp1_gridNS_lv0_edNotificationID", "Notification Template", grid.Locator, "NotificationID");
                    NotificationID.DataField = "NotificationID";
                    Format = new DropDown("_ctl00_phF_tab_t4_sp1_gridNS_lv0_edFormat", "Format", grid.Locator, "Format");
                    Format.DataField = "Format";
                    Format.Items.Add("H", "Html");
                    Format.Items.Add("E", "Excel");
                    Format.Items.Add("P", "PDF");
                    RecipientsBehavior = new DropDown("_ctl00_phF_tab_t4_sp1_gridNS_lv0_ec", "Recipients", grid.Locator, "RecipientsBehavior");
                    RecipientsBehavior.DataField = "RecipientsBehavior";
                    RecipientsBehavior.Items.Add("O", "Override Recipients");
                    RecipientsBehavior.Items.Add("A", "Add Recipients");
                    SetupID = new PXTextEdit("ctl00_phF_tab_t4_sp1_gridNS_ei", "SetupID", grid.Locator, "SetupID");
                    SetupID.DataField = "SetupID";
                    Module = new PXTextEdit("ctl00_phF_tab_t4_sp1_gridNS_ei", "Module", grid.Locator, "Module");
                    Module.DataField = "Module";
                    SourceCD = new PXTextEdit("ctl00_phF_tab_t4_sp1_gridNS_ei", "SourceCD", grid.Locator, "SourceCD");
                    SourceCD.DataField = "SourceCD";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Active { get; }
				public PXTextEditColumnFilter NotificationCD { get; }
				public SelectorColumnFilter NBranchID { get; }
				public SelectorColumnFilter EMailAccountID { get; }
				public SelectorColumnFilter DefaultPrinterID { get; }
				public SelectorColumnFilter ReportID { get; }
				public SelectorColumnFilter NotificationID { get; }
				public DropDownColumnFilter Format { get; }
				public DropDownColumnFilter RecipientsBehavior { get; }
				public PXTextEditColumnFilter SetupID { get; }
				public PXTextEditColumnFilter Module { get; }
				public PXTextEditColumnFilter SourceCD { get; }
                
                public c_grid_header(c_notifications_gridns grid) : 
                        base(grid)
                {
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    NotificationCD = new PXTextEditColumnFilter(grid.Row.NotificationCD);
                    NBranchID = new SelectorColumnFilter(grid.Row.NBranchID);
                    EMailAccountID = new SelectorColumnFilter(grid.Row.EMailAccountID);
                    DefaultPrinterID = new SelectorColumnFilter(grid.Row.DefaultPrinterID);
                    ReportID = new SelectorColumnFilter(grid.Row.ReportID);
                    NotificationID = new SelectorColumnFilter(grid.Row.NotificationID);
                    Format = new DropDownColumnFilter(grid.Row.Format);
                    RecipientsBehavior = new DropDownColumnFilter(grid.Row.RecipientsBehavior);
                    SetupID = new PXTextEditColumnFilter(grid.Row.SetupID);
                    Module = new PXTextEditColumnFilter(grid.Row.Module);
                    SourceCD = new PXTextEditColumnFilter(grid.Row.SourceCD);
                }
            }
        }
        
        public class c_notifications_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NotificationCD { get; }
			public Label NotificationCDLabel { get; }
			public Selector NotificationID { get; }
			public Label NotificationIDLabel { get; }
			public Selector NBranchID { get; }
			public Label NBranchIDLabel { get; }
			public DropDown Format { get; }
			public Label FormatLabel { get; }
			public CheckBox Active { get; }
			public Label ActiveLabel { get; }
			public Selector DefaultPrinterID { get; }
			public Label DefaultPrinterIDLabel { get; }
			public Selector ReportID { get; }
			public Label ReportIDLabel { get; }
			public Selector EMailAccountID { get; }
			public Label EMailAccountIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_notifications_lv0(string locator, string name) : 
                    base(locator, name)
            {
                NotificationCD = new PXTextEdit("ctl00_phF_tab_t4_sp1_gridNS_lv0_edNotificationCD", "Mailing ID", locator, null);
                NotificationCDLabel = new Label(NotificationCD);
                NotificationCD.DataField = "NotificationCD";
                NotificationID = new Selector("ctl00_phF_tab_t4_sp1_gridNS_lv0_edNotificationID", "Notification Template", locator, null);
                NotificationIDLabel = new Label(NotificationID);
                NotificationID.DataField = "NotificationID";
                NBranchID = new Selector("ctl00_phF_tab_t4_sp1_gridNS_lv0_edNBranchID", "Branch", locator, null);
                NBranchIDLabel = new Label(NBranchID);
                NBranchID.DataField = "NBranchID";
                Format = new DropDown("ctl00_phF_tab_t4_sp1_gridNS_lv0_edFormat", "Format", locator, null);
                FormatLabel = new Label(Format);
                Format.DataField = "Format";
                Format.Items.Add("H", "Html");
                Format.Items.Add("E", "Excel");
                Format.Items.Add("P", "PDF");
                Active = new CheckBox("ctl00_phF_tab_t4_sp1_gridNS_lv0_chkActive", "Active", locator, null);
                ActiveLabel = new Label(Active);
                Active.DataField = "Active";
                DefaultPrinterID = new Selector("ctl00_phF_tab_t4_sp1_gridNS_lv0_edDefPrinterID", "Default Printer", locator, null);
                DefaultPrinterIDLabel = new Label(DefaultPrinterID);
                DefaultPrinterID.DataField = "DefaultPrinterID";
                ReportID = new Selector("ctl00_phF_tab_t4_sp1_gridNS_lv0_edReportID", "Report", locator, null);
                ReportIDLabel = new Label(ReportID);
                ReportID.DataField = "ReportID";
                EMailAccountID = new Selector("ctl00_phF_tab_t4_sp1_gridNS_lv0_edEMailAccount", "Default Email Account", locator, null);
                EMailAccountIDLabel = new Label(EMailAccountID);
                EMailAccountID.DataField = "EMailAccountID";
                Es = new Selector("ctl00_phF_tab_t4_sp1_gridNS_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phF_tab_t4_sp1_gridNS_lv0_ec", "Ec", locator, null);
                DataMemberName = "Notifications";
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
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t4_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phF_tab_t4_sp1_gridNS_lv0");
                    ContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_recipients_gridnr : Grid<c_recipients_gridnr.c_grid_row, c_recipients_gridnr.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_recipients_gridnr(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phF_tab_t4_sp1_gridNR");
                DataMemberName = "Recipients";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phF_tab_t4_sp1_gridNR_fe_gf", "FilterForm");
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phF_tab_t4_sp1_gridNR_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button ContactIDEdit { get; }
                
                public PxButtonCollection()
                {
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t4_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phF_tab_t4_sp1_gridNR");
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
			public PXTextEdit RecipientID { get; }
                
                public c_grid_row(c_recipients_gridnr grid) : 
                        base(grid)
                {
                    Active = new CheckBox("ctl00_phF_tab_t4_sp1_gridNR_ef", "Active", grid.Locator, "Active");
                    Active.DataField = "Active";
                    ContactType = new DropDown("_ctl00_phF_tab_t4_sp1_gridNR_lv0_ec", "Contact Type", grid.Locator, "ContactType");
                    ContactType.DataField = "ContactType";
                    ContactType.Items.Add("P", "Primary");
                    ContactType.Items.Add("B", "Billing");
                    ContactType.Items.Add("S", "Shipping");
                    ContactType.Items.Add("E", "Employee");
                    OriginalContactID = new PXNumberEdit("ctl00_phF_tab_t4_sp1_gridNR_en", "OriginalContactID", grid.Locator, "OriginalContactID");
                    OriginalContactID.DataField = "OriginalContactID";
                    ContactID = new Selector("_ctl00_phF_tab_t4_sp1_gridNR_lv0_edContactID", "Contact ID", grid.Locator, "ContactID");
                    ContactID.DataField = "ContactID";
                    Format = new DropDown("_ctl00_phF_tab_t4_sp1_gridNR_lv0_ec", "Format", grid.Locator, "Format");
                    Format.DataField = "Format";
                    Format.Items.Add("H", "Html");
                    Format.Items.Add("E", "Excel");
                    Format.Items.Add("P", "PDF");
                    AddTo = new DropDown("_ctl00_phF_tab_t4_sp1_gridNR_lv0_ec", "Add To", grid.Locator, "AddTo");
                    AddTo.DataField = "AddTo";
                    AddTo.Items.Add("T", "To");
                    AddTo.Items.Add("C", "Cc");
                    AddTo.Items.Add("B", "Bcc");
                    RecipientID = new PXTextEdit("ctl00_phF_tab_t4_sp1_gridNR_ei", "RecipientID", grid.Locator, "RecipientID");
                    RecipientID.DataField = "RecipientID";
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
				public PXTextEditColumnFilter RecipientID { get; }
                
                public c_grid_header(c_recipients_gridnr grid) : 
                        base(grid)
                {
                    Active = new CheckBoxColumnFilter(grid.Row.Active);
                    ContactType = new DropDownColumnFilter(grid.Row.ContactType);
                    OriginalContactID = new PXNumberEditColumnFilter(grid.Row.OriginalContactID);
                    ContactID = new SelectorColumnFilter(grid.Row.ContactID);
                    Format = new DropDownColumnFilter(grid.Row.Format);
                    AddTo = new DropDownColumnFilter(grid.Row.AddTo);
                    RecipientID = new PXTextEditColumnFilter(grid.Row.RecipientID);
                }
            }
        }
        
        public class c_recipients_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector ContactID { get; }
			public Label ContactIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_recipients_lv0(string locator, string name) : 
                    base(locator, name)
            {
                ContactID = new Selector("ctl00_phF_tab_t4_sp1_gridNR_lv0_edContactID", "Contact ID", locator, null);
                ContactIDLabel = new Label(ContactID);
                ContactID.DataField = "ContactID";
                Es = new Selector("ctl00_phF_tab_t4_sp1_gridNR_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phF_tab_t4_sp1_gridNR_lv0_ec", "Ec", locator, null);
                DataMemberName = "Recipients";
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
                    ContactIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t4_sp1_gridNR_lv0_edContactID\'] div[class=\'editBtnCont\'" +
                            "] > div > div", "ContactIDEdit", "ctl00_phF_tab_t4_sp1_gridNR_lv0");
                    ContactIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
        }
        
        public class c_dunningsetup_gridns : Grid<c_dunningsetup_gridns.c_grid_row, c_dunningsetup_gridns.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_dunningsetup_gridns(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phF_tab_t3_gridNS");
                DataMemberName = "DunningSetup";
                FilterForm = new c_grid_filter("ctl00_phF_tab_t3_gridNS_fe_gf", "FilterForm");
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
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
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
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phF_tab_t3_gridNS_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phF_tab_t3_gridNS_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phF_tab_t3_gridNS_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phF_tab_t3_gridNS_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phF_tab_t3_gridNS_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phF_tab_t3_gridNS_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXNumberEdit DunningLetterLevel { get; }
			public PXNumberEdit DueDays { get; }
			public PXNumberEdit DaysToSettle { get; }
			public PXTextEdit Descr { get; }
			public PXNumberEdit DunningFee { get; }
			public PXTextEdit BaseCuryID { get; }
                
                public c_grid_row(c_dunningsetup_gridns grid) : 
                        base(grid)
                {
                    DunningLetterLevel = new PXNumberEdit("ctl00_phF_tab_t3_gridNS_en", "Dunning Letter Level", grid.Locator, "DunningLetterLevel");
                    DunningLetterLevel.DataField = "DunningLetterLevel";
                    DueDays = new PXNumberEdit("ctl00_phF_tab_t3_gridNS_en", "Days Past Due", grid.Locator, "DueDays");
                    DueDays.DataField = "DueDays";
                    DaysToSettle = new PXNumberEdit("ctl00_phF_tab_t3_gridNS_en", "Days to Settle", grid.Locator, "DaysToSettle");
                    DaysToSettle.DataField = "DaysToSettle";
                    Descr = new PXTextEdit("ctl00_phF_tab_t3_gridNS_ei", "Description", grid.Locator, "Descr");
                    Descr.DataField = "Descr";
                    DunningFee = new PXNumberEdit("ctl00_phF_tab_t3_gridNS_en", "Dunning Fee", grid.Locator, "DunningFee");
                    DunningFee.DataField = "DunningFee";
                    BaseCuryID = new PXTextEdit("ctl00_phF_tab_t3_gridNS_ei", "Base Currency ID", grid.Locator, "BaseCuryID");
                    BaseCuryID.DataField = "BaseCuryID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXNumberEditColumnFilter DunningLetterLevel { get; }
				public PXNumberEditColumnFilter DueDays { get; }
				public PXNumberEditColumnFilter DaysToSettle { get; }
				public PXTextEditColumnFilter Descr { get; }
				public PXNumberEditColumnFilter DunningFee { get; }
				public PXTextEditColumnFilter BaseCuryID { get; }
                
                public c_grid_header(c_dunningsetup_gridns grid) : 
                        base(grid)
                {
                    DunningLetterLevel = new PXNumberEditColumnFilter(grid.Row.DunningLetterLevel);
                    DueDays = new PXNumberEditColumnFilter(grid.Row.DueDays);
                    DaysToSettle = new PXNumberEditColumnFilter(grid.Row.DaysToSettle);
                    Descr = new PXTextEditColumnFilter(grid.Row.Descr);
                    DunningFee = new PXNumberEditColumnFilter(grid.Row.DunningFee);
                    BaseCuryID = new PXTextEditColumnFilter(grid.Row.BaseCuryID);
                }
            }
        }
        
        public class c_setupapproval_gridapproval : Grid<c_setupapproval_gridapproval.c_grid_row, c_setupapproval_gridapproval.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_setupapproval_gridapproval(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phF_tab_t2_gridApproval");
                DataMemberName = "SetupApproval";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_phF_tab_t2_gridApproval_fe_gf", "FilterForm");
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
            
            public virtual void AssignmentNotificationIDEdit()
            {
                Buttons.AssignmentNotificationIDEdit.Click();
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
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_at_tlb div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phF_tab_t2_gridApproval_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AssignmentNotificationIDEdit { get; }
                
                public PxButtonCollection()
                {
                    AssignmentNotificationIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t2_gridApproval_lv0_edAssignmentNotificationID\'] div[cl" +
                            "ass=\'editBtnCont\'] > div > div", "AssignmentNotificationIDEdit", "ctl00_phF_tab_t2_gridApproval");
                    AssignmentNotificationIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox IsActive { get; }
			public DropDown DocType { get; }
			public Selector AssignmentMapID { get; }
			public Selector AssignmentNotificationID { get; }
			public PXNumberEdit ApprovalID { get; }
                
                public c_grid_row(c_setupapproval_gridapproval grid) : 
                        base(grid)
                {
                    IsActive = new CheckBox("_ctl00_phF_tab_t2_gridApproval_lv0_edIsActive", "Active", grid.Locator, "IsActive");
                    IsActive.DataField = "IsActive";
                    DocType = new DropDown("_ctl00_phF_tab_t2_gridApproval_lv0_edDocType", "Type", grid.Locator, "DocType");
                    DocType.DataField = "DocType";
                    DocType.Items.Add("INV", "Invoice");
                    DocType.Items.Add("DRM", "Debit Memo");
                    DocType.Items.Add("CRM", "Credit Memo");
                    DocType.Items.Add("REF", "Customer Refund");
                    DocType.Items.Add("RCS", "Cash Return");
                    AssignmentMapID = new Selector("_ctl00_phF_tab_t2_gridApproval_lv0_edAssignmentMapID", "Approval Map", grid.Locator, "AssignmentMapID");
                    AssignmentMapID.DataField = "AssignmentMapID";
                    AssignmentNotificationID = new Selector("_ctl00_phF_tab_t2_gridApproval_lv0_edAssignmentNotificationID", "Pending Approval Notification", grid.Locator, "AssignmentNotificationID");
                    AssignmentNotificationID.DataField = "AssignmentNotificationID";
                    ApprovalID = new PXNumberEdit("ctl00_phF_tab_t2_gridApproval_en", "ApprovalID", grid.Locator, "ApprovalID");
                    ApprovalID.DataField = "ApprovalID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter IsActive { get; }
				public DropDownColumnFilter DocType { get; }
				public SelectorColumnFilter AssignmentMapID { get; }
				public SelectorColumnFilter AssignmentNotificationID { get; }
				public PXNumberEditColumnFilter ApprovalID { get; }
                
                public c_grid_header(c_setupapproval_gridapproval grid) : 
                        base(grid)
                {
                    IsActive = new CheckBoxColumnFilter(grid.Row.IsActive);
                    DocType = new DropDownColumnFilter(grid.Row.DocType);
                    AssignmentMapID = new SelectorColumnFilter(grid.Row.AssignmentMapID);
                    AssignmentNotificationID = new SelectorColumnFilter(grid.Row.AssignmentNotificationID);
                    ApprovalID = new PXNumberEditColumnFilter(grid.Row.ApprovalID);
                }
            }
        }
        
        public class c_setupapproval_lv0 : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox IsActive { get; }
			public Label IsActiveLabel { get; }
			public DropDown DocType { get; }
			public Label DocTypeLabel { get; }
			public Selector AssignmentMapID { get; }
			public Label AssignmentMapIDLabel { get; }
			public Selector AssignmentNotificationID { get; }
			public Label AssignmentNotificationIDLabel { get; }
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_setupapproval_lv0(string locator, string name) : 
                    base(locator, name)
            {
                IsActive = new CheckBox("ctl00_phF_tab_t2_gridApproval_lv0_edIsActive", "Active", locator, null);
                IsActiveLabel = new Label(IsActive);
                IsActive.DataField = "IsActive";
                DocType = new DropDown("ctl00_phF_tab_t2_gridApproval_lv0_edDocType", "Type", locator, null);
                DocTypeLabel = new Label(DocType);
                DocType.DataField = "DocType";
                DocType.Items.Add("INV", "Invoice");
                DocType.Items.Add("DRM", "Debit Memo");
                DocType.Items.Add("CRM", "Credit Memo");
                DocType.Items.Add("REF", "Customer Refund");
                DocType.Items.Add("RCS", "Cash Return");
                AssignmentMapID = new Selector("ctl00_phF_tab_t2_gridApproval_lv0_edAssignmentMapID", "Approval Map", locator, null);
                AssignmentMapIDLabel = new Label(AssignmentMapID);
                AssignmentMapID.DataField = "AssignmentMapID";
                AssignmentNotificationID = new Selector("ctl00_phF_tab_t2_gridApproval_lv0_edAssignmentNotificationID", "Pending Approval Notification", locator, null);
                AssignmentNotificationIDLabel = new Label(AssignmentNotificationID);
                AssignmentNotificationID.DataField = "AssignmentNotificationID";
                Es = new Selector("ctl00_phF_tab_t2_gridApproval_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "SetupApproval";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void AssignmentNotificationIDEdit()
            {
                Buttons.AssignmentNotificationIDEdit.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button AssignmentNotificationIDEdit { get; }
                
                public PxButtonCollection()
                {
                    AssignmentNotificationIDEdit = new Button("css=div[id=\'ctl00_phF_tab_t2_gridApproval_lv0_edAssignmentNotificationID\'] div[cl" +
                            "ass=\'editBtnCont\'] > div > div", "AssignmentNotificationIDEdit", "ctl00_phF_tab_t2_gridApproval_lv0");
                    AssignmentNotificationIDEdit.WaitAction = Wait.WaitForNewWindowToOpen;
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
