namespace PosMiso.View
{
    partial class DM_NhomSanPham
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
            this.grdNhomSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvNhomSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colManhomspid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTennhom = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhomSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 44);
            this.panel1.TabIndex = 0;
            // 
            // grdNhomSanPham
            // 
            this.grdNhomSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNhomSanPham.Location = new System.Drawing.Point(0, 0);
            this.grdNhomSanPham.MainView = this.gvNhomSanPham;
            this.grdNhomSanPham.Name = "grdNhomSanPham";
            this.grdNhomSanPham.Size = new System.Drawing.Size(1107, 480);
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
            this.gvNhomSanPham.Name = "gvNhomSanPham";
            this.gvNhomSanPham.OptionsView.ShowGroupPanel = false;
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
            // 
            // colTennhom
            // 
            this.colTennhom.Caption = "Tên nhóm";
            this.colTennhom.FieldName = "Tennhom";
            this.colTennhom.Name = "colTennhom";
            this.colTennhom.Visible = true;
            this.colTennhom.VisibleIndex = 1;
            // 
            // DM_NhomSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 524);
            this.Controls.Add(this.grdNhomSanPham);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DM_NhomSanPham";
            this.Text = "Nhóm sản phẩm";
            this.Load += new System.EventHandler(this.DM_NhomSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNhomSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl grdNhomSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhomSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colManhomspid;
        private DevExpress.XtraGrid.Columns.GridColumn colManhom;
        private DevExpress.XtraGrid.Columns.GridColumn colTennhom;
    }
}