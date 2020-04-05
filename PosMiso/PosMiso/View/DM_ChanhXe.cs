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
    public partial class DM_ChanhXe : Form
    {
        private MTGlobal.MT_ROLE MTROLE;
        private MTGlobal.MT_BUTTONACTION MTButton;

        private DataTable oTblCX;
        private String pPhieuID = "";
        private String pLoaiPhieu = "";
        private String pTuNgay = "";
        private String pDenNgay = "";
        DevExpress.Utils.WaitDialogForm Dlg;

        public DM_ChanhXe()
        {
            InitializeComponent();
            Dlg = Utils.shwWait();
            SysPar.SetGridReadOnly(true, gvPhieu);
            try
            {
                pLoaiPhieu = MTGlobal.CX;
                pTuNgay = MTGlobal.MT_TUNGAY;
                pDenNgay = MTGlobal.MT_DENNGAY;

                setUserRight();
                BindData();
            }
            catch { }
            Utils.closeWait(Dlg);
        }
        
        private void setUserRight()
        {
            DataTable oTblRole = UserRoleFuntional.getRoleByFunctionID(this.Name.ToString());

            if (oTblRole.Rows.Count == 1)
            {
                DataRow rw = oTblRole.Rows[0];
                MTROLE.isAdd = Utils.parseStringToBoolean(rw["them"].ToString());
                MTROLE.isEdit = Utils.parseStringToBoolean(rw["sua"].ToString());
                MTROLE.isDel = Utils.parseStringToBoolean(rw["xoa"].ToString());
                MTROLE.isPrint = Utils.parseStringToBoolean(rw["in"].ToString());
            }
        }
        private void BindData()
        {
            try
            {
                SqlParameter[] arrPara = new SqlParameter[4];
                arrPara[0] = new SqlParameter("@LOAIP", SqlDbType.NVarChar, 5);
                arrPara[0].Value = pLoaiPhieu;
                arrPara[1] = new SqlParameter("@TUNGAY", SqlDbType.NVarChar, 15);
                arrPara[1].Value = pTuNgay;
                arrPara[2] = new SqlParameter("@DENNGAY", SqlDbType.NVarChar, 15);
                arrPara[2].Value = pDenNgay;
                arrPara[3] = new SqlParameter("@NGUOIDUNG", SqlDbType.NVarChar, 50);
                arrPara[3].Value = MTGlobal.MT_USER_LOGIN;
                oTblCX = new MTSQLServer().wRead("NX_shwChanhxeList", arrPara);

                grdPhieu.DataSource = oTblCX;
                SysPar.SetGridReadOnly(true, gvPhieu);
            }
            catch { }
        }
        private void BindDataCT(String mPhieuID)
        {
            try
            {
                String mSql = String.Format("SELECT A.*,B.Tensp,B.Dvt,B.Quycach FROM NX_CHANHXECT A LEFT JOIN DM_SANPHAM B ON A.Masp=B.Masp WHERE Chanhxeid='{0}' order by Chanhxectid asc", mPhieuID);
                DataTable oTblNXCT = new MTSQLServer().wRead(mSql, null, false);
                grdPhieuCT.DataSource = oTblNXCT;
                SysPar.SetGridReadOnly(true, gvPhieuCT);
            }
            catch { }
        }

        private void fChitietPhieu(bool isNew = false)
        {
            try
            {
                if (gvPhieu.FocusedRowHandle < 0)
                {
                    pPhieuID = "";
                }
                else
                {
                    try
                    {
                        pPhieuID = gvPhieu.GetRowCellValue(gvPhieu.FocusedRowHandle, colChanhxeid).ToString();
                    }
                    catch { }
                }
                if (isNew == false && (pPhieuID == "" || gvPhieu.DataRowCount <= 0))
                {
                    isNew = true;
                }

                CX_PhieuCX ofrmCX = new CX_PhieuCX(pPhieuID, this.pLoaiPhieu, this.pTuNgay, this.pDenNgay, MTROLE, isNew);
                ofrmCX.ShowDialog();
                BindData();
            }
            catch (Exception ex) { Utils.showMessage(ex.Message.ToString(), "Thông báo lỗi"); }
        }

        private void grdPhieu_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    fChitietPhieu(true);
                    break;

                case Keys.F6:
                    fChitietPhieu();
                    break;

                case Keys.F7:
                    if (pPhieuID == "")
                    {
                        Utils.showMessage("Bạn chưa chọn phiếu để in...", "Lưu ý");
                    }
                    new MTReport().rptNX_Chanhxe(pPhieuID);
                    break;

                case Keys.F8:
                    try
                    {
                        this.Close();
                    }
                    catch { }
                    break;
            }
        }

        private void gvPhieu_DoubleClick(object sender, EventArgs e)
        {
            fChitietPhieu();
        }

        private void gvPhieu_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (gvPhieu.FocusedRowHandle < 0)
                {
                    return;
                }
                pPhieuID = gvPhieu.GetRowCellValue(gvPhieu.FocusedRowHandle, colChanhxeid).ToString();
                if (pPhieuID != "")
                {
                    BindDataCT(pPhieuID);
                }
            }
            catch (Exception ex) { ex.Data.Clear(); }
        }
    }
}
