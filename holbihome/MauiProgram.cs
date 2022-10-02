using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui;

namespace holbihome;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseMauiApp<App>().UseMauiCommunityToolkit().ConfigureFonts(fonts => {
			fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			fonts.AddFont("fa_solid.ttf", "FontAwesome");
		});

		return builder.Build();
	}
}

