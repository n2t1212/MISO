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
    public partial class DM_KhachHang : Form
    {
        DataTable otblSrcKhachHang = null;
        public DM_KhachHang()
        {
            InitializeComponent();
        }

        private void DM_KhachHang_Load(object sender, EventArgs e)
        {
            setDataSourceKhachHang();
        }

        private void setDataSourceKhachHang()
        {
            try
            {
                String mSql = String.Format("select Makhid,Makh,Tenkh,Dienthoai,Diachi,Xa,Huyen,Tinh,Email,Mst,Sinhnhat from DM_KHACHHANG order by Makh asc");
                otblSrcKhachHang = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
                if (otblSrcKhachHang == null)
                {
                    Utils.showMessage("Không thể đọc dữ liệu cần chọn...", "Thông báo");
                    return;
                }

                grdKhachHang.DataSource = otblSrcKhachHang;
                SysPar.SetGridReadOnly(true, gvKhachHang);
            }
            catch (Exception ex) { }

        }
    }
}
