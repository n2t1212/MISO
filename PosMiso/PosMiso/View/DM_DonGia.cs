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
    public partial class DM_DonGia : Form
    {
        DataTable otblSrcBangGia = null;
        DataTable otblSrcBangGiaCT = null;

        String bangGiaID = "";
        public DM_DonGia()
        {
            InitializeComponent();
        }

        private void DM_DonGia_Load(object sender, EventArgs e)
        {
            setDataSourceBangGia();
            setDataSourceBangGiaCT(bangGiaID);
        }

        private void setDataSourceBangGia()
        {
            try
            {
                String mSql = String.Format("select Banggiaid,Banggia,Tungay,Denngay,Ngayapdung,Apdung from DM_BANGGIA order by Banggiaid asc");
                otblSrcBangGia = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
                if (otblSrcBangGia == null)
                {
                    Utils.showMessage("Không thể đọc dữ liệu cần chọn...", "Thông báo");
                    return;
                }

                grdBangGia.DataSource = otblSrcBangGia;
                SysPar.SetGridReadOnly(true, gvBangGia);
            }
            catch (Exception ex) { }

        }

        private void setDataSourceBangGiaCT(String _bangGiaID)
        {
            try
            {
                String mSql = String.Format("select Banggiactid,Banggiaid,Maspid,Mavung,Masp,Tensp,Giagoc,Giasi,Giale,Ghichu from DM_BANGGIA_CHITIET order by Masp asc");

                if (_bangGiaID != null && _bangGiaID.Length > 0)
                {
                    mSql = String.Format("select Banggiactid,Banggiaid,Maspid,Mavung,Masp,Tensp,Giagoc,Giasi,Giale,Ghichu from DM_BANGGIA_CHITIET where Banggiaid='{0}' order by Masp asc", _bangGiaID);
                }

                otblSrcBangGiaCT = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
                if (otblSrcBangGiaCT == null)
                {
                    Utils.showMessage("Không thể đọc dữ liệu cần chọn...", "Thông báo");
                    return;
                }

                grdBangGiaCT.DataSource = otblSrcBangGiaCT;
                SysPar.SetGridReadOnly(true, gvBangGiaCT);
            }
            catch (Exception ex) { }

        }

        private void gvBangGiaCT_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
        }

        private void btnDownTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fdl = new FolderBrowserDialog();
                if (fdl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (System.IO.File.Exists(fdl.SelectedPath + @"\Bieu_mau_gia_san_pham.xlsx"))
                    {
                        Utils.showMessage("File mẫu đang tồn tại trong thư mục. Vui lòng kiểm tra lại..", "Thông báo");
                    }
                    else
                    {
                        System.IO.File.Copy(@"Bieu_mau_gia_san_pham.xlsx", fdl.SelectedPath + @"\Bieu_mau_gia_san_pham.xlsx");
                        Utils.showMessage("Đã tải file mẫu thành công.", "Thông báo");
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                Utils.showMessage("Lỗi tải file. Vui lòng kiểm tra đường dẫn", "Thông báo");
                return;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (bangGiaID.Length == 0)
            {
                Utils.showMessage("Vui lòng chọn bảng giá cần nhập", "Thông báo");
                return;
            }

            dlg_ImportGiaSanPham giaImport = new dlg_ImportGiaSanPham(bangGiaID);
            giaImport.ShowDialog();
        }

        private void gvBangGia_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dataRow = gvBangGia.GetDataRow(e.RowHandle);

            if (dataRow != null)
            {
                bangGiaID = dataRow["Banggiaid"].ToString();
                setDataSourceBangGiaCT(bangGiaID);
            }
        }
    }
}
