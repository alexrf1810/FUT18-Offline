using System.Windows;
using FUT18Launcher.ViewModels.Shell;
using Microsoft.Extensions.DependencyInjection;

namespace FUT18Launcher;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        DataContext = App.Host.Services.GetRequiredService<ShellViewModel>();
    }
}
