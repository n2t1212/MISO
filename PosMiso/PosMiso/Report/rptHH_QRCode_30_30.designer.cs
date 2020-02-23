﻿namespace PosMiso.Report
{
    partial class rptHH_QRCode_30_30
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.parThangNam = new DevExpress.XtraReports.Parameters.Parameter();
            this.parTax = new DevExpress.XtraReports.Parameters.Parameter();
            this.parCompany = new DevExpress.XtraReports.Parameters.Parameter();
            this.parAddress = new DevExpress.XtraReports.Parameters.Parameter();
            this.parTel = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.parNguoiLap = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrMaCode = new DevExpress.XtraReports.UI.XRBarCode();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrMaCode});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 266F;
            this.Detail.MultiColumn.ColumnCount = 3;
            this.Detail.MultiColumn.ColumnWidth = 306F;
            this.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Dpi = 254F;
            this.ReportHeader.Expanded = false;
            this.ReportHeader.HeightF = 0F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.Visible = false;
            // 
            // parThangNam
            // 
            this.parThangNam.Description = "Tháng Năm";
            this.parThangNam.Name = "parThangNam";
            // 
            // parTax
            // 
            this.parTax.Description = "Mã Số Thuế";
            this.parTax.Name = "parTax";
            this.parTax.ValueInfo = "0343434343";
            // 
            // parCompany
            // 
            this.parCompany.Description = "Tên Công Ty";
            this.parCompany.Name = "parCompany";
            this.parCompany.ValueInfo = "CÔNG TY TNHH ABC";
            // 
            // parAddress
            // 
            this.parAddress.Description = "Địa chỉ Công Ty";
            this.parAddress.Name = "parAddress";
            this.parAddress.ValueInfo = "Số 1 Đường Cộng Hòa, F.13, Q.Tân Bình, TP.HCM";
            // 
            // parTel
            // 
            this.parTel.Description = "Điện Thoại";
            this.parTel.Name = "parTel";
            this.parTel.ValueInfo = "(028) 03434923";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Dpi = 254F;
            this.ReportFooter.Expanded = false;
            this.ReportFooter.HeightF = 114F;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.Visible = false;
            // 
            // parNguoiLap
            // 
            this.parNguoiLap.Description = "Người Lập";
            this.parNguoiLap.Name = "parNguoiLap";
            // 
            // xrMaCode
            // 
            this.xrMaCode.Dpi = 254F;
            this.xrMaCode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrMaCode.LocationFloat = new DevExpress.Utils.PointFloat(25.00001F, 4F);
            this.xrMaCode.Module = 5.08F;
            this.xrMaCode.Name = "xrMaCode";
            this.xrMaCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrMaCode.SizeF = new System.Drawing.SizeF(260F, 260F);
            this.xrMaCode.StylePriority.UseFont = false;
            this.xrMaCode.StylePriority.UseTextAlignment = false;
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            this.xrMaCode.Symbology = qrCodeGenerator1;
            this.xrMaCode.Text = "AAAAA";
            this.xrMaCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrMaCode.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrMaCode_BeforePrint);
            // 
            // rptHH_QRCode
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.ReportFooter});
            this.Dpi = 254F;
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 308;
            this.PageWidth = 950;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.parCompany,
            this.parAddress,
            this.parTax,
            this.parTel,
            this.parNguoiLap,
            this.parThangNam});
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 31.75F;
            this.Version = "12.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.Parameters.Parameter parTax;
        private DevExpress.XtraReports.Parameters.Parameter parCompany;
        private DevExpress.XtraReports.Parameters.Parameter parAddress;
        private DevExpress.XtraReports.Parameters.Parameter parTel;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.Parameters.Parameter parNguoiLap;
        private DevExpress.XtraReports.Parameters.Parameter parThangNam;
        private DevExpress.XtraReports.UI.XRBarCode xrMaCode;
    }
}
