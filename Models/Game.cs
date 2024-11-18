namespace TrendingGamesApp.Models;

public class Game
{
    public int Id { get; set; }
    public string? Title { get; set; }        // Mark as nullable
    public string? Genre { get; set; }        // Mark as nullable
    public string? Description { get; set; }  // Mark as nullable
    public double Rating { get; set; }
}
