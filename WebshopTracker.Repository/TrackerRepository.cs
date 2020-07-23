using System;
using System.Collections.Generic;
using System.Linq;
using WebshopTracker.Domain;
using WebshopTracker.Repository.Abstractions;
using WebshopTracker.Repository.Mapper;

namespace WebshopTracker.Repository
{
    public class TrackerRepository : ITrackerRepository
    {
        private readonly TrackerContext trackerContext;
        private readonly IPacketMapper packetMapper;

        public TrackerRepository(TrackerContext trackerContext, IPacketMapper packetMapper)
        {
            this.trackerContext = trackerContext;
            this.packetMapper = packetMapper;
        }

        public IEnumerable<Packet> GetAll()
        {
            return trackerContext.Packets.Select(p => packetMapper.MapToDomain(p)).ToList(); 
        }
        public Packet GetByCode(string code)
        {
            var packet = trackerContext.Packets.Where(p => p.Number == code).Single();
            return packetMapper.MapToDomain(packet);
        }
    }
}


