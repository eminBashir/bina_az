using Microsoft.Extensions.DependencyInjection;
using RepositoryLayer.Implementation;
using RepositoryLayer.Interface;

namespace RepositoryLayer.Configuration
{
    public static class RepositoryConfiguration
    {
        public static void AddRepositoryConfig(this IServiceCollection services)
        {
            services.AddScoped<IAnnouncmentRepository,AnnouncmentRepository>(); 
            services.AddScoped<IAnnouncmentImagesRepository,AnnouncmentImagesRepository>();
            services.AddScoped<IAnnouncmentStatusRepository,AnnouncmentStatusRepository>();
            services.AddScoped<IAnnouncmentTypeRepository,AnnouncmentTypeRepository>();
            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<ICityRepository,CityRepository>();
            services.AddScoped<IFavoritsRepository,FavoritsRepository>();
            services.AddScoped<IPaymentRepository,PaymentRepository>();
            services.AddScoped<IRegionRepository,RegionRepository>();
            services.AddScoped<ISettlementRepository,SettlementRepository>();
            services.AddScoped<IStatusRepository,StatusRepository>();
        }
    }
}
