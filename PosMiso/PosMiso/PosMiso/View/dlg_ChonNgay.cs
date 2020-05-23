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
    public partial class dlg_ChonNgay : Form
    {
        private bool isLoad = false;
        public bool isChon = false;

        public dlg_ChonNgay()
        {
            InitializeComponent();
            isLoad = true;
            resetDateData();
            if (MTGlobal.MT_LOAI_TG == "M")
            {
                rdbThang.Checked = true;
            }
            else if (MTGlobal.MT_LOAI_TG == "Y")
            {
                rdbNam.Checked = true;
            }
            else
            {
                rdbNgay.Checked = true;
            }
        }

        private void resetDateData()
        {
            MTGlobal.MT_TUNGAY = "";
            MTGlobal.MT_DENNGAY = "";
            MTGlobal.MT_THANG = "";
            MTGlobal.MT_NAM = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                isChon = false;
                if (rdbNgay.Checked == true)
                {
                    if (dtpTuNgay.Text == "" && dtpDenNgay.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn ngày cần xem.", "Lưu ý", MessageBoxButtons.OK);
                        dtpTuNgay.Focus();
                        return;
                    }
                    else if (dtpTuNgay.Text == "" && dtpDenNgay.Text != "")
                    {
                        MessageBox.Show("Bạn chưa chọn ngày bắt đầu cần xem.", "Lưu ý", MessageBoxButtons.OK);
                        dtpTuNgay.Focus();
                        return;
                    }
                    else if (dtpTuNgay.Text != "" && dtpDenNgay.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn đến ngày cần xem.", "Lưu ý", MessageBoxButtons.OK);
                        dtpDenNgay.Focus();
                        return;
                    }
                    else if (dtpTuNgay.DateTime > dtpDenNgay.DateTime)
                    {
                        MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc.", "Lưu ý", MessageBoxButtons.OK);
                        dtpTuNgay.Focus();
                        return;
                    }
                    MTGlobal.MT_TUNGAY = Convert.ToDateTime(dtpTuNgay.Text.ToString()).ToShortDateString();
                    MTGlobal.MT_DENNGAY = Convert.ToDateTime(dtpDenNgay.Text.ToString()).ToShortDateString();
                    isChon = true;
                }
                else if (rdbThang.Checked == true)
                {
                    if (txtThang.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn tháng cần xem.", "Lưu ý", MessageBoxButtons.OK);
                        txtThang.Focus();
                        return;
                    }

                    string[] dateArr = txtThang.Text.Trim().Split('/');
                    string m = "";
                    string y = "";
                    if (dateArr.Length == 2)
                    {
                        m = dateArr[0];
                        y = dateArr[1];
                    }
                    else if (dateArr.Length == 3)
                    {
                        m = dateArr[1];
                        y = dateArr[2];
                    }

                    m = m.Length == 1 ? "0" + m : m;
                    MTGlobal.MT_THANG = m;
                    MTGlobal.MT_TUNGAY = "01/" + m + "/" + y;
                    if (m.Substring(0, 2) == "12")
                    {
                        MTGlobal.MT_DENNGAY = "01/01/" + (int.Parse(y) + 1).ToString();
                    }
                    else
                    {
                        m = (int.Parse(m) + 1).ToString();
                        m = m.Length == 1 ? "0" + m : m;
                        MTGlobal.MT_DENNGAY = "01/" + m + "/" + y;
                    }
                    isChon = true;
                }

                else if (rdbNam.Checked == true)
                {
                    string y = "";

                    if (txtNam.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn năm cần xem..", "Lưu ý", MessageBoxButtons.OK);
                        txtNam.Focus();
                        return;

                    }
                    else
                    {
                        string[] dateArr = txtNam.Text.Trim().Split('/');
                        if (dateArr.Length == 1)
                        {
                            y = dateArr[0];
                        }
                        else if (dateArr.Length == 2)
                        {
                            y = dateArr[1];
                        }
                        else if (dateArr.Length == 3)
                        {
                            y = dateArr[2];
                        }

                        if (y.Length != 4 && int.Parse(y) < 1900)
                        {
                            MessageBox.Show("Năm cần xem không hợp lệ..", "Lưu ý", MessageBoxButtons.OK);
                            txtNam.Focus();
                            return;
                        }
                        else if (int.Parse(y) > DateTime.Today.Year)
                        {
                            MessageBox.Show("Năm cần xem không thể lớn hơn năm hiện tại..", "Lưu ý", MessageBoxButtons.OK);
                            txtNam.Focus();
                            return;
                        }
                    }
                    
                    MTGlobal.MT_TUNGAY = "01/01/" + y;
                    MTGlobal.MT_DENNGAY = "31/12/" + y;
                    MTGlobal.MT_NAM = y;
                    isChon = true;
                }

                if (isChon)
                {
                    this.Close();
                }
                else
                {
                    Utils.showMessage("Bạn chưa chọn thời gian cần xem..", "Lưu ý");
                }
            }
            catch { }
        }

        public void setPermit(bool isNgay = true, bool isThang = true, bool isNam = true)
        {
            if (isNgay)
            {
                rdbNgay.Enabled = true;
            }
            else { rdbNgay.Enabled = false; rdbNgay.Checked = false; }

            if (isThang)
            {
                rdbThang.Enabled = true;
            }
            else { rdbThang.Enabled = false; rdbThang.Checked = false; }

            if (isNam)
            {
                rdbNam.Enabled = true;
            }
            else { rdbNam.Enabled = false; rdbNam.Checked = false; }

            if (isNgay == true && isThang == false && isNam == false)
            {
                rdbNgay.Checked = true;
            }
            else if (isNgay == false && isThang == true && isNam == false)
            {
                rdbThang.Checked = true;
            }
            else if (isNgay == false && isThang == false && isNam == true)
            {
                rdbNam.Checked = true;
            }

            if (MTGlobal.MT_TUNGAY != "" && MTGlobal.MT_DENNGAY != "")
            {
                dtpTuNgay.EditValue = Convert.ToDateTime(MTGlobal.MT_TUNGAY);
                dtpDenNgay.EditValue = Convert.ToDateTime(MTGlobal.MT_DENNGAY);
            }
            else
            {
                dtpTuNgay.EditValue = DateTime.Now.AddDays(-1);
                dtpDenNgay.EditValue = DateTime.Now;
            }
            dtpTuNgay.Focus();
        }

        private void rdbNgay_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbNgay.Checked == true && isLoad == true)
                {
                    visibleDay();
                    if (MTGlobal.MT_TUNGAY != "" && MTGlobal.MT_DENNGAY != "")
                    {
                        dtpTuNgay.EditValue = Convert.ToDateTime(MTGlobal.MT_TUNGAY);
                        dtpDenNgay.EditValue = Convert.ToDateTime(MTGlobal.MT_DENNGAY);
                    }
                    else
                    {
                        dtpTuNgay.EditValue = DateTime.Now.AddDays(-1);
                        dtpDenNgay.EditValue = DateTime.Now;
                    }
                    dtpTuNgay.Focus();
                    MTGlobal.MT_LOAI_TG = "D";
                }
            }
            catch { }
        }

        private void rdbThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbThang.Checked == true && isLoad == true)
            {
                visibleMonth();
                if (MTGlobal.MT_THANG != "")
                {
                    txtThang.Text = MTGlobal.MT_THANG;
                }
                else
                {
                    txtThang.Text = DateTime.Today.Month.ToString().PadLeft(2, '0') + "/" + DateTime.Today.Year.ToString();
                }
                txtThang.Focus();
                MTGlobal.MT_LOAI_TG = "M";
            }
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNam.Checked == true && isLoad == true)
            {
                visibleYear();

                if (MTGlobal.MT_NAM != "")
                {
                    txtNam.Text = MTGlobal.MT_NAM;
                }
                else
                {
                    txtNam.Text = DateTime.Today.Year.ToString();
                }
                txtNam.Focus();
                MTGlobal.MT_LOAI_TG = "Y";
            }
        }

        private void visibleDay()
        {
            lblTuNgay.Visible = true;
            dtpTuNgay.Visible = true;
            lblDenNgay.Visible = true;
            dtpDenNgay.Visible = true;

            invisibleMonth();
            invisibleYear();
        }

        private void visibleMonth()
        {
            lblThang.Visible = true;
            txtThang.Visible = true;

            invisibleDay();
            invisibleYear();
        }

        private void visibleYear()
        {
            lblNam.Visible = true;
            txtNam.Visible = true;

            invisibleDay();
            invisibleMonth();
        }

        private void invisibleDay()
        {
            lblTuNgay.Visible = false;
            dtpTuNgay.Visible = false;
            lblDenNgay.Visible = false;
            dtpDenNgay.Visible = false;
        }

        private void invisibleMonth()
        {
            lblThang.Visible = false;
            txtThang.Visible = false;
        }

        private void invisibleYear()
        {
            lblNam.Visible = false;
            txtNam.Visible = false;
        }

    }
}
