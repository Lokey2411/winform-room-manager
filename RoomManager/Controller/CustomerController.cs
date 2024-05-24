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
                string sql = "select distinct * from customers as c join rooms as r on c.roomId = r.id;";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    String name = reader.GetString(1);
                    String phoneNumber = reader.GetString(2);
                    DateTime checkInDate = reader.GetDateTime(3);
                    DateTime checkOutDate = reader.GetDateTime(4);
                    Room room = new Room(reader.GetInt32(5), reader.GetString(7), reader.GetString(8));
                    list.Add(new Customer(id, name, phoneNumber, checkInDate, checkOutDate, room));
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
                string sql = "select distinct * from customers as c join rooms as r on c.roomId = r.id where r.name LIKE '%"+name+"%';";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    String dbName = reader.GetString(1);
                    String phoneNumber = reader.GetString(2);
                    DateTime checkInDate = reader.GetDateTime(3);
                    DateTime checkOutDate = reader.GetDateTime(4);
                    Room room = new Room(reader.GetInt32(5), reader.GetString(7), reader.GetString(8));
                    list.Add(new Customer(id, dbName, phoneNumber, checkInDate, checkOutDate, room));
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
