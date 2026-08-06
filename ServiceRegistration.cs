using Microsoft.Extensions.DependencyInjection;
using FUT18Launcher.Navigation;

namespace FUT18Launcher.Services;

public static class ServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddSingleton<INavigationService, NavigationService>();

        return services;
    }
}
