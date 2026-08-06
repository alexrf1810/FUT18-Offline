using FUT18Launcher.Database;
using FUT18Launcher.Models;
using Microsoft.EntityFrameworkCore;

namespace FUT18Launcher.Repositories;

public class ClubRepository : IClubRepository
{
    private readonly AppDbContext _context;

    public ClubRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Club?> GetClubAsync()
    {
        return await _context.Clubs.FirstOrDefaultAsync();
    }

    public async Task SaveClubAsync(Club club)
    {
        if (club.Id == 0)
            _context.Clubs.Add(club);
        else
            _context.Clubs.Update(club);

        await _context.SaveChangesAsync();
    }
}
