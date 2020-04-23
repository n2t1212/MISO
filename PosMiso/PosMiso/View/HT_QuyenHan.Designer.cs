namespace PosMiso.View
{
    partial class HT_QuyenHan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grdNhomQuyen = new DevExpress.XtraGrid.GridControl();
            this.gvNhomQuyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsoid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmanhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltennhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdQuyenHan = new DevExpress.XtraGrid.GridControl();
            this.gvQuyenHan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmacn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchucnang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colthem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colxoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colduyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdAdd = new System.Windows.Forms.ToolStripButton();
            this.cmdEdit = new System.Windows.Forms.ToolStripButton();
            this.cmdDel = new System.Windows.Forms.ToolStripButton();
            this.cmdSave = new System.Windows.Forms.ToolStripButton();
            this.cmdAbort = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhomQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuyenHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuyenHan)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1317, 48);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 48);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grdNhomQuyen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdQuyenHan);
            this.splitContainer1.Size = new System.Drawing.Size(1317, 600);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 2;
            // 
            // grdNhomQuyen
            // 
            this.grdNhomQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNhomQuyen.Location = new System.Drawing.Point(0, 0);
            this.grdNhomQuyen.MainView = this.gvNhomQuyen;
            this.grdNhomQuyen.Name = "grdNhomQuyen";
            this.grdNhomQuyen.Size = new System.Drawing.Size(1317, 218);
            this.grdNhomQuyen.TabIndex = 0;
            this.grdNhomQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhomQuyen});
            // 
            // gvNhomQuyen
            // 
            this.gvNhomQuyen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsoid,
            this.colmanhom,
            this.coltennhom});
            this.gvNhomQuyen.GridControl = this.grdNhomQuyen;
            this.gvNhomQuyen.Name = "gvNhomQuyen";
            this.gvNhomQuyen.OptionsView.ShowGroupPanel = false;
            this.gvNhomQuyen.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvNhomQuyen_RowClick);
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
            this.colmanhom.Width = 440;
            // 
            // coltennhom
            // 
            this.coltennhom.Caption = "Tên nhóm";
            this.coltennhom.FieldName = "tennhom";
            this.coltennhom.Name = "coltennhom";
            this.coltennhom.Visible = true;
            this.coltennhom.VisibleIndex = 1;
            this.coltennhom.Width = 859;
            // 
            // grdQuyenHan
            // 
            this.grdQuyenHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdQuyenHan.Location = new System.Drawing.Point(0, 0);
            this.grdQuyenHan.MainView = this.gvQuyenHan;
            this.grdQuyenHan.Name = "grdQuyenHan";
            this.grdQuyenHan.Size = new System.Drawing.Size(1317, 378);
            this.grdQuyenHan.TabIndex = 0;
            this.grdQuyenHan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvQuyenHan});
            this.grdQuyenHan.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grdQuyenHan_PreviewKeyDown);
            // 
            // gvQuyenHan
            // 
            this.gvQuyenHan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colmacn,
            this.colchucnang,
            this.colthem,
            this.colsua,
            this.colxoa,
            this.colduyet,
            this.colin});
            this.gvQuyenHan.GridControl = this.grdQuyenHan;
            this.gvQuyenHan.Name = "gvQuyenHan";
            this.gvQuyenHan.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "soid";
            this.colID.FieldName = "soid";
            this.colID.Name = "colID";
            // 
            // colmacn
            // 
            this.colmacn.Caption = "macn";
            this.colmacn.FieldName = "macn";
            this.colmacn.Name = "colmacn";
            // 
            // colchucnang
            // 
            this.colchucnang.Caption = "Tên chức năng";
            this.colchucnang.FieldName = "chucnang";
            this.colchucnang.Name = "colchucnang";
            this.colchucnang.Visible = true;
            this.colchucnang.VisibleIndex = 0;
            // 
            // colthem
            // 
            this.colthem.Caption = "Thêm";
            this.colthem.FieldName = "them";
            this.colthem.Name = "colthem";
            this.colthem.Visible = true;
            this.colthem.VisibleIndex = 1;
            // 
            // colsua
            // 
            this.colsua.Caption = "Sửa";
            this.colsua.FieldName = "sua";
            this.colsua.Name = "colsua";
            this.colsua.Visible = true;
            this.colsua.VisibleIndex = 2;
            // 
            // colxoa
            // 
            this.colxoa.Caption = "Xóa";
            this.colxoa.FieldName = "xoa";
            this.colxoa.Name = "colxoa";
            this.colxoa.Visible = true;
            this.colxoa.VisibleIndex = 3;
            // 
            // colduyet
            // 
            this.colduyet.Caption = "Duyệt";
            this.colduyet.FieldName = "duyet";
            this.colduyet.Name = "colduyet";
            this.colduyet.Visible = true;
            this.colduyet.VisibleIndex = 4;
            // 
            // colin
            // 
            this.colin.Caption = "In";
            this.colin.FieldName = "in";
            this.colin.Name = "colin";
            this.colin.Visible = true;
            this.colin.VisibleIndex = 5;
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
            this.cmdExit,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1317, 48);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Image = global::PosMiso.Properties.Resources.ic_btn_add1;
            this.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(65, 45);
            this.cmdAdd.Text = "Thêm (F2)";
            this.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAdd.ToolTipText = "Thêm (F2)";
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click_1);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Image = global::PosMiso.Properties.Resources.ic_btn_edit;
            this.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(53, 45);
            this.cmdEdit.Text = "Sửa (F3)";
            this.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdEdit.ToolTipText = "Sửa (F3)";
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click_1);
            // 
            // cmdDel
            // 
            this.cmdDel.Image = global::PosMiso.Properties.Resources.ic_btn_del;
            this.cmdDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(54, 45);
            this.cmdDel.Text = "Xóa (F4)";
            this.cmdDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdDel.ToolTipText = "Xóa (F4)";
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click_1);
            // 
            // cmdSave
            // 
            this.cmdSave.Image = global::PosMiso.Properties.Resources.ic_btn_save;
            this.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(54, 45);
            this.cmdSave.Text = "Lưu (F5)";
            this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdSave.ToolTipText = "Lưu (F5)";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click_1);
            // 
            // cmdAbort
            // 
            this.cmdAbort.Image = global::PosMiso.Properties.Resources.ic_btn_abort;
            this.cmdAbort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAbort.Name = "cmdAbort";
            this.cmdAbort.Size = new System.Drawing.Size(61, 45);
            this.cmdAbort.Text = "Hủy (Esc)";
            this.cmdAbort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAbort.ToolTipText = "Hủy (Esc)";
            this.cmdAbort.Click += new System.EventHandler(this.cmdAbort_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // cmdExit
            // 
            this.cmdExit.Image = global::PosMiso.Properties.Resources.ic_btn_exit;
            this.cmdExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(65, 45);
            this.cmdExit.Text = "Thoát (F8)";
            this.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // HT_QuyenHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 648);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Name = "HT_QuyenHan";
            this.Text = "Quyền hạn";
            this.Load += new System.EventHandler(this.HT_QuyenHan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNhomQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuyenHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuyenHan)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl grdNhomQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhomQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colsoid;
        private DevExpress.XtraGrid.Columns.GridColumn colmanhom;
        private DevExpress.XtraGrid.Columns.GridColumn coltennhom;
        private DevExpress.XtraGrid.GridControl grdQuyenHan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvQuyenHan;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colmacn;
        private DevExpress.XtraGrid.Columns.GridColumn colchucnang;
        private DevExpress.XtraGrid.Columns.GridColumn colthem;
        private DevExpress.XtraGrid.Columns.GridColumn colsua;
        private DevExpress.XtraGrid.Columns.GridColumn colxoa;
        private DevExpress.XtraGrid.Columns.GridColumn colduyet;
        private DevExpress.XtraGrid.Columns.GridColumn colin;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdAdd;
        private System.Windows.Forms.ToolStripButton cmdEdit;
        private System.Windows.Forms.ToolStripButton cmdDel;
        private System.Windows.Forms.ToolStripButton cmdSave;
        private System.Windows.Forms.ToolStripButton cmdAbort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cmdExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

    }
}