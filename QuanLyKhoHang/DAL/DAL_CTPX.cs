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
    public class DAL_CTPX : DBConnect
    {
        public DataTable Load_DAL(string sql)
        {
            return Load(sql);
        }

        public int Insert(CTPX ctpx)
        {
            if (Load_DAL("select * from PhieuXuat where MaPX='" + ctpx.MaPX + "'").Rows.Count == 0) return 3;
            else if (Load_DAL("select * from MatHang where MaHang='" + ctpx.MaHang + "'").Rows.Count == 0) return 4;
            else if (Load_DAL("select * from CTPX where MaPX='" + ctpx.MaPX + "' and MaHang='" + ctpx.MaHang + "'").Rows.Count > 0) return 2;
            else if (ctpx.SoLuong <= 0 || ctpx.DonGia < 0) return 5;
            else if (Load_DAL("select * from CTMH where MaKho=(select MaKho from PhieuXuat where MaPX='" + ctpx.MaPX + "') and MaHang='" + ctpx.MaHang + "'").Rows.Count == 0) return 6;
            else
            {
                string sql = "select SoLuong from CTMH where MaHang = '" + ctpx.MaHang + "' and MaKho=(select MaKho from PhieuXuat where MaPX='" + ctpx.MaPX + "')";
                if (TinhSL(sql) < ctpx.SoLuong) return 7;
                else
                    try
                    {
                        if (con.State != ConnectionState.Open) con.Open();
                        SqlCommand cmd = new SqlCommand("Insert_CTPX", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@ma", ctpx.MaPX));
                        cmd.Parameters.Add(new SqlParameter("@mh", ctpx.MaHang));
                        cmd.Parameters.Add(new SqlParameter("@sl", ctpx.SoLuong));
                        cmd.Parameters.Add(new SqlParameter("@dg", ctpx.DonGia));
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

        public int Update(CTPX ctpx)
        {
            if (Load_DAL("select * from CTPX where MaPX='" + ctpx.MaPX + "' and MaHang='" + ctpx.MaHang + "'").Rows.Count == 0) return 2;
            else if (ctpx.SoLuong <= 0 || ctpx.DonGia < 0) return 3;
            else
            {
                string sql = "select SoLuong from CTMH where MaHang = '" + ctpx.MaHang + "' and MaKho=(select MaKho from PhieuXuat where MaPX='" + ctpx.MaPX + "')";
                string sql2 = "select SoLuong from CTPX where MaPX='" + ctpx.MaPX + "'";
                if (TinhSL(sql) + TinhSL(sql2) < ctpx.SoLuong) return 4;
                else
                    try
                    {
                        if (con.State != ConnectionState.Open) con.Open();
                        SqlCommand cmd = new SqlCommand("Update_CTPX", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@sl", ctpx.SoLuong));
                        cmd.Parameters.Add(new SqlParameter("@dg", ctpx.DonGia));
                        cmd.Parameters.Add(new SqlParameter("@ma", ctpx.MaPX));
                        cmd.Parameters.Add(new SqlParameter("@mh", ctpx.MaHang));
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

        public int Delete(CTPX ctpx)
        {
            if (Load_DAL("select * from CTPX where MaPX='" + ctpx.MaPX + "' and MaHang='" + ctpx.MaHang + "'").Rows.Count == 0) return 2;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Delete_CTPX", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ma", ctpx.MaPX));
                    cmd.Parameters.Add(new SqlParameter("@mh", ctpx.MaHang));
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
        
        public int TinhSL(string sql)
        {
            try
            {
                if (con.State != ConnectionState.Open) con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                int i = (int)cmd.ExecuteScalar();
                con.Close();
                return i;
            }
            catch
            {
                if (con.State == ConnectionState.Open) con.Close();
                return 0;
            }
        }
    }
}
