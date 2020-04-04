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
    public partial class BH_PhieuBH : Form
    {
        private MTGlobal.MT_ROLE MTROLE;
        private MTGlobal.MT_BUTTONACTION MTButton;

        private DataTable oTblNX;
        private String pPhieuID = "";
        private String pLoaiPhieu = "";
        private String pTuNgay = "";
        private String pDenNgay = "";
        private String pCa = "";
        private String pQuay = "";

        DevExpress.Utils.WaitDialogForm Dlg;

        public BH_PhieuBH()
        {
            InitializeComponent();
            SysPar.SetGridReadOnly(true, gvPhieu);

            try
            {
                Dlg= Utils.shwWait();
                pLoaiPhieu = MTGlobal.MT_LOAIP;
                pTuNgay = MTGlobal.MT_TUNGAY;
                pDenNgay = MTGlobal.MT_DENNGAY;
                pCa = MTGlobal.MT_CA;
                pQuay = MTGlobal.MT_QUAY;

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
                SqlParameter[] arrPara = new SqlParameter[6];
                arrPara[0] = new SqlParameter("@LOAIP", SqlDbType.NVarChar, 5);
                arrPara[0].Value = pLoaiPhieu;
                arrPara[1] = new SqlParameter("@TUNGAY", SqlDbType.NVarChar, 15);
                arrPara[1].Value = pTuNgay;
                arrPara[2] = new SqlParameter("@DENNGAY", SqlDbType.NVarChar, 15);
                arrPara[2].Value = pDenNgay;
                arrPara[3] = new SqlParameter("@CA", SqlDbType.NVarChar, 15);
                arrPara[3].Value = pCa;
                arrPara[4] = new SqlParameter("@QUAY", SqlDbType.NVarChar, 15);
                arrPara[4].Value = pQuay;
                arrPara[5] = new SqlParameter("@NGUOIDUNG", SqlDbType.NVarChar, 50);
                arrPara[5].Value = MTGlobal.MT_USER_LOGIN;
                oTblNX = new MTSQLServer().wRead("BH_shwPhieuBHList", arrPara);

                grdPhieu.DataSource = oTblNX;
                SysPar.SetGridReadOnly(true, gvPhieu);
            }
            catch { }
        }
        private void BindDataCT(String mPhieuID)
        {
            try
            {
                String mSql = String.Format("SELECT * FROM BH_PHIEUBHCT where Phieubhid='{0}' AND ISNULL(Quatang,0)=0 order by Phieubhctid ASC", mPhieuID);
                DataTable oTblNXCT = new MTSQLServer().wRead(mSql, null, false);
                grdPhieuCT.DataSource = oTblNXCT;
                SysPar.SetGridReadOnly(true, gvPhieuCT);
            }
            catch { }
        }
        private void BindDataKM(String mPhieuID)
        {
            try
            {
                String mSql = String.Format("SELECT * FROM BH_PHIEUBHCT where Phieubhid='{0}' AND ISNULL(Quatang,0)=1 order by Phieubhctid ASC", mPhieuID);
                DataTable oTblNXCT = new MTSQLServer().wRead(mSql, null, false);
                grdPhieuKM.DataSource = oTblNXCT;
                SysPar.SetGridReadOnly(true, gvPhieuKM);
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
                        pPhieuID = gvPhieu.GetRowCellValue(gvPhieu.FocusedRowHandle, colPhieubhid).ToString();
                    }
                    catch { }
                }

                if (isNew == false && (pPhieuID == "" || gvPhieu.DataRowCount <= 0))
                {
                    isNew = true;
                }

                BH_PhieuBHFrm ofrmPN = new BH_PhieuBHFrm(pPhieuID, this.pLoaiPhieu, this.pTuNgay, this.pDenNgay, MTROLE, isNew);
                ofrmPN.ShowDialog();
                BindData();
            }
            catch { }
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
                        Utils.showMessage("Bạn chưa chọn phiếu để in..", "Lưu ý");
                        return;
                    }
                    new MTReport().rptBH_InBill(pPhieuID);
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

        private void gvPhieu_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (gvPhieu.FocusedRowHandle < 0)
                {
                    return;
                }
                pPhieuID = gvPhieu.GetRowCellValue(gvPhieu.FocusedRowHandle, colPhieubhid).ToString();
                if (pPhieuID != "")
                {
                    BindDataCT(pPhieuID);
                    BindDataKM(pPhieuID);
                }
            }
            catch (Exception ex) { ex.Data.Clear(); } 
        }

        private void gvPhieu_DoubleClick(object sender, EventArgs e)
        {
            fChitietPhieu();
        }
    }
}
