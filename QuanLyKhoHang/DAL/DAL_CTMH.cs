using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_CTMH : DBConnect
    {
        public DataTable Load_DAL(string sql)
        {
            return Load(sql);
        }

        public int Insert(CTMH ctmh)
        {
            if (Load_DAL("select * from CTMH where MaKho='" + ctmh.MaKho + "' and MaHang='" + ctmh.MaHang + "'").Rows.Count > 0) return 2;
            else if (ctmh.SoLuong < 0) return 3;
            else
            {
                if (con.State != ConnectionState.Open) con.Open();
                SqlCommand cmd = new SqlCommand("Insert_CTMH", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", ctmh.MaHang));
                cmd.Parameters.Add(new SqlParameter("@kho", ctmh.MaKho));
                cmd.Parameters.Add(new SqlParameter("@sl", ctmh.SoLuong));
                try { if (con.State != ConnectionState.Open) con.Open(); } catch { return -2; }
                try { cmd.ExecuteNonQuery(); return 1; } catch { return 0; } finally { if (con.State == ConnectionState.Open) con.Close(); }
            }
        }

        public int Update(CTMH ctmh)
        {
            if (Load_DAL("select * from CTMH where MaKho='" + ctmh.MaKho + "' and MaHang='" + ctmh.MaHang + "'").Rows.Count == 0) return 2;
            else if (ctmh.SoLuong < 0) return 3;
            else
                {
                if (con.State != ConnectionState.Open) con.Open();
                SqlCommand cmd = new SqlCommand("Update_CTMH", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@sl", ctmh.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@ma", ctmh.MaHang));
                cmd.Parameters.Add(new SqlParameter("@kho", ctmh.MaKho));
                try { if (con.State != ConnectionState.Open) con.Open(); } catch { return -2; }
                try { cmd.ExecuteNonQuery(); return 1; } catch { return 0; } finally { if (con.State == ConnectionState.Open) con.Close(); }
            }
        }

        public int Delete(CTMH ctmh)
        {
            if (Load_DAL("select * from CTMH where MaKho='" + ctmh.MaKho + "' and MaHang='" + ctmh.MaHang + "'").Rows.Count == 0) return 2;
            else
            {
                if (con.State != ConnectionState.Open) con.Open();
                SqlCommand cmd = new SqlCommand("Delete_CTMH", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", ctmh.MaHang));
                cmd.Parameters.Add(new SqlParameter("@kho", ctmh.MaKho));
                try { if (con.State != ConnectionState.Open) con.Open(); } catch { return -2; }
                try { cmd.ExecuteNonQuery(); return 1; } catch { return 0; } finally { if (con.State == ConnectionState.Open) con.Close(); }
            }
        }
    }
}
