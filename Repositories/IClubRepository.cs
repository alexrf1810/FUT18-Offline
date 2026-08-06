using FUT18Launcher.Models;

namespace FUT18Launcher.Repositories;

public interface IClubRepository
{
    Task<Club?> GetClubAsync();

    Task SaveClubAsync(Club club);
}
