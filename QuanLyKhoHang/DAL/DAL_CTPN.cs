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
    public class DAL_CTPN:DBConnect
    {
        public DataTable Load_DAL(string sql)
        {
            return Load(sql);
        }

        public int Insert(CTPN ctpn)
        {
            if (Load_DAL("select * from CTPN where MaPN='" + ctpn.MaPN + "' and MaHang='" + ctpn.MaHang + "'").Rows.Count > 0) return 2;
            else if (ctpn.SoLuong <= 0 || ctpn.DonGia<0) return 3;
            else
                {
                    SqlCommand cmd = new SqlCommand("Insert_CTPN", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ma", ctpn.MaPN));
                    cmd.Parameters.Add(new SqlParameter("@mh", ctpn.MaHang));
                    cmd.Parameters.Add(new SqlParameter("@sl", ctpn.SoLuong));
                    cmd.Parameters.Add(new SqlParameter("@dg", ctpn.DonGia));
                    try { if (con.State != ConnectionState.Open) con.Open(); } catch { return -2; }
                    try { cmd.ExecuteNonQuery(); return 1; } catch { return 0; } finally { if (con.State == ConnectionState.Open) con.Close(); }
            }
        }

        public int Update(CTPN ctpn)
        {
            if (Load_DAL("select * from CTPN where MaPN='" + ctpn.MaPN + "' and MaHang='" + ctpn.MaHang + "'").Rows.Count == 0) return 2;
            else if (ctpn.SoLuong <= 0 || ctpn.DonGia < 0) return 3;
            else
            {
                SqlCommand cmd = new SqlCommand("Update_CTPN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@sl", ctpn.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@dg", ctpn.DonGia));
                cmd.Parameters.Add(new SqlParameter("@ma", ctpn.MaPN));
                cmd.Parameters.Add(new SqlParameter("@mh", ctpn.MaHang));
                try { if (con.State != ConnectionState.Open) con.Open(); } catch { return -2; }
                try { cmd.ExecuteNonQuery(); return 1; } catch { return 0; } finally { if (con.State == ConnectionState.Open) con.Close(); }
            }
               
        }

        public int Delete(CTPN ctpn)
        {
            if (Load_DAL("select * from CTPN where MaPN='" + ctpn.MaPN + "' and MaHang='" + ctpn.MaHang + "'").Rows.Count == 0) return 2;
            else
            {
                if (con.State != ConnectionState.Open) con.Open();
                SqlCommand cmd = new SqlCommand("Delete_CTPN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", ctpn.MaPN));
                cmd.Parameters.Add(new SqlParameter("@mh", ctpn.MaHang));
                try { if (con.State != ConnectionState.Open) con.Open(); } catch { return -2; }
                try { cmd.ExecuteNonQuery(); return 1; } catch { return 0; } finally { if (con.State == ConnectionState.Open) con.Close(); }
            }
        }
    }
}
