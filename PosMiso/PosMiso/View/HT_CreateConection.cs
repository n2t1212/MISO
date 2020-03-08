using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Linq;
using PosMiso.Model;
using DevExpress.XtraEditors.Controls;
using Microsoft.Win32;

namespace PosMiso.View
{
    public partial class HT_CreateConection : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection testSQLConnection;

        private string FILE_RESTORE = "";
        private string SERVER = "";
        private string USERNAME = "";
        private string PASSWORD = "";
        private string DBNAME = "";

        public bool isConnect = false;

        public HT_CreateConection()
        {
            InitializeComponent();
        }

        private void HT_CreateConection_Load(object sender, EventArgs e)
        {
            SERVER = MTGlobal.ReadRegistryKey(MTGlobal.MT_REGKEY_SECTION_SQL, MTGlobal.MT_REGKEY_DBHOST, "");
            DBNAME = MTGlobal.ReadRegistryKey(MTGlobal.MT_REGKEY_SECTION_SQL, MTGlobal.MT_REGKEY_DBNAME, "");
            USERNAME = MTGlobal.ReadRegistryKey(MTGlobal.MT_REGKEY_SECTION_SQL, MTGlobal.MT_REGKEY_DBUSER, "");
            PASSWORD = MTGlobal.ReadRegistryKey(MTGlobal.MT_REGKEY_SECTION_SQL, MTGlobal.MT_REGKEY_DBPASS, "");

            btnCreate.Visible = true;
            txtDB.Text = DBNAME;
            txtUsername.Text = USERNAME;
            txtPassword.Text = PASSWORD;
            //if (txtDB.Text != "")
            //{
            //    cmdSelectFile.Enabled = false;
            //}
            //else
            //{
            //    cmdSelectFile.Enabled = true;
            //}

            initServerCombobox();  
        }

        private bool isConnection(string connectionStr)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionStr))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void initServerCombobox()
        {
            List<string> lstServer = this.ListLocalSqlInstances().ToList();
            int count = lstServer.Count;
            ComboBoxItemCollection items = cbServer.Properties.Items;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    items.Add(lstServer[i]);
                }
            }
        }

        public class DatabaseSystem
        {
            public string name { get; set; }
        }

        public class ServerSQL
        {
            public string name { get; set; }
        }

        public class CSDL
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SERVER = cbServer.SelectedText.Trim();
            DBNAME = txtDB.Text.ToString().Trim();
            USERNAME = txtUsername.Text.ToString().Trim();
            PASSWORD = txtPassword.Text.ToString().Trim();

            if (SERVER.Length == 0)
            {
                Utils.showMessage("CSDL không được để trống", "Thông báo");
                cbServer.Focus();
                return;
            }
            if (DBNAME.Length == 0)
            {
                Utils.showMessage("Vui lòng nhập tên CSDL cần tạo...", "Thông báo");
                txtDB.Focus();
                return;
            }
            if (FILE_RESTORE.Length == 0)
            {
                Utils.showMessage("Vui lòng chọn tập tin khôi phục", "Thông báo");
                txtDB.Focus();
                return;
            }

            if (!Utils.validateFileType(FILE_RESTORE, Utils.BACKUP_SQL_TYPE))
            {
                Utils.showMessage(Utils.ERR_FILE_FORMAT(Utils.BACKUP_SQL_EXTENSION), "Thông báo");
                txtDB.Text = "";
                return;
            }

            string testConnectionStr = string.Format(@"Data Source={0};Persist Security Info=True;User ID={1};Password={2};Max Pool Size=2000", SERVER, USERNAME, PASSWORD);
            if (!isConnection(testConnectionStr))
            {
                Utils.showMessage("Tài khoản hoặc mật khẩu không đúng. Vui lòng kiểm tra lại", "Thông báo");
                isConnect = false;
                return;
            }

            if (Utils.createAndRestoreDB(SERVER, USERNAME, PASSWORD, DBNAME, FILE_RESTORE))
            {
                Utils.showMessage("Tạo CSDL thành công", "Thông báo");
                MTGlobal.WriteRegistryKey(MTGlobal.MT_REGKEY_SECTION_SQL, MTGlobal.MT_REGKEY_DBHOST, SERVER);
                MTGlobal.WriteRegistryKey(MTGlobal.MT_REGKEY_SECTION_SQL, MTGlobal.MT_REGKEY_DBNAME, DBNAME);
                MTGlobal.WriteRegistryKey(MTGlobal.MT_REGKEY_SECTION_SQL, MTGlobal.MT_REGKEY_DBUSER, USERNAME);
                MTGlobal.WriteRegistryKey(MTGlobal.MT_REGKEY_SECTION_SQL, MTGlobal.MT_REGKEY_DBPASS, PASSWORD);
                MTGlobal.MTAPPSTART();
                isConnect = true;
                this.Close();
                btnCreate.Visible = true;
            }
            else
            {
                Utils.showMessage("Không thể tạo CSDL", "Thông báo");
                isConnect = false;
            }
        }

        private void cmdSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FILE_RESTORE = ofd.FileName;
                    txtDB.Text = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
                    btnCreate.Visible = true;
                }
            }
            catch { }  
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}