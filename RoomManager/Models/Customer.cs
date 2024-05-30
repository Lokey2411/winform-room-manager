using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomManager.Models
{
    internal class Customer
    {
        public int ID { get; set; }
        public DateTime checkInDate { get; set; }
        public DateTime checkOutDate { get; set; }
        public Room room { get; set; }
        public User user { get; set; }
        public Customer() { }
        public Customer(int id, string Name, string phoneNumber,  DateTime checkInDate, DateTime checkOutDate, Room room, int userId) {
            ID = id;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.room = room;
            this.user = new User(userId, Name, phoneNumber);
        }
    }
}

