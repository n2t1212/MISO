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
    public partial class DM_SanPham : Form
    {
        DataTable otblSrcSanPham = null;
        DataTable otblSrcNhomSanPham = null;

        String maNhomSPId = "";

        public DM_SanPham()
        {
            InitializeComponent();
        }

        private void DM_SanPham_Load(object sender, EventArgs e)
        {
            setDataSourceNhomSanPham();
            setDataSourceSanPham("");
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

        private void setDataSourceSanPham(String Manhomspid)
        {
            try
            {
                String mSql = String.Format("select Maspid,Masp,Tensp,Dvt,Quycach,Quydoikgl,Quydoithung,Maqrcode,Mabarcode from DM_SANPHAM order by Masp asc");

                if (Manhomspid != null && Manhomspid.Length > 0)
                {
                    mSql = String.Format("select Maspid,Masp,Tensp,Dvt,Quycach,Quydoikgl,Quydoithung,Maqrcode,Mabarcode from DM_SANPHAM where Manhomspid ='{0}' order by Masp asc", Manhomspid);
                }
                otblSrcSanPham = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
                if (otblSrcSanPham == null)
                {
                    Utils.showMessage("Không thể đọc dữ liệu cần chọn...", "Thông báo");
                    return;
                }

                grdSanPham.DataSource = otblSrcSanPham;
                SysPar.SetGridReadOnly(true, gvSanPham);
            }
            catch (Exception ex) { }

        }

        private void gvNhomSanPham_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gvNhomSanPham.GetDataRow(e.FocusedRowHandle);

            if(dataRow != null)
            {
                maNhomSPId = dataRow["Manhomspid"].ToString();
                setDataSourceSanPham(maNhomSPId);
            }
        }

        private void btnInMa_Click(object sender, EventArgs e)
        {
            frmInMa inMa = new frmInMa();
            inMa.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (maNhomSPId.Length == 0)
            {
                Utils.showMessage("Vui lòng chọn nhóm sản phẩm cần nhập", "Thông báo");
                return;
            }

            dlg_ImportSanPham importSP = new dlg_ImportSanPham(maNhomSPId);
            importSP.ShowDialog();
        }

        private void btnDownTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fdl = new FolderBrowserDialog();
                if (fdl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (System.IO.File.Exists(fdl.SelectedPath + @"\Bieu_mau_san_pham.xlsx"))
                    {
                        Utils.showMessage("File mẫu đang tồn tại trong thư mục. Vui lòng kiểm tra lại..", "Thông báo");
                    }
                    else
                    {
                        System.IO.File.Copy(@"Bieu_mau_san_pham.xlsx", fdl.SelectedPath + @"\Bieu_mau_san_pham.xlsx");
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
    }
}
