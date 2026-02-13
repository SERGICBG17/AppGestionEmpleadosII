using AppGestionEmpleadosII.UI.Pages;
using AppGestionEmpleadosII.UI.PagesViewModels;
using Microsoft.Extensions.Logging;

namespace AppGestionEmpleadosII
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<MainPageModel>();
            //builder.Services.AddTransient<DepartamentosPageModel>();
            //builder.Services.AddTransient<EmpleadosPageModel>();
            //builder.Services.AddTransient<GraficosPageModel>();
            //builder.Services.AddTransient<SedesPageModel>();
            //builder.Services.AddTransient<SettingsPageModel>();

            builder.Services.AddTransient<MainPage>();
            //builder.Services.AddTransient<DepartamentosPage>();
            //builder.Services.AddTransient<EmpleadosPage>();
            //builder.Services.AddTransient<GraficosPage>();
            //builder.Services.AddTransient<SedesPage>();
            //builder.Services.AddTransient<SettingsPage>();

            return builder.Build();
        }
    }
}
