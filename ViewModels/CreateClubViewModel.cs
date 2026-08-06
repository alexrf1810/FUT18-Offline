using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FUT18Launcher.Navigation;
using FUT18Launcher.Services;

namespace FUT18Launcher.ViewModels;

public partial class CreateClubViewModel : BaseViewModel
{
    private readonly IClubService _clubService;
    private readonly INavigationService _navigationService;
    private readonly HomeViewModel _homeViewModel;

    [ObservableProperty]
    private string clubName = string.Empty;

    [ObservableProperty]
    private string managerName = string.Empty;

    [ObservableProperty]
    private string statusMessage = string.Empty;

    public CreateClubViewModel(
        IClubService clubService,
        INavigationService navigationService,
        HomeViewModel homeViewModel)
    {
        _clubService = clubService;
        _navigationService = navigationService;
        _homeViewModel = homeViewModel;
    }

    [RelayCommand]
    private async Task CreateClub()
    {
        StatusMessage = string.Empty;

        if (string.IsNullOrWhiteSpace(ClubName))
        {
            StatusMessage = "Introduce un nombre para el club.";
            return;
        }

        if (string.IsNullOrWhiteSpace(ManagerName))
        {
            StatusMessage = "Introduce el nombre del entrenador.";
            return;
        }

        if (await _clubService.ClubExistsAsync())
        {
            StatusMessage = "Ya existe un club creado.";
            return;
        }

        var club = await _clubService.CreateClubAsync(
            ClubName,
            ManagerName);

        _homeViewModel.LoadClub(club);

        _navigationService.Navigate(_homeViewModel);
    }
}
