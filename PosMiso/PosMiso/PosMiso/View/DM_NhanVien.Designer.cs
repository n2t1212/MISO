namespace PosMiso.View
{
    partial class DM_NhanVien
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
            this.grdNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gvNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colManvid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMabp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemBP = new PosMiso.Model.RepositoryItemCustomGridLookUpEdit();
            this.viewBP = new PosMiso.Model.CustomGridView();
            this.colbophanid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmabophan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenbophan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTennv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaysinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienthoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaythuviec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaychinhthuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 41);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdAdd,
            this.cmdEdit,
            this.cmdDel,
            this.cmdSave,
            this.cmdAbort,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(968, 38);
            this.toolStrip1.TabIndex = 42;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Image = global::PosMiso.Properties.Resources.ic_btn_add1;
            this.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(65, 35);
            this.cmdAdd.Text = "Thêm (F2)";
            this.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click_1);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Image = global::PosMiso.Properties.Resources.ic_btn_edit;
            this.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(53, 35);
            this.cmdEdit.Text = "Sửa (F3)";
            this.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click_1);
            // 
            // cmdDel
            // 
            this.cmdDel.Image = global::PosMiso.Properties.Resources.ic_btn_del;
            this.cmdDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(54, 35);
            this.cmdDel.Text = "Xóa (F4)";
            this.cmdDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click_1);
            // 
            // cmdSave
            // 
            this.cmdSave.Image = global::PosMiso.Properties.Resources.ic_btn_save;
            this.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(54, 35);
            this.cmdSave.Text = "Lưu (F5)";
            this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click_1);
            // 
            // cmdAbort
            // 
            this.cmdAbort.Image = global::PosMiso.Properties.Resources.ic_btn_abort;
            this.cmdAbort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAbort.Name = "cmdAbort";
            this.cmdAbort.Size = new System.Drawing.Size(61, 35);
            this.cmdAbort.Text = "Hủy (Esc)";
            this.cmdAbort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAbort.Click += new System.EventHandler(this.cmdAbort_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::PosMiso.Properties.Resources.ic_exit;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(65, 35);
            this.toolStripButton2.Text = "Thoát (F8)";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // grdNhanVien
            // 
            this.grdNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNhanVien.Location = new System.Drawing.Point(0, 41);
            this.grdNhanVien.MainView = this.gvNhanVien;
            this.grdNhanVien.Name = "grdNhanVien";
            this.grdNhanVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemBP});
            this.grdNhanVien.Size = new System.Drawing.Size(968, 352);
            this.grdNhanVien.TabIndex = 1;
            this.grdNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhanVien});
            this.grdNhanVien.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grdNhanVien_PreviewKeyDown);
            // 
            // gvNhanVien
            // 
            this.gvNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colManvid,
            this.colMabp,
            this.colManv,
            this.colTennv,
            this.colNgaysinh,
            this.colDiachi,
            this.colDienthoai,
            this.colEmail,
            this.colNgaythuviec,
            this.colNgaychinhthuc});
            this.gvNhanVien.GridControl = this.grdNhanVien;
            this.gvNhanVien.Name = "gvNhanVien";
            this.gvNhanVien.OptionsView.ShowGroupPanel = false;
            this.gvNhanVien.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvNhanVien_InitNewRow);
            // 
            // colManvid
            // 
            this.colManvid.Caption = "Manvid";
            this.colManvid.FieldName = "Manvid";
            this.colManvid.Name = "colManvid";
            // 
            // colMabp
            // 
            this.colMabp.Caption = "Mã bộ phận";
            this.colMabp.ColumnEdit = this.repositoryItemBP;
            this.colMabp.FieldName = "Mabp";
            this.colMabp.Name = "colMabp";
            this.colMabp.Visible = true;
            this.colMabp.VisibleIndex = 0;
            // 
            // repositoryItemBP
            // 
            this.repositoryItemBP.AutoComplete = false;
            this.repositoryItemBP.AutoHeight = false;
            this.repositoryItemBP.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemBP.Name = "repositoryItemBP";
            this.repositoryItemBP.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemBP.View = this.viewBP;
            // 
            // viewBP
            // 
            this.viewBP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbophanid,
            this.colmabophan,
            this.coltenbophan});
            this.viewBP.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.viewBP.Name = "viewBP";
            this.viewBP.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.viewBP.OptionsView.ShowGroupPanel = false;
            // 
            // colbophanid
            // 
            this.colbophanid.Caption = "bophanid";
            this.colbophanid.FieldName = "bophanid";
            this.colbophanid.Name = "colbophanid";
            // 
            // colmabophan
            // 
            this.colmabophan.Caption = "Mã bộ phận";
            this.colmabophan.FieldName = "mabophan";
            this.colmabophan.Name = "colmabophan";
            this.colmabophan.Visible = true;
            this.colmabophan.VisibleIndex = 0;
            // 
            // coltenbophan
            // 
            this.coltenbophan.Caption = "Tên bộ phận";
            this.coltenbophan.FieldName = "tenbophan";
            this.coltenbophan.Name = "coltenbophan";
            this.coltenbophan.Visible = true;
            this.coltenbophan.VisibleIndex = 1;
            // 
            // colManv
            // 
            this.colManv.Caption = "Mã nhân viên";
            this.colManv.FieldName = "Manv";
            this.colManv.Name = "colManv";
            this.colManv.Visible = true;
            this.colManv.VisibleIndex = 1;
            // 
            // colTennv
            // 
            this.colTennv.Caption = "Tên nhân viên";
            this.colTennv.FieldName = "Tennv";
            this.colTennv.Name = "colTennv";
            this.colTennv.Visible = true;
            this.colTennv.VisibleIndex = 2;
            // 
            // colNgaysinh
            // 
            this.colNgaysinh.Caption = "Ngày sinh";
            this.colNgaysinh.FieldName = "Ngaysinh";
            this.colNgaysinh.Name = "colNgaysinh";
            this.colNgaysinh.Visible = true;
            this.colNgaysinh.VisibleIndex = 3;
            // 
            // colDiachi
            // 
            this.colDiachi.Caption = "Địa chỉ";
            this.colDiachi.FieldName = "Diachi";
            this.colDiachi.Name = "colDiachi";
            this.colDiachi.Visible = true;
            this.colDiachi.VisibleIndex = 4;
            // 
            // colDienthoai
            // 
            this.colDienthoai.Caption = "Điện thoại";
            this.colDienthoai.FieldName = "Dienthoai";
            this.colDienthoai.Name = "colDienthoai";
            this.colDienthoai.Visible = true;
            this.colDienthoai.VisibleIndex = 5;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 6;
            // 
            // colNgaythuviec
            // 
            this.colNgaythuviec.Caption = "Ngày thử việc";
            this.colNgaythuviec.FieldName = "Ngaythuviec";
            this.colNgaythuviec.Name = "colNgaythuviec";
            this.colNgaythuviec.Visible = true;
            this.colNgaythuviec.VisibleIndex = 7;
            // 
            // colNgaychinhthuc
            // 
            this.colNgaychinhthuc.Caption = "Ngày chính thức";
            this.colNgaychinhthuc.FieldName = "Ngaychinhthuc";
            this.colNgaychinhthuc.Name = "colNgaychinhthuc";
            this.colNgaychinhthuc.Visible = true;
            this.colNgaychinhthuc.VisibleIndex = 8;
            // 
            // DM_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 393);
            this.Controls.Add(this.grdNhanVien);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DM_NhanVien";
            this.Text = "Danh mục nhân viên";
            this.Load += new System.EventHandler(this.DM_NhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl grdNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colManvid;
        private DevExpress.XtraGrid.Columns.GridColumn colMabp;
        private Model.RepositoryItemCustomGridLookUpEdit repositoryItemBP;
        private Model.CustomGridView viewBP;
        private DevExpress.XtraGrid.Columns.GridColumn colbophanid;
        private DevExpress.XtraGrid.Columns.GridColumn colmabophan;
        private DevExpress.XtraGrid.Columns.GridColumn coltenbophan;
        private DevExpress.XtraGrid.Columns.GridColumn colManv;
        private DevExpress.XtraGrid.Columns.GridColumn colTennv;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaysinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDiachi;
        private DevExpress.XtraGrid.Columns.GridColumn colDienthoai;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaythuviec;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaychinhthuc;
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