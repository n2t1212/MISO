namespace PosMiso.View
{
    partial class DM_Kho
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
            this.grdKho = new DevExpress.XtraGrid.GridControl();
            this.gvKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKhoid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMakho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenkho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaikho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThukho = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 48);
            this.panel1.TabIndex = 0;
            // 
            // grdKho
            // 
            this.grdKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKho.Location = new System.Drawing.Point(0, 0);
            this.grdKho.MainView = this.gvKho;
            this.grdKho.Name = "grdKho";
            this.grdKho.Size = new System.Drawing.Size(1111, 482);
            this.grdKho.TabIndex = 1;
            this.grdKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKho});
            // 
            // gvKho
            // 
            this.gvKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKhoid,
            this.colMakho,
            this.colTenkho,
            this.colDiachi,
            this.colLoaikho,
            this.colThukho});
            this.gvKho.GridControl = this.grdKho;
            this.gvKho.Name = "gvKho";
            this.gvKho.OptionsView.ShowGroupPanel = false;
            // 
            // colKhoid
            // 
            this.colKhoid.Caption = "Khoid";
            this.colKhoid.FieldName = "Khoid";
            this.colKhoid.Name = "colKhoid";
            // 
            // colMakho
            // 
            this.colMakho.Caption = "Mã kho";
            this.colMakho.FieldName = "Makho";
            this.colMakho.Name = "colMakho";
            this.colMakho.Visible = true;
            this.colMakho.VisibleIndex = 0;
            // 
            // colTenkho
            // 
            this.colTenkho.Caption = "Tên kho";
            this.colTenkho.FieldName = "Tenkho";
            this.colTenkho.Name = "colTenkho";
            this.colTenkho.Visible = true;
            this.colTenkho.VisibleIndex = 1;
            // 
            // colDiachi
            // 
            this.colDiachi.Caption = "Địa chỉ";
            this.colDiachi.FieldName = "Diachi";
            this.colDiachi.Name = "colDiachi";
            this.colDiachi.Visible = true;
            this.colDiachi.VisibleIndex = 2;
            // 
            // colLoaikho
            // 
            this.colLoaikho.Caption = "Loại kho";
            this.colLoaikho.FieldName = "Loaikho";
            this.colLoaikho.Name = "colLoaikho";
            this.colLoaikho.Visible = true;
            this.colLoaikho.VisibleIndex = 3;
            // 
            // colThukho
            // 
            this.colThukho.Caption = "Thủ kho";
            this.colThukho.FieldName = "Thukho";
            this.colThukho.Name = "colThukho";
            this.colThukho.Visible = true;
            this.colThukho.VisibleIndex = 4;
            // 
            // DM_Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 530);
            this.Controls.Add(this.grdKho);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DM_Kho";
            this.Text = "Kho";
            this.Load += new System.EventHandler(this.DM_Kho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl grdKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKho;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoid;
        private DevExpress.XtraGrid.Columns.GridColumn colMakho;
        private DevExpress.XtraGrid.Columns.GridColumn colTenkho;
        private DevExpress.XtraGrid.Columns.GridColumn colDiachi;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaikho;
        private DevExpress.XtraGrid.Columns.GridColumn colThukho;
    }
}