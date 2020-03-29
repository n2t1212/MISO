namespace PosMiso.View
{
    partial class dlg_ImportSanPham
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
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.grdSanPhamImport = new DevExpress.XtraGrid.GridControl();
            this.gvSanPhamImport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTensp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDvt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuycach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuydoikgl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuydoithung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhacungcap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.isNew = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSanPhamImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamImport)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(952, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 28);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Location = new System.Drawing.Point(16, 16);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(189, 19);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "NHẬP SẢN PHẨM TỪ FILE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn file";
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnFile.Location = new System.Drawing.Point(432, 24);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(40, 26);
            this.btnFile.TabIndex = 3;
            this.btnFile.Text = "...";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.isNew);
            this.panel2.Controls.Add(this.txtFile);
            this.panel2.Controls.Add(this.grdSanPhamImport);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnFile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 452);
            this.panel2.TabIndex = 5;
            // 
            // txtFile
            // 
            this.txtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.Location = new System.Drawing.Point(112, 24);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(312, 22);
            this.txtFile.TabIndex = 6;
            // 
            // grdSanPhamImport
            // 
            this.grdSanPhamImport.Location = new System.Drawing.Point(0, 56);
            this.grdSanPhamImport.MainView = this.gvSanPhamImport;
            this.grdSanPhamImport.Name = "grdSanPhamImport";
            this.grdSanPhamImport.Size = new System.Drawing.Size(1008, 368);
            this.grdSanPhamImport.TabIndex = 5;
            this.grdSanPhamImport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPhamImport});
            // 
            // gvSanPhamImport
            // 
            this.gvSanPhamImport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasp,
            this.colTensp,
            this.colDvt,
            this.colQuycach,
            this.colQuydoikgl,
            this.colQuydoithung,
            this.colNhacungcap});
            this.gvSanPhamImport.GridControl = this.grdSanPhamImport;
            this.gvSanPhamImport.Name = "gvSanPhamImport";
            this.gvSanPhamImport.OptionsView.ShowGroupPanel = false;
            // 
            // colMasp
            // 
            this.colMasp.Caption = "Mã sản phẩm";
            this.colMasp.FieldName = "Masp";
            this.colMasp.Name = "colMasp";
            this.colMasp.Visible = true;
            this.colMasp.VisibleIndex = 0;
            this.colMasp.Width = 172;
            // 
            // colTensp
            // 
            this.colTensp.Caption = "Tên sản phẩm";
            this.colTensp.FieldName = "Tensp";
            this.colTensp.Name = "colTensp";
            this.colTensp.Visible = true;
            this.colTensp.VisibleIndex = 1;
            this.colTensp.Width = 276;
            // 
            // colDvt
            // 
            this.colDvt.Caption = "Đơn vị tính";
            this.colDvt.FieldName = "Dvt";
            this.colDvt.Name = "colDvt";
            this.colDvt.Visible = true;
            this.colDvt.VisibleIndex = 2;
            this.colDvt.Width = 114;
            // 
            // colQuycach
            // 
            this.colQuycach.Caption = "Quy cách";
            this.colQuycach.FieldName = "Quycach";
            this.colQuycach.Name = "colQuycach";
            this.colQuycach.Visible = true;
            this.colQuycach.VisibleIndex = 3;
            this.colQuycach.Width = 100;
            // 
            // colQuydoikgl
            // 
            this.colQuydoikgl.Caption = "Quy đổi kgl";
            this.colQuydoikgl.FieldName = "Quydoikgl";
            this.colQuydoikgl.Name = "colQuydoikgl";
            this.colQuydoikgl.Visible = true;
            this.colQuydoikgl.VisibleIndex = 4;
            this.colQuydoikgl.Width = 85;
            // 
            // colQuydoithung
            // 
            this.colQuydoithung.Caption = "Quy đổi thùng";
            this.colQuydoithung.FieldName = "Quydoithung";
            this.colQuydoithung.Name = "colQuydoithung";
            this.colQuydoithung.Visible = true;
            this.colQuydoithung.VisibleIndex = 5;
            this.colQuydoithung.Width = 102;
            // 
            // colNhacungcap
            // 
            this.colNhacungcap.Caption = "Nhà cung cấp";
            this.colNhacungcap.FieldName = "Nhacungcap";
            this.colNhacungcap.Name = "colNhacungcap";
            this.colNhacungcap.Visible = true;
            this.colNhacungcap.VisibleIndex = 6;
            this.colNhacungcap.Width = 141;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Controls.Add(this.btnImport);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 444);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1000, 56);
            this.panel4.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnCancel.Location = new System.Drawing.Point(520, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnImport.Location = new System.Drawing.Point(312, 16);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(104, 32);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Đồng ý";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // isNew
            // 
            this.isNew.AutoSize = true;
            this.isNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.isNew.Location = new System.Drawing.Point(509, 28);
            this.isNew.Name = "isNew";
            this.isNew.Size = new System.Drawing.Size(127, 20);
            this.isNew.TabIndex = 7;
            this.isNew.Text = "Nhập mới dữ liệu";
            this.isNew.UseVisualStyleBackColor = true;
            // 
            // dlg_ImportSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dlg_ImportSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dlg_ImportSanPham";
            this.Load += new System.EventHandler(this.dlg_ImportSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSanPhamImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPhamImport)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnImport;
        private DevExpress.XtraGrid.GridControl grdSanPhamImport;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPhamImport;
        private DevExpress.XtraGrid.Columns.GridColumn colMasp;
        private System.Windows.Forms.TextBox txtFile;
        private DevExpress.XtraGrid.Columns.GridColumn colTensp;
        private DevExpress.XtraGrid.Columns.GridColumn colDvt;
        private DevExpress.XtraGrid.Columns.GridColumn colQuycach;
        private DevExpress.XtraGrid.Columns.GridColumn colQuydoikgl;
        private DevExpress.XtraGrid.Columns.GridColumn colQuydoithung;
        private DevExpress.XtraGrid.Columns.GridColumn colNhacungcap;
        private System.Windows.Forms.CheckBox isNew;
    }
}