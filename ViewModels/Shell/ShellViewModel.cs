using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FUT18Launcher.Navigation;
using FUT18Launcher.ViewModels.Club;
using FUT18Launcher.ViewModels.Home;
using FUT18Launcher.ViewModels.Market;
using FUT18Launcher.ViewModels.SBC;
using FUT18Launcher.ViewModels.Squad;
using FUT18Launcher.ViewModels.Store;

namespace FUT18Launcher.ViewModels.Shell;

public partial class ShellViewModel : BaseViewModel
{
    private readonly NavigationStore _navigationStore;

    private readonly HomeViewModel _homeViewModel;
    private readonly SquadViewModel _squadViewModel;
    private readonly StoreViewModel _storeViewModel;
    private readonly ClubViewModel _clubViewModel;
    private readonly MarketViewModel _marketViewModel;
    private readonly SbcViewModel _sbcViewModel;

    [ObservableProperty]
    private string clubName = string.Empty;

    [ObservableProperty]
    private int coins;

    [ObservableProperty]
    private int fifaPoints;

    [ObservableProperty]
    private int level;

    public BaseViewModel CurrentViewModel => _navigationStore.CurrentViewModel;

    public ShellViewModel(
        NavigationStore navigationStore,
        HomeViewModel homeViewModel,
        SquadViewModel squadViewModel,
        StoreViewModel storeViewModel,
        ClubViewModel clubViewModel,
        MarketViewModel marketViewModel,
        SbcViewModel sbcViewModel)
    {
        _navigationStore = navigationStore;

        _homeViewModel = homeViewModel;
        _squadViewModel = squadViewModel;
        _storeViewModel = storeViewModel;
        _clubViewModel = clubViewModel;
        _marketViewModel = marketViewModel;
        _sbcViewModel = sbcViewModel;

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

    [RelayCommand]
    private void OpenHome()
    {
        _navigationStore.CurrentViewModel = _homeViewModel;
    }

    [RelayCommand]
    private void OpenSquad()
    {
        _navigationStore.CurrentViewModel = _squadViewModel;
    }

    [RelayCommand]
    private void OpenStore()
    {
        _navigationStore.CurrentViewModel = _storeViewModel;
    }

    [RelayCommand]
    private void OpenClub()
    {
        _navigationStore.CurrentViewModel = _clubViewModel;
    }

    [RelayCommand]
    private void OpenMarket()
    {
        _navigationStore.CurrentViewModel = _marketViewModel;
    }

    [RelayCommand]
    private void OpenSbc()
    {
        _navigationStore.CurrentViewModel = _sbcViewModel;
    }
}
