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
    public partial class HH_PhieuNhap : Form
    {
        private DataTable oTblNX;
        private String pPhieuID = "";
        private String pLoaiPhieu = "";
        private String pTuNgay = "";
        private String pDenNgay = "";
        private MTGlobal.MT_ROLE mActRole;
        DevExpress.Utils.WaitDialogForm Dlg;

        public HH_PhieuNhap()
        {
            InitializeComponent();
            Dlg = PosMiso.Model.Utils.shwWait();
            try
            {

                pLoaiPhieu = MTGlobal.PN;
                pTuNgay = MTGlobal.MT_TUNGAY;
                pDenNgay = MTGlobal.MT_DENNGAY;
                BindData();
            }
            catch { }
            Utils.closeWait(Dlg);
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
                oTblNX = new MTSQLServer().wRead("NX_shwPhieuList", arrPara);

                grdPhieuNhap.DataSource = oTblNX;
                SysPar.SetGridReadOnly(true, gvPhieuNhap);
            }
            catch { }
        }
        private void BindDataCT(String mPhieuID)
        {
            try
            {
                String mSql = String.Format("SELECT * FROM NX_PHIEUNXCT where phieunxid='{0}' ORDER BY Phieunxctid asc", mPhieuID);
                DataTable oTblNXCT = new MTSQLServer().wRead(mSql, null, false);
                grdPhieuNXCT.DataSource = oTblNXCT;
                SysPar.SetGridReadOnly(true, gvPhieuNXCT);
            }
            catch { }
        }

        private void grdPhieuNhap_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    //cmdAdd_Click(sender, e);
                    break;

                case Keys.F6:
                    fChitietPhieu();
                    break;

                case Keys.F7:
                    if (pPhieuID == "")
                    {
                        Utils.showMessage("Bạn chưa chọn phiếu để in...", "Lưu ý");
                    }
                    if (pLoaiPhieu == MTGlobal.PN)
                    {
                        new MTReport().rptNX_Phieunhap(pPhieuID);
                    }
                    else
                    {
                        new MTReport().rptNX_Phieuxuat(pPhieuID);
                    }
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

        private void fChitietPhieu(bool isNew = false)
        {
            try
            {
                if (gvPhieuNhap.FocusedRowHandle < 0)
                {
                    pPhieuID = "";
                }
                else
                {
                    try
                    {
                        DataRow dataRow = gvPhieuNhap.GetDataRow(gvPhieuNhap.FocusedRowHandle);

                        if (dataRow != null)
                        {
                            pPhieuID = dataRow["Phieunxid"].ToString();
                        }
                    }
                    catch { }
                }

                if (isNew == false && (pPhieuID == "" || gvPhieuNhap.DataRowCount <= 0))
                {
                    isNew = true;
                }


                if (pLoaiPhieu == MTGlobal.PN)
                {
                    NX_PhieuNhap ofrmPN = new NX_PhieuNhap(pPhieuID, this.pLoaiPhieu, this.pTuNgay, this.pDenNgay, mActRole, isNew);
                    ofrmPN.ShowDialog();
                    BindData();
                }
                else if (pLoaiPhieu == MTGlobal.PX)
                {
                    //NX_PhieuXuat ofrmPX = new NX_PhieuXuat(pPhieuID, this.pLoaiPhieu, this.pTuNgay, this.pDenNgay, mActRole, isNew);
                    //ofrmPX.ShowDialog();
                    BindData();
                }
            }
            catch (Exception ex) { Utils.showMessage(ex.Message.ToString(), "Thông báo lỗi"); }
        }


        private void gvPhieuNhap_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataRow dataRow = gvPhieuNhap.GetDataRow(e.RowHandle);

                if (dataRow != null)
                {
                    pPhieuID = dataRow["Phieunxid"].ToString();
                    BindDataCT(pPhieuID);
                }
            }
            catch (Exception ex) { ex.Data.Clear(); }
        }

        private void gvPhieuNhap_DoubleClick(object sender, EventArgs e)
        {
            fChitietPhieu();
        }
    }
}
