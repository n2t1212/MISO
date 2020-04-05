namespace PosMiso.View
{
    partial class DM_SanPham
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
            this.panelFunction = new System.Windows.Forms.Panel();
            this.btnDownTemplate = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdAbort = new System.Windows.Forms.Button();
            this.cmdDel = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnInMa = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grdNhomSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvNhomSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colManhomspid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTennhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaspid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTensp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDvt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuycach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuydoikgl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuydoithung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMabarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaqrcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManhomspid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhomSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFunction
            // 
            this.panelFunction.Controls.Add(this.btnDownTemplate);
            this.panelFunction.Controls.Add(this.cmdSave);
            this.panelFunction.Controls.Add(this.cmdAbort);
            this.panelFunction.Controls.Add(this.cmdDel);
            this.panelFunction.Controls.Add(this.cmdEdit);
            this.panelFunction.Controls.Add(this.cmdAdd);
            this.panelFunction.Controls.Add(this.btnImport);
            this.panelFunction.Controls.Add(this.btnInMa);
            this.panelFunction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFunction.Location = new System.Drawing.Point(0, 482);
            this.panelFunction.Name = "panelFunction";
            this.panelFunction.Size = new System.Drawing.Size(1191, 49);
            this.panelFunction.TabIndex = 7;
            // 
            // btnDownTemplate
            // 
            this.btnDownTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnDownTemplate.Location = new System.Drawing.Point(152, 8);
            this.btnDownTemplate.Name = "btnDownTemplate";
            this.btnDownTemplate.Size = new System.Drawing.Size(112, 32);
            this.btnDownTemplate.TabIndex = 4;
            this.btnDownTemplate.Text = "Tải mẫu (.xls)";
            this.btnDownTemplate.UseVisualStyleBackColor = true;
            this.btnDownTemplate.Click += new System.EventHandler(this.btnDownTemplate_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.cmdSave.Location = new System.Drawing.Point(802, 8);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(104, 32);
            this.cmdSave.TabIndex = 3;
            this.cmdSave.Text = "Lưu (F5)";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdAbort
            // 
            this.cmdAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAbort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.cmdAbort.Location = new System.Drawing.Point(929, 8);
            this.cmdAbort.Name = "cmdAbort";
            this.cmdAbort.Size = new System.Drawing.Size(104, 32);
            this.cmdAbort.TabIndex = 3;
            this.cmdAbort.Text = "Hủy (Esc)";
            this.cmdAbort.UseVisualStyleBackColor = true;
            this.cmdAbort.Click += new System.EventHandler(this.cmdAbort_Click);
            // 
            // cmdDel
            // 
            this.cmdDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.cmdDel.Location = new System.Drawing.Point(677, 8);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(104, 32);
            this.cmdDel.TabIndex = 3;
            this.cmdDel.Text = "Xóa (F4)";
            this.cmdDel.UseVisualStyleBackColor = true;
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.cmdEdit.Location = new System.Drawing.Point(557, 8);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(104, 32);
            this.cmdEdit.TabIndex = 3;
            this.cmdEdit.Text = "Sửa (F3)";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.cmdAdd.Location = new System.Drawing.Point(434, 8);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(104, 32);
            this.cmdAdd.TabIndex = 3;
            this.cmdAdd.Text = "Thêm (F2)";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnImport.Location = new System.Drawing.Point(288, 8);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(104, 32);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Nhập (.xls)";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnInMa
            // 
            this.btnInMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnInMa.Location = new System.Drawing.Point(24, 8);
            this.btnInMa.Name = "btnInMa";
            this.btnInMa.Size = new System.Drawing.Size(104, 32);
            this.btnInMa.TabIndex = 2;
            this.btnInMa.Text = "In mã";
            this.btnInMa.UseVisualStyleBackColor = true;
            this.btnInMa.Click += new System.EventHandler(this.btnInMa_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.grdNhomSanPham);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdSanPham);
            this.splitContainer1.Size = new System.Drawing.Size(1191, 482);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 8;
            // 
            // grdNhomSanPham
            // 
            this.grdNhomSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNhomSanPham.Location = new System.Drawing.Point(0, 0);
            this.grdNhomSanPham.MainView = this.gvNhomSanPham;
            this.grdNhomSanPham.Name = "grdNhomSanPham";
            this.grdNhomSanPham.Size = new System.Drawing.Size(1191, 212);
            this.grdNhomSanPham.TabIndex = 2;
            this.grdNhomSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhomSanPham,
            this.gridView1});
            // 
            // gvNhomSanPham
            // 
            this.gvNhomSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colManhomspid,
            this.colManhom,
            this.colTennhom});
            this.gvNhomSanPham.GridControl = this.grdNhomSanPham;
            this.gvNhomSanPham.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvNhomSanPham.Name = "gvNhomSanPham";
            this.gvNhomSanPham.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvNhomSanPham.OptionsView.ColumnAutoWidth = false;
            this.gvNhomSanPham.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvNhomSanPham.OptionsView.ShowGroupPanel = false;
            this.gvNhomSanPham.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gvNhomSanPham.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gvNhomSanPham.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvNhomSanPham.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvNhomSanPham_RowClick);
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
            this.colManhom.Width = 477;
            // 
            // colTennhom
            // 
            this.colTennhom.Caption = "Tên nhóm";
            this.colTennhom.FieldName = "Tennhom";
            this.colTennhom.Name = "colTennhom";
            this.colTennhom.Visible = true;
            this.colTennhom.VisibleIndex = 1;
            this.colTennhom.Width = 697;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdNhomSanPham;
            this.gridView1.Name = "gridView1";
            // 
            // grdSanPham
            // 
            this.grdSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSanPham.Location = new System.Drawing.Point(0, 0);
            this.grdSanPham.MainView = this.gvSanPham;
            this.grdSanPham.Name = "grdSanPham";
            this.grdSanPham.Size = new System.Drawing.Size(1191, 266);
            this.grdSanPham.TabIndex = 1;
            this.grdSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPham});
            // 
            // gvSanPham
            // 
            this.gvSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaspid,
            this.colManhomspid1,
            this.colMasp,
            this.colTensp,
            this.colDvt,
            this.colQuycach,
            this.colQuydoikgl,
            this.colQuydoithung,
            this.colMabarcode,
            this.colMaqrcode});
            this.gvSanPham.GridControl = this.grdSanPham;
            this.gvSanPham.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvSanPham.Name = "gvSanPham";
            this.gvSanPham.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvSanPham.OptionsView.ShowGroupPanel = false;
            this.gvSanPham.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gvSanPham.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gvSanPham.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvSanPham.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvSanPham_InitNewRow);
            this.gvSanPham.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvSanPham_KeyDown);
            // 
            // colMaspid
            // 
            this.colMaspid.Caption = "MASPID";
            this.colMaspid.FieldName = "Maspid";
            this.colMaspid.Name = "colMaspid";
            // 
            // colMasp
            // 
            this.colMasp.Caption = "Mã hàng";
            this.colMasp.FieldName = "Masp";
            this.colMasp.Name = "colMasp";
            this.colMasp.Visible = true;
            this.colMasp.VisibleIndex = 0;
            this.colMasp.Width = 202;
            // 
            // colTensp
            // 
            this.colTensp.Caption = "Tên hàng hóa";
            this.colTensp.FieldName = "Tensp";
            this.colTensp.Name = "colTensp";
            this.colTensp.Visible = true;
            this.colTensp.VisibleIndex = 1;
            this.colTensp.Width = 324;
            // 
            // colDvt
            // 
            this.colDvt.Caption = "Đơn vị tính";
            this.colDvt.FieldName = "Dvt";
            this.colDvt.Name = "colDvt";
            this.colDvt.Visible = true;
            this.colDvt.VisibleIndex = 2;
            this.colDvt.Width = 112;
            // 
            // colQuycach
            // 
            this.colQuycach.Caption = "Quy cách";
            this.colQuycach.FieldName = "Quycach";
            this.colQuycach.Name = "colQuycach";
            this.colQuycach.Visible = true;
            this.colQuycach.VisibleIndex = 3;
            this.colQuycach.Width = 83;
            // 
            // colQuydoikgl
            // 
            this.colQuydoikgl.Caption = "Quy đổi Kgl";
            this.colQuydoikgl.FieldName = "Quydoikgl";
            this.colQuydoikgl.Name = "colQuydoikgl";
            this.colQuydoikgl.Visible = true;
            this.colQuydoikgl.VisibleIndex = 4;
            this.colQuydoikgl.Width = 74;
            // 
            // colQuydoithung
            // 
            this.colQuydoithung.Caption = "Quy đổi thùng";
            this.colQuydoithung.FieldName = "Quydoithung";
            this.colQuydoithung.Name = "colQuydoithung";
            this.colQuydoithung.Visible = true;
            this.colQuydoithung.VisibleIndex = 5;
            this.colQuydoithung.Width = 91;
            // 
            // colMabarcode
            // 
            this.colMabarcode.Caption = "Mã bar code";
            this.colMabarcode.FieldName = "Mabarcode";
            this.colMabarcode.Name = "colMabarcode";
            this.colMabarcode.OptionsColumn.AllowEdit = false;
            this.colMabarcode.OptionsColumn.AllowFocus = false;
            this.colMabarcode.OptionsColumn.ReadOnly = true;
            this.colMabarcode.Visible = true;
            this.colMabarcode.VisibleIndex = 6;
            this.colMabarcode.Width = 126;
            // 
            // colMaqrcode
            // 
            this.colMaqrcode.Caption = "Mã QR code";
            this.colMaqrcode.FieldName = "Maqrcode";
            this.colMaqrcode.Name = "colMaqrcode";
            this.colMaqrcode.OptionsColumn.AllowEdit = false;
            this.colMaqrcode.OptionsColumn.AllowFocus = false;
            this.colMaqrcode.OptionsColumn.ReadOnly = true;
            this.colMaqrcode.Visible = true;
            this.colMaqrcode.VisibleIndex = 7;
            this.colMaqrcode.Width = 144;
            // 
            // colManhomspid1
            // 
            this.colManhomspid1.Caption = "Manhomspid";
            this.colManhomspid1.FieldName = "Manhomspid";
            this.colManhomspid1.Name = "colManhomspid1";
            // 
            // DM_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 531);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelFunction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DM_SanPham";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.DM_SanPham_Load);
            this.panelFunction.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNhomSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFunction;
        private System.Windows.Forms.Button btnDownTemplate;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdAbort;
        private System.Windows.Forms.Button cmdDel;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnInMa;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl grdNhomSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhomSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colManhomspid;
        private DevExpress.XtraGrid.Columns.GridColumn colManhom;
        private DevExpress.XtraGrid.Columns.GridColumn colTennhom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grdSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colMaspid;
        private DevExpress.XtraGrid.Columns.GridColumn colMasp;
        private DevExpress.XtraGrid.Columns.GridColumn colTensp;
        private DevExpress.XtraGrid.Columns.GridColumn colDvt;
        private DevExpress.XtraGrid.Columns.GridColumn colQuycach;
        private DevExpress.XtraGrid.Columns.GridColumn colQuydoikgl;
        private DevExpress.XtraGrid.Columns.GridColumn colQuydoithung;
        private DevExpress.XtraGrid.Columns.GridColumn colMabarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colMaqrcode;
        private DevExpress.XtraGrid.Columns.GridColumn colManhomspid1;

    }
}