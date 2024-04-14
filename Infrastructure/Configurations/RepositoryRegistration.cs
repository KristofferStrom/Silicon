using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configurations
{
    public static class RepositoryRegistration
    {
        public static void RegisterRepositories(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<CourseRepo>();
            services.AddScoped<CategoryRepo>();
            services.AddScoped<SubscribeRepo>();
            services.AddScoped<UserRepo>();
        }
    }
}
