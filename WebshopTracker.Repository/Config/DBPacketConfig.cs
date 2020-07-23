using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebshopTracker.Repository.Entities;


using Microsoft.EntityFrameworkCore;


namespace WebshopTracker.Repository.Config
{
    class DBPacketConfig
    {
        public void Configure(EntityTypeBuilder<DBPacket> builder)
        {
            builder.ToTable("PacketTable");
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Number).IsRequired();
            builder.HasIndex(o => o.Number).IsUnique();
            builder.Property(o => o.Status).IsRequired();
        }
    }
}
