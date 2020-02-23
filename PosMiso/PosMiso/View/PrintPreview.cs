using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpf.Printing;

namespace PosMiso.View
{
    public partial class PrintPreview : Form
    {
        public DevExpress.XtraReports.UI.XtraReport report;

        public PrintPreview()
        {
            InitializeComponent();
        }

        private void printControl1_Load(object sender, EventArgs e)
        {
            XtraReportPreviewModel model = new XtraReportPreviewModel(report);
            model.AutoShowParametersPanel = false;
        }
    }
}
