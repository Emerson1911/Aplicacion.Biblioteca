using Microsoft.Extensions.Logging;

namespace Biblioteca;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("fontello.ttf", "icon");
                fonts.AddFont("Rubik-Italic-VariableFont_wght.ttf", "Ruby");
                fonts.AddFont("Rubik-VariableFont_wght", "Rubi"); ;
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
