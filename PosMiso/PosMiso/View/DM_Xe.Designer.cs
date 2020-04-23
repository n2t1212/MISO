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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdAdd = new System.Windows.Forms.ToolStripButton();
            this.cmdEdit = new System.Windows.Forms.ToolStripButton();
            this.cmdDel = new System.Windows.Forms.ToolStripButton();
            this.cmdSave = new System.Windows.Forms.ToolStripButton();
            this.cmdAbort = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdExit = new System.Windows.Forms.ToolStripButton();
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
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 40);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdAdd,
            this.cmdEdit,
            this.cmdDel,
            this.cmdSave,
            this.cmdAbort,
            this.toolStripSeparator2,
            this.cmdExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1194, 40);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Image = global::PosMiso.Properties.Resources.ic_btn_add1;
            this.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(65, 37);
            this.cmdAdd.Text = "Thêm (F2)";
            this.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click_1);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Image = global::PosMiso.Properties.Resources.ic_btn_edit;
            this.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(53, 37);
            this.cmdEdit.Text = "Sửa (F3)";
            this.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click_1);
            // 
            // cmdDel
            // 
            this.cmdDel.Image = global::PosMiso.Properties.Resources.ic_btn_del;
            this.cmdDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(54, 37);
            this.cmdDel.Text = "Xóa (F4)";
            this.cmdDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click_1);
            // 
            // cmdSave
            // 
            this.cmdSave.Image = global::PosMiso.Properties.Resources.ic_btn_save;
            this.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(54, 37);
            this.cmdSave.Text = "Lưu (F5)";
            this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click_1);
            // 
            // cmdAbort
            // 
            this.cmdAbort.Image = global::PosMiso.Properties.Resources.ic_btn_abort;
            this.cmdAbort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAbort.Name = "cmdAbort";
            this.cmdAbort.Size = new System.Drawing.Size(61, 37);
            this.cmdAbort.Text = "Hủy (Esc)";
            this.cmdAbort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAbort.Click += new System.EventHandler(this.cmdAbort_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // cmdExit
            // 
            this.cmdExit.Image = global::PosMiso.Properties.Resources.ic_exit;
            this.cmdExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(65, 37);
            this.cmdExit.Text = "Thoát (F8)";
            this.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // grdXe
            // 
            this.grdXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdXe.Location = new System.Drawing.Point(0, 40);
            this.grdXe.MainView = this.gvXe;
            this.grdXe.Name = "grdXe";
            this.grdXe.Size = new System.Drawing.Size(1194, 539);
            this.grdXe.TabIndex = 1;
            this.grdXe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvXe});
            this.grdXe.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grdXe_PreviewKeyDown);
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
            this.gvXe.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvXe_InitNewRow);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DM_Xe";
            this.Text = "Xe";
            this.Load += new System.EventHandler(this.DM_Xe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl grdXe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvXe;
        private DevExpress.XtraGrid.Columns.GridColumn colXeid;
        private DevExpress.XtraGrid.Columns.GridColumn colSoxe;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaixe;
        private DevExpress.XtraGrid.Columns.GridColumn colTaixe;
        private DevExpress.XtraGrid.Columns.GridColumn colDienthoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDiachi;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdAdd;
        private System.Windows.Forms.ToolStripButton cmdEdit;
        private System.Windows.Forms.ToolStripButton cmdDel;
        private System.Windows.Forms.ToolStripButton cmdSave;
        private System.Windows.Forms.ToolStripButton cmdAbort;
        private System.Windows.Forms.ToolStripButton cmdExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}