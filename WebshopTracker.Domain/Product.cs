using System;

namespace WebshopTracker.Domain
{
    public class Product
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public uint Price { get; set; }
    }
}
