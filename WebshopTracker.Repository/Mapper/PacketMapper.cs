using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using WebshopTracker.Domain;
using WebshopTracker.Repository.Entities;

namespace WebshopTracker.Repository.Mapper
{
    class PacketMapper : IPacketMapper
    {
        public Packet MapToDomain (DBPacket packet)
        {
            var mapped = new Packet
            {
                Id = packet.Id,
                Number = packet.Number,
                Status = Enum.Parse<Status>(packet.Status.ToString()),
                // Products = (packet.Products ?? new List<DBProduct>()).Select(p => (Product)(p.Name)).ToList() TODO

            };
            return mapped;
        }

        public DBPacket MapToEntity(Packet packet)
        {
            throw new NotImplementedException(); // Not needed for the task, to be implemented later
        }
    }
}
