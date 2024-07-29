using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class SqlConnectionData
    {
        // Tạo chuỗi kết nối CSDL
        public static SqlConnection Connect()
        {
            string connectionString = @"Data Source=QUANGCUONG\SQLEXPRESS;Initial Catalog=DA_QLSACH;User ID=sa;Password=123;Integrated Security=False;";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            return sqlconn;
        }
    }

    public class DatabaseAccess
    {
        public static string CheckDangNhapDTO(NhanVien nhanVien)
        {
            string user = null;

            // Sử dụng using để đảm bảo SqlConnection được đóng và giải phóng tài nguyên
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand("proc_dangnhap", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@user", nhanVien.UsernameNV);
                    command.Parameters.AddWithValue("@pass", nhanVien.PasswordNV);

                    // Sử dụng using để đảm bảo SqlDataReader được đóng và giải phóng tài nguyên
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int u = reader.GetInt32(0);
                                user = u.ToString();
                                return user;
                            }
                        }
                        else
                        {
                            return "Tài khoản hoặc mật khẩu không chính xác!";
                        }
                    }
                }
            }

            return user;
        }
    }
}

