using CommunityToolkit.Mvvm.Input;
using Models;
using MyMauiApp.Abstractions;
using MyMauiApp.Commands;   

namespace MyMauiApp.PageModels;

public partial class ProductsPageModel : BasePageModel
{
    public List<Product> Products { get; set; }
    public Product SelectedProduct { get; set; }

    private readonly IProductService _productService;

    public ProductsPageModel(IProductService productService)
    {
        _productService = productService;
    }

    [RelayCommand]
    private async Task NavigateToProduct(Product product)
    {        
        await Shell.Current.GoToAsync($"product?id={product.Id}"); // Query
    }

    public void MakeReservation()
    {
        Console.WriteLine("making...");

        throw new NotImplementedException();
        
    }

    [RelayCommand]
    private async Task LoadData()
    {
        Products = await _productService.GetAllAsync();
    }
}
