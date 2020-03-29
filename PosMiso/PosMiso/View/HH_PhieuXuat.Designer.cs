namespace PosMiso.View
{
    partial class HH_PhieuXuat
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grdPhieuXuat = new DevExpress.XtraGrid.GridControl();
            this.gvPhieuXuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPhieunxid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSophieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayps = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoctgoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaonhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenkh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenkho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLydo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguyente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTTVat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoilap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdPhieuNXCT = new DevExpress.XtraGrid.GridControl();
            this.gvPhieuNXCT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTensp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDvt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuycach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLThung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVATCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTTVatCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichuCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuNXCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuNXCT)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.grdPhieuXuat);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdPhieuNXCT);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 700);
            this.splitContainer1.SplitterDistance = 318;
            this.splitContainer1.TabIndex = 0;
            // 
            // grdPhieuXuat
            // 
            this.grdPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPhieuXuat.Location = new System.Drawing.Point(0, 0);
            this.grdPhieuXuat.MainView = this.gvPhieuXuat;
            this.grdPhieuXuat.Name = "grdPhieuXuat";
            this.grdPhieuXuat.Size = new System.Drawing.Size(1000, 318);
            this.grdPhieuXuat.TabIndex = 0;
            this.grdPhieuXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhieuXuat});
            this.grdPhieuXuat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdPhieuXuat_KeyDown);
            // 
            // gvPhieuXuat
            // 
            this.gvPhieuXuat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPhieunxid,
            this.colSophieu,
            this.colNgayct,
            this.colNgayps,
            this.colSoctgoc,
            this.colGiaonhan,
            this.colTenkh,
            this.colTenkho,
            this.colLydo,
            this.colNguyente,
            this.colVat,
            this.colTTVat,
            this.colThanhtien,
            this.colGhichu,
            this.colNguoilap});
            this.gvPhieuXuat.GridControl = this.grdPhieuXuat;
            this.gvPhieuXuat.Name = "gvPhieuXuat";
            this.gvPhieuXuat.OptionsView.ShowGroupPanel = false;
            this.gvPhieuXuat.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvPhieuXuat_RowClick);
            // 
            // colPhieunxid
            // 
            this.colPhieunxid.Caption = "Phieunxid";
            this.colPhieunxid.FieldName = "Phieunxid";
            this.colPhieunxid.Name = "colPhieunxid";
            // 
            // colSophieu
            // 
            this.colSophieu.Caption = "Số phiếu";
            this.colSophieu.FieldName = "Sophieu";
            this.colSophieu.Name = "colSophieu";
            this.colSophieu.Visible = true;
            this.colSophieu.VisibleIndex = 0;
            this.colSophieu.Width = 77;
            // 
            // colNgayct
            // 
            this.colNgayct.Caption = "Ngày chứng từ";
            this.colNgayct.FieldName = "Ngayct";
            this.colNgayct.Name = "colNgayct";
            this.colNgayct.Visible = true;
            this.colNgayct.VisibleIndex = 1;
            this.colNgayct.Width = 90;
            // 
            // colNgayps
            // 
            this.colNgayps.Caption = "Ngày phát sinh";
            this.colNgayps.FieldName = "Ngayps";
            this.colNgayps.Name = "colNgayps";
            this.colNgayps.Visible = true;
            this.colNgayps.VisibleIndex = 2;
            this.colNgayps.Width = 90;
            // 
            // colSoctgoc
            // 
            this.colSoctgoc.Caption = "Số chứng từ gốc";
            this.colSoctgoc.FieldName = "Soctgoc";
            this.colSoctgoc.Name = "colSoctgoc";
            this.colSoctgoc.Visible = true;
            this.colSoctgoc.VisibleIndex = 3;
            this.colSoctgoc.Width = 89;
            // 
            // colGiaonhan
            // 
            this.colGiaonhan.Caption = "Giao nhận";
            this.colGiaonhan.FieldName = "Giaonhan";
            this.colGiaonhan.Name = "colGiaonhan";
            this.colGiaonhan.Visible = true;
            this.colGiaonhan.VisibleIndex = 4;
            this.colGiaonhan.Width = 72;
            // 
            // colTenkh
            // 
            this.colTenkh.Caption = "Tên khách hàng";
            this.colTenkh.FieldName = "Tenkh";
            this.colTenkh.Name = "colTenkh";
            this.colTenkh.Visible = true;
            this.colTenkh.VisibleIndex = 5;
            this.colTenkh.Width = 89;
            // 
            // colTenkho
            // 
            this.colTenkho.Caption = "Tên kho";
            this.colTenkho.FieldName = "Tenkho";
            this.colTenkho.Name = "colTenkho";
            this.colTenkho.Visible = true;
            this.colTenkho.VisibleIndex = 6;
            this.colTenkho.Width = 65;
            // 
            // colLydo
            // 
            this.colLydo.Caption = "Lý do";
            this.colLydo.FieldName = "Lydo";
            this.colLydo.Name = "colLydo";
            this.colLydo.Visible = true;
            this.colLydo.VisibleIndex = 7;
            this.colLydo.Width = 52;
            // 
            // colNguyente
            // 
            this.colNguyente.Caption = "Nguyên tệ";
            this.colNguyente.FieldName = "Nguyente";
            this.colNguyente.Name = "colNguyente";
            this.colNguyente.Visible = true;
            this.colNguyente.VisibleIndex = 8;
            this.colNguyente.Width = 52;
            // 
            // colVat
            // 
            this.colVat.Caption = "VAT";
            this.colVat.FieldName = "Vat";
            this.colVat.Name = "colVat";
            this.colVat.Visible = true;
            this.colVat.VisibleIndex = 9;
            this.colVat.Width = 52;
            // 
            // colTTVat
            // 
            this.colTTVat.Caption = "Tiền VAT";
            this.colTTVat.FieldName = "TTVat";
            this.colTTVat.Name = "colTTVat";
            this.colTTVat.Visible = true;
            this.colTTVat.VisibleIndex = 10;
            this.colTTVat.Width = 60;
            // 
            // colThanhtien
            // 
            this.colThanhtien.Caption = "Tổng tiền";
            this.colThanhtien.FieldName = "Thanhtien";
            this.colThanhtien.Name = "colThanhtien";
            this.colThanhtien.Visible = true;
            this.colThanhtien.VisibleIndex = 11;
            this.colThanhtien.Width = 57;
            // 
            // colGhichu
            // 
            this.colGhichu.Caption = "Ghi chú";
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            this.colGhichu.Visible = true;
            this.colGhichu.VisibleIndex = 12;
            this.colGhichu.Width = 47;
            // 
            // colNguoilap
            // 
            this.colNguoilap.Caption = "Người lập";
            this.colNguoilap.FieldName = "Nguoilap";
            this.colNguoilap.Name = "colNguoilap";
            this.colNguoilap.Visible = true;
            this.colNguoilap.VisibleIndex = 13;
            this.colNguoilap.Width = 90;
            // 
            // grdPhieuNXCT
            // 
            this.grdPhieuNXCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPhieuNXCT.Location = new System.Drawing.Point(0, 0);
            this.grdPhieuNXCT.MainView = this.gvPhieuNXCT;
            this.grdPhieuNXCT.Name = "grdPhieuNXCT";
            this.grdPhieuNXCT.Size = new System.Drawing.Size(1000, 378);
            this.grdPhieuNXCT.TabIndex = 0;
            this.grdPhieuNXCT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhieuNXCT});
            // 
            // gvPhieuNXCT
            // 
            this.gvPhieuNXCT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasp,
            this.colTensp,
            this.colDvt,
            this.colQuycach,
            this.colSLThung,
            this.colSoluong,
            this.colDongia,
            this.colNgte,
            this.colVATCT,
            this.colTTVatCT,
            this.colTTien,
            this.colGhichuCT});
            this.gvPhieuNXCT.GridControl = this.grdPhieuNXCT;
            this.gvPhieuNXCT.Name = "gvPhieuNXCT";
            this.gvPhieuNXCT.OptionsView.ShowGroupPanel = false;
            // 
            // colMasp
            // 
            this.colMasp.Caption = "Mã hàng hóa";
            this.colMasp.FieldName = "Masp";
            this.colMasp.Name = "colMasp";
            this.colMasp.Visible = true;
            this.colMasp.VisibleIndex = 0;
            // 
            // colTensp
            // 
            this.colTensp.Caption = "Tên hàng hóa";
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
            // colSLThung
            // 
            this.colSLThung.Caption = "Số thùng";
            this.colSLThung.FieldName = "SLThung";
            this.colSLThung.Name = "colSLThung";
            this.colSLThung.Visible = true;
            this.colSLThung.VisibleIndex = 4;
            // 
            // colSoluong
            // 
            this.colSoluong.Caption = "Số lượng";
            this.colSoluong.FieldName = "Soluong";
            this.colSoluong.Name = "colSoluong";
            this.colSoluong.Visible = true;
            this.colSoluong.VisibleIndex = 5;
            // 
            // colDongia
            // 
            this.colDongia.Caption = "Đơn giá";
            this.colDongia.FieldName = "Dongia";
            this.colDongia.Name = "colDongia";
            this.colDongia.Visible = true;
            this.colDongia.VisibleIndex = 6;
            // 
            // colNgte
            // 
            this.colNgte.Caption = "Nguyên tệ";
            this.colNgte.FieldName = "Nguyente";
            this.colNgte.Name = "colNgte";
            this.colNgte.Visible = true;
            this.colNgte.VisibleIndex = 7;
            // 
            // colVATCT
            // 
            this.colVATCT.Caption = "VAT (%)";
            this.colVATCT.FieldName = "Vat";
            this.colVATCT.Name = "colVATCT";
            this.colVATCT.Visible = true;
            this.colVATCT.VisibleIndex = 8;
            // 
            // colTTVatCT
            // 
            this.colTTVatCT.Caption = "Tiền VAT";
            this.colTTVatCT.FieldName = "TTVat";
            this.colTTVatCT.Name = "colTTVatCT";
            this.colTTVatCT.Visible = true;
            this.colTTVatCT.VisibleIndex = 9;
            // 
            // colTTien
            // 
            this.colTTien.Caption = "Thành tiền";
            this.colTTien.FieldName = "Thanhtien";
            this.colTTien.Name = "colTTien";
            this.colTTien.Visible = true;
            this.colTTien.VisibleIndex = 10;
            // 
            // colGhichuCT
            // 
            this.colGhichuCT.Caption = "Ghi chú";
            this.colGhichuCT.FieldName = "Ghichu";
            this.colGhichuCT.Name = "colGhichuCT";
            this.colGhichuCT.Visible = true;
            this.colGhichuCT.VisibleIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 654);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 46);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(352, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "F7: In chứng từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(185, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "F6: Xem chi tiết phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(63, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "F2: Thêm mới";
            // 
            // HH_PhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HH_PhieuXuat";
            this.Text = "HH_PhieuXuat";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuNXCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuNXCT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl grdPhieuXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhieuXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colPhieunxid;
        private DevExpress.XtraGrid.Columns.GridColumn colSophieu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayct;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayps;
        private DevExpress.XtraGrid.Columns.GridColumn colSoctgoc;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaonhan;
        private DevExpress.XtraGrid.Columns.GridColumn colTenkh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenkho;
        private DevExpress.XtraGrid.Columns.GridColumn colLydo;
        private DevExpress.XtraGrid.Columns.GridColumn colNguyente;
        private DevExpress.XtraGrid.Columns.GridColumn colVat;
        private DevExpress.XtraGrid.Columns.GridColumn colTTVat;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhtien;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoilap;
        private DevExpress.XtraGrid.GridControl grdPhieuNXCT;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhieuNXCT;
        private DevExpress.XtraGrid.Columns.GridColumn colMasp;
        private DevExpress.XtraGrid.Columns.GridColumn colTensp;
        private DevExpress.XtraGrid.Columns.GridColumn colDvt;
        private DevExpress.XtraGrid.Columns.GridColumn colQuycach;
        private DevExpress.XtraGrid.Columns.GridColumn colSLThung;
        private DevExpress.XtraGrid.Columns.GridColumn colSoluong;
        private DevExpress.XtraGrid.Columns.GridColumn colDongia;
        private DevExpress.XtraGrid.Columns.GridColumn colNgte;
        private DevExpress.XtraGrid.Columns.GridColumn colVATCT;
        private DevExpress.XtraGrid.Columns.GridColumn colTTVatCT;
        private DevExpress.XtraGrid.Columns.GridColumn colTTien;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichuCT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}