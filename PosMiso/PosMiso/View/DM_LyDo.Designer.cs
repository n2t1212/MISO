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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdAdd = new System.Windows.Forms.ToolStripButton();
            this.cmdEdit = new System.Windows.Forms.ToolStripButton();
            this.cmdDel = new System.Windows.Forms.ToolStripButton();
            this.cmdSave = new System.Windows.Forms.ToolStripButton();
            this.cmdAbort = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.grdLyDo = new DevExpress.XtraGrid.GridControl();
            this.gvLyDo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMald = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLydo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTKNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTKNo = new PosMiso.Model.RepositoryItemCustomGridLookUpEdit();
            this.viewTKNo = new PosMiso.Model.CustomGridView();
            this.colMatk1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaiKhoan1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTKCo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLyDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLyDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTKNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTKNo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 39);
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
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1119, 39);
            this.toolStrip1.TabIndex = 32;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Image = global::PosMiso.Properties.Resources.ic_btn_add1;
            this.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(65, 36);
            this.cmdAdd.Text = "Thêm (F2)";
            this.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click_1);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Image = global::PosMiso.Properties.Resources.ic_btn_edit;
            this.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(53, 36);
            this.cmdEdit.Text = "Sửa (F3)";
            this.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click_1);
            // 
            // cmdDel
            // 
            this.cmdDel.Image = global::PosMiso.Properties.Resources.ic_btn_del;
            this.cmdDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(54, 36);
            this.cmdDel.Text = "Xóa (F4)";
            this.cmdDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click_1);
            // 
            // cmdSave
            // 
            this.cmdSave.Image = global::PosMiso.Properties.Resources.ic_btn_save;
            this.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(54, 36);
            this.cmdSave.Text = "Lưu (F5)";
            this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click_1);
            // 
            // cmdAbort
            // 
            this.cmdAbort.Image = global::PosMiso.Properties.Resources.ic_btn_abort;
            this.cmdAbort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAbort.Name = "cmdAbort";
            this.cmdAbort.Size = new System.Drawing.Size(61, 36);
            this.cmdAbort.Text = "Hủy (Esc)";
            this.cmdAbort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAbort.Click += new System.EventHandler(this.cmdAbort_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::PosMiso.Properties.Resources.ic_exit;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(65, 36);
            this.toolStripButton2.Text = "Thoát (F8)";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // grdLyDo
            // 
            this.grdLyDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLyDo.Location = new System.Drawing.Point(0, 39);
            this.grdLyDo.MainView = this.gvLyDo;
            this.grdLyDo.Name = "grdLyDo";
            this.grdLyDo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTKNo});
            this.grdLyDo.Size = new System.Drawing.Size(1119, 495);
            this.grdLyDo.TabIndex = 1;
            this.grdLyDo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLyDo});
            this.grdLyDo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grdLyDo_PreviewKeyDown);
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
            this.colTKNo.ColumnEdit = this.repositoryItemTKNo;
            this.colTKNo.FieldName = "TKNo";
            this.colTKNo.Name = "colTKNo";
            this.colTKNo.Visible = true;
            this.colTKNo.VisibleIndex = 3;
            // 
            // repositoryItemTKNo
            // 
            this.repositoryItemTKNo.AutoComplete = false;
            this.repositoryItemTKNo.AutoHeight = false;
            this.repositoryItemTKNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTKNo.Name = "repositoryItemTKNo";
            this.repositoryItemTKNo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemTKNo.View = this.viewTKNo;
            // 
            // viewTKNo
            // 
            this.viewTKNo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMatk1,
            this.colTaiKhoan1});
            this.viewTKNo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.viewTKNo.Name = "viewTKNo";
            this.viewTKNo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.viewTKNo.OptionsView.ShowGroupPanel = false;
            // 
            // colMatk1
            // 
            this.colMatk1.Caption = "Mã tài khoản";
            this.colMatk1.FieldName = "Matk";
            this.colMatk1.Name = "colMatk1";
            this.colMatk1.Visible = true;
            this.colMatk1.VisibleIndex = 0;
            // 
            // colTaiKhoan1
            // 
            this.colTaiKhoan1.Caption = "Tài khoản";
            this.colTaiKhoan1.FieldName = "Taikhoan";
            this.colTaiKhoan1.Name = "colTaiKhoan1";
            this.colTaiKhoan1.Visible = true;
            this.colTaiKhoan1.VisibleIndex = 1;
            // 
            // colTKCo
            // 
            this.colTKCo.Caption = "Tài khoản có";
            this.colTKCo.ColumnEdit = this.repositoryItemTKNo;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLyDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLyDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTKNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTKNo)).EndInit();
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
        private Model.RepositoryItemCustomGridLookUpEdit repositoryItemTKNo;
        private Model.CustomGridView viewTKNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMatk1;
        private DevExpress.XtraGrid.Columns.GridColumn colTaiKhoan1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdAdd;
        private System.Windows.Forms.ToolStripButton cmdEdit;
        private System.Windows.Forms.ToolStripButton cmdDel;
        private System.Windows.Forms.ToolStripButton cmdSave;
        private System.Windows.Forms.ToolStripButton cmdAbort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}