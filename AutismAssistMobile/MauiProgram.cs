using Microsoft.Extensions.Logging;
using AutismAssistMobile.Data;
using Microsoft.EntityFrameworkCore;
using AutismAssistMobile.Shared;

namespace AutismAssistMobile;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var dataDir = FileSystem.AppDataDirectory;
		var dbPath = Path.Combine(dataDir, "friend.db");
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
		  // Add the FriendContext to the service collection
                builder.Services.AddDbContext<FriendContext>(options =>
					options.UseSqlite($"Data Source={dbPath}"));

                // Add the FriendService to the service collection
                builder.Services.AddScoped<IFriendService, FriendService>();

                // Seed the database if necessary
                using var scope = builder.Services.BuildServiceProvider().CreateScope();
                var db = scope.ServiceProvider.GetRequiredService<FriendContext>();
                if (db.Database.EnsureCreated())
                {
                    SeedData.Initialize(db);
                }
#endif

		builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}

