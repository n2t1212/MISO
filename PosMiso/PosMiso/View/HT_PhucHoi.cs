using Microsoft.Win32;
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
    public partial class HT_PhucHoi : Form
    {
        private string restoreFile = "";
        private SqlConnection testSQLConnection;

        private string SERVER = "";
        private string USERNAME = "";
        private string PASSWORD = "";
        private string DBNAME = "";

        public HT_PhucHoi()
        {
            InitializeComponent();
        }

        private void HT_PhucHoi_Load(object sender, EventArgs e)
        {
            showOrHideRestoreData(false);
            initServerCombobox();
            DBNAME = MTGlobal.ReadRegistryKey(MTGlobal.MT_REGKEY_SECTION_SQL, MTGlobal.MT_REGKEY_DBNAME, "MTSMPOS");

            if (DBNAME != null && DBNAME.Length > 0)
            {
                txtCSDL.Text = DBNAME;
                txtCSDL.Enabled = false;
            }
              
        }

        private void btnCheckConnect_Click(object sender, EventArgs e)
        {
            if (cbxServer.SelectedItem == null)
            {
                Utils.showMessage("Vui lòng chọn server", "Thông báo");
                cbxServer.Focus();
                return;
            }
            SERVER = cbxServer.SelectedItem.ToString();
            USERNAME = txtUsername.Text.Trim();
            PASSWORD = txtPassword.Text.Trim();

            if (USERNAME.Length == 0)
            {
                Utils.showMessage("Tài khoản không được bỏ trống", "Thông báo");
                return;
            }

            if (PASSWORD.Length == 0)
            {
                Utils.showMessage("Mật khẩu không được bỏ trống", "Thông báo");
                return;
            }

            //string testConnectionStr = string.Format(@"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3};Max Pool Size=2000", SERVER, MTGlobal.MT_DBNAME, USERNAME, PASSWORD);
            string testConnectionStr = string.Format(@"Data Source={0};Persist Security Info=True;User ID={1};Password={2};Max Pool Size=2000", SERVER, USERNAME, PASSWORD);

            if (isConnection(testConnectionStr))
            {
                Utils.showMessage("Kết nối thành công", "Thông báo");
                btnCheckConnect.Visible = false;
                showOrHideRestoreData(true);
                return;
            }

            txtCSDL.Focus();
        }

        private bool isConnection(string connectionStr)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionStr))
                {
                    conn.Open(); // throws if invalid
                    return true;
                }
            }
            catch (Exception ex)
            {
                Utils.showMessage("Không thể kết nối server. Vui lòng kiểm tra lại thông tin", "Thông báo");
                return false;
            }
        }

        private void showOrHideRestoreData(bool isShow)
        {
            lblFile.Visible = isShow;
            lblCSDL.Visible = isShow;
            txtPath.Visible = isShow;
            txtCSDL.Visible = isShow;
            btnPath.Visible = isShow;
            btnRestore.Visible = isShow;
        }

        #region "GET_SQL_CBX"
        private void initServerCombobox()
        {
            List<string> lstServer = this.ListLocalSqlInstances().ToList();
            //int count = lstServer.Count;
            //List<ServerSQL> dsServer = new List<ServerSQL>();
            //if (count > 0)
            //{
            //    for (int i = 0; i < count; i++)
            //    {
            //        dsServer.Add(new ServerSQL() { name = lstServer[i] });
            //    }
            //}

            cbxServer.DataSource = lstServer;
        }

        public class DatabaseSystem
        {
            public string name { get; set; }
        }

        public class ServerSQL
        {
            public string name { get; set; }
        }

        private IEnumerable<string> ListLocalSqlInstances()
        {
            if (Environment.Is64BitOperatingSystem)
            {
                using (var hive = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                {
                    foreach (string item in ListLocalSqlInstances(hive))
                    {
                        yield return item;
                    }
                }

                using (var hive = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
                {
                    foreach (string item in ListLocalSqlInstances(hive))
                    {
                        yield return item;
                    }
                }
            }
            else
            {
                foreach (string item in ListLocalSqlInstances(Registry.LocalMachine))
                {
                    yield return item;
                }
            }
        }

        private IEnumerable<string> ListLocalSqlInstances(RegistryKey hive)
        {
            const string keyName = @"Software\Microsoft\Microsoft SQL Server";
            const string valueName = "InstalledInstances";
            const string defaultName = "MSSQLSERVER";

            using (var key = hive.OpenSubKey(keyName, false))
            {
                if (key == null) return Enumerable.Empty<string>();

                var value = key.GetValue(valueName) as string[];
                if (value == null) return Enumerable.Empty<string>();

                for (int index = 0; index < value.Length; index++)
                {
                    if (string.Equals(value[index], defaultName, StringComparison.OrdinalIgnoreCase))
                    {
                        value[index] = ".";
                    }
                    else
                    {
                        value[index] = @".\" + value[index];
                    }
                }

                return value;
            }
        }
        #endregion

        private void btnPath_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                restoreFile = ofd.FileName;
                txtPath.Text = restoreFile;
                btnRestore.Enabled = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (txtCSDL.Text.ToString() == null)
            {
                Utils.showMessage("Vui lòng chọn CSDL cần phục hồi", "Thông báo");
                txtPath.Text = "";
                btnRestore.Enabled = false;
                txtCSDL.Focus();
                return;
            }

            DBNAME = txtCSDL.Text.ToString().Trim();

            if (Utils.isDatabaseExisted(DBNAME))
            {
                Utils.showMessage("CSDL đã tồn tại. Vui lòng chọn tên CSDL khác.", "Thông báo");
                txtPath.Text = "";
                btnRestore.Enabled = false;
                txtCSDL.Focus();
                return;
            }

            if (!Utils.validateFileType(restoreFile, Utils.BACKUP_SQL_TYPE))
            {
                Utils.showMessage(Utils.ERR_FILE_FORMAT(Utils.BACKUP_SQL_EXTENSION), "Thông báo");
                txtPath.Text = "";
                btnRestore.Enabled = false;
                return;
            }

            try
            {
                if (MTGlobal.MT_Cnn.State == ConnectionState.Closed)
                {
                    MTGlobal.MT_Cnn.Open();
                }

                btnRestore.Enabled = false;

                string testConnectionStr = string.Format(@"Data Source={0};Persist Security Info=True;User ID={1};Password={2};Max Pool Size=2000", SERVER, USERNAME, PASSWORD);

                if (!isConnection(testConnectionStr))
                {
                    Utils.showMessage("Tài khoản hoặc mật khẩu không đúng. Vui lòng kiểm tra lại", "Thông báo");
                    return;
                }

                if (Utils.createAndRestoreDB(SERVER, USERNAME, PASSWORD, DBNAME, restoreFile))
                {
                    Utils.showMessage("Phục hồi dữ liệu thành công", "Thông báo");
                }
                else
                {
                    Utils.showMessage("Không thể phục hồi dữ liệu. Vui lòng kiểm tra lại", "Thông báo");
                }

            }
            catch (Exception ex)
            {
                Utils.showMessage("Có lỗi trong quá trình phục hồi dữ liệu", "Thông báo");
            }
        }

    }
}
