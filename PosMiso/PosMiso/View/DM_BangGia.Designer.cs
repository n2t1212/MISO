namespace PosMiso.View
{
    partial class DM_BangGia
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdAdd = new System.Windows.Forms.ToolStripButton();
            this.cmdEdit = new System.Windows.Forms.ToolStripButton();
            this.cmdDel = new System.Windows.Forms.ToolStripButton();
            this.cmdSave = new System.Windows.Forms.ToolStripButton();
            this.cmdAbort = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.grdBangGia = new DevExpress.XtraGrid.GridControl();
            this.gvBangGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBanggiaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBanggia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTungay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDenngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayapdung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApdung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaylap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoilap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaysua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoisua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangGia)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdAdd,
            this.cmdEdit,
            this.cmdDel,
            this.cmdSave,
            this.cmdAbort,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(967, 38);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Image = global::PosMiso.Properties.Resources.ic_btn_add1;
            this.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(65, 35);
            this.cmdAdd.Text = "Thêm (F2)";
            this.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Image = global::PosMiso.Properties.Resources.ic_btn_edit;
            this.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(53, 35);
            this.cmdEdit.Text = "Sửa (F3)";
            this.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdDel
            // 
            this.cmdDel.Image = global::PosMiso.Properties.Resources.ic_btn_del;
            this.cmdDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(54, 35);
            this.cmdDel.Text = "Xóa (F4)";
            this.cmdDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Image = global::PosMiso.Properties.Resources.ic_btn_save;
            this.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(54, 35);
            this.cmdSave.Text = "Lưu (F5)";
            this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdAbort
            // 
            this.cmdAbort.Image = global::PosMiso.Properties.Resources.ic_btn_abort;
            this.cmdAbort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAbort.Name = "cmdAbort";
            this.cmdAbort.Size = new System.Drawing.Size(61, 35);
            this.cmdAbort.Text = "Hủy (Esc)";
            this.cmdAbort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAbort.Click += new System.EventHandler(this.cmdAbort_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::PosMiso.Properties.Resources.ic_exit;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(65, 35);
            this.toolStripButton2.Text = "Thoát (F8)";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // grdBangGia
            // 
            this.grdBangGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBangGia.Location = new System.Drawing.Point(0, 38);
            this.grdBangGia.MainView = this.gvBangGia;
            this.grdBangGia.Name = "grdBangGia";
            this.grdBangGia.Size = new System.Drawing.Size(967, 407);
            this.grdBangGia.TabIndex = 25;
            this.grdBangGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBangGia});
            this.grdBangGia.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grdBangGia_PreviewKeyDown);
            // 
            // gvBangGia
            // 
            this.gvBangGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBanggiaid,
            this.colBanggia,
            this.colTungay,
            this.colDenngay,
            this.colNgayapdung,
            this.colApdung,
            this.colNgaylap,
            this.colNguoilap,
            this.colNgaysua,
            this.colNguoisua});
            this.gvBangGia.GridControl = this.grdBangGia;
            this.gvBangGia.Name = "gvBangGia";
            this.gvBangGia.OptionsView.ShowGroupPanel = false;
            this.gvBangGia.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvBangGia_InitNewRow);
            // 
            // colBanggiaid
            // 
            this.colBanggiaid.Caption = "Banggiaid";
            this.colBanggiaid.FieldName = "Banggiaid";
            this.colBanggiaid.Name = "colBanggiaid";
            // 
            // colBanggia
            // 
            this.colBanggia.Caption = "Tên bảng giá";
            this.colBanggia.FieldName = "Banggia";
            this.colBanggia.Name = "colBanggia";
            this.colBanggia.Visible = true;
            this.colBanggia.VisibleIndex = 0;
            // 
            // colTungay
            // 
            this.colTungay.Caption = "Áp dụng từ ngày";
            this.colTungay.FieldName = "Tungay";
            this.colTungay.Name = "colTungay";
            this.colTungay.Visible = true;
            this.colTungay.VisibleIndex = 1;
            // 
            // colDenngay
            // 
            this.colDenngay.Caption = "Áp dụng đến ngày";
            this.colDenngay.FieldName = "Denngay";
            this.colDenngay.Name = "colDenngay";
            this.colDenngay.Visible = true;
            this.colDenngay.VisibleIndex = 2;
            // 
            // colNgayapdung
            // 
            this.colNgayapdung.Caption = "Ngày áp dụng";
            this.colNgayapdung.FieldName = "Ngayapdung";
            this.colNgayapdung.Name = "colNgayapdung";
            this.colNgayapdung.Visible = true;
            this.colNgayapdung.VisibleIndex = 3;
            // 
            // colApdung
            // 
            this.colApdung.Caption = "Áp dụng";
            this.colApdung.FieldName = "Apdung";
            this.colApdung.Name = "colApdung";
            this.colApdung.Visible = true;
            this.colApdung.VisibleIndex = 4;
            // 
            // colNgaylap
            // 
            this.colNgaylap.Caption = "Ngày lập";
            this.colNgaylap.FieldName = "Ngaylap";
            this.colNgaylap.Name = "colNgaylap";
            this.colNgaylap.Visible = true;
            this.colNgaylap.VisibleIndex = 6;
            // 
            // colNguoilap
            // 
            this.colNguoilap.Caption = "Người lập";
            this.colNguoilap.FieldName = "Nguoilap";
            this.colNguoilap.Name = "colNguoilap";
            this.colNguoilap.Visible = true;
            this.colNguoilap.VisibleIndex = 5;
            // 
            // colNgaysua
            // 
            this.colNgaysua.Caption = "Ngaysua";
            this.colNgaysua.FieldName = "Ngaysua";
            this.colNgaysua.Name = "colNgaysua";
            // 
            // colNguoisua
            // 
            this.colNguoisua.Caption = "Nguoisua";
            this.colNguoisua.FieldName = "Nguoisua";
            this.colNguoisua.Name = "colNguoisua";
            // 
            // DM_BangGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 445);
            this.Controls.Add(this.grdBangGia);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DM_BangGia";
            this.Text = "Bảng giá";
            this.Load += new System.EventHandler(this.DM_BangGia_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdAdd;
        private System.Windows.Forms.ToolStripButton cmdEdit;
        private System.Windows.Forms.ToolStripButton cmdDel;
        private System.Windows.Forms.ToolStripButton cmdSave;
        private System.Windows.Forms.ToolStripButton cmdAbort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private DevExpress.XtraGrid.GridControl grdBangGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn colBanggiaid;
        private DevExpress.XtraGrid.Columns.GridColumn colBanggia;
        private DevExpress.XtraGrid.Columns.GridColumn colTungay;
        private DevExpress.XtraGrid.Columns.GridColumn colDenngay;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayapdung;
        private DevExpress.XtraGrid.Columns.GridColumn colApdung;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaylap;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoilap;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaysua;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoisua;
    }
}