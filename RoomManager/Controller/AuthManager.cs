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
                String sql = "Select * from users where username = '" + username + "'";
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
        public void signUp(String username, String password, String customerName, String phoneNumber)
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
                String sql = "INSERT INTO users(username, password, name, phone_number) VALUES(@username, @password, @customerName, @phoneNumber);";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("username", username);
                command.Parameters.AddWithValue("password", password);
                command.Parameters.AddWithValue("customerName", customerName);
                command.Parameters.AddWithValue("phoneNumber", phoneNumber);
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
        public int GetUserId(string username)
        {
            try
            {
                SqlConnection conn = getConnection();
                conn.Open();
                string sql = "select id from users where username = @username";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("username", username);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) return reader.GetInt32(0);
                conn.Close();
                return -1;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Lỗi truy vấn, vui lòng thử lại"+ex.Message);
                return -1;
            }
        }
        public AuthManager()
        {

        }
    }
}
