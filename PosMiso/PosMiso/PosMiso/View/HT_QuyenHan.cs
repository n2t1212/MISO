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
    public partial class HT_QuyenHan : Form
    {
        private MTGlobal.MT_ROLE MTROLE;
        private MTGlobal.MT_TOOL_TRIP_BUTTONACTION MTButton;

        DataTable otblSrcNhomQuyen = null;
        DataTable otblSrcQuyenHan = null;
        SqlDataAdapter SQLAdaptor = null;
        DataSet DSetMain = null;

        String nhomQuyenID = "";
        private const String SQL_DEL = "DELETE HT_NHOMQUYEN_CHUCNANG WHERE soid = '{0}'";
        private const String SQL_DEL_ROOT = "DELETE HT_NHOMQUYEN_CHUCNANG WHERE macn = (SELECT macnroot FROM DM_CHUCNANG WHERE macn='{0}')";

        public HT_QuyenHan()
        {
            InitializeComponent();
        }

        private void HT_QuyenHan_Load(object sender, EventArgs e)
        {
            setUserRight();
            setDataSourceNhomQuyen();
            setDataSourceQuyenHan("");
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

        private void setDataSourceNhomQuyen()
        {
            try
            {
                String mSql = String.Format("select * from HT_NHOMQUYEN order by manhom");
                otblSrcNhomQuyen = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
                if (otblSrcNhomQuyen == null)
                {
                    Utils.showMessage("Không thể đọc dữ liệu cần chọn...", "Thông báo");
                    return;
                }

                grdNhomQuyen.DataSource = otblSrcNhomQuyen;
                SysPar.SetGridReadOnly(true, gvNhomQuyen);
            }
            catch (Exception ex) { }

        }

        private void setDataSourceQuyenHan(String nhomQuyenID)
        {
            try
            {
                String mSql = String.Format("select nqcn.soid as soid, nqcn.macn as macn, cn.chucnang as chucnang, " + 
                                                 "nqcn.them as them, nqcn.xoa as xoa, nqcn.sua as sua, nqcn.duyet as duyet, nqcn.[in] as [in]" +
                                                  " from HT_NHOMQUYEN_CHUCNANG nqcn left join DM_CHUCNANG cn on cn.macn = nqcn.macn" +
                                                  " order by manhom asc");

                if (nhomQuyenID != null && nhomQuyenID.Length > 0)
                {
                    mSql = String.Format("select nqcn.soid as soid, nqcn.macn as macn, cn.chucnang as chucnang, " +
                                                 "nqcn.them as them, nqcn.xoa as xoa, nqcn.sua as sua, nqcn.duyet as duyet, nqcn.[in] as [in]" +
                                                  " from HT_NHOMQUYEN_CHUCNANG nqcn left join DM_CHUCNANG cn on cn.macn = nqcn.macn" +
                                                  " where nqcn.manhom='{0}' order by manhom asc", nhomQuyenID);    
                }
                otblSrcQuyenHan = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
                SQLAdaptor = MTSQLServer.getMTSQLServer().wAdapter(mSql, null, false);
                DSetMain = new DataSet();
                SQLAdaptor.Fill(DSetMain, "HT_NHOMQUYEN_CHUCNANG");
                if (otblSrcQuyenHan == null)
                {
                    Utils.showMessage("Không thể đọc dữ liệu cần chọn...", "Thông báo");
                    return;
                }

                grdQuyenHan.DataSource = otblSrcQuyenHan;
                SysPar.SetGridReadOnly(true, gvQuyenHan);
            }
            catch (Exception ex) { }

        }

        private void gvNhomQuyen_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dataRow = gvNhomQuyen.GetDataRow(e.RowHandle);

            if (dataRow != null)
            {
                nhomQuyenID = dataRow["soid"].ToString();
                setDataSourceQuyenHan(nhomQuyenID);
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            dlg_AddQuyenHan addQH = new dlg_AddQuyenHan(nhomQuyenID);
            addQH.ShowDialog();
        }

        private void fdoAdd()
        {
            dlg_AddQuyenHan addQH = new dlg_AddQuyenHan(nhomQuyenID);
            addQH.ShowDialog();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            fdoEdit();
        }


        private void fdoEdit()
        {
            if (SysPar.SetGridReadOnly(false, gvQuyenHan))
            {
                gvQuyenHan.Focus();
                gvQuyenHan.FocusedColumn = colthem;
                gvQuyenHan.ShowEditor();
                MTGlobal.SetToolStripButtonAction(MTROLE, MTButton, "EDIT");
            }
        }

        private DataTable initDataTable()
        {
            DataTable tblNQCN = new DataTable();
            tblNQCN.Columns.Add("soid", typeof(string));
            tblNQCN.Columns.Add("manhom", typeof(string));
            tblNQCN.Columns.Add("macn", typeof(string));
            tblNQCN.Columns.Add("them", typeof(int));
            tblNQCN.Columns.Add("sua", typeof(int));
            tblNQCN.Columns.Add("xoa", typeof(int));
            tblNQCN.Columns.Add("duyet", typeof(int));
            tblNQCN.Columns.Add("in", typeof(int));
            tblNQCN.Columns.Add("nguoilap", typeof(string));
            tblNQCN.Columns.Add("ngaylap", typeof(DateTime));
            tblNQCN.Columns.Add("nguoisua", typeof(string));
            tblNQCN.Columns.Add("ngaysua", typeof(DateTime));
            return tblNQCN;
        }

        private DataTable convertTableSelectedToTableNQCN(DataTable dt)
        {
            DataTable tblNQCN = initDataTable();
            int loop = 0;
            foreach (DataRow rw in dt.Rows)
            {
                DataRow row = tblNQCN.NewRow();
                row["soid"] = rw["soid"];
                row["manhom"] = nhomQuyenID;
                row["macn"] = rw["macn"];
                row["them"] = rw["them"];
                row["sua"] = rw["sua"];
                row["xoa"] = rw["xoa"];
                row["duyet"] = rw["duyet"];
                row["in"] = rw["in"];
                row["nguoilap"] = MTGlobal.MT_USER_LOGIN;
                row["ngaylap"] = DateTime.Now;

                tblNQCN.Rows.Add(row);
                loop++;
            }
            return tblNQCN;
        }

        private void fdoSave()
        {
            String msg = "";
            try
            {
                if (MTGlobal.MT_CURRENT_ACTION == "ADD" || MTGlobal.MT_CURRENT_ACTION == "EDIT")
                {
                    DataTable dt = ((DataView)gvQuyenHan.DataSource).Table;
                    DataTable tblNQCN = convertTableSelectedToTableNQCN(dt);
                    try
                    {
                        SqlParameter[] arrPara = new SqlParameter[3];
                        arrPara[0] = new SqlParameter("@nhomQuyenChucNangTbl", SqlDbType.Structured);
                        arrPara[0].Value = tblNQCN;
                        arrPara[1] = new SqlParameter("@nguoidung", SqlDbType.NVarChar, 50);
                        arrPara[1].Value = MTGlobal.MT_USER_LOGIN;
                        arrPara[2] = new SqlParameter("@ketqua", SqlDbType.NVarChar, 255);
                        arrPara[2].Direction = ParameterDirection.Output;

                        int iRs = MTSQLServer.getMTSQLServer().wExec("spHT_AddNhomQuyenChucNang", arrPara);

                        if (iRs == -1)
                        {
                            Utils.showMessage("Dữ liệu không thể cập nhật. Vui lòng kiểm tra lại.", "Thông báo");
                            //return;
                        }
                        else
                        {
                            Utils.showMessage("Dữ liệu cập nhật thành công.", "Thông báo");
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        Utils.showMessage("Lỗi kết nối cơ sở dữ liệu", "Thông báo");
                        return;
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
                if (gvQuyenHan.GetSelectedRows() == null)
                {
                    err = Utils.SELECT_ROW_TO_DELETE;
                }
                var row = gvQuyenHan.GetRow(gvQuyenHan.GetSelectedRows()[0]);
                if (row == null)
                {
                    err = Utils.SELECT_ROW_TO_DELETE;
                }
                var id = ((System.Data.DataRowView)(row)).Row.ItemArray[0];
                var macn = ((System.Data.DataRowView)(row)).Row.ItemArray[1];

                String sql1 = String.Format(SQL_DEL, id);
                int result1 = MTSQLServer.getMTSQLServer().wExec(sql1, null, false);
                String sql2 = String.Format(SQL_DEL_ROOT, macn);
                int result2 = MTSQLServer.getMTSQLServer().wExec(sql2, null, false);
                if (result1 == 1 && result2 == 1)
                {
                    setDataSourceQuyenHan(nhomQuyenID);
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
                MTSQLServer.getMTSQLServer().Abort(SQLAdaptor, DSetMain.Tables["HT_NHOMQUYEN_CHUCNANG"]);
                SysPar.SetGridReadOnly(true, gvQuyenHan);
                MTGlobal.SetToolStripButtonAction(MTROLE, MTButton, "ABORT");
            }
            catch { }
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

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void grdQuyenHan_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
            else if (e.KeyCode == Keys.F8)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                fdoAbort();
            }
        }
    }
}
