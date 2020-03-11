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
    public partial class DM_LyDo : Form
    {
        DataTable otblSrcLyDo = null;

        public DM_LyDo()
        {
            InitializeComponent();
        }

        private void DM_LyDo_Load(object sender, EventArgs e)
        {
            setDataSourceLyDo();
        }

        private void setDataSourceLyDo()
        {
            try
            {
                String mSql = String.Format("select Mald,Lydo,Loai,TKNo,TKCo,Ghichu from DM_LYDO order by Mald asc");
                otblSrcLyDo = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
                if (otblSrcLyDo == null)
                {
                    Utils.showMessage("Không thể đọc dữ liệu cần chọn...", "Thông báo");
                    return;
                }

                grdLyDo.DataSource = otblSrcLyDo;
                SysPar.SetGridReadOnly(true, gvLyDo);
            }
            catch (Exception ex) { }

        }
    }
}
