using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebshopTracker.Repository.Entities;

namespace WebshopTracker.Repository.Config
{
    class DBProductConfig
    {
        public void Configure(EntityTypeBuilder<DBProduct> builder)
        {
            builder.ToTable("ProductTable");
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Name).IsRequired();
            builder.HasIndex(o => o.Name).IsUnique();
            builder.Property(o => o.Price).IsRequired();
        }

    }
}
