using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using FUT18Launcher.ViewModels;

namespace FUT18Launcher;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        DataContext = App.Host.Services.GetRequiredService<MainViewModel>();
    }
}
