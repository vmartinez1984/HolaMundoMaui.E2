using CommunityToolkit.Maui;
using HolaMundo.Maui.MvvmV1.Services;
using Microsoft.Extensions.Logging;

namespace HolaMundo.Maui.MvvmV1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddScoped<ClienteService>();
            builder.Services.AddScoped<UnidadDeTrabajo>();

            return builder.Build();
        }
    }
}
