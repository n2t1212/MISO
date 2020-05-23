using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
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
    public partial class NX_PhieuXuat : Form
    {
        private string pPhieuNXID = "";
        private string pDenNgay = "";
        private string pTuNgay = "";
        private string pLoaiPhieu = "";

        private DataTable otblPNX = null;
        private DataTable otblPNXCT = null;
        private DataTable otblKho = null;
        private DataTable otblKH = null;
        private DataTable otblLydo = null;
        private bool isEdit = false;
        DevExpress.Utils.WaitDialogForm Dlg;

        MTGlobal.MT_ROLE pACT_ROLE;
        private MTGlobal.MT_TOOL_TRIP_BUTTONACTION MTButton;

        private DataTable otblSP = null;

        public NX_PhieuXuat()
        {
            InitializeComponent();
        }

        public NX_PhieuXuat(String mPhieuNXID, String mLoaiPhieu, String mTuNgay, String mDenNgay, MTGlobal.MT_ROLE mActRole, bool isAddNew = false)
        {
            InitializeComponent();
            this.lblTitle.Text = "Phiếu xuất kho - " + MTGlobal.RPT_COMPANY;
            this.pPhieuNXID = mPhieuNXID;
            this.pTuNgay = mTuNgay == "" ? DateTime.Now.ToShortDateString() : mTuNgay;
            this.pDenNgay = mDenNgay == "" ? DateTime.Now.ToShortDateString() : mDenNgay;
            this.pLoaiPhieu = mLoaiPhieu;
            this.pACT_ROLE = mActRole;

            Dlg = Utils.shwWait();
            setUserRight();
            loadWarehourseToLookupEdit();
            loadCustomerToLookupEdit();
            loadLydoToLookupEdit();
            if (isAddNew)
            {
                fdoAdd();
            }
            else
            {
                BindData();
                SysPar.SetGridReadOnly(true, gvPhieuXuat);
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
            this.cmdPrint.Enabled = pACT_ROLE.isPrint;
            MTButton.cmdAdd = this.cmdAdd;
            MTButton.cmdEdit = this.cmdEdit;
            MTButton.cmdDel = this.cmdDel;
            MTButton.cmdSave = this.cmdSave;
            MTButton.cmdAbort = this.cmdAbort;
            MTButton.cmdPrint = this.cmdPrint;
            MTGlobal.SetToolStripButtonAction(pACT_ROLE, MTButton, "INIT");
        }

        private void setReadOnly(bool ReadOnly = false)
        {
            dtpNgaylap.Enabled = !ReadOnly;
            dtpNgayPS.Enabled = !ReadOnly;
            txtSoctgoc.ReadOnly = ReadOnly;
            cbNguyente.Enabled = !ReadOnly;
            txtTygia.ReadOnly = ReadOnly;
            txtMaKho.Enabled = !ReadOnly;
            txtTenkho.ReadOnly = ReadOnly;
            txtMadv.Enabled = !ReadOnly;
            txtTendonvi.ReadOnly = ReadOnly;
            txtMald.Enabled = !ReadOnly;
            txtLydo.ReadOnly = ReadOnly;
            txtNguoigiao.ReadOnly = ReadOnly;
            txtGhichu.ReadOnly = ReadOnly;
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

        private void BindData()
        {
            try
            {
                cbNguyente.SelectedIndex = 0;
                txtTygia.Text = "1";
                txtMaKho.Text = "";
                txtTenkho.Text = "";
                txtMadv.Text = "";
                txtTendonvi.Text = "";
                txtMald.Text = "";
                txtLydo.Text = "";
                txtNguoigiao.Text = "";
                txtGhichu.Text = "";

                if (pPhieuNXID != "")
                {
                    String mSql = String.Format("SELECT A.*,B.Tenkho,C.Tenkh,D.Lydo FROM NX_PHIEUNX A LEFT JOIN DM_KHO B ON A.Makho=B.Makho "
                                                 + "LEFT JOIN DM_KHACHHANG C ON A.Makh=c.Makh  LEFT JOIN DM_LYDO D ON A.Mald=d.Mald " +
                                                   " WHERE Phieunxid='{0}'", pPhieuNXID);

                    otblPNX = new MTSQLServer().wRead(mSql, null, false);
                    if (otblPNX != null)
                    {
                        foreach (DataRow vR in otblPNX.Rows)
                        {
                            txtSophieu.Text = vR["Sophieu"].ToString();
                            dtpNgaylap.EditValue = vR["Ngayct"].ToString() != "" ? Convert.ToDateTime(vR["Ngayct"].ToString()).ToShortDateString() : "";
                            dtpNgayPS.EditValue = vR["Ngayps"].ToString() != "" ? Convert.ToDateTime(vR["Ngayps"].ToString()).ToShortDateString() : "";
                            txtSoctgoc.Text = vR["Soctgoc"].ToString();
                            cbNguyente.SelectedText = vR["Loaitien"].ToString();
                            txtTygia.Text = vR["Tygia"].ToString();
                            txtMaKho.Text = vR["Makho"].ToString();
                            txtTenkho.Text = vR["Tenkho"].ToString();
                            txtMadv.Text = vR["Makh"].ToString();
                            txtTendonvi.Text = vR["Tenkh"].ToString();
                            txtMald.Text = vR["Mald"].ToString();
                            txtLydo.Text = vR["Lydo"].ToString();
                            txtNguoigiao.Text = vR["Giaonhan"].ToString();
                            txtGhichu.Text = vR["Ghichu"].ToString();
                        }
                    }

                }

                otblPNXCT = new MTSQLServer().wRead(String.Format("SELECT * FROM NX_PHIEUNXCT where Phieunxid='{0}' ORDER BY Phieunxctid asc", pPhieuNXID), null, false);
                grdPhieuXuat.DataSource = otblPNXCT;
                SysPar.SetGridReadOnly(true, gvPhieuXuat);

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
            /*
            if (txtMadv.Text == "")
            {
                Utils.showMessage("Bạn chưa nhập mã khách hàng..", "Thông báo");
                txtMadv.Focus();
                return false;
            }*/

            if (txtMaKho.Text == "")
            {
                Utils.showMessage("Bạn chưa chọn kho hàng..", "Thông báo");
                txtMaKho.Focus();
                return false;
            }
            if (txtNguoigiao.Text == "")
            {
                Utils.showMessage("Bạn chưa nhập người giao hàng..", "Thông báo");
                txtNguoigiao.Focus();
                return false;
            }
            if (gvPhieuXuat.DataRowCount <= 0)
            {
                Utils.showMessage("Bạn chưa nhập chi tiết hàng hóa..", "Thông báo");
                gvPhieuXuat.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gvPhieuXuat.FocusedRowHandle = GridControl.NewItemRowHandle;
                gvPhieuXuat.FocusedColumn = gvPhieuXuat.VisibleColumns[0];
                gvPhieuXuat.ShowEditor();
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
                pPhieuNXID = MTGlobal.GetNewID();
                txtSophieu.Text = MTGlobal.GetSophieu(MTGlobal.MT_KYHIEU_CUAHANG, this.pLoaiPhieu, mMM, mYY, MTGlobal.MT_USER_LOGIN).ToString();
                dtpNgaylap.Text = DateTime.Now.ToShortDateString();
                dtpNgayPS.Text = DateTime.Now.ToShortDateString();

                cbxType.SelectedIndex = 0;
                cbxDisplay.SelectedIndex = 0;

                BindData();
                if (SysPar.SetGridReadOnly(false, gvPhieuXuat))
                {
                    gvPhieuXuat.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                    grdPhieuXuat.DataSource = new modPhieuNX().dtPhieuNXCT();
                    gvPhieuXuat.FocusedRowHandle = GridControl.NewItemRowHandle;
                    gvPhieuXuat.FocusedColumn = gvPhieuXuat.VisibleColumns[0];
                    gvPhieuXuat.ShowEditor();
                }

                setReadOnly(false);
                MTGlobal.SetToolStripButtonAction(pACT_ROLE, MTButton, "ADD");
                txtSophieu.Focus();
                isEdit = true;
            }
            catch (Exception ex) { Utils.showMessage(ex.Message.ToString(), "Thông báo lỗi"); }
        }

        private void fdoEdit()
        {
            setReadOnly(false);
            MTGlobal.SetToolStripButtonAction(pACT_ROLE, MTButton, "EDIT");
            isEdit = true;
            txtSophieu.Focus();
            if (SysPar.SetGridReadOnly(false, gvPhieuXuat))
            {
                gvPhieuXuat.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gvPhieuXuat.FocusedRowHandle = GridControl.NewItemRowHandle;
                gvPhieuXuat.FocusedColumn = gvPhieuXuat.VisibleColumns[0];
                gvPhieuXuat.ShowEditor();
            }
        }
        private void fdoSave()
        {
            if (fValidate())
            {
                DataTable tmpPN = new modPhieuNX().dtPhieuNX();
                DataRow vR = tmpPN.NewRow();
                vR["Phieunxid"] = pPhieuNXID;
                vR["Sophieu"] = txtSophieu.Text.ToUpper();
                vR["Loaiphieu"] = this.pLoaiPhieu;
                vR["Makho"] = txtMaKho.Text;
                vR["Mald"] = txtMald.Text;
                vR["Makh"] = txtMadv.Text;
                vR["Ngayct"] = Convert.ToDateTime(dtpNgaylap.Text);
                vR["Ngayps"] = Convert.ToDateTime(dtpNgayPS.Text);
                vR["Soctgoc"] = txtSoctgoc.Text;
                vR["Loaitien"] = cbNguyente.Text.ToString();
                vR["Tygia"] = txtTygia.Text.Length == 0 ? 0 : Double.Parse(txtTygia.Text);
                vR["Nguyente"] = 0;
                vR["Vat"] = 0;
                vR["TTVat"] = 0;
                vR["Thanhtien"] = 0;
                vR["Ghichu"] = txtGhichu.Text;
                vR["Giaonhan"] = txtNguoigiao.Text.Trim();
                vR["Ngaylap"] = DateTime.Now;
                vR["Nguoilap"] = MTGlobal.MT_USER_LOGIN;
                tmpPN.Rows.Add(vR);
                tmpPN.AcceptChanges();

                DataTable tmpPNCT = new modPhieuNX().dtPhieuNXCT();
                var filteredRows = gvPhieuXuat.DataController.GetAllFilteredAndSortedRows();
                if (filteredRows.Count == 0)
                {
                    return;
                }

                // gvPhieuXuat.CommitEditing();
                gvPhieuXuat.CloseEditor();
                otblPNXCT.AcceptChanges();
                //for (int i = 0; i < filteredRows.Count; i++){
                for (int i = 0; i < gvPhieuXuat.DataRowCount; i++)
                {
                    DataRow cR = tmpPNCT.NewRow();
                    foreach (GridColumn column in gvPhieuXuat.VisibleColumns)
                    {
                        cR[column.FieldName] = gvPhieuXuat.GetRowCellValue(i, column);
                    }

                    cR["Phieunxctid"] = gvPhieuXuat.GetRowCellValue(i, colPhieunxctid);
                    cR["Phieunxid"] = pPhieuNXID;
                    //cR["Maspid"] = sR["Maspid"];
                    //cR["Masp"] = sR["Masp"];
                    //cR["Tensp"] = sR["Tensp"];
                    //cR["Quycach"] = sR["Quycach"];
                    //cR["Dvt"] = sR["Dvt"];
                    //cR["SLThung"] = sR["SLThung"];
                    //cR["Soluong"] = sR["Soluong"];
                    //cR["Dongia"] = sR["Dongia"];
                    //cR["Nguyente"] = sR["Nguyente"];
                    //cR["Vat"] = sR["Vat"];
                    //cR["TTVat"] = sR["TTVat"];
                    //cR["Thanhtien"] = sR["Thanhtien"];
                    cR["Songaychono"] = 0;
                    cR["Ghiso"] = 1;
                    tmpPNCT.Rows.Add(cR);
                }
                tmpPNCT.AcceptChanges();

                String Rs = new modPhieuNX().SavePhieuNX(tmpPN, tmpPNCT);
                if (Rs == "")
                {
                    setReadOnly(true);
                    MTGlobal.SetToolStripButtonAction(pACT_ROLE, MTButton, "SAVE");
                    SysPar.SetGridReadOnly(true, gvPhieuXuat);
                    isEdit = false;
                }
                else
                {
                    Utils.showMessage(Rs, "Thông báo");
                }
            }
        }

        private void fThanhTien(int iRowHander)
        {
            try
            {
                String sSL = "0", sDG = "0", sVAT = "0";
                sSL = gvPhieuXuat.GetRowCellValue(iRowHander, "Soluong").ToString();
                sDG = gvPhieuXuat.GetRowCellValue(iRowHander, "Dongia").ToString();
                sVAT = gvPhieuXuat.GetRowCellValue(iRowHander, "Vat").ToString();

                Double dGia, dSL, dVAT;
                Double.TryParse(sDG, out dGia);
                Double.TryParse(sSL, out dSL);
                Double.TryParse(sVAT, out dVAT);

                if (dSL > 0 && dGia > 0)
                {
                    gvPhieuXuat.SetRowCellValue(iRowHander, "Nguyente", Math.Round(dSL * dGia, 0, MidpointRounding.AwayFromZero));
                    if (dVAT > 0)
                    {
                        gvPhieuXuat.SetRowCellValue(iRowHander, "TTVat", Math.Round((dSL * dGia * dVAT) / 100, 0, MidpointRounding.AwayFromZero));
                    }
                    gvPhieuXuat.SetRowCellValue(iRowHander, "Thanhtien", Math.Round((dSL * dGia) + ((dSL * dGia * dVAT) / 100), 0, MidpointRounding.AwayFromZero));
                }
                else
                {
                    gvPhieuXuat.SetRowCellValue(iRowHander, "Nguyente", 0);
                    gvPhieuXuat.SetRowCellValue(iRowHander, "TTVat", 0);
                    gvPhieuXuat.SetRowCellValue(iRowHander, "Thanhtien", 0);
                }

            }
            catch { }
        }

        private void fQuydoithung(Double dSLThung)
        {
            if (dSLThung == 0)
                return;
            try
            {
                String sMasp = "";
                sMasp = gvPhieuXuat.GetRowCellValue(gvPhieuXuat.FocusedRowHandle, colMasp).ToString();
                if (otblSP != null && otblSP.Rows.Count > 0)
                {
                    DataRow[] vRow = otblSP.Select(string.Format("Masp='{0}'", sMasp));
                    if (vRow.Length > 0)
                    {
                        Double dQDThung = 0, dSLQD = 0;
                        Double.TryParse(vRow[0]["Quydoithung"].ToString(), out dQDThung);
                        dQDThung = dQDThung == 0 ? 1 : dQDThung;
                        dSLQD = Math.Round(dSLThung * dQDThung, 0, MidpointRounding.AwayFromZero);
                        gvPhieuXuat.SetRowCellValue(gvPhieuXuat.FocusedRowHandle, colSoluong, dSLQD);
                    }
                }
            }
            catch { }
        }

        private void fQuydoile2thung(Double dSLLe)
        {
            if (dSLLe == 0)
                return;
            try
            {
                String sMasp = "";
                sMasp = gvPhieuXuat.GetRowCellValue(gvPhieuXuat.FocusedRowHandle, colMasp).ToString();
                if (otblSP != null && otblSP.Rows.Count > 0)
                {
                    DataRow[] vRow = otblSP.Select(string.Format("Masp='{0}'", sMasp));
                    if (vRow.Length > 0)
                    {
                        Double dQDThung = 0, dSLQD = 0;
                        Double.TryParse(vRow[0]["Quydoithung"].ToString(), out dQDThung);
                        dQDThung = dQDThung == 0 ? 1 : dQDThung;
                        dSLQD = Math.Round(dSLLe / dQDThung, 0, MidpointRounding.AwayFromZero);
                        gvPhieuXuat.SetRowCellValue(gvPhieuXuat.FocusedRowHandle, colSLThung, dSLQD);

                    }
                }
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (pPhieuNXID == "")
            {
                Utils.showMessage("Bạn chưa chọn phiếu để in...", "Lưu ý");
            }
            new MTReport().rptNX_Phieuxuat(pPhieuNXID);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                fdoAdd();
            }
            catch (Exception ex) { Utils.showMessage(ex.Message.ToString(), "Thông báo lỗi"); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fdoEdit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (pPhieuNXID == "")
            {
                Utils.showMessage("Bạn chưa chọn phiếu cần xóa..", "Lưu ý");
                return;
            }
            if (Utils.ConfirmMessage("Bạn có chắc muốn xóa phiếu này?", "Xác nhận"))
            {
                if (new modPhieuNX().DelPhieuNX(pPhieuNXID))
                {
                    pPhieuNXID = "";
                    BindData();
                    setReadOnly(true);
                    MTGlobal.SetToolStripButtonAction(pACT_ROLE, MTButton, "ABORT");
                }
                else
                {
                    Utils.showMessage("Không thể xóa phiếu, vui lòng kiểm tra lại", "Thông báo");
                }

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            fdoSave();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BindData();
            setReadOnly(true);
            MTGlobal.SetToolStripButtonAction(pACT_ROLE, MTButton, "ABORT");
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

        private void txtMaKho_EditValueChanged(object sender, EventArgs e)
        {
            String makho = txtMaKho.Text;
            if (makho == null || makho == "")
            {
                txtMaKho.Focus();
                return;
            }

            DataRow[] vRow = otblKho.Select(string.Format("Makho='{0}'", makho));
            if (vRow.Length > 0)
            {
                String tenkho = vRow[0]["Tenkho"].ToString();
                txtTenkho.Text = tenkho;
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
                txtTendonvi.Text = tenkh;
            }
        }

        private void txtMald_EditValueChanged(object sender, EventArgs e)
        {
            String mald = txtMald.Text;
            if (mald == null || mald == "")
            {
                txtMald.Focus();
                return;
            }

            DataRow[] vRow = otblLydo.Select(string.Format("Mald='{0}'", mald));
            if (vRow.Length > 0)
            {
                String tenlydo = vRow[0]["Lydo"].ToString();
                txtLydo.Text = tenlydo;
            }
        }

        private void gvPhieuXuat_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            try
            {
                gvPhieuXuat.SetRowCellValue(e.RowHandle, colPhieunxctid, MTGlobal.GetNewID());
                gvPhieuXuat.SetRowCellValue(e.RowHandle, colPhieunxid, pPhieuNXID);
            }
            catch { }
        }

        private void loadProductToLookupEdit(DataTable otblSP)
        {
            repositoryItems.DataSource = otblSP;
            repositoryItems.ValueMember = "Masp";
            repositoryItems.DisplayMember = "Masp";
            repositoryItems.NullText = "";
            colMasp.ColumnEdit = repositoryItems;
        }

        private void loadWarehourseToLookupEdit()
        {
            String mSql = String.Format("SELECT * FROM DM_KHO");
            otblKho = new MTSQLServer().wRead(mSql, null, false);
            txtMaKho.Properties.DataSource = otblKho;
            txtMaKho.Properties.ValueMember = "Makho";
            txtMaKho.Properties.DisplayMember = "Makho";
            txtMaKho.Properties.NullText = "Chọn kho";
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

        private void loadLydoToLookupEdit()
        {
            String mSql = String.Format("SELECT * FROM DM_LYDO");
            otblLydo = new MTSQLServer().wRead(mSql, null, false);
            txtMald.Properties.DataSource = otblLydo;
            txtMald.Properties.ValueMember = "Mald";
            txtMald.Properties.DisplayMember = "Mald";
            txtMald.Properties.NullText = "Chọn lý do";
        }

        private void gvPhieuXuat_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (isEdit == false) { return; }

            if (gvPhieuXuat.FocusedColumn.FieldName == "Dongia" && e.Column.Name == "colDongia")
            {
                if (gvPhieuXuat.GetRowCellValue(e.RowHandle, colSoluong) != null
                    && gvPhieuXuat.GetRowCellValue(e.RowHandle, colSoluong).ToString() != ""
                    && gvPhieuXuat.GetRowCellValue(e.RowHandle, colSLThung) != null
                    && gvPhieuXuat.GetRowCellValue(e.RowHandle, colSLThung).ToString() != "")
                {
                    fThanhTien(e.RowHandle);
                }
            }

            else if (gvPhieuXuat.FocusedColumn.FieldName == "Vat" && e.Column.Name == "colVat")
            {
                if (gvPhieuXuat.GetRowCellValue(e.RowHandle, colSoluong).ToString() != "" && gvPhieuXuat.GetRowCellValue(e.RowHandle, colSLThung).ToString() != "")
                {
                    fThanhTien(e.RowHandle);
                }
            }

            else if (gvPhieuXuat.FocusedColumn.FieldName == "SLThung" && e.Column.Name == "colSLThung")
            {
                Double slThung = 0;

                Double.TryParse(gvPhieuXuat.GetRowCellValue(e.RowHandle, colSLThung).ToString(), out slThung);
                fQuydoithung(slThung);
                if (gvPhieuXuat.GetRowCellValue(gvPhieuXuat.FocusedRowHandle, colDongia).ToString() != "")
                {
                    fThanhTien(gvPhieuXuat.FocusedRowHandle);
                }
            }

            else if (gvPhieuXuat.FocusedColumn.FieldName == "Soluong" && e.Column.Name == "colSoluong")
            {
                Double slLe = 0;
                Double.TryParse(gvPhieuXuat.GetRowCellValue(gvPhieuXuat.FocusedRowHandle, colSoluong).ToString(), out slLe);
                fQuydoile2thung(slLe);
                if (gvPhieuXuat.GetRowCellValue(gvPhieuXuat.FocusedRowHandle, colDongia).ToString() != "")
                {
                    fThanhTien(gvPhieuXuat.FocusedRowHandle);
                }
            }
        }

        private void gvPhieuXuat_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (e.Row == null) return;
            if (gvPhieuXuat.GetRowCellValue(e.RowHandle, colMasp) == null || gvPhieuXuat.GetRowCellValue(e.RowHandle, colMasp).ToString() == "")
            {
                e.ErrorText = "Bạn chưa nhập mã hàng hóa..";
                e.Valid = false;
                return;
            }

            double dDG = 0, dSL = 0;
            try
            {
                Double.TryParse(gvPhieuXuat.GetRowCellValue(e.RowHandle, colDongia).ToString(), out dDG);
                Double.TryParse(gvPhieuXuat.GetRowCellValue(e.RowHandle, colSoluong).ToString(), out dSL);
            }
            catch { }
            if (dDG <= 0)
            {
                e.ErrorText = "Bạn chưa nhập đơn giá hàng hóa..";
                e.Valid = false;
                return;
            }
            if (dSL <= 0)
            {
                e.ErrorText = "Bạn chưa nhập đơn giá hàng hóa..";
                e.Valid = false;
                return;
            }

            double dVAT = 0, dTTVAT = 0, dNguyente = 0, dNguyenteRow = 0, dTTVatRow = 0, dThanhtienRow = 0;
            try
            {
                Double.TryParse(gvPhieuXuat.GetRowCellValue(e.RowHandle, colVat).ToString(), out dVAT);
                dNguyente = Math.Round(dSL * dDG, 0, MidpointRounding.AwayFromZero);
                if (dVAT > 0)
                {
                    dTTVAT = Math.Round(dNguyente * dVAT / 100, 0, MidpointRounding.AwayFromZero);
                }

                Double.TryParse(gvPhieuXuat.GetRowCellValue(e.RowHandle, colNguyente).ToString(), out dNguyenteRow);
                Double.TryParse(gvPhieuXuat.GetRowCellValue(e.RowHandle, colTTVat).ToString(), out dTTVatRow);
                Double.TryParse(gvPhieuXuat.GetRowCellValue(e.RowHandle, colThanhtien).ToString(), out dThanhtienRow);

                if (dNguyente != Math.Round(dNguyenteRow, 0, MidpointRounding.AwayFromZero))
                {
                    e.ErrorText = "Số tiền nguyên tệ không đúng.";
                    e.Valid = false;
                    return;
                }

                if (dTTVAT != Math.Round(dTTVatRow, 0, MidpointRounding.AwayFromZero))
                {
                    e.ErrorText = "Số tiền (VAT) không đúng.";
                    e.Valid = false;
                    return;
                }
                if ((dNguyente + dTTVAT) != Math.Round(dThanhtienRow, 0, MidpointRounding.AwayFromZero))
                {
                    e.ErrorText = "Tổng thành tiền không đúng.";
                    e.Valid = false;
                    return;
                }
                gvPhieuXuat.UpdateCurrentRow();
            }
            catch { } 
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

        private void gvPhieuXuat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var editObj = ((DevExpress.XtraGrid.Views.Grid.GridView)(sender)).EditingValue;

                if (gvPhieuXuat.FocusedColumn.FieldName == "Masp" && gvPhieuXuat.FocusedColumn.Name == "colMasp")
                {
                    if (gvPhieuXuat.GetFocusedRowCellValue(colMasp) == null)  // || gvPhieuXuat.GetFocusedRowCellValue(colMasp).ToString() == ""
                    {
                        gvPhieuXuat.FocusedColumn = colMasp;
                        return;
                    }
                    //String sMasp = gvPhieuXuat.GetRowCellValue(gvPhieuXuat.FocusedRowHandle, colMasp).ToString();
                    String sMasp;

                    sMasp = editObj != null ? editObj.ToString() : "";
                    if (sMasp == null || sMasp == "")
                    {
                        gvPhieuXuat.FocusedColumn = colMasp;
                        return;
                    }

                    DataRow[] vRow = otblSP.Select(string.Format("Masp='{0}'", sMasp));
                    if (vRow.Length > 0)
                    {
                        double dSL = 0;
                        try
                        {
                            double.TryParse(gvPhieuXuat.GetRowCellValue(gvPhieuXuat.FocusedRowHandle, colSoluong).ToString(), out dSL);
                            if (dSL == 0) { dSL = 1; }
                        }
                        catch { dSL = 1; }
                        gvPhieuXuat.SetRowCellValue(gvPhieuXuat.FocusedRowHandle, colMasp, sMasp);
                        gvPhieuXuat.SetRowCellValue(gvPhieuXuat.FocusedRowHandle, colTensp, vRow[0]["Tensp"].ToString());
                        gvPhieuXuat.SetRowCellValue(gvPhieuXuat.FocusedRowHandle, colDvt, vRow[0]["Dvt"].ToString());
                        gvPhieuXuat.SetRowCellValue(gvPhieuXuat.FocusedRowHandle, colQuycach, vRow[0]["Quycach"].ToString());
                        gvPhieuXuat.SetRowCellValue(gvPhieuXuat.FocusedRowHandle, colSoluong, dSL);
                        Double dDGX = MTGlobal.GetDonGia(sMasp, pDenNgay);
                        gvPhieuXuat.SetRowCellValue(gvPhieuXuat.FocusedRowHandle, colDongia, dDGX);
                        fQuydoile2thung(dSL);
                        gvPhieuXuat.CloseEditor();
                        gvPhieuXuat.ShowEditor();
                        gvPhieuXuat.FocusedColumn = colSoluong;
                    }
                }
                else if (gvPhieuXuat.FocusedColumn.FieldName == "SLThung" && gvPhieuXuat.FocusedColumn.Name == "colSLThung")
                {
                    Double slThung = 0;
                    try
                    {
                        Double.TryParse(editObj.ToString(), out slThung);
                    }
                    catch
                    {
                        slThung = 1;
                    }
                    gvPhieuXuat.SetRowCellValue(gvPhieuXuat.FocusedRowHandle, colSLThung, slThung);
                    fQuydoithung(slThung);
                    if (gvPhieuXuat.GetRowCellValue(gvPhieuXuat.FocusedRowHandle, colDongia).ToString() != "")
                    {
                        fThanhTien(gvPhieuXuat.FocusedRowHandle);
                    }
                }

                else if (gvPhieuXuat.FocusedColumn.FieldName == "Soluong" && gvPhieuXuat.FocusedColumn.Name == "colSoluong")
                {
                    Double slLe = 0;
                    try
                    {
                        Double.TryParse(editObj.ToString(), out slLe);
                    }
                    catch
                    {
                        slLe = 1;
                    }
                    gvPhieuXuat.SetRowCellValue(gvPhieuXuat.FocusedRowHandle, colSoluong, slLe);
                    fQuydoile2thung(slLe);
                    if (gvPhieuXuat.GetRowCellValue(gvPhieuXuat.FocusedRowHandle, colDongia).ToString() != "")
                    {
                        fThanhTien(gvPhieuXuat.FocusedRowHandle);
                    }
                }
                else if (gvPhieuXuat.FocusedColumn.FieldName == "Vat" && gvPhieuXuat.FocusedColumn.Name == "colVat")
                {
                    Double vat = 0;
                    try
                    {
                        Double.TryParse(editObj.ToString(), out vat);
                    }
                    catch
                    {
                        vat = 0;
                    }
                    gvPhieuXuat.SetRowCellValue(gvPhieuXuat.FocusedRowHandle, colVat, vat);
                    if (gvPhieuXuat.GetRowCellValue(gvPhieuXuat.FocusedRowHandle, colSoluong).ToString() != "" && gvPhieuXuat.GetRowCellValue(gvPhieuXuat.FocusedRowHandle, colSLThung).ToString() != "")
                    {

                        fThanhTien(gvPhieuXuat.FocusedRowHandle);
                    }
                }

            }
        }

        private void grdPhieuXuat_KeyDown(object sender, KeyEventArgs e)
        {
            if (isEdit == false) { return; }
            if (e.KeyCode == Keys.Enter)
            {
                if (gvPhieuXuat.FocusedColumn.FieldName == "Masp" && gvPhieuXuat.FocusedColumn.Name == "colMasp")
                {
                    if (gvPhieuXuat.GetFocusedRowCellValue(colMasp) == null || gvPhieuXuat.GetFocusedRowCellValue(colMasp).ToString() == "")  //
                    {
                        gvPhieuXuat.FocusedColumn = colMasp;
                        return;
                    }
                    String sMasp = gvPhieuXuat.GetRowCellValue(gvPhieuXuat.FocusedRowHandle, colMasp).ToString();
                    if (sMasp == null || sMasp == "")
                    {
                        gvPhieuXuat.FocusedColumn = colMasp;
                        return;
                    }

                    DataRow[] vRow = otblSP.Select(string.Format("Masp='{0}'", sMasp));
                    if (vRow.Length > 0)
                    {
                        double dSL = 0;
                        try
                        {
                            double.TryParse(gvPhieuXuat.GetRowCellValue(gvPhieuXuat.FocusedRowHandle, colDongia).ToString(), out dSL);
                            if (dSL == 0) { dSL = 1; }
                        }
                        catch { dSL = 1; }
                        //gvPhieuXuat.SetRowCellValue(gvPhieuXuat.FocusedRowHandle, colMasp, sMasp);
                        gvPhieuXuat.SetRowCellValue(gvPhieuXuat.FocusedRowHandle, colTensp, vRow[0]["Tensp"].ToString());
                        gvPhieuXuat.SetRowCellValue(gvPhieuXuat.FocusedRowHandle, colDvt, vRow[0]["Dvt"].ToString());
                        gvPhieuXuat.SetRowCellValue(gvPhieuXuat.FocusedRowHandle, colQuycach, vRow[0]["Quycach"].ToString());
                        gvPhieuXuat.SetRowCellValue(gvPhieuXuat.FocusedRowHandle, colSoluong, dSL);
                        Double dDGX = MTGlobal.GetDonGia(sMasp, pDenNgay);
                        gvPhieuXuat.SetRowCellValue(gvPhieuXuat.FocusedRowHandle, colDongia, dDGX);
                        fQuydoile2thung(dSL);
                        gvPhieuXuat.CloseEditor();
                        gvPhieuXuat.ShowEditor();
                        gvPhieuXuat.FocusedColumn = colSoluong;
                    }
                }
            }
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    if (gvPhieuXuat.GetFocusedRowCellValue(colPhieunxctid) == null || gvPhieuXuat.GetFocusedRowCellValue(colPhieunxctid).ToString() == "")
                    {
                        e.Handled = true;
                        return;
                    }
                    if (Utils.ConfirmMessage(String.Format("Bạn có chắc muốn xóa {0} không ?", gvPhieuXuat.GetRowCellValue(gvPhieuXuat.FocusedRowHandle, colMasp).ToString()), "Xác nhận xóa") == true)
                    {
                        gvPhieuXuat.DeleteRow(gvPhieuXuat.FocusedRowHandle);
                    }
                }
                catch (Exception ex) { ex.Data.Clear(); }
            }
        }

        private void cmdAdd_Click_1(object sender, EventArgs e)
        {
            fdoAdd();
        }

        private void cmdEdit_Click_1(object sender, EventArgs e)
        {
            fdoEdit();
        }

        private void cmdDel_Click_1(object sender, EventArgs e)
        {
            if (pPhieuNXID == "")
            {
                Utils.showMessage("Bạn chưa chọn phiếu cần xóa..", "Lưu ý");
                return;
            }
            if (Utils.ConfirmMessage("Bạn có chắc muốn xóa phiếu này?", "Xác nhận"))
            {
                if (new modPhieuNX().DelPhieuNX(pPhieuNXID))
                {
                    pPhieuNXID = "";
                    BindData();
                    setReadOnly(true);
                    MTGlobal.SetToolStripButtonAction(pACT_ROLE, MTButton, "ABORT");
                }
                else
                {
                    Utils.showMessage("Không thể xóa phiếu, vui lòng kiểm tra lại", "Thông báo");
                }

            }
        }

        private void cmdSave_Click_1(object sender, EventArgs e)
        {
            fdoSave();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fdoAdd();
        }

        private void cmdExit_Click(object sender, EventArgs e)
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

        private void cmdEdit_Click_2(object sender, EventArgs e)
        {
            fdoEdit();
        }

        private void fdoDel()
        {
            if (pPhieuNXID == "")
            {
                Utils.showMessage("Bạn chưa chọn phiếu cần xóa..", "Lưu ý");
                return;
            }
            if (Utils.ConfirmMessage("Bạn có chắc muốn xóa phiếu này?", "Xác nhận"))
            {
                if (new modPhieuNX().DelPhieuNX(pPhieuNXID))
                {
                    pPhieuNXID = "";
                    BindData();
                    setReadOnly(true);
                    MTGlobal.SetToolStripButtonAction(pACT_ROLE, MTButton, "ABORT");
                }
                else
                {
                    Utils.showMessage("Không thể xóa phiếu, vui lòng kiểm tra lại", "Thông báo");
                }

            }
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
            BindData();
            setReadOnly(true);
            MTGlobal.SetToolStripButtonAction(pACT_ROLE, MTButton, "ABORT");
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            if (pPhieuNXID == "")
            {
                Utils.showMessage("Bạn chưa chọn phiếu để in...", "Lưu ý");
            }
            new MTReport().rptNX_Phieuxuat(pPhieuNXID);
        }


        private void grdPhieuXuat_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                fdoAdd();
            }
            else if (e.KeyCode == Keys.F3)
            {
                fdoEdit();
            }
            else if (e.KeyCode == Keys.F4)
            {
                fdoDel();
            }
            else if (e.KeyCode == Keys.F5)
            {
                fdoSave();
            }
            else if (e.KeyCode == Keys.F7)
            {
                if (pPhieuNXID == "")
                {
                    Utils.showMessage("Bạn chưa chọn phiếu để in...", "Lưu ý");
                }
                new MTReport().rptNX_Phieuxuat(pPhieuNXID);
            }
            else if (e.KeyCode == Keys.F8)
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
            else if (e.KeyCode == Keys.Escape)
            {
                BindData();
                setReadOnly(true);
                MTGlobal.SetToolStripButtonAction(pACT_ROLE, MTButton, "ABORT");
            }
        }
    }
}
