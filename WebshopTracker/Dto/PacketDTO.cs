using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebshopTracker.Api.Dto
{
    public class PacketDTO
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Status { get; set; }
        public List<string> Products { get; set; }

    }
}
