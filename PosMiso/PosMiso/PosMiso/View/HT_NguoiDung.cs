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
    public partial class HT_NguoiDung : Form
    {
        private string nhomQuyenID = "";
        private string maNhomQuyen = "";
        private string currentUserId = "";
        DataTable otblSrcNV = null;
        DataTable otblSrcND = null;
        DataTable otblSrcNQ = null;
        private MTGlobal.MT_ROLE MTROLE;
        private MTGlobal.MT_TOOL_TRIP_BUTTONACTION MTButton;

        SqlDataAdapter SQLAdaptor = null;
        DataSet DSetMain = null;
        private const string SQL_DELETE = "DELETE HT_NGUOIDUNG WHERE soid='{0}'";

        public HT_NguoiDung()
        {
            InitializeComponent();
        }

        private void loadNVToLookupEdit()
        {
            String mSql = String.Format("SELECT * FROM DM_NHANVIEN");
            otblSrcNV = new MTSQLServer().wRead(mSql, null, false);
            repositoryItemNV.DataSource = otblSrcNV;
            repositoryItemNV.ValueMember = "Manv";
            repositoryItemNV.DisplayMember = "Manv";
            repositoryItemNV.NullText = "";
            colmanv.ColumnEdit = repositoryItemNV;
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

        private void setDataSourceND()
        {
            try
            {
                String mSql = String.Format("select nd.* from HT_NGUOIDUNG nd LEFT JOIN HT_QUYENHAN qh ON qh.soid_nguoidung = nd.soid where qh.soid_nhomquyen = '{0}' order by nd.manv asc", nhomQuyenID);
                otblSrcND = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
                SQLAdaptor = MTSQLServer.getMTSQLServer().wAdapter(mSql, null, false);
                DSetMain = new DataSet();
                SQLAdaptor.Fill(DSetMain, "HT_NGUOIDUNG");
                if (otblSrcND == null)
                {
                    Utils.showMessage("Không thể đọc dữ liệu cần chọn...", "Thông báo");
                    return;
                }

                grdNguoiDung.DataSource = otblSrcND;
                SysPar.SetGridReadOnly(true, gvNguoiDung);
            }
            catch (Exception ex) { }
        }

        private void fdoAdd()
        {
            if (SysPar.SetGridReadOnly(false, gvNguoiDung))
            {
                gvNguoiDung.AddNewRow();
                gvNguoiDung.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gvNguoiDung.FocusedRowHandle = GridControl.NewItemRowHandle;
                gvNguoiDung.FocusedColumn = colmanv;
                gvNguoiDung.Focus();
                gvNguoiDung.ShowEditor();
                MTGlobal.SetToolStripButtonAction(MTROLE, MTButton, "ADD");
            }

            colmanv.OptionsColumn.AllowEdit = true;
        }

        private void fdoEdit()
        {
            if (SysPar.SetGridReadOnly(false, gvNguoiDung))
            {
                gvNguoiDung.Focus();
                gvNguoiDung.FocusedColumn = colmanv;
                gvNguoiDung.ShowEditor();
                MTGlobal.SetToolStripButtonAction(MTROLE, MTButton, "EDIT");
            }
        }

        private void fdoSave()
        {
            String msg = "";
            if (MTGlobal.MT_CURRENT_ACTION == "ADD" || MTGlobal.MT_CURRENT_ACTION == "EDIT")
            {
                DataTable dt = ((DataView)gvNguoiDung.DataSource).Table;
                //DataTable dtND = new modNguoiDung().dtNguoiDung();
                //foreach (DataRow sR in dt.Rows)
                //{
                //    DataRow cR = dtND.NewRow();
                //    cR["soid"] = sR["soid"];
                //    cR["manv"] = sR["manv"];
                //    cR["taikhoan"] = sR["taikhoan"];
                //    cR["matkhau"] = sR["matkhau"];
                //    cR["hoten"] = sR["hoten"];
                //    cR["nguoilap"] = sR["nguoilap"];
                //    cR["ngaylap"] = sR["ngaylap"];
                //    cR["nguoisua"] = sR["nguoisua"];
                //    cR["ngaysua"] = sR["ngaysua"];
                //    cR["ngaysync"] = sR["ngaysync"];
                //    cR["isync"] = sR["isync"];
                //    cR["kyhieu"] = sR["kyhieu"];
                //    dtND.Rows.Add(cR);
                //}
                //dtND.AcceptChanges();
                msg = new modNguoiDung().SaveNguoiDung(dt, MTGlobal.MT_USER_LOGIN, maNhomQuyen);
            }

            if (msg != "")
            {
                Utils.showMessage(msg, "Thông báo");
            }
        }

        private void fdoDel()
        {
            String err = "";
            try
            {
                if (gvNguoiDung.GetSelectedRows() == null)
                {
                    err = Utils.SELECT_ROW_TO_DELETE;
                }
                var row = gvNguoiDung.GetRow(gvNguoiDung.GetSelectedRows()[0]);
                if (row == null)
                {
                    err = Utils.SELECT_ROW_TO_DELETE;
                }
                var id = ((System.Data.DataRowView)(row)).Row.ItemArray[0];

                String sql = String.Format(SQL_DELETE, id);
                int result = MTSQLServer.getMTSQLServer().wExec(sql, null, false);
                if (result == 1)
                {
                    setDataSourceND();
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
                currentUserId = "";
                MTSQLServer.getMTSQLServer().Abort(SQLAdaptor, DSetMain.Tables["HT_NGUOIDUNG"]);
                SysPar.SetGridReadOnly(true, gvNguoiDung);
                MTGlobal.SetToolStripButtonAction(MTROLE, MTButton, "ABORT");
            }
            catch { }
        }

        private void HT_NguoiDung_Load(object sender, EventArgs e)
        {
            setUserRight();
            loadNVToLookupEdit();
            setDataSourceNhomQuyen();
        }

        private void setDataSourceNhomQuyen()
        {
            try
            {
                String mSql = String.Format("select * from HT_NHOMQUYEN order by manhom asc");
                otblSrcNQ = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);

                if (otblSrcNQ == null)
                {
                    Utils.showMessage("Không thể đọc dữ liệu cần chọn...", "Thông báo");
                    return;
                }

                grdNhomQuyen.DataSource = otblSrcNQ;
                SysPar.SetGridReadOnly(true, gvNhomQuyen);
            }
            catch (Exception ex) { }
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

        private void gvNhomQuyen_RowClick(object sender, RowClickEventArgs e)
        {
            DataRow dataRow = gvNhomQuyen.GetDataRow(e.RowHandle);

            if (dataRow != null)
            {
                nhomQuyenID = dataRow["soid"].ToString();
                maNhomQuyen = dataRow["manhom"].ToString();
                setDataSourceND();
            }
        }

        private void gvNguoiDung_KeyDown_1(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var editObj = ((DevExpress.XtraGrid.Views.Grid.GridView)(sender)).EditingValue;
                    if (gvNguoiDung.FocusedColumn.FieldName == "manv" && gvNguoiDung.FocusedColumn.Name == "colmanv")
                    {
                        if (gvNguoiDung.GetFocusedRowCellValue(colmanv) == null)// || gvPhieuBH.GetFocusedRowCellValue(colMasp).ToString() == "")
                        {
                            gvNguoiDung.FocusedColumn = colmanv;
                            return;
                        }

                        String sManv = editObj != null ? editObj.ToString() : "";
                        if (sManv == null || sManv == "")
                        {
                            gvNguoiDung.FocusedColumn = colmanv;
                            return;
                        }

                        if (sManv != "")
                        {
                            DataRow[] vRow = otblSrcNV.Select(string.Format("Manv='{0}'", sManv));
                            if (vRow.Length > 0)
                            {
                                String tennv = vRow[0]["Tennv"].ToString();
                                gvNguoiDung.SetRowCellValue(gvNguoiDung.FocusedRowHandle, colhoten, tennv);
                            }

                        }
                    }
                    else if (gvNguoiDung.FocusedColumn.FieldName == "matkhau" && gvNguoiDung.FocusedColumn.Name == "colmatkhau")
                    {
                        if (gvNguoiDung.GetFocusedRowCellValue(colmatkhau) == null)// || gvPhieuBH.GetFocusedRowCellValue(colMasp).ToString() == "")
                        {
                            gvNguoiDung.FocusedColumn = colmatkhau;
                            return;
                        }

                        String pwd = editObj != null ? editObj.ToString() : "";
                        if (pwd == null || pwd == "")
                        {
                            gvNguoiDung.FocusedColumn = colmatkhau;
                            return;
                        }

                        string md5Pwd = MTGlobal.HashMD5(pwd);
                        gvNguoiDung.SetRowCellValue(gvNguoiDung.FocusedRowHandle, colmatkhau, md5Pwd);
                    }
                }
            }
            catch (Exception ex) { Utils.showMessage("Phát sinh lỗi xử lý[KEYDOWN]=>" + ex.Message.ToString(), "Thông báo lỗi"); }
        }

        private void gvNguoiDung_InitNewRow_1(object sender, InitNewRowEventArgs e)
        {
            try
            {
                currentUserId = MTGlobal.GetNewID();
                gvNguoiDung.SetRowCellValue(e.RowHandle, colsoid, currentUserId);
            }
            catch { }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdEdit_Click_1(object sender, EventArgs e)
        {
            fdoEdit();
        }

        private void cmdAdd_Click_1(object sender, EventArgs e)
        {
            fdoAdd();
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

        private void grdNguoiDung_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
