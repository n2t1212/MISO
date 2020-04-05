namespace PosMiso.View
{
    partial class DM_LyDo
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
            this.grdLyDo = new DevExpress.XtraGrid.GridControl();
            this.gvLyDo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMald = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLydo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTKNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTKCo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdLyDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLyDo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 494);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 40);
            this.panel1.TabIndex = 0;
            // 
            // grdLyDo
            // 
            this.grdLyDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLyDo.Location = new System.Drawing.Point(0, 0);
            this.grdLyDo.MainView = this.gvLyDo;
            this.grdLyDo.Name = "grdLyDo";
            this.grdLyDo.Size = new System.Drawing.Size(1119, 494);
            this.grdLyDo.TabIndex = 1;
            this.grdLyDo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLyDo});
            // 
            // gvLyDo
            // 
            this.gvLyDo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMald,
            this.colLydo,
            this.colLoai,
            this.colTKNo,
            this.colTKCo,
            this.colGhichu});
            this.gvLyDo.GridControl = this.grdLyDo;
            this.gvLyDo.Name = "gvLyDo";
            this.gvLyDo.OptionsView.ShowGroupPanel = false;
            // 
            // colMald
            // 
            this.colMald.Caption = "Mã lý do";
            this.colMald.FieldName = "Mald";
            this.colMald.Name = "colMald";
            this.colMald.Visible = true;
            this.colMald.VisibleIndex = 0;
            // 
            // colLydo
            // 
            this.colLydo.Caption = "Tên lý do";
            this.colLydo.FieldName = "Lydo";
            this.colLydo.Name = "colLydo";
            this.colLydo.Visible = true;
            this.colLydo.VisibleIndex = 1;
            // 
            // colLoai
            // 
            this.colLoai.Caption = "Loại";
            this.colLoai.FieldName = "Loai";
            this.colLoai.Name = "colLoai";
            this.colLoai.Visible = true;
            this.colLoai.VisibleIndex = 2;
            // 
            // colTKNo
            // 
            this.colTKNo.Caption = "Tài khoản nợ";
            this.colTKNo.FieldName = "TKNo";
            this.colTKNo.Name = "colTKNo";
            this.colTKNo.Visible = true;
            this.colTKNo.VisibleIndex = 3;
            // 
            // colTKCo
            // 
            this.colTKCo.Caption = "Tài khoản có";
            this.colTKCo.FieldName = "TKCo";
            this.colTKCo.Name = "colTKCo";
            this.colTKCo.Visible = true;
            this.colTKCo.VisibleIndex = 4;
            // 
            // colGhichu
            // 
            this.colGhichu.Caption = "Ghi chú";
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            this.colGhichu.Visible = true;
            this.colGhichu.VisibleIndex = 5;
            // 
            // DM_LyDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 534);
            this.Controls.Add(this.grdLyDo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DM_LyDo";
            this.Text = "Lý do";
            this.Load += new System.EventHandler(this.DM_LyDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLyDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLyDo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl grdLyDo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLyDo;
        private DevExpress.XtraGrid.Columns.GridColumn colMald;
        private DevExpress.XtraGrid.Columns.GridColumn colLydo;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colTKNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTKCo;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
    }
}