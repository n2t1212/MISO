﻿using PosMiso.Model;
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
    public partial class DM_Xe : Form
    {
        DataTable otblSrcXe = null;

        public DM_Xe()
        {
            InitializeComponent();
        }

        private void DM_Xe_Load(object sender, EventArgs e)
        {
            setDataSourceXe();
        }

        private void setDataSourceXe()
        {
            try
            {
                String mSql = String.Format("select Xeid,Soxe,Loaixe,Taixe,Dienthoai,Diachi,Ghichu from DM_XE order by Xeid asc");
                otblSrcXe = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
                if (otblSrcXe == null)
                {
                    Utils.showMessage("Không thể đọc dữ liệu cần chọn...", "Thông báo");
                    return;
                }

                grdXe.DataSource = otblSrcXe;
                SysPar.SetGridReadOnly(true, gvXe);
            }
            catch (Exception ex) { }

        }
    }
}
