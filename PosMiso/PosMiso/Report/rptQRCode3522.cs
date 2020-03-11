﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.BarCode;

namespace PosMiso
{
    public partial class rptQRCode3522 : DevExpress.XtraReports.UI.XtraReport
    {
        public rptQRCode3522()
        {
            InitializeComponent();
        }

        public void InitMacode(bool isQrcode = false,bool isDG=false)
        {
            if (isQrcode)
            {
                this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
                xrMaCode.Symbology = new QRCodeGenerator();

                //xrMaCode.Width = 110;
                //xrMaCode.Height = 110;
                xrMaCode.BackColor = System.Drawing.Color.White;
                xrMaCode.ForeColor = System.Drawing.Color.Green;
                xrMaCode.AutoModule = true;
                xrMaCode.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                ((QRCodeGenerator)xrMaCode.Symbology).CompactionMode = QRCodeCompactionMode.AlphaNumeric;
                ((QRCodeGenerator)xrMaCode.Symbology).ErrorCorrectionLevel = QRCodeErrorCorrectionLevel.H;
                ((QRCodeGenerator)xrMaCode.Symbology).Version = QRCodeVersion.AutoVersion;

                if (isDG)
                {
                    crBarcodePrice.Visible = true;
                }
                else {
                    crBarcodePrice.Visible = false;
                }
                //crBarcodeText.Angle = 90;
                //crBarcodeText.LeftF = xrMaCode.LeftF + xrMaCode.WidthF + 1;
                //crBarcodePrice.LeftF = xrMaCode.LeftF - crBarcodePrice.WidthF - 1;
            }
            else
            {
                this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
                xrMaCode.Symbology = new Code128Generator();
                xrMaCode.AutoModule = true;
                xrMaCode.Font = new System.Drawing.Font("Arial", 6F);
                xrMaCode.Width = 250;
                xrMaCode.Height = 110;
                crBarcodeText.TopF = xrMaCode.LocationF.Y + xrMaCode.HeightF + 1;
                crBarcodeText.LeftF = xrMaCode.LeftF;
                crBarcodeText.WidthF = xrMaCode.WidthF;
                crBarcodeText.HeightF = 15;
                xrMaCode.BackColor = System.Drawing.Color.White;
                xrMaCode.ForeColor = System.Drawing.Color.Black;
                ((Code128Generator)xrMaCode.Symbology).CharacterSet = Code128Charset.CharsetB;
               
                crBarcodeText.Angle = 0;

                if (isDG)
                {
                    crBarcodePrice.Visible = true;
                }
                else
                {
                    crBarcodePrice.Visible = false;
                }
            }
        }


        public void BindData()
        {
            xrMaCode.DataBindings.Add(new XRBinding("Text", DataSource, "Macode"));
            crBarcodeText.DataBindings.Add(new XRBinding("Text", DataSource, "MacodeText"));
            crBarcodePrice.DataBindings.Add(new XRBinding("Text", DataSource, "Dongia","{0:N0}"));
        }

        private void crBarcodePrice_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double dPrice = 0;
            try
            {              
                Double.TryParse((sender as XRLabel).Text, out dPrice);               
            }
            catch { }
            if (dPrice<=0){
             (sender as XRLabel).Text="";
            }
        }
    }
}