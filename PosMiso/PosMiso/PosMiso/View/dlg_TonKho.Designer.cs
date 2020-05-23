namespace PosMiso.View
{
    partial class dlg_TonKho
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
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.cmdAbort = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdDel = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.grdTonKho = new DevExpress.XtraGrid.GridControl();
            this.gvTonKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaspid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMakho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenkho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTensp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDvt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuycach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuoiky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 36);
            this.panel1.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(811, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 28);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 18);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "BẢNG KÊ HÀNG HÓA TỒN KHO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(193)))), ((int)(((byte)(222)))));
            this.panel2.Controls.Add(this.btnExit1);
            this.panel2.Controls.Add(this.cmdAbort);
            this.panel2.Controls.Add(this.cmdSave);
            this.panel2.Controls.Add(this.cmdDel);
            this.panel2.Controls.Add(this.cmdEdit);
            this.panel2.Controls.Add(this.cmdExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 382);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 46);
            this.panel2.TabIndex = 6;
            // 
            // btnExit1
            // 
            this.btnExit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit1.Location = new System.Drawing.Point(1250, 7);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(100, 32);
            this.btnExit1.TabIndex = 8;
            this.btnExit1.Text = "Thoát (F8)";
            this.btnExit1.UseVisualStyleBackColor = true;
            // 
            // cmdAbort
            // 
            this.cmdAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAbort.Location = new System.Drawing.Point(1139, 7);
            this.cmdAbort.Name = "cmdAbort";
            this.cmdAbort.Size = new System.Drawing.Size(102, 32);
            this.cmdAbort.TabIndex = 2;
            this.cmdAbort.Text = "Bỏ qua (Esc)";
            this.cmdAbort.UseVisualStyleBackColor = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(1043, 7);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(90, 32);
            this.cmdSave.TabIndex = 3;
            this.cmdSave.Text = "Lưu (F5)";
            this.cmdSave.UseVisualStyleBackColor = true;
            // 
            // cmdDel
            // 
            this.cmdDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDel.Location = new System.Drawing.Point(947, 7);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(90, 32);
            this.cmdDel.TabIndex = 4;
            this.cmdDel.Text = "Xóa (F4)";
            this.cmdDel.UseVisualStyleBackColor = true;
            // 
            // cmdEdit
            // 
            this.cmdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEdit.Location = new System.Drawing.Point(851, 7);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(90, 32);
            this.cmdEdit.TabIndex = 5;
            this.cmdEdit.Text = "Sửa (F3)";
            this.cmdEdit.UseVisualStyleBackColor = true;
            // 
            // cmdExit
            // 
            this.cmdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Image = global::PosMiso.Properties.Resources.ic_btn_exit;
            this.cmdExit.Location = new System.Drawing.Point(379, 5);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(90, 32);
            this.cmdExit.TabIndex = 7;
            this.cmdExit.Text = "Thoát";
            this.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // grdTonKho
            // 
            this.grdTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTonKho.Location = new System.Drawing.Point(0, 36);
            this.grdTonKho.MainView = this.gvTonKho;
            this.grdTonKho.Name = "grdTonKho";
            this.grdTonKho.Size = new System.Drawing.Size(854, 346);
            this.grdTonKho.TabIndex = 7;
            this.grdTonKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTonKho});
            // 
            // gvTonKho
            // 
            this.gvTonKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaspid,
            this.colMakho,
            this.colTenkho,
            this.colMasp,
            this.colTensp,
            this.colDvt,
            this.colQuycach,
            this.colCuoiky});
            this.gvTonKho.GridControl = this.grdTonKho;
            this.gvTonKho.Name = "gvTonKho";
            this.gvTonKho.OptionsView.ShowGroupPanel = false;
            // 
            // colMaspid
            // 
            this.colMaspid.Caption = "Maspid";
            this.colMaspid.FieldName = "Maspid";
            this.colMaspid.Name = "colMaspid";
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
            this.colTenkho.Caption = "Kho";
            this.colTenkho.FieldName = "Tenkho";
            this.colTenkho.Name = "colTenkho";
            this.colTenkho.Visible = true;
            this.colTenkho.VisibleIndex = 1;
            // 
            // colMasp
            // 
            this.colMasp.Caption = "Mã hàng hóa";
            this.colMasp.FieldName = "Masp";
            this.colMasp.Name = "colMasp";
            this.colMasp.Visible = true;
            this.colMasp.VisibleIndex = 2;
            // 
            // colTensp
            // 
            this.colTensp.Caption = "Tên hàng hóa";
            this.colTensp.FieldName = "Tensp";
            this.colTensp.Name = "colTensp";
            this.colTensp.Visible = true;
            this.colTensp.VisibleIndex = 3;
            // 
            // colDvt
            // 
            this.colDvt.Caption = "Đơn vị tính";
            this.colDvt.FieldName = "Dvt";
            this.colDvt.Name = "colDvt";
            this.colDvt.Visible = true;
            this.colDvt.VisibleIndex = 4;
            // 
            // colQuycach
            // 
            this.colQuycach.Caption = "Quy cách";
            this.colQuycach.FieldName = "Quycach";
            this.colQuycach.Name = "colQuycach";
            this.colQuycach.Visible = true;
            this.colQuycach.VisibleIndex = 5;
            // 
            // colCuoiky
            // 
            this.colCuoiky.Caption = "Tồn kho";
            this.colCuoiky.DisplayFormat.FormatString = "n0";
            this.colCuoiky.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCuoiky.FieldName = "Cuoiky";
            this.colCuoiky.Name = "colCuoiky";
            this.colCuoiky.Visible = true;
            this.colCuoiky.VisibleIndex = 6;
            // 
            // dlg_TonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 428);
            this.Controls.Add(this.grdTonKho);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dlg_TonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tồn kho";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTonKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit1;
        private System.Windows.Forms.Button cmdAbort;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdDel;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdExit;
        private DevExpress.XtraGrid.GridControl grdTonKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTonKho;
        private DevExpress.XtraGrid.Columns.GridColumn colMaspid;
        private DevExpress.XtraGrid.Columns.GridColumn colMakho;
        private DevExpress.XtraGrid.Columns.GridColumn colTenkho;
        private DevExpress.XtraGrid.Columns.GridColumn colMasp;
        private DevExpress.XtraGrid.Columns.GridColumn colTensp;
        private DevExpress.XtraGrid.Columns.GridColumn colDvt;
        private DevExpress.XtraGrid.Columns.GridColumn colQuycach;
        private DevExpress.XtraGrid.Columns.GridColumn colCuoiky;
    }
}