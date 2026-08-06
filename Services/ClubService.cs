using FUT18Launcher.Models;
using FUT18Launcher.Repositories;

namespace FUT18Launcher.Services;

public class ClubService : IClubService
{
    private readonly IClubRepository _clubRepository;

    public ClubService(IClubRepository clubRepository)
    {
        _clubRepository = clubRepository;
    }

    public async Task<bool> ClubExistsAsync()
    {
        return await _clubRepository.ClubExistsAsync();
    }

    public async Task<Club?> GetClubAsync()
    {
        return await _clubRepository.GetClubAsync();
    }

    public async Task<Club> CreateClubAsync(string clubName, string managerName)
    {
        var club = new Club
        {
            Name = clubName.Trim(),
            ManagerName = managerName.Trim(),
            Coins = 500,
            Level = 1,
            Experience = 0,
            BadgeId = 1,
            StadiumId = 1,
            BallId = 1,
            HomeKitId = 1,
            AwayKitId = 2,
            CreatedAt = DateTime.UtcNow,
            LastLogin = DateTime.UtcNow
        };

        await _clubRepository.SaveClubAsync(club);

        return club;
    }
}
