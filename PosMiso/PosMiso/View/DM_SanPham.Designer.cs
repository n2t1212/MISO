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
            this.grdSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaspid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTensp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDvt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuycach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuydoikgl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuydoithung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMabarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaqrcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdNhomSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvNhomSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colManhomspid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTennhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerDMSP = new System.Windows.Forms.SplitContainer();
            this.panelFunction = new System.Windows.Forms.Panel();
            this.btnDownTemplate = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnInMa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhomSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDMSP)).BeginInit();
            this.splitContainerDMSP.Panel1.SuspendLayout();
            this.splitContainerDMSP.Panel2.SuspendLayout();
            this.splitContainerDMSP.SuspendLayout();
            this.panelFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdSanPham
            // 
            this.grdSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSanPham.Location = new System.Drawing.Point(0, 0);
            this.grdSanPham.MainView = this.gvSanPham;
            this.grdSanPham.Name = "grdSanPham";
            this.grdSanPham.Size = new System.Drawing.Size(1191, 303);
            this.grdSanPham.TabIndex = 0;
            this.grdSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPham});
            // 
            // gvSanPham
            // 
            this.gvSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaspid,
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
            // 
            // colMaspid
            // 
            this.colMaspid.Caption = "MASPID";
            this.colMaspid.FieldName = "Maspid";
            this.colMaspid.Name = "colMaspid";
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
            this.colQuydoikgl.VisibleIndex = 5;
            this.colQuydoikgl.Width = 74;
            // 
            // colQuydoithung
            // 
            this.colQuydoithung.Caption = "Quy đổi thùng";
            this.colQuydoithung.FieldName = "Quydoithung";
            this.colQuydoithung.Name = "colQuydoithung";
            this.colQuydoithung.Visible = true;
            this.colQuydoithung.VisibleIndex = 6;
            this.colQuydoithung.Width = 91;
            // 
            // colMabarcode
            // 
            this.colMabarcode.Caption = "Mã bar code";
            this.colMabarcode.FieldName = "Mabarcode";
            this.colMabarcode.Name = "colMabarcode";
            this.colMabarcode.Visible = true;
            this.colMabarcode.VisibleIndex = 4;
            this.colMabarcode.Width = 126;
            // 
            // colMaqrcode
            // 
            this.colMaqrcode.Caption = "Mã QR code";
            this.colMaqrcode.FieldName = "Maqrcode";
            this.colMaqrcode.Name = "colMaqrcode";
            this.colMaqrcode.Visible = true;
            this.colMaqrcode.VisibleIndex = 7;
            this.colMaqrcode.Width = 144;
            // 
            // grdNhomSanPham
            // 
            this.grdNhomSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNhomSanPham.Location = new System.Drawing.Point(0, 0);
            this.grdNhomSanPham.MainView = this.gvNhomSanPham;
            this.grdNhomSanPham.Name = "grdNhomSanPham";
            this.grdNhomSanPham.Size = new System.Drawing.Size(1191, 224);
            this.grdNhomSanPham.TabIndex = 1;
            this.grdNhomSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhomSanPham});
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
            // splitContainerDMSP
            // 
            this.splitContainerDMSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDMSP.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDMSP.Name = "splitContainerDMSP";
            this.splitContainerDMSP.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDMSP.Panel1
            // 
            this.splitContainerDMSP.Panel1.Controls.Add(this.grdNhomSanPham);
            // 
            // splitContainerDMSP.Panel2
            // 
            this.splitContainerDMSP.Panel2.Controls.Add(this.grdSanPham);
            this.splitContainerDMSP.Size = new System.Drawing.Size(1191, 531);
            this.splitContainerDMSP.SplitterDistance = 224;
            this.splitContainerDMSP.TabIndex = 2;
            // 
            // panelFunction
            // 
            this.panelFunction.Controls.Add(this.btnDownTemplate);
            this.panelFunction.Controls.Add(this.btnImport);
            this.panelFunction.Controls.Add(this.btnInMa);
            this.panelFunction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFunction.Location = new System.Drawing.Point(0, 475);
            this.panelFunction.Name = "panelFunction";
            this.panelFunction.Size = new System.Drawing.Size(1191, 56);
            this.panelFunction.TabIndex = 3;
            // 
            // btnDownTemplate
            // 
            this.btnDownTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnDownTemplate.Location = new System.Drawing.Point(152, 8);
            this.btnDownTemplate.Name = "btnDownTemplate";
            this.btnDownTemplate.Size = new System.Drawing.Size(112, 32);
            this.btnDownTemplate.TabIndex = 4;
            this.btnDownTemplate.Text = "Tải mẫu (.xls)";
            this.btnDownTemplate.UseVisualStyleBackColor = true;
            this.btnDownTemplate.Click += new System.EventHandler(this.btnDownTemplate_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnImport.Location = new System.Drawing.Point(288, 8);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(104, 32);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Nhập (.xls)";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnInMa
            // 
            this.btnInMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnInMa.Location = new System.Drawing.Point(24, 8);
            this.btnInMa.Name = "btnInMa";
            this.btnInMa.Size = new System.Drawing.Size(104, 32);
            this.btnInMa.TabIndex = 2;
            this.btnInMa.Text = "In mã";
            this.btnInMa.UseVisualStyleBackColor = true;
            this.btnInMa.Click += new System.EventHandler(this.btnInMa_Click);
            // 
            // DM_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 531);
            this.Controls.Add(this.panelFunction);
            this.Controls.Add(this.splitContainerDMSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DM_SanPham";
            this.Text = "DM_SanPham";
            this.Load += new System.EventHandler(this.DM_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhomSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomSanPham)).EndInit();
            this.splitContainerDMSP.Panel1.ResumeLayout(false);
            this.splitContainerDMSP.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDMSP)).EndInit();
            this.splitContainerDMSP.ResumeLayout(false);
            this.panelFunction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colMaspid;
        private DevExpress.XtraGrid.Columns.GridColumn colMasp;
        private DevExpress.XtraGrid.Columns.GridColumn colTensp;
        private DevExpress.XtraGrid.Columns.GridColumn colDvt;
        private DevExpress.XtraGrid.Columns.GridColumn colQuycach;
        private DevExpress.XtraGrid.Columns.GridColumn colMabarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colQuydoikgl;
        private DevExpress.XtraGrid.Columns.GridColumn colQuydoithung;
        private DevExpress.XtraGrid.Columns.GridColumn colMaqrcode;
        private DevExpress.XtraGrid.GridControl grdNhomSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhomSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colManhomspid;
        private DevExpress.XtraGrid.Columns.GridColumn colManhom;
        private DevExpress.XtraGrid.Columns.GridColumn colTennhom;
        private System.Windows.Forms.SplitContainer splitContainerDMSP;
        private System.Windows.Forms.Panel panelFunction;
        private System.Windows.Forms.Button btnInMa;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnDownTemplate;
    }
}