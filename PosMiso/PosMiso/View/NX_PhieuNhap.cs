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
    public partial class NX_PhieuNhap : Form
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
        private MTGlobal.MT_BUTTONACTION MTButton;

        private DataTable otblSP = null;

        public NX_PhieuNhap()
        {
            InitializeComponent();
        }

        public NX_PhieuNhap(String mPhieuNXID, String mLoaiPhieu, String mTuNgay, String mDenNgay, MTGlobal.MT_ROLE mActRole, bool isAddNew = false)
        {
            InitializeComponent();
            this.lblTitle.Text = "LẬP PHIẾU NHẬP";
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
                SysPar.SetGridReadOnly(true, gvPhieuNhap);
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
            MTGlobal.SetButtonAction(pACT_ROLE, MTButton, "INIT");
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
                grdPhieuNhap.DataSource = otblPNXCT;
                SysPar.SetGridReadOnly(true, gvPhieuNhap);

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
            if (gvPhieuNhap.DataRowCount <= 0)
            {
                Utils.showMessage("Bạn chưa nhập chi tiết hàng hóa..", "Thông báo");
                gvPhieuNhap.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gvPhieuNhap.FocusedRowHandle = GridControl.NewItemRowHandle;
                gvPhieuNhap.FocusedColumn = gvPhieuNhap.VisibleColumns[0];
                gvPhieuNhap.ShowEditor();
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

                BindData();
                if (SysPar.SetGridReadOnly(false, gvPhieuNhap))
                {
                    gvPhieuNhap.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                    grdPhieuNhap.DataSource = new modPhieuNX().dtPhieuNXCT();
                    gvPhieuNhap.FocusedRowHandle = GridControl.NewItemRowHandle;
                    gvPhieuNhap.FocusedColumn = gvPhieuNhap.VisibleColumns[0];
                    gvPhieuNhap.ShowEditor();
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
            if (SysPar.SetGridReadOnly(false, gvPhieuNhap))
            {
                gvPhieuNhap.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gvPhieuNhap.FocusedRowHandle = GridControl.NewItemRowHandle;
                gvPhieuNhap.FocusedColumn = gvPhieuNhap.VisibleColumns[0];
                gvPhieuNhap.ShowEditor();
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
                var filteredRows = gvPhieuNhap.DataController.GetAllFilteredAndSortedRows();
                if (filteredRows.Count == 0)
                {
                    return;
                }

               // gvPhieuNhap.CommitEditing();
                gvPhieuNhap.CloseEditor();
                otblPNXCT.AcceptChanges();
                //for (int i = 0; i < filteredRows.Count; i++){
                for (int i = 0; i < gvPhieuNhap.DataRowCount; i++)  
                {
                    DataRow cR = tmpPNCT.NewRow();
                    foreach (GridColumn column in gvPhieuNhap.VisibleColumns)
                    {
                        cR[column.FieldName] = gvPhieuNhap.GetRowCellValue(i, column);
                    }

                    cR["Phieunxctid"] = gvPhieuNhap.GetRowCellValue(i, colPhieunxctid);
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
                    MTGlobal.SetButtonAction(pACT_ROLE, MTButton, "SAVE");
                    SysPar.SetGridReadOnly(true, gvPhieuNhap);
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
                sSL = gvPhieuNhap.GetRowCellValue(iRowHander, "Soluong").ToString();
                sDG = gvPhieuNhap.GetRowCellValue(iRowHander, "Dongia").ToString();
                sVAT = gvPhieuNhap.GetRowCellValue(iRowHander, "Vat").ToString();

                Double dGia, dSL, dVAT;
                Double.TryParse(sDG, out dGia);
                Double.TryParse(sSL, out dSL);
                Double.TryParse(sVAT, out dVAT);

                if (dSL > 0 && dGia > 0)
                {
                    gvPhieuNhap.SetRowCellValue(iRowHander, "Nguyente", Math.Round(dSL * dGia, 0, MidpointRounding.AwayFromZero));
                    if (dVAT > 0)
                    {
                        gvPhieuNhap.SetRowCellValue(iRowHander, "TTVat", Math.Round((dSL * dGia * dVAT) / 100, 0, MidpointRounding.AwayFromZero));
                    }
                    gvPhieuNhap.SetRowCellValue(iRowHander, "Thanhtien", Math.Round((dSL * dGia) + ((dSL * dGia * dVAT) / 100), 0, MidpointRounding.AwayFromZero));
                }
                else
                {
                    gvPhieuNhap.SetRowCellValue(iRowHander, "Nguyente", 0);
                    gvPhieuNhap.SetRowCellValue(iRowHander, "TTVat", 0);
                    gvPhieuNhap.SetRowCellValue(iRowHander, "Thanhtien", 0);
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
                sMasp = gvPhieuNhap.GetRowCellValue(gvPhieuNhap.FocusedRowHandle, colMasp).ToString();
                if (otblSP != null && otblSP.Rows.Count > 0)
                {
                    DataRow[] vRow = otblSP.Select(string.Format("Masp='{0}'", sMasp));
                    if (vRow.Length > 0)
                    {
                        Double dQDThung = 0, dSLQD = 0;
                        Double.TryParse(vRow[0]["Quydoithung"].ToString(), out dQDThung);
                        dQDThung = dQDThung == 0 ? 1 : dQDThung;
                        dSLQD = Math.Round(dSLThung * dQDThung, 0, MidpointRounding.AwayFromZero);
                        gvPhieuNhap.SetRowCellValue(gvPhieuNhap.FocusedRowHandle, colSoluong, dSLQD);
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
                sMasp = gvPhieuNhap.GetRowCellValue(gvPhieuNhap.FocusedRowHandle, colMasp).ToString();
                if (otblSP != null && otblSP.Rows.Count > 0)
                {
                    DataRow[] vRow = otblSP.Select(string.Format("Masp='{0}'", sMasp));
                    if (vRow.Length > 0)
                    {
                        Double dQDThung = 0, dSLQD = 0;
                        Double.TryParse(vRow[0]["Quydoithung"].ToString(), out dQDThung);
                        dQDThung = dQDThung == 0 ? 1 : dQDThung;
                        dSLQD = Math.Round(dSLLe / dQDThung, 0, MidpointRounding.AwayFromZero);
                        gvPhieuNhap.SetRowCellValue(gvPhieuNhap.FocusedRowHandle, colSLThung, dSLQD);
                        
                    }
                }
            }
            catch { }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (pPhieuNXID == "")
            {
                Utils.showMessage("Bạn chưa chọn phiếu để in...", "Lưu ý");
            }
            new MTReport().rptNX_Phieunhap(pPhieuNXID);
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
                    MTGlobal.SetButtonAction(pACT_ROLE, MTButton, "ABORT");
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
            MTGlobal.SetButtonAction(pACT_ROLE, MTButton, "ABORT");
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

        private void gvPhieuNhap_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            try
            {
                gvPhieuNhap.SetRowCellValue(e.RowHandle, colPhieunxctid, MTGlobal.GetNewID());
                gvPhieuNhap.SetRowCellValue(e.RowHandle, colPhieunxid, pPhieuNXID);
            }
            catch { }
        }

        private void grdPhieuNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (isEdit == false) { return; }
            if (e.KeyCode == Keys.Enter)
            {
                if (gvPhieuNhap.FocusedColumn.FieldName == "Masp" && gvPhieuNhap.FocusedColumn.Name == "colMasp")
                {
                    if (gvPhieuNhap.GetFocusedRowCellValue(colMasp) == null || gvPhieuNhap.GetFocusedRowCellValue(colMasp).ToString() == "")  //
                    {
                        gvPhieuNhap.FocusedColumn = colMasp;
                        return;
                    }
                    String sMasp = gvPhieuNhap.GetRowCellValue(gvPhieuNhap.FocusedRowHandle, colMasp).ToString();
                    if (sMasp == null || sMasp == "")
                    {
                        gvPhieuNhap.FocusedColumn = colMasp;
                        return;
                    }

                    DataRow[] vRow = otblSP.Select(string.Format("Masp='{0}'", sMasp));
                    if (vRow.Length > 0)
                    {
                        double dSL = 0;
                        try
                        {
                            double.TryParse(gvPhieuNhap.GetRowCellValue(gvPhieuNhap.FocusedRowHandle, colDongia).ToString(), out dSL);
                            if (dSL == 0) { dSL = 1; }
                        }
                        catch { dSL = 1; }
                        //gvPhieuNhap.SetRowCellValue(gvPhieuNhap.FocusedRowHandle, colMasp, sMasp);
                        gvPhieuNhap.SetRowCellValue(gvPhieuNhap.FocusedRowHandle, colTensp, vRow[0]["Tensp"].ToString());
                        gvPhieuNhap.SetRowCellValue(gvPhieuNhap.FocusedRowHandle, colDvt, vRow[0]["Dvt"].ToString());
                        gvPhieuNhap.SetRowCellValue(gvPhieuNhap.FocusedRowHandle, colQuycach, vRow[0]["Quycach"].ToString());
                        gvPhieuNhap.SetRowCellValue(gvPhieuNhap.FocusedRowHandle, colSoluong, dSL);
                        fQuydoile2thung(dSL);
                        gvPhieuNhap.CloseEditor();
                        gvPhieuNhap.ShowEditor();
                        gvPhieuNhap.FocusedColumn = colSoluong;
                    }
                }
            }
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    if (gvPhieuNhap.GetFocusedRowCellValue(colPhieunxctid) == null || gvPhieuNhap.GetFocusedRowCellValue(colPhieunxctid).ToString() == "")
                    {
                        e.Handled = true;
                        return;
                    }
                    if (Utils.ConfirmMessage(String.Format("Bạn có chắc muốn xóa {0} không ?", gvPhieuNhap.GetRowCellValue(gvPhieuNhap.FocusedRowHandle, colMasp).ToString()), "Xác nhận xóa") == true)
                    {
                        gvPhieuNhap.DeleteRow(gvPhieuNhap.FocusedRowHandle);
                    }
                }
                catch (Exception ex) { ex.Data.Clear(); }
            }
        }

        private void loadProductToLookupEdit(DataTable otblSP)
        {
            repositoryItems1.DataSource = otblSP;
            repositoryItems1.ValueMember = "Masp";
            repositoryItems1.DisplayMember = "Masp";
            repositoryItems1.NullText = "";
            colMasp.ColumnEdit = repositoryItems1;
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

        private void gvPhieuNhap_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)  
        {
            if (isEdit == false) { return; }

            if (gvPhieuNhap.FocusedColumn.FieldName == "Dongia" && e.Column.Name == "colDongia")
            {
                if (gvPhieuNhap.GetRowCellValue(e.RowHandle, colSoluong) != null
                    && gvPhieuNhap.GetRowCellValue(e.RowHandle, colSoluong).ToString() != ""
                    && gvPhieuNhap.GetRowCellValue(e.RowHandle, colSLThung) != null
                    && gvPhieuNhap.GetRowCellValue(e.RowHandle, colSLThung).ToString() != "")
                {
                    fThanhTien(e.RowHandle);
                }
            }

            else if (gvPhieuNhap.FocusedColumn.FieldName == "Vat" && e.Column.Name == "colVat")
            {
                if (gvPhieuNhap.GetRowCellValue(e.RowHandle, colSoluong).ToString() != "" && gvPhieuNhap.GetRowCellValue(e.RowHandle, colSLThung).ToString() != "")
                {
                    fThanhTien(e.RowHandle);
                }
            }

            else if (gvPhieuNhap.FocusedColumn.FieldName == "SLThung" && e.Column.Name == "colSLThung")
            {
                Double slThung = 0;

                Double.TryParse(gvPhieuNhap.GetRowCellValue(e.RowHandle, colSLThung).ToString(), out slThung);
                fQuydoithung(slThung);
                if (gvPhieuNhap.GetRowCellValue(gvPhieuNhap.FocusedRowHandle, colDongia).ToString() != "")
                {
                    fThanhTien(gvPhieuNhap.FocusedRowHandle);
                }
            }

            else if (gvPhieuNhap.FocusedColumn.FieldName == "Soluong" && e.Column.Name == "colSoluong")
            {
                Double slLe = 0;
                Double.TryParse(gvPhieuNhap.GetRowCellValue(gvPhieuNhap.FocusedRowHandle, colSoluong).ToString(), out slLe);
                fQuydoile2thung(slLe);
                if (gvPhieuNhap.GetRowCellValue(gvPhieuNhap.FocusedRowHandle, colDongia).ToString() != "")
                {
                    fThanhTien(gvPhieuNhap.FocusedRowHandle);
                }
            }
            
        }

        private void gvPhieuNhap_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (e.Row == null) return;
            if (gvPhieuNhap.GetRowCellValue(e.RowHandle, colMasp) == null || gvPhieuNhap.GetRowCellValue(e.RowHandle, colMasp).ToString() == "")
            {
                e.ErrorText = "Bạn chưa nhập mã hàng hóa..";
                e.Valid = false;
                return;
            }

            double dDG = 0, dSL = 0;
            try
            {
                Double.TryParse(gvPhieuNhap.GetRowCellValue(e.RowHandle, colDongia).ToString(), out dDG);
                Double.TryParse(gvPhieuNhap.GetRowCellValue(e.RowHandle, colSoluong).ToString(), out dSL);
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
                Double.TryParse(gvPhieuNhap.GetRowCellValue(e.RowHandle, colVat).ToString(), out dVAT);
                dNguyente = Math.Round(dSL * dDG, 0, MidpointRounding.AwayFromZero);
                if (dVAT > 0)
                {
                    dTTVAT = Math.Round(dNguyente * dVAT / 100, 0, MidpointRounding.AwayFromZero);
                }

                Double.TryParse(gvPhieuNhap.GetRowCellValue(e.RowHandle, colNguyente).ToString(), out dNguyenteRow);
                Double.TryParse(gvPhieuNhap.GetRowCellValue(e.RowHandle, colTTVat).ToString(), out dTTVatRow);
                Double.TryParse(gvPhieuNhap.GetRowCellValue(e.RowHandle, colThanhtien).ToString(), out dThanhtienRow);

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
                gvPhieuNhap.UpdateCurrentRow();
            }
            catch { } 
        }

        private void NX_PhieuNhap_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
                if (pPhieuNXID == "")
                {
                    Utils.showMessage("Bạn chưa chọn phiếu để in...", "Lưu ý");
                }
                new MTReport().rptNX_Phieunhap(pPhieuNXID);
            }
            else if (e.KeyCode == Keys.F8)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                BindData();
                setReadOnly(true);
                MTGlobal.SetButtonAction(pACT_ROLE, MTButton, "ABORT");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnExit1_Click(sender, e);
        }

        private void txtMakho_Leave(object sender, EventArgs e)
        {
            
        }

        private void gvPhieuNhap_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
          
        }

        private void gvPhieuNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var editObj = ((DevExpress.XtraGrid.Views.Grid.GridView)(sender)).EditingValue;

                if (gvPhieuNhap.FocusedColumn.FieldName == "Masp" && gvPhieuNhap.FocusedColumn.Name == "colMasp")
                {
                    if (gvPhieuNhap.GetFocusedRowCellValue(colMasp) == null)  // || gvPhieuNhap.GetFocusedRowCellValue(colMasp).ToString() == ""
                    {
                        gvPhieuNhap.FocusedColumn = colMasp;
                        return;
                    }
                    //String sMasp = gvPhieuNhap.GetRowCellValue(gvPhieuNhap.FocusedRowHandle, colMasp).ToString();
                    String sMasp;
                    
                    sMasp = editObj != null ? editObj.ToString() : "";
                    if (sMasp == null || sMasp == "")
                    {
                        gvPhieuNhap.FocusedColumn = colMasp;
                        return;
                    }

                    DataRow[] vRow = otblSP.Select(string.Format("Masp='{0}'", sMasp));
                    if (vRow.Length > 0)
                    {
                        double dSL = 0;
                        try
                        {
                            double.TryParse(gvPhieuNhap.GetRowCellValue(gvPhieuNhap.FocusedRowHandle, colSoluong).ToString(), out dSL);
                            if (dSL == 0) { dSL = 1; }
                        }
                        catch { dSL = 1; }
                        gvPhieuNhap.SetRowCellValue(gvPhieuNhap.FocusedRowHandle, colMasp, sMasp);
                        gvPhieuNhap.SetRowCellValue(gvPhieuNhap.FocusedRowHandle, colTensp, vRow[0]["Tensp"].ToString());
                        gvPhieuNhap.SetRowCellValue(gvPhieuNhap.FocusedRowHandle, colDvt, vRow[0]["Dvt"].ToString());
                        gvPhieuNhap.SetRowCellValue(gvPhieuNhap.FocusedRowHandle, colQuycach, vRow[0]["Quycach"].ToString());
                        gvPhieuNhap.SetRowCellValue(gvPhieuNhap.FocusedRowHandle, colSoluong, dSL);
                        fQuydoile2thung(dSL);
                        gvPhieuNhap.CloseEditor();
                        gvPhieuNhap.ShowEditor();
                        gvPhieuNhap.FocusedColumn = colSoluong;
                    }
                }
          
            }
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
        
    }
}
