namespace PosMiso.View
{
    partial class dlg_AddQuyenHan
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
            this.pnlTitleForm = new DevExpress.XtraEditors.PanelControl();
            this.cmdAppExit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdChucNang = new DevExpress.XtraGrid.GridControl();
            this.gvChucNang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmacn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTencn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tvChucNang = new System.Windows.Forms.TreeView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cmdRemoveAll = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAdd = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRemove = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAddAll = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitleForm)).BeginInit();
            this.pnlTitleForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleForm
            // 
            this.pnlTitleForm.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.pnlTitleForm.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(190)))), ((int)(((byte)(224)))));
            this.pnlTitleForm.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlTitleForm.Appearance.Options.UseBackColor = true;
            this.pnlTitleForm.Controls.Add(this.cmdAppExit);
            this.pnlTitleForm.Controls.Add(this.labelControl2);
            this.pnlTitleForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlTitleForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleForm.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleForm.Name = "pnlTitleForm";
            this.pnlTitleForm.Size = new System.Drawing.Size(900, 45);
            this.pnlTitleForm.TabIndex = 8;
            // 
            // cmdAppExit
            // 
            this.cmdAppExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAppExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAppExit.Location = new System.Drawing.Point(855, 8);
            this.cmdAppExit.Name = "cmdAppExit";
            this.cmdAppExit.Size = new System.Drawing.Size(34, 28);
            this.cmdAppExit.TabIndex = 9;
            this.cmdAppExit.Text = "X";
            this.cmdAppExit.Click += new System.EventHandler(this.cmdAppExit_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.labelControl2.Location = new System.Drawing.Point(8, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(128, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "THÊM QUYỀN HẠN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 46);
            this.panel1.TabIndex = 9;
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnImport.Image = global::PosMiso.Properties.Resources.ic_btn_ok;
            this.btnImport.Location = new System.Drawing.Point(368, 8);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(104, 32);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Đồng ý";
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdChucNang);
            this.panel2.Controls.Add(this.tvChucNang);
            this.panel2.Controls.Add(this.panelControl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 379);
            this.panel2.TabIndex = 4;
            // 
            // grdChucNang
            // 
            this.grdChucNang.Dock = System.Windows.Forms.DockStyle.Right;
            this.grdChucNang.Location = new System.Drawing.Point(368, 0);
            this.grdChucNang.MainView = this.gvChucNang;
            this.grdChucNang.Name = "grdChucNang";
            this.grdChucNang.Size = new System.Drawing.Size(532, 379);
            this.grdChucNang.TabIndex = 11;
            this.grdChucNang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChucNang});
            // 
            // gvChucNang
            // 
            this.gvChucNang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmacn,
            this.colTencn,
            this.colThem,
            this.colSua,
            this.colXoa,
            this.colDuyet,
            this.colIn});
            this.gvChucNang.GridControl = this.grdChucNang;
            this.gvChucNang.Name = "gvChucNang";
            this.gvChucNang.OptionsSelection.MultiSelect = true;
            this.gvChucNang.OptionsView.ShowGroupPanel = false;
            // 
            // colmacn
            // 
            this.colmacn.Caption = "macn";
            this.colmacn.FieldName = "macn";
            this.colmacn.Name = "colmacn";
            // 
            // colTencn
            // 
            this.colTencn.Caption = "Tên chức năng";
            this.colTencn.FieldName = "tencn";
            this.colTencn.Name = "colTencn";
            this.colTencn.OptionsColumn.AllowEdit = false;
            this.colTencn.Visible = true;
            this.colTencn.VisibleIndex = 0;
            this.colTencn.Width = 195;
            // 
            // colThem
            // 
            this.colThem.Caption = "Thêm";
            this.colThem.FieldName = "them";
            this.colThem.Name = "colThem";
            this.colThem.Visible = true;
            this.colThem.VisibleIndex = 1;
            this.colThem.Width = 64;
            // 
            // colSua
            // 
            this.colSua.Caption = "Sửa";
            this.colSua.FieldName = "sua";
            this.colSua.Name = "colSua";
            this.colSua.Visible = true;
            this.colSua.VisibleIndex = 2;
            this.colSua.Width = 64;
            // 
            // colXoa
            // 
            this.colXoa.Caption = "Xóa";
            this.colXoa.FieldName = "xoa";
            this.colXoa.Name = "colXoa";
            this.colXoa.Visible = true;
            this.colXoa.VisibleIndex = 3;
            this.colXoa.Width = 59;
            // 
            // colDuyet
            // 
            this.colDuyet.Caption = "Duyệt";
            this.colDuyet.FieldName = "duyet";
            this.colDuyet.Name = "colDuyet";
            this.colDuyet.Visible = true;
            this.colDuyet.VisibleIndex = 4;
            this.colDuyet.Width = 61;
            // 
            // colIn
            // 
            this.colIn.Caption = "In";
            this.colIn.FieldName = "in";
            this.colIn.Name = "colIn";
            this.colIn.Visible = true;
            this.colIn.VisibleIndex = 5;
            this.colIn.Width = 67;
            // 
            // tvChucNang
            // 
            this.tvChucNang.CheckBoxes = true;
            this.tvChucNang.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvChucNang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvChucNang.Location = new System.Drawing.Point(0, 0);
            this.tvChucNang.Name = "tvChucNang";
            this.tvChucNang.Size = new System.Drawing.Size(280, 379);
            this.tvChucNang.TabIndex = 10;
            this.tvChucNang.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvChucNang_AfterCheck);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cmdRemoveAll);
            this.panelControl2.Controls.Add(this.cmdAdd);
            this.panelControl2.Controls.Add(this.cmdRemove);
            this.panelControl2.Controls.Add(this.cmdAddAll);
            this.panelControl2.Location = new System.Drawing.Point(280, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(88, 384);
            this.panelControl2.TabIndex = 9;
            // 
            // cmdRemoveAll
            // 
            this.cmdRemoveAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRemoveAll.Location = new System.Drawing.Point(22, 215);
            this.cmdRemoveAll.Name = "cmdRemoveAll";
            this.cmdRemoveAll.Size = new System.Drawing.Size(38, 30);
            this.cmdRemoveAll.TabIndex = 8;
            this.cmdRemoveAll.Text = "|<";
            this.cmdRemoveAll.Click += new System.EventHandler(this.cmdRemoveAll_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAdd.Location = new System.Drawing.Point(22, 95);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(38, 30);
            this.cmdAdd.TabIndex = 5;
            this.cmdAdd.Text = ">";
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdRemove
            // 
            this.cmdRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRemove.Location = new System.Drawing.Point(22, 179);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(38, 30);
            this.cmdRemove.TabIndex = 7;
            this.cmdRemove.Text = "<";
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // cmdAddAll
            // 
            this.cmdAddAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAddAll.Location = new System.Drawing.Point(22, 131);
            this.cmdAddAll.Name = "cmdAddAll";
            this.cmdAddAll.Size = new System.Drawing.Size(38, 30);
            this.cmdAddAll.TabIndex = 6;
            this.cmdAddAll.Text = ">|";
            this.cmdAddAll.Click += new System.EventHandler(this.cmdAddAll_Click);
            // 
            // dlg_AddQuyenHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 470);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitleForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dlg_AddQuyenHan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm quyền hạn";
            this.Load += new System.EventHandler(this.dlg_AddQuyenHan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitleForm)).EndInit();
            this.pnlTitleForm.ResumeLayout(false);
            this.pnlTitleForm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlTitleForm;
        private DevExpress.XtraEditors.SimpleButton cmdAppExit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView tvChucNang;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton cmdRemoveAll;
        private DevExpress.XtraEditors.SimpleButton cmdAdd;
        private DevExpress.XtraEditors.SimpleButton cmdRemove;
        private DevExpress.XtraEditors.SimpleButton cmdAddAll;
        private DevExpress.XtraGrid.GridControl grdChucNang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn colmacn;
        private DevExpress.XtraGrid.Columns.GridColumn colTencn;
        private DevExpress.XtraGrid.Columns.GridColumn colThem;
        private DevExpress.XtraGrid.Columns.GridColumn colSua;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn colIn;
    }
}