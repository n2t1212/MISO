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
    public partial class DM_BangGia : Form
    {

        private MTGlobal.MT_ROLE MTROLE;
        private MTGlobal.MT_TOOL_TRIP_BUTTONACTION MTButton;

        SqlDataAdapter SQLAdaptor = null;
        DataSet DSetMain = null;
        private const string SQL_DELETE = "delete from DM_BANGGIA where Banggiaid='{0}'";

        DataTable otblSrcBangGia = null;

        public DM_BangGia()
        {
            InitializeComponent();
        }

        private void DM_BangGia_Load(object sender, EventArgs e)
        {
            setUserRight();
            setDataSourceBangGia();
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
                String mSql = String.Format("select * from DM_BANGGIA order by Banggia asc");
                otblSrcBangGia = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
                SQLAdaptor = MTSQLServer.getMTSQLServer().wAdapter(mSql, null, false);
                DSetMain = new DataSet();
                SQLAdaptor.Fill(DSetMain, "DM_BANGGIA");
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

        private void fdoAdd()
        {
            if (SysPar.SetGridReadOnly(false, gvBangGia))
            {
                gvBangGia.AddNewRow();
                gvBangGia.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gvBangGia.FocusedRowHandle = GridControl.NewItemRowHandle;
                gvBangGia.FocusedColumn = colBanggia;
                gvBangGia.Focus();
                gvBangGia.ShowEditor();
                MTGlobal.SetToolStripButtonAction(MTROLE, MTButton, "ADD");
            }

            colBanggia.OptionsColumn.AllowEdit = true;
        }

        private void fdoEdit()
        {
            if (SysPar.SetGridReadOnly(false, gvBangGia))
            {
                gvBangGia.Focus();
                gvBangGia.FocusedColumn = colBanggia;
                gvBangGia.ShowEditor();
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
                    DataTable dt = ((DataView)gvBangGia.DataSource).Table;
                    if (MTSQLServer.getMTSQLServer().doSaveTable(SQLAdaptor, dt))
                    {
                        SysPar.SetGridReadOnly(true, gvBangGia);
                        MTGlobal.SetToolStripButtonAction(MTROLE, MTButton, "SAVE");
                        setDataSourceBangGia();
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
                if (gvBangGia.GetSelectedRows() == null)
                {
                    err = Utils.SELECT_ROW_TO_DELETE;
                }
                var row = gvBangGia.GetRow(gvBangGia.GetSelectedRows()[0]);
                if (row == null)
                {
                    err = Utils.SELECT_ROW_TO_DELETE;
                }
                var id = ((System.Data.DataRowView)(row)).Row.ItemArray[0];

                String sql = String.Format(SQL_DELETE, id);
                int result = MTSQLServer.getMTSQLServer().wExec(sql, null, false);
                if (result == 1)
                {
                    setDataSourceBangGia();
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
                MTSQLServer.getMTSQLServer().Abort(SQLAdaptor, DSetMain.Tables["DM_BANGGIA"]);
                SysPar.SetGridReadOnly(true, gvBangGia);
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

        private void gvBangGia_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            try
            {
                gvBangGia.SetRowCellValue(e.RowHandle, colBanggiaid, MTGlobal.GetNewID());
                gvBangGia.SetRowCellValue(e.RowHandle, colNgaylap, DateTime.Now);
                gvBangGia.SetRowCellValue(e.RowHandle, colNguoilap, MTGlobal.MT_USER_LOGIN);
            }
            catch { }
        }
    }
}
