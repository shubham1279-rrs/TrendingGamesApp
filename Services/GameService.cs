using TrendingGamesApp.Models;

namespace TrendingGamesApp.Services;

public class GameService
{
    private static List<Game> games = new()
    {
        new Game { Id = 1, Title = "Game A", Genre = "Action", Description = "An action-packed adventure", Rating = 4.5 },
        new Game { Id = 2, Title = "Game B", Genre = "Strategy", Description = "A strategy game to test your wits", Rating = 4.2 },
        new Game { Id = 3, Title = "Game C", Genre = "RPG", Description = "Role-playing experience", Rating = 4.7 },
    };

    public List<Game> GetTrendingGames() => games;
}
