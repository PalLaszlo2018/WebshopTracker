using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopTracker.Domain
{
    public class Packet
    {
        public ulong Id { get; set; }
        public string Number { get; set; }
        public Status Status { get; set; }
        public List<Product> Products { get; set; }
    }
}
