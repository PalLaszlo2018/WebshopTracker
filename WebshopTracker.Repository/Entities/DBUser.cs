using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopTracker.Repository.Entities
{
    public class DBUser
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public List<DBPacket> Packets { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
