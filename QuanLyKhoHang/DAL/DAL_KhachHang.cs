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
    public class DAL_KhachHang:DBConnect
    {
        public DataTable Load_DAL(string sql)
        {
            return Load(sql);
        }

        public int Insert(KhachHang kh)
        {
            if (Load_DAL("select * from KhachHang where MaKH='" + kh.MaKH + "'").Rows.Count > 0) return 2;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Insert_KhachHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ma", kh.MaKH));
                    cmd.Parameters.Add(new SqlParameter("@ten", kh.TenKH));
                    cmd.Parameters.Add(new SqlParameter("@dc", kh.DiaChi));
                    cmd.Parameters.Add(new SqlParameter("@dt", kh.DT));
                    cmd.Parameters.Add(new SqlParameter("@email", kh.Email));
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

        public int Update(KhachHang kh)
        {
            if (Load_DAL("select * from KhachHang where MaKH='" + kh.MaKH + "'").Rows.Count == 0) return 2;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Update_KhachHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ten", kh.TenKH));
                    cmd.Parameters.Add(new SqlParameter("@dc", kh.DiaChi));
                    cmd.Parameters.Add(new SqlParameter("@dt", kh.DT));
                    cmd.Parameters.Add(new SqlParameter("@email", kh.Email));
                    cmd.Parameters.Add(new SqlParameter("@ma", kh.MaKH));
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

        public int Delete(KhachHang kh)
        {
            if (Load_DAL("select * from KhachHang where MaKH='" + kh.MaKH + "'").Rows.Count == 0) return 2;
            else if (Load_DAL("select * from PhieuXuat where MaKH='" + kh.MaKH + "'").Rows.Count > 0) return 3;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Delete_KhachHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ma", kh.MaKH));
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
