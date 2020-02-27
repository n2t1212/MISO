using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using PosMiso.Model;
using System.Threading;

namespace PosMiso.View
{
    public partial class HT_Login : DevExpress.XtraEditors.XtraForm
    {
        SqlDataAdapter SQLAdaptor = null;
        DataSet DSetMain = null;

        public BackgroundWorker bw = new BackgroundWorker();

        public HT_Login()
        {
            InitializeComponent();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }

        #region "BACKGROUND"
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(200);
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Canceled!";
            }

            else if (!(e.Error == null))
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Error: " + e.Error.Message;
            }
            else
            {
                lblMsg.Visible = true;
                lblMsg.Text = "LOGIN SUCCESSFUL";
                txtUserName.Enabled = true;
                txtPassWord.Enabled = true;
                btnLogin.Enabled = true;

                MisoMain oM = new MisoMain();
                this.Hide();
                oM.ShowDialog();
                this.Close();
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }
        #endregion

        #region "LOGIN"
        private void button1_Click(object sender, EventArgs e)
        {
            DevExpress.Utils.WaitDialogForm Dlg = new DevExpress.Utils.WaitDialogForm("Đang nạp dữ liệu...", "QUẢN LÝ KHO HÀNG");
            Dlg.Show();

            try
            {
                String userName = txtUserName.Text.ToUpper().Trim();
                string pass = txtPassWord.Text;
                lblMsg.Visible = false;
                Cursor.Current = Cursors.WaitCursor;
                txtUserName.Enabled = false;
                txtPassWord.Enabled = false;
                btnLogin.Enabled = false;

                string mLoginRs = new modMember().fValidMember(userName, pass);
                if (mLoginRs == "T")
                {
                    MTGlobal.SetConfigKey("MT_ACCOUNT", userName);
                    if (chkRemember.Checked == true)
                    {
                        MTGlobal.SetConfigKey("MT_PASSWORD", txtPassWord.Text.ToString());
                        MTGlobal.SetConfigKey("MT_REMEMBER", "1");
                    }
                    else
                    {
                        MTGlobal.SetConfigKey("MT_PASSWORD", "");
                        MTGlobal.SetConfigKey("MT_REMEMBER", "0");
                    }
                    if (bw.IsBusy == false)
                    {
                        bw.RunWorkerAsync();
                    }


                    Thread vThread = new Thread(() =>{
                        try{
                            MTSynData.doSyncCheckActive();
                            MTGlobal.onSetPara();
                        }
                        catch { }
                    });
                    vThread.Start();                          
                }
                else
                {
                    //lblLoading.Visibility = Visibility.Hidden;
                    lblMsg.Visible = true;
                    lblMsg.Text = mLoginRs;
                    txtUserName.Enabled = true;
                    txtPassWord.Enabled = true;
                    btnLogin.Enabled = true;
                    txtUserName.SelectAll();
                    txtPassWord.Focus();
                    txtPassWord.SelectAll();
                }
            }
            catch (Exception ex) {}

            if (Dlg != null) { Dlg.Close(); }
        }
        #endregion

        #region "EXIT"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "KEYDOWN"
        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUserName.Text.Trim() == "") 
                { 
                    txtUserName.Focus(); 
                    lblMsg.Text = "Bạn chưa nhập tài khoản đăng nhập !";
                }
                else
                {
                    txtPassWord.Focus();
                }
            }
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPassWord.Text.Trim() == "") 
                { 
                    txtPassWord.Focus();
                    lblMsg.Text = "Bạn chưa nhập mật khẩu đăng nhập !";
                }
                else
                {
                    btnLogin.Focus();
                }
            }
        }
        #endregion

        #region "EVENT"
        private void HT_Login_Load(object sender, EventArgs e)
        {
            string mUsername = MTGlobal.MT_USER_LOGIN;
            string mPassword = MTGlobal.MT_REMEMBER == true ? MTGlobal.MT_USER_PASS : "";

            if (MTGlobal.MT_REMEMBER) { chkRemember.Checked = true; }

            if (mUsername != "")
            {
                txtUserName.Text = mUsername.Trim().ToUpper();
                txtPassWord.Text = mPassword;
                lblWelcome.Text = "Welcome " + mUsername.Trim().ToUpper();
                lblWelcome.Visible = true;
                lblUsername.Visible = false;
                txtUserName.Visible = false;

            }
            else
            {
                lblWelcome.Visible = false;
                lblUsername.Visible = true;
                txtUserName.Visible = true;
                txtUserName.Text = "";
                txtUserName.Focus();
            }
        }
        #endregion

        private void lblWelcome_Click(object sender, EventArgs e)
        {
            lblWelcome.Visible = false;
            lblUsername.Visible = true;
            txtUserName.Visible = true;
        }
    }
}