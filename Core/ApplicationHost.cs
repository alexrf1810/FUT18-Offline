using FUT18Launcher.Database;
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
                services.AddDbContext<AppDbContext>(options =>
                {
                    options.UseSqlite("Data Source=fut18offline.db");
                });

                services.AddSingleton<MainViewModel>();

                services.AddApplicationServices();
            })

            .Build();
    }
}
services.AddTransient<CreateClubViewModel>();
