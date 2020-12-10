using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SinhVien
{
    class SinhVienDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;
        public SinhVienDAL()
        {
            dc = new DataConnection();
            
        }
        public DataTable getAllSinhVien()
        {
            string sql = "select *from sinhvien"; // tao cau lenh sql
            SqlConnection conn = dc.getConnect(); // connection 
            da = new SqlDataAdapter(sql,conn); // khoi tao doi tuong cua lop adapter
            conn.Open(); // mo ket noi
            dt = new DataTable(); //khoi tao doi tuong table 
            da.Fill(dt); //do dl tu adpa ter vao table
            conn.Close(); // dong ket noi
            return dt;

        }
        public bool addSinhVien(SinhVien sv)
        {
            string sql = "insert into sinhvien(masv,hoten,ngaysinh,gioitinh,makhoa,diem) VALUES(@masv,@hoten,@ngaysinh,@gioitinh,@makhoa,@diem)";
            SqlConnection conn = dc.getConnect();
            try {
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@masv", SqlDbType.NVarChar).Value = sv.Masv;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = sv.Hoten;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = sv.Ngaysinh;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = sv.Gioitinh;
                cmd.Parameters.Add("@makhoa", SqlDbType.NVarChar).Value = sv.Makhoa;
                cmd.Parameters.Add("@diem", SqlDbType.Text).Value = sv.Diem;
                conn.Open();
                cmd.ExecuteNonQuery(); //cau lenh thuc thi
                conn.Close();
            
            } catch (Exception ex)
            {
                Console.WriteLine("ERER: " + ex);
                return false;

            }
            return true;
            
        }
        public bool editSinhVien(SinhVien sv)
        {
            string sql = "update sinhvien SET hoten= @hoten,ngaysinh= @ngaysinh,gioitinh= @gioitinh,makhoa= @makhoa,diem= @diem where masv = @masv";
            SqlConnection conn = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@masv", SqlDbType.NVarChar).Value = sv.Masv;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = sv.Hoten;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = sv.Ngaysinh;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = sv.Gioitinh;
                cmd.Parameters.Add("@makhoa", SqlDbType.NVarChar).Value = sv.Makhoa;
                cmd.Parameters.Add("@diem", SqlDbType.Text).Value = sv.Diem;
                conn.Open();
                cmd.ExecuteNonQuery(); //cau lenh thuc thi
                conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERER: " + ex);
                return false;

            }
            return true;

        }
        public bool deleteSinhVien(SinhVien sv)
        {
            string sql = "delete sinhvien where masv = @masv";
            SqlConnection conn = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@masv", SqlDbType.NVarChar).Value = sv.Masv;
        
                conn.Open();
                cmd.ExecuteNonQuery(); //cau lenh thuc thi
                conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERER: " + ex);
                return false;

            }
            return true;

        }
        public DataTable findlSinhVien(string sv)
        {
            string sql = "select *from sinhvien where hoten LIKE '%"+sv+"' OR makhoa LIKE '%"+sv+"'"; // tao cau lenh sql
            SqlConnection conn = dc.getConnect(); // connection 
            da = new SqlDataAdapter(sql, conn); // khoi tao doi tuong cua lop adapter
            conn.Open(); // mo ket noi
            dt = new DataTable(); //khoi tao doi tuong table 
            da.Fill(dt); //do dl tu adpa ter vao table
            conn.Close(); // dong ket noi
            return dt;

        }

    }
}
