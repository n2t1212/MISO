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
    public partial class CN_ChungTu : Form
    {
        private List<String> TYPE_CT = new List<String> {"Lập từ báo giá",
                                                        "Lập từ Đơn đặt hàng",
                                                        "Lập từ Hợp đồng bán",
                                                        "Lập từ Phiếu xuất",
                                                        "Lập từ Hóa đơn",
                                                        "Lập từ Mua hàng",
                                                        "Lập từ chuyển kho"};
        public CN_ChungTu()
        {
            InitializeComponent();
            cbxLoai.SelectedIndex = 0;
            initTypeCheckCombobox();
        }

        void initTypeCheckCombobox()
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
