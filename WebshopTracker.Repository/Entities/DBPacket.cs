using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopTracker.Repository.Entities
{
    public class DBPacket
    {
        public ulong Id { get; set; }

        public string Number { get; set; }

        public DBStatus Status { get; set; }

        public List<DBProduct> Products { get; set; }
    }
}
