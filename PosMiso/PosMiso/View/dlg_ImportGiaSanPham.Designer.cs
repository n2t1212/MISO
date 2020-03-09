namespace PosMiso.View
{
    partial class dlg_ImportGiaSanPham
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdGiaImport = new DevExpress.XtraGrid.GridControl();
            this.gvGiaImport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMavung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTensp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiagoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.isNew = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGiaImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaImport)).BeginInit();
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
            this.btnExit.Location = new System.Drawing.Point(948, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 28);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Location = new System.Drawing.Point(16, 16);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(222, 19);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "NHẬP GIÁ SẢN PHẨM TỪ FILE";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnImport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 48);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnCancel.Location = new System.Drawing.Point(606, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnImport.Location = new System.Drawing.Point(398, 8);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(104, 32);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Đồng ý";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grdGiaImport);
            this.panel3.Controls.Add(this.txtFile);
            this.panel3.Controls.Add(this.isNew);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnFile);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 404);
            this.panel3.TabIndex = 2;
            // 
            // grdGiaImport
            // 
            this.grdGiaImport.Location = new System.Drawing.Point(0, 64);
            this.grdGiaImport.MainView = this.gvGiaImport;
            this.grdGiaImport.Name = "grdGiaImport";
            this.grdGiaImport.Size = new System.Drawing.Size(1000, 336);
            this.grdGiaImport.TabIndex = 11;
            this.grdGiaImport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGiaImport});
            // 
            // gvGiaImport
            // 
            this.gvGiaImport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMavung,
            this.colMasp,
            this.colTensp,
            this.colGiagoc,
            this.colGiasi,
            this.colGiale,
            this.colGhichu});
            this.gvGiaImport.GridControl = this.grdGiaImport;
            this.gvGiaImport.Name = "gvGiaImport";
            this.gvGiaImport.OptionsView.ShowGroupPanel = false;
            // 
            // colMavung
            // 
            this.colMavung.Caption = "Mã vùng";
            this.colMavung.FieldName = "Mavung";
            this.colMavung.Name = "colMavung";
            this.colMavung.Visible = true;
            this.colMavung.VisibleIndex = 0;
            this.colMavung.Width = 116;
            // 
            // colMasp
            // 
            this.colMasp.Caption = "Mã sản phẩm";
            this.colMasp.FieldName = "Masp";
            this.colMasp.Name = "colMasp";
            this.colMasp.Visible = true;
            this.colMasp.VisibleIndex = 1;
            this.colMasp.Width = 124;
            // 
            // colTensp
            // 
            this.colTensp.Caption = "Tên sản phẩm";
            this.colTensp.FieldName = "Tensp";
            this.colTensp.Name = "colTensp";
            this.colTensp.Visible = true;
            this.colTensp.VisibleIndex = 2;
            this.colTensp.Width = 192;
            // 
            // colGiagoc
            // 
            this.colGiagoc.Caption = "Giá gốc";
            this.colGiagoc.FieldName = "Giagoc";
            this.colGiagoc.Name = "colGiagoc";
            this.colGiagoc.Visible = true;
            this.colGiagoc.VisibleIndex = 3;
            this.colGiagoc.Width = 133;
            // 
            // colGiasi
            // 
            this.colGiasi.Caption = "Giá sỉ";
            this.colGiasi.FieldName = "Giasi";
            this.colGiasi.Name = "colGiasi";
            this.colGiasi.Visible = true;
            this.colGiasi.VisibleIndex = 4;
            this.colGiasi.Width = 98;
            // 
            // colGiale
            // 
            this.colGiale.Caption = "Giá lẻ";
            this.colGiale.FieldName = "Giale";
            this.colGiale.Name = "colGiale";
            this.colGiale.Visible = true;
            this.colGiale.VisibleIndex = 5;
            this.colGiale.Width = 150;
            // 
            // colGhichu
            // 
            this.colGhichu.Caption = "Ghi chú";
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            this.colGhichu.Visible = true;
            this.colGhichu.VisibleIndex = 6;
            this.colGhichu.Width = 169;
            // 
            // txtFile
            // 
            this.txtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.Location = new System.Drawing.Point(104, 24);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(312, 26);
            this.txtFile.TabIndex = 10;
            // 
            // isNew
            // 
            this.isNew.AutoSize = true;
            this.isNew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.isNew.Location = new System.Drawing.Point(520, 24);
            this.isNew.Name = "isNew";
            this.isNew.Size = new System.Drawing.Size(150, 23);
            this.isNew.TabIndex = 9;
            this.isNew.TabStop = true;
            this.isNew.Text = "Nhập mới dữ liệu";
            this.isNew.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chọn file";
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnFile.Location = new System.Drawing.Point(424, 24);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(40, 26);
            this.btnFile.TabIndex = 8;
            this.btnFile.Text = "...";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // dlg_ImportGiaSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dlg_ImportGiaSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dlg_ImportGiaSanPham";
            this.Load += new System.EventHandler(this.dlg_ImportGiaSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGiaImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.RadioButton isNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFile;
        private DevExpress.XtraGrid.GridControl grdGiaImport;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGiaImport;
        private DevExpress.XtraGrid.Columns.GridColumn colMavung;
        private DevExpress.XtraGrid.Columns.GridColumn colMasp;
        private DevExpress.XtraGrid.Columns.GridColumn colTensp;
        private DevExpress.XtraGrid.Columns.GridColumn colGiagoc;
        private DevExpress.XtraGrid.Columns.GridColumn colGiasi;
        private DevExpress.XtraGrid.Columns.GridColumn colGiale;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
    }
}