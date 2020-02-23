using PosMiso.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosMiso.View
{
    public partial class HT_StartingForm : Form
    {
        public HT_StartingForm()
        {
            InitializeComponent();
        }

        DevExpress.Utils.WaitDialogForm oWait;

        private void HT_StartingForm_Load(object sender, EventArgs e)
        {
            oWait= Utils.shwWait("Đang tạo kết nối dữ liệu hệ thống...", "Đang xử lý..");
            try{
                if (MTGlobal.MTAPPSTART())
                {
                    MTGlobal.onSetPara();
                    Utils.closeWait(oWait);
                    if (MTGlobal.HT_POS_IMEI == "")
                    {
                        HT_Register register = new HT_Register();
                        this.Hide();
                        register.ShowDialog();
                    }
                    else
                    {
                        HT_Login login = new HT_Login();
                        this.Hide();
                        login.ShowDialog();
                    }
                    this.Close();
                }
                else
                {
                    Utils.closeWait(oWait);
                    if (Utils.ConfirmMessage("Thông tin kết nối dữ liệu không đúng. Bạn có muốn tạo kết nối đến CSDL ?", "Xác nhận tạo kết nối"))
                    {
                        //Show Đăng ký kết nối SQL  
                        HT_CreateConection oConnect = new HT_CreateConection();
                        oConnect.ShowDialog();
                        if (oConnect.isConnect)
                        {
                            HT_Login login = new HT_Login();
                            login.Show();
                        }
                        else {
                            this.Close();
                        }

                    }
                    else {
                        this.Close();
                    }
                    
                }
                 Utils.closeWait(oWait);
            }
            catch (Exception ex) {
                Utils.showMessage("ERROR LOAD:" + ex.Message.ToString(), "THÔNG TIN LỖI");
                Utils.closeWait(oWait);
            }
        }
    }
}
