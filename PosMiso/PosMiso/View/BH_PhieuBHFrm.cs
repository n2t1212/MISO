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
    public partial class BH_PhieuBHFrm : Form
    {
        MTGlobal.MT_ROLE pACT_ROLE;
        private MTGlobal.MT_TOOL_TRIP_BUTTONACTION MTButton;

        private string pPhieuID = "";
        private string pDenNgay = "";
        private string pTuNgay = "";
        private String pLoaiPhieu = "";
        private DataTable otblBH = null;
        private DataTable otblBHCT = null;
        private DataTable otblKH = null;

        private bool isEdit = false;
        DevExpress.Utils.WaitDialogForm Dlg;

        private DataTable otblSP = null;

        Timer oTimerClock;

        public BH_PhieuBHFrm()
        {
            InitializeComponent();
        }

        public BH_PhieuBHFrm(String mPhieuID, String mLoaiPhieu, String mTuNgay, String mDenNgay, MTGlobal.MT_ROLE mActRole, bool isAddNew = false)
        {
            InitializeComponent();         
            this.pPhieuID = mPhieuID;
            this.pTuNgay = mTuNgay == "" ? DateTime.Now.ToShortDateString() : mTuNgay;
            this.pDenNgay = mDenNgay == "" ? DateTime.Now.ToShortDateString() : mDenNgay;
            this.pLoaiPhieu = mLoaiPhieu;
            this.pACT_ROLE = mActRole;

            this.txtQuay.Text = MTGlobal.MT_QUAY;
            this.txtCa.Text = MTGlobal.MT_CA;
            this.txtThuNgan.Text = MTGlobal.MT_USER_LOGIN_FULLNAME;

            Dlg= Utils.shwWait();
            setUserRight();
            loadCustomerToLookupEdit();
            if (isAddNew){
                fdoAdd();
            }
            else {
                BindData();
                SysPar.SetGridReadOnly(true, gvPhieuBH);
                setReadOnly(true);
            }
            
            System.Threading.Thread oThreSP = new System.Threading.Thread(LoadSanPham);
            oThreSP.Start();

            oTimerClock = new Timer();
            oTimerClock.Tick += oTimerClock_Tick;
            oTimerClock.Interval = 1000;
            oTimerClock.Enabled = true;

            Utils.closeWait(Dlg);
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
            //MTButton.cmdPrint = this.cmdPrint;
            MTGlobal.SetToolStripButtonAction(pACT_ROLE, MTButton, "INIT");
        }

        private void setReadOnly(bool isReadonly = false)
        {
            dtpNgaylap.Enabled = !isReadonly;
            chkKHmoi.Enabled = !isReadonly;
            chkVIP.Enabled = !isReadonly;
            txtMadv.Enabled = !isReadonly;
            txtTendonvi.Enabled = !isReadonly;
            txtDienthoai.Enabled = !isReadonly;
            txtDiachi.Enabled = !isReadonly;
            txtGhichu.Enabled = !isReadonly;

            txtTongCK.Enabled = !isReadonly;
            txtTongTTCK.Enabled = !isReadonly;
            txtBarCode.Enabled = !isReadonly;
            txtBarCodeNo.Enabled = !isReadonly;
            txtTientra.Enabled = !isReadonly;
            cmdPrint.Enabled = !isReadonly;
            cmdSave.Enabled = !isReadonly;
            cmdPrint.Enabled = !isReadonly;

        }

        private void LoadSanPham()
        {
            try
            {
                String mSql = "SELECT Maspid,Manhomspid,Masp,Tensp,Dvt,Quycach,Quydoikgl,Quydoithung,Nhacungcap,Maqrcode,Mabarcode FROM DM_SANPHAM with(nolock) order by Masp asc";
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


        private void BindData()
        {
            try
            {
                txtMadv.Text = "";
                txtTendonvi.Text = "";
                txtDiachi.Text = "";
                txtDienthoai.Text = "";
                txtGhichu.Text = "";

                txtBarCode.Text = "";
                txtBarCodeNo.Text = "";

                txtThanhtien.Text = "";
                txtTongCK.Text = "";
                txtTongTTCK.Text = "";
                txtThanhtoan.Text = "";
                txtTientra.Text = "";
                txtTienthua.Text = "";

                chkKHmoi.Checked = false;
                chkVIP.Checked = false;

                if (pPhieuID != "")
                {
                    String mSql = String.Format("SELECT A.* FROM BH_PHIEUBH A WHERE A.Phieubhid='{0}'", pPhieuID);
                    otblBH = new MTSQLServer().wRead(mSql, null, false);
                    if (otblBH != null)
                    {
                        foreach (DataRow vR in otblBH.Rows)
                        {
                            txtSophieu.Text = vR["Sophieu"].ToString();
                            dtpNgaylap.EditValue = vR["Ngayct"].ToString() != "" ? Convert.ToDateTime(vR["Ngayct"].ToString()).ToShortDateString() : "";
                            txtMadv.Text = vR["Makh"].ToString();
                            txtTendonvi.Text = vR["tenkh"].ToString();
                            txtDienthoai.Text = vR["dienthoai"].ToString();
                            txtDiachi.Text = vR["diachi"].ToString();
                            txtGhichu.Text = vR["ghichu"].ToString();

                            txtQuay.Text = vR["Quay"].ToString();
                            txtCa.Text = vR["Ca"].ToString();
                            txtThuNgan.Text = vR["Thungan"].ToString();

                            txtThanhtien.Text = Utils.formatNumber(vR["Nguyente"].ToString());
                            txtTongCK.Text = Utils.formatNumber(vR["Ck"].ToString());
                            txtTongTTCK.Text = Utils.formatNumber(vR["TTCk"].ToString());
                            txtThanhtien.Text = Utils.formatNumber(vR["Thanhtien"].ToString());
                            txtTientra.Text = Utils.formatNumber(vR["Tientra"].ToString());
                            txtTienthua.Text = Utils.formatNumber(vR["Tienthoi"].ToString());
                            if (vR["LoaiKH"] != null && vR["LoaiKH"].ToString() == "VIP")
                            {
                                chkVIP.Checked = true;
                            }
                            else
                            {
                                chkVIP.Checked = false;
                            }
                        }
                    }
                }

                otblBHCT = new MTSQLServer().wRead(String.Format("SELECT * FROM BH_PHIEUBHCT where Phieubhid='{0}' ORDER BY Quatang, Phieubhctid asc", pPhieuID), null, false);
                grdPhieuBH.DataSource = otblBHCT;
                SysPar.SetGridReadOnly(false, gvPhieuBH);
            }
            catch { }
        }

        //private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        //{
        //    try
        //    {
        //        Regex regex = new Regex("[^0-9]+");
        //        e.Handled = regex.IsMatch(e.Text);
        //    }
        //    catch { }
        //}

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

            Double dThanhTienF = 0, dTongTTCKF = 0, dTientra = 0;
            Double.TryParse(txtThanhtien.Text, out dThanhTienF);
            Double.TryParse(txtTongTTCK.Text, out dTongTTCKF);
            Double.TryParse(txtTientra.Text, out dTientra);

            if (dThanhTienF <= 0)
            {
                Utils.showMessage("Số tiền đơn hàng phải >0", "Thông báo");
                txtThanhtien.Focus();
                return false;
            }
            if (dThanhTienF <= 0)
            {
                Utils.showMessage("Bạn chưa nhập số tiền khách trả..", "Thông báo");
                txtTientra.Focus();
                return false;
            }

            gvPhieuBH.CloseEditor();
            otblBHCT.AcceptChanges();
            if (otblBHCT == null || otblBHCT.Rows.Count == 0)
            {
                Utils.showMessage("Bạn chưa nhập chi tiết bán hàng.", "Thông báo");
                if (SysPar.SetGridReadOnly(false, gvPhieuBH))
                {
                    gvPhieuBH.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                    gvPhieuBH.FocusedRowHandle = GridControl.NewItemRowHandle;
                    gvPhieuBH.FocusedColumn = gvPhieuBH.VisibleColumns[0];
                    gvPhieuBH.ShowEditor();
                }
                return false;
            }
            return true;
        }

        private void fThanhTienRow(int iRowHander)
        {
            try
            {
                String sSL = "0", sDG = "0", sCK = "0", sTTCK = "0";
                sSL = gvPhieuBH.GetRowCellValue(iRowHander, colSoluong).ToString();
                sDG = gvPhieuBH.GetRowCellValue(iRowHander, colDongia).ToString();
                sCK = gvPhieuBH.GetRowCellValue(iRowHander, colCk).ToString();

                Double dGia, dSL, dCk, dTTCk;
                Double.TryParse(sDG, out dGia);
                Double.TryParse(sSL, out dSL);
                Double.TryParse(sCK, out dCk);

                if (dSL > 0 && dGia > 0)
                {
                    gvPhieuBH.SetRowCellValue(iRowHander, colNguyente, Math.Round(dSL * dGia, 0, MidpointRounding.AwayFromZero));
                    if (dCk > 0)
                    {
                        dTTCk = Math.Round(dCk * dSL * dGia / 100, 0, MidpointRounding.AwayFromZero);
                        gvPhieuBH.SetRowCellValue(iRowHander, colTTCk, dTTCk);
                    }
                    sTTCK = gvPhieuBH.GetRowCellValue(iRowHander, colTTCk).ToString();
                    Double.TryParse(sTTCK, out dTTCk);

                    gvPhieuBH.SetRowCellValue(iRowHander, colThanhtien, Math.Round(dSL * dGia - dTTCk, 0, MidpointRounding.AwayFromZero));
                }
                else
                {
                    gvPhieuBH.SetRowCellValue(iRowHander, colNguyente, 0);
                    gvPhieuBH.SetRowCellValue(iRowHander, colTTCk, 0);
                    gvPhieuBH.SetRowCellValue(iRowHander, colThanhtien, 0);
                }
            }
            catch { }
        }

        private void fTinhTong()
        {
            try
            {
                try { gvPhieuBH.PostEditor(); gvPhieuBH.RefreshData(); }
                catch { }

                Double dThanhtien = 0, dThanhtienTmp = 0, dTongTTCK = 0, dTongTTCKTmp = 0;
                for (int i = 0; i < gvPhieuBH.RowCount; i++)
                {
                    int iRowHandle = gvPhieuBH.GetRowHandle(i);
                    try
                    {
                        DataRowView vR = (System.Data.DataRowView)gvPhieuBH.GetRow(iRowHandle);
                        if (vR["Quatang"].ToString() != "1" && vR["Quatang"].ToString() != "True")
                        {
                            Double.TryParse(vR.Row["Nguyente"].ToString(), out dThanhtienTmp);
                            Double.TryParse(vR.Row["TTCk"].ToString(), out dTongTTCKTmp);
                            dThanhtien += dThanhtienTmp;
                            dTongTTCK += dTongTTCKTmp;
                        }
                    }
                    catch { }
                }
                if (dTongTTCK > 0)
                {
                    txtTongCK.Text = "0";
                }
                else
                {
                    Double dTongCK = 0;
                    Double.TryParse(txtTongCK.Text.Trim(), out dTongCK);
                    dTongTTCK = Math.Round(dThanhtien * dTongCK / 100, 0, MidpointRounding.AwayFromZero);
                }

                string thanhTien =  Math.Round(dThanhtien, 0, MidpointRounding.AwayFromZero).ToString();
                txtThanhtien.Text = Utils.formatNumber(thanhTien);

                string tongTTCK = Math.Round(dTongTTCK, 0, MidpointRounding.AwayFromZero).ToString();
                txtTongTTCK.Text = Utils.formatNumber(tongTTCK);

                string thanhToan = Math.Round(dThanhtien - dTongTTCK, 0, MidpointRounding.AwayFromZero).ToString();
                txtThanhtoan.Text = Utils.formatNumber(thanhToan);

            }
            catch { }
        }

        private void fTinhThanhToan()
        {
            try
            {
                Double dThanhtien = 0, dCK = 0, dTTCK = 0, dThanhtoan = 0, dTientra = 0, dTienthoi = 0;
                Double.TryParse(txtThanhtien.Text.ToString(), out dThanhtien);
                Double.TryParse(txtTongCK.Text.ToString(), out dCK);
                if (dCK > 0)
                {
                    dTTCK = dThanhtien * dCK / 100;
                }
                else
                {
                    Double.TryParse(txtTongTTCK.Text.ToString(), out dTTCK);
                }
                Double.TryParse(txtTientra.Text.ToString(), out dTientra);

                dThanhtoan = Math.Round(dThanhtien - dTTCK, 0, MidpointRounding.AwayFromZero);
                dTienthoi = Math.Round(dTientra - dThanhtoan, 0, MidpointRounding.AwayFromZero);

                txtTongTTCK.Text = Utils.formatNumber(dTTCK.ToString());
                txtThanhtoan.Text = Utils.formatNumber(dThanhtoan.ToString());
                txtTienthua.Text = Utils.formatNumber(dTienthoi.ToString());
            }
            catch { }
        }

        private void fQuydoithung(int iRowHander)
        {
            try
            {
                String sMasp = "";
                sMasp = gvPhieuBH.GetRowCellValue(iRowHander, colMasp).ToString();
                if (otblSP != null && otblSP.Rows.Count > 0)
                {
                    DataRow[] vRow = otblSP.Select(string.Format("Masp='{0}'", sMasp));
                    if (vRow.Length > 0)
                    {
                        Double dSLThung = 0, dQDThung = 0, dSLQD = 0;
                        Double.TryParse(vRow[0]["Quydoithung"].ToString(), out dQDThung);
                        Double.TryParse(gvPhieuBH.GetRowCellValue(iRowHander, colSLThung).ToString(), out dSLThung);
                        dSLQD = Math.Round(dSLThung * dQDThung, 0, MidpointRounding.AwayFromZero);
                        gvPhieuBH.SetRowCellValue(iRowHander, colSoluong, dSLQD);
                    }
                }
            }
            catch { }
        }

        private void fdoAdd()
        {
            try
            {
                int mMM = int.Parse(Convert.ToDateTime(pDenNgay).Month.ToString().PadLeft(2, '0'));
                int mYY = int.Parse(Convert.ToDateTime(pDenNgay).Year.ToString());
                pPhieuID = MTGlobal.GetNewID();
                txtSophieu.Text = MTGlobal.GetSophieu(MTGlobal.MT_KYHIEU_CUAHANG, this.pLoaiPhieu, mMM, mYY, MTGlobal.MT_USER_LOGIN).ToString();
                dtpNgaylap.Text = DateTime.Now.ToShortDateString();

                BindData();
                if (SysPar.SetGridReadOnly(false,gvPhieuBH))
                {
                    gvPhieuBH.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                    gvPhieuBH.FocusedRowHandle = GridControl.NewItemRowHandle;
                    gvPhieuBH.FocusedColumn = gvPhieuBH.VisibleColumns[0];
                    gvPhieuBH.ShowEditor();
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
            if (SysPar.SetGridReadOnly(false, gvPhieuBH))
            {
                gvPhieuBH.FocusedRowHandle = GridControl.NewItemRowHandle;
                gvPhieuBH.FocusedColumn = gvPhieuBH.VisibleColumns[0];
                gvPhieuBH.ShowEditor();
            }
        }

        private void fdoSave()
        {
            if (fValidate())
            {
                DataTable tmpBH = new modPhieuBH().dtPhieuBH();
                DataRow vR = tmpBH.NewRow();
                vR["Phieubhid"] = pPhieuID;
                vR["Sophieu"] = txtSophieu.Text.ToUpper();
                vR["Ngayct"] = Convert.ToDateTime(dtpNgaylap.Text);
                vR["Ngayps"] = Convert.ToDateTime(dtpNgaylap.Text);
                vR["Loaiphieu"] = this.pLoaiPhieu;

                vR["Makh"] = txtMadv.Text;
                vR["Tenkh"] = txtTendonvi.Text;
                vR["Dienthoai"] = txtDienthoai.Text;
                vR["Diachi"] = txtDiachi.Text;
                vR["LoaiKH"] = (chkVIP.Checked == true ? "VIP" : "NORMAL");
                vR["Khmoi"] = (chkKHmoi.Checked == true ? 1 : 0);
                vR["Quay"] = txtQuay.Text;
                vR["Ca"] = txtCa.Text;
                vR["Thungan"] = txtThuNgan.Text;

                vR["Nguyente"] = txtThanhtien.Text;
                vR["Ck"] = txtTongCK.Text == "" ? "0" : txtTongCK.Text;
                vR["TTCk"] = txtTongTTCK.Text == "" ? "0" : txtTongTTCK.Text;
                vR["Thanhtien"] = txtThanhtoan.Text;

                vR["Tientra"] = txtTientra.Text == "" ? "0" : txtTientra.Text;
                vR["Tienthoi"] = txtTienthua.Text == "" ? "0" : txtTienthua.Text;

                vR["Ghichu"] = txtGhichu.Text;
                vR["Ngaylap"] = DateTime.Now;
                vR["Nguoilap"] = MTGlobal.MT_USER_LOGIN;
                vR["TKNo"] = MTGlobal.TK_NO;
                vR["TKCo"] = MTGlobal.TK_CO;
                tmpBH.Rows.Add(vR);
                tmpBH.AcceptChanges();

                DataTable tmpBHCT = new modPhieuBH().dtPhieuBHCT();
                //gvPhieuBH.CommitEditing();
                gvPhieuBH.CloseEditor();
                otblBHCT.AcceptChanges();

                foreach (DataRow sR in otblBHCT.Rows)
                {
                    DataRow cR = tmpBHCT.NewRow();
                    cR["Phieubhctid"] = sR["Phieubhctid"];
                    cR["Phieubhid"] = pPhieuID;
                    cR["Mavach"] = sR["Mavach"];
                    cR["Maspid"] = sR["Maspid"];
                    cR["Masp"] = sR["Masp"];
                    cR["Tensp"] = sR["Tensp"];
                    cR["Dvt"] = sR["Dvt"];
                    cR["Quycach"] = sR["Quycach"];
                    cR["SLThung"] = sR["SLThung"];
                    cR["Soluong"] = sR["Soluong"];
                    cR["Dongia"] = sR["Dongia"];
                    cR["Nguyente"] = sR["Nguyente"];
                    cR["Ck"] = sR["Ck"];
                    cR["TTCk"] = sR["TTCk"];
                    cR["Thanhtien"] = sR["Thanhtien"];
                    cR["Quatang"] = sR["Quatang"];
                    cR["Ghiso"] = 1;
                    cR["Ghichu"] = sR["Ghichu"];
                    tmpBHCT.Rows.Add(cR);
                }
                tmpBHCT.AcceptChanges();

                //gvPhieuBH.CommitEditing();
                gvPhieuBH.CloseEditor();
                otblBHCT.AcceptChanges();

                String Rs = new modPhieuBH().SavePhieuBH(tmpBH, tmpBHCT, MTGlobal.MT_USER_LOGIN);
                if (Rs == "")
                {
                    String msg = new modPhieuBH().SaveDiemTichLuy(txtMadv.Text.ToString().ToUpper(), tmpBHCT);

                    setReadOnly(true);
                    MTGlobal.SetToolStripButtonAction(pACT_ROLE, MTButton, "SAVE");
                    SysPar.SetGridReadOnly(true, gvPhieuBH);
                    isEdit = false;
                }
                else
                {
                    Utils.showMessage(Rs, "Thông báo");
                }
            }
        }

        private void oTimerClock_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            lblTime.Text = "[" + d.ToShortDateString() + " " + d.Hour.ToString() + ":" + d.Minute.ToString() + ":" + d.Second.ToString() + "]";
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

        private void fdoPrint()
        {
            if (pPhieuID == "")
            {
                Utils.showMessage("Bạn chưa chọn phiếu để in..", "Lưu ý");
                return;
            }

            Double dTientra = 0;
            Double.TryParse(txtTientra.Text, out dTientra);
            if (dTientra <= 0)
            {
                Utils.showMessage("Bạn chưa nhập tiền khách trả...", "Lưu ý");
                return;
            }

            if (isEdit)
            {
                fdoSave();
            }
            new MTReport().rptBH_InBill(pPhieuID);
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
            fdoPrint();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            fdoEdit();
        }

        private void cmdDel_Click(object sender, EventArgs e)
        {
            if (pPhieuID == "")
            {
                Utils.showMessage("Bạn chưa chọn phiếu cần xóa..", "Lưu ý");
                return;
            }
            if (Utils.ConfirmMessage("Bạn có chắc muốn xóa phiếu này?", "Xác nhận"))
            {
                if (new modPhieuBH().DelPhieuBH(pPhieuID))
                {
                    pPhieuID = "";
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

        private void cmdSave_Click(object sender, EventArgs e)
        {
            fdoSave();
        }

        private void fdoExit()
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

        private void fdoAbort()
        {
            setReadOnly(true);
            MTGlobal.SetToolStripButtonAction(pACT_ROLE, MTButton, "ABORT");
        }

        private void gvPhieuBH_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            try
            {
                gvPhieuBH.SetRowCellValue(e.RowHandle, colPhieubhctid, MTGlobal.GetNewID());
                gvPhieuBH.SetRowCellValue(e.RowHandle, colPhieubhid, pPhieuID);
            }
            catch { }
        }

        private void cmdViewStock()
        {
            if (pDenNgay == "")
            {
                Utils.showMessage("Không xác định được ngày kết tồn kho..", "Thông báo");
                return;
            }

            DataTable oTblSPC = new DataTable();
            oTblSPC.Columns.Add("Maspid", typeof(System.String));
            oTblSPC.Columns.Add("Masp", typeof(System.String));

            dlg_TonKho oTonkho = new dlg_TonKho(oTblSPC, pDenNgay);
            oTonkho.ShowDialog();
        }

        private void gvPhieuBH_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (isEdit == false) { return; }

                if (gvPhieuBH.FocusedColumn.FieldName == "Dongia" && e.Column.Name == "colDongia")
                {
                    if (gvPhieuBH.GetRowCellValue(e.RowHandle, colDongia).ToString() != "" && gvPhieuBH.GetRowCellValue(e.RowHandle, colSoluong).ToString() != "")
                    {
                        fThanhTienRow(e.RowHandle);
                    }
                }
                else if (gvPhieuBH.FocusedColumn.FieldName == "SLThung" && e.Column.Name == "colSLThung")
                {
                    fQuydoithung(e.RowHandle);
                    fThanhTienRow(e.RowHandle);
                }
                else if (gvPhieuBH.FocusedColumn.FieldName == "Soluong" && e.Column.Name == "colSoluong")
                {
                    if (gvPhieuBH.GetRowCellValue(e.RowHandle, colDongia).ToString() != "" && gvPhieuBH.GetRowCellValue(e.RowHandle, colSoluong).ToString() != "")
                    {
                        fThanhTienRow(e.RowHandle);
                    }
                }
                else if (gvPhieuBH.FocusedColumn.FieldName == "Ck" && e.Column.Name == "colCk")
                {
                    if (gvPhieuBH.GetRowCellValue(e.RowHandle, colDongia).ToString() != "" && gvPhieuBH.GetRowCellValue(e.RowHandle, colSoluong).ToString() != "")
                    {
                        fThanhTienRow(e.RowHandle);
                    }
                }
                else if (gvPhieuBH.FocusedColumn.FieldName == "TTCk" && e.Column.Name == "colTTCk")
                {
                    Double dcolCK = 0;
                    Double.TryParse(gvPhieuBH.GetRowCellValue(e.RowHandle, colCk).ToString(), out dcolCK);
                    gvPhieuBH.SetRowCellValue(e.RowHandle, colCk, 0);
                    if (dcolCK <= 0)
                    {
                        fThanhTienRow(e.RowHandle);
                    }
                }
            }
            catch { }
        }

        private void gvPhieuBH_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (e.ErrorText != "")
            {
                Utils.showMessage(e.ErrorText.ToString(), "Lưu ý", "ERR");
            }
            e.ExceptionMode = ExceptionMode.NoAction;   
        }

        private void gvPhieuBH_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                
                if (e.Row == null) return;
                if (gvPhieuBH.GetRowCellValue(e.RowHandle, colMasp) == null || gvPhieuBH.GetRowCellValue(e.RowHandle, colMasp).ToString() == "")
                {
                    e.ErrorText = "Bạn chưa nhập mã hàng hóa.." ;
                    e.Valid = false;
                    return;
                }
                double dDG = 0, dSL = 0;
                try
                {
                    Double.TryParse(gvPhieuBH.GetRowCellValue(e.RowHandle, colDongia).ToString(), out dDG);
                    Double.TryParse(gvPhieuBH.GetRowCellValue(e.RowHandle, colSoluong).ToString(), out dSL);
                }
                catch { }

                String isQuatang = "";
                try
                {
                    isQuatang = gvPhieuBH.GetRowCellValue(e.RowHandle, colQuatang).ToString();
                }
                catch { }
                if (isQuatang != "True")
                {
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
                    e.Valid = true;
                    fTinhTong();
                }
            }
            catch { }
        }

        private void BH_PhieuBHFrm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
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
                    fdoAbort();
                }
                else if (e.KeyCode == Keys.F9)
                {
                    cmdViewStock();
                }
                else if (e.KeyCode == Keys.Q && e.KeyCode == Keys.ControlKey)
                {
                    if (isEdit)
                    {
                        txtBarCode.Focus();
                        txtBarCode.SelectAll();
                    }
                }
                else if (e.KeyCode == Keys.I && e.KeyCode == Keys.ControlKey)
                {
                    if (isEdit)
                    {
                        grdPhieuBH.Focus();
                        gvPhieuBH.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                        gvPhieuBH.FocusedRowHandle = GridControl.NewItemRowHandle;
                        gvPhieuBH.FocusedColumn = colMasp;
                        gvPhieuBH.ShowEditor();
                    }
                }
            }
            catch { }

        }

        private void cmdStock_Click(object sender, EventArgs e)
        {
            cmdViewStock();
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
        

        private void txtBarCode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (isEdit == false) { return; }
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtBarCode.Text.Trim() != "" && txtBarCode.Text.Length > 2)
                    {
                        String mCode = "";
                        Double mDongia = 0;
                        if (txtBarCode.Text.IndexOf("$") > 0)
                        {
                            String[] mBarcode = txtBarCode.Text.Split('$');
                            if (mBarcode.Length > 1)
                            {
                                mCode = mBarcode[0];
                                Double.TryParse(mBarcode[1], out mDongia);
                            }
                            else if (mBarcode.Length > 1)
                            {
                                mCode = mBarcode[0];
                            }
                        }
                        else
                        {
                            mCode = txtBarCode.Text.Trim();
                        }
                        AddBarCode(mCode, 1, mDongia);

                        txtBarCode.Text = mCode;
                        txtBarCode.SelectionStart = 0;
                        txtBarCode.SelectAll();
                    }
                }
                catch (Exception ex) { Utils.showMessage("Không thể xử lý dữ liệu mã code:" + ex.Message.ToString()); }
            }
        }

        private void AddBarCode(String mBarcode, int mSL = 0, Double mDongia = 0)
        {
            try
            {
                if (mBarcode != "")
                {
                    DataRow[] vRow = null;
                    Double dNguyente = 0, dQDThung = 0, dSL = 0, dSLThung = 0;
                    String mCode = mBarcode.Substring(1, mBarcode.Length - 1);
                    bool isThung = (mBarcode.Substring(0, 1) == "1" || mBarcode.Substring(0, 1) == "A") ? true : false;

                    if (otblSP != null)
                    {
                        vRow = otblSP.Select(string.Format("Maqrcode='{0}' or Mabarcode='{1}'", mCode, mCode));
                    }

                    if (vRow != null && vRow.Length > 0)
                    {
                        foreach (DataRow vR in vRow)
                        {
                            if (vR["Masp"].ToString() != "")
                            {
                                if (FindBarcodeExists(vR["Masp"].ToString(), mSL, isThung, vR) == true)
                                {
                                    return;
                                }

                                if (isThung)
                                {
                                    dSLThung = mSL;
                                    if (mDongia <= 0)
                                    {
                                        mDongia = MTGlobal.GetDonGia(vR["Masp"].ToString(), pDenNgay, "SI");
                                    }
                                    Double.TryParse(vR["Quydoithung"].ToString(), out dQDThung);
                                    dSL = Math.Round(dQDThung * mSL, 0, MidpointRounding.AwayFromZero);
                                    dNguyente = Math.Round(dSLThung * mDongia, 0, MidpointRounding.AwayFromZero);
                                    if (dSL > 0)
                                    {
                                        mDongia = Math.Round(mDongia / dSL, 0, MidpointRounding.AwayFromZero);
                                    }
                                }
                                else
                                {
                                    dSLThung = 0;
                                    dSL = mSL;
                                    if (mDongia <= 0)
                                    {
                                        mDongia = MTGlobal.GetDonGia(vR["Masp"].ToString(), pDenNgay);
                                    }
                                    dNguyente = Math.Round(dSL * mDongia, 0, MidpointRounding.AwayFromZero);
                                }

                                DataRow vRBH = otblBHCT.NewRow();
                                vRBH["Phieubhctid"] = MTGlobal.GetNewID();
                                vRBH["Phieubhid"] = pPhieuID;
                                vRBH["Masp"] = vR["masp"];
                                vRBH["Tensp"] = vR["tensp"];
                                vRBH["Dvt"] = vR["dvt"];
                                vRBH["Quycach"] = vR["quycach"];
                                vRBH["SLThung"] = dSLThung;
                                vRBH["Soluong"] = dSL;
                                vRBH["Dongia"] = mDongia;
                                vRBH["Nguyente"] = dNguyente;
                                vRBH["Thanhtien"] = dNguyente;
                                vRBH["QDThung"] = dQDThung;
                                otblBHCT.Rows.Add(vRBH);

                                txtBarCode.SelectAll();
                                break;
                            }
                        }
                        otblBHCT.AcceptChanges();
                        grdPhieuBH.Refresh();
                        fTinhTong();
                    }
                    else
                    {
                        DataTable oTblBarcode = new MTSQLServer().wRead(String.Format("select top 1 Maspid,Masp,Tensp,Dvt,Quycach,Quydoithung from DM_SANPHAM where Mabarcode='{0}' OR Maqrcode='{1}'", mBarcode, mBarcode), null, false);
                        if (oTblBarcode != null && oTblBarcode.Rows.Count > 0)
                        {
                            foreach (DataRow vR in oTblBarcode.Rows)
                            {
                                if (vR["Masp"].ToString() != "")
                                {
                                    if (FindBarcodeExists(vR["Masp"].ToString(), mSL, isThung) == true)
                                    {
                                        return;
                                    }

                                    if (isThung)
                                    {
                                        dSLThung = mSL;
                                        if (mDongia <= 0)
                                        {
                                            mDongia = MTGlobal.GetDonGia(vR["Masp"].ToString(), pDenNgay, "SI");
                                        }
                                        Double.TryParse(vR["Quydoithung"].ToString(), out dQDThung);
                                        dSL = Math.Round(dQDThung * mSL, 0, MidpointRounding.AwayFromZero);
                                        dNguyente = Math.Round(dSLThung * mDongia, 0, MidpointRounding.AwayFromZero);
                                        if (dSL > 0)
                                        {
                                            mDongia = Math.Round(mDongia / dSL, 0, MidpointRounding.AwayFromZero);
                                        }
                                    }
                                    else
                                    {
                                        dSLThung = 0;
                                        dSL = mSL;
                                        if (mDongia <= 0)
                                        {
                                            mDongia = MTGlobal.GetDonGia(vR["Masp"].ToString(), pDenNgay);
                                        }
                                        dNguyente = Math.Round(dSL * mDongia, 0, MidpointRounding.AwayFromZero);
                                    }

                                    DataRow vRBH = otblBHCT.NewRow();
                                    vRBH["Phieubhctid"] = MTGlobal.GetNewID();
                                    vRBH["Phieubhid"] = pPhieuID;
                                    vRBH["Mavach"] = mBarcode;
                                    vRBH["Masp"] = vR["Masp"];
                                    vRBH["Tensp"] = vR["Tensp"];
                                    vRBH["Dvt"] = vR["Dvt"];
                                    vRBH["Quycach"] = vR["Quycach"];
                                    vRBH["SLThung"] = dSLThung;
                                    vRBH["Soluong"] = dSL;
                                    vRBH["Dongia"] = mDongia;
                                    vRBH["Nguyente"] = dNguyente;
                                    vRBH["Thanhtien"] = dNguyente;
                                    otblBHCT.Rows.Add(vRBH);

                                    txtBarCode.SelectAll();
                                    break;
                                }
                            }
                            otblBHCT.AcceptChanges();
                            grdPhieuBH.Refresh();
                            fTinhTong();
                        }
                    }
                }
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message.ToString()); }
        }

        private bool FindBarcodeExists(String mMasp, int iSL = 1, bool isThung = false, DataRow rowSanPham = null)
        {
            try
            {
                int mSL = 0;
                for (int i = 0; i < gvPhieuBH.DataRowCount; i++)
                {
                    int iRowHandle = gvPhieuBH.GetRowHandle(i);
                    try
                    {
                        DataRowView vR = (System.Data.DataRowView)gvPhieuBH.GetRow(iRowHandle);
                        if (vR == null)
                        {
                            continue;
                        }

                        // SLThung + 1
                        if (isThung)
                        {
                            if (vR.Row["Masp"].ToString().Trim() == mMasp.Trim())
                            {
                                // Set SLThung
                                int.TryParse(vR["SLThung"].ToString(), out mSL);
                                mSL = mSL + iSL;
                                gvPhieuBH.SetRowCellValue(iRowHandle, colSLThung, mSL);

                                // Set Soluong
                                Double currentSoLuong = 0;
                                Double dQDThung = 1;
                                Double.TryParse(vR["Soluong"].ToString(), out currentSoLuong);

                                if (rowSanPham != null)
                                {
                                    Double.TryParse(rowSanPham["Quydoithung"].ToString(), out dQDThung);
                                }

                                currentSoLuong += Math.Round(dQDThung * iSL, 0, MidpointRounding.AwayFromZero);
                                gvPhieuBH.SetRowCellValue(iRowHandle, colSoluong, currentSoLuong);

                                // Lay don gia theo don gia thung
                                Double mDonGiaSi = MTGlobal.GetDonGia(vR["Masp"].ToString(), pDenNgay, "SI");
                                Double mDongia = Math.Round(mDonGiaSi / dQDThung, 0, MidpointRounding.AwayFromZero);
                                gvPhieuBH.SetRowCellValue(iRowHandle, colDongia, mDongia);

                                fThanhTienRow(iRowHandle);
                                fTinhTong();
                                return true;
                            }
                        }

                        if (vR.Row["Masp"].ToString().Trim() == mMasp.Trim())
                        {
                            int.TryParse(vR["Soluong"].ToString(), out mSL);
                            mSL = mSL + iSL;
                            gvPhieuBH.SetRowCellValue(iRowHandle, colSoluong, mSL);
                            fThanhTienRow(iRowHandle);
                            fTinhTong();
                            return true;
                        }
                    }
                    catch { }
                }
            }
            catch { return false; }
            return false;
        }

        private bool RowExists(String mMasp, int iSL = 1)
        {
            try
            {
                int mSL = 0;
                for (int i = 0; i < gvPhieuBH.DataRowCount; i++)
                {
                    int iRowHandle = gvPhieuBH.GetRowHandle(i);
                    try
                    {
                        DataRowView vR = (System.Data.DataRowView)gvPhieuBH.GetRow(iRowHandle);
                        if (vR.Row["Masp"].ToString().Trim() == mMasp.Trim())
                        {
                            int.TryParse(vR["Soluong"].ToString(), out mSL);
                            mSL = mSL + iSL;
                            gvPhieuBH.SetRowCellValue(iRowHandle, colSoluong, mSL);
                            return true;
                        }
                    }
                    catch { }
                }
            }
            catch { return false; }
            return false;
        }

        private void txtTongCK_TextChanged(object sender, EventArgs e)
        {
            fTinhThanhToan();
        }

        private void txtTongTTCK_TextChanged(object sender, EventArgs e)
        {
            fTinhThanhToan();
        }

        private void txtTientra_TextChanged(object sender, EventArgs e)
        {
            fTinhThanhToan();
        }

        private void gvPhieuBH_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (isEdit == false) { return; }
                if (e.KeyCode == Keys.Enter)
                {
                    var editObj = ((DevExpress.XtraGrid.Views.Grid.GridView)(sender)).EditingValue;
                    if (gvPhieuBH.FocusedColumn.FieldName == "Masp" && gvPhieuBH.FocusedColumn.Name == "colMasp")
                    {
                        if (gvPhieuBH.GetFocusedRowCellValue(colMasp) == null)// || gvPhieuBH.GetFocusedRowCellValue(colMasp).ToString() == "")
                        {
                            gvPhieuBH.FocusedColumn = colMasp;
                            return;
                        }

                        //String sMasp = gvPhieuBH.GetRowCellValue(gvPhieuBH.FocusedRowHandle, colMasp).ToString();
                        String sMasp = editObj != null ? editObj.ToString() : "";
                        if (sMasp == null || sMasp == "")
                        {
                            gvPhieuBH.FocusedColumn = colMasp;
                            return;
                        }

                        if (sMasp != "")
                        {
                            double dSL = 0;
                            try
                            {
                                double.TryParse(gvPhieuBH.GetRowCellValue(gvPhieuBH.FocusedRowHandle, colSoluong).ToString(), out dSL);
                                if (dSL == 0) { dSL = 1; }
                            }
                            catch { dSL = 1; }


                            if (otblSP != null && otblSP.Rows.Count > 0)
                            {
                                DataRow[] vRow = otblSP.Select(string.Format("Masp='{0}'", sMasp));
                                if (vRow.Length > 0)
                                {
                                    gvPhieuBH.SetRowCellValue(gvPhieuBH.FocusedRowHandle, colTensp, vRow[0]["Tensp"].ToString());
                                    gvPhieuBH.SetRowCellValue(gvPhieuBH.FocusedRowHandle, colDvt, vRow[0]["Dvt"].ToString());
                                    gvPhieuBH.SetRowCellValue(gvPhieuBH.FocusedRowHandle, colQuycach, vRow[0]["Quycach"].ToString());

                                    Double dDGX = MTGlobal.GetDonGia(sMasp, pDenNgay);
                                    gvPhieuBH.SetRowCellValue(gvPhieuBH.FocusedRowHandle, colDongia, dDGX);
                                    gvPhieuBH.SetRowCellValue(gvPhieuBH.FocusedRowHandle, colSoluong, dSL);
                                    if (dDGX > 0)
                                    {
                                        Double dNguyente = Math.Round(dDGX * dSL, 0, MidpointRounding.AwayFromZero);
                                        gvPhieuBH.SetRowCellValue(gvPhieuBH.FocusedRowHandle, colNguyente, dNguyente);
                                        gvPhieuBH.SetRowCellValue(gvPhieuBH.FocusedRowHandle, colThanhtien, dNguyente);
                                    }

                                }
                              
                            }
                            gvPhieuBH.CloseEditor();
                            gvPhieuBH.ShowEditor();
                            gvPhieuBH.SetRowCellValue(gvPhieuBH.FocusedRowHandle, colMasp, sMasp);

                        }
                    }

                    else if (gvPhieuBH.FocusedColumn.FieldName == "Ghichu" && gvPhieuBH.FocusedColumn.Name == "colGhichu1")
                    {
                        gvPhieuBH.AddNewRow();
                        gvPhieuBH.FocusedColumn = colMasp;
                    }
                    //else if (gvPhieuBH.FocusedColumn.FieldName == "SLThung" && gvPhieuBH.FocusedColumn.Name == "colSLThung")
                    //{
                    //    fQuydoithung(gvPhieuBH.FocusedRowHandle);
                    //    fThanhTienRow(gvPhieuBH.FocusedRowHandle);
                    //}
                }
                if (e.KeyCode == Keys.Delete)
                {
                    try
                    {
                        if (gvPhieuBH.GetFocusedRowCellValue(colPhieubhctid) == null || gvPhieuBH.GetFocusedRowCellValue(colPhieubhctid).ToString() == "")
                        {
                            e.Handled = true;
                            return;
                        }
                        if (Utils.ConfirmMessage(String.Format("Bạn có chắc muốn xóa {0} không ?", gvPhieuBH.GetRowCellValue(gvPhieuBH.FocusedRowHandle, colMasp).ToString()), "Xác nhận xóa") == true)
                        {
                            gvPhieuBH.DeleteRow(gvPhieuBH.FocusedRowHandle);
                        }
                    }
                    catch (Exception ex) { ex.Data.Clear(); }
                }
            }
            catch (Exception ex) { Utils.showMessage("Phát sinh lỗi xử lý[KEYDOWN]=>" + ex.Message.ToString(), "Thông báo lỗi"); }
        }

        private void cmdAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                fdoAdd();
            }
            catch (Exception ex) { Utils.showMessage(ex.Message.ToString(), "Thông báo lỗi"); }
        }

        private void cmdDel_Click_1(object sender, EventArgs e)
        {

        }

        private void cmdDel_Click_2(object sender, EventArgs e)
        {
            
        }

        private void cmdAbort_Click_1(object sender, EventArgs e)
        {
            fdoAbort();
        }

        private void fdoStock()
        {
            if (pDenNgay == "")
            {
                Utils.showMessage("Không xác định được ngày kết tồn kho..", "Thông báo");
                return;
            }

            DataTable oTblSPC = new DataTable();
            oTblSPC.Columns.Add("Maspid", typeof(System.String));
            oTblSPC.Columns.Add("Masp", typeof(System.String));

            dlg_TonKho oTonkho = new dlg_TonKho(oTblSPC, pDenNgay);
            oTonkho.ShowDialog();
        }

        private void cmdStock_Click_1(object sender, EventArgs e)
        {
            fdoStock();
        }

        private void grdPhieuBH_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
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
                    fdoAbort();
                }
                else if (e.KeyCode == Keys.F9)
                {
                    cmdViewStock();
                }
                else if (e.KeyCode == Keys.Q && e.KeyCode == Keys.ControlKey)
                {
                    if (isEdit)
                    {
                        txtBarCode.Focus();
                        txtBarCode.SelectAll();
                    }
                }
                else if (e.KeyCode == Keys.I && e.KeyCode == Keys.ControlKey)
                {
                    if (isEdit)
                    {
                        grdPhieuBH.Focus();
                        gvPhieuBH.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                        gvPhieuBH.FocusedRowHandle = GridControl.NewItemRowHandle;
                        gvPhieuBH.FocusedColumn = colMasp;
                        gvPhieuBH.ShowEditor();
                    }
                }
            }
            catch { }
        }

        
    }
}
