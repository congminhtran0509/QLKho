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
    public class DAL_NhanVien:DBConnect
    {
        public DataTable Load_DAL(string sql)
        {
            return Load(sql);
        }

        public int Insert(NhanVien nv)
        {
            string sql = "select * from NhanVien where MaNV = '" + nv.MaNV + "'";
            if (Load_DAL(sql).Rows.Count > 0) return 2;
            else
            {
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Insert_NV", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@manv", nv.MaNV));
                    cmd.Parameters.Add(new SqlParameter("@ht", nv.HoTen));
                    cmd.Parameters.Add(new SqlParameter("@ns", Convert.ToDateTime(nv.NgaySinh)));
                    cmd.Parameters.Add(new SqlParameter("@cmnd", nv.CMND));
                    cmd.Parameters.Add(new SqlParameter("@gt", nv.GT));
                    cmd.Parameters.Add(new SqlParameter("@dc", nv.DiaChi));
                    cmd.Parameters.Add(new SqlParameter("@dt", nv.DT));
                    cmd.Parameters.Add(new SqlParameter("@email", nv.Email));
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

        public int Update(NhanVien nv)
        {
            string sql = "select * from NhanVien where MaNV = '" + nv.MaNV + "'";
            if (Load_DAL(sql).Rows.Count == 0) return 2;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Update_NV", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ht", nv.HoTen));
                    cmd.Parameters.Add(new SqlParameter("@ns", Convert.ToDateTime(nv.NgaySinh)));
                    cmd.Parameters.Add(new SqlParameter("@cmnd", nv.CMND));
                    cmd.Parameters.Add(new SqlParameter("@gt", nv.GT));
                    cmd.Parameters.Add(new SqlParameter("@dc", nv.DiaChi));
                    cmd.Parameters.Add(new SqlParameter("@dt", nv.DT));
                    cmd.Parameters.Add(new SqlParameter("@email", nv.Email));
                    cmd.Parameters.Add(new SqlParameter("@manv", nv.MaNV));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return 1;
                }
                catch {
                    if (con.State == ConnectionState.Open) con.Close();
                    return 0;
                }
        }

        public int Delete(NhanVien nv)
        {
            if (Load_DAL("select * from NhanVien where MaNV = '" + nv.MaNV + "'").Rows.Count == 0) return 2;
            else if (Load_DAL("select * from PhieuNhap where MaNV = '" + nv.MaNV + "'").Rows.Count > 0) return 3;
            else if (Load_DAL("select * from PhieuXuat where MaNV = '" + nv.MaNV + "'").Rows.Count > 0) return 4;
            else if (Load_DAL("select * from Kho where NVQL = '" + nv.MaNV + "'").Rows.Count > 0) return 5;
            else
                try
                    {
                        if (con.State != ConnectionState.Open) con.Open();
                        SqlCommand cmd = new SqlCommand("Delete_NV", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@manv", nv.MaNV));
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
