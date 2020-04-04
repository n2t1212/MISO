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
    public partial class TC_PhieuThuFrm : Form
    {
        MTGlobal.MT_ROLE pACT_ROLE;
        private MTGlobal.MT_BUTTONACTION MTButton;

        private string pPhieuTCID = "";
        private string pDenNgay = "";
        private string pTuNgay = "";
        private string pLoaiPhieu = "";

        private DataTable otblPTC = null;
        private DataTable otblPTCCT = null;
        private bool isEdit = false;
        DevExpress.Utils.WaitDialogForm Dlg;

        private DataTable otblKH = null;
        private DataTable otblLydo = null;
        private DataTable otblNV = null;
        private DataTable otblTK = null;

        // TK nợ, TK có
        private String TKNo = "";
        private String TKCo = "";

        public TC_PhieuThuFrm()
        {
            InitializeComponent();
        }

        public TC_PhieuThuFrm(String mPhieuTCID, String mLoaiPhieu, String mTuNgay, String mDenNgay,
            MTGlobal.MT_ROLE mActRole, bool isAddNew = false)
        {
            InitializeComponent();
            this.pPhieuTCID = mPhieuTCID;
            this.pTuNgay = mTuNgay == "" ? DateTime.Now.ToShortDateString() : mTuNgay;
            this.pDenNgay = mDenNgay == "" ? DateTime.Now.ToShortDateString() : mDenNgay;
            this.pLoaiPhieu = mLoaiPhieu;
            this.pACT_ROLE = mActRole;

            lblTitle.Text = mLoaiPhieu == MTGlobal.PT ? "LẬP PHIẾU THU" : "LẬP PHIẾU CHI";

            Dlg = Utils.shwWait();

            setUserRight();
            loadCustomerToLookupEdit();
            loadLydoToLookupEdit();
            loadNhanVienToLookupEdit();
            loadTaiKhoanToLookupEdit();
            if (isAddNew)
            {
                fdoAdd();
            }
            else
            {
                BindData();
                SysPar.SetGridReadOnly(true, gvPhieuThuCT);
                setReadOnly(true);
            }

            Utils.closeWait(Dlg);
        }

        private void setReadOnly(bool isReadOnly)
        {
            cbNguyenTe.Enabled = !isReadOnly;
            txtMaDT.Enabled = !isReadOnly;
            txtTenDoiTuong.Enabled = !isReadOnly;
            txtHoTen.Enabled = !isReadOnly;
            txtDiaChi.Enabled = !isReadOnly;
            txtMaLD.Enabled = !isReadOnly;
            txtLD.Enabled = !isReadOnly;
            txtManv.Enabled = !isReadOnly;
            txtTennv.Enabled = !isReadOnly;
            txtGhiChu.Enabled = !isReadOnly;
            txtSoPhieu.Enabled = !isReadOnly;
            txtSoCT.Enabled = !isReadOnly;
            txtNgayCT.Enabled = !isReadOnly;
            txtNgayPS.Enabled = !isReadOnly;
        }

        private void loadCustomerToLookupEdit()
        {
            String mSql = String.Format("SELECT * FROM DM_KHACHHANG");
            otblKH = new MTSQLServer().wRead(mSql, null, false);
            txtMaDT.Properties.DataSource = otblKH;
            txtMaDT.Properties.ValueMember = "Makh";
            txtMaDT.Properties.DisplayMember = "Makh";
            txtMaDT.Properties.NullText = "Chọn đối tượng";
        }

        private void loadLydoToLookupEdit()
        {
            String mSql = String.Format("SELECT * FROM DM_LYDO");
            otblLydo = new MTSQLServer().wRead(mSql, null, false);
            txtMaLD.Properties.DataSource = otblLydo;
            txtMaLD.Properties.ValueMember = "Mald";
            txtMaLD.Properties.DisplayMember = "Mald";
            txtMaLD.Properties.NullText = "Chọn lý do";
        }

        private void loadNhanVienToLookupEdit()
        {
            String mSql = String.Format("SELECT * FROM DM_NHANVIEN");
            otblNV = new MTSQLServer().wRead(mSql, null, false);
            txtManv.Properties.DataSource = otblNV;
            txtManv.Properties.ValueMember = "Manv";
            txtManv.Properties.DisplayMember = "Manv";
            txtManv.Properties.NullText = "Chọn nhân viên";
            
        }

        private void loadTaiKhoanToLookupEdit()
        {
            String mSql = String.Format("SELECT * FROM DM_TAIKHOAN");
            otblTK = new MTSQLServer().wRead(mSql, null, false);

            repositoryItemTKCo.DataSource = otblTK;
            repositoryItemTKCo.ValueMember = "Matk";
            repositoryItemTKCo.DisplayMember = "Matk";
            repositoryItemTKCo.NullText = "Chọn tài khoản";
            colTKCo.ColumnEdit = repositoryItemTKCo;

            repositoryItemTKNo.DataSource = otblTK;
            repositoryItemTKNo.ValueMember = "Matk";
            repositoryItemTKNo.DisplayMember = "Matk";
            repositoryItemTKNo.NullText = "Chọn tài khoản";
            colTKNo.ColumnEdit = repositoryItemTKNo;
        }

        private void setUserRight()
        {
            this.cmdAdd.Enabled = pACT_ROLE.isAdd;
            this.cmdEdit.Enabled = pACT_ROLE.isEdit;
            this.cmdDel.Enabled = pACT_ROLE.isDel;
            this.cmdPrint.Enabled = pACT_ROLE.isPrint;
            MTButton.cmdAdd = this.cmdAdd;
            MTButton.cmdEdit = this.cmdEdit;
            MTButton.cmdDel = this.cmdDel;
            MTButton.cmdSave = this.cmdSave;
            MTButton.cmdAbort = this.cmdAbort;
            MTButton.cmdPrint = this.cmdPrint;
            MTGlobal.SetButtonAction(pACT_ROLE, MTButton, "INIT");
        }

        private void BindData()
        {
            cbNguyenTe.SelectedIndex = 0;
            txtMaDT.Text = "";
            txtTenDoiTuong.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtMaLD.Text = "";
            txtLD.Text = "";
            txtManv.Text = "";
            txtTennv.Text = "";
            txtGhiChu.Text = "";

            if (pPhieuTCID != "")
            {
                String mSql = String.Format("select A.*, B.Tenkh, B.Diachi, C.Lydo, C.TKNo, C.TKCo, D.Tennv from TC_PHIEUTC A left join DM_KHACHHANG B on A.Madt = B.Makh left join DM_LYDO C on A.Mald = C.Mald left join DM_NHANVIEN D on A.Mant = D.Manv where A.Phieutcid = '{0}'", pPhieuTCID);

                otblPTC = new MTSQLServer().wRead(mSql, null, false);

                if (otblPTC != null)
                {
                    foreach (DataRow vR in otblPTC.Rows)
                    {
                        txtSoPhieu.Text = vR["Sophieu"].ToString();
                        txtMaDT.Text = vR["Madt"].ToString();
                        txtTenDoiTuong.Text = vR["Tenkh"].ToString();
                        txtDiaChi.Text = vR["Diachi"].ToString();
                        txtHoTen.Text = vR["Hoten"].ToString();
                        txtMaLD.Text = vR["Mald"].ToString();
                        txtLD.Text = vR["Lydo"].ToString();
                        txtManv.Text = vR["Mant"].ToString();
                        txtTennv.Text = vR["Tennv"].ToString();
                        txtGhiChu.Text = vR["Ghichu"].ToString();
                        txtSoCT.Text = vR["Soctgoc"].ToString();
                        txtNgayCT.EditValue = vR["Ngayct"].ToString() != "" ? Convert.ToDateTime(vR["Ngayct"].ToString()).ToShortDateString() : "";
                        txtNgayPS.EditValue = vR["Ngayps"].ToString() != "" ? Convert.ToDateTime(vR["Ngayps"].ToString()).ToShortDateString() : "";
                        cbNguyenTe.SelectedValue = vR["Loaitien"].ToString();
                        txtTyGia.Text = vR["Tygia"].ToString();

                        TKNo = vR["TKNo"].ToString();
                        TKCo = vR["TKCo"].ToString();
                    }
                }
            }

            otblPTCCT = new MTSQLServer().wRead(String.Format("SELECT * FROM TC_PHIEUTCCT where Phieutcid='{0}' ORDER BY Phieutcctid asc", pPhieuTCID), null, false);
            grdPhieuThuCT.DataSource = otblPTCCT;
            SysPar.SetGridReadOnly(true, gvPhieuThuCT);
        }

        private void fdoAdd()
        {
            try
            {
                int mMM = int.Parse(Convert.ToDateTime(pDenNgay).Month.ToString().PadLeft(2, '0'));
                int mYY = int.Parse(Convert.ToDateTime(pDenNgay).Year.ToString());
                pPhieuTCID = MTGlobal.GetNewID();
                txtSoPhieu.Text = MTGlobal.GetSophieu(MTGlobal.MT_KYHIEU_CUAHANG, this.pLoaiPhieu, mMM, mYY, MTGlobal.MT_USER_LOGIN).ToString();
                txtNgayCT.Text = DateTime.Now.ToShortDateString();
                txtNgayPS.Text = DateTime.Now.ToShortDateString();

                BindData();
                if (SysPar.SetGridReadOnly(false, gvPhieuThuCT))
                {
                    gvPhieuThuCT.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                    //gvPhieuThuCT.DataSource = new modPhieuNX().dtPhieuNXCT();
                    gvPhieuThuCT.FocusedRowHandle = GridControl.NewItemRowHandle;
                    gvPhieuThuCT.FocusedColumn = gvPhieuThuCT.VisibleColumns[0];
                    gvPhieuThuCT.ShowEditor();
                }

                setReadOnly(false);
                MTGlobal.SetButtonAction(pACT_ROLE, MTButton, "ADD");
                txtSoPhieu.Focus();
                isEdit = true;
            }
            catch (Exception ex) { Utils.showMessage(ex.Message.ToString(), "Thông báo lỗi"); }
        }

        private void fdoEdit()
        {
            setReadOnly(false);
            MTGlobal.SetButtonAction(pACT_ROLE, MTButton, "EDIT");
            isEdit = true;
            txtMaDT.Focus();
            if (SysPar.SetGridReadOnly(false, gvPhieuThuCT))
            {
                gvPhieuThuCT.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                //grdPhieuThuCT.DataSource = new modPhieuTC().dtPhieuTCCT();
                gvPhieuThuCT.FocusedRowHandle = GridControl.NewItemRowHandle;
                gvPhieuThuCT.FocusedColumn = gvPhieuThuCT.VisibleColumns[0];
                gvPhieuThuCT.ShowEditor();
            }
        }

        private void fdoSave()
        {
            Double soTien = 0;
            if (fValidate())
            {
                DataTable tmpTCCT = new modPhieuTC().dtPhieuTCCT();
                var filteredRows = gvPhieuThuCT.DataController.GetAllFilteredAndSortedRows();
                if (filteredRows.Count == 0)
                {
                    return;
                }

                //gvPhieuThuCT.CommitEditing();
                gvPhieuThuCT.CloseEditor();
                otblPTCCT.AcceptChanges();

                foreach (DataRow sR in otblPTCCT.Rows)
                {
                    DataRow cR = tmpTCCT.NewRow();
                    cR["Phieutcctid"] = sR["Phieutcctid"];
                    cR["Phieutcid"] = pPhieuTCID;
                    cR["Macp"] = sR["Macp"];
                    cR["Madt"] = sR["Madt"];
                    cR["Matk"] = sR["Matk"];
                    cR["TKNo"] = sR["TKNo"];
                    cR["TKCo"] = sR["TKCo"];
                    cR["Nguyente"] = sR["Nguyente"];
                    cR["Thanhtien"] = sR["Thanhtien"];
                    cR["Diengiai"] = sR["Diengiai"];
                    cR["SoHD"] = sR["SoHD"];
                    cR["NChono"] = sR["NChono"];

                    soTien += Convert.ToDouble(sR["Thanhtien"]);

                    tmpTCCT.Rows.Add(cR);
                }
                tmpTCCT.AcceptChanges();

                DataTable tmpTC = new modPhieuTC().dtPhieuTC();
                DataRow vR = tmpTC.NewRow();
                vR["Phieutcid"] = pPhieuTCID;
                vR["Mant"] = txtManv.Text;
                vR["Madt"] = txtMaDT.Text.ToUpper();
                vR["Loaiphieu"] = pLoaiPhieu;
                vR["Sophieu"] = txtSoPhieu.Text;
                vR["Ngayct"] = Convert.ToDateTime(txtNgayCT.Text);
                vR["Ngayps"] = Convert.ToDateTime(txtNgayCT.Text);
                vR["Tygia"] = txtTyGia.Text.Length == 0 ? 0 : Double.Parse(txtTyGia.Text);
                vR["Soctgoc"] = txtSoCT.Text;
                vR["TKDu"] = "";
                vR["Nguyente"] = 0;
                vR["Sotien"] = soTien;
                vR["Hoten"] = txtHoTen.Text;
                vR["Nguoilap"] = txtManv.Text;
                vR["Ngaylap"] = DateTime.Now;
                vR["Nguoisua"] = "";
                vR["Ghiso"] = 1;
                vR["Mald"] = txtMaLD.Text;
                vR["Ghichu"] = txtGhiChu.Text;
                vR["Loaitien"] = cbNguyenTe.SelectedItem != null ? cbNguyenTe.SelectedItem.ToString(): "VND";

                tmpTC.Rows.Add(vR);
                tmpTC.AcceptChanges();

                String Rs = new modPhieuTC().SavePhieuTC(tmpTC, tmpTCCT);
                if (Rs == "")
                {
                    setReadOnly(true);
                    MTGlobal.SetButtonAction(pACT_ROLE, MTButton, "SAVE");
                    SysPar.SetGridReadOnly(true, gvPhieuThuCT);
                    isEdit = false;
                }
                else
                {
                    Utils.showMessage(Rs, "Thông báo");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Threading.Thread vThread = new System.Threading.Thread(() =>
            {
                try
                {
                    MTSynData.doSyncPost();
                }
                catch { }
            });
            vThread.Start();
            this.Close();
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread vThread = new System.Threading.Thread(() =>
            {
                try
                {
                    MTSynData.doSyncPost();
                }
                catch { }
            });
            vThread.Start();
            this.Close();
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            if (pPhieuTCID == "")
            {
                Utils.showMessage("Bạn chưa chọn phiếu để in...", "Lưu ý");
            }
            new MTReport().rptTC_Phieuthu(pPhieuTCID);
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                fdoAdd();
            }
            catch (Exception ex) { Utils.showMessage(ex.Message.ToString(), "Thông báo lỗi"); }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            fdoEdit();
        }

        private void cmdDel_Click(object sender, EventArgs e)
        {
            if (pPhieuTCID == "")
            {
                Utils.showMessage("Bạn chưa chọn phiếu cần xóa..", "Lưu ý");
                return;
            }
            if (Utils.ConfirmMessage("Bạn có chắc muốn xóa phiếu này?", "Xác nhận"))
            {
                if (new modPhieuTC().DelPhieuTC(pPhieuTCID))
                {
                    pPhieuTCID = "";
                    BindData();
                    //setReadOnly(true);
                    MTGlobal.SetButtonAction(pACT_ROLE, MTButton, "ABORT");
                }
                else
                {
                    Utils.showMessage("Không thể xóa phiếu, vui lòng kiểm tra lại", "Thông báo");
                }

            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            fdoSave();
        }

        private void cmdAbort_Click(object sender, EventArgs e)
        {
            BindData();
            //setReadOnly(true);
            MTGlobal.SetButtonAction(pACT_ROLE, MTButton, "ABORT");
        }

        private bool fValidate()
        {
            if (txtMaDT.Text == "")
            {
                Utils.showMessage("Đối tượng không được bỏ trống..", "Thông báo");
                txtMaDT.Focus();
                return false;
            }

            if (txtMaLD.Text == "")
            {
                Utils.showMessage("Lý do không được bỏ trống..", "Thông báo");
                txtMaLD.Focus();
                return false;
            }

            if (txtSoPhieu.Text == "")
            {
                Utils.showMessage("Số phiếu chưa được khởi tạo..", "Thông báo");
                txtSoPhieu.Focus();
                return false;
            }

            if (txtNgayCT.Text == "")
            {
                Utils.showMessage("Ngày chứng từ không được bỏ trống..", "Thông báo");
                txtNgayCT.Focus();
                return false;
            }

            if (txtNgayPS.Text == "")
            {
                Utils.showMessage("Ngày hoạch toán không được bỏ trống..", "Thông báo");
                txtNgayPS.Focus();
                return false;
            }

            return true;
        }

        private void txtMaDT_EditValueChanged(object sender, EventArgs e)
        {
            String madt = txtMaDT.Text;
            if (madt == null || madt == "")
            {
                txtMaDT.Focus();
                return;
            }

            DataRow[] vRow = otblKH.Select(string.Format("Makh='{0}'", madt));
            if (vRow.Length > 0)
            {
                String Tenkh = vRow[0]["Tenkh"].ToString();
                String Diachi = vRow[0]["Diachi"].ToString();
                txtTenDoiTuong.Text = Tenkh;
                txtHoTen.Text = Tenkh;
                txtDiaChi.Text = Diachi;
            }
        }

        private void txtMaLD_EditValueChanged(object sender, EventArgs e)
        {
            String mald = txtMaLD.Text;
            if (mald == null || mald == "")
            {
                txtMaLD.Focus();
                return;
            }

            DataRow[] vRow = otblLydo.Select(string.Format("Mald='{0}'", mald));
            if (vRow.Length > 0)
            {
                String tenlydo = vRow[0]["Lydo"].ToString();
                TKNo = vRow[0]["TKNo"].ToString();
                TKCo = vRow[0]["TKCo"].ToString();
                txtLD.Text = tenlydo;
            }
        }

        private void txtManv_EditValueChanged(object sender, EventArgs e)
        {
            String manv = txtManv.Text;
            if (manv == null || manv == "")
            {
                txtManv.Focus();
                return;
            }

            DataRow[] vRow = otblNV.Select(string.Format("Manv='{0}'", manv));
            if (vRow.Length > 0)
            {
                String tenNV = vRow[0]["Tennv"].ToString();
                txtTennv.Text = tenNV;
            }
        }

        private void gvPhieuThuCT_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gvPhieuThuCT.SetRowCellValue(e.RowHandle, colPhieutcctid, MTGlobal.GetNewID());
        }

        private void gvPhieuThuCT_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                if (gvPhieuThuCT.FocusedColumn.FieldName == "TKNo" && gvPhieuThuCT.FocusedColumn.Name == "colTKNo")
                {
                    if (gvPhieuThuCT.GetFocusedRowCellValue(colTKNo) == null || gvPhieuThuCT.GetFocusedRowCellValue(colTKNo).ToString() == "")
                    {
                        gvPhieuThuCT.FocusedColumn = colTKNo;
                        return;
                    }
                }

                if (gvPhieuThuCT.FocusedColumn.FieldName == "TKCo" && gvPhieuThuCT.FocusedColumn.Name == "colTKCo")
                {
                    if (gvPhieuThuCT.GetFocusedRowCellValue(colTKCo) == null || gvPhieuThuCT.GetFocusedRowCellValue(colTKCo).ToString() == "")
                    {
                        gvPhieuThuCT.FocusedColumn = colTKCo;
                        return;
                    }
                }

                if (gvPhieuThuCT.FocusedColumn.FieldName == "Diengiai" && gvPhieuThuCT.FocusedColumn.Name == "colDiengiai")
                {
                    gvPhieuThuCT.SetFocusedRowCellValue(colTKNo, TKNo);
                    gvPhieuThuCT.SetFocusedRowCellValue(colTKCo, TKCo);
                    gvPhieuThuCT.FocusedColumn = colTKCo;
                }
            }
        }
    }
}
