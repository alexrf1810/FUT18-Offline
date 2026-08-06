using System.ComponentModel.DataAnnotations;

namespace FUT18Launcher.Models;

public class Club
{
    public int Id { get; set; }

    [Required]
    [MaxLength(64)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MaxLength(64)]
    public string ManagerName { get; set; } = string.Empty;

    public int Coins { get; set; } = 500;

    public int Level { get; set; } = 1;

    public int Experience { get; set; } = 0;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime LastLogin { get; set; } = DateTime.UtcNow;

    public int BadgeId { get; set; }

    public int StadiumId { get; set; }

    public int BallId { get; set; }

    public int HomeKitId { get; set; }

    public int AwayKitId { get; set; }

    public ICollection<Player> Players { get; set; } = new List<Player>();
}
