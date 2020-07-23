using System;
using System.Collections.Generic;
using WebshopTracker.Domain;

namespace WebshopTracker.Service.Abstractions
{
    public interface ITrackerService
    {
        IEnumerable<Packet> GetAll();

        IEnumerable<Packet> GetByNumber(string number);
    }
}
