using TrendingGamesApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddSingleton<GameService>();
builder.Services.AddRazorPages();  // Add this line to configure Razor Pages

var app = builder.Build();

app.MapGet("/api/games", (GameService gameService) => gameService.GetTrendingGames());

app.MapRazorPages();  // Enables Razor Pages

app.Run();
