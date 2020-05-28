using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PosMiso.UserControl
{
    public partial class UC_ToolStrip : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void cmdAddClickHandler();
        public event cmdAddClickHandler cmdAddClick;

        public delegate void cmdEditClickHandler();
        public event cmdEditClickHandler cmdEditClick;

        public delegate void cmdDelClickHandler();
        public event cmdDelClickHandler cmdDelClick;

        public delegate void cmdSaveClickHandler();
        public event cmdSaveClickHandler cmdSaveClick;

        public delegate void cmdAbortClickHandler();
        public event cmdAbortClickHandler cmdAbortClick;

        public delegate void cmdExitClickHandler();
        public event cmdExitClickHandler cmdExitClick;

        public UC_ToolStrip()
        {
            InitializeComponent();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            cmdAddClick();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            cmdEditClick();
        }

        private void cmdDel_Click(object sender, EventArgs e)
        {
            cmdDelClick();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            cmdSaveClick();
        }

        private void cmdAbort_Click(object sender, EventArgs e)
        {
            cmdAbortClick();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            cmdExitClick();
        }
    }
}
