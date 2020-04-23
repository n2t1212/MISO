using PosMiso.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosMiso.View
{
    public partial class dlg_AddQuyenHan : Form
    {
        SqlDataAdapter SQLAdaptor = null;
        DataSet DSetMain = null;
        private string nhomQuyenId = "";
        private DataTable tblSrc = null;
        private DataTable tblNQCN = null;
        private DataTable tblSelected = null;
        private String removeFunctionIds = "";

        private List<FunctionNode> trees;
        private List<FunctionNode> selectedNode = new List<FunctionNode>();

        public dlg_AddQuyenHan()
        {
            InitializeComponent();
        }

        public dlg_AddQuyenHan(string nhomQuyenId)
        {
            InitializeComponent();
            this.nhomQuyenId = nhomQuyenId;
            InitTableSelected();
            InitTableNhomQuyenChucNang();
            loadGridChucNang();

            //MTGlobal.SetFormatGridControl(grdChucNang, tblChucNang);
            //MTGlobal.SetFormatGridControl(grdNhomQuyenChucNang, tblNhomQuyenChucNang);
            //tblChucNang.MultiSelectMode = DevExpress.Xpf.Grid.TableViewSelectMode.Row;
            //tblNhomQuyenChucNang.MultiSelectMode = DevExpress.Xpf.Grid.TableViewSelectMode.Row;
            //MTGlobal.SetGridReadOnly(grdNhomQuyenChucNang, tblNhomQuyenChucNang, false);
        }

        private void dlg_AddQuyenHan_Load(object sender, EventArgs e)
        {
            loadTreeViewChucNang();
        }

        private void loadTreeViewChucNang()
        {
            initTreeViewChucNang();
        }

        private void initTreeViewChucNang()
        {
            // get parent
            trees = initParents();

            // get childs
            initChildForParent();

            initTree();
        }

        private void initTree()
        {
            if (trees != null)
            {
                tvChucNang.Nodes.Clear();
                trees.Sort(comparasionNode);
                foreach(FunctionNode parent in trees)
                {
                    TreeNode node = new TreeNode();
                    node.Name = parent.macn;
                    node.Text = parent.chucnang;
                    foreach (FunctionNode child in parent.child)
                    {
                        TreeNode childNode = new TreeNode();
                        childNode.Name = child.macn;
                        childNode.Text = child.chucnang;
                        node.Nodes.Add(childNode);
                    }
                    tvChucNang.Nodes.Add(node);
                }   
            }
        }

        #region "GET_DATA"
        private List<FunctionNode> initParents()
        {
            string sql = string.Format("select cn.* from DM_CHUCNANG cn " +
                                        "where (cn.macn not in (select nqcn.macn " +
					                                           "from HT_NHOMQUYEN_CHUCNANG nqcn "  +
					                                           "where nqcn.manhom = '{0}') " +
                                                "or cn.macn in (select distinct a.macnroot " +
					                                           "from DM_CHUCNANG a " +
					                                           "where a.macnroot is not null " +
					                                                 "and a.macn not in (select nqcn.macn " +
					                                                                    "from HT_NHOMQUYEN_CHUCNANG nqcn " +
					                                                                   " where nqcn.manhom = '{0}'))) " +
		                                        "and macnroot is null", this.nhomQuyenId);

            if (removeFunctionIds != "")
            {
                sql = string.Format("select cn.* from DM_CHUCNANG cn " +
                                        "where (cn.macn not in (select nqcn.macn " +
                                                               "from HT_NHOMQUYEN_CHUCNANG nqcn " +
                                                               "where nqcn.manhom = '{0}') " +
                                                "or cn.macn in (select distinct a.macnroot " +
                                                               "from DM_CHUCNANG a " +
                                                               "where a.macnroot is not null " +
                                                                     "and a.macn not in (select nqcn.macn " +
                                                                                        "from HT_NHOMQUYEN_CHUCNANG nqcn " +
                                                                                       " where nqcn.manhom = '{0}'))) " +
                                                "or cn.macn in ({1}) and macnroot is null", this.nhomQuyenId, removeFunctionIds);
                //sql = string.Format("select cn.* from DM_CHUCNANG cn where cn.macn not in (select nqcn.macn from HT_NHOMQUYEN_CHUCNANG nqcn where nqcn.manhom = '{0}') or cn.macn in ({1}) and macnroot is null", this.nhomQuyenId, removeFunctionIds);
            }

            SQLAdaptor = MTSQLServer.getMTSQLServer().wAdapter(sql, null, false);
            DSetMain = new DataSet();
            SQLAdaptor.Fill(DSetMain, "DM_CHUCNANG");
            DataTable dt = DSetMain.Tables["DM_CHUCNANG"];

            List<FunctionNode> parents = new List<FunctionNode>();
            foreach (DataRow rw in dt.Rows)
            {
                FunctionNode parent = new FunctionNode();
                parent.macn = rw["macn"].ToString();
                parent.chucnang = rw["chucnang"].ToString();
                parents.Add(parent);
            }
            return parents;
        }

        private void initChildForParent()
        {
            string sql = string.Format("select cn.* from DM_CHUCNANG cn where cn.macn not in (select nqcn.macn from HT_NHOMQUYEN_CHUCNANG nqcn where nqcn.manhom = '{0}') and macnroot is not null", this.nhomQuyenId);

            if (removeFunctionIds != "")
            {
                sql = string.Format("select cn.* from DM_CHUCNANG cn where cn.macn not in (select nqcn.macn from HT_NHOMQUYEN_CHUCNANG nqcn where nqcn.manhom = '{0}') or cn.macn in ({1}) and macnroot is not null", this.nhomQuyenId, removeFunctionIds);
            }

            SQLAdaptor = MTSQLServer.getMTSQLServer().wAdapter(sql, null, false);
            DSetMain = new DataSet();
            SQLAdaptor.Fill(DSetMain, "DM_CHUCNANG");
            DataTable dt = DSetMain.Tables["DM_CHUCNANG"];

            foreach (FunctionNode parent in trees)
            {
                getChildsForParent(parent, dt);  
            }
        }

        private void getChildsForParent(FunctionNode parent, DataTable dt)
        {
            string macn = parent.macn;
            foreach (DataRow rw in dt.Rows)
            {
                if (macn == rw["macnroot"].ToString())
                {
                    FunctionNode child = new FunctionNode();
                    child.macn = rw["macn"].ToString();
                    child.chucnang = rw["chucnang"].ToString();
                    parent.child.Add(child);
                }
            }
        }
        #endregion


        #region "INIT_DT"
        private void InitTableSelected()
        {
            tblSelected = new DataTable();
            tblSelected.Columns.Add("soid", typeof(string));
            tblSelected.Columns.Add("macn", typeof(string));
            tblSelected.Columns.Add("tencn", typeof(string));
            tblSelected.Columns.Add("them", typeof(bool));
            tblSelected.Columns.Add("sua", typeof(bool));
            tblSelected.Columns.Add("xoa", typeof(bool));
            tblSelected.Columns.Add("duyet", typeof(bool));
            tblSelected.Columns.Add("in", typeof(bool));
        }

        private void InitTableNhomQuyenChucNang()
        {
            tblNQCN = new DataTable();
            tblNQCN.Columns.Add("soid", typeof(string));
            tblNQCN.Columns.Add("manhom", typeof(string));
            tblNQCN.Columns.Add("macn", typeof(string));
            tblNQCN.Columns.Add("them", typeof(int));
            tblNQCN.Columns.Add("sua", typeof(int));
            tblNQCN.Columns.Add("xoa", typeof(int));
            tblNQCN.Columns.Add("duyet", typeof(int));
            tblNQCN.Columns.Add("in", typeof(int));
            tblNQCN.Columns.Add("nguoilap", typeof(string));
            tblNQCN.Columns.Add("ngaylap", typeof(DateTime));
            tblNQCN.Columns.Add("nguoisua", typeof(string));
            tblNQCN.Columns.Add("ngaysua", typeof(DateTime));
        }
        #endregion

        private void cmdAppExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            resetTreeAfterSelect();

            foreach (FunctionNode node in selectedNode)
            {
                DataRow rw = tblSelected.NewRow();
                rw["soid"] = MTGlobal.GetNewID();
                rw["macn"] = node.macn;
                rw["tencn"] = node.chucnang;
                rw["them"] = true;
                rw["sua"] = true;
                rw["xoa"] = true;
                rw["duyet"] = true;
                rw["in"] = true;
                tblSelected.Rows.Add(rw);
            }
            grdChucNang.DataSource = tblSelected;
            selectedNode.Clear();
        }

        private void loadGridChucNang()
        {
            String mSql = mSql = String.Format("select nqcn.soid as soid, nqcn.macn as macn, cn.chucnang as tencn, " +
                                                 "nqcn.them as them, nqcn.xoa as xoa, nqcn.sua as sua, nqcn.duyet as duyet, nqcn.[in] as [in]" +
                                                  " from HT_NHOMQUYEN_CHUCNANG nqcn left join DM_CHUCNANG cn on cn.macn = nqcn.macn" +
                                                  " where nqcn.manhom='{0}' order by manhom asc", nhomQuyenId);
            tblSelected = MTSQLServer.getMTSQLServer().wRead(mSql, null, false);
            grdChucNang.DataSource = tblSelected;
        }

        private void FindCheckedNodes(List<TreeNode> checked_nodes, TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Checked) checked_nodes.Add(node);

                FindCheckedNodes(checked_nodes, node.Nodes);
            }
        }

        private List<TreeNode> CheckedNodes(TreeView trv)
        {
            List<TreeNode> checked_nodes = new List<TreeNode>();
            FindCheckedNodes(checked_nodes, tvChucNang.Nodes);
            return checked_nodes;
        }

        private void resetTreeAfterSelect()
        {
            List<TreeNode> checked_nodes = CheckedNodes(tvChucNang);

            foreach (TreeNode node in checked_nodes)
            {
                string macn = node.Name;
                resetTreeNodeData(macn);
            }

            initTree();
        }

        private void resetTreeNodeData(string macn)
        {
            bool isChild = false;
            foreach (FunctionNode parent in trees)
            {
                if (parent.macn == macn)
                {
                    selectedNode.Add(parent);
                    if (parent.child.Count == 0)
                    {
                        trees.Remove(parent);
                    }
                   
                    break;
                }
                FunctionNode newParent = parent;
                foreach (FunctionNode child in parent.child)
                {
                    if (child.macn == macn)
                    {
                        selectedNode.Add(child);
                        newParent.child.Remove(child);
                        isChild = true;
                        break;
                    }
                }

                if (isChild)
                {
                    trees.Remove(parent);
                    if (newParent.child.Count > 0)
                    {
                        trees.Add(newParent);
                    }
                    else
                    {
                        selectedNode.Add(newParent);
                    }
                    break;
                }
            }
        }
        
        private static int comparasionNode(FunctionNode node1, FunctionNode node2)
        {
            if (node1 == null)
            {
                if (node2 == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (node2 == null)
                {
                    return 1;
                }
                else
                {
                    return node1.chucnang.CompareTo(node2.chucnang);
                }
            }
        }

        #region "CHECK_TREEVIEW"
        private void tvChucNang_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }

            SelectParents(e.Node, e.Node.Checked);
        }

        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;

                if (node.Nodes.Count > 0)
                {
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }
        private void SelectParents(TreeNode node, Boolean isChecked)
        {
            var parent = node.Parent;

            if (parent == null)
                return;

            if (!isChecked && HasCheckedNode(parent))
                return;

            parent.Checked = isChecked;
            SelectParents(parent, isChecked);
        }

        private bool HasCheckedNode(TreeNode node)
        {
            return node.Nodes.Cast<TreeNode>().Any(n => n.Checked);
        }

        #endregion

        private void convertTableSelectedToTableNQCN()
        {
            int loop = 0;
            foreach (DataRow rw in tblSelected.Rows)
            {
                DataRow row = tblNQCN.NewRow();
                row["soid"] = MTGlobal.GetNewID() + loop;
                row["manhom"] = nhomQuyenId;
                row["macn"] = rw["macn"];
                row["them"] = rw["them"];
                row["sua"] = rw["sua"];
                row["xoa"] = rw["xoa"];
                row["duyet"] = rw["duyet"];
                row["in"] = rw["in"];
                row["nguoilap"] = MTGlobal.MT_USER_LOGIN;
                row["ngaylap"] = DateTime.Now;

                tblNQCN.Rows.Add(row);
                loop++;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (tblSelected.Rows.Count == 0)
            {
                Utils.showMessage("Vui lòng chọn chức năng", "Thông báo", "MSG");
                return;
            }

            this.convertTableSelectedToTableNQCN();

            try
            {
                String sql = String.Format("DELETE HT_NHOMQUYEN_CHUCNANG where manhom = '{0}'", nhomQuyenId);
                int result = MTSQLServer.getMTSQLServer().wExec(sql, null, false);          

                SqlParameter[] arrPara = new SqlParameter[3];
                arrPara[0] = new SqlParameter("@nhomQuyenChucNangTbl", SqlDbType.Structured);
                arrPara[0].Value = tblNQCN;
                arrPara[1] = new SqlParameter("@nguoidung", SqlDbType.NVarChar, 50);
                arrPara[1].Value = MTGlobal.MT_USER_LOGIN;
                arrPara[2] = new SqlParameter("@ketqua", SqlDbType.NVarChar, 255);
                arrPara[2].Direction = ParameterDirection.Output;

                int iRs = MTSQLServer.getMTSQLServer().wExec("spHT_AddNhomQuyenChucNang", arrPara);

                if (iRs == -1)
                {
                    Utils.showMessage("Dữ liệu không thể cập nhật. Vui lòng kiểm tra lại.", "Thông báo");
                    //return;
                }
                else
                {
                    Utils.showMessage("Dữ liệu cập nhật thành công.", "Thông báo");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Utils.showMessage("Lỗi kết nối cơ sở dữ liệu", "Thông báo");
                return;
            }
        }

        private void cmdAddAll_Click(object sender, EventArgs e)
        {
            foreach (FunctionNode node in trees)
            {
                DataRow rw = tblSelected.NewRow();
                rw["soid"] = MTGlobal.GetNewID();
                rw["macn"] = node.macn;
                rw["tencn"] = node.chucnang;
                rw["them"] = true;
                rw["sua"] = true;
                rw["xoa"] = true;
                rw["duyet"] = true;
                rw["in"] = true;
                tblSelected.Rows.Add(rw);

                foreach (FunctionNode child in node.child)
                {
                    DataRow rw1 = tblSelected.NewRow();
                    rw1["soid"] = MTGlobal.GetNewID();
                    rw1["macn"] = child.macn;
                    rw1["tencn"] = child.chucnang;
                    rw1["them"] = true;
                    rw1["sua"] = true;
                    rw1["xoa"] = true;
                    rw1["duyet"] = true;
                    rw1["in"] = true;
                    tblSelected.Rows.Add(rw1);
                }
            }
            grdChucNang.DataSource = tblSelected;
            trees.Clear();
            initTree();
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            List<DataRow> selectedList = new List<DataRow>();
            foreach (int i in gvChucNang.GetSelectedRows())
            {
                DataRow row = gvChucNang.GetDataRow(i);
                selectedList.Add(row);
            }

            string macn = "";
            foreach(DataRow row in selectedList)
            {
                macn = row["macn"].ToString();
                addNodeToTree(macn);
                tblSelected.Rows.Remove(row);
            }

            tblSelected.AcceptChanges();
            grdChucNang.DataSource = tblSelected;
            grdChucNang.RefreshDataSource();


        }

        private void addNodeToTree(string macn)
        {
            DataRow row = getChucNangByCode(macn);

            // parent node
            if (row != null && row["macnroot"].ToString() == "")
            {
                if (getParentNode(macn) == null)
                {
                    FunctionNode node = new FunctionNode();
                    node.macn = row["macn"].ToString();
                    node.chucnang = row["chucnang"].ToString();
                    trees.Add(node);
                    initTree();
                }
                return;
                
            }
            //child node
            FunctionNode child = new FunctionNode();
            child.macn = row["macn"].ToString();
            child.chucnang = row["chucnang"].ToString();

            string parentCode = row["macnroot"].ToString();

            FunctionNode parent = getParentNode(parentCode);
            if (parent != null)
            {
                FunctionNode newParent = parent;
                newParent.child.Add(child);
                trees.Remove(parent);
                trees.Add(newParent);
            }
            else
            {
                DataRow row1 = getChucNangByCode(parentCode);
                if (row1 != null)
                {
                    FunctionNode parent1 = new FunctionNode();
                    parent1.macn = row1["macn"].ToString();
                    parent1.chucnang = row1["chucnang"].ToString();
                    parent1.child.Add(child);
                    trees.Add(parent1);
                }
                
            }

            initTree();
            
        }

        private DataRow getChucNangByCode(string macn)
        {
            if (macn == "")
            {
                return null;
            }
            string sql = string.Format("select cn.* from DM_CHUCNANG cn where cn.macn ='{0}'", macn);
            SQLAdaptor = MTSQLServer.getMTSQLServer().wAdapter(sql, null, false);
            DSetMain = new DataSet();
            SQLAdaptor.Fill(DSetMain, "DM_CHUCNANG");
            DataTable dt = DSetMain.Tables["DM_CHUCNANG"];

            if (dt.Rows.Count < 0)
            {
                return null;
            }
            return dt.Rows[0];
        }

        private FunctionNode getParentNode(string macn)
        {
            foreach (FunctionNode node in trees)
            {
                if (node.macn == macn)
                {
                    return node;
                }
            }
            return null;
        }

        private void cmdRemoveAll_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataRow row in tblSelected.Rows)
            {
                if (count == 0)
                {
                    removeFunctionIds += String.Format("'{0}'", row["macn"].ToString());
                }
                else
                {
                    removeFunctionIds += String.Format(",'{0}'", row["macn"].ToString());
                }
                count++;
            }
            tblSelected.Clear();
            grdChucNang.DataSource = tblSelected;
            initTreeViewChucNang();
        }
    }

    

    #region "DEF_TREE_OBJ"
    public class FunctionNode
    {
        public string macn { get; set; }
        public string chucnang { get; set; }
        public List<FunctionNode> child { get; set; }

        public FunctionNode()
        {
            child = new List<FunctionNode>();
        }
    }
    #endregion
}
