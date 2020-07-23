using System;
using System.Collections.Generic;
using System.Threading;
using WebshopTracker.Domain;
using WebshopTracker.Repository.Abstractions;
using WebshopTracker.Service.Abstractions;

namespace WebshopTracker.Service
{
    public class TrackerService : ITrackerService
    {
        private readonly ITrackerRepository trackerRepository;

        public TrackerService(ITrackerRepository trackerRepository)
        {
            this.trackerRepository = trackerRepository;
        }

        public IEnumerable<Packet> GetAll()
        {
            return trackerRepository.GetAll();
        }

        public IEnumerable<Packet> GetByNumber(string code)
        {
            return (IEnumerable<Packet>)trackerRepository.GetByCode(code);
        }
    }
}

