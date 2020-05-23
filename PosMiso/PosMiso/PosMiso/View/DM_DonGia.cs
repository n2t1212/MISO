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
    public partial class DM_DonGia : Form
    {
        private MTGlobal.MT_ROLE MTROLE;
        private MTGlobal.MT_TOOL_TRIP_BUTTONACTION MTButton;

        DataTable otblSrcBangGia = null;
        DataTable otblSrcBangGiaCT = null;
        SqlDataAdapter SQLAdaptor = null;
        DataSet DSetMain = null;
        private DataTable otblSP = null;

        private const String DEL_SQL = "delete from DM_BANGGIA_CHITIET where Masp='{0}'" +
            " and Masp not in (select Masp from BH_PHIEUBHCT)" +
            " and Masp not in (select Masp from NX_PHIEUNXCT)" +
            " and Masp not in (select Masp from NX_CHANHXECT)";

        String bangGiaID = "";
        public DM_DonGia()
        {
            InitializeComponent();
        }

        private void DM_DonGia_Load(object sender, EventArgs e)
        {
            setUserRight();
            loadProductToLookupEdit();
            setDataSourceBangGia();
            setDataSourceBangGiaCT(bangGiaID);
        }

        private void loadProductToLookupEdit()
        {
            String mSql = "SELECT Maspid,Manhomspid,Masp,Tensp,Dvt,Quycach,Quydoikgl,Quydoithung,Nhacungcap,Maqrcode,Mabarcode FROM DM_SANPHAM with(nolock) order by Masp asc";
            otblSP = new MTSQLServer().wRead(mSql, null, false);
            repositoryItem.DataSource = otblSP;
            repositoryItem.ValueMember = "Masp";
            repositoryItem.DisplayMember = "Masp";
            repositoryItem.NullText = "";
            colMasp.ColumnEdit = repositoryItem;
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

        private void setDataSourceBangGia()
        {
            try
            {
                String mSql = String.Format("select Banggiaid,Banggia,Tungay,Denngay,Ngayapdung,Apdung from DM_BANGGIA order by Banggiaid asc");
                otblSrcBangGia = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
               
                if (otblSrcBangGia == null)
                {
                    Utils.showMessage("Không thể đọc dữ liệu cần chọn...", "Thông báo");
                    return;
                }

                grdBangGia.DataSource = otblSrcBangGia;
                SysPar.SetGridReadOnly(true, gvBangGia);
            }
            catch (Exception ex) { }

        }

        private void setDataSourceBangGiaCT(String _bangGiaID)
        {
            try
            {
                String mSql = String.Format("select Banggiactid,Banggiaid,Maspid,Mavung,Masp,Tensp,Giagoc,Giasi,Giale,Ghichu from DM_BANGGIA_CHITIET order by Masp asc");

                if (_bangGiaID != null && _bangGiaID.Length > 0)
                {
                    mSql = String.Format("select Banggiactid,Banggiaid,Maspid,Mavung,Masp,Tensp,Giagoc,Giasi,Giale,Ghichu from DM_BANGGIA_CHITIET where Banggiaid='{0}' order by Masp asc", _bangGiaID);
                }

                otblSrcBangGiaCT = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
                SQLAdaptor = MTSQLServer.getMTSQLServer().wAdapter(mSql, null, false);
                DSetMain = new DataSet();
                SQLAdaptor.Fill(DSetMain, "DM_BANGGIA_CHITIET");
                if (otblSrcBangGiaCT == null)
                {
                    Utils.showMessage("Không thể đọc dữ liệu cần chọn...", "Thông báo");
                    return;
                }

                grdBangGiaCT.DataSource = otblSrcBangGiaCT;
                SysPar.SetGridReadOnly(true, gvBangGiaCT);
            }
            catch (Exception ex) { }

        }

        private void gvBangGia_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dataRow = gvBangGia.GetDataRow(e.RowHandle);

            if (dataRow != null)
            {
                bangGiaID = dataRow["Banggiaid"].ToString();
                setDataSourceBangGiaCT(bangGiaID);
            }
        }

        private void fdoAdd()
        {
            //if (bangGiaID == "")
            //{
            //    MessageBox.Show("Bạn chưa chọn bảng giá..", "Thông báo", MessageBoxButtons.OK);
            //    return;
            //}

            if (SysPar.SetGridReadOnly(false, gvBangGiaCT))
            {
                gvBangGiaCT.AddNewRow();
                gvBangGiaCT.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gvBangGiaCT.FocusedRowHandle = GridControl.NewItemRowHandle;
                gvBangGiaCT.FocusedColumn = colMasp;
                gvBangGiaCT.Focus();
                gvBangGiaCT.ShowEditor();
                MTGlobal.SetToolStripButtonAction(MTROLE, MTButton, "ADD");
            }

            colMasp.OptionsColumn.AllowEdit = true;
        }

        private void fdoEdit()
        {
            if (SysPar.SetGridReadOnly(false, gvBangGiaCT))
            {
                gvBangGiaCT.Focus();
                gvBangGiaCT.FocusedColumn = colMasp;
                gvBangGiaCT.ShowEditor();
                MTGlobal.SetToolStripButtonAction(MTROLE, MTButton, "EDIT");
            }
        }

        private void fdoSave()
        {
            String msg = "";
            try
            {
                if (MTGlobal.MT_CURRENT_ACTION == "ADD" || MTGlobal.MT_CURRENT_ACTION == "EDIT")
                {
                    DataTable dt = ((DataView)gvBangGiaCT.DataSource).Table;
                    if (MTSQLServer.getMTSQLServer().doSaveTable(SQLAdaptor, dt))
                    {
                        SysPar.SetGridReadOnly(true, gvBangGiaCT);
                        MTGlobal.SetToolStripButtonAction(MTROLE, MTButton, "SAVE");
                        setDataSourceBangGiaCT(bangGiaID);
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
                if (gvBangGiaCT.GetSelectedRows() == null)
                {
                    err = Utils.SELECT_ROW_TO_DELETE;
                }
                var row = gvBangGiaCT.GetRow(gvBangGiaCT.GetSelectedRows()[0]);
                if (row == null)
                {
                    err = Utils.SELECT_ROW_TO_DELETE;
                }
                var id = ((System.Data.DataRowView)(row)).Row.ItemArray[4];

                String sql = String.Format(DEL_SQL, id);
                int result = MTSQLServer.getMTSQLServer().wExec(sql, null, false);
                if (result == 1)
                {
                    setDataSourceBangGiaCT(bangGiaID);
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
            try
            {
                MTSQLServer.getMTSQLServer().Abort(SQLAdaptor, DSetMain.Tables["DM_BANGGIA_CHITIET"]);
                SysPar.SetGridReadOnly(true, gvBangGiaCT);
                MTGlobal.SetToolStripButtonAction(MTROLE, MTButton, "ABORT");
            }
            catch { }
        }

        private void gvBangGiaCT_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            try
            {
                gvBangGiaCT.SetRowCellValue(e.RowHandle, colBanggiactid, MTGlobal.GetNewID());
                gvBangGiaCT.SetRowCellValue(e.RowHandle, colBanggiaid, bangGiaID);
            }
            catch { }
        }

        private void gvBangGiaCT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (gvBangGiaCT.FocusedColumn.FieldName == "Masp" && gvBangGiaCT.FocusedColumn.Name == "colMasp")
                {
                    if (gvBangGiaCT.GetFocusedRowCellValue(colMasp) == null)// || gvSanPham.GetFocusedRowCellValue(colMasp).ToString() == "")
                    {
                        gvBangGiaCT.FocusedColumn = colMasp;
                        return;
                    }

                    var editObj = ((DevExpress.XtraGrid.Views.Grid.GridView)(sender)).EditingValue;
                    String sMasp = editObj != null ? editObj.ToString() : "";
                    if (sMasp == null || sMasp == "")
                    {
                        gvBangGiaCT.FocusedColumn = colMasp;
                        return;
                    }

                    string errDuplicateSP = ValidateHelper.checkCodeValueNotDuplicate("DM_BANGGIA_CHITIET", "Masp", sMasp, "Mã SP");

                    if (errDuplicateSP.Length > 0)
                    {
                        gvBangGiaCT.FocusedColumn = colMasp;
                        Utils.showMessage(errDuplicateSP, "Thông báo");
                        return;
                    }

                    if (otblSP != null && otblSP.Rows.Count > 0)
                    {
                        DataRow[] vRow = otblSP.Select(string.Format("Masp='{0}'", sMasp));
                        if (vRow.Length > 0)
                        {
                            String tensp = vRow[0]["Tensp"].ToString();
                            gvBangGiaCT.SetRowCellValue(gvBangGiaCT.FocusedRowHandle, colMasp, sMasp);
                            gvBangGiaCT.SetRowCellValue(gvBangGiaCT.FocusedRowHandle, colTensp, tensp);
                        }
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fdl = new FolderBrowserDialog();
                if (fdl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (System.IO.File.Exists(fdl.SelectedPath + @"\Bieu_mau_gia_san_pham.xlsx"))
                    {
                        Utils.showMessage("File mẫu đang tồn tại trong thư mục. Vui lòng kiểm tra lại..", "Thông báo");
                    }
                    else
                    {
                        System.IO.File.Copy(@"Bieu_mau_gia_san_pham.xlsx", fdl.SelectedPath + @"\Bieu_mau_gia_san_pham.xlsx");
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

        private void btnImport_Click_1(object sender, EventArgs e)
        {
            if (bangGiaID.Length == 0)
            {
                Utils.showMessage("Vui lòng chọn bảng giá cần nhập", "Thông báo");
                return;
            }

            dlg_ImportGiaSanPham giaImport = new dlg_ImportGiaSanPham(bangGiaID);
            giaImport.ShowDialog();
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdBangGia_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
            else if (e.KeyCode == Keys.F8)
            {
                this.Close();
            }
        }
    }
}
