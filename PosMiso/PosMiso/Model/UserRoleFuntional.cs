using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosMiso.Model;
using System.Data;

namespace PosMiso.Model
{
    public static class UserRoleFuntional
    {
        #region "GET_ROLE_USER_MENU_FUNCTION"
        public static DataTable getRoleByFunctionID(String frmName)
        {
            String macn = "";
            DataTable oTblFunction = getFunctionByFormName(frmName);
            if (oTblFunction.Rows.Count == 1)
            {
                macn = oTblFunction.Rows[0]["macn"].ToString();
            }

            if (macn == null || macn == "")
            {
                return new DataTable();
            }

            String mSql = String.Format("SELECT NQCN.* FROM HT_NHOMQUYEN_CHUCNANG NQCN LEFT JOIN HT_NHOMQUYEN NQ ON NQCN.manhom = NQ.soid "
            + "LEFT JOIN HT_QUYENHAN QH ON QH.soid_nhomquyen = NQ.soid LEFT JOIN HT_NGUOIDUNG ND on ND.soid = QH.soid_nguoidung "
            + "where NQCN.macn = '{0}' and ND.taikhoan = '{1}'", macn, MTGlobal.MT_USER_LOGIN);

            DataTable oTblRole = new MTSQLServer().wRead(mSql, null, false);

            return oTblRole;
        }

        public static DataTable getFunctionByFormName(String frmName)
        {
            String mSql = String.Format("SELECT * FROM DM_CHUCNANG WHERE tenform = '{0}'", frmName);

            DataTable oTblFunction = new MTSQLServer().wRead(mSql, null, false);
            return oTblFunction;
        }
        #endregion
    }
}
