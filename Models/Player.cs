using System.ComponentModel.DataAnnotations;

namespace FUT18Launcher.Models;

public class Player
{
    public int Id { get; set; }

    [Required]
    [MaxLength(64)]
    public string Name { get; set; } = string.Empty;

    public int Overall { get; set; }

    public string Position { get; set; } = string.Empty;

    public string Nation { get; set; } = string.Empty;

    public string League { get; set; } = string.Empty;

    public string ClubName { get; set; } = string.Empty;

    public bool Rare { get; set; }

    public int Pace { get; set; }

    public int Shooting { get; set; }

    public int Passing { get; set; }

    public int Dribbling { get; set; }

    public int Defending { get; set; }

    public int Physical { get; set; }

    public int Contract { get; set; } = 7;

    public int Fitness { get; set; } = 99;

    public bool Untradeable { get; set; }

    public int ClubId { get; set; }

    public Club? Club { get; set; }
}
