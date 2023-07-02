using MauiTarefas.Pages;
using MauiTarefas.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiTarefas;

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
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<TarefasPage>();
        builder.Services.AddTransient<DetalhesPage>();
        builder.Services.AddTransient<TarefasPageViewModel>();
        builder.Services.AddTransient<DetalhesPageViewModel>();

        return builder.Build();
	}
}
