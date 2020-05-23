namespace PosMiso.View
{
    partial class HT_NguoiDung
    {
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl grdNhomQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhomQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colsoid1;
        private DevExpress.XtraGrid.Columns.GridColumn colmanhom;
        private DevExpress.XtraGrid.Columns.GridColumn coltennhom;
        private DevExpress.XtraGrid.GridControl grdNguoiDung;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn colsoid;
        private DevExpress.XtraGrid.Columns.GridColumn colmanv;
        private Model.RepositoryItemCustomGridLookUpEdit repositoryItemNV;

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdAdd = new System.Windows.Forms.ToolStripButton();
            this.cmdEdit = new System.Windows.Forms.ToolStripButton();
            this.cmdDel = new System.Windows.Forms.ToolStripButton();
            this.cmdSave = new System.Windows.Forms.ToolStripButton();
            this.cmdAbort = new System.Windows.Forms.ToolStripButton();
            this.cmdExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.grdNhomQuyen = new DevExpress.XtraGrid.GridControl();
            this.gvNhomQuyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsoid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmanhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltennhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdNguoiDung = new DevExpress.XtraGrid.GridControl();
            this.gvNguoiDung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsoid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmanv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemNV = new PosMiso.Model.RepositoryItemCustomGridLookUpEdit();
            this.viewNV = new PosMiso.Model.CustomGridView();
            this.colManvid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManv1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTennv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienthoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltaikhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmatkhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisync = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhomQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 48);
            this.panel1.TabIndex = 1;
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
            this.cmdExit,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(946, 48);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Image = global::PosMiso.Properties.Resources.ic_btn_add1;
            this.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(65, 45);
            this.cmdAdd.Text = "Thêm (F2)";
            this.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click_1);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Image = global::PosMiso.Properties.Resources.ic_btn_edit;
            this.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(53, 45);
            this.cmdEdit.Text = "Sửa (F3)";
            this.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click_1);
            // 
            // cmdDel
            // 
            this.cmdDel.Image = global::PosMiso.Properties.Resources.ic_btn_del;
            this.cmdDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(54, 45);
            this.cmdDel.Text = "Xóa (F4)";
            this.cmdDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click_1);
            // 
            // cmdSave
            // 
            this.cmdSave.Image = global::PosMiso.Properties.Resources.ic_btn_save;
            this.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(54, 45);
            this.cmdSave.Text = "Lưu (F5)";
            this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click_1);
            // 
            // cmdAbort
            // 
            this.cmdAbort.Image = global::PosMiso.Properties.Resources.ic_btn_abort;
            this.cmdAbort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAbort.Name = "cmdAbort";
            this.cmdAbort.Size = new System.Drawing.Size(61, 45);
            this.cmdAbort.Text = "Hủy (Esc)";
            this.cmdAbort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAbort.Click += new System.EventHandler(this.cmdAbort_Click_1);
            // 
            // cmdExit
            // 
            this.cmdExit.Image = global::PosMiso.Properties.Resources.ic_exit;
            this.cmdExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(65, 45);
            this.cmdExit.Text = "Thoát (F8)";
            this.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // grdNhomQuyen
            // 
            this.grdNhomQuyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdNhomQuyen.Location = new System.Drawing.Point(0, 48);
            this.grdNhomQuyen.MainView = this.gvNhomQuyen;
            this.grdNhomQuyen.Name = "grdNhomQuyen";
            this.grdNhomQuyen.Size = new System.Drawing.Size(946, 155);
            this.grdNhomQuyen.TabIndex = 4;
            this.grdNhomQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhomQuyen});
            // 
            // gvNhomQuyen
            // 
            this.gvNhomQuyen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsoid1,
            this.colmanhom,
            this.coltennhom});
            this.gvNhomQuyen.GridControl = this.grdNhomQuyen;
            this.gvNhomQuyen.Name = "gvNhomQuyen";
            this.gvNhomQuyen.OptionsView.ShowGroupPanel = false;
            this.gvNhomQuyen.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvNhomQuyen_RowClick);
            // 
            // colsoid1
            // 
            this.colsoid1.Caption = "soid";
            this.colsoid1.FieldName = "soid";
            this.colsoid1.Name = "colsoid1";
            // 
            // colmanhom
            // 
            this.colmanhom.Caption = "Mã nhóm";
            this.colmanhom.FieldName = "manhom";
            this.colmanhom.Name = "colmanhom";
            this.colmanhom.Visible = true;
            this.colmanhom.VisibleIndex = 0;
            // 
            // coltennhom
            // 
            this.coltennhom.Caption = "Tên nhóm";
            this.coltennhom.FieldName = "tennhom";
            this.coltennhom.Name = "coltennhom";
            this.coltennhom.Visible = true;
            this.coltennhom.VisibleIndex = 1;
            // 
            // grdNguoiDung
            // 
            this.grdNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNguoiDung.Location = new System.Drawing.Point(0, 203);
            this.grdNguoiDung.MainView = this.gvNguoiDung;
            this.grdNguoiDung.Name = "grdNguoiDung";
            this.grdNguoiDung.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemNV});
            this.grdNguoiDung.Size = new System.Drawing.Size(946, 221);
            this.grdNguoiDung.TabIndex = 5;
            this.grdNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNguoiDung});
            this.grdNguoiDung.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grdNguoiDung_PreviewKeyDown);
            // 
            // gvNguoiDung
            // 
            this.gvNguoiDung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsoid,
            this.colmanv,
            this.colhoten,
            this.coltaikhoan,
            this.colmatkhau,
            this.colisync});
            this.gvNguoiDung.GridControl = this.grdNguoiDung;
            this.gvNguoiDung.Name = "gvNguoiDung";
            this.gvNguoiDung.OptionsView.ShowGroupPanel = false;
            this.gvNguoiDung.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvNguoiDung_InitNewRow_1);
            this.gvNguoiDung.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvNguoiDung_KeyDown_1);
            // 
            // colsoid
            // 
            this.colsoid.Caption = "soid";
            this.colsoid.FieldName = "soid";
            this.colsoid.Name = "colsoid";
            // 
            // colmanv
            // 
            this.colmanv.Caption = "Mã nhân viên";
            this.colmanv.ColumnEdit = this.repositoryItemNV;
            this.colmanv.FieldName = "manv";
            this.colmanv.Name = "colmanv";
            this.colmanv.Visible = true;
            this.colmanv.VisibleIndex = 0;
            // 
            // repositoryItemNV
            // 
            this.repositoryItemNV.AutoComplete = false;
            this.repositoryItemNV.AutoHeight = false;
            this.repositoryItemNV.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemNV.Name = "repositoryItemNV";
            this.repositoryItemNV.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemNV.View = this.viewNV;
            // 
            // viewNV
            // 
            this.viewNV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colManvid,
            this.colManv1,
            this.colTennv,
            this.colEmail,
            this.colDienthoai,
            this.colDiachi});
            this.viewNV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.viewNV.Name = "viewNV";
            this.viewNV.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.viewNV.OptionsView.ShowGroupPanel = false;
            // 
            // colManvid
            // 
            this.colManvid.Caption = "Manvid";
            this.colManvid.FieldName = "Manvid";
            this.colManvid.Name = "colManvid";
            // 
            // colManv1
            // 
            this.colManv1.Caption = "Mã nhân viên";
            this.colManv1.FieldName = "Manv";
            this.colManv1.Name = "colManv1";
            this.colManv1.Visible = true;
            this.colManv1.VisibleIndex = 0;
            // 
            // colTennv
            // 
            this.colTennv.Caption = "Tên nhân viên";
            this.colTennv.FieldName = "Tennv";
            this.colTennv.Name = "colTennv";
            this.colTennv.Visible = true;
            this.colTennv.VisibleIndex = 1;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 2;
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
            // colhoten
            // 
            this.colhoten.Caption = "Họ tên";
            this.colhoten.FieldName = "hoten";
            this.colhoten.Name = "colhoten";
            this.colhoten.OptionsColumn.AllowEdit = false;
            this.colhoten.OptionsColumn.AllowFocus = false;
            this.colhoten.OptionsColumn.ReadOnly = true;
            this.colhoten.Visible = true;
            this.colhoten.VisibleIndex = 1;
            // 
            // coltaikhoan
            // 
            this.coltaikhoan.Caption = "Tài khoản";
            this.coltaikhoan.FieldName = "taikhoan";
            this.coltaikhoan.Name = "coltaikhoan";
            this.coltaikhoan.Visible = true;
            this.coltaikhoan.VisibleIndex = 2;
            // 
            // colmatkhau
            // 
            this.colmatkhau.Caption = "Mật khẩu";
            this.colmatkhau.FieldName = "matkhau";
            this.colmatkhau.Name = "colmatkhau";
            this.colmatkhau.Visible = true;
            this.colmatkhau.VisibleIndex = 3;
            // 
            // colisync
            // 
            this.colisync.Caption = "Kích hoạt";
            this.colisync.FieldName = "isync";
            this.colisync.Name = "colisync";
            this.colisync.Visible = true;
            this.colisync.VisibleIndex = 4;
            // 
            // HT_NguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 424);
            this.Controls.Add(this.grdNguoiDung);
            this.Controls.Add(this.grdNhomQuyen);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HT_NguoiDung";
            this.Text = "Hệ thống - Người dùng";
            this.Load += new System.EventHandler(this.HT_NguoiDung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhomQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNV)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private Model.CustomGridView viewNV;
        private DevExpress.XtraGrid.Columns.GridColumn colManvid;
        private DevExpress.XtraGrid.Columns.GridColumn colManv1;
        private DevExpress.XtraGrid.Columns.GridColumn colTennv;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colDienthoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDiachi;
        private DevExpress.XtraGrid.Columns.GridColumn colhoten;
        private DevExpress.XtraGrid.Columns.GridColumn coltaikhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colmatkhau;
        private DevExpress.XtraGrid.Columns.GridColumn colisync;
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