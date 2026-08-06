using System.Windows;
using Microsoft.Extensions.Hosting;
using FUT18Launcher.Core;

namespace FUT18Launcher;

public partial class App : Application
{
    public static IHost Host { get; private set; } = null!;

    protected override void OnStartup(StartupEventArgs e)
    {
        Host = ApplicationHost.BuildHost();

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
