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


namespace PosMiso
{
    public partial class MisoMain : XtraForm
    {
        public MisoMain()
        {
            InitializeComponent();
            InitMenuLeftComponent();
            //InitMenuTopComponent();
            InitStatusBar();
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
                splitContainerControl.Panel1.Controls.Add(navBarControl);
                //navBarControl.ActiveGroup = a;
                navBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
                navBarControl.Groups.AddRange(navGroups.ToArray());
                navBarControl.Items.AddRange(navItems.ToArray());
                navBarControl.LargeImages = navbarImageListLarge;
                navBarControl.Location = new System.Drawing.Point(0, 0);
                navBarControl.Name = "navBarControl";
                navBarControl.OptionsNavPane.ExpandedWidth = 165;
                navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
                navBarControl.Size = new System.Drawing.Size(165, 520);
                navBarControl.SmallImages = navbarImageList;
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
            MenuStrip MainMenu = new MenuStrip();
            MainMenu.BackColor = Color.OrangeRed;
            MainMenu.ForeColor = Color.Black;
            MainMenu.Text = "File Menu";
            MainMenu.Font = new Font("Georgia", 16);
            this.MainMenuStrip = MainMenu;
            Controls.Add(MainMenu);
        }
        #endregion

        #region "ITEM-CLICKED"
        private void navItm_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            // Ký hiệu của menu
            string code = ((DevExpress.XtraNavBar.NavElement)(sender)).Name.ToString();

            //gridView1.Columns.Clear();

            //GridColumn col=new GridColumn();
            //col.Caption = "Họ";
            //col.FieldName = "FirstName";
            //col.Visible = true;
            //gridView1.Columns.Add(col);

            //GridColumn col1 = new GridColumn();
            //col1.Caption = "Tên";
            //col1.FieldName = "SecondName";
            //col1.Visible = true;
            //gridView1.Columns.Add(col1);

            //GridColumn col2 = new GridColumn();
            //col2.Caption = "Comment";
            //col2.FieldName = "Commments";
            //col2.Visible = true;
            //gridView1.Columns.Add(col2);

            //BindingList<Person> gridDataList = new BindingList<Person>();
            //gridDataList.Add(new Person("John", "Smith"));
            //gridDataList.Add(new Person("Gabriel", "Smith"));
            //gridDataList.Add(new Person("Ashley", "Smith", "some comment"));
            //gridDataList.Add(new Person("Adrian", "Smith", "some comment"));
            //gridDataList.Add(new Person("Gabriella", "Smith", "some comment"));
            //gridControl.DataSource = gridDataList;
        }
        #endregion

        #region "STATUSBAR"
        System.Windows.Forms.Timer tmr = null;
        private void InitStatusBar()
        {
            serverName.Caption = "Máy chủ: " + MTGlobal.MT_DBHost;
            dbName.Caption = "Tên CSDL: " + MTGlobal.MT_DBNAME;
            userName.Caption = "Tên người dùng: " + MTGlobal.MT_USER_LOGIN;
            lblActive.Caption = MTGlobal.HT_POS_ACTIVE;

            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;    
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            systemTime.Caption = DateTime.Now.ToString();
        }
        #endregion

    }
}