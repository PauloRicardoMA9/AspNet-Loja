using LojaAspNet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LojaAspNet.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDatabaseDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LojaContext>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("LojaContext")));

            return services;
        }
    }
}
