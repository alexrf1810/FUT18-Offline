using System.Windows;
using FUT18Launcher.ViewModels;

namespace FUT18Launcher;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}
