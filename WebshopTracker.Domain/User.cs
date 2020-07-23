using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopTracker.Domain
{
    public class User
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public List<Packet> Packets { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
