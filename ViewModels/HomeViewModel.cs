using CommunityToolkit.Mvvm.ComponentModel;
using FUT18Launcher.Models;

namespace FUT18Launcher.ViewModels;

public partial class HomeViewModel : BaseViewModel
{
    [ObservableProperty]
    private string clubName = string.Empty;

    [ObservableProperty]
    private string managerName = string.Empty;

    [ObservableProperty]
    private int coins;

    [ObservableProperty]
    private int level;

    [ObservableProperty]
    private int experience;

    public void LoadClub(Club club)
    {
        ClubName = club.Name;
        ManagerName = club.ManagerName;
        Coins = club.Coins;
        Level = club.Level;
        Experience = club.Experience;
    }
}
