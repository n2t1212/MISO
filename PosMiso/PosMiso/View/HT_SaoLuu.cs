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
    public partial class HT_SaoLuu : Form
    {
        string backUpFile = "";

        public HT_SaoLuu()
        {
            InitializeComponent();
            lblError.Enabled = false;
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblError.Enabled = false;

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Chọn thư mục";

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                backUpFile = fbd.SelectedPath + "\\" + MTGlobal.MT_DBNAME + DateTime.Now.ToString("yyyyMMddHHmmss") + ".bak";
                txtPath.Text = backUpFile;
                btnBackup.Enabled = true;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (backUpFile.Trim().Length == 0)
                {
                    lblError.Text = "Vui lòng chọn thư mục lưu trữ";
                    lblError.Enabled = true;
                    return;
                }

                string cmd = "BACKUP DATABASE [" + MTGlobal.MT_DBNAME + "] TO DISK='" + @backUpFile + "'";


                if (MTGlobal.MT_Cnn.State == ConnectionState.Closed)
                {
                    MTGlobal.MT_Cnn.Open();
                }

                SqlCommand command = new SqlCommand(cmd, MTGlobal.MT_Cnn);
                int rs = command.ExecuteNonQuery();

                Utils.showMessage("Sao lưu dữ liệu thành công", "Thông báo", "MSG");
                btnBackup.Enabled = false;
            }
            catch (Exception ex)
            {
                Utils.showMessage("Lỗi. Không thể sao lưu dữ liệu", "", "Thông báo");
            }
        }
    }
}
