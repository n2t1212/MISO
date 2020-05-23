using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class DM_SanPham : Form
    {
        private MTGlobal.MT_ROLE MTROLE;
        private MTGlobal.MT_TOOL_TRIP_BUTTONACTION MTButton;

        DataTable otblSrcSanPham = null;
        DataTable otblSrcNhomSanPham = null;
        SqlDataAdapter SQLAdaptor = null;
        DataSet DSetMain = null;

        private const String SQL_DELETE_SP = "delete from DM_SANPHAM where Maspid='{0}'" +
            " and Masp not in (select Masp from BH_PHIEUBHCT)" +
            " and Masp not in (select Masp from NX_PHIEUNXCT)" +
            " and Masp not in (select Masp from NX_CHANHXECT)";

        String maNhomSPId = "";

        public DM_SanPham()
        {
            InitializeComponent();
        }

        private void DM_SanPham_Load(object sender, EventArgs e)
        {
            setUserRight();
            setDataSourceNhomSanPham();
            setDataSourceSanPham("");
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

                MTButton.cmdAdd = this.cmdAdd;
                MTButton.cmdEdit = this.cmdEdit;
                MTButton.cmdSave = this.cmdSave;
                MTButton.cmdDel = this.cmdDel;

                MTGlobal.SetPermitToolStrip(MTROLE, MTButton);
            }
        }

        private void setDataSourceNhomSanPham()
        {
            try
            {
                String mSql = String.Format("select Manhomspid,Manhom,Tennhom from DM_NHOMSP order by Manhom asc");
                otblSrcNhomSanPham = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
                if (otblSrcNhomSanPham == null)
                {
                    Utils.showMessage("Không thể đọc dữ liệu cần chọn...", "Thông báo");
                    return;
                }

                grdNhomSanPham.DataSource = otblSrcNhomSanPham;
                SysPar.SetGridReadOnly(true, gvNhomSanPham);
            }
            catch (Exception ex) { }

        }

        private void setDataSourceSanPham(String Manhomspid)
        {
            try
            {
                String mSql = String.Format("select Maspid,Masp,Tensp,Dvt,Quycach,Quydoikgl,Quydoithung,Maqrcode,Mabarcode from DM_SANPHAM order by Masp asc");

                if (Manhomspid != null && Manhomspid.Length > 0)
                {
                    mSql = String.Format("select Maspid,Manhomspid,Masp,Tensp,Dvt,Quycach,Quydoikgl,Quydoithung,Maqrcode,Mabarcode from DM_SANPHAM where Manhomspid ='{0}' order by Masp asc", Manhomspid);
                }
                otblSrcSanPham = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
                SQLAdaptor = MTSQLServer.getMTSQLServer().wAdapter(mSql, null, false);
                DSetMain = new DataSet();
                SQLAdaptor.Fill(DSetMain, "DM_SANPHAM");
                DataTable dt = DSetMain.Tables["DM_SANPHAM"];
                if (otblSrcSanPham == null)
                {
                    Utils.showMessage("Không thể đọc dữ liệu cần chọn...", "Thông báo");
                    return;
                }

                grdSanPham.DataSource = otblSrcSanPham;
                SysPar.SetGridReadOnly(true, gvSanPham);
            }
            catch (Exception ex) { }

        }

        private void gvNhomSanPham_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void btnInMa_Click(object sender, EventArgs e)
        {
            frmInMa inMa = new frmInMa();
            inMa.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (maNhomSPId.Length == 0)
            {
                Utils.showMessage("Vui lòng chọn nhóm sản phẩm cần nhập", "Thông báo");
                return;
            }

            dlg_ImportSanPham importSP = new dlg_ImportSanPham(maNhomSPId);
            importSP.ShowDialog();
        }

        private void fdoImport()
        {
            if (maNhomSPId.Length == 0)
            {
                Utils.showMessage("Vui lòng chọn nhóm sản phẩm cần nhập", "Thông báo");
                return;
            }

            dlg_ImportSanPham importSP = new dlg_ImportSanPham(maNhomSPId);
            importSP.ShowDialog();
        }

        private void fdoDownload()
        {
            try
            {
                FolderBrowserDialog fdl = new FolderBrowserDialog();
                if (fdl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (System.IO.File.Exists(fdl.SelectedPath + @"\Bieu_mau_san_pham.xlsx"))
                    {
                        Utils.showMessage("File mẫu đang tồn tại trong thư mục. Vui lòng kiểm tra lại..", "Thông báo");
                    }
                    else
                    {
                        System.IO.File.Copy(@"Bieu_mau_san_pham.xlsx", fdl.SelectedPath + @"\Bieu_mau_san_pham.xlsx");
                        Utils.showMessage("Đã tải file mẫu thành công.", "Thông báo");
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                Utils.showMessage("Lỗi tải file. Vui lòng kiểm tra đường dẫn", "Thông báo");
                return;
            }
        }

        private void fdoPrintCode()
        {
            frmInMa inMa = new frmInMa();
            inMa.ShowDialog();
        }

        private void btnDownTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fdl = new FolderBrowserDialog();
                if (fdl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (System.IO.File.Exists(fdl.SelectedPath + @"\Bieu_mau_san_pham.xlsx"))
                    {
                        Utils.showMessage("File mẫu đang tồn tại trong thư mục. Vui lòng kiểm tra lại..", "Thông báo");
                    }
                    else
                    {
                        System.IO.File.Copy(@"Bieu_mau_san_pham.xlsx", fdl.SelectedPath + @"\Bieu_mau_san_pham.xlsx");
                        Utils.showMessage("Đã tải file mẫu thành công.", "Thông báo");
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                Utils.showMessage("Lỗi tải file. Vui lòng kiểm tra đường dẫn", "Thông báo");
                return;
            }
        }

        private void gvNhomSanPham_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dataRow = gvNhomSanPham.GetDataRow(e.RowHandle);

            if (dataRow != null)
            {
                maNhomSPId = dataRow["Manhomspid"].ToString();
                setDataSourceSanPham(maNhomSPId);
            }
        }

        private void DisableEditCode()
        {
            colMasp.OptionsColumn.AllowEdit = false;
            colMabarcode.OptionsColumn.AllowEdit = false;
            colMaqrcode.OptionsColumn.AllowEdit = false;
        }

        private void EnableEditCode()
        {
            colMasp.OptionsColumn.AllowEdit = true;
            colMasp.OptionsColumn.AllowFocus = true;
            colMasp.OptionsColumn.ReadOnly = false;

            colMabarcode.OptionsColumn.AllowEdit = true;
            colMabarcode.OptionsColumn.AllowFocus = true;
            colMabarcode.OptionsColumn.ReadOnly = false;

            colMaqrcode.OptionsColumn.AllowEdit = true;
            colMaqrcode.OptionsColumn.AllowFocus = true;
            colMaqrcode.OptionsColumn.ReadOnly = false;
        }

        private void fdoAdd()
        {
            if (maNhomSPId == "")
            {
                MessageBox.Show("Bạn chưa chọn nhóm sản phẩm..", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (SysPar.SetGridReadOnly(false, gvSanPham))
            {
                gvSanPham.AddNewRow();
                gvSanPham.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gvSanPham.FocusedRowHandle = GridControl.NewItemRowHandle;
                gvSanPham.FocusedColumn = colMasp;
                gvSanPham.Focus();
                gvSanPham.ShowEditor();
                MTGlobal.SetToolStripButtonAction(MTROLE, MTButton, "ADD");
            }

            DisableEditCode();

            colMasp.OptionsColumn.AllowEdit = true;
        }

        private void fdoEdit()
        {
            if (SysPar.SetGridReadOnly(false, gvSanPham))
            {
                gvSanPham.Focus();
                gvSanPham.FocusedColumn = colMasp;
                gvSanPham.ShowEditor();
                MTGlobal.SetToolStripButtonAction(MTROLE, MTButton, "EDIT");
                DisableEditCode();
            }
        }

        private void fdoSave()
        {
            DisableEditCode();
            String msg = "";
            try
            {
                if (MTGlobal.MT_CURRENT_ACTION == "ADD" || MTGlobal.MT_CURRENT_ACTION == "EDIT")
                {
                    DataTable dt = ((DataView)gvSanPham.DataSource).Table;
                    if (MTSQLServer.getMTSQLServer().doSaveTable(SQLAdaptor, dt))
                    {
                        SysPar.SetGridReadOnly(true, gvSanPham);
                        MTGlobal.SetToolStripButtonAction(MTROLE, MTButton, "SAVE");
                        setDataSourceSanPham(maNhomSPId);
                        msg = Utils.SAVE_DB_OK;
                    }
                    else
                    {
                        msg = Utils.ERR_UPDATE_DB;
                    }
                }

            }
            catch (Exception ex)
            {
                msg = ex.Message.ToString();
            } 
            if (msg != "")
            {
                //System.Windows.MessageBox.Show(msg);
                Utils.showMessage(msg, "Thông báo");
            }
        }

        private void fdoDel()
        {
            String err = "";
            try
            {
                if (gvSanPham.GetSelectedRows() == null)
                {
                    err = Utils.SELECT_ROW_TO_DELETE;
                }
                var row = gvSanPham.GetRow(gvSanPham.GetSelectedRows()[0]);
                if (row == null)
                {
                    err = Utils.SELECT_ROW_TO_DELETE;
                }
                var id = ((System.Data.DataRowView)(row)).Row.ItemArray[0];

                String sql = String.Format(SQL_DELETE_SP, id);
                int result = MTSQLServer.getMTSQLServer().wExec(sql, null, false);
                if (result == 1)
                {
                    setDataSourceSanPham(maNhomSPId);
                    err = Utils.SAVE_DB_OK;
                }
                else
                {
                    err = Utils.ERR_UPDATE_DB;
                }
            }
            catch (Exception ex) { err = ex.Message.ToString(); }

            if (err != "")
            {
                //System.Windows.MessageBox.Show(msg);
                Utils.showMessage(err, "Thông báo");
            }
        }

        private void fdoAbort()
        {
            DisableEditCode();
            try
            {
                MTSQLServer.getMTSQLServer().Abort(SQLAdaptor, DSetMain.Tables["DM_SANPHAM"]);
                SysPar.SetGridReadOnly(true, gvSanPham);
                MTGlobal.SetToolStripButtonAction(MTROLE, MTButton, "ABORT");
            }
            catch { }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            fdoAdd();
        }

        private void gvSanPham_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            try
            {
                gvSanPham.SetRowCellValue(e.RowHandle, colMaspid, MTGlobal.GetNewID());
                gvSanPham.SetRowCellValue(e.RowHandle, colManhomspid, maNhomSPId);
            }
            catch { }
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

        private void gvSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            // Press CTRL + E to edit masp, barcode and QR code
            if (e.KeyCode == Keys.E && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                EnableEditCode();
            }

            // Press CTRL + U to disable edit masp, barcode and QR code
            if (e.KeyCode == Keys.U && e.KeyCode == Keys.ControlKey)
            {
                DisableEditCode();
            }

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (gvSanPham.FocusedColumn.FieldName == "Masp" && gvSanPham.FocusedColumn.Name == "colMasp")
                {
                    if (gvSanPham.GetFocusedRowCellValue(colMasp) == null)// || gvSanPham.GetFocusedRowCellValue(colMasp).ToString() == "")
                    {
                        gvSanPham.FocusedColumn = colMasp;
                        return;
                    }

                    var editObj = ((DevExpress.XtraGrid.Views.Grid.GridView)(sender)).EditingValue;
                    String sMasp = editObj != null ? editObj.ToString() : "";
                    if (sMasp == null || sMasp == "")
                    {
                        gvSanPham.FocusedColumn = colMasp;
                        return;
                    }

                    string errDuplicateSP = ValidateHelper.checkCodeValueNotDuplicate("DM_SANPHAM", "Masp", sMasp, "Mã SP");

                    if (errDuplicateSP.Length > 0)
                    {
                        gvSanPham.FocusedColumn = colMasp;
                        Utils.showMessage(errDuplicateSP, "Thông báo");
                        return;
                    }

                    gvSanPham.SetRowCellValue(gvSanPham.FocusedRowHandle, colMabarcode, sMasp);
                    gvSanPham.SetRowCellValue(gvSanPham.FocusedRowHandle, colMaqrcode, sMasp);
                }
            }
        }

        private void cmdDownload_Click(object sender, EventArgs e)
        {
            fdoDownload();
        }

        private void btnImport_Click_1(object sender, EventArgs e)
        {
            fdoImport();
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
            fdoDel();
        }

        private void cmdSave_Click_1(object sender, EventArgs e)
        {
            fdoSave();
        }

        private void cmdAbort_Click_1(object sender, EventArgs e)
        {
            fdoAbort();
        }

        private void cmdPrintCode_Click(object sender, EventArgs e)
        {
            fdoPrintCode();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdSanPham_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
            else if (e.KeyCode == Keys.Escape)
            {
                fdoAbort();
            }
            else if (e.KeyCode == Keys.F7)
            {
                fdoPrintCode();
            }
            else if (e.KeyCode == Keys.F8)
            {
                this.Close();
            }
        }
    }
}
