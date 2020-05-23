using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosMiso.Model
{
    class SysPar
    {
        public static string MT_Cnnstr { get; set; }
        public static SqlConnection MT_Cnn;

        public static int MT_BARCODE_COPYNO = 6;
        public static int MT_QR_MARGIN_LEFT = 30;
        public static int MT_QR_MARGIN_RIGHT = 30;
        public static int MT_QR_MARGIN_TOP = 15;
        public static int MT_QR_MARGIN_BOTTON = 15;

        public static int MT_BC_MARGIN_LEFT = 30;
        public static int MT_BC_MARGIN_RIGHT = 30;
        public static int MT_BC_MARGIN_TOP = 15;
        public static int MT_BC_MARGIN_BOTTON = 15;

        public static String MT_DEFAULT_TYPE = "QR";
        public static int MT_DEFAUL_TEM_ROW = 3; 

        public static void SetFormatGridControl(DevExpress.XtraGrid.GridControl oGrid, DevExpress.XtraGrid.Views.Grid.GridView View,bool isFilterRow=true)
        {
            try
            {
                View.OptionsNavigation.EnterMoveNextColumn = true;
                View.OptionsSelection.MultiSelect = true;
                View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
                View.ColumnPanelRowHeight =35;
                View.RowHeight = 30;
                View.ViewCaptionHeight = 32;
                View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
                //View.OptionsSelection.InvertSelection=true;
                //View.GridControl.LookAndFeel.UseDefaultLookAndFeel=false;
                View.OptionsNavigation.AutoFocusNewRow = true;
                View.OptionsView.ShowAutoFilterRow = isFilterRow;
                View.OptionsView.ShowGroupPanel = false; 
                View.FixedLineWidth = 3;
                View.OptionsView.ColumnAutoWidth = false;
            }
            catch { }
        }

        public static bool SetGridReadOnly(bool isReadOnly, DevExpress.XtraGrid.Views.Grid.GridView View)
        {
            try
            {
                for (int i = 0; i < View.Columns.Count; i++)
                {
                    try
                    {
                        View.Columns[i].OptionsColumn.AllowEdit = !isReadOnly;
                        View.Columns[i].OptionsColumn.ReadOnly = isReadOnly;
                    }
                    catch { return false; }
                }
            }
            catch { return false; }
            return true;
        }
    }
}
