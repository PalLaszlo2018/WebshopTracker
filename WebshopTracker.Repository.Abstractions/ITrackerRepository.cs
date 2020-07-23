using System;
using System.Collections.Generic;
using System.Net.Sockets;
using WebshopTracker.Domain;

namespace WebshopTracker.Repository.Abstractions
{
    public interface ITrackerRepository
    {
        IEnumerable<Packet> GetAll();

        Packet GetByCode(string code);
    }
}
