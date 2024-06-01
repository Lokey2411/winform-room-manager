using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RoomManager.Models;

namespace RoomManager.Controller
{
    internal class CustomerController:DB
    {
        public CustomerController() { }
        public User GetUser(string username)
        {
            User user = new User();
            try 
            {
                SqlConnection conn = getConnection();
                conn.Open();
                string sql = "select * from users where username = @username";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("username", username);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    //handle if user exists
                    int id = GetDataFromField<int>(reader,"id");
                    string name = GetDataFromField<string>(reader, "name");
                    string phoneNumber = GetDataFromField<string>(reader, "phone_number");
                    user = new User(id,name,phoneNumber);
                }
                conn.Close();
            }
            catch (SqlException ex) 
            {
                MessageBox.Show("Lỗi truy vấn: " + ex);
            }
            return user;
        }
        public Customer[] GetAllCustomers() {
            List<Customer> list = new List<Customer>();
            try
            {
                SqlConnection conn = getConnection();
                conn.Open();
                string sql = "select c.*, u.*,  u.name as customerName, r.*, r.name as roomName from (customers as c join rooms as r on c.roomId = r.id) join users as u on c.userId = u.id;";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = GetDataFromField<int>(reader,"id");
                    String name = GetDataFromField<string>(reader, "customerName");
                    String phoneNumber = GetDataFromField<string>(reader, "phone_number");
                    DateTime checkInDate = GetDataFromField<DateTime>(reader, "check_in_date");
                    DateTime checkOutDate = GetDataFromField<DateTime>(reader, "check_out_date");
                    Room room = new Room(GetDataFromField<int>(reader,"roomId"), GetDataFromField<string>(reader,"roomName"),GetDataFromField<string>(reader, "status"), GetDataFromField<string>(reader, "descriptions"));
                    int userId = reader.GetInt32(4);
                    list.Add(new Customer(id, name, phoneNumber, checkInDate, checkOutDate, room, userId));
                }
                conn.Close();
            }
            catch(SqlException ex) {
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message);
            }
            return list.ToArray();
        }
        public int CheckInRoom(DateTime checkin, DateTime checkout, int roomId, int userId)
        {
            try
            {
                SqlConnection conn = getConnection();
                conn.Open();
                string sql = "INSERT INTO customers(check_in_date, check_out_date, roomId, userId) VALUES(@checkin, @checkout, @roomId, @userId)";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("checkin", checkin);
                command.Parameters.AddWithValue("checkout", checkout);
                command.Parameters.AddWithValue("roomId", roomId);
                command.Parameters.AddWithValue("userId", userId);
                command.ExecuteNonQuery();
                conn.Close();
                return 200;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message);
                return 500;
            }
        }
        public int CheckOutRoom(string username, int roomId)
        {
            try {
                SqlConnection conn = getConnection();
                conn.Open();
                string sql = "UPDATE customers SET check_out_date = @checkout where roomId = @roomId and userId = (Select id from users where username = @username)";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("checkout", DateTime.Now);
                command.Parameters.AddWithValue("username", username);
                command.Parameters.AddWithValue("roomId", roomId);
                command.ExecuteNonQuery();
                conn.Close();
                return 200;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Lỗi truy vấn: " + ex.Message);
                return 500;
            }
        }
        public Customer[] SearchCustomer(string name)
        {
            List<Customer> list = new List<Customer>();
            try
            {
                SqlConnection conn = getConnection();
                conn.Open();
                string sql = "select c.*, r.*, r.name as roomName from customers as c join rooms as r on c.roomId = r.id where r.descriptions LIKE '%"+name+"%';";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AuthManager auth = new AuthManager(); 
                    int id = GetDataFromField<int>(reader,"id");
                    DateTime checkInDate = GetDataFromField<DateTime>(reader, "check_in_date");
                    DateTime checkOutDate = GetDataFromField<DateTime>(reader, "check_out_date");
                    Room room = new Room(GetDataFromField<int>(reader, "roomId"), GetDataFromField<string>(reader, "roomName"), GetDataFromField<string>(reader, "status"),GetDataFromField<string>(reader, "descriptions"));
                    String dbName = reader.GetString(11);
                    String phoneNumber = reader.GetString(4);
                    int userId = auth.GetUserId(dbName);
                    list.Add(new Customer(id, dbName, phoneNumber, checkInDate, checkOutDate, room, userId));
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message);
            }
            return list.ToArray();
        }
    }
}
