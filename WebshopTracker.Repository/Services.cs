using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using WebshopTracker.Repository.Abstractions;
using WebshopTracker.Repository.Mapper;

namespace WebshopTracker.Repository
{
    public static class Services
    {
        public static void RegisterRepositoryDependecies(this IServiceCollection services)
        {
            services.AddTransient<ITrackerContext, TrackerContext>();
            services.AddTransient<IPacketMapper, PacketMapper>();
            services.AddTransient<ITrackerRepository, TrackerRepository>();

        }
    }
}
