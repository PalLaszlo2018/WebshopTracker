using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopTracker.Repository.Entities
{
    public class DBProduct
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public uint Price { get; set; }

    }
}
