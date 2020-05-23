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
    public partial class dlg_ImportSanPham : Form
    {
        private const string PROVIDER = "Provider=Microsoft.ACE.OLEDB.12.0;";
        private const string EXTENDED_PROPERTIES = "Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1;';";
        private const string MOI = "MOI";

        private DataTable sanPham;
        private DataTable excelContent;

        public string manhomspid = "";
        private string fileName = "";
        private string loai = "";

        public dlg_ImportSanPham()
        {
            InitializeComponent();
        }

        public dlg_ImportSanPham(string mNhomspid)
        {
            InitializeComponent();
            this.manhomspid = mNhomspid;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (isNew.Checked == true)
            {
                loai = MOI;
            }
            SaveSanPham();
            btnImport.Enabled = false;
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
                viewSanPham();
            }
            else
            {
                Utils.showMessage(Utils.ERR_FILE_FORMAT(Utils.EXCEL_EXTENSION_1), "Thông báo");
                txtFile.Text = "";
                return;
            }
        }

        private void viewSanPham()
        {
            convertExcelContent2sanPhamDataTable();
            grdSanPhamImport.DataSource = sanPham;
        }

        private void dlg_ImportSanPham_Load(object sender, EventArgs e)
        {
            txtFile.ReadOnly = true;
            initSanPhamDataTable();
            btnImport.Enabled = false;
        }

        private void initSanPhamDataTable()
        {
            sanPham = new DataTable();
            sanPham.Columns.Add("Spid", typeof(string));
            sanPham.Columns.Add("Manhomspid", typeof(string));
            sanPham.Columns.Add("Masp", typeof(string));
            sanPham.Columns.Add("Tensp", typeof(string));
            sanPham.Columns.Add("Dvt", typeof(string));
            sanPham.Columns.Add("Quycach", typeof(string));
            sanPham.Columns.Add("Quydoikgl", typeof(double));
            sanPham.Columns.Add("Quydoithung", typeof(double));
            sanPham.Columns.Add("Nhacungcap", typeof(string));
            sanPham.Columns.Add("Mabarcode", typeof(string));
            sanPham.Columns.Add("Maqrcode", typeof(string));
            sanPham.Columns.Add("Ngaylap", typeof(DateTime));
            sanPham.Columns.Add("Nguoilap", typeof(string));
            sanPham.Columns.Add("Ngaysua", typeof(DateTime));
            sanPham.Columns.Add("Nguoisua", typeof(string));
        }

        private DataTable ReadDataFromExcelFile()
        {
            string connectionString = PROVIDER + "Data Source=" + fileName.Trim() + ";" + EXTENDED_PROPERTIES;
            OleDbConnection oledbConn = new OleDbConnection(connectionString);
            DataTable data = null;
            try
            {
                oledbConn.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [SAN_PHAM$]", oledbConn);
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

        private void convertExcelContent2sanPhamDataTable()
        {
            DataRow rw;
            try
            {
                for (int i = 2; i < excelContent.Rows.Count; i++)
                {
                    rw = sanPham.NewRow();
                    if (excelContent.Rows[i][0] == null || excelContent.Rows[i][0].ToString() == "")
                    {
                        break;
                    }
                    string spid = "";
                    string tensp = "";
                    rw["Manhomspid"] = manhomspid;
                    string masp = excelContent.Rows[i][0] == DBNull.Value ? "" : Utils.convertToUnsignedString(excelContent.Rows[i][0].ToString());
                    DataTable product = this.getProductByCode(masp);
                    if (product.Rows.Count == 1)
                    {
                        spid = product.Rows[0]["Maspid"] == DBNull.Value ? "" : product.Rows[0]["Maspid"].ToString();
                        //tensp = product.Rows[0]["Tensp"] == DBNull.Value ? "" : product.Rows[0]["Tensp"].ToString();
                    }
                    else
                    {
                        spid = MTGlobal.GetNewID();
                        //tensp = excelContent.Rows[i][1] == DBNull.Value ? "" : excelContent.Rows[i][1].ToString();
                    }
                    tensp = excelContent.Rows[i][1] == DBNull.Value ? "" : excelContent.Rows[i][1].ToString();
                    rw["Spid"] = spid;
                    rw["Masp"] = masp;
                    rw["Tensp"] = tensp;
                    rw["Dvt"] = excelContent.Rows[i][2] == DBNull.Value ? "" : excelContent.Rows[i][2].ToString();
                    rw["Quycach"] = excelContent.Rows[i][3] == DBNull.Value ? "" : excelContent.Rows[i][3].ToString();
                    rw["Quydoikgl"] = excelContent.Rows[i][4] == DBNull.Value ? 0 : double.Parse(excelContent.Rows[i][4].ToString());
                    rw["Quydoithung"] = excelContent.Rows[i][5] == DBNull.Value ? 1 : double.Parse(excelContent.Rows[i][5].ToString());
                    rw["Nhacungcap"] = excelContent.Rows[i][6] == DBNull.Value ? "" : excelContent.Rows[i][6].ToString();
                    rw["Ngaylap"] = DateTime.Now;
                    rw["Nguoilap"] = MTGlobal.MT_USER_LOGIN;
                    rw["Mabarcode"] = masp;
                    rw["Maqrcode"] = masp;

                    sanPham.Rows.Add(rw);
                }
            }
            catch (Exception ex)
            {
                Utils.showMessage("Vui lòng kiểm tra nội dung file", "Thông báo");
                return;
            }
        }

        public void SaveSanPham()
        {
            try
            {
                SqlParameter[] arrPara = new SqlParameter[4];
                arrPara[0] = new SqlParameter("@tblSanPham", SqlDbType.Structured);
                arrPara[0].Value = sanPham;
                arrPara[1] = new SqlParameter("@Nhomid", SqlDbType.NVarChar, 50);
                arrPara[1].Value = manhomspid;
                arrPara[2] = new SqlParameter("@Loai", SqlDbType.NVarChar, 10);
                arrPara[2].Value = loai;
                arrPara[3] = new SqlParameter("@Nguoidung", SqlDbType.NVarChar, 50);
                arrPara[3].Value = MTGlobal.MT_USER_LOGIN;
                int iRs = MTSQLServer.getMTSQLServer().wExec("spDM_ImportSanPham", arrPara);

                if (iRs == -1)
                {
                    Utils.showMessage("Dữ liệu không thể cập nhật. Vui lòng kiểm tra lại.", "Thông báo");
                    //return;
                }
                else
                {
                    Utils.showMessage("Dữ liệu cập nhật thành công.", "Thông báo");
                    txtFile.Text = "";
                    initSanPhamDataTable();
                    grdSanPhamImport.DataSource = sanPham;
                }
            }
            catch (Exception ex)
            {
                Utils.showMessage("Lỗi kết nối cơ sở dữ liệu", "Lỗi");
                return;
            }
        }
    }
}
