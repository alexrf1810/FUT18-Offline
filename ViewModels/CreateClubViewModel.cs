using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FUT18Launcher.Models;
using FUT18Launcher.Repositories;

namespace FUT18Launcher.ViewModels;

public partial class CreateClubViewModel : BaseViewModel
{
    private readonly IClubRepository _clubRepository;

    [ObservableProperty]
    private string clubName = string.Empty;

    [ObservableProperty]
    private string managerName = string.Empty;

    [ObservableProperty]
    private string statusMessage = string.Empty;

    public CreateClubViewModel(IClubRepository clubRepository)
    {
        _clubRepository = clubRepository;
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

        var existingClub = await _clubRepository.GetClubAsync();

        if (existingClub != null)
        {
            StatusMessage = "Ya existe un club creado.";
            return;
        }

        var club = new Club
        {
            Name = ClubName.Trim(),
            ManagerName = ManagerName.Trim(),
            Coins = 500,
            Level = 1,
            Experience = 0
        };

        await _clubRepository.SaveClubAsync(club);

        StatusMessage = "¡Club creado correctamente!";
    }
}
