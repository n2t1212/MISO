using PosMiso.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosMiso.View
{
    public partial class dlg_ChonQuay : Form
    {
        public bool isChon = false;

        public dlg_ChonQuay()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            try
            {
                rdbQ1.Checked = true;
                rdbC1.Checked = true;

            }
            catch { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            isChon = false;
            this.Close();
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            isChon = false;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            isChon = false;
            if (rdbC2.Checked == true)
            {
                MTGlobal.MT_CA = "CA 02";
            }
            else if (rdbC3.Checked == true)
            {
                MTGlobal.MT_CA = "CA 03";
            }
            else
            {
                MTGlobal.MT_CA = "CA 01";
            }

            if (rdbQ2.Checked == true)
            {
                MTGlobal.MT_QUAY = "Quầy số 02";
            }
            else if (rdbQ3.Checked == true)
            {
                MTGlobal.MT_QUAY = "Quầy số 03";
            }
            else
            {
                MTGlobal.MT_QUAY = "Quầy số 01";
            }
            isChon = true;
            this.Close();
        }
    }
}
