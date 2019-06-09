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
    public class DAL_MatHang:DBConnect
    {
        public DataTable Load_DAL(string sql)
        {
            return Load(sql);
        }

        public int Insert(MatHang mh)
        {
            if (Load_DAL("select * from MatHang where MaHang='" + mh.MaHang + "'").Rows.Count > 0) return 2;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Insert_MatHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ma", mh.MaHang));
                    cmd.Parameters.Add(new SqlParameter("@ten", mh.TenHang));
                    cmd.Parameters.Add(new SqlParameter("@malh", mh.MaLH));
                    cmd.Parameters.Add(new SqlParameter("@dvt", mh.DVT));
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

        public int Update(MatHang mh)
        {
            if (Load_DAL("select * from MatHang where MaHang='" + mh.MaHang + "'").Rows.Count == 0) return 2;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Update_MatHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ten", mh.TenHang));
                    cmd.Parameters.Add(new SqlParameter("@malh", mh.MaLH));
                    cmd.Parameters.Add(new SqlParameter("@dvt", mh.DVT));
                    cmd.Parameters.Add(new SqlParameter("@ma", mh.MaHang));
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

        public int Delete(MatHang mh)
        {
            if (Load_DAL("select * from MatHang where MaHang='" + mh.MaHang + "'").Rows.Count == 0) return 2;
            else if (Load_DAL("select * from CTPN where MaHang='" + mh.MaHang + "'").Rows.Count > 0) return 3;
            else if (Load_DAL("select * from CTPX where MaHang='" + mh.MaHang + "'").Rows.Count > 0) return 4;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Delete_MatHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ma", mh.MaHang));
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
