using FUT18Launcher.Models;

namespace FUT18Launcher.Repositories;

public interface IClubRepository
{
    Task<Club?> GetClubAsync();

    Task<bool> ClubExistsAsync();

    Task SaveClubAsync(Club club);

    Task UpdateClubAsync(Club club);
}
