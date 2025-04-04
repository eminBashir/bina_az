using DataLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataLayer.Extensions
{
    public static class DbInject
    {
        public static void AddServices(this IServiceCollection services, IConfigurationManager configuration)
        {
            services.AddDbContext<AppDbContext>(op =>
            {
                op.UseSqlServer(configuration.GetConnectionString("Default"));
            });
        }
    }
}
