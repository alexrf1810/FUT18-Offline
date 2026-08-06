using FUT18Launcher.Navigation;
using FUT18Launcher.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FUT18Launcher.Services;

public static class ServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddSingleton<INavigationService, NavigationService>();

        services.AddScoped<IClubRepository, ClubRepository>();

        return services;
    }
}
