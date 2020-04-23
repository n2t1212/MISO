namespace PosMiso.View
{
    partial class DM_SanPham
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
            this.panelFunction = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdDownload = new System.Windows.Forms.ToolStripButton();
            this.btnImport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdAdd = new System.Windows.Forms.ToolStripButton();
            this.cmdEdit = new System.Windows.Forms.ToolStripButton();
            this.cmdDel = new System.Windows.Forms.ToolStripButton();
            this.cmdSave = new System.Windows.Forms.ToolStripButton();
            this.cmdAbort = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdPrintCode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdExit = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grdNhomSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvNhomSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colManhomspid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTennhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaspid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManhomspid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTensp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDvt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuycach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuydoikgl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuydoithung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMabarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaqrcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelFunction.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhomSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFunction
            // 
            this.panelFunction.Controls.Add(this.toolStrip1);
            this.panelFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFunction.Location = new System.Drawing.Point(0, 0);
            this.panelFunction.Name = "panelFunction";
            this.panelFunction.Size = new System.Drawing.Size(1191, 49);
            this.panelFunction.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdDownload,
            this.btnImport,
            this.toolStripSeparator1,
            this.cmdAdd,
            this.cmdEdit,
            this.cmdDel,
            this.cmdSave,
            this.cmdAbort,
            this.toolStripSeparator2,
            this.cmdPrintCode,
            this.toolStripSeparator3,
            this.cmdExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1191, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdDownload
            // 
            this.cmdDownload.Image = global::PosMiso.Properties.Resources.ic_btn_download;
            this.cmdDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDownload.Name = "cmdDownload";
            this.cmdDownload.Size = new System.Drawing.Size(54, 35);
            this.cmdDownload.Text = "Tải Mẫu";
            this.cmdDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdDownload.Click += new System.EventHandler(this.cmdDownload_Click);
            // 
            // btnImport
            // 
            this.btnImport.Image = global::PosMiso.Properties.Resources.ic_btn_upload;
            this.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(59, 35);
            this.btnImport.Text = "Nhập file";
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Image = global::PosMiso.Properties.Resources.ic_btn_add1;
            this.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(65, 35);
            this.cmdAdd.Text = "Thêm (F2)";
            this.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click_1);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Image = global::PosMiso.Properties.Resources.ic_btn_edit;
            this.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(53, 35);
            this.cmdEdit.Text = "Sửa (F3)";
            this.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click_1);
            // 
            // cmdDel
            // 
            this.cmdDel.Image = global::PosMiso.Properties.Resources.ic_btn_del;
            this.cmdDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(54, 35);
            this.cmdDel.Text = "Xóa (F4)";
            this.cmdDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click_1);
            // 
            // cmdSave
            // 
            this.cmdSave.Image = global::PosMiso.Properties.Resources.ic_btn_save;
            this.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(54, 35);
            this.cmdSave.Text = "Lưu (F5)";
            this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click_1);
            // 
            // cmdAbort
            // 
            this.cmdAbort.Image = global::PosMiso.Properties.Resources.ic_btn_abort;
            this.cmdAbort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAbort.Name = "cmdAbort";
            this.cmdAbort.Size = new System.Drawing.Size(61, 35);
            this.cmdAbort.Text = "Hủy (Esc)";
            this.cmdAbort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAbort.Click += new System.EventHandler(this.cmdAbort_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // cmdPrintCode
            // 
            this.cmdPrintCode.Image = global::PosMiso.Properties.Resources.ic_btn_print_qr;
            this.cmdPrintCode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPrintCode.Name = "cmdPrintCode";
            this.cmdPrintCode.Size = new System.Drawing.Size(64, 35);
            this.cmdPrintCode.Text = "In mã (F7)";
            this.cmdPrintCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdPrintCode.Click += new System.EventHandler(this.cmdPrintCode_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // cmdExit
            // 
            this.cmdExit.Image = global::PosMiso.Properties.Resources.ic_exit;
            this.cmdExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(65, 35);
            this.cmdExit.Text = "Thoát (F8)";
            this.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grdNhomSanPham);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdSanPham);
            this.splitContainer1.Size = new System.Drawing.Size(1191, 482);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 8;
            // 
            // grdNhomSanPham
            // 
            this.grdNhomSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNhomSanPham.Location = new System.Drawing.Point(0, 0);
            this.grdNhomSanPham.MainView = this.gvNhomSanPham;
            this.grdNhomSanPham.Name = "grdNhomSanPham";
            this.grdNhomSanPham.Size = new System.Drawing.Size(1191, 212);
            this.grdNhomSanPham.TabIndex = 2;
            this.grdNhomSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhomSanPham,
            this.gridView1});
            // 
            // gvNhomSanPham
            // 
            this.gvNhomSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colManhomspid,
            this.colManhom,
            this.colTennhom});
            this.gvNhomSanPham.GridControl = this.grdNhomSanPham;
            this.gvNhomSanPham.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvNhomSanPham.Name = "gvNhomSanPham";
            this.gvNhomSanPham.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvNhomSanPham.OptionsView.ColumnAutoWidth = false;
            this.gvNhomSanPham.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvNhomSanPham.OptionsView.ShowGroupPanel = false;
            this.gvNhomSanPham.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gvNhomSanPham.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gvNhomSanPham.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvNhomSanPham.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvNhomSanPham_RowClick);
            // 
            // colManhomspid
            // 
            this.colManhomspid.Caption = "Manhomspid";
            this.colManhomspid.FieldName = "Manhomspid";
            this.colManhomspid.Name = "colManhomspid";
            // 
            // colManhom
            // 
            this.colManhom.Caption = "Mã nhóm";
            this.colManhom.FieldName = "Manhom";
            this.colManhom.Name = "colManhom";
            this.colManhom.Visible = true;
            this.colManhom.VisibleIndex = 0;
            this.colManhom.Width = 477;
            // 
            // colTennhom
            // 
            this.colTennhom.Caption = "Tên nhóm";
            this.colTennhom.FieldName = "Tennhom";
            this.colTennhom.Name = "colTennhom";
            this.colTennhom.Visible = true;
            this.colTennhom.VisibleIndex = 1;
            this.colTennhom.Width = 697;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdNhomSanPham;
            this.gridView1.Name = "gridView1";
            // 
            // grdSanPham
            // 
            this.grdSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSanPham.Location = new System.Drawing.Point(0, 0);
            this.grdSanPham.MainView = this.gvSanPham;
            this.grdSanPham.Name = "grdSanPham";
            this.grdSanPham.Size = new System.Drawing.Size(1191, 266);
            this.grdSanPham.TabIndex = 1;
            this.grdSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPham});
            this.grdSanPham.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grdSanPham_PreviewKeyDown);
            // 
            // gvSanPham
            // 
            this.gvSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaspid,
            this.colManhomspid1,
            this.colMasp,
            this.colTensp,
            this.colDvt,
            this.colQuycach,
            this.colQuydoikgl,
            this.colQuydoithung,
            this.colMabarcode,
            this.colMaqrcode});
            this.gvSanPham.GridControl = this.grdSanPham;
            this.gvSanPham.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvSanPham.Name = "gvSanPham";
            this.gvSanPham.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvSanPham.OptionsView.ShowGroupPanel = false;
            this.gvSanPham.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gvSanPham.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gvSanPham.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvSanPham.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvSanPham_InitNewRow);
            this.gvSanPham.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvSanPham_KeyDown);
            // 
            // colMaspid
            // 
            this.colMaspid.Caption = "MASPID";
            this.colMaspid.FieldName = "Maspid";
            this.colMaspid.Name = "colMaspid";
            // 
            // colManhomspid1
            // 
            this.colManhomspid1.Caption = "Manhomspid";
            this.colManhomspid1.FieldName = "Manhomspid";
            this.colManhomspid1.Name = "colManhomspid1";
            // 
            // colMasp
            // 
            this.colMasp.Caption = "Mã hàng";
            this.colMasp.FieldName = "Masp";
            this.colMasp.Name = "colMasp";
            this.colMasp.Visible = true;
            this.colMasp.VisibleIndex = 0;
            this.colMasp.Width = 202;
            // 
            // colTensp
            // 
            this.colTensp.Caption = "Tên hàng hóa";
            this.colTensp.FieldName = "Tensp";
            this.colTensp.Name = "colTensp";
            this.colTensp.Visible = true;
            this.colTensp.VisibleIndex = 1;
            this.colTensp.Width = 324;
            // 
            // colDvt
            // 
            this.colDvt.Caption = "Đơn vị tính";
            this.colDvt.FieldName = "Dvt";
            this.colDvt.Name = "colDvt";
            this.colDvt.Visible = true;
            this.colDvt.VisibleIndex = 2;
            this.colDvt.Width = 112;
            // 
            // colQuycach
            // 
            this.colQuycach.Caption = "Quy cách";
            this.colQuycach.FieldName = "Quycach";
            this.colQuycach.Name = "colQuycach";
            this.colQuycach.Visible = true;
            this.colQuycach.VisibleIndex = 3;
            this.colQuycach.Width = 83;
            // 
            // colQuydoikgl
            // 
            this.colQuydoikgl.Caption = "Quy đổi Kgl";
            this.colQuydoikgl.FieldName = "Quydoikgl";
            this.colQuydoikgl.Name = "colQuydoikgl";
            this.colQuydoikgl.Visible = true;
            this.colQuydoikgl.VisibleIndex = 4;
            this.colQuydoikgl.Width = 74;
            // 
            // colQuydoithung
            // 
            this.colQuydoithung.Caption = "Quy đổi thùng";
            this.colQuydoithung.FieldName = "Quydoithung";
            this.colQuydoithung.Name = "colQuydoithung";
            this.colQuydoithung.Visible = true;
            this.colQuydoithung.VisibleIndex = 5;
            this.colQuydoithung.Width = 91;
            // 
            // colMabarcode
            // 
            this.colMabarcode.Caption = "Mã bar code";
            this.colMabarcode.FieldName = "Mabarcode";
            this.colMabarcode.Name = "colMabarcode";
            this.colMabarcode.OptionsColumn.AllowEdit = false;
            this.colMabarcode.OptionsColumn.AllowFocus = false;
            this.colMabarcode.OptionsColumn.ReadOnly = true;
            this.colMabarcode.Visible = true;
            this.colMabarcode.VisibleIndex = 6;
            this.colMabarcode.Width = 126;
            // 
            // colMaqrcode
            // 
            this.colMaqrcode.Caption = "Mã QR code";
            this.colMaqrcode.FieldName = "Maqrcode";
            this.colMaqrcode.Name = "colMaqrcode";
            this.colMaqrcode.OptionsColumn.AllowEdit = false;
            this.colMaqrcode.OptionsColumn.AllowFocus = false;
            this.colMaqrcode.OptionsColumn.ReadOnly = true;
            this.colMaqrcode.Visible = true;
            this.colMaqrcode.VisibleIndex = 7;
            this.colMaqrcode.Width = 144;
            // 
            // DM_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 531);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelFunction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DM_SanPham";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.DM_SanPham_Load);
            this.panelFunction.ResumeLayout(false);
            this.panelFunction.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNhomSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFunction;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl grdNhomSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhomSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colManhomspid;
        private DevExpress.XtraGrid.Columns.GridColumn colManhom;
        private DevExpress.XtraGrid.Columns.GridColumn colTennhom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grdSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colMaspid;
        private DevExpress.XtraGrid.Columns.GridColumn colMasp;
        private DevExpress.XtraGrid.Columns.GridColumn colTensp;
        private DevExpress.XtraGrid.Columns.GridColumn colDvt;
        private DevExpress.XtraGrid.Columns.GridColumn colQuycach;
        private DevExpress.XtraGrid.Columns.GridColumn colQuydoikgl;
        private DevExpress.XtraGrid.Columns.GridColumn colQuydoithung;
        private DevExpress.XtraGrid.Columns.GridColumn colMabarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colMaqrcode;
        private DevExpress.XtraGrid.Columns.GridColumn colManhomspid1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdDownload;
        private System.Windows.Forms.ToolStripButton btnImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cmdAdd;
        private System.Windows.Forms.ToolStripButton cmdEdit;
        private System.Windows.Forms.ToolStripButton cmdDel;
        private System.Windows.Forms.ToolStripButton cmdSave;
        private System.Windows.Forms.ToolStripButton cmdAbort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton cmdPrintCode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton cmdExit;

    }
}