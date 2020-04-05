using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class CX_PhieuCX : Form
    {
        MTGlobal.MT_ROLE pACT_ROLE;
        private MTGlobal.MT_BUTTONACTION MTButton;

        private string pPhieuID = "";
        private string pDenNgay = "";
        private string pTuNgay = "";
        private string pLoaiPhieu = "PN";

        private DataTable otblCX = null;
        private DataTable otblCXCT = null;
        private bool isEdit = false;
        DevExpress.Utils.WaitDialogForm Dlg;

        private DataTable otblSP = null;
        private DataTable otblKH = null;
        private DataTable otblXe = null;

        public CX_PhieuCX()
        {
            InitializeComponent();
        }

        public CX_PhieuCX(String mPhieuID, String mLoaiPhieu, String mTuNgay, String mDenNgay, MTGlobal.MT_ROLE mActRole, bool isAddNew = false)
        {
            InitializeComponent();

            this.pPhieuID = mPhieuID;
            this.pTuNgay = mTuNgay == "" ? DateTime.Now.ToShortDateString() : mTuNgay;
            this.pDenNgay = mDenNgay == "" ? DateTime.Now.ToShortDateString() : mDenNgay;
            this.pLoaiPhieu = mLoaiPhieu;
            this.pACT_ROLE = mActRole;

            Dlg = Utils.shwWait();
            setUserRight();
            loadCustomerToLookupEdit();
            loadCarToLookupEdit();
            if (isAddNew)
            {
                fdoAdd();
            }
            else
            {
                BindData();
                SysPar.SetGridReadOnly(true, gvPhieu);
                setReadOnly(true);
            }
            System.Threading.Thread oThreSP = new System.Threading.Thread(LoadSanPham);
            oThreSP.Start();

            Utils.closeWait(Dlg);
        }

        private void setUserRight()
        {
            this.cmdAdd.Enabled = pACT_ROLE.isAdd;
            this.cmdEdit.Enabled = pACT_ROLE.isEdit;
            this.cmdDel.Enabled = pACT_ROLE.isDel;
            MTButton.cmdAdd = this.cmdAdd;
            MTButton.cmdEdit = this.cmdEdit;
            MTButton.cmdDel = this.cmdDel;
            MTButton.cmdSave = this.cmdSave;
            MTButton.cmdAbort = this.cmdAbort;
            MTGlobal.SetButtonAction(pACT_ROLE, MTButton, "INIT");
        }

        private void setReadOnly(bool isReadonly = false)
        {
            dtpNgaylap.Enabled = !isReadonly;
            dtpNgayPS.Enabled = !isReadonly;

            txtTrongluong.ReadOnly = isReadonly;
            txtChiphi.ReadOnly = isReadonly;
            cbThanhtoan.Enabled = !isReadonly;
            txtMadv.Enabled = !isReadonly;
            txtTendonvi.ReadOnly = isReadonly;
            txtDienthoai.ReadOnly = isReadonly;
            txtDiachi.ReadOnly = isReadonly;
            txtSoxe.Enabled = !isReadonly;
            txtLoaixe.ReadOnly = isReadonly;
            txtTaixe.ReadOnly = isReadonly;
            txtDienthoaiXe.ReadOnly = isReadonly;
            txtGhichu.ReadOnly = isReadonly;
        }

        private void loadCustomerToLookupEdit()
        {
            String mSql = String.Format("SELECT * FROM DM_KHACHHANG");
            otblKH = new MTSQLServer().wRead(mSql, null, false);
            txtMadv.Properties.DataSource = otblKH;
            txtMadv.Properties.ValueMember = "Makh";
            txtMadv.Properties.DisplayMember = "Makh";
            txtMadv.Properties.NullText = "Chọn khách hàng";
        }

        private void loadCarToLookupEdit()
        {
            String mSql = String.Format("SELECT * FROM DM_XE");
            otblXe = new MTSQLServer().wRead(mSql, null, false);
            txtSoxe.Properties.DataSource = otblXe;
            txtSoxe.Properties.ValueMember = "Soxe";
            txtSoxe.Properties.DisplayMember = "Soxe";
            txtSoxe.Properties.NullText = "Chọn xe";
        }

        private void LoadSanPham()
        {
            try
            {
                String mSql = "SELECT Maspid,Manhomspid,Masp,Tensp,Dvt,Quycach,Quydoikgl,Quydoithung,Nhacungcap FROM DM_SANPHAM with(nolock) order by Masp asc";
                otblSP = new MTSQLServer().wRead(mSql, null, false);
                loadProductToLookupEdit(otblSP);
            }
            catch (Exception ex) { }
        }

        private void loadProductToLookupEdit(DataTable otblSP)
        {
            repositoryItem.DataSource = otblSP;
            repositoryItem.ValueMember = "Masp";
            repositoryItem.DisplayMember = "Masp";
            repositoryItem.NullText = "";
            colMasp.ColumnEdit = repositoryItem;
        }

        private void BindData(bool isDetailOnly = false)
        {
            try
            {
                if (isDetailOnly)
                {
                    otblCXCT = new MTSQLServer().wRead(String.Format("SELECT A.*,B.Tensp,B.Dvt,B.Quycach FROM NX_CHANHXECT A LEFT JOIN DM_SANPHAM B ON A.Masp=B.Masp WHERE Chanhxeid='{0}' ORDER BY Chanhxectid ASC", pPhieuID), null, false);
                    grdPhieu.DataSource = otblCXCT;
                    SysPar.SetGridReadOnly(false, gvPhieu);
                }
                else
                {
                    txtTrongluong.Text = "";
                    txtChiphi.Text = "";
                    cbThanhtoan.Text = "";
                    txtMadv.Text = "";
                    txtTendonvi.Text = "";
                    txtDienthoai.Text = "";
                    txtDiachi.Text = "";
                    txtSoxe.Text = "";
                    txtLoaixe.Text = "";
                    txtTaixe.Text = "";
                    txtDienthoaiXe.Text = "";
                    txtGhichu.Text = "";
                    if (pPhieuID != "")
                    {
                        String mSql = String.Format("SELECT * FROM NX_CHANHXE WHERE Chanhxeid='{0}'", pPhieuID);
                        otblCX = new MTSQLServer().wRead(mSql, null, false);
                        if (otblCX != null)
                        {
                            foreach (DataRow vR in otblCX.Rows)
                            {
                                txtSophieu.Text = vR["Sophieu"].ToString();
                                dtpNgaylap.EditValue = vR["Ngayct"].ToString() != "" ? Convert.ToDateTime(vR["Ngayct"].ToString()).ToShortDateString() : "";
                                dtpNgayPS.EditValue = vR["Ngayps"].ToString() != "" ? Convert.ToDateTime(vR["Ngayps"].ToString()).ToShortDateString() : "";

                                txtTrongluong.Text = vR["Trongluong"].ToString();
                                txtChiphi.Text = vR["Chiphi"].ToString();
                                cbThanhtoan.Text = vR["HTThanhtoan"].ToString();
                                txtMadv.Text = vR["Makh"].ToString();
                                txtTendonvi.Text = vR["Tenkh"].ToString();
                                txtDienthoai.Text = vR["Dienthoai"].ToString();
                                txtDiachi.Text = vR["Diachi"].ToString();
                                txtSoxe.Text = vR["Soxe"].ToString();
                                txtLoaixe.Text = vR["Loaixe"].ToString();
                                txtTaixe.Text = vR["Taixe"].ToString();
                                txtDienthoaiXe.Text = vR["Dienthoaixe"].ToString();
                                txtGhichu.Text = vR["Ghichu"].ToString();
                            }
                        }

                    }

                    otblCXCT = new MTSQLServer().wRead(String.Format("SELECT A.*,B.Tensp,B.Dvt,B.Quycach FROM NX_CHANHXECT A LEFT JOIN DM_SANPHAM B ON A.Masp=B.Masp WHERE Chanhxeid='{0}' ORDER BY Chanhxectid ASC", pPhieuID), null, false);
                    grdPhieu.DataSource = otblCXCT;
                    SysPar.SetGridReadOnly(false, gvPhieu);
                }
            }
            catch { }
        }

        private void fQuydoithung(int iRowHander)
        {
            try
            {
                String sMasp = "";
                sMasp = gvPhieu.GetRowCellValue(iRowHander, colMasp).ToString();
                if (otblSP != null && otblSP.Rows.Count > 0)
                {
                    DataRow[] vRow = otblSP.Select(string.Format("Masp='{0}'", sMasp));
                    if (vRow.Length > 0)
                    {
                        Double dSLThung = 0, dQDThung = 0, dSLQD = 0;
                        Double.TryParse(vRow[0]["Quydoithung"].ToString(), out dQDThung);
                        Double.TryParse(gvPhieu.GetRowCellValue(iRowHander, colSLThung).ToString(), out dSLThung);
                        dSLQD = Math.Round(dSLThung * dQDThung, 0, MidpointRounding.AwayFromZero);
                        gvPhieu.SetRowCellValue(iRowHander, colSoluong, dSLQD);
                    }
                }
            }
            catch { }
        }

        private bool fValidate()
        {
            if (txtSophieu.Text == "")
            {
                Utils.showMessage("Số phiếu chưa được khởi tạo..", "Thông báo");
                txtSophieu.Focus();
                return false;
            }
            if (dtpNgaylap.Text == "")
            {
                Utils.showMessage("Ngày chứng từ không thể bỏ trống..", "Thông báo");
                dtpNgaylap.Focus();
                return false;
            }
            if (txtMadv.Text == "")
            {
                Utils.showMessage("Bạn chưa nhập mã khách hàng..", "Thông báo");
                txtMadv.Focus();
                return false;
            }

            if (txtChiphi.Text == "" || txtChiphi.Text == "0")
            {
                Utils.showMessage("Bạn chưa nhập chi phí gửi..", "Thông báo");
                txtChiphi.Focus();
                return false;
            }

            if (txtSoxe.Text == "")
            {
                Utils.showMessage("Bạn chưa nhập mã khách hàng..", "Thông báo");
                txtSoxe.Focus();
                return false;
            }
            if (gvPhieu.RowCount <= 0)
            {
                Utils.showMessage("Bạn chưa nhập chi tiết hàng hóa..", "Thông báo");
                gvPhieu.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gvPhieu.FocusedRowHandle = GridControl.NewItemRowHandle;
                gvPhieu.FocusedColumn = gvPhieu.Columns[0];
                gvPhieu.ShowEditor();
                return false;
            }
            return true;
        }

        private void fdoAdd()
        {
            try
            {
                int mMM = int.Parse(Convert.ToDateTime(pDenNgay).Month.ToString().PadLeft(2, '0'));
                int mYY = int.Parse(Convert.ToDateTime(pDenNgay).Year.ToString());
                pPhieuID = MTGlobal.GetNewID();
                txtSophieu.Text = MTGlobal.GetSophieu(MTGlobal.MT_KYHIEU_CUAHANG, pLoaiPhieu, mMM, mYY, MTGlobal.MT_USER_LOGIN).ToString();
                dtpNgaylap.Text = DateTime.Now.ToShortDateString();
                dtpNgayPS.Text = DateTime.Now.ToShortDateString();

                BindData();
                if (SysPar.SetGridReadOnly(false, gvPhieu))
                {
                    gvPhieu.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                    gvPhieu.FocusedRowHandle = GridControl.NewItemRowHandle;
                    gvPhieu.FocusedColumn = gvPhieu.Columns[0];
                    gvPhieu.ShowEditor();
                }

                setReadOnly(false);
                MTGlobal.SetButtonAction(pACT_ROLE, MTButton, "ADD");
                txtSophieu.Focus();
                isEdit = true;
            }
            catch (Exception ex) { Utils.showMessage(ex.Message.ToString(), "Thông báo lỗi"); }
        }

        private void fdoEdit()
        {
            setReadOnly(false);
            MTGlobal.SetButtonAction(pACT_ROLE, MTButton, "EDIT");
            isEdit = true;
            txtSophieu.Focus();
            if (SysPar.SetGridReadOnly(false, gvPhieu))
            {
                gvPhieu.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gvPhieu.FocusedRowHandle = GridControl.NewItemRowHandle;
                gvPhieu.FocusedColumn = gvPhieu.Columns[0];
                gvPhieu.ShowEditor();
            }
        }
        private void fdoSave()
        {
            if (fValidate())
            {
                DataTable tmpCX = new modChanhxe().dtPhieu();
                DataRow vR = tmpCX.NewRow();

                Double dTrongluong = 0, dChiphi = 0;
                Double.TryParse(txtTrongluong.Text, out dTrongluong);
                Double.TryParse(txtChiphi.Text, out dChiphi);

                vR["Chanhxeid"] = pPhieuID;
                vR["Sophieu"] = txtSophieu.Text.ToUpper();
                vR["Loaiphieu"] = this.pLoaiPhieu;
                vR["Ngayct"] = Convert.ToDateTime(dtpNgaylap.Text);
                vR["Ngayps"] = Convert.ToDateTime(dtpNgayPS.Text);

                vR["Makh"] = txtMadv.Text;
                vR["Tenkh"] = txtTendonvi.Text;
                vR["Diachi"] = txtDiachi.Text;
                vR["Dienthoai"] = txtDienthoai.Text;

                vR["Soxe"] = txtSoxe.Text;
                vR["Loaixe"] = txtLoaixe.Text;
                vR["Taixe"] = txtTaixe.Text;
                vR["Dienthoaixe"] = txtDienthoaiXe.Text;

                vR["Trongluong"] = Math.Round(dTrongluong, 0, MidpointRounding.AwayFromZero);
                vR["Chiphi"] = Math.Round(dChiphi, 0, MidpointRounding.AwayFromZero);
                vR["HTThanhtoan"] = cbThanhtoan.Text;
                vR["Trangthai"] = 0;
                vR["Ghichu"] = txtGhichu.Text;

                tmpCX.Rows.Add(vR);
                tmpCX.AcceptChanges();

                DataTable tmpCXCT = new modChanhxe().dtPhieuCT();
                //gvPhieu.CommitEditing();
                gvPhieu.CloseEditor();
                otblCXCT.AcceptChanges();
                foreach (DataRow sR in otblCXCT.Rows)
                {
                    DataRow cR = tmpCXCT.NewRow();
                    cR["Chanhxectid"] = sR["Chanhxectid"];
                    cR["Chanhxeid"] = pPhieuID;
                    cR["Maspid"] = sR["Maspid"];
                    cR["Masp"] = sR["Masp"];
                    cR["SLThung"] = sR["SLThung"];
                    cR["Soluong"] = sR["Soluong"];
                    cR["Ghichu"] = sR["Ghichu"];
                    tmpCXCT.Rows.Add(cR);
                }
                tmpCXCT.AcceptChanges();

                String Rs = new modChanhxe().SavePhieu(tmpCX, tmpCXCT);
                if (Rs == "")
                {
                    BindData(true);
                    setReadOnly(true);
                    MTGlobal.SetButtonAction(pACT_ROLE, MTButton, "SAVE");
                    SysPar.SetGridReadOnly(true, gvPhieu);
                    isEdit = false;
                }
                else
                {
                    Utils.showMessage(Rs, "Thông báo");
                }
            }
        }

        private void fdoDel()
        {
            if (pPhieuID == ""){
                Utils.showMessage("Bạn chưa chọn phiếu cần xóa..", "Lưu ý");
                return;
            }
            if (Utils.ConfirmMessage("Bạn có chắc muốn xóa phiếu này?", "Xác nhận"))
            {
                if (new modChanhxe().DelPhieu(pPhieuID))
                {
                    pPhieuID = "";
                    BindData();
                    setReadOnly(true);
                    MTGlobal.SetButtonAction(pACT_ROLE, MTButton, "ABORT");
                }
                else
                {
                    Utils.showMessage("Không thể xóa phiếu, vui lòng kiểm tra lại", "Thông báo");
                }
            }
        }

        private void fdoAbort()
        {
            BindData();
            setReadOnly(true);
            MTGlobal.SetButtonAction(pACT_ROLE, MTButton, "ABORT");      
        }

        private void fdoPrint()
        {
            if (pPhieuID == "")
            {
                Utils.showMessage("Bạn chưa chọn phiếu để in...", "Lưu ý");
            }
            new MTReport().rptNX_Chanhxe(pPhieuID);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvPhieu_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            try
            {
                gvPhieu.SetRowCellValue(e.RowHandle, colChanhxectid, MTGlobal.GetNewID());
                gvPhieu.SetRowCellValue(e.RowHandle, colChanhxeid, pPhieuID);
            }
            catch { }
        }

        private void gvPhieu_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void gvPhieu_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (isEdit == false) { return; }
            if (gvPhieu.FocusedColumn.FieldName == "SLThung" && e.Column.Name == "colSoThung")
            {
                fQuydoithung(e.RowHandle);
            }
        }

        private void gvPhieu_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (e.ErrorText!="")
            {
                Utils.showMessage(e.ErrorText, "Lưu ý", "ERR");
            }
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gvPhieu_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (e.Row == null) return;
            if (gvPhieu.GetRowCellValue(e.RowHandle, colMasp) == null || gvPhieu.GetRowCellValue(e.RowHandle, colMasp).ToString() == "")
            {
                e.ErrorText = "Bạn chưa nhập mã hàng hóa..";
                e.Valid = false;
                return;
            }

            double dSL = 0;
            try
            {
                Double.TryParse(gvPhieu.GetRowCellValue(e.RowHandle, colSoluong).ToString(), out dSL);
            }
            catch { }
            if (dSL <= 0)
            {
                e.ErrorText = "Bạn chưa nhập đơn giá hàng hóa..";
                e.Valid = false;
                return;
            }  
        }

        private void grdPhieu_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                fdoAdd();
            }
            else if (e.KeyCode == Keys.F3)
            {
                fdoEdit();
            }
            else if (e.KeyCode == Keys.F5)
            {
                fdoSave();
            }
            else if (e.KeyCode == Keys.F7)
            {
                fdoPrint();
            }
            else if (e.KeyCode == Keys.F8)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                fdoAbort();
            } 
        }

        private void gvPhieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (isEdit == false) { return; }
            if (e.KeyCode == Keys.Enter)
            {
                var editObj = ((DevExpress.XtraGrid.Views.Grid.GridView)(sender)).EditingValue;
                if (gvPhieu.FocusedColumn.FieldName == "Masp" && gvPhieu.FocusedColumn.Name == "colMasp")
                {
                    if (gvPhieu.GetFocusedRowCellValue(colMasp) == null)// || gvPhieu.GetFocusedRowCellValue(colMasp).ToString() == "")
                    {
                        gvPhieu.FocusedColumn = colMasp;
                        return;
                    }

                    String sMasp = editObj != null ? editObj.ToString() : "";
                    if (sMasp == null || sMasp == "")
                    {
                        gvPhieu.FocusedColumn = colMasp;
                        return;
                    }

                    if (sMasp != "")
                    {
                        double dSL = 0;
                        try
                        {
                            double.TryParse(gvPhieu.GetRowCellValue(gvPhieu.FocusedRowHandle, colSoluong).ToString(), out dSL);
                            if (dSL == 0) { dSL = 1; }
                        }
                        catch { dSL = 1; }

                        if (otblSP != null && otblSP.Rows.Count > 0)
                        {
                            DataRow[] vRow = otblSP.Select(string.Format("Masp='{0}'", sMasp));
                            if (vRow.Length > 0)
                            {
                                gvPhieu.SetRowCellValue(gvPhieu.FocusedRowHandle, colTensp, vRow[0]["Tensp"].ToString());
                                gvPhieu.SetRowCellValue(gvPhieu.FocusedRowHandle, colDvt, vRow[0]["Dvt"].ToString());
                                gvPhieu.SetRowCellValue(gvPhieu.FocusedRowHandle, colQuycach, vRow[0]["Quycach"].ToString());
                                gvPhieu.SetRowCellValue(gvPhieu.FocusedRowHandle, colSoluong, dSL);
                            }
                        }

                        gvPhieu.CloseEditor();
                        gvPhieu.ShowEditor();
                        gvPhieu.SetRowCellValue(gvPhieu.FocusedRowHandle, colMasp, sMasp);
                        //tblView.PostEditor();
                    }
                }
            }

            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    if (gvPhieu.GetFocusedRowCellValue(colChanhxectid) == null || gvPhieu.GetFocusedRowCellValue(colChanhxectid).ToString() == "")
                    {
                        e.Handled = true;
                        return;
                    }
                    if (Utils.ConfirmMessage(String.Format("Bạn có chắc muốn xóa {0} không ?", gvPhieu.GetRowCellValue(gvPhieu.FocusedRowHandle, colMasp).ToString()), "Xác nhận xóa") == true)
                    {
                        gvPhieu.DeleteRow(gvPhieu.FocusedRowHandle);
                    }
                }
                catch (Exception ex) { ex.Data.Clear(); }
            }
        }

        private void txtMadv_EditValueChanged(object sender, EventArgs e)
        {
            String makh = txtMadv.Text;
            if (makh == null || makh == "")
            {
                txtMadv.Focus();
                return;
            }

            DataRow[] vRow = otblKH.Select(string.Format("Makh='{0}'", makh));
            if (vRow.Length > 0)
            {
                String tenkh = vRow[0]["Tenkh"].ToString();
                String dienthoai = vRow[0]["Dienthoai"].ToString();
                String diachi = vRow[0]["Diachi"].ToString();
                txtTendonvi.Text = tenkh;
                txtDienthoai.Text = dienthoai;
                txtDiachi.Text = diachi;
            }
        }

        private void txtSoxe_EditValueChanged(object sender, EventArgs e)
        {
            String soxe = txtSoxe.Text;
            if (soxe == null || soxe == "")
            {
                txtSoxe.Focus();
                return;
            }

            DataRow[] vRow = otblXe.Select(string.Format("Soxe='{0}'", soxe));
            if (vRow.Length > 0)
            {
                txtLoaixe.Text = vRow[0]["Loaixe"].ToString();
                txtTaixe.Text = vRow[0]["Taixe"].ToString();
                txtDienthoaiXe.Text = vRow[0]["Dienthoai"].ToString();
            }
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            fdoPrint();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            fdoAdd();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            fdoEdit();
        }

        private void cmdDel_Click(object sender, EventArgs e)
        {
            fdoDel();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            fdoSave();
        }

        private void cmdAbort_Click(object sender, EventArgs e)
        {
            fdoAbort();
        }
    }
}
