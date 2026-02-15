using AppGestionEmpleadosII.Models;
using AppGestionEmpleadosII.Services;
using AppGestionEmpleadosII.UI.Pages;
using AppGestionEmpleadosII.UI.Pages.Detalle;
using AppGestionEmpleadosII.UI.PagesModel;
using AppGestionEmpleadosII.UI.PagesModel.Detalle;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace AppGestionEmpleadosII
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<EmpleadoService>();
            builder.Services.AddSingleton<DepartamentoService>();
            builder.Services.AddSingleton<SedeService>();

            builder.Services.AddTransient<MainPageModel>();
            builder.Services.AddTransient<DepartamentosPageModel>();
            builder.Services.AddTransient<EmpleadosPageModel>();
            builder.Services.AddTransient<GraficosPageModel>();
            builder.Services.AddTransient<SedesPageModel>();
            builder.Services.AddTransient<SettingsPageModel>();

            builder.Services.AddTransient<DetalleEmpleadoPageModel>();
            builder.Services.AddTransient<DetalleDepartamentoPageModel>();
            builder.Services.AddTransient<DetalleSedePageModel>();

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<DepartamentosPage>();
            builder.Services.AddTransient<EmpleadosPage>();
            builder.Services.AddTransient<GraficosPage>();
            builder.Services.AddTransient<SedesPage>();
            builder.Services.AddTransient<SettingsPage>();

            builder.Services.AddTransient<DetalleEmpleadoPage>();
            builder.Services.AddTransient<DetalleDepartamentoPage>();
            builder.Services.AddTransient<DetalleSedePage>();

            return builder.Build();
        }
    }
}
