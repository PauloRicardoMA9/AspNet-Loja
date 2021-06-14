using LojaAspNet.Data;
using Microsoft.AspNetCore.Identity;
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

            services.AddDbContext<LojaAspNetIdentity>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("LojaAspNetIdentityConnection")));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddDefaultUI()
                .AddEntityFrameworkStores<LojaAspNetIdentity>();

            return services;
        }
    }
}
