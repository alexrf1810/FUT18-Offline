using FUT18Launcher.Core;
using FUT18Launcher.Database;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace FUT18Launcher;

public partial class App : Application
{
    public static IHost Host { get; private set; } = null!;

    protected override void OnStartup(StartupEventArgs e)
    {
        Host = ApplicationHost.BuildHost();

        using var scope = Host.Services.CreateScope();

        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        db.Database.EnsureCreated();

        Host.Start();

        base.OnStartup(e);
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        await Host.StopAsync();

        Host.Dispose();

        base.OnExit(e);
    }
}
