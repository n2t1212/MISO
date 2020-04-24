using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraNavBar;
using PosMiso.Model;
using DevExpress.XtraGrid.Columns;
using PosMiso.View;
using DevExpress.XtraTabbedMdi;
using System.Reflection;


namespace PosMiso
{
    public partial class MisoMain : XtraForm
    {
        public MisoMain()
        {
            InitializeComponent();
            InitMenuTopComponent();
            InitMenuLeftComponent();
            InitStatusBar();
        }

        #region "MENU"
        public bool ThumbnailCallback()
        {
            return false;
        }

        private void InitMenuLeftComponent()
        {
            List<NavBarGroup> navGroups = new List<NavBarGroup>();
            List<NavBarItem> navItems = new List<NavBarItem>();
            List<DM_ChucNang> groups = new List<DM_ChucNang>();
            List<DM_ChucNang> items = new List<DM_ChucNang>();

            try
            {
                string mSQL = string.Format("select cn.* from DM_CHUCNANG cn left join HT_NHOMQUYEN_CHUCNANG nqcn on nqcn.macn = cn.macn " 
                    + "left join HT_NHOMQUYEN nq on nq.soid = nqcn.manhom left join HT_QUYENHAN qh on qh.soid_nhomquyen = nq.soid " 
                    + "left join HT_NGUOIDUNG nd on nd.soid = qh.soid_nguoidung where nd.taikhoan ='{0}' "
                    + "and cn.muccon='left'"
                    , MTGlobal.MT_USER_LOGIN);
                DataTable otblMenu = MTSQLServer.getMTSQLServer().wRead(mSQL, null, false);
                if (otblMenu != null)
                {
                    foreach (DataRow MnuR in otblMenu.Rows)
                    {
                        String id = (MnuR["macn"].ToString());
                        String code =  (MnuR["kyhieu"].ToString());
                        String name = (MnuR["chucnang"].ToString());
                        String root = (MnuR["macnroot"].ToString());
                        String icon = (MnuR["icon"].ToString());
                        String formName = (MnuR["tenform"].ToString());
                        DM_ChucNang chucNang = new DM_ChucNang(id, code, name, root, icon, formName);
                        if (root == "")
                        {
                            groups.Add(chucNang);
                        }
                        else
                        {
                            items.Add(chucNang);
                        }
                    }
                }

                foreach(DM_ChucNang grp in groups){
                    NavBarGroup navGrp = new NavBarGroup();
                    navGrp.Caption = grp.name;
                    navGrp.Expanded = true;
                    navGrp.Name = grp.formName;
                    Image icon = Image.FromFile(string.Format("../../Medias/Icons/{0}", grp.icon));
                    Image.GetThumbnailImageAbort callback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                    icon = icon.GetThumbnailImage(20, 20, callback, IntPtr.Zero);
                    navGrp.SmallImage = icon;

                    List<NavBarItemLink> itemLink = new List<NavBarItemLink>();
                    foreach (DM_ChucNang itm in items)
                    {
                        if (itm.root == grp.id)
                        {
                            NavBarItem navItm = new NavBarItem();
                            navItm.Caption = itm.name;
                            navItm.Name = itm.formName;
                            Image icon1 = Image.FromFile(string.Format("../../Medias/Icons/{0}", itm.icon));
                            Image.GetThumbnailImageAbort callback1 = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                            icon1 = icon1.GetThumbnailImage(20, 20, callback, IntPtr.Zero);
                            navItm.SmallImage = icon1;
                            navItm.LinkClicked += navItm_LinkClicked;
                            navItems.Add(navItm);
                            itemLink.Add(new NavBarItemLink(navItm));
                        }
                    }

                    navGrp.ItemLinks.AddRange(itemLink.ToArray());
                    navGroups.Add(navGrp);
                    
                }

                navBarControl.BeginInit();
                panelMenuLeft.Controls.Add(navBarControl);
                navBarControl.Dock = System.Windows.Forms.DockStyle.Left;
                navBarControl.Groups.AddRange(navGroups.ToArray());
                navBarControl.Items.AddRange(navItems.ToArray());
  
                navBarControl.Location = new System.Drawing.Point(0, 0);
                navBarControl.Name = "navBarControl";
                navBarControl.OptionsNavPane.ExpandedWidth = 165;
                navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
                navBarControl.Size = new System.Drawing.Size(200, 520);
                navBarControl.StoreDefaultPaintStyleName = true;
                navBarControl.TabIndex = 1;
                navBarControl.Text = "navBarControl1";
                navBarControl.EndInit();
            }
            catch (Exception ex) { 
                Utils.showMessage("Không thể tải danh sách chức năng", "Lỗi"); 
            }

        }

        void navItm_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            OpenForm(e.Link.ItemName.ToString(), e.Link.Caption.ToString());
        }

        private void InitMenuTopComponent()
        {
            List<ToolStripMenuItem> groupMenus = new List<ToolStripMenuItem>();
            List<DM_ChucNang> groups = new List<DM_ChucNang>();
            List<DM_ChucNang> items = new List<DM_ChucNang>();

            menuTop.Dock = System.Windows.Forms.DockStyle.Top;
            try
            {
                string mSQL = string.Format("select cn.* from DM_CHUCNANG cn left join HT_NHOMQUYEN_CHUCNANG nqcn on nqcn.macn = cn.macn "
                    + "left join HT_NHOMQUYEN nq on nq.soid = nqcn.manhom left join HT_QUYENHAN qh on qh.soid_nhomquyen = nq.soid "
                    + "left join HT_NGUOIDUNG nd on nd.soid = qh.soid_nguoidung where nd.taikhoan ='{0}' "
                    + "and cn.muccon='top'"
                    , MTGlobal.MT_USER_LOGIN);
                DataTable otblMenu = MTSQLServer.getMTSQLServer().wRead(mSQL, null, false);
                if (otblMenu != null)
                {
                    foreach (DataRow MnuR in otblMenu.Rows)
                    {
                        String id = (MnuR["macn"].ToString());
                        String code = (MnuR["kyhieu"].ToString());
                        String name = (MnuR["chucnang"].ToString());
                        String root = (MnuR["macnroot"].ToString());
                        String icon = (MnuR["icon"].ToString());
                        String formName = (MnuR["tenform"].ToString());
                        DM_ChucNang chucNang = new DM_ChucNang(id, code, name, root, icon, formName);
                        if (root == "")
                        {
                            groups.Add(chucNang);
                        }
                        else
                        {
                            items.Add(chucNang);
                        }
                    }
                }

                foreach (DM_ChucNang grp in groups)
                {
                    ToolStripMenuItem menuGrp = new ToolStripMenuItem();
                    menuGrp.Name = grp.formName;
                    menuGrp.Size = new System.Drawing.Size(163, 22);
                    menuGrp.Text = grp.name;
                    menuGrp.Image = Image.FromFile(string.Format("../../Medias/Icons/{0}", grp.icon));
                    menuGrp.Click += menuGrp_Click;

                    List<ToolStripMenuItem> menuItems = new List<ToolStripMenuItem>();
                    foreach (DM_ChucNang itm in items)
                    {
                        if (itm.root == grp.id)
                        {
                            ToolStripMenuItem menuItem = new ToolStripMenuItem();
                            menuItem.Name = itm.formName;
                            menuItem.Size = new System.Drawing.Size(163, 22);
                            menuItem.Text = itm.name;
                            menuItem.Image = Image.FromFile(string.Format("../../Medias/Icons/{0}", itm.icon));
                            menuItem.Click += menuItem_Click;
                            menuItems.Add(menuItem);
                        }
                    }

                    menuGrp.DropDownItems.AddRange(menuItems.ToArray());
                    groupMenus.Add(menuGrp);
                }

                menuTop.Items.AddRange(groupMenus.ToArray());
            }
            catch (Exception ex)
            {
                Utils.showMessage("Không thể tải danh sách chức năng", "Lỗi");
            }
            
        }

        private void menuGrp_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            String frmName = menuItem.Name;
            String description = menuItem.Text;

            // handle system functionality if any (OpenForm function won't be called)
            handleSystemFuntionality(frmName);

            OpenForm(frmName, description);
        }

        private void handleSystemFuntionality(String frmName)
        {
            if (frmName == "HT_Thoat")
            {
                this.Close();
            }

            if (frmName == "HT_ThongTin")
            {
                HT_Register frm = new HT_Register();
                frm.ShowDialog();
                return;
            }

            if (frmName == "HT_ChuyenSoDu")
            {
                if (Utils.ChonThoiGian(false, true, false))
                {
                    MTGlobal.Ketchuyensodu();
                }
                return;
            }
        }

        void menuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            String frmName = menuItem.Name;
            String description = menuItem.Text;

            if (frmName == "HT_Thoat")
            {
                this.Close();
            }

            OpenForm(frmName, description);
        }
        #endregion

        #region "STATUSBAR"
        System.Windows.Forms.Timer tmr = null;
        private void InitStatusBar()
        {
            serverName.Text = "Máy chủ: " + MTGlobal.MT_DBHost;
            dbName.Text = "Tên CSDL: " + MTGlobal.MT_DBNAME;
            userName.Text = "Tên người dùng: " + MTGlobal.MT_USER_LOGIN;
            lblActive.Text = MTGlobal.HT_POS_ACTIVE;

            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            systemTime.Text = DateTime.Now.ToString();
        }
        #endregion

        #region "ITEM-CLICKED"
        Cursor currentCursor;
        private void RefreshForm(bool b)
        {
            if (b)
            {
                currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                Refresh();
            }
            else
                Cursor.Current = currentCursor;
        }

        private void handleRenderForm(bool isMdiParent, Type obj, string frmName = "", string mCaption = "", string mPermit = "")
        {
            Form frm = Activator.CreateInstance(obj) as Form;
            frm.Name = frmName;
            frm.Text = mCaption.Replace("&", " ");
            frm.Tag = mPermit;

            if (isMdiParent)
            {
                frm.MdiParent = this;
            }
            
            frm.Show();
        }

        private void OpenForm(string frmName = "", string mCaption = "")
        {
            if (frmName == "")
                return;
            try
            {
                string mPermit = "", mOptTime = "", mOptEnable = "";            

                RefreshForm(true);
                if (!CheckFormOpening(frmName))
                {
                    Type obj = Assembly.GetExecutingAssembly().GetType("PosMiso.View." + frmName);
                    if (obj != null)
                    {
                        if (Utils.isUsingDateForm(frmName))
                        {
                            if (Utils.ChonThoiGian())
                            {
                                if (frmName == "BH_PhieuBH")
                                {
                                    MTGlobal.MT_LOAIP = MTGlobal.BH;
                                    if (Utils.ChonQuay(MTGlobal.BH))
                                    {
                                        handleRenderForm(true, obj, frmName, mCaption, mPermit);
                                    }
                                }
                                else
                                {
                                    handleRenderForm(true, obj, frmName, mCaption, mPermit);
                                }
                            }
                        }
                        else
                        {
                            bool isMdiParent = Utils.isMdiParent(frmName);
                            handleRenderForm(isMdiParent, obj, frmName, mCaption, mPermit);
                        }
                    }
                }
                RefreshForm(false);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region "PAGE_RENDER"
        private void xtraTabbedMdiManager1_PageAdded(object sender, MdiTabPageEventArgs e)
        {
            picLayout.SendToBack();
        }

        private void xtraTabbedMdiManager1_PageRemoved(object sender, MdiTabPageEventArgs e)
        {
            try
            {
                if (tabMDI.Pages.Count <= 0)
                {
                    picLayout.BringToFront();
                }
            }
            catch
            {
                picLayout.SendToBack();
            }
        }
        #endregion

        private bool CheckFormOpening(string frmName = "")
        {
            try
            {
                for (int i = 0; i <= this.tabMDI.Pages.Count; i++)
                {
                    if (this.tabMDI.Pages[i].MdiChild.Name == frmName)
                    {
                        this.tabMDI.Pages[i].MdiChild.Focus();
                        return true;
                    }
                }
                return false;
            }
            catch { return false; }

        }
        

    }
}