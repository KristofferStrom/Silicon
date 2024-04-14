using Infrastructure.Contexts;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configurations
{
    public static class DbContextRegistration
    {
        public static void RegisterDbContexts(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationIdentityContext>(x => x.UseSqlServer(config.GetConnectionString("SqlServer")));
        }
    }
}
