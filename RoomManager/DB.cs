using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RoomManager
{
    public class DB
    {
        private string db = "Room_manager";
        public SqlConnection getConnection()
        {
            String connectionString = "Server=localhost\\SQLEXPRESS;Database=" + db + ";Trusted_Connection=True;";
            return new SqlConnection(connectionString);
        }
        public void createUsersTable()
        {
            try
            {
                SqlConnection conn = getConnection();
                conn.Open();
                String sql = "IF OBJECT_ID(N'users', N'U') IS NULL BEGIN CREATE TABLE users (" +
                    "id int PRIMARY KEY NOT NULL IDENTITY(1,1)," +
                    "username varchar(255) NOT NULL," +
                    "password text NOT NULL); " +
                    "END";
                SqlCommand command = new SqlCommand(sql, conn);
                AuthManager auth = new AuthManager();
                command.ExecuteNonQuery();
                if (!auth.hasUser("admin"))
                {
                    command = new SqlCommand("INSERT INTO users( username, password) VALUES( 'admin','admin') ;", conn);
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu:" + ex.Message);
            }
        }
        public void createRoomsTable()
        {
            try
            {
                SqlConnection conn = getConnection();
                conn.Open();
                String sql = "IF OBJECT_ID(N'rooms', N'U') IS NULL BEGIN  " +
                    "CREATE TABLE rooms(" +
                    "id int PRIMARY KEY NOT NULL IDENTITY(1,1), " +
                    "name varchar(255) NOT NULL, " +
                    "status nvarchar(50) NOT NULL);" +
                    "END";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu:" + ex.Message);
            }
        }
        public void createCustomersTable()
        {
            try
            {
                SqlConnection conn = getConnection();
                conn.Open();
                String sql = "IF OBJECT_ID(N'customers', N'U') IS NULL " +
                    "BEGIN  " +
                    "CREATE TABLE customers(" +
                    "id int NOT NULL PRIMARY KEY IDENTITY(1,1), " +
                    "name nvarchar(255) NOT NULL, " +
                    "phone_number varchar(20) NOT NULL,"+
                    "check_in_date date NOT NULL, " +
                    "check_out_date date NOT NULL, " +
                    "roomId int NOT NULL FOREIGN KEY REFERENCES rooms(id) ); " +
                    "END";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu:" + ex.Message);
            }
        }
        public void createTables()
        {
            createUsersTable();
            createRoomsTable();
            createCustomersTable();
        }
        public DB()
        {

        }
    }
}
