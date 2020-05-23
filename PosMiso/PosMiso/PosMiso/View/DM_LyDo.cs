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
    public partial class DM_LyDo : Form
    {
        DataTable otblSrcLyDo = null;
        DataTable otblTK = null;

        private MTGlobal.MT_ROLE MTROLE;
        private MTGlobal.MT_TOOL_TRIP_BUTTONACTION MTButton;

        SqlDataAdapter SQLAdaptor = null;
        DataSet DSetMain = null;
        private const string SQL_DELETE = "DELETE DM_LYDO WHERE Mald='{0}'";

        public DM_LyDo()
        {
            InitializeComponent();
        }

        private void DM_LyDo_Load(object sender, EventArgs e)
        {
            setUserRight();
            loadTaiKhoanToLookupEdit();
            setDataSourceLyDo();
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

        private void loadTaiKhoanToLookupEdit()
        {
            String mSql = String.Format("select * from DM_TAIKHOAN order by Matk asc");
            otblTK = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);

            repositoryItemTKNo.DataSource = otblTK;
            repositoryItemTKNo.ValueMember = "Matk";
            repositoryItemTKNo.DisplayMember = "Matk";
            repositoryItemTKNo.NullText = "";
            colTKNo.ColumnEdit = repositoryItemTKNo;
            colTKCo.ColumnEdit = repositoryItemTKNo;
        }
        private void setDataSourceLyDo()
        {
            try
            {
                String mSql = String.Format("select Mald,Lydo,Loai,TKNo,TKCo,Ghichu from DM_LYDO order by Mald asc");
                otblSrcLyDo = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
                SQLAdaptor = MTSQLServer.getMTSQLServer().wAdapter(mSql, null, false);
                DSetMain = new DataSet();
                SQLAdaptor.Fill(DSetMain, "DM_LYDO");
                if (otblSrcLyDo == null)
                {
                    Utils.showMessage("Không thể đọc dữ liệu cần chọn...", "Thông báo");
                    return;
                }

                grdLyDo.DataSource = otblSrcLyDo;
                SysPar.SetGridReadOnly(true, gvLyDo);
            }
            catch (Exception ex) { }

        }

        private void fdoAdd()
        {
            if (SysPar.SetGridReadOnly(false, gvLyDo))
            {
                gvLyDo.AddNewRow();
                gvLyDo.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gvLyDo.FocusedRowHandle = GridControl.NewItemRowHandle;
                gvLyDo.FocusedColumn = colMald;
                gvLyDo.Focus();
                gvLyDo.ShowEditor();
                MTGlobal.SetToolStripButtonAction(MTROLE, MTButton, "ADD");
            }

            colMald.OptionsColumn.AllowEdit = true;
        }

        private void fdoEdit()
        {
            if (SysPar.SetGridReadOnly(false, gvLyDo))
            {
                gvLyDo.Focus();
                gvLyDo.FocusedColumn = colMald;
                gvLyDo.ShowEditor();
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
                    DataTable dt = ((DataView)gvLyDo.DataSource).Table;
                    if (MTSQLServer.getMTSQLServer().doSaveTable(SQLAdaptor, dt))
                    {
                        SysPar.SetGridReadOnly(true, gvLyDo);
                        MTGlobal.SetToolStripButtonAction(MTROLE, MTButton, "SAVE");
                        setDataSourceLyDo();
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
                Utils.showMessage(msg, "Thông báo");
            }
        }

        private void fdoDel()
        {
            String err = "";
            try
            {
                if (gvLyDo.GetSelectedRows() == null)
                {
                    err = Utils.SELECT_ROW_TO_DELETE;
                }
                var row = gvLyDo.GetRow(gvLyDo.GetSelectedRows()[0]);
                if (row == null)
                {
                    err = Utils.SELECT_ROW_TO_DELETE;
                }
                var id = ((System.Data.DataRowView)(row)).Row.ItemArray[0];

                String sql = String.Format(SQL_DELETE, id);
                int result = MTSQLServer.getMTSQLServer().wExec(sql, null, false);
                if (result == 1)
                {
                    setDataSourceLyDo();
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
                MTSQLServer.getMTSQLServer().Abort(SQLAdaptor, DSetMain.Tables["DM_LYDO"]);
                SysPar.SetGridReadOnly(true, gvLyDo);
                MTGlobal.SetToolStripButtonAction(MTROLE, MTButton, "ABORT");
            }
            catch { }
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

        private void grdLyDo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
