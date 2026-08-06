using FUT18Launcher.Models;

namespace FUT18Launcher.Services;

public interface IClubService
{
    Task<bool> ClubExistsAsync();

    Task<Club?> GetClubAsync();

    Task<Club> CreateClubAsync(string clubName, string managerName);
}
