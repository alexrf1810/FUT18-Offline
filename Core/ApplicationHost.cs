using FUT18Launcher.Database;
using FUT18Launcher.Navigation;
using FUT18Launcher.Repositories;
using FUT18Launcher.Services;
using FUT18Launcher.ViewModels;
using FUT18Launcher.ViewModels.Club;
using FUT18Launcher.ViewModels.Home;
using FUT18Launcher.ViewModels.Market;
using FUT18Launcher.ViewModels.SBC;
using FUT18Launcher.ViewModels.Shell;
using FUT18Launcher.ViewModels.Squad;
using FUT18Launcher.ViewModels.Store;
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
                // Base de datos
                services.AddDbContext<AppDbContext>(options =>
                {
                    options.UseSqlite("Data Source=fut18offline.db");
                });

                // Navegación
                services.AddSingleton<NavigationStore>();
                services.AddSingleton<INavigationService, NavigationService>();

                // Repositorios
                services.AddScoped<IClubRepository, ClubRepository>();

                // Servicios
                services.AddScoped<IClubService, ClubService>();
                services.AddSingleton<StartupService>();

                // ViewModels principales
                services.AddSingleton<MainViewModel>();
                services.AddSingleton<ShellViewModel>();

                // ViewModels
                services.AddTransient<CreateClubViewModel>();
                services.AddTransient<HomeViewModel>();
                services.AddTransient<SquadViewModel>();
                services.AddTransient<StoreViewModel>();
                services.AddTransient<ClubViewModel>();
                services.AddTransient<MarketViewModel>();
                services.AddTransient<SbcViewModel>();

                // Servicios auxiliares
                services.AddApplicationServices();
            })
            .Build();
    }
}
