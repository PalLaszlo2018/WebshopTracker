using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebshopTracker.Repository.Entities;

namespace WebshopTracker.Repository
{
    public interface ITrackerContext
    {

        DbSet<DBPacket> Packets { get; set; }
        DbSet<DBProduct> Products { get; set; }
        DbSet<DBStatus> Statuses { get; set; }
        DbSet<DBUser> Users { get; set; }
    }
}
