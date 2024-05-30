using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomManager.Models
{
    internal class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public User() { }
        public User(int iD, string name, string phoneNumber)
        {
            ID = iD;
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
}
