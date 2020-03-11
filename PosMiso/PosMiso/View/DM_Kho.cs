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
    public partial class DM_Kho : Form
    {
        DataTable otblSrcKho = null;

        public DM_Kho()
        {
            InitializeComponent();
        }

        private void DM_Kho_Load(object sender, EventArgs e)
        {
            setDataSourceBangGia();
        }

        private void setDataSourceBangGia()
        {
            try
            {
                String mSql = String.Format("select Khoid,Makho,Tenkho,Diachi,Loaikho,Thukho from DM_KHO order by Makho asc");
                otblSrcKho = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
                if (otblSrcKho == null)
                {
                    Utils.showMessage("Không thể đọc dữ liệu cần chọn...", "Thông báo");
                    return;
                }

                grdKho.DataSource = otblSrcKho;
                SysPar.SetGridReadOnly(true, gvKho);
            }
            catch (Exception ex) { }

        }
    }
}
