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
        return await _context.Clubs
            .Include(c => c.Players)
            .FirstOrDefaultAsync();
    }

    public async Task<bool> ClubExistsAsync()
    {
        return await _context.Clubs.AnyAsync();
    }

    public async Task SaveClubAsync(Club club)
    {
        await _context.Clubs.AddAsync(club);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateClubAsync(Club club)
    {
        _context.Clubs.Update(club);
        await _context.SaveChangesAsync();
    }
}
