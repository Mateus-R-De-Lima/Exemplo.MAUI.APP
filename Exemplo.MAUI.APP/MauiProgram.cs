using Exemplo.MAUI.APP.Constants;
using Exemplo.MAUI.APP.Navigation;
using Exemplo.MAUI.APP.Views.Pages.Login.DoLogin;
using Exemplo.MAUI.APP.Views.Pages.Login.User.Register;
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
                .AddPages()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("Raleway-Black.ttf", FontFamily.MAIN_FONT_BLACK);
                    fonts.AddFont("Raleway-Regular.ttf", FontFamily.MAIN_FONT_REGULAR);
                    fonts.AddFont("Raleway-Thin.ttf", FontFamily.MAIN_FONT_THIN);
                    fonts.AddFont("WorkSans-Black.ttf", FontFamily.SECONDARY_FONT_BLACK);
                    fonts.AddFont("WorkSans-Regular.ttf", FontFamily.SECONDARY_FONT_REGULAR);
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }


        private static MauiAppBuilder AddPages( this MauiAppBuilder appBuilder)
        {
            Routing.RegisterRoute(RoutePages.LOGIN_PAGE, typeof(DoLoginPage));
            Routing.RegisterRoute(RoutePages.USER_REGISTER_ACCOUNT_PAGE, typeof(RegisterAccountPage));

            return appBuilder;
        }
    }
}
