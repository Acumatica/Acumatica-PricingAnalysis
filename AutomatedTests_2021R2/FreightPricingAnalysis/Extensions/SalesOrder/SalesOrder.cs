using GeneratedWrappers.Acumatica;


namespace FreightPrice.Extensions
{
    public class SalesOrder : SO301000_SOOrderEntry
    {
        public c_document_form SOSummary => Document_form;
        public c_transactions_grid SOTransGrid => Transactions_grid;
        public c_currentdocument_formdeliverysettings SOShippingSettings => CurrentDocument_formDeliverySettings;
        public c_currentdocument_formfreightinfo SOTotals => CurrentDocument_formFreightInfo;
        public PxToolBar SOToolBar => ToolBar;
        public c_pricinganalysispreview_grdprofitpreview SOPricingProfitPreviewGrid => PricingAnalysisPreview_grdProfitPreview;
        public c_pricinganalysispreviewheaderfilter_frmlineallocationheader SOPricingProfitPreviewHeader => PricingAnalysisPreviewHeaderFilter_frmLineAllocationHeader;
        public c_profitanalysissettingfilterbydoc_frmpabsettingsbydoc SODocPricingRulerPanel => ProfitAnalysisSettingFilterByDoc_frmPABSettingsByDoc;
        public c_pricinganalysisbreakuplinesbydoc_grdprofitbreakupbydoc SODocPricingRulerPanelGrid => PricingAnalysisBreakupLinesByDoc_grdProfitBreakupByDoc;
        public c_pricinganalysispreviewheaderrecs_grdprofitheaderinfo SOPricingAnalysisSummary => PricingAnalysisPreviewHeaderRecs_grdProfitHeaderInfo;
        public c_profitanalysissettingfilterbyline_frmpabsettingsbyline SOLinePricingRulerPanel => ProfitAnalysisSettingFilterByLine_frmPABSettingsByLine;
        public c_pricinganalysisbreakuplinesbyline_grdprofitbreakupbyline SOLinePricingRulerPanelGrid => PricingAnalysisBreakupLinesByLine_grdProfitBreakupByLine;
        public c_soparamfilter_formcreateshipment SOCreateShipment => Soparamfilter_formcreateshipment;
    }
}
