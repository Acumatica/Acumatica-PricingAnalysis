using PX.Data;
using PX.Data.BQL.Fluent;
using PX.Objects.IN;
using PX.Web.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PX.PricingAnalysis.Ext
{
    public abstract class PricingAnalysisGraph<TGraph, TPrimary> : PXGraphExtension<TGraph>
            where TGraph : PXGraph
            where TPrimary : class, IBqlTable, new()
    {
        public PXSelectExtension<Document> DocumentData;
        public PXSelectExtension<DocumentLine> DocumentLineData;

        protected virtual bool CalcFreightPrices => false;

        #region SmartPanel Styling
        public override void Initialize()
        {
            Page page = HttpContext.Current?.Handler as PXPage;
            if (page != null)
            {
                page.Load += Page_Load;
            }
        }

        private void Page_Load(object sender, EventArgs e)
        {
            Page page = (Page)sender;
            PXStyle rowStyle = new PXStyle();
            rowStyle.BackColor = System.Drawing.Color.FromArgb(232, 252, 255);
            page.Header.StyleSheet.CreateStyleRule(rowStyle, page, ".CssCurentRowStyle");

            PXStyle rowStyleEditing = new PXStyle();
            rowStyleEditing.BackColor = System.Drawing.Color.White;
            page.Header.StyleSheet.CreateStyleRule(rowStyleEditing, page, ".CssCurentRowStyleEditing");

            PXStyle cellStyleEditing = new PXStyle();
            cellStyleEditing.BackColor = System.Drawing.Color.FromArgb(255, 255, 220);
            page.Header.StyleSheet.CreateStyleRule(cellStyleEditing, page, ".CssCurentCellStyleEditing");

            PXStyle cellStyleLastCost = new PXStyle();
            cellStyleLastCost.BackColor = System.Drawing.Color.FromArgb(255, 217, 179);
            page.Header.StyleSheet.CreateStyleRule(cellStyleLastCost, page, ".CssCurentCellStyleLastCost");

            PXStyle cellStyleHeaderCurrent = new PXStyle();
            cellStyleHeaderCurrent.BackColor = System.Drawing.Color.FromArgb(232, 252, 255);
            page.Header.StyleSheet.CreateStyleRule(cellStyleHeaderCurrent, page, ".GridMain.Dash .GridRow.CssStyleHeaderCurrent");

            PXStyle cellStyleHeaderPreview = new PXStyle();
            cellStyleHeaderPreview.BackColor = System.Drawing.Color.FromArgb(255, 255, 220);
            page.Header.StyleSheet.CreateStyleRule(cellStyleHeaderPreview, page, ".GridMain.Dash .GridRow.CssStyleHeaderPreview");

            PX.Web.UI.PXGrid grdProfitHeaderInfo = (PX.Web.UI.PXGrid)ControlHelper.FindControl("grdProfitHeaderInfo", page);
            if (grdProfitHeaderInfo != null)
            {
                grdProfitHeaderInfo.RowDataBound += (object grdHeaderSender, PXGridRowEventArgs erHdb) =>
                {
                    var dataHeader = erHdb.Row.DataItem as PX.PricingAnalysis.Ext.PricingAnalysisPreviewHeaderInfo;

                    erHdb.Row.Cells["CuryProfitTotal"].Style.CssClass = (dataHeader.CuryProfitTotal < 0M) ? "red20" : "green20";

                    erHdb.Row.Cells["HeaderInfoType"].Style.CssClass = (dataHeader.HeaderInfoType == HeaderInfoTypes.Current) ?
                                                                        "CssStyleHeaderCurrent" : "CssStyleHeaderPreview";
                };
            }

            PX.Web.UI.PXGrid grdProfitPreview = (PX.Web.UI.PXGrid)ControlHelper.FindControl("grdProfitPreview", page);
            if (grdProfitPreview != null)
            {
                grdProfitPreview.RowDataBound += (object grdsender, PXGridRowEventArgs erdb) =>
                {
                    var data = erdb.Row.DataItem as PX.PricingAnalysis.Ext.PricingAnalysisPreviewLine;
                    if (data == null) { return; }
                    if (data.LineType == PX.PricingAnalysis.Ext.ProfitLineType.CurrentLineType)
                    {
                        erdb.Row.Style.CssClass = "CssCurentRowStyle";

                        if (data.IsLastCostUsed.GetValueOrDefault(false))
                        {
                            erdb.Row.Cells["CuryExtCostDisplay"].Style.CssClass = "CssCurentCellStyleLastCost";
                        }

                        if (data.MarginPercent.GetValueOrDefault(0) == 0M)
                        {
                            erdb.Row.Cells["MarginPercent"].Style.CssClass = "bad";
                        }

                        if (data.MarkupPercent.GetValueOrDefault(0) == 0M)
                        {
                            erdb.Row.Cells["MarkupPercent"].Style.CssClass = "bad";
                        }
                    }
                    else
                    {
                        erdb.Row.Style.CssClass = "CssCurentRowStyleEditing";

                        //For Specific Column
                        erdb.Row.Cells["CuryUnitPrice"].Style.CssClass = "CssCurentCellStyleEditing";
                        erdb.Row.Cells["CuryDiscAmt"].Style.CssClass = "CssCurentCellStyleEditing";
                        erdb.Row.Cells["CuryLineAmt"].Style.CssClass = "CssCurentCellStyleEditing";
                        erdb.Row.Cells["CuryProfit"].Style.CssClass = "CssCurentCellStyleEditing";
                        erdb.Row.Cells["MarginPercent"].Style.CssClass = (data.MarginPercent.GetValueOrDefault(0) == 0M) ? "bad" : "CssCurentCellStyleEditing";
                        erdb.Row.Cells["MarkupPercent"].Style.CssClass = (data.MarkupPercent.GetValueOrDefault(0) == 0M) ? "bad" : "CssCurentCellStyleEditing";
                    }
                };
            }

            PX.Web.UI.PXGrid grdProfitBreakupByLine = (PX.Web.UI.PXGrid)ControlHelper.FindControl("grdProfitBreakupByLine", page);
            if (grdProfitBreakupByLine != null)
            {
                grdProfitBreakupByLine.RowDataBound += (object grdsender, PXGridRowEventArgs erdb) =>
                {
                    var data = erdb.Row.DataItem as PX.PricingAnalysis.Ext.PricingAnalysisBreakup;
                    if (data == null) { return; }
                    if (data.LineType == PX.PricingAnalysis.Ext.ProfitLineType.CurrentLineType)
                    {
                        erdb.Row.Style.CssClass = "CssCurentRowStyle";
                    }
                    else
                    {
                        erdb.Row.Style.CssClass = "CssCurentRowStyleEditing";
                    }
                };
            }

            PX.Web.UI.PXGrid grdProfitBreakupByDoc = (PX.Web.UI.PXGrid)ControlHelper.FindControl("grdProfitBreakupByDoc", page);
            if (grdProfitBreakupByDoc != null)
            {
                grdProfitBreakupByDoc.RowDataBound += (object grdsender, PXGridRowEventArgs erdb) =>
                {
                    var data = erdb.Row.DataItem as PX.PricingAnalysis.Ext.PricingAnalysisBreakupByDoc;
                    if (data == null) { return; }
                    if (data.LineType == PX.PricingAnalysis.Ext.ProfitLineType.CurrentLineType)
                    {
                        erdb.Row.Style.CssClass = "CssCurentRowStyle";
                    }
                    else
                    {
                        erdb.Row.Style.CssClass = "CssCurentRowStyleEditing";
                    }
                };
            }
        }

        #endregion

        #region DataViews
        public PXFilter<PricingAnalysisPreviewHeader> PricingAnalysisPreviewHeaderFilter;

        [PXCopyPasteHiddenView]
        [PXVirtualDAC]
        public PXSelect<PricingAnalysisPreviewHeaderInfo, Where<True, Equal<True>>,
                    OrderBy<Asc<PricingAnalysisPreviewHeaderInfo.headerInfoID>>> PricingAnalysisPreviewHeaderRecs;

        [PXCopyPasteHiddenView]
        [PXVirtualDAC]
        public PXSelect<PricingAnalysisPreviewLine> PricingAnalysisPreview;

        public PXFilter<ProfitAnalysisByLineSetting> ProfitAnalysisSettingFilterByLine;

        [PXCopyPasteHiddenView]
        [PXVirtualDAC]
        public PXSelect<PricingAnalysisBreakup> PricingAnalysisBreakupLinesByLine;

        public PXFilter<ProfitAnalysisByDocSetting> ProfitAnalysisSettingFilterByDoc;

        [PXCopyPasteHiddenView]
        [PXVirtualDAC]
        public PXSelect<PricingAnalysisBreakupByDoc> PricingAnalysisBreakupLinesByDoc;

        #endregion

        #region ViewDelegates

        public IEnumerable pricingAnalysisPreview()
        {
            IEnumerable<PricingAnalysisPreviewLine> datalist = (IEnumerable<PricingAnalysisPreviewLine>)PricingAnalysisPreview.Cache.Cached;

            if (datalist == null || datalist.Count() <= 0)
            {
                InitializePreviewData();
                datalist = (IEnumerable<PricingAnalysisPreviewLine>)PricingAnalysisPreview.Cache.Cached;
            }

            PricingAnalysisPreview.Cache.IsDirty = false;
            return datalist;
        }

        public IEnumerable pricingAnalysisPreviewHeaderRecs()
        {
            RefreshHeaderTotal();
            PricingAnalysisPreviewHeaderRecs.Cache.IsDirty = false;
            return PricingAnalysisPreviewHeaderRecs.Cache.Cached;
        }

        public IEnumerable pricingAnalysisBreakupLinesByLine()
        {
            IEnumerable<PricingAnalysisBreakup> datalist = (IEnumerable<PricingAnalysisBreakup>)PricingAnalysisBreakupLinesByLine.Cache.Cached;

            if (datalist == null || datalist.Count() <= 0)
            {
                PopulateBreaupLines();
                datalist = (IEnumerable<PricingAnalysisBreakup>)PricingAnalysisBreakupLinesByLine.Cache.Cached;
            }

            PricingAnalysisBreakupLinesByLine.Cache.IsDirty = false;
            return datalist;
        }

        public IEnumerable profitAnalysisSettingFilterByLine()
        {
            ProfitAnalysisByLineSetting settings = ProfitAnalysisSettingFilterByLine.Current;
            if (PricingAnalysisPreview.Current?.IsFreightLine ?? false)
            {
                settings.InventoryIDDisplay = Messages.FreightLineText;
                settings.InventoryDescription = Messages.FreightLineDescription;
            }
            else
            {
                var inventoryItem = InventoryItem.PK.Find(Base, PricingAnalysisPreview.Current?.InventoryID);
                if (inventoryItem != null)
                {
                    settings.InventoryID = inventoryItem?.InventoryID;
                    settings.InventoryIDDisplay = inventoryItem?.InventoryCD;
                    settings.InventoryDescription = inventoryItem?.Descr;
                }
            }

            ProfitAnalysisSettingFilterByLine.UpdateCurrent();

            ProfitAnalysisSettingFilterByLine.Cache.IsDirty = false;
            return ProfitAnalysisSettingFilterByLine.Cache.Cached;
        }

        public IEnumerable pricingAnalysisBreakupLinesByDoc()
        {
            IEnumerable<PricingAnalysisBreakupByDoc> datalist = (IEnumerable<PricingAnalysisBreakupByDoc>)PricingAnalysisBreakupLinesByDoc.Cache.Cached;

            if (datalist == null || datalist.Count() <= 0)
            {
                PopulateBreaupLinesForDoc();
                datalist = (IEnumerable<PricingAnalysisBreakupByDoc>)PricingAnalysisBreakupLinesByDoc.Cache.Cached;
            }

            PricingAnalysisBreakupLinesByDoc.Cache.IsDirty = false;
            return datalist;
        }

        #endregion

        #region helper methods
        public virtual void InitializePreviewData()
        {
            int iRecordCounter = 0;

            foreach (DocumentLine orgLine in DocumentLineData.Select())
            {
                if (!orgLine.IsStockItem.GetValueOrDefault(false) || orgLine.OrderQty.GetValueOrDefault(0) <= 0) { continue; }

                var inventoryItem = InventoryItem.PK.Find(Base, orgLine.InventoryID);

                PricingAnalysisPreviewLine line = new PricingAnalysisPreviewLine()
                {
                    RecordID = iRecordCounter++,
                    LineNbr = orgLine.LineNbr,
                    LineType = ProfitLineType.CurrentLineType,
                    InventoryID = orgLine.InventoryID,
                    InventoryIDDisplay = inventoryItem.InventoryCD,
                    InventoryDescription = inventoryItem.Descr,
                    IsLastCostUsed = orgLine.IsLastCostUsed,
                    UOM = orgLine.UOM,
                    OrderQty = orgLine.OrderQty,
                    OrderQtyDisplay = orgLine.OrderQty,
                    CuryDiscAmt = orgLine.CuryDiscAmt,
                    CuryUnitPrice = orgLine.CuryUnitPrice,
                    CuryExtCost = orgLine.CuryExtCost,
                    CuryExtCostDisplay = orgLine.CuryExtCost,
                    CuryLineAmt = orgLine.CuryLineAmt,
                    CuryProfit = orgLine.CuryLineAmt - orgLine.CuryExtCost,
                    MarkupPercent = PXPriceCostAttribute.Round((decimal)((orgLine.CuryExtCost != 0) ? ((orgLine.CuryLineAmt - orgLine.CuryExtCost) / orgLine.CuryExtCost) * 100 : 0m)),
                    MarginPercent = PXPriceCostAttribute.Round((decimal)((orgLine.CuryLineAmt != 0) ? ((orgLine.CuryLineAmt - orgLine.CuryExtCost) / orgLine.CuryLineAmt) * 100 : 0m))
                };
                //if (line.CuryExtCost.GetValueOrDefault(0) <= 0m) { line.MarkupPercent = null; }
                line = PricingAnalysisPreview.Insert(line);
                PricingAnalysisPreview.Cache.SetStatus(line, PXEntryStatus.Held);
                PricingAnalysisPreviewLine prvLine = PXCache<PricingAnalysisPreviewLine>.CreateCopy(line);
                prvLine.RecordID = iRecordCounter++;
                prvLine.LineType = ProfitLineType.PreviewLineType;
                prvLine.InventoryIDDisplay = null;
                prvLine.InventoryDescription = null;
                prvLine.OrderQtyDisplay = null;
                prvLine.UOM = null;
                prvLine.CuryExtCostDisplay = null;
                prvLine = PricingAnalysisPreview.Insert(prvLine);
                PricingAnalysisPreview.Cache.SetStatus(prvLine, PXEntryStatus.Held);
            }

            InitializeFreightPreviewData(iRecordCounter);
        }

        protected virtual void InitializeFreightPreviewData(int currentRecordCounter)
        {
            if (!CalcFreightPrices) { return; }

            Document freightDetail = DocumentData.Current;
            if (freightDetail == null) { return; }

            PricingAnalysisPreviewLine record = new PricingAnalysisPreviewLine()
            {
                RecordID = currentRecordCounter++,
                LineType = ProfitLineType.CurrentLineType,
                InventoryIDDisplay = Messages.FreightLineText,
                InventoryDescription = Messages.FreightLineDescription,
                IsFreightLine = true,
                UOM = "EA",
                OrderQty = 1,
                OrderQtyDisplay = 1,
                CuryDiscAmt = 0,
                CuryUnitPrice = freightDetail.CuryFreightTot,
                CuryExtCost = freightDetail.CuryFreightCost,
                CuryExtCostDisplay = freightDetail.CuryFreightCost,
                CuryLineAmt = freightDetail.CuryFreightTot,
                CuryProfit = freightDetail.CuryFreightTot - freightDetail.CuryFreightCost,
                MarkupPercent = PXPriceCostAttribute.Round((decimal)((freightDetail.CuryFreightCost != 0) ? ((freightDetail.CuryFreightTot - freightDetail.CuryFreightCost) / freightDetail.CuryFreightCost) * 100 : 0m)),
                MarginPercent = PXPriceCostAttribute.Round((decimal)((freightDetail.CuryFreightTot != 0) ? ((freightDetail.CuryFreightTot - freightDetail.CuryFreightCost) / freightDetail.CuryFreightTot) * 100 : 0m))
            };

            record = PricingAnalysisPreview.Insert(record);
            PricingAnalysisPreview.Cache.SetStatus(record, PXEntryStatus.Held);

            if (!freightDetail.OverrideFreightAmount.GetValueOrDefault(false))
            {
                return;
            }

            PricingAnalysisPreviewLine recordPrvLine = PXCache<PricingAnalysisPreviewLine>.CreateCopy(record);
            recordPrvLine.RecordID = currentRecordCounter++;
            recordPrvLine.LineType = ProfitLineType.PreviewLineType;
            recordPrvLine.IsFreightLine = true;
            recordPrvLine.InventoryIDDisplay = null;
            recordPrvLine.InventoryDescription = null;
            recordPrvLine.OrderQtyDisplay = null;
            recordPrvLine.UOM = null;
            recordPrvLine.CuryExtCostDisplay = null;

            recordPrvLine = PricingAnalysisPreview.Insert(recordPrvLine);
            PricingAnalysisPreview.Cache.SetStatus(recordPrvLine, PXEntryStatus.Held);
        }

        public virtual void RefreshHeaderTotal()
        {
            PricingAnalysisPreviewHeader header = PricingAnalysisPreviewHeaderFilter.Current;

            if (header == null) return;

            decimal? cprofitTotal = 0;
            decimal? ccostTotal = 0;
            decimal? camountTotal = 0;
            decimal? profitTotal = 0;
            decimal? costTotal = 0;
            decimal? amountTotal = 0;

            foreach (PricingAnalysisPreviewLine data in PricingAnalysisPreview.Select())
            {
                if (data.LineType == ProfitLineType.PreviewLineType)
                {
                    profitTotal += data.CuryProfit ?? Decimal.Zero;
                    costTotal += data.CuryExtCost ?? Decimal.Zero;
                    amountTotal += data.CuryLineAmt ?? Decimal.Zero;
                }
                else if (data.LineType == ProfitLineType.CurrentLineType)
                {
                    cprofitTotal += data.CuryProfit ?? Decimal.Zero;
                    ccostTotal += data.CuryExtCost ?? Decimal.Zero;
                    camountTotal += data.CuryLineAmt ?? Decimal.Zero;
                }
            }

            header.CuryProfitTotalCurrent = cprofitTotal;
            header.CuryExtCostTotalCurrent = ccostTotal;
            header.CuryAmountTotalCurrent = camountTotal;
            header.MarkupPercentCurrent = (ccostTotal.GetValueOrDefault(0) > 0) ? (cprofitTotal / ccostTotal) * 100 : null;
            header.MarginPercentCurrent = (camountTotal.GetValueOrDefault(0) > 0) ? (cprofitTotal / camountTotal) * 100 : null;

            header.CuryProfitTotal = profitTotal;
            header.CuryExtCostTotal = costTotal;
            header.CuryAmountTotal = amountTotal;
            header.MarkupPercentPreview = (costTotal.GetValueOrDefault(0) > 0) ? (profitTotal / costTotal) * 100 : null;
            header.MarginPercentPreview = (amountTotal.GetValueOrDefault(0) > 0) ? (profitTotal / amountTotal) * 100 : null;
            PricingAnalysisPreviewHeaderFilter.Update(header);

            //Grid View for Header
            PricingAnalysisPreviewHeaderRecs.Cache.Clear();

            var currentHeaderLine = new PricingAnalysisPreviewHeaderInfo()
            {
                HeaderInfoID = 1,
                HeaderInfoType = HeaderInfoTypes.Current,
                CuryAmountTotal = camountTotal,
                CuryExtCostTotal = ccostTotal,
                CuryProfitTotal = cprofitTotal,
                MarkupPercent = (ccostTotal.GetValueOrDefault(0) > 0) ? (cprofitTotal / ccostTotal) * 100 : null,
                MarginPercent = (camountTotal.GetValueOrDefault(0) > 0) ? (cprofitTotal / camountTotal) * 100 : null
            };
            PricingAnalysisPreviewHeaderRecs.Insert(currentHeaderLine);
            PricingAnalysisPreviewHeaderRecs.Cache.SetStatus(currentHeaderLine, PXEntryStatus.Held);

            var previewHeaderLine = new PricingAnalysisPreviewHeaderInfo()
            {
                HeaderInfoID = 2,
                HeaderInfoType = HeaderInfoTypes.Preview,
                CuryAmountTotal = amountTotal,
                CuryExtCostTotal = costTotal,
                CuryProfitTotal = profitTotal,
                MarkupPercent = (costTotal.GetValueOrDefault(0) > 0) ? (profitTotal / costTotal) * 100 : null,
                MarginPercent = (amountTotal.GetValueOrDefault(0) > 0) ? (profitTotal / amountTotal) * 100 : null
            };
            PricingAnalysisPreviewHeaderRecs.Insert(previewHeaderLine);
            PricingAnalysisPreviewHeaderRecs.Cache.SetStatus(previewHeaderLine, PXEntryStatus.Held);
        }

        public virtual void PopulateBreaupLines()
        {
            PricingAnalysisBreakupLinesByLine.Cache.Clear();
            PricingAnalysisBreakupLinesByLine.Cache.ClearQueryCache();

            PricingAnalysisPreviewHeader headerFilter = PricingAnalysisPreviewHeaderFilter.Current;

            PricingAnalysisPreviewLine orgLine = PricingAnalysisPreview.Current;
            ProfitAnalysisByLineSetting settings = ProfitAnalysisSettingFilterByLine.Current;

            List<PricingAnalysisPreviewLine> prvLines = PricingAnalysisPreview.Select().RowCast<PricingAnalysisPreviewLine>().ToList();
            PricingAnalysisPreviewLine cPrvLine = prvLines.Where(x => x.LineNbr == orgLine.LineNbr && x.LineType == ProfitLineType.CurrentLineType).FirstOrDefault();

            if (cPrvLine == null) { return; }

            decimal iStart = settings.StartValue.GetValueOrDefault(10);
            int iCounter = settings.IncrementValue.GetValueOrDefault(2);
            int iRecordCounter = 2;
            PricingAnalysisBreakup cline = PopulateCurrentBreakupLine(cPrvLine, settings);
            cline = PricingAnalysisBreakupLinesByLine.Insert(cline);
            PricingAnalysisBreakupLinesByLine.Cache.SetStatus(cline, PXEntryStatus.Held);
            for (decimal i = iStart; i <= 100; i += iCounter)
            {
                if (settings.BreakupBy == BreakupBy.Markup)
                {
                    PricingAnalysisBreakup line = new PricingAnalysisBreakup()
                    {
                        RecordID = iRecordCounter++,
                        LineNbr = orgLine.LineNbr,
                        LineType = ProfitLineType.PreviewLineType,
                        OrderQty = orgLine.OrderQty,
                        CuryExtCost = orgLine.CuryExtCost,
                        CuryUnitPrice = orgLine.CuryUnitPrice,
                        CuryDiscAmt = orgLine.CuryDiscAmt,
                        MarkupPercent = i,
                        CuryProfit = PXPriceCostAttribute.Round((decimal)((i * orgLine.CuryExtCost) / 100)),
                        CuryExtPrice = PXPriceCostAttribute.Round((decimal)(orgLine.CuryExtCost + (i * orgLine.CuryExtCost) / 100))
                    };
                    if (headerFilter?.ApplyAdjustmentAs == AdjustmentType.Discount && !orgLine.IsFreightLine.GetValueOrDefault(false))
                    {
                        line.CuryDiscAmt = PXPriceCostAttribute.Round((decimal)((orgLine.OrderQty * orgLine.CuryUnitPrice) - line.CuryExtPrice));
                    }
                    else
                    {
                        line.CuryUnitPrice = PXPriceCostAttribute.Round((decimal)(line.CuryExtPrice / line.OrderQty));
                    }
                    line = PricingAnalysisBreakupLinesByLine.Insert(line);
                    PricingAnalysisBreakupLinesByLine.Cache.SetStatus(line, PXEntryStatus.Held);
                }
                else if (settings.BreakupBy == BreakupBy.Margin)
                {
                    decimal iMargin = (i == 100) ? 99 : i;
                    PricingAnalysisBreakup line = new PricingAnalysisBreakup()
                    {
                        RecordID = iRecordCounter++,
                        LineNbr = orgLine.LineNbr,
                        LineType = ProfitLineType.PreviewLineType,
                        OrderQty = orgLine.OrderQty,
                        CuryExtCost = orgLine.CuryExtCost,
                        CuryUnitPrice = orgLine.CuryUnitPrice,
                        CuryDiscAmt = orgLine.CuryDiscAmt,
                        MarginPercent = iMargin,
                        CuryExtPrice = PXPriceCostAttribute.Round((decimal)(orgLine.CuryExtCost / (1 - (iMargin / 100)))),
                        CuryProfit = PXPriceCostAttribute.Round((decimal)((orgLine.CuryExtCost / (1 - (iMargin / 100))) - orgLine.CuryExtCost)),
                    };
                    if (headerFilter?.ApplyAdjustmentAs == AdjustmentType.Discount && !orgLine.IsFreightLine.GetValueOrDefault(false))
                    {
                        line.CuryDiscAmt = PXPriceCostAttribute.Round((decimal)((orgLine.OrderQty * orgLine.CuryUnitPrice) - line.CuryExtPrice));
                    }
                    else
                    {
                        line.CuryUnitPrice = PXPriceCostAttribute.Round((decimal)(line.CuryExtPrice / line.OrderQty));
                    }
                    line = PricingAnalysisBreakupLinesByLine.Insert(line);
                    PricingAnalysisBreakupLinesByLine.Cache.SetStatus(line, PXEntryStatus.Held);
                }
            }
        }

        public virtual PricingAnalysisBreakup PopulateCurrentBreakupLine(PricingAnalysisPreviewLine cPrvLine, ProfitAnalysisByLineSetting settings)
        {
            PricingAnalysisBreakup line = null;
            if (settings.BreakupBy == BreakupBy.Markup)
            {
                line = new PricingAnalysisBreakup()
                {
                    RecordID = 1,
                    LineNbr = cPrvLine.LineNbr,
                    LineType = ProfitLineType.CurrentLineType,
                    OrderQty = cPrvLine.OrderQty,
                    CuryUnitPrice = cPrvLine.CuryUnitPrice,
                    CuryDiscAmt = cPrvLine.CuryDiscAmt,
                    CuryExtCost = cPrvLine.CuryExtCost,
                    MarkupPercent = cPrvLine.MarkupPercent,
                    CuryProfit = cPrvLine.CuryProfit,
                    CuryExtPrice = cPrvLine.CuryLineAmt
                };
            }
            else if (settings.BreakupBy == BreakupBy.Margin)
            {
                line = new PricingAnalysisBreakup()
                {
                    RecordID = 1,
                    LineNbr = cPrvLine.LineNbr,
                    LineType = ProfitLineType.CurrentLineType,
                    OrderQty = cPrvLine.OrderQty,
                    CuryUnitPrice = cPrvLine.CuryUnitPrice,
                    CuryDiscAmt = cPrvLine.CuryDiscAmt,
                    CuryExtCost = cPrvLine.CuryExtCost,
                    MarginPercent = cPrvLine.MarginPercent,
                    CuryExtPrice = cPrvLine.CuryLineAmt,
                    CuryProfit = cPrvLine.CuryProfit,
                };
            }
            return line;
        }

        public virtual void PopulateBreaupLinesForDoc()
        {
            PricingAnalysisBreakupLinesByDoc.Cache.Clear();
            PricingAnalysisBreakupLinesByDoc.Cache.ClearQueryCache();

            ProfitAnalysisByDocSetting settings = ProfitAnalysisSettingFilterByDoc.Current;

            decimal iStart = settings.StartValue.GetValueOrDefault(10);
            int iCounter = settings.IncrementValue.GetValueOrDefault(2);
            int iRecordCounter = 2;

            PricingAnalysisPreviewHeader prvSettings = PricingAnalysisPreviewHeaderFilter.Current;

            PricingAnalysisBreakupByDoc cline = PopulateCurrentBreakupLineForDoc(prvSettings, settings);
            cline = PricingAnalysisBreakupLinesByDoc.Insert(cline);
            PricingAnalysisBreakupLinesByDoc.Cache.SetStatus(cline, PXEntryStatus.Held);

            for (decimal i = iStart; i <= 100; i += iCounter)
            {
                if (settings.BreakupBy == BreakupBy.Markup)
                {
                    PricingAnalysisBreakupByDoc line = new PricingAnalysisBreakupByDoc()
                    {
                        RecordID = iRecordCounter++,
                        LineType = ProfitLineType.PreviewLineType,
                        CuryExtCost = prvSettings.CuryExtCostTotal,
                        MarkupPercent = i,
                        CuryProfit = PXPriceCostAttribute.Round((decimal)((i * prvSettings.CuryExtCostTotal) / 100)),
                        CuryExtPrice = PXPriceCostAttribute.Round((decimal)(prvSettings.CuryExtCostTotal + (i * prvSettings.CuryExtCostTotal) / 100))
                    };
                    line = PricingAnalysisBreakupLinesByDoc.Insert(line);
                    PricingAnalysisBreakupLinesByDoc.Cache.SetStatus(line, PXEntryStatus.Held);
                }
                else if (settings.BreakupBy == BreakupBy.Margin)
                {
                    decimal iMargin = (i == 100) ? 99 : i;
                    PricingAnalysisBreakupByDoc line = new PricingAnalysisBreakupByDoc()
                    {
                        RecordID = iRecordCounter++,
                        LineType = ProfitLineType.PreviewLineType,
                        CuryExtCost = prvSettings.CuryExtCostTotal,
                        MarginPercent = iMargin,
                        CuryExtPrice = PXPriceCostAttribute.Round((decimal)(prvSettings.CuryExtCostTotal / (1 - (iMargin / 100)))),
                        CuryProfit = PXPriceCostAttribute.Round((decimal)((prvSettings.CuryExtCostTotal / (1 - (iMargin / 100))) - prvSettings.CuryExtCostTotal)),
                    };
                    line = PricingAnalysisBreakupLinesByDoc.Insert(line);
                    PricingAnalysisBreakupLinesByDoc.Cache.SetStatus(line, PXEntryStatus.Held);
                }
            }
        }

        public virtual PricingAnalysisBreakupByDoc PopulateCurrentBreakupLineForDoc(PricingAnalysisPreviewHeader totals, ProfitAnalysisByDocSetting settings)
        {
            PricingAnalysisBreakupByDoc line = null;
            if (settings.BreakupBy == BreakupBy.Markup)
            {
                line = new PricingAnalysisBreakupByDoc()
                {
                    RecordID = 1,
                    LineType = ProfitLineType.CurrentLineType,
                    CuryExtCost = totals.CuryExtCostTotalCurrent,
                    MarkupPercent = PXPriceCostAttribute.Round((decimal)((totals.CuryExtCostTotalCurrent.GetValueOrDefault(0) > 0) ? ((totals.CuryAmountTotalCurrent - totals.CuryExtCostTotalCurrent) / totals.CuryExtCostTotalCurrent) * 100 : 0)),
                    CuryProfit = totals.CuryProfitTotalCurrent,
                    CuryExtPrice = totals.CuryAmountTotalCurrent
                };
            }
            else if (settings.BreakupBy == BreakupBy.Margin)
            {
                line = new PricingAnalysisBreakupByDoc()
                {
                    RecordID = 1,
                    LineType = ProfitLineType.CurrentLineType,
                    CuryExtCost = totals.CuryExtCostTotalCurrent,
                    MarginPercent = PXPriceCostAttribute.Round((decimal)((totals.CuryAmountTotalCurrent != 0) ? ((totals.CuryAmountTotalCurrent - totals.CuryExtCostTotalCurrent) / totals.CuryAmountTotalCurrent) * 100 : 0m)),
                    CuryProfit = totals.CuryProfitTotalCurrent,
                    CuryExtPrice = totals.CuryAmountTotalCurrent,
                };
            }
            return line;
        }

        #endregion

        #region Event Handlers
        public void _(Events.FieldUpdated<PricingAnalysisPreviewHeader, PricingAnalysisPreviewHeader.applyAdjustmentAs> e)
        {
            var currentHeaderRecs = e.Row;
            if (!(currentHeaderRecs?.CuryAmountTotal == currentHeaderRecs?.CuryAmountTotalCurrent &&
                  currentHeaderRecs?.CuryProfitTotal == currentHeaderRecs?.CuryProfitTotalCurrent &&
                  currentHeaderRecs?.MarginPercentCurrent == currentHeaderRecs?.MarginPercentPreview &&
                  currentHeaderRecs?.MarkupPercentCurrent == currentHeaderRecs?.MarkupPercentPreview) &&
                  e.NewValue != e.OldValue)
            {
                PricingAnalysisPreview.Cache.Clear();
                PricingAnalysisPreview.Cache.ClearQueryCache();
            }
        }

        public void _(Events.FieldVerifying<PricingAnalysisPreviewLine.marginPercent> e)
        {
            if (!e.ExternalCall) { return; }
            PricingAnalysisPreviewLine data = (PricingAnalysisPreviewLine)e.Row;
            PXCache sender = e.Cache;
            if (data == null || sender == null || e.NewValue == null) { return; }
            if (Convert.ToDecimal(e.NewValue) >= 100M)
            {
                throw new PXSetPropertyException(Messages.InvalidMargin, PXErrorLevel.Error);
            }
        }

        public void _(Events.RowUpdated<PricingAnalysisPreviewLine> e)
        {
            if (e.Row == null || e.OldRow == null) { return; }
            PXCache sender = e.Cache;

            PricingAnalysisPreviewHeader previewHeader = PricingAnalysisPreviewHeaderFilter.Current;

            PricingAnalysisPreviewLine row = (PricingAnalysisPreviewLine)e.Row;
            PricingAnalysisPreviewLine oldrow = (PricingAnalysisPreviewLine)e.OldRow;

            PricingAnalysisPreviewLine currentLine = e.Cache.Cached.OfType<PricingAnalysisPreviewLine>().ToList().Where(x => x.LineNbr == row.LineNbr && x.LineType == ProfitLineType.CurrentLineType).FirstOrDefault();
            //Unit Price is changed
            if (!sender.ObjectsEqual<PricingAnalysisPreviewLine.curyUnitPrice>(row, oldrow))
            {
                row.CuryLineAmt = PXPriceCostAttribute.Round((decimal)((row.CuryUnitPrice * row.OrderQty) - row.CuryDiscAmt));
                row.CuryProfit = PXPriceCostAttribute.Round((decimal)(row.CuryLineAmt - row.CuryExtCost));
                row.MarkupPercent = PXPriceCostAttribute.Round((decimal)((row.CuryExtCost.GetValueOrDefault(0) > 0) ? ((row.CuryLineAmt - row.CuryExtCost) / row.CuryExtCost) * 100 : 0));
                row.MarginPercent = PXPriceCostAttribute.Round((decimal)((row.CuryLineAmt.GetValueOrDefault(0) > 0) ? ((row.CuryLineAmt - row.CuryExtCost) / row.CuryLineAmt) * 100 : 0));
            }
            //Discount is changed
            else if (!sender.ObjectsEqual<PricingAnalysisPreviewLine.curyDiscAmt>(row, oldrow) && !row.IsFreightLine.GetValueOrDefault(false))
            {
                row.CuryLineAmt = PXPriceCostAttribute.Round((decimal)((row.CuryUnitPrice * row.OrderQty) - row.CuryDiscAmt));
                row.CuryProfit = PXPriceCostAttribute.Round((decimal)(row.CuryLineAmt - row.CuryExtCost));
                row.MarkupPercent = PXPriceCostAttribute.Round((decimal)((row.CuryExtCost.GetValueOrDefault(0) > 0) ? ((row.CuryLineAmt - row.CuryExtCost) / row.CuryExtCost) * 100 : 0));
                row.MarginPercent = PXPriceCostAttribute.Round((decimal)((row.CuryLineAmt.GetValueOrDefault(0) > 0) ? ((row.CuryLineAmt - row.CuryExtCost) / row.CuryLineAmt) * 100 : 0));
                //row.CuryUnitPrice = PXPriceCostAttribute.Round((decimal)(((currentLine.OrderQty * currentLine.CuryUnitPrice * row.CuryLineAmt) / currentLine.CuryLineAmt) / row.OrderQty));
            }
            //Selling Price is changed
            else if (!sender.ObjectsEqual<PricingAnalysisPreviewLine.curyLineAmt>(row, oldrow))
            {
                //Math.Round(value, CommonSetupDecPl.PrcCst, MidpointRounding.AwayFromZero)
                row.CuryProfit = PXPriceCostAttribute.Round((decimal)(row.CuryLineAmt - row.CuryExtCost));
                row.MarkupPercent = PXPriceCostAttribute.Round((decimal)((row.CuryExtCost.GetValueOrDefault(0) > 0) ? ((row.CuryLineAmt - row.CuryExtCost) / row.CuryExtCost) * 100 : 0));
                row.MarginPercent = PXPriceCostAttribute.Round((decimal)((row.CuryLineAmt.GetValueOrDefault(0) > 0) ? ((row.CuryLineAmt - row.CuryExtCost) / row.CuryLineAmt) * 100 : 0));
                if (previewHeader.ApplyAdjustmentAs == AdjustmentType.Discount && !row.IsFreightLine.GetValueOrDefault(false))
                {
                    row.CuryDiscAmt = PXPriceCostAttribute.Round((decimal)((row.CuryUnitPrice * row.OrderQty) - row.CuryLineAmt));
                }
                else
                {
                    row.CuryUnitPrice = PXPriceCostAttribute.Round((decimal)(row.CuryLineAmt / row.OrderQty));
                }
            }
            //If Profit is changed
            else if (!sender.ObjectsEqual<PricingAnalysisPreviewLine.curyProfit>(row, oldrow))
            {
                row.CuryLineAmt = PXPriceCostAttribute.Round((decimal)(row.CuryExtCost + row.CuryProfit));
                row.MarkupPercent = PXPriceCostAttribute.Round((decimal)((row.CuryExtCost.GetValueOrDefault(0) > 0) ? ((row.CuryLineAmt - row.CuryExtCost) / row.CuryExtCost) * 100 : 0));
                row.MarginPercent = PXPriceCostAttribute.Round((decimal)((row.CuryLineAmt.GetValueOrDefault(0) > 0) ? ((row.CuryLineAmt - row.CuryExtCost) / row.CuryLineAmt) * 100 : 0));
                if (previewHeader.ApplyAdjustmentAs == AdjustmentType.Discount && !row.IsFreightLine.GetValueOrDefault(false))
                {
                    row.CuryDiscAmt = PXPriceCostAttribute.Round((decimal)((row.CuryUnitPrice * row.OrderQty) - row.CuryLineAmt));
                }
                else
                {
                    row.CuryUnitPrice = PXPriceCostAttribute.Round((decimal)(row.CuryLineAmt / row.OrderQty));
                }
            }
            //If MarkupPercent is changed
            else if (!sender.ObjectsEqual<PricingAnalysisPreviewLine.markupPercent>(row, oldrow))
            {
                row.CuryProfit = PXPriceCostAttribute.Round((decimal)((row.MarkupPercent * row.CuryExtCost) / 100));
                row.CuryLineAmt = PXPriceCostAttribute.Round((decimal)(row.CuryExtCost + row.CuryProfit));
                row.MarginPercent = PXPriceCostAttribute.Round((decimal)((row.CuryLineAmt.GetValueOrDefault(0) > 0) ? ((row.CuryLineAmt - row.CuryExtCost) / row.CuryLineAmt) * 100 : 0));
                if (previewHeader.ApplyAdjustmentAs == AdjustmentType.Discount && !row.IsFreightLine.GetValueOrDefault(false))
                {
                    row.CuryDiscAmt = PXPriceCostAttribute.Round((decimal)((row.CuryUnitPrice * row.OrderQty) - row.CuryLineAmt));
                }
                else
                {
                    row.CuryUnitPrice = PXPriceCostAttribute.Round((decimal)(row.CuryLineAmt / row.OrderQty));
                }
            }
            //If MarginPercent is changed
            else if (!sender.ObjectsEqual<PricingAnalysisPreviewLine.marginPercent>(row, oldrow))
            {
                row.CuryLineAmt = PXPriceCostAttribute.Round((decimal)(row.CuryExtCost / (1 - (row.MarginPercent) / 100)));
                row.CuryProfit = PXPriceCostAttribute.Round((decimal)(row.CuryLineAmt - row.CuryExtCost));
                row.MarkupPercent = PXPriceCostAttribute.Round((decimal)((row.CuryExtCost.GetValueOrDefault(0) > 0) ? ((row.CuryLineAmt - row.CuryExtCost) / row.CuryExtCost) * 100 : 0));
                if (previewHeader.ApplyAdjustmentAs == AdjustmentType.Discount && !row.IsFreightLine.GetValueOrDefault(false))
                {
                    row.CuryDiscAmt = PXPriceCostAttribute.Round((decimal)((row.CuryUnitPrice * row.OrderQty) - row.CuryLineAmt));
                }
                else
                {
                    row.CuryUnitPrice = PXPriceCostAttribute.Round((decimal)(row.CuryLineAmt / row.OrderQty));
                }
            }
            RefreshHeaderTotal();
            PricingAnalysisPreview.Cache.IsDirty = false;
            PricingAnalysisPreviewHeaderFilter.Cache.IsDirty = false;
            PricingAnalysisPreviewHeaderRecs.Cache.IsDirty = false;
            //To Apply Style.
            PricingAnalysisPreview.View.RequestRefresh();
        }

        public void _(Events.RowPersisting<PricingAnalysisPreviewLine> e)
        {
            e.Cancel = true;
        }

        public void _(Events.RowPersisting<PricingAnalysisBreakup> e)
        {
            e.Cancel = true;
        }

        public void _(Events.RowPersisting<PricingAnalysisBreakupByDoc> e)
        {
            e.Cancel = true;
        }

        public void _(Events.RowPersisting<PricingAnalysisPreviewHeaderInfo> e)
        {
            e.Cancel = true;
        }

        public void _(Events.RowSelected<PricingAnalysisPreviewHeader> e)
        {
            if (e.Cache == null || e.Row == null) { return; }

            bool bAllowEdit = DocumentLineData.BaseSelect.AllowUpdate;
            PXUIFieldAttribute.SetEnabled<PricingAnalysisPreviewHeader.applyAdjustmentAs>(e.Cache, e.Row, bAllowEdit);
        }

        public void _(Events.RowSelected<Document> e)
        {
            Document data = e.Row;
            PXCache sender = e.Cache;
            if (data == null || sender == null) { return; }

            bool bAllowEdit = DocumentLineData.BaseSelect.AllowUpdate;
            ProfitBreakUpByCurrentItem.SetEnabled(bAllowEdit);
            ProfitBreakUpByDocument.SetEnabled(bAllowEdit);
        }

        public void _(Events.RowSelected<PricingAnalysisPreviewLine> e)
        {
            PricingAnalysisPreviewLine data = e.Row;
            PXCache sender = e.Cache;
            if (data == null || sender == null) { return; }

            bool canEdit = DocumentLineData.BaseSelect.AllowUpdate;
            bool bAllowEdit = data.LineType == ProfitLineType.PreviewLineType && canEdit;
            bool bAllowEditPrice = bAllowEdit && ((PricingAnalysisPreviewHeaderFilter.Current?.ApplyAdjustmentAs == AdjustmentType.Price)
                                                || (PricingAnalysisPreview.Current != null && PricingAnalysisPreview.Current.IsFreightLine.GetValueOrDefault(false)));
            bool bAllowEditDisc = bAllowEdit && (PricingAnalysisPreviewHeaderFilter.Current?.ApplyAdjustmentAs == AdjustmentType.Discount)
                                                 && PricingAnalysisPreview.Current != null && !PricingAnalysisPreview.Current.IsFreightLine.GetValueOrDefault(false);
            PXUIFieldAttribute.SetEnabled<PricingAnalysisPreviewLine.curyUnitPrice>(sender, data, bAllowEditPrice);
            PXUIFieldAttribute.SetEnabled<PricingAnalysisPreviewLine.curyDiscAmt>(sender, data, bAllowEditDisc);
            PXUIFieldAttribute.SetEnabled<PricingAnalysisPreviewLine.curyLineAmt>(sender, data, bAllowEdit);
            PXUIFieldAttribute.SetEnabled<PricingAnalysisPreviewLine.curyProfit>(sender, data, bAllowEdit);
            PXUIFieldAttribute.SetEnabled<PricingAnalysisPreviewLine.marginPercent>(sender, data, bAllowEdit && (data.CuryExtCost.GetValueOrDefault(0) > 0));
            PXUIFieldAttribute.SetEnabled<PricingAnalysisPreviewLine.markupPercent>(sender, data, bAllowEdit && (data.CuryExtCost.GetValueOrDefault(0) > 0));

            if (PricingAnalysisPreviewHeaderFilter.Current?.ApplyAdjustmentAs == AdjustmentType.Discount
                    && (e.Row.IsFreightLine ?? false)
                    && e.Row.LineType == ProfitLineType.PreviewLineType)
            {
                e.Cache.RaiseExceptionHandling<PricingAnalysisPreviewLine.curyDiscAmt>(e.Row,
                                                e.Row.CuryDiscAmt,
                                                new PXSetPropertyException(Messages.ApplyAdjustmentDiscountChangeFreightWarning,
                                                                            PXErrorLevel.RowWarning));
            }
        }

        public void _(Events.RowSelected<ProfitAnalysisByLineSetting> e)
        {
            ProfitAnalysisByLineSetting data = e.Row;
            PXCache sender = e.Cache;
            if (data == null || sender == null) { return; }
            PXUIFieldAttribute.SetVisible<PricingAnalysisBreakup.marginPercent>(PricingAnalysisBreakupLinesByLine.Cache, null, (data.BreakupBy == BreakupBy.Margin));
            PXUIFieldAttribute.SetVisible<PricingAnalysisBreakup.markupPercent>(PricingAnalysisBreakupLinesByLine.Cache, null, (data.BreakupBy == BreakupBy.Markup));
            PricingAnalysisBreakupLinesByLine.Cache.AllowUpdate = false;
            PricingAnalysisBreakupLinesByLine.Cache.AllowInsert = false;
            PricingAnalysisBreakupLinesByLine.Cache.AllowDelete = false;
        }

        public void _(Events.RowUpdated<ProfitAnalysisByLineSetting> e)
        {
            ProfitAnalysisByLineSetting data = e.Row;
            ProfitAnalysisByLineSetting olddata = e.OldRow;
            PXCache sender = e.Cache;
            if (data == null || olddata == null || sender == null) { return; }
            if (!sender.ObjectsEqual<ProfitAnalysisByLineSetting.breakupBy, ProfitAnalysisByLineSetting.startValue, ProfitAnalysisByLineSetting.incrementValue>(data, olddata))
            {
                PopulateBreaupLines();
            }
        }

        public void _(Events.RowSelected<ProfitAnalysisByDocSetting> e)
        {
            ProfitAnalysisByDocSetting data = e.Row;
            PXCache sender = e.Cache;
            if (data == null || sender == null) { return; }
            PXUIFieldAttribute.SetVisible<PricingAnalysisBreakup.marginPercent>(PricingAnalysisBreakupLinesByDoc.Cache, null, (data.BreakupBy == BreakupBy.Margin));
            PXUIFieldAttribute.SetVisible<PricingAnalysisBreakup.markupPercent>(PricingAnalysisBreakupLinesByDoc.Cache, null, (data.BreakupBy == BreakupBy.Markup));
            PricingAnalysisBreakupLinesByDoc.Cache.AllowUpdate = false;
            PricingAnalysisBreakupLinesByDoc.Cache.AllowInsert = false;
            PricingAnalysisBreakupLinesByDoc.Cache.AllowDelete = false;
        }

        public void _(Events.RowUpdated<ProfitAnalysisByDocSetting> e)
        {
            ProfitAnalysisByDocSetting data = e.Row;
            ProfitAnalysisByDocSetting olddata = e.OldRow;
            PXCache sender = e.Cache;
            if (data == null || olddata == null || sender == null) { return; }
            if (!sender.ObjectsEqual<ProfitAnalysisByLineSetting.breakupBy, ProfitAnalysisByLineSetting.startValue, ProfitAnalysisByLineSetting.incrementValue>(data, olddata))
            {
                PopulateBreaupLinesForDoc();
            }
        }

        public void _(Events.FieldDefaulting<PricingAnalysisPreviewLine, PricingAnalysisPreviewLine.enablePriceAnalysisByLine> e)
        {
            if (e.Row.IsFreightLine.GetValueOrDefault(false))
            {
                e.NewValue = DocumentData.Current != null && DocumentData.Current.OverrideFreightAmount.GetValueOrDefault();
            }
        }
        #endregion

        #region Actions

        public PXAction<TPrimary> PricingAnalysis;
        [PXUIField(DisplayName = "Pricing Analysis", MapEnableRights = PXCacheRights.Select, MapViewRights = PXCacheRights.Select)]
        [PXButton(CommitChanges = true)]
        public virtual IEnumerable pricingAnalysis(PXAdapter adapter)
        {
            if (PricingAnalysisPreviewHeaderFilter.AskExtFullyValid((graph, viewName) =>
            {
                PricingAnalysisPreviewHeaderRecs.Cache.Clear();
                PricingAnalysisPreviewHeaderRecs.Cache.ClearQueryCache();
                PricingAnalysisPreview.Cache.Clear();
                PricingAnalysisPreview.Cache.ClearQueryCache();
                graph.Views[viewName].Cache.Clear();
                graph.Views[viewName].Cache.ClearQueryCache();
                graph.Views[viewName].ClearDialog();
            }, DialogAnswerType.Positive, true))
            {
                bool canEdit = DocumentData.BaseSelect.AllowUpdate;
                if (!canEdit) { return adapter.Get(); }

                Document soDoc = DocumentData.Current;
                PricingAnalysisPreviewHeader filterData = PricingAnalysisPreviewHeaderFilter.Current;
                List<DocumentLine> soLines = DocumentLineData.Select().RowCast<DocumentLine>().ToList();

                foreach (PricingAnalysisPreviewLine line in PricingAnalysisPreview.Cache.Updated)
                {
                    if (line.IsFreightLine.GetValueOrDefault(false))
                    {
                        soDoc.CuryFreightAmt = line.CuryUnitPrice - soDoc.CuryPremiumFreightAmt;
                        DocumentData.Update(soDoc);
                    }
                    else
                    {
                        DocumentLine soline = soLines.Where(x => x.LineNbr == line.LineNbr).FirstOrDefault();
                        if (soline == null)
                        {
                            continue;
                        }

                        if (filterData.ApplyAdjustmentAs == AdjustmentType.Discount)
                        {
                            soline.CuryDiscAmt = line.CuryDiscAmt;
                        }
                        else
                        {
                            soline.CuryUnitPrice = line.CuryUnitPrice;
                        }
                        DocumentLineData.Update(soline);
                    }
                }
            }
            else
            {
                PricingAnalysisPreviewHeaderFilter.Cache.Clear();
                PricingAnalysisPreviewHeaderFilter.Cache.ClearQueryCacheObsolete();
                PricingAnalysisPreview.Cache.Clear();
                PricingAnalysisPreview.Cache.ClearQueryCache();
            }
            return adapter.Get();
        }

        public PXAction<TPrimary> ProfitBreakUpByDocument;
        [PXUIField(DisplayName = "Document Pricing Ruler", MapEnableRights = PXCacheRights.Select, MapViewRights = PXCacheRights.Select)]
        [PXButton]
        public virtual IEnumerable profitBreakUpByDocument(PXAdapter adapter)
        {
            if (ProfitAnalysisSettingFilterByDoc.AskExtFullyValid((graph, viewName) =>
            {
                ProfitAnalysisSettingFilterByDoc.Cache.Clear();
                ProfitAnalysisSettingFilterByDoc.Cache.ClearQueryCache();
                PricingAnalysisBreakupLinesByDoc.Cache.Clear();
                PricingAnalysisBreakupLinesByDoc.Cache.ClearQueryCache();
            }, DialogAnswerType.Positive, true))
            {
                ProfitAnalysisByDocSetting settings = ProfitAnalysisSettingFilterByDoc.Current;

                PricingAnalysisBreakupByDoc cBreakUpLine = PricingAnalysisBreakupLinesByDoc.Current;
                List<PricingAnalysisPreviewLine> prvLines = PricingAnalysisPreview.Select().RowCast<PricingAnalysisPreviewLine>().ToList();
                prvLines = prvLines.Where(x => x.LineType == ProfitLineType.PreviewLineType).ToList();
                foreach (PricingAnalysisPreviewLine cPrvLine in prvLines)
                {
                    PricingAnalysisPreviewLine cPrvLineOld = PXCache<PricingAnalysisPreviewLine>.CreateCopy(cPrvLine);
                    if (settings.BreakupBy == BreakupBy.Markup)
                    {
                        cPrvLine.MarkupPercent = cBreakUpLine.MarkupPercent;
                        PricingAnalysisPreview.Cache.RaiseRowUpdated(cPrvLine, cPrvLineOld);
                        PricingAnalysisPreview.Cache.SetStatus(cPrvLine, PXEntryStatus.Updated);
                    }
                    else if (settings.BreakupBy == BreakupBy.Margin)
                    {
                        cPrvLine.MarginPercent = cBreakUpLine.MarginPercent;
                        PricingAnalysisPreview.Cache.RaiseRowUpdated(cPrvLine, cPrvLineOld);
                        PricingAnalysisPreview.Cache.SetStatus(cPrvLine, PXEntryStatus.Updated);
                    }
                }
            }
            return adapter.Get();
        }

        public PXAction<TPrimary> ProfitBreakUpByCurrentItem;
        [PXUIField(DisplayName = "Line Pricing Ruler", MapEnableRights = PXCacheRights.Select, MapViewRights = PXCacheRights.Select)]
        [PXButton]
        public virtual IEnumerable profitBreakUpByCurrentItem(PXAdapter adapter)
        {
            if (ProfitAnalysisSettingFilterByLine.AskExtFullyValid((graph, viewName) =>
            {
                ProfitAnalysisSettingFilterByLine.Cache.Clear();
                ProfitAnalysisSettingFilterByLine.Cache.ClearQueryCache();
                PricingAnalysisBreakupLinesByLine.Cache.Clear();
                PricingAnalysisBreakupLinesByLine.Cache.ClearQueryCache();
            }, DialogAnswerType.Positive, true))
            {
                ProfitAnalysisByLineSetting settings = ProfitAnalysisSettingFilterByLine.Current;

                PricingAnalysisBreakup cBreakUpLine = PricingAnalysisBreakupLinesByLine.Current;
                List<PricingAnalysisPreviewLine> prvLines = PricingAnalysisPreview.Select().RowCast<PricingAnalysisPreviewLine>().ToList();
                PricingAnalysisPreviewLine cPrvLine = prvLines.Where(x => x.LineNbr == cBreakUpLine.LineNbr && x.LineType == ProfitLineType.PreviewLineType).FirstOrDefault();
                PricingAnalysisPreviewLine cPrvLineOld = PXCache<PricingAnalysisPreviewLine>.CreateCopy(cPrvLine);

                if (settings.BreakupBy == BreakupBy.Markup)
                {
                    cPrvLine.MarkupPercent = cBreakUpLine.MarkupPercent;
                    PricingAnalysisPreview.Cache.RaiseRowUpdated(cPrvLine, cPrvLineOld);
                    PricingAnalysisPreview.Cache.SetStatus(cPrvLine, PXEntryStatus.Updated);
                }
                else if (settings.BreakupBy == BreakupBy.Margin)
                {
                    cPrvLine.MarginPercent = cBreakUpLine.MarginPercent;
                    PricingAnalysisPreview.Cache.RaiseRowUpdated(cPrvLine, cPrvLineOld);
                    PricingAnalysisPreview.Cache.SetStatus(cPrvLine, PXEntryStatus.Updated);
                }
            }
            return adapter.Get();
        }

        public PXAction<TPrimary> VoidPricingAnalysis;
        [PXUIField(DisplayName = "Cancel", MapEnableRights = PXCacheRights.Select, MapViewRights = PXCacheRights.Select)]
        [PXButton]
        public virtual IEnumerable voidPricingAnalysis(PXAdapter adapter)
        {
            PricingAnalysisPreview.Cache.Clear();
            PricingAnalysisPreview.Cache.ClearQueryCache();
            return adapter.Get();
        }
        #endregion

        protected abstract DocumentMapping GetDocumentMapping();
        protected class DocumentMapping : IBqlMapping
        {
            public Type Table { get; }
            public Type Extension => typeof(Document);

            public DocumentMapping(Type table) { Table = table; }

            public Type NoteID = typeof(Document.noteID);
            public Type UsrEditable = typeof(Document.usrEditable);
            public Type CuryFreightTot = typeof(Document.curyFreightTot);
            public Type CuryFreightAmt = typeof(Document.curyFreightAmt);
            public Type CuryPremiumFreightAmt = typeof(Document.curyFreightAmt);
            public Type CuryFreightCost = typeof(Document.curyFreightCost);
            public Type OverrideFreightAmount = typeof(Document.overrideFreightAmount);
        }

        protected abstract DocumentLineMapping GetDocumentLineMapping();
        protected class DocumentLineMapping : IBqlMapping
        {
            public Type Table { get; }
            public Type Extension => typeof(DocumentLine);

            public DocumentLineMapping(Type table) { Table = table; }

            public Type NoteID = typeof(DocumentLine.noteID);
            public Type LineNbr = typeof(DocumentLine.lineNbr);
            public Type InventoryID = typeof(DocumentLine.inventoryID);
            public Type IsStockItem = typeof(DocumentLine.isStockItem);
            public Type UOM = typeof(DocumentLine.uOM);
            public Type OrderQty = typeof(DocumentLine.orderQty);
            public Type CuryDiscAmt = typeof(DocumentLine.curyDiscAmt);
            public Type CuryUnitPrice = typeof(DocumentLine.curyUnitPrice);
            public Type CuryExtCost = typeof(DocumentLine.curyExtCost);
            public Type CuryLineAmt = typeof(DocumentLine.curyLineAmt);
            public Type IsLastCostUsed = typeof(DocumentLine.isLastCostUsed);
        }
    }

    [PXHidden]
    public class Document : PXMappedCacheExtension
    {
        #region NoteID
        public abstract class noteID : PX.Data.BQL.BqlGuid.Field<noteID> { }

        public virtual Guid? NoteID { get; set; }
        #endregion

        #region UsrEditable
        public abstract class usrEditable : PX.Data.BQL.BqlBool.Field<usrEditable> { }

        public virtual bool? UsrEditable { get; set; }
        #endregion

        #region CuryFreightTot
        public abstract class curyFreightTot : PX.Data.BQL.BqlDecimal.Field<curyFreightTot> { }

        public virtual decimal? CuryFreightTot { get; set; }
        #endregion

        #region CuryFreightAmt
        public abstract class curyFreightAmt : PX.Data.BQL.BqlDecimal.Field<curyFreightAmt> { }

        public virtual decimal? CuryFreightAmt { get; set; }
        #endregion

        #region CuryPremiumFreightAmt
        public abstract class curyPremiumFreightAmt : PX.Data.BQL.BqlDecimal.Field<curyPremiumFreightAmt> { }

        public virtual decimal? CuryPremiumFreightAmt { get; set; }
        #endregion

        #region FreightCost
        public abstract class curyFreightCost : PX.Data.BQL.BqlDecimal.Field<curyFreightCost> { }

        public virtual decimal? CuryFreightCost { get; set; }
        #endregion

        #region OverrideFreightAmount
        public abstract class overrideFreightAmount : PX.Data.BQL.BqlBool.Field<overrideFreightAmount> { }

        public virtual bool? OverrideFreightAmount { get; set; }
        #endregion
    }

    [PXHidden]
    public class DocumentLine : PXMappedCacheExtension
    {
        #region NoteID
        public abstract class noteID : PX.Data.BQL.BqlGuid.Field<noteID> { }

        public virtual Guid? NoteID { get; set; }
        #endregion

        #region LineNbr
        public abstract class lineNbr : PX.Data.BQL.BqlInt.Field<lineNbr> { }

        public virtual int? LineNbr { get; set; }
        #endregion

        #region InventoryID
        public abstract class inventoryID : PX.Data.BQL.BqlInt.Field<inventoryID> { }

        public virtual int? InventoryID { get; set; }
        #endregion

        #region IsStockItem
        public abstract class isStockItem : PX.Data.BQL.BqlBool.Field<isStockItem> { }

        public virtual bool? IsStockItem { get; set; }
        #endregion

        #region UOM
        public abstract class uOM : PX.Data.BQL.BqlString.Field<uOM> { }

        public virtual String UOM { get; set; }
        #endregion

        #region OrderQty
        public abstract class orderQty : PX.Data.BQL.BqlDecimal.Field<orderQty> { }

        public virtual decimal? OrderQty { get; set; }
        #endregion

        #region CuryDiscAmt
        public abstract class curyDiscAmt : PX.Data.BQL.BqlDecimal.Field<curyDiscAmt> { }

        public virtual decimal? CuryDiscAmt { get; set; }
        #endregion

        #region CuryUnitPrice
        public abstract class curyUnitPrice : PX.Data.BQL.BqlDecimal.Field<curyUnitPrice> { }

        public virtual decimal? CuryUnitPrice { get; set; }
        #endregion

        #region CuryExtCost
        public abstract class curyExtCost : PX.Data.BQL.BqlDecimal.Field<curyExtCost> { }

        public virtual decimal? CuryExtCost { get; set; }
        #endregion

        #region CuryLineAmt
        public abstract class curyLineAmt : PX.Data.BQL.BqlDecimal.Field<curyLineAmt> { }

        public virtual decimal? CuryLineAmt { get; set; }
        #endregion

        #region CuryProfit
        public abstract class curyProfit : PX.Data.BQL.BqlDecimal.Field<curyProfit> { }

        public virtual decimal? CuryProfit { get; set; }
        #endregion

        #region IsLastCostUsed
        public abstract class isLastCostUsed : PX.Data.BQL.BqlBool.Field<isLastCostUsed> { }

        public virtual bool? IsLastCostUsed { get; set; }
        #endregion
    }
}