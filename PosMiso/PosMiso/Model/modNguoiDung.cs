using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosMiso.Model
{
    class modNguoiDung
    {
        public modNguoiDung() { }

        public DataTable dtNguoiDung()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("soid", typeof(String));
            dt.Columns.Add("manv", typeof(String));
            dt.Columns.Add("taikhoan", typeof(String));
	        dt.Columns.Add("matkhau", typeof(String));
            dt.Columns.Add("hoten", typeof(String));
            dt.Columns.Add("nguoilap", typeof(String));
            dt.Columns.Add("ngaylap", typeof(DateTime));
            dt.Columns.Add("nguoisua", typeof(String));
            dt.Columns.Add("ngaysua", typeof(DateTime));
            dt.Columns.Add("ngaysync", typeof(DateTime));
            dt.Columns.Add("isync", typeof(int));
            dt.Columns.Add("kyhieu", typeof(String));
            return dt;
        }

        public string SaveNguoiDung(System.Data.DataTable otblND, String mNguoiDung, String mMaNhomQuyen)
        {
            try
            {
                SqlParameter[] arrPara = new SqlParameter[3];
                arrPara[0] = new SqlParameter("@nguoidungDT", SqlDbType.Structured);
                arrPara[0].Value = otblND;
                arrPara[1] = new SqlParameter("@nguoidung", SqlDbType.NVarChar, 50);
                arrPara[1].Value = mNguoiDung;
                arrPara[2] = new SqlParameter("@maNhomQuyen", SqlDbType.NVarChar, 50);
                arrPara[2].Value = mMaNhomQuyen;
                int iRs = MTSQLServer.getMTSQLServer().wExec("spHT_AddNguoiDung", arrPara);
                return Utils.SAVE_DB_OK;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
    }
}
