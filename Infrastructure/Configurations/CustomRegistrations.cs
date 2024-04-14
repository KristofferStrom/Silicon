using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configurations;

public static class CustomRegistrations
{
    public static void RegisterDependencies(this IServiceCollection services, IConfiguration config)
    {
        services.RegisterDbContexts(config);
        services.RegisterRepositories(config);
        services.RegisterServices(config);
        services.RegisterAuthentication(config);
    }
}
