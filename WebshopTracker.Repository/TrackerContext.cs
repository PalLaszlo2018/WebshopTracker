using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebshopTracker.Repository.Config;
using WebshopTracker.Repository.Entities;

namespace WebshopTracker.Repository
{
    public class TrackerContext : DbContext, ITrackerContext
    {
        public DbSet<DBPacket> Packets { get; set; }
        public DbSet<DBProduct> Products { get; set; }
        public DbSet<DBStatus> Statuses { get; set; }
        public DbSet<DBUser> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // optionsBuilder.UseMySQL("server=localhost;database=ize;user=root;password=test1234"); TODO MYSQL -> MSSQL

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // modelBuilder.ApplyConfiguration(new DBPacketConfig()); TODO
        }
    }
}

