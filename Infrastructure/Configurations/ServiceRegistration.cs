using Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configurations;

public static class ServiceRegistration
{
    public static void RegisterServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<ContentService>();
        services.AddScoped<CourseService>();
        services.AddScoped<CategoryService>();
        services.AddScoped<AccountService>();
    }
}
