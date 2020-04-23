namespace PosMiso.View
{
    partial class HT_NhomQuyen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdAdd = new System.Windows.Forms.ToolStripButton();
            this.cmdEdit = new System.Windows.Forms.ToolStripButton();
            this.cmdDel = new System.Windows.Forms.ToolStripButton();
            this.cmdSave = new System.Windows.Forms.ToolStripButton();
            this.cmdAbort = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdExit = new System.Windows.Forms.ToolStripButton();
            this.grdNhomQuyen = new DevExpress.XtraGrid.GridControl();
            this.gvNhomQuyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsoid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmanhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltennhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnguoilap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaylap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnguoisua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaysua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhomQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 42);
            this.panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdAdd,
            this.cmdEdit,
            this.cmdDel,
            this.cmdSave,
            this.cmdAbort,
            this.toolStripSeparator1,
            this.cmdExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(943, 42);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Image = global::PosMiso.Properties.Resources.ic_btn_add1;
            this.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(65, 39);
            this.cmdAdd.Text = "Thêm (F2)";
            this.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click_1);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Image = global::PosMiso.Properties.Resources.ic_btn_edit;
            this.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(53, 39);
            this.cmdEdit.Text = "Sửa (F3)";
            this.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click_1);
            // 
            // cmdDel
            // 
            this.cmdDel.Image = global::PosMiso.Properties.Resources.ic_btn_del;
            this.cmdDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(54, 39);
            this.cmdDel.Text = "Xóa (F4)";
            this.cmdDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click_1);
            // 
            // cmdSave
            // 
            this.cmdSave.Image = global::PosMiso.Properties.Resources.ic_btn_save;
            this.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(54, 39);
            this.cmdSave.Text = "Lưu (F5)";
            this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click_1);
            // 
            // cmdAbort
            // 
            this.cmdAbort.Image = global::PosMiso.Properties.Resources.ic_btn_abort;
            this.cmdAbort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAbort.Name = "cmdAbort";
            this.cmdAbort.Size = new System.Drawing.Size(61, 39);
            this.cmdAbort.Text = "Hủy (Esc)";
            this.cmdAbort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAbort.Click += new System.EventHandler(this.cmdAbort_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // cmdExit
            // 
            this.cmdExit.Image = global::PosMiso.Properties.Resources.ic_exit;
            this.cmdExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(65, 39);
            this.cmdExit.Text = "Thoát (F8)";
            this.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // grdNhomQuyen
            // 
            this.grdNhomQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNhomQuyen.Location = new System.Drawing.Point(0, 42);
            this.grdNhomQuyen.MainView = this.gvNhomQuyen;
            this.grdNhomQuyen.Name = "grdNhomQuyen";
            this.grdNhomQuyen.Size = new System.Drawing.Size(943, 348);
            this.grdNhomQuyen.TabIndex = 2;
            this.grdNhomQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhomQuyen});
            this.grdNhomQuyen.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grdNhomQuyen_PreviewKeyDown);
            // 
            // gvNhomQuyen
            // 
            this.gvNhomQuyen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsoid,
            this.colmanhom,
            this.coltennhom,
            this.colnguoilap,
            this.colngaylap,
            this.colnguoisua,
            this.colngaysua});
            this.gvNhomQuyen.GridControl = this.grdNhomQuyen;
            this.gvNhomQuyen.Name = "gvNhomQuyen";
            this.gvNhomQuyen.OptionsView.ShowGroupPanel = false;
            this.gvNhomQuyen.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvNhomQuyen_InitNewRow);
            // 
            // colsoid
            // 
            this.colsoid.Caption = "soid";
            this.colsoid.FieldName = "soid";
            this.colsoid.Name = "colsoid";
            // 
            // colmanhom
            // 
            this.colmanhom.Caption = "Mã nhóm";
            this.colmanhom.FieldName = "manhom";
            this.colmanhom.Name = "colmanhom";
            this.colmanhom.Visible = true;
            this.colmanhom.VisibleIndex = 0;
            // 
            // coltennhom
            // 
            this.coltennhom.Caption = "Tên nhóm";
            this.coltennhom.FieldName = "tennhom";
            this.coltennhom.Name = "coltennhom";
            this.coltennhom.Visible = true;
            this.coltennhom.VisibleIndex = 1;
            // 
            // colnguoilap
            // 
            this.colnguoilap.Caption = "Người lập";
            this.colnguoilap.FieldName = "nguoilap";
            this.colnguoilap.Name = "colnguoilap";
            this.colnguoilap.OptionsColumn.AllowEdit = false;
            this.colnguoilap.OptionsColumn.AllowFocus = false;
            this.colnguoilap.OptionsColumn.ReadOnly = true;
            this.colnguoilap.Visible = true;
            this.colnguoilap.VisibleIndex = 2;
            // 
            // colngaylap
            // 
            this.colngaylap.Caption = "Ngày lập";
            this.colngaylap.FieldName = "ngaylap";
            this.colngaylap.Name = "colngaylap";
            this.colngaylap.OptionsColumn.AllowEdit = false;
            this.colngaylap.OptionsColumn.AllowFocus = false;
            this.colngaylap.OptionsColumn.ReadOnly = true;
            this.colngaylap.Visible = true;
            this.colngaylap.VisibleIndex = 3;
            // 
            // colnguoisua
            // 
            this.colnguoisua.Caption = "Người sửa";
            this.colnguoisua.FieldName = "nguoisua";
            this.colnguoisua.Name = "colnguoisua";
            this.colnguoisua.OptionsColumn.AllowEdit = false;
            this.colnguoisua.OptionsColumn.AllowFocus = false;
            this.colnguoisua.OptionsColumn.ReadOnly = true;
            this.colnguoisua.Visible = true;
            this.colnguoisua.VisibleIndex = 4;
            // 
            // colngaysua
            // 
            this.colngaysua.Caption = "Ngày sửa";
            this.colngaysua.FieldName = "ngaysua";
            this.colngaysua.Name = "colngaysua";
            this.colngaysua.OptionsColumn.AllowEdit = false;
            this.colngaysua.OptionsColumn.AllowFocus = false;
            this.colngaysua.OptionsColumn.ReadOnly = true;
            this.colngaysua.Visible = true;
            this.colngaysua.VisibleIndex = 5;
            // 
            // HT_NhomQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 390);
            this.Controls.Add(this.grdNhomQuyen);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HT_NhomQuyen";
            this.Text = "Nhóm quyền hệ thống";
            this.Load += new System.EventHandler(this.HT_NhomQuyen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhomQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomQuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl grdNhomQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhomQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colsoid;
        private DevExpress.XtraGrid.Columns.GridColumn colmanhom;
        private DevExpress.XtraGrid.Columns.GridColumn coltennhom;
        private DevExpress.XtraGrid.Columns.GridColumn colnguoilap;
        private DevExpress.XtraGrid.Columns.GridColumn colngaylap;
        private DevExpress.XtraGrid.Columns.GridColumn colnguoisua;
        private DevExpress.XtraGrid.Columns.GridColumn colngaysua;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdAdd;
        private System.Windows.Forms.ToolStripButton cmdEdit;
        private System.Windows.Forms.ToolStripButton cmdDel;
        private System.Windows.Forms.ToolStripButton cmdSave;
        private System.Windows.Forms.ToolStripButton cmdAbort;
        private System.Windows.Forms.ToolStripButton cmdExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}