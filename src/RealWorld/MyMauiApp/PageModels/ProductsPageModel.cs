using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Models;
using MyMauiApp.Abstractions;
using MyMauiApp.Commands;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MyMauiApp.PageModels;

public partial class ProductsPageModel : BasePageModel
{
    [ObservableProperty]
    private ObservableCollection<Product> products = [];

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
        // await Shell.Current.DisplayAlert("Debug", "LoadData", "OK");

        //  Products = await _productService.GetAllAsync();

        try
        {
            var products = await _productService.GetAllAsync();

            Products.Clear();

            foreach (var product in products)
            {
                Products.Add(product);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
        }

    }

}
