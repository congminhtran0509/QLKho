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
    public class DAL_PhieuNhap:DBConnect
    {
        public DataTable Load_DAL(string sql)
        {
            return Load(sql);
        }

        public int Insert(PhieuNhap pn)
        {
            if (Load_DAL("select * from PhieuNhap where MaPN='" + pn.MaPN + "'").Rows.Count > 0) return 2;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Insert_PhieuNhap", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ma", pn.MaPN));
                    cmd.Parameters.Add(new SqlParameter("@nv", pn.MaNV));
                    cmd.Parameters.Add(new SqlParameter("@ngay", Convert.ToDateTime(pn.NgayNhap)));
                    cmd.Parameters.Add(new SqlParameter("@ncc", pn.MaNCC));
                    cmd.Parameters.Add(new SqlParameter("@kho", pn.MaKho));
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

        public int Update(PhieuNhap pn)
        {
            if (Load_DAL("select * from PhieuNhap where MaPN='" + pn.MaPN + "'").Rows.Count == 0) return 2;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Update_PhieuNhap", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@nv", pn.MaNV));
                    cmd.Parameters.Add(new SqlParameter("@ngay", Convert.ToDateTime(pn.NgayNhap)));
                    cmd.Parameters.Add(new SqlParameter("@ncc", pn.MaNCC));
                    cmd.Parameters.Add(new SqlParameter("@kho", pn.MaKho));
                    cmd.Parameters.Add(new SqlParameter("@ma", pn.MaPN));
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

        public int Delete(PhieuNhap pn)
        {
            if (Load_DAL("select * from PhieuNhap where MaPN='" + pn.MaPN + "'").Rows.Count == 0) return 2;
            else
            {
                if (Load_DAL("select * from CTPN where MaPN='" + pn.MaPN + "'").Rows.Count > 0) return 3;
                else
                    try
                    {
                        if (con.State != ConnectionState.Open) con.Open();
                        SqlCommand cmd = new SqlCommand("Delete_PhieuNhap", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@ma", pn.MaPN));
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
}
