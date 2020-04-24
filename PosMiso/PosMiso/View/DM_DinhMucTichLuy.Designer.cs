namespace PosMiso.View
{
    partial class DM_DinhMucTichLuy
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
            this.grdTichLuy = new DevExpress.XtraGrid.GridControl();
            this.gvTichLuy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItem = new PosMiso.Model.RepositoryItemCustomGridLookUpEdit();
            this.viewSP = new PosMiso.Model.CustomGridView();
            this.colMasp1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTensp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDvt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuycach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoanhSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoanhsoNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQDDiemDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQDDiemDSNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayapdung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDenngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApdung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTichLuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTichLuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSP)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(957, 38);
            this.toolStrip1.TabIndex = 23;
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
            // grdTichLuy
            // 
            this.grdTichLuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTichLuy.Location = new System.Drawing.Point(0, 38);
            this.grdTichLuy.MainView = this.gvTichLuy;
            this.grdTichLuy.Name = "grdTichLuy";
            this.grdTichLuy.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItem});
            this.grdTichLuy.Size = new System.Drawing.Size(957, 395);
            this.grdTichLuy.TabIndex = 24;
            this.grdTichLuy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTichLuy});
            this.grdTichLuy.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grdTichLuy_PreviewKeyDown);
            // 
            // gvTichLuy
            // 
            this.gvTichLuy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasp,
            this.colDoanhSo,
            this.colDoanhsoNo,
            this.colQDDiemDS,
            this.colQDDiemDSNo,
            this.colNgayapdung,
            this.colDenngay,
            this.colApdung});
            this.gvTichLuy.GridControl = this.grdTichLuy;
            this.gvTichLuy.Name = "gvTichLuy";
            this.gvTichLuy.OptionsView.ShowGroupPanel = false;
            // 
            // colMasp
            // 
            this.colMasp.Caption = "Mã sản phẩm";
            this.colMasp.ColumnEdit = this.repositoryItem;
            this.colMasp.FieldName = "Masp";
            this.colMasp.Name = "colMasp";
            this.colMasp.Visible = true;
            this.colMasp.VisibleIndex = 0;
            // 
            // repositoryItem
            // 
            this.repositoryItem.AutoComplete = false;
            this.repositoryItem.AutoHeight = false;
            this.repositoryItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItem.Name = "repositoryItem";
            this.repositoryItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItem.View = this.viewSP;
            // 
            // viewSP
            // 
            this.viewSP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasp1,
            this.colTensp,
            this.colDvt,
            this.colQuycach});
            this.viewSP.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.viewSP.Name = "viewSP";
            this.viewSP.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.viewSP.OptionsView.ShowGroupPanel = false;
            // 
            // colMasp1
            // 
            this.colMasp1.Caption = "Mã sản phẩm";
            this.colMasp1.FieldName = "Masp";
            this.colMasp1.Name = "colMasp1";
            this.colMasp1.Visible = true;
            this.colMasp1.VisibleIndex = 0;
            // 
            // colTensp
            // 
            this.colTensp.Caption = "Tên sản phẩm";
            this.colTensp.FieldName = "Tensp";
            this.colTensp.Name = "colTensp";
            this.colTensp.Visible = true;
            this.colTensp.VisibleIndex = 1;
            // 
            // colDvt
            // 
            this.colDvt.Caption = "Đơn vị tính";
            this.colDvt.FieldName = "Dvt";
            this.colDvt.Name = "colDvt";
            this.colDvt.Visible = true;
            this.colDvt.VisibleIndex = 2;
            // 
            // colQuycach
            // 
            this.colQuycach.Caption = "Quy cách";
            this.colQuycach.FieldName = "Quycach";
            this.colQuycach.Name = "colQuycach";
            this.colQuycach.Visible = true;
            this.colQuycach.VisibleIndex = 3;
            // 
            // colDoanhSo
            // 
            this.colDoanhSo.Caption = "Doanh số";
            this.colDoanhSo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDoanhSo.FieldName = "DoanhSo";
            this.colDoanhSo.Name = "colDoanhSo";
            this.colDoanhSo.Visible = true;
            this.colDoanhSo.VisibleIndex = 1;
            // 
            // colDoanhsoNo
            // 
            this.colDoanhsoNo.Caption = "Doanh số nợ";
            this.colDoanhsoNo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDoanhsoNo.FieldName = "DoanhsoNo";
            this.colDoanhsoNo.Name = "colDoanhsoNo";
            this.colDoanhsoNo.Visible = true;
            this.colDoanhsoNo.VisibleIndex = 2;
            // 
            // colQDDiemDS
            // 
            this.colQDDiemDS.Caption = "Quy đổi điểm doanh số";
            this.colQDDiemDS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQDDiemDS.FieldName = "QDDiemDS";
            this.colQDDiemDS.Name = "colQDDiemDS";
            this.colQDDiemDS.Visible = true;
            this.colQDDiemDS.VisibleIndex = 3;
            // 
            // colQDDiemDSNo
            // 
            this.colQDDiemDSNo.Caption = "Quy đổi điểm doanh số nợ";
            this.colQDDiemDSNo.FieldName = "QDDiemDSNo";
            this.colQDDiemDSNo.Name = "colQDDiemDSNo";
            this.colQDDiemDSNo.Visible = true;
            this.colQDDiemDSNo.VisibleIndex = 4;
            // 
            // colNgayapdung
            // 
            this.colNgayapdung.Caption = "Ngày áp dụng";
            this.colNgayapdung.FieldName = "Ngayapdung";
            this.colNgayapdung.Name = "colNgayapdung";
            this.colNgayapdung.Visible = true;
            this.colNgayapdung.VisibleIndex = 5;
            // 
            // colDenngay
            // 
            this.colDenngay.Caption = "Đến ngày";
            this.colDenngay.FieldName = "Denngay";
            this.colDenngay.Name = "colDenngay";
            this.colDenngay.Visible = true;
            this.colDenngay.VisibleIndex = 6;
            // 
            // colApdung
            // 
            this.colApdung.Caption = "Áp dụng";
            this.colApdung.FieldName = "Apdung";
            this.colApdung.Name = "colApdung";
            this.colApdung.Visible = true;
            this.colApdung.VisibleIndex = 7;
            // 
            // DM_DinhMucTichLuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 433);
            this.Controls.Add(this.grdTichLuy);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DM_DinhMucTichLuy";
            this.Text = "Định mức điểm tích lũy";
            this.Load += new System.EventHandler(this.DM_DinhMucTichLuy_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTichLuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTichLuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSP)).EndInit();
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
        private DevExpress.XtraGrid.GridControl grdTichLuy;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTichLuy;
        private DevExpress.XtraGrid.Columns.GridColumn colMasp;
        private Model.RepositoryItemCustomGridLookUpEdit repositoryItem;
        private Model.CustomGridView viewSP;
        private DevExpress.XtraGrid.Columns.GridColumn colMasp1;
        private DevExpress.XtraGrid.Columns.GridColumn colTensp;
        private DevExpress.XtraGrid.Columns.GridColumn colDvt;
        private DevExpress.XtraGrid.Columns.GridColumn colQuycach;
        private DevExpress.XtraGrid.Columns.GridColumn colDoanhSo;
        private DevExpress.XtraGrid.Columns.GridColumn colDoanhsoNo;
        private DevExpress.XtraGrid.Columns.GridColumn colQDDiemDS;
        private DevExpress.XtraGrid.Columns.GridColumn colQDDiemDSNo;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayapdung;
        private DevExpress.XtraGrid.Columns.GridColumn colDenngay;
        private DevExpress.XtraGrid.Columns.GridColumn colApdung;
    }
}