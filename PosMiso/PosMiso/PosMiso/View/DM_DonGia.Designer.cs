namespace PosMiso.View
{
    partial class DM_DonGia
    {
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl grdBangGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn colBanggiaid;
        private DevExpress.XtraGrid.Columns.GridColumn coldBanggia;
        private DevExpress.XtraGrid.Columns.GridColumn colTungay;
        private DevExpress.XtraGrid.Columns.GridColumn colDenngay;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayapdung;
        private DevExpress.XtraGrid.Columns.GridColumn colApdung;
        private DevExpress.XtraGrid.GridControl grdBangGiaCT;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBangGiaCT;
        private DevExpress.XtraGrid.Columns.GridColumn colBanggiactid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaspid;
        private DevExpress.XtraGrid.Columns.GridColumn colMasp;
        private DevExpress.XtraGrid.Columns.GridColumn colTensp;
        private DevExpress.XtraGrid.Columns.GridColumn colGiagoc;
        private DevExpress.XtraGrid.Columns.GridColumn colGiasi;
        private DevExpress.XtraGrid.Columns.GridColumn colGiale;
        private DevExpress.XtraGrid.Columns.GridColumn colMavung;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnImport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdAdd = new System.Windows.Forms.ToolStripButton();
            this.cmdEdit = new System.Windows.Forms.ToolStripButton();
            this.cmdDel = new System.Windows.Forms.ToolStripButton();
            this.cmdSave = new System.Windows.Forms.ToolStripButton();
            this.cmdAbort = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grdBangGia = new DevExpress.XtraGrid.GridControl();
            this.gvBangGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBanggiaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldBanggia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTungay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDenngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayapdung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApdung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdBangGiaCT = new DevExpress.XtraGrid.GridControl();
            this.gvBangGiaCT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBanggiactid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaspid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItem = new PosMiso.Model.RepositoryItemCustomGridLookUpEdit();
            this.viewSP = new PosMiso.Model.CustomGridView();
            this.colMaspid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasp1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTensp1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDvt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuycach1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTensp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiagoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMavung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBangGiaCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangGiaCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 42);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnImport,
            this.toolStripSeparator1,
            this.cmdAdd,
            this.cmdEdit,
            this.cmdDel,
            this.cmdSave,
            this.cmdAbort,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1191, 38);
            this.toolStrip.TabIndex = 12;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::PosMiso.Properties.Resources.ic_btn_download;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(54, 35);
            this.toolStripButton1.Text = "Tải Mẫu";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 42);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grdBangGia);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdBangGiaCT);
            this.splitContainer1.Size = new System.Drawing.Size(1191, 585);
            this.splitContainer1.SplitterDistance = 237;
            this.splitContainer1.TabIndex = 1;
            // 
            // grdBangGia
            // 
            this.grdBangGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBangGia.Location = new System.Drawing.Point(0, 0);
            this.grdBangGia.MainView = this.gvBangGia;
            this.grdBangGia.Name = "grdBangGia";
            this.grdBangGia.Size = new System.Drawing.Size(1191, 237);
            this.grdBangGia.TabIndex = 0;
            this.grdBangGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBangGia});
            this.grdBangGia.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grdBangGia_PreviewKeyDown);
            // 
            // gvBangGia
            // 
            this.gvBangGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBanggiaid,
            this.coldBanggia,
            this.colTungay,
            this.colDenngay,
            this.colNgayapdung,
            this.colApdung});
            this.gvBangGia.GridControl = this.grdBangGia;
            this.gvBangGia.Name = "gvBangGia";
            this.gvBangGia.OptionsView.ShowGroupPanel = false;
            this.gvBangGia.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvBangGia_RowClick);
            // 
            // colBanggiaid
            // 
            this.colBanggiaid.Caption = "Banggiaid";
            this.colBanggiaid.FieldName = "Banggiaid";
            this.colBanggiaid.Name = "colBanggiaid";
            // 
            // coldBanggia
            // 
            this.coldBanggia.Caption = "Tên bảng giá";
            this.coldBanggia.FieldName = "Banggia";
            this.coldBanggia.Name = "coldBanggia";
            this.coldBanggia.Visible = true;
            this.coldBanggia.VisibleIndex = 0;
            // 
            // colTungay
            // 
            this.colTungay.Caption = "Từ ngày";
            this.colTungay.FieldName = "Tungay";
            this.colTungay.Name = "colTungay";
            this.colTungay.Visible = true;
            this.colTungay.VisibleIndex = 1;
            // 
            // colDenngay
            // 
            this.colDenngay.Caption = "Đến ngày";
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
            // grdBangGiaCT
            // 
            this.grdBangGiaCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBangGiaCT.Location = new System.Drawing.Point(0, 0);
            this.grdBangGiaCT.MainView = this.gvBangGiaCT;
            this.grdBangGiaCT.Name = "grdBangGiaCT";
            this.grdBangGiaCT.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItem});
            this.grdBangGiaCT.Size = new System.Drawing.Size(1191, 344);
            this.grdBangGiaCT.TabIndex = 0;
            this.grdBangGiaCT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBangGiaCT});
            // 
            // gvBangGiaCT
            // 
            this.gvBangGiaCT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBanggiactid,
            this.gridColumn1,
            this.colMaspid,
            this.colMasp,
            this.colTensp,
            this.colGiagoc,
            this.colGiasi,
            this.colGiale,
            this.colMavung,
            this.colGhichu});
            this.gvBangGiaCT.GridControl = this.grdBangGiaCT;
            this.gvBangGiaCT.Name = "gvBangGiaCT";
            this.gvBangGiaCT.OptionsView.ShowGroupPanel = false;
            this.gvBangGiaCT.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvBangGiaCT_InitNewRow);
            this.gvBangGiaCT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvBangGiaCT_KeyDown);
            // 
            // colBanggiactid
            // 
            this.colBanggiactid.Caption = "Banggiactid";
            this.colBanggiactid.FieldName = "Banggiactid";
            this.colBanggiactid.Name = "colBanggiactid";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Banggiaid";
            this.gridColumn1.FieldName = "Banggiaid";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // colMaspid
            // 
            this.colMaspid.Caption = "Maspid";
            this.colMaspid.FieldName = "Maspid";
            this.colMaspid.Name = "colMaspid";
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
            this.colMaspid1,
            this.colMasp1,
            this.colTensp1,
            this.colDvt1,
            this.colQuycach1});
            this.viewSP.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.viewSP.Name = "viewSP";
            this.viewSP.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.viewSP.OptionsView.ShowGroupPanel = false;
            // 
            // colMaspid1
            // 
            this.colMaspid1.Caption = "Maspid";
            this.colMaspid1.FieldName = "Maspid";
            this.colMaspid1.Name = "colMaspid1";
            // 
            // colMasp1
            // 
            this.colMasp1.Caption = "Mã sản phẩm";
            this.colMasp1.FieldName = "Masp";
            this.colMasp1.Name = "colMasp1";
            this.colMasp1.Visible = true;
            this.colMasp1.VisibleIndex = 0;
            // 
            // colTensp1
            // 
            this.colTensp1.Caption = "Tên sản phẩm";
            this.colTensp1.FieldName = "Tensp";
            this.colTensp1.Name = "colTensp1";
            this.colTensp1.Visible = true;
            this.colTensp1.VisibleIndex = 1;
            // 
            // colDvt1
            // 
            this.colDvt1.Caption = "ĐVT";
            this.colDvt1.FieldName = "Dvt";
            this.colDvt1.Name = "colDvt1";
            this.colDvt1.Visible = true;
            this.colDvt1.VisibleIndex = 2;
            // 
            // colQuycach1
            // 
            this.colQuycach1.Caption = "Quy cách";
            this.colQuycach1.FieldName = "Quycach";
            this.colQuycach1.Name = "colQuycach1";
            this.colQuycach1.Visible = true;
            this.colQuycach1.VisibleIndex = 3;
            // 
            // colTensp
            // 
            this.colTensp.Caption = "Tên sản phẩm";
            this.colTensp.FieldName = "Tensp";
            this.colTensp.Name = "colTensp";
            this.colTensp.Visible = true;
            this.colTensp.VisibleIndex = 1;
            // 
            // colGiagoc
            // 
            this.colGiagoc.Caption = "Giá gốc";
            this.colGiagoc.DisplayFormat.FormatString = "n0";
            this.colGiagoc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGiagoc.FieldName = "Giagoc";
            this.colGiagoc.Name = "colGiagoc";
            this.colGiagoc.Visible = true;
            this.colGiagoc.VisibleIndex = 2;
            // 
            // colGiasi
            // 
            this.colGiasi.Caption = "Giá sỉ";
            this.colGiasi.DisplayFormat.FormatString = "n0";
            this.colGiasi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGiasi.FieldName = "Giasi";
            this.colGiasi.Name = "colGiasi";
            this.colGiasi.Visible = true;
            this.colGiasi.VisibleIndex = 3;
            // 
            // colGiale
            // 
            this.colGiale.Caption = "Giá lẻ";
            this.colGiale.DisplayFormat.FormatString = "n0";
            this.colGiale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGiale.FieldName = "Giale";
            this.colGiale.Name = "colGiale";
            this.colGiale.Visible = true;
            this.colGiale.VisibleIndex = 4;
            // 
            // colMavung
            // 
            this.colMavung.Caption = "Tỉnh địa phương";
            this.colMavung.FieldName = "Mavung";
            this.colMavung.Name = "colMavung";
            this.colMavung.Visible = true;
            this.colMavung.VisibleIndex = 5;
            // 
            // colGhichu
            // 
            this.colGhichu.Caption = "Ghi chú";
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            this.colGhichu.Visible = true;
            this.colGhichu.VisibleIndex = 6;
            // 
            // DM_DonGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 627);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DM_DonGia";
            this.Text = "Đơn giá";
            this.Load += new System.EventHandler(this.DM_DonGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBangGiaCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangGiaCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Model.RepositoryItemCustomGridLookUpEdit repositoryItem;
        private Model.CustomGridView viewSP;
        private DevExpress.XtraGrid.Columns.GridColumn colMaspid1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasp1;
        private DevExpress.XtraGrid.Columns.GridColumn colTensp1;
        private DevExpress.XtraGrid.Columns.GridColumn colDvt1;
        private DevExpress.XtraGrid.Columns.GridColumn colQuycach1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cmdAdd;
        private System.Windows.Forms.ToolStripButton cmdEdit;
        private System.Windows.Forms.ToolStripButton cmdDel;
        private System.Windows.Forms.ToolStripButton cmdSave;
        private System.Windows.Forms.ToolStripButton cmdAbort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}