using PosMiso.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosMiso.View
{
    public partial class dlg_ImportGiaSanPham : Form
    {
        private const string PROVIDER = "Provider=Microsoft.ACE.OLEDB.12.0;";
        private const string EXTENDED_PROPERTIES = "Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1;';";
        private const string MOI = "MOI";

        private DataTable bangGiaCT;
        private DataTable excelContent;

        public string bangGiaid = "";
        private string fileName = "";
        private string loai = "";

        public dlg_ImportGiaSanPham()
        {
            InitializeComponent();
        }

        public dlg_ImportGiaSanPham(String _bangGiaid)
        {
            InitializeComponent();
            this.bangGiaid = _bangGiaid;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = openFileDlg.FileName;
            }
            txtFile.Text = fileName;

            if (Utils.validateFileType(fileName, Utils.EXCEL_TYPE))
            {
                btnImport.Enabled = true;
                excelContent = ReadDataFromExcelFile();
                viewBangGiaCT();
            }
            else
            {
                Utils.showMessage(Utils.ERR_FILE_FORMAT(Utils.EXCEL_EXTENSION_1), "Thông báo");
                txtFile.Text = "";
                return;
            }
        }

        private void viewBangGiaCT()
        {
            convertExcelContent2BangGiaCTDataTable();
            grdGiaImport.DataSource = bangGiaCT;
        }

        private void initBangGiaCTDataTable()
        {
            bangGiaCT = new DataTable();
            bangGiaCT.Columns.Add("Banggiactid", typeof(string));
            bangGiaCT.Columns.Add("Banggiaid", typeof(string));
            bangGiaCT.Columns.Add("Mavung", typeof(string));
            bangGiaCT.Columns.Add("Spid", typeof(string));
            bangGiaCT.Columns.Add("Masp", typeof(string));
            bangGiaCT.Columns.Add("Tensp", typeof(string));
            bangGiaCT.Columns.Add("Giagoc", typeof(double));
            bangGiaCT.Columns.Add("Giasi", typeof(double));
            bangGiaCT.Columns.Add("Giale", typeof(double));
            bangGiaCT.Columns.Add("Ghichu", typeof(string));

        }

        private DataTable ReadDataFromExcelFile()
        {
            string connectionString = PROVIDER + "Data Source=" + fileName.Trim() + ";" + EXTENDED_PROPERTIES;
            OleDbConnection oledbConn = new OleDbConnection(connectionString);
            DataTable data = null;
            try
            {
                oledbConn.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [GIA_SP$]", oledbConn);
                OleDbDataAdapter oleda = new OleDbDataAdapter();

                oleda.SelectCommand = cmd;
                DataSet ds = new DataSet();
                oleda.Fill(ds);

                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                Utils.showMessage("Có lỗi trong quá trình xử lý", "Thông báo");
            }
            finally
            {
                // Đóng chuỗi kết nối
                oledbConn.Close();
            }
            return data;
        }

        private DataTable getProductByCode(string code)
        {
            string mSQL = "select * from DM_SANPHAM";
            if (code.Length > 0)
            {
                mSQL += string.Format(" where UPPER(Masp) = '{0}' ", code.ToString().ToUpper());
            }

            DataTable dt = MTSQLServer.getMTSQLServer().wRead(mSQL, null, false);
            return dt;
        }

        private void convertExcelContent2BangGiaCTDataTable()
        {
            try
            {
                DataRow rw;
                for (int i = 2; i < excelContent.Rows.Count; i++)
                {
                    rw = bangGiaCT.NewRow();
                    if (excelContent.Rows[i][0] == null || excelContent.Rows[i][0].ToString() == "")
                    {
                        break;
                    }
                    rw["Banggiactid"] = MTGlobal.GetNewID();
                    rw["Banggiaid"] = bangGiaid;
                    rw["Mavung"] = excelContent.Rows[i][0] == DBNull.Value ? "" : excelContent.Rows[i][0].ToString();
                    string masp = excelContent.Rows[i][1] == DBNull.Value ? "" : Utils.convertToUnsignedString(excelContent.Rows[i][1].ToString());
                    DataTable product = this.getProductByCode(masp);
                    if (product.Rows.Count < 1)
                    {
                        continue;
                    }
                    string spid = product.Rows[0]["Maspid"] == DBNull.Value ? "" : product.Rows[0]["Maspid"].ToString();
                    rw["Spid"] = spid;
                    rw["Masp"] = masp;
                    rw["Tensp"] = product.Rows[0]["Tensp"] == DBNull.Value ? "" : product.Rows[0]["Tensp"].ToString();
                    rw["Giagoc"] = excelContent.Rows[i][2] == DBNull.Value ? 0 : double.Parse(excelContent.Rows[i][2].ToString());
                    rw["Giasi"] = excelContent.Rows[i][3] == DBNull.Value ? 0 : double.Parse(excelContent.Rows[i][3].ToString());
                    rw["Giale"] = excelContent.Rows[i][4] == DBNull.Value ? 0 : double.Parse(excelContent.Rows[i][4].ToString());
                    rw["Ghichu"] = excelContent.Rows[i][5] == DBNull.Value ? "" : excelContent.Rows[i][5].ToString();

                    bangGiaCT.Rows.Add(rw);
                }
            }
            catch (Exception ex)
            {
                Utils.showMessage("Vui lòng kiểm tra nội dung file", "Thông báo");
                return;
            }
        }


        public void SaveBangGia()
        {
            try
            {
                SqlParameter[] arrPara = new SqlParameter[4];
                arrPara[0] = new SqlParameter("@tblBanggiaCT", SqlDbType.Structured);
                arrPara[0].Value = bangGiaCT;
                arrPara[1] = new SqlParameter("@Banggiaid", SqlDbType.NVarChar, 50);
                arrPara[1].Value = bangGiaid;
                arrPara[2] = new SqlParameter("@Loai", SqlDbType.NVarChar, 10);
                arrPara[2].Value = loai;
                arrPara[3] = new SqlParameter("@Nguoidung", SqlDbType.NVarChar, 50);
                arrPara[3].Value = MTGlobal.MT_USER_LOGIN;
                int iRs = MTSQLServer.getMTSQLServer().wExec("spDM_ImportBanggia", arrPara);

                if (iRs == -1)
                {
                    Utils.showMessage("Dữ liệu không thể cập nhật. Vui lòng kiểm tra lại.", "Thông báo");
                    //return;
                }
                else
                {
                    Utils.showMessage("Dữ liệu cập nhật thành công.", "Thông báo");
                    txtFile.Text = "";
                    initBangGiaCTDataTable();
                    grdGiaImport.DataSource = bangGiaCT;
                }
            }
            catch (Exception ex)
            {
                Utils.showMessage("Lỗi kết nối cơ sở dữ liệu", "Lỗi", "ERR");
                return;
            }
        }

        private void dlg_ImportGiaSanPham_Load(object sender, EventArgs e)
        {
            txtFile.ReadOnly = true;
            initBangGiaCTDataTable();
            btnImport.Enabled = false;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            SaveBangGia();
        }
    }
}
