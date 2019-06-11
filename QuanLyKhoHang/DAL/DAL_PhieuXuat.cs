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
    public class DAL_PhieuXuat:DBConnect
    {
        public DataTable Load_DAL(string sql)
        {
            return Load(sql);
        }

        public int Insert(PhieuXuat px)
        {
            if (Load_DAL("select * from PhieuXuat where MaPX='" + px.MaPX + "'").Rows.Count > 0) return 2;
            else
                {
                    SqlCommand cmd = new SqlCommand("Insert_PhieuXuat", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ma", px.MaPX));
                    cmd.Parameters.Add(new SqlParameter("@nv", px.MaNV));
                    cmd.Parameters.Add(new SqlParameter("@ngay", Convert.ToDateTime(px.NgayXuat)));
                    cmd.Parameters.Add(new SqlParameter("@kh", px.MaKH));
                    cmd.Parameters.Add(new SqlParameter("@kho", px.MaKho));
                    try { if (con.State != ConnectionState.Open) con.Open(); } catch { return -2; }
                    try { cmd.ExecuteNonQuery(); return 1; } catch { return 0; } finally { if (con.State == ConnectionState.Open) con.Close(); }
            }
        }

        public int Update(PhieuXuat px)
        {
            if (Load_DAL("select * from PhieuXuat where MaPX='" + px.MaPX + "'").Rows.Count == 0) return 2;
            else if (Load_DAL("select * from CTPX where MaPX='" + px.MaPX + "'").Rows.Count > 0 && GiaTriChuoi("select MaKho from PhieuXuat where MaPX='" + px.MaPX + "'") != px.MaKho) return 3;
            else
                {
                    SqlCommand cmd = new SqlCommand("Update_PhieuXuat", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@nv", px.MaNV));
                    cmd.Parameters.Add(new SqlParameter("@ngay", Convert.ToDateTime(px.NgayXuat)));
                    cmd.Parameters.Add(new SqlParameter("@kh", px.MaKH));
                    cmd.Parameters.Add(new SqlParameter("@kho", px.MaKho));
                    cmd.Parameters.Add(new SqlParameter("@ma", px.MaPX));
                    try { if (con.State != ConnectionState.Open) con.Open(); } catch { return -2; }
                    try { cmd.ExecuteNonQuery(); return 1; } catch { return 0; } finally { if (con.State == ConnectionState.Open) con.Close(); }
            }
        }

        public int Delete(PhieuXuat px)
        {
            if (Load_DAL("select * from PhieuXuat where MaPX='" + px.MaPX + "'").Rows.Count == 0) return 2;
            else
            {
                if (Load_DAL("select * from CTPX where MaPX='" + px.MaPX + "'").Rows.Count > 0) return 3;
                else
                {
                    SqlCommand cmd = new SqlCommand("Delete_PhieuXuat", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ma", px.MaPX));
                    try { if (con.State != ConnectionState.Open) con.Open(); } catch { return -2; }
                    try { cmd.ExecuteNonQuery(); return 1; } catch { return 0; } finally { if (con.State == ConnectionState.Open) con.Close(); }
                }
            }
        }

        public string GiaTriChuoi(string sql)
        {
            try
            {
                if (con.State != ConnectionState.Open) con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                string i = (string)cmd.ExecuteScalar();
                con.Close();
                return i;
            }
            catch
            {
                if (con.State == ConnectionState.Open) con.Close();
                return "";
            }
        }
    }
}
