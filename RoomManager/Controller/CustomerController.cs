using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
