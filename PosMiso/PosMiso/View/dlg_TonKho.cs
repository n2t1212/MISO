using PosMiso.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosMiso.View
{
    public partial class dlg_TonKho : Form
    {
        public DataRow RowSP = null;
        private String pLoaiDM = "";

        public System.Data.DataRowView pRowChon;
        public String pGiaTriChon = "";
        public String pMaso = "";
        public String pFieldNameReturn="";
        private String pDenngay = "";

        public dlg_TonKho()
        {
            InitializeComponent();
        }

        public dlg_TonKho(DataTable mTblSP, String mDenngay = "")
        {
            InitializeComponent();
            this.pDenngay = mDenngay;

            setDataSource(mTblSP);
        }

        private void setDataSource(DataTable oTblSP)
        {
            try
            {

                SqlParameter[] arrPara = new SqlParameter[3];
                arrPara[0] = new SqlParameter("@tblSP", SqlDbType.Structured);
                arrPara[0].Value = oTblSP;
                arrPara[1] = new SqlParameter("@Denngay", SqlDbType.NVarChar, 15);
                arrPara[1].Value = this.pDenngay;
                arrPara[2] = new SqlParameter("@Nguoidung", SqlDbType.NVarChar, 50);
                arrPara[2].Value = MTGlobal.MT_USER_LOGIN;

                DataTable oTblHHTK = new MTSQLServer().wRead("spHH_Xemtonkho", arrPara);
                grdTonKho.DataSource = oTblHHTK;
                if (gvTonKho.DataRowCount > 0)
                {
                    gvTonKho.Focus();
                    gvTonKho.FocusedColumn = colMasp;
                }
            }
            catch (Exception ex) { }
        } 

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
