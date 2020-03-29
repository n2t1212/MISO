namespace PosMiso.View
{
    partial class DM_DonGia
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
            this.btnDownTemplate = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
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
            this.colTensp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiagoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMavung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBangGiaCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangGiaCT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDownTemplate);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 579);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnDownTemplate
            // 
            this.btnDownTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnDownTemplate.Location = new System.Drawing.Point(16, 8);
            this.btnDownTemplate.Name = "btnDownTemplate";
            this.btnDownTemplate.Size = new System.Drawing.Size(112, 32);
            this.btnDownTemplate.TabIndex = 6;
            this.btnDownTemplate.Text = "Tải mẫu (.xls)";
            this.btnDownTemplate.UseVisualStyleBackColor = true;
            this.btnDownTemplate.Click += new System.EventHandler(this.btnDownTemplate_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnImport.Location = new System.Drawing.Point(144, 8);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(104, 32);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Nhập (.xls)";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.Size = new System.Drawing.Size(1191, 579);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 1;
            // 
            // grdBangGia
            // 
            this.grdBangGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBangGia.Location = new System.Drawing.Point(0, 0);
            this.grdBangGia.MainView = this.gvBangGia;
            this.grdBangGia.Name = "grdBangGia";
            this.grdBangGia.Size = new System.Drawing.Size(1191, 215);
            this.grdBangGia.TabIndex = 0;
            this.grdBangGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBangGia});
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
            this.grdBangGiaCT.Size = new System.Drawing.Size(1191, 360);
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
            this.colMasp.FieldName = "Masp";
            this.colMasp.Name = "colMasp";
            this.colMasp.Visible = true;
            this.colMasp.VisibleIndex = 0;
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
            this.colGiagoc.FieldName = "Giagoc";
            this.colGiagoc.Name = "colGiagoc";
            this.colGiagoc.Visible = true;
            this.colGiagoc.VisibleIndex = 2;
            // 
            // colGiasi
            // 
            this.colGiasi.Caption = "Giá sỉ";
            this.colGiasi.FieldName = "Giasi";
            this.colGiasi.Name = "colGiasi";
            this.colGiasi.Visible = true;
            this.colGiasi.VisibleIndex = 3;
            // 
            // colGiale
            // 
            this.colGiale.Caption = "Giá lẻ";
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
            this.Text = "DM_DonGia";
            this.Load += new System.EventHandler(this.DM_DonGia_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBangGiaCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangGiaCT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDownTemplate;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl grdBangGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBangGia;
        private DevExpress.XtraGrid.GridControl grdBangGiaCT;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBangGiaCT;
        private DevExpress.XtraGrid.Columns.GridColumn colBanggiaid;
        private DevExpress.XtraGrid.Columns.GridColumn coldBanggia;
        private DevExpress.XtraGrid.Columns.GridColumn colTungay;
        private DevExpress.XtraGrid.Columns.GridColumn colDenngay;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayapdung;
        private DevExpress.XtraGrid.Columns.GridColumn colApdung;
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
    }
}