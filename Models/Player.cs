namespace FUT18Launcher.Models;

public class Player
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public int Overall { get; set; }

    public string Nation { get; set; } = string.Empty;

    public string League { get; set; } = string.Empty;

    public string Club { get; set; } = string.Empty;

    public string Position { get; set; } = string.Empty;
}
