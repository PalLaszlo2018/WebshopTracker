using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace WebshopTracker.Api.Dto
{
    public class UserDTO
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public List<string> Packets { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
