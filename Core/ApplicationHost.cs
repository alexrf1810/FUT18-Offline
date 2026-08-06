using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FUT18Launcher.Navigation;
using FUT18Launcher.Services;
using FUT18Launcher.ViewModels;

namespace FUT18Launcher.Core;

public static class ApplicationHost
{
    public static IHost BuildHost()
    {
        return Host.CreateDefaultBuilder()

            .ConfigureServices((context, services) =>
            {
                services.AddSingleton<MainViewModel>();

                services.AddApplicationServices();

            })

            .Build();
    }
}
