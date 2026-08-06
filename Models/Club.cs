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

    // Economía
    public int Coins { get; set; } = 500;

    public int FIFAPoints { get; set; } = 0;

    // Progresión
    public int Level { get; set; } = 1;

    public int Experience { get; set; } = 0;

    // Fechas
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime LastLogin { get; set; } = DateTime.UtcNow;

    // Personalización
    public int BadgeId { get; set; } = 1;

    public int StadiumId { get; set; } = 1;

    public int BallId { get; set; } = 1;

    public int HomeKitId { get; set; } = 1;

    public int AwayKitId { get; set; } = 2;

    // Colecciones
    public ICollection<Player> Players { get; set; } = new List<Player>();
}
