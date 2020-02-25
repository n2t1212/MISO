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


namespace PosMiso
{
    public partial class MisoMain : XtraForm
    {
        public MisoMain()
        {
            InitializeComponent();
            InitMenuLeftComponent();
            InitMenuTopComponent();
            InitStatusBar();
            picLayout.Image = Image.FromFile(string.Format("../../Medias/Pictures/mtpos_bg.png"));
        }

        #region "MENU"
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
                    + "left join HT_NGUOIDUNG nd on nd.soid = qh.soid_nguoidung where nd.taikhoan ='{0}' and cn.muccon='left'", MTGlobal.MT_USER_LOGIN);
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
                        DM_ChucNang chucNang = new DM_ChucNang(id, code, name, root, icon);
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
                    navGrp.LargeImageIndex = 0;
                    navGrp.Name = grp.code;
                    navGrp.LargeImage = Image.FromFile(string.Format("../../Medias/Icons/{0}", grp.icon));

                    List<NavBarItemLink> itemLink = new List<NavBarItemLink>();
                    foreach (DM_ChucNang itm in items)
                    {
                        if (itm.root == grp.id)
                        {
                            NavBarItem navItm = new NavBarItem();
                            navItm.Caption = itm.name;
                            navItm.Name = itm.code;
                            navItm.SmallImage = Image.FromFile(string.Format("../../Medias/Icons/{0}", itm.icon));   
                            navItm.LinkClicked+=navItm_LinkClicked;
                            navItems.Add(navItm);
                            itemLink.Add(new NavBarItemLink(navItm));
                        }
                    }

                    navGrp.ItemLinks.AddRange(itemLink.ToArray());
                    navGroups.Add(navGrp);
                    
                }

                navBarControl.BeginInit();
                this.Controls.Add(navBarControl);
                navBarControl.Dock = System.Windows.Forms.DockStyle.Left;
                navBarControl.Groups.AddRange(navGroups.ToArray());
                navBarControl.Items.AddRange(navItems.ToArray());
  
                navBarControl.Location = new System.Drawing.Point(0, 0);
                navBarControl.Name = "navBarControl";
                navBarControl.OptionsNavPane.ExpandedWidth = 165;
                navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
                navBarControl.Size = new System.Drawing.Size(165, 520);
                navBarControl.StoreDefaultPaintStyleName = true;
                navBarControl.TabIndex = 1;
                navBarControl.Text = "navBarControl1";
                navBarControl.EndInit();
            }
            catch (Exception ex) { 
                Utils.showMessage("Không thể tải danh sách chức năng", "Lỗi"); 
            }

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
                    + "left join HT_NGUOIDUNG nd on nd.soid = qh.soid_nguoidung where nd.taikhoan ='{0}' and cn.muccon='top'", MTGlobal.MT_USER_LOGIN);
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
                        DM_ChucNang chucNang = new DM_ChucNang(id, code, name, root, icon);
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
                    menuGrp.Name = grp.code;
                    menuGrp.Size = new System.Drawing.Size(163, 22);
                    menuGrp.Text = grp.name;
                    menuGrp.Image = Image.FromFile(string.Format("../../Medias/Icons/{0}", grp.icon));

                    List<ToolStripMenuItem> menuItems = new List<ToolStripMenuItem>();
                    foreach (DM_ChucNang itm in items)
                    {
                        if (itm.root == grp.id)
                        {
                            ToolStripMenuItem menuItem = new ToolStripMenuItem();
                            menuItem.Name = itm.code;
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
        private void navItm_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var a = ((DevExpress.XtraNavBar.ComponentCollectionItem)(sender)).Name.ToString();
            if (a == "mnuDM_KHACHHANG")
            {
                if(!CheckFormOpening("Test")){
                    Test test = new Test();
                test.TopLevel = false;
                test.Visible = true;
                test.Dock = DockStyle.Fill;
                test.FormBorderStyle = FormBorderStyle.None;
                test.MdiParent = this;
                test.Show();
                }
                
            }
            else
            {
                if (!CheckFormOpening("Form1"))
                {
                    Form1 f1 = new Form1();
                    f1.TopLevel = false;
                    f1.Visible = true;
                    f1.Dock = DockStyle.Fill;
                    f1.FormBorderStyle = FormBorderStyle.None;
                    f1.MdiParent = this;
                    f1.Show();
                }
            }
            

        }

        void menuItem_Click(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
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