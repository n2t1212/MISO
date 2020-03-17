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
    public partial class HT_QuyenHan : Form
    {
        DataTable otblSrcNhomQuyen = null;
        DataTable otblSrcQuyenHan = null;

        String nhomQuyenID = "";

        public HT_QuyenHan()
        {
            InitializeComponent();
        }

        private void HT_QuyenHan_Load(object sender, EventArgs e)
        {
            setDataSourceNhomQuyen();
            setDataSourceQuyenHan("");
        }


        private void setDataSourceNhomQuyen()
        {
            try
            {
                String mSql = String.Format("select * from HT_NHOMQUYEN order by manhom");
                otblSrcNhomQuyen = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
                if (otblSrcNhomQuyen == null)
                {
                    Utils.showMessage("Không thể đọc dữ liệu cần chọn...", "Thông báo");
                    return;
                }

                grdNhomQuyen.DataSource = otblSrcNhomQuyen;
                SysPar.SetGridReadOnly(true, gvNhomQuyen);
            }
            catch (Exception ex) { }

        }

        private void setDataSourceQuyenHan(String nhomQuyenID)
        {
            try
            {
                String mSql = String.Format("select nqcn.soid as soid, nqcn.macn as macn, cn.chucnang as chucnang, " + 
                                                 "nqcn.them as them, nqcn.xoa as xoa, nqcn.sua as sua, nqcn.duyet as duyet, nqcn.[in] as [in]" +
                                                  " from HT_NHOMQUYEN_CHUCNANG nqcn left join DM_CHUCNANG cn on cn.macn = nqcn.macn" +
                                                  " order by manhom asc");

                if (nhomQuyenID != null && nhomQuyenID.Length > 0)
                {
                    mSql = String.Format("select nqcn.soid as soid, nqcn.macn as macn, cn.chucnang as chucnang, " +
                                                 "nqcn.them as them, nqcn.xoa as xoa, nqcn.sua as sua, nqcn.duyet as duyet, nqcn.[in] as [in]" +
                                                  " from HT_NHOMQUYEN_CHUCNANG nqcn left join DM_CHUCNANG cn on cn.macn = nqcn.macn" +
                                                  " where nqcn.manhom='{0}' order by manhom asc", nhomQuyenID);    
                }
                otblSrcQuyenHan = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
                if (otblSrcQuyenHan == null)
                {
                    Utils.showMessage("Không thể đọc dữ liệu cần chọn...", "Thông báo");
                    return;
                }

                grdQuyenHan.DataSource = otblSrcQuyenHan;
                SysPar.SetGridReadOnly(true, gvQuyenHan);
            }
            catch (Exception ex) { }

        }

        private void gvNhomQuyen_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dataRow = gvNhomQuyen.GetDataRow(e.RowHandle);

            if (dataRow != null)
            {
                nhomQuyenID = dataRow["soid"].ToString();
                setDataSourceQuyenHan(nhomQuyenID);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dlg_AddQuyenHan addQH = new dlg_AddQuyenHan(nhomQuyenID);
            addQH.ShowDialog();
        }
    }
}
