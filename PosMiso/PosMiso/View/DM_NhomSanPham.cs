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
    public partial class DM_NhomSanPham : Form
    {
        DataTable otblSrcNhomSanPham = null;

        public DM_NhomSanPham()
        {
            InitializeComponent();
        }

        private void DM_NhomSanPham_Load(object sender, EventArgs e)
        {
            setDataSourceNhomSanPham();
        }

        private void setDataSourceNhomSanPham()
        {
            try
            {
                String mSql = String.Format("select Manhomspid,Manhom,Tennhom from DM_NHOMSP order by Manhom asc");
                otblSrcNhomSanPham = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
                if (otblSrcNhomSanPham == null)
                {
                    Utils.showMessage("Không thể đọc dữ liệu cần chọn...", "Thông báo");
                    return;
                }

                grdNhomSanPham.DataSource = otblSrcNhomSanPham;
                SysPar.SetGridReadOnly(true, gvNhomSanPham);
            }
            catch (Exception ex) { }

        }
    }
}
