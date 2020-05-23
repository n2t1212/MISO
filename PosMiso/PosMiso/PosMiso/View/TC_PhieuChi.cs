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
    public partial class TC_PhieuChi : Form
    {
        private MTGlobal.MT_ROLE MTROLE;
        private MTGlobal.MT_BUTTONACTION MTButton;

        private String pPhieuID = "";
        private String pLoaiPhieu = "";
        private String pTuNgay = "";
        private String pDenNgay = "";
        DevExpress.Utils.WaitDialogForm Dlg;

        private DataTable oTblTC = null;

        public TC_PhieuChi()
        {
            InitializeComponent();

            Dlg = Utils.shwWait();
            try
            {
                pLoaiPhieu = MTGlobal.PC;
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
                oTblTC = new MTSQLServer().wRead("TC_shwPhieuTCList", arrPara);

                grdPhieuThu.DataSource = oTblTC;
                SysPar.SetGridReadOnly(true, gvPhieuThu);
            }
            catch { }
        }

        private void BindDataCT(String mPhieuID)
        {
            try
            {
                String mSql = String.Format("SELECT * FROM TC_PHIEUTCCT where phieutcid='{0}' ORDER BY Phieutcctid asc", mPhieuID);
                DataTable oTblNXCT = new MTSQLServer().wRead(mSql, null, false);
                grdPhieuThuCT.DataSource = oTblNXCT;
                SysPar.SetGridReadOnly(true, gvPhieuThuCT);
            }
            catch { }
        }

        private void fChitietPhieu(bool isNew = false)
        {
            try
            {
                if (gvPhieuThu.FocusedRowHandle < 0)
                {
                    pPhieuID = "";
                }
                else
                {
                    try
                    {
                        pPhieuID = gvPhieuThu.GetRowCellValue(gvPhieuThu.FocusedRowHandle, colPhieutcid).ToString();
                    }
                    catch { }
                }

                if (isNew == false && (pPhieuID == "" || gvPhieuThu.DataRowCount <= 0))
                {
                    isNew = true;
                }


                if (pLoaiPhieu == MTGlobal.PC)
                {
                    TC_PhieuThuFrm ofrmPT = new TC_PhieuThuFrm(pPhieuID, this.pLoaiPhieu, this.pTuNgay, this.pDenNgay, MTROLE, isNew);
                    ofrmPT.ShowDialog();
                    BindData();
                }
            }
            catch (Exception ex) { Utils.showMessage(ex.Message.ToString(), "Thông báo lỗi"); }
        }

        private void grdPhieuThu_KeyDown(object sender, KeyEventArgs e)
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
                    if (pLoaiPhieu == MTGlobal.PT)
                    {

                    }
                    else
                    {
                        //
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

        private void gvPhieuThu_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataRow dataRow = gvPhieuThu.GetDataRow(e.RowHandle);

                if (dataRow != null)
                {
                    pPhieuID = dataRow["Phieutcid"].ToString();
                    BindDataCT(pPhieuID);
                }
            }
            catch (Exception ex) { ex.Data.Clear(); }
        }

        private void gvPhieuThu_DoubleClick(object sender, EventArgs e)
        {
            fChitietPhieu();
        }
    }
}
