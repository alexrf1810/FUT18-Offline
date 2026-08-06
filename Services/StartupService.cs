using FUT18Launcher.Navigation;
using FUT18Launcher.ViewModels;

namespace FUT18Launcher.Services;

public class StartupService
{
    private readonly IClubService _clubService;
    private readonly INavigationService _navigationService;
    private readonly CreateClubViewModel _createClubViewModel;
    private readonly HomeViewModel _homeViewModel;

    public StartupService(
        IClubService clubService,
        INavigationService navigationService,
        CreateClubViewModel createClubViewModel,
        HomeViewModel homeViewModel)
    {
        _clubService = clubService;
        _navigationService = navigationService;
        _createClubViewModel = createClubViewModel;
        _homeViewModel = homeViewModel;
    }

    public async Task InitializeAsync()
    {
        if (await _clubService.ClubExistsAsync())
        {
            var club = await _clubService.GetClubAsync();

            if (club != null)
            {
                _homeViewModel.LoadClub(club);
                _navigationService.Navigate(_homeViewModel);
                return;
            }
        }

        _navigationService.Navigate(_createClubViewModel);
    }
}
