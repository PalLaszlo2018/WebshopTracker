using System;
using System.Collections.Generic;
using System.Text;
using WebshopTracker.Domain;
using WebshopTracker.Repository.Entities;

namespace WebshopTracker.Repository.Mapper
{
    public interface IPacketMapper
    {
        DBPacket MapToEntity(Packet packet);

        Packet MapToDomain(DBPacket packet);
    }



}
