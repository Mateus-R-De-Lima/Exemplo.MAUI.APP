using Microsoft.Extensions.Logging;

namespace Exemplo.MAUI.APP
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
                    fonts.AddFont("Raleway-Black.ttf", "RalewayBlack");
                    fonts.AddFont("Raleway-Regular.ttf", "RalewayRegular");
                    fonts.AddFont("Raleway-Thin.ttf", "RalewayThin");
                    fonts.AddFont("WorkSans-Black.ttf", "WorkSansBlack");
                    fonts.AddFont("WorkSans-Regular.ttf", "WorkSansRegular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
