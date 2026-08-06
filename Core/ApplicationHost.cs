using FUT18Launcher.Database;
using FUT18Launcher.Navigation;
using FUT18Launcher.Repositories;
using FUT18Launcher.Services;
using FUT18Launcher.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FUT18Launcher.Core;

public static class ApplicationHost
{
    public static IHost BuildHost()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                // Base de datos SQLite
                services.AddDbContext<AppDbContext>(options =>
                {
                    options.UseSqlite("Data Source=fut18offline.db");
                });

                // Navegación
                services.AddSingleton<NavigationStore>();
                services.AddSingleton<INavigationService, NavigationService>();

                // Repositorios
                services.AddScoped<IClubRepository, ClubRepository>();

                // Servicios de dominio
                services.AddScoped<IClubService, ClubService>();

                // ViewModels
                services.AddSingleton<MainViewModel>();
                services.AddTransient<CreateClubViewModel>();
                services.AddTransient<HomeViewModel>();

                // Servicios auxiliares
                services.AddApplicationServices();
            })
            .Build();
    }
}
