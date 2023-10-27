using Microsoft.Extensions.Logging;
using TaskAppMaui8.Pages;
using TaskAppMaui8.ViewModels;

namespace TaskAppMaui8
{
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
            builder.Services.AddSingleton<MainTaskPage>();
            builder.Services.AddSingleton<MainViewModel>();

            builder.Services.AddTransient<AddItemPage>();
            builder.Services.AddTransient<AddTaskViewModel>();
#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}