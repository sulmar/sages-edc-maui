using Bogus;
using Models;

namespace MyMauiApp.Services;

// Dodanie biblioteki Bogus do udawania danych
// dotnet add package Bogus


// Zbior regul
public class ProductFaker : Faker<Product>
{
    public ProductFaker()
    {
        RuleFor(p => p.Id, f => f.IndexFaker);
        RuleFor(p => p.Name, f => f.Commerce.ProductName());
        RuleFor(p => p.Price, f => Math.Round( f.Random.Decimal(1, 100),2));
        RuleFor(p => p.Quantity, f => f.Random.Int(0, 100));
        RuleFor(p => p.Archived, f => f.Random.Bool(0.2f));
    }
}
