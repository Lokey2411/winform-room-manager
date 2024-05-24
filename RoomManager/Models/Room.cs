﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomManager.Models
{
    internal class Room
    {
        public Room(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Status{ get; set; }
        public String toString()
        {
            return "ID: " + ID + ", Name: " + Name + ", Status: " + Status;
        }
    }
}
