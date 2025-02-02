﻿using Microsoft.Extensions.Logging;

namespace MauiApp1;

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
			})
			.ConfigureMauiHandlers((handlers) =>
			{
#if MACCATALYST
				// Uncomment this handler
				// Workaround for Picker not updating SelectedItem on Mac Catalyst 
				handlers.AddHandler(typeof(Picker), typeof(FixPickerHandler));
#endif
			}
			);

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
