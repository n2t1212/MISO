namespace PosMiso.View
{
    partial class DM_KhachHang
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
            this.btnImport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gvKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMakhid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMakh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenkh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaloai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienthoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSinhnhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 567);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnImport.Location = new System.Drawing.Point(16, 8);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(104, 32);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Nhập (.xls)";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdKhachHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1172, 567);
            this.panel2.TabIndex = 1;
            // 
            // grdKhachHang
            // 
            this.grdKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKhachHang.Location = new System.Drawing.Point(0, 0);
            this.grdKhachHang.MainView = this.gvKhachHang;
            this.grdKhachHang.Name = "grdKhachHang";
            this.grdKhachHang.Size = new System.Drawing.Size(1172, 567);
            this.grdKhachHang.TabIndex = 0;
            this.grdKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhachHang});
            // 
            // gvKhachHang
            // 
            this.gvKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMakhid,
            this.colMakh,
            this.colTenkh,
            this.colMaloai,
            this.colDienthoai,
            this.colXa,
            this.colHuyen,
            this.colTinh,
            this.colEmail,
            this.colMst,
            this.colSinhnhat});
            this.gvKhachHang.GridControl = this.grdKhachHang;
            this.gvKhachHang.Name = "gvKhachHang";
            this.gvKhachHang.OptionsView.ShowGroupPanel = false;
            // 
            // colMakhid
            // 
            this.colMakhid.Caption = "Makhid";
            this.colMakhid.FieldName = "Makhid";
            this.colMakhid.Name = "colMakhid";
            // 
            // colMakh
            // 
            this.colMakh.Caption = "Mã khách hàng";
            this.colMakh.FieldName = "Makh";
            this.colMakh.Name = "colMakh";
            this.colMakh.Visible = true;
            this.colMakh.VisibleIndex = 0;
            // 
            // colTenkh
            // 
            this.colTenkh.Caption = "Tên khách hàng";
            this.colTenkh.FieldName = "Tenkh";
            this.colTenkh.Name = "colTenkh";
            this.colTenkh.Visible = true;
            this.colTenkh.VisibleIndex = 1;
            // 
            // colMaloai
            // 
            this.colMaloai.Caption = "Loại khách hàng";
            this.colMaloai.FieldName = "Maloai";
            this.colMaloai.Name = "colMaloai";
            this.colMaloai.Visible = true;
            this.colMaloai.VisibleIndex = 2;
            // 
            // colDienthoai
            // 
            this.colDienthoai.Caption = "Số điện thoại";
            this.colDienthoai.FieldName = "Dienthoai";
            this.colDienthoai.Name = "colDienthoai";
            this.colDienthoai.Visible = true;
            this.colDienthoai.VisibleIndex = 3;
            // 
            // colXa
            // 
            this.colXa.Caption = "Xã";
            this.colXa.FieldName = "Xa";
            this.colXa.Name = "colXa";
            this.colXa.Visible = true;
            this.colXa.VisibleIndex = 4;
            // 
            // colHuyen
            // 
            this.colHuyen.Caption = "Huyện";
            this.colHuyen.FieldName = "Huyen";
            this.colHuyen.Name = "colHuyen";
            this.colHuyen.Visible = true;
            this.colHuyen.VisibleIndex = 5;
            // 
            // colTinh
            // 
            this.colTinh.Caption = "Tỉnh";
            this.colTinh.FieldName = "Tinh";
            this.colTinh.Name = "colTinh";
            this.colTinh.Visible = true;
            this.colTinh.VisibleIndex = 6;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 7;
            // 
            // colMst
            // 
            this.colMst.Caption = "Mã số thuế";
            this.colMst.FieldName = "Mst";
            this.colMst.Name = "colMst";
            this.colMst.Visible = true;
            this.colMst.VisibleIndex = 8;
            // 
            // colSinhnhat
            // 
            this.colSinhnhat.Caption = "Sinh nhật";
            this.colSinhnhat.FieldName = "Sinhnhat";
            this.colSinhnhat.Name = "colSinhnhat";
            this.colSinhnhat.Visible = true;
            this.colSinhnhat.VisibleIndex = 9;
            // 
            // DM_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DM_KhachHang";
            this.Text = "DM_KhachHang";
            this.Load += new System.EventHandler(this.DM_KhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnImport;
        private DevExpress.XtraGrid.GridControl grdKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMakhid;
        private DevExpress.XtraGrid.Columns.GridColumn colMakh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenkh;
        private DevExpress.XtraGrid.Columns.GridColumn colMaloai;
        private DevExpress.XtraGrid.Columns.GridColumn colDienthoai;
        private DevExpress.XtraGrid.Columns.GridColumn colXa;
        private DevExpress.XtraGrid.Columns.GridColumn colHuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colMst;
        private DevExpress.XtraGrid.Columns.GridColumn colSinhnhat;
    }
}