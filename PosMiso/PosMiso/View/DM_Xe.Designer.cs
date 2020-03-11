namespace PosMiso.View
{
    partial class DM_Xe
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
            this.button1 = new System.Windows.Forms.Button();
            this.grdXe = new DevExpress.XtraGrid.GridControl();
            this.gvXe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colXeid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoxe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaixe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaixe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienthoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 523);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 56);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grdXe
            // 
            this.grdXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdXe.Location = new System.Drawing.Point(0, 0);
            this.grdXe.MainView = this.gvXe;
            this.grdXe.Name = "grdXe";
            this.grdXe.Size = new System.Drawing.Size(1194, 523);
            this.grdXe.TabIndex = 1;
            this.grdXe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvXe});
            // 
            // gvXe
            // 
            this.gvXe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colXeid,
            this.colSoxe,
            this.colLoaixe,
            this.colTaixe,
            this.colDienthoai,
            this.colDiachi,
            this.colGhichu});
            this.gvXe.GridControl = this.grdXe;
            this.gvXe.Name = "gvXe";
            this.gvXe.OptionsView.ShowGroupPanel = false;
            // 
            // colXeid
            // 
            this.colXeid.Caption = "Xeid";
            this.colXeid.FieldName = "Xeid";
            this.colXeid.Name = "colXeid";
            // 
            // colSoxe
            // 
            this.colSoxe.Caption = "Số xe";
            this.colSoxe.FieldName = "Soxe";
            this.colSoxe.Name = "colSoxe";
            this.colSoxe.Visible = true;
            this.colSoxe.VisibleIndex = 0;
            // 
            // colLoaixe
            // 
            this.colLoaixe.Caption = "Loại xe";
            this.colLoaixe.FieldName = "Loaixe";
            this.colLoaixe.Name = "colLoaixe";
            this.colLoaixe.Visible = true;
            this.colLoaixe.VisibleIndex = 1;
            // 
            // colTaixe
            // 
            this.colTaixe.Caption = "Tài xế";
            this.colTaixe.FieldName = "Taixe";
            this.colTaixe.Name = "colTaixe";
            this.colTaixe.Visible = true;
            this.colTaixe.VisibleIndex = 2;
            // 
            // colDienthoai
            // 
            this.colDienthoai.Caption = "Điện thoại";
            this.colDienthoai.FieldName = "Dienthoai";
            this.colDienthoai.Name = "colDienthoai";
            this.colDienthoai.Visible = true;
            this.colDienthoai.VisibleIndex = 3;
            // 
            // colDiachi
            // 
            this.colDiachi.Caption = "Địa chỉ";
            this.colDiachi.FieldName = "Diachi";
            this.colDiachi.Name = "colDiachi";
            this.colDiachi.Visible = true;
            this.colDiachi.VisibleIndex = 4;
            // 
            // colGhichu
            // 
            this.colGhichu.Caption = "Ghi chú";
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            this.colGhichu.Visible = true;
            this.colGhichu.VisibleIndex = 5;
            // 
            // DM_Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 579);
            this.Controls.Add(this.grdXe);
            this.Controls.Add(this.panel1);
            this.Name = "DM_Xe";
            this.Text = "DM_Xe";
            this.Load += new System.EventHandler(this.DM_Xe_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridControl grdXe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvXe;
        private DevExpress.XtraGrid.Columns.GridColumn colXeid;
        private DevExpress.XtraGrid.Columns.GridColumn colSoxe;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaixe;
        private DevExpress.XtraGrid.Columns.GridColumn colTaixe;
        private DevExpress.XtraGrid.Columns.GridColumn colDienthoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDiachi;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
    }
}