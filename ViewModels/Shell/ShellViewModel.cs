using CommunityToolkit.Mvvm.ComponentModel;
using FUT18Launcher.Navigation;

namespace FUT18Launcher.ViewModels.Shell;

public partial class ShellViewModel : BaseViewModel
{
    private readonly NavigationStore _navigationStore;

    [ObservableProperty]
    private string clubName = string.Empty;

    [ObservableProperty]
    private int coins;

    [ObservableProperty]
    private int fifaPoints;

    [ObservableProperty]
    private int level;

    public BaseViewModel CurrentViewModel => _navigationStore.CurrentViewModel;

    public ShellViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;

        _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
    }

    private void OnCurrentViewModelChanged()
    {
        OnPropertyChanged(nameof(CurrentViewModel));
    }

    public void LoadClub(
        string clubName,
        int coins,
        int fifaPoints,
        int level)
    {
        ClubName = clubName;
        Coins = coins;
        FIFAPoints = fifaPoints;
        Level = level;
    }
}
