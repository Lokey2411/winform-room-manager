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
    internal class RoomController: DB
    {
        public RoomController()
        {

        }
        public Room[] GetAllRooms()
        {
            List<Room> rooms = new List<Room>();

            try
            {
                using (SqlConnection conn = getConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM rooms;";
                    SqlCommand command = new SqlCommand(sql, conn);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = GetDataFromField<int>(reader, "id");
                        string name = GetDataFromField<string>(reader, "name");
                        string descriptions = GetDataFromField<string>(reader, "descriptions");
                        string status = GetDataFromField<string>(reader, "status");
                        rooms.Add(new Room (id,name,status,descriptions));
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log or display an error message)
                Console.WriteLine("Error: " + ex.Message);
            }

            return rooms.ToArray();
        }
        public int AddNewRoom(string name, string descriptions)
        {
            try
            {
                SqlConnection conn = getConnection();
                conn.Open();
                //check if duplicated data
                string sql = "Select * from rooms where name = @name";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("name", name);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) { conn.Close(); return 409; }
                conn.Close();      //close connection before insert
                conn.Open();
                sql = "INSERT INTO rooms(name,descriptions, status) VALUES(@name,@descriptions, N'chưa đặt')";
                command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("name", name); //binding params
                command.Parameters.AddWithValue("descriptions", descriptions);
                command.ExecuteNonQuery();
                conn.Close();
                return 200;
            }
            catch (SqlException ex) {
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message);
                getConnection().Close();
                return 500;
            }
        }
        public Room[] SearchRoomByName(string name)
        {
            List<Room> rooms = new List<Room>();

            try
            {
                using (SqlConnection conn = getConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM rooms where name  LIKE '%"+name+"%' or descriptions LIKE '%"+name+"%';";
                    SqlCommand command = new SqlCommand(sql, conn);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string dbnameResult = reader.GetString(1);
                        string status = reader.GetString(2);
                        string descriptions = GetDataFromField<string>(reader, "descriptions");
                        rooms.Add(new Room(id, dbnameResult, status,descriptions));
                    }
                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                // Handle exceptions (e.g., log or display an error message)
                Console.WriteLine("Error: " + ex.Message);
            }

            return rooms.ToArray();
        }
        public int RemoveRoom(int id)
        {
            try {
                SqlConnection conn = getConnection();
                string sql = "Select * from rooms where id = " + id;
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (!reader.Read()) {
                    conn.Close();
                    return 400;
                }
                conn.Close();
                conn.Open();
                sql = "DELETE FROM rooms where id = " + id;
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                return 200;
            }
            catch (SqlException ex){
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message);
                return 500;
            }
        }
        public void UpdateStatus(int id, string status)
        {
            try
            {
                SqlConnection conn = getConnection();
                string sql = "UPDATE rooms SET status = @status where id = @id";
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("status", status);
                command.Parameters.AddWithValue("id", id);
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi truy vấn: "+ex.Message);
            }
        }
    }
}
