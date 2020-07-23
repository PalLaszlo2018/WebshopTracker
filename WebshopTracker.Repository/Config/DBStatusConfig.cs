using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebshopTracker.Repository.Entities;

namespace WebshopTracker.Repository.Config
{
    class DBStatusConfig
    {
        public void Configure(EntityTypeBuilder<DBStatus> builder)
        {
            builder.ToTable("StatusTable");
            builder.HasKey(o => o.Id);
            builder.Property(o => o.StatusCode).IsRequired();
            builder.HasIndex(o => o.StatusCode).IsUnique();
        }

    }
}
