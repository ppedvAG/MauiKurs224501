using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;
using System.Diagnostics;

namespace MauiKurs230320;

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

#if ANDROID

		builder.ConfigureLifecycleEvents
			(
				events =>
				{
					events.AddAndroid(android => android
					.OnStart(activity => Debug.Print("AndroidOnStart"))
					.OnStop(activity => Debug.Print("AndroidOnStop"))
					);
				}
			);

#endif


#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
