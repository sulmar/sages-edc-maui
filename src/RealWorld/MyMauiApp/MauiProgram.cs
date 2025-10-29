using Microsoft.Extensions.Logging;
using MyMauiApp.Abstractions;
using MyMauiApp.PageModels;
using MyMauiApp.Services;

namespace MyMauiApp
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

            // Rejestracja uslug w konterzene wstrzykiwania zaleznosci (Dependency Injection)
            builder.Services.AddTransient<ProductsPageModel>();
            builder.Services.AddTransient<IProductService, FakeProductService>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
