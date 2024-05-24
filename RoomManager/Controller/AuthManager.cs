using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RoomManager
{
    internal class AuthManager : DB
    {
        public String getPassword(String username)
        {
            try
            {
                SqlConnection conn = getConnection();
                conn.Open();
                String sql = "Select password from users where username = '" + username + "'";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetString(0);
                }
                MessageBox.Show("Không tìm thấy tài khoản. Vui lòng nhập lại");
                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn: " + ex.Message);
                return "";
            }
        }
        public Boolean hasUser(String username)
        {
            try
            {
                SqlConnection conn = getConnection();
                conn.Open();
                String sql = "Select * from users where username LIKE '" + username + "'";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    conn.Close();
                    return true;
                }
                conn.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn: " + ex.Message);
                return false;
            }
        }
        public void signUp(String username, String password)
        {
            if (hasUser(username))
            {
                MessageBox.Show("Tài khoản đã đăng ký. Vui lòng nhập tài khoản khác và thử lại");
                return;
            }
            try
            {
                SqlConnection conn = getConnection();
                conn.Open();
                String sql = "INSERT INTO users(username, password) VALUES('" + username + "','" + password + "');";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Tài khoản đã đăng ký thành công");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn: " + ex.Message);
            }
        }
        public String signIn(String username, String password)
        {
            string dbPassword = getPassword(username);
            if (password != dbPassword)
            {
                MessageBox.Show("Sai mật khẩu. Vui lòng nhập lại");
            }
            else
            {
                if (username == "admin") return "admin";
                return "customer";
            }
            return "invalid log in";
        }
        public AuthManager()
        {

        }
    }
}
