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
            if (Load_DAL("select * from PhieuNhap where MaPN='" + ctpn.MaPN + "'").Rows.Count == 0) return 3;
            else if (Load_DAL("select * from MatHang where MaHang='" + ctpn.MaHang + "'").Rows.Count == 0) return 4;
            else if (Load_DAL("select * from CTPN where MaPN='" + ctpn.MaPN + "' and MaHang='" + ctpn.MaHang + "'").Rows.Count > 0) return 2;
            else if (ctpn.SoLuong <= 0 || ctpn.DonGia<0) return 5;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Insert_CTPN", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ma", ctpn.MaPN));
                    cmd.Parameters.Add(new SqlParameter("@mh", ctpn.MaHang));
                    cmd.Parameters.Add(new SqlParameter("@sl", ctpn.SoLuong));
                    cmd.Parameters.Add(new SqlParameter("@dg", ctpn.DonGia));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return 1;
                }
                catch
                {
                    if (con.State == ConnectionState.Open) con.Close();
                    return 0;
                }
        }

        public int Update(CTPN ctpn)
        {
            if (Load_DAL("select * from CTPN where MaPN='" + ctpn.MaPN + "' and MaHang='" + ctpn.MaHang + "'").Rows.Count == 0) return 2;
            else if (ctpn.SoLuong <= 0 || ctpn.DonGia < 0) return 3;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Update_CTPN", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sl", ctpn.SoLuong));
                    cmd.Parameters.Add(new SqlParameter("@dg", ctpn.DonGia));
                    cmd.Parameters.Add(new SqlParameter("@ma", ctpn.MaPN));
                    cmd.Parameters.Add(new SqlParameter("@mh", ctpn.MaHang));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return 1;
                }
                catch
                {
                    if (con.State == ConnectionState.Open) con.Close();
                    return 0;
                }
        }

        public int Delete(CTPN ctpn)
        {
            if (Load_DAL("select * from CTPN where MaPN='" + ctpn.MaPN + "' and MaHang='" + ctpn.MaHang + "'").Rows.Count == 0) return 2;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Delete_CTPN", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ma", ctpn.MaPN));
                    cmd.Parameters.Add(new SqlParameter("@mh", ctpn.MaHang));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return 1;
                }
                catch
                {
                    if (con.State == ConnectionState.Open) con.Close();
                    return 0;
                }
        }
    }
}
