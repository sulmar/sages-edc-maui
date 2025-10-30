using Bogus;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Models;
using MyMauiApp.Abstractions;
using MyMauiApp.PageModels;
using MyMauiApp.Services;
using MyMauiApp.Views.Pages;

namespace MyMauiApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                // Initialize the .NET MAUI Community Toolkit by adding the below line of code
                .UseMauiCommunityToolkit() // dotnet add package CommunityToolkit.Maui
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Rejestracja uslug w konterzene wstrzykiwania zaleznosci (Dependency Injection)
            builder.Services.AddTransient<ProductsPageModel>();

            // dotnet add package Microsoft.Extensions.Http
            builder.Services.AddHttpClient<IProductService, ApiProductService>(client => client.BaseAddress = new Uri("https://localhost:7199"));

            // Fakers
            //builder.Services.AddSingleton<IProductService, FakeProductService>();
            //builder.Services.AddSingleton<Faker<Product>, ProductFaker>();

            // MVVM Toolkit (CommunityToolkit.Mvvm)

            // Routing 
            // Rejestracja trasy
            builder.Services.AddTransientWithShellRoute<ProductDetailPage, ProductDetailPageModel>("product");

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
