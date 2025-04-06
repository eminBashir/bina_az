using BusinessLayer.Mapper;
using BusinessLayer.Services.Implementation;
using BusinessLayer.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Configuration
{
    public static class AnnouncServiceConfig
    {
        public static void AddAnnouncServiceConfig(this IServiceCollection services)
        {
            services.AddScoped<ICityService,CityService>();
            services.AddScoped<IRegionService,RegionService>();
            services.AddAutoMapper(typeof(MapperProfile));
        }

    }
}
