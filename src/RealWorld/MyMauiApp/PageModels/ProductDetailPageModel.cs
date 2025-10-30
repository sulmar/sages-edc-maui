using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Models;
using MyMauiApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMauiApp.PageModels;

[QueryProperty(nameof(ProductId), "id")]
public partial class ProductDetailPageModel : BasePageModel
{

    [ObservableProperty]
    private Product product;

    private readonly IProductService productService;
    public ProductDetailPageModel(IProductService productService)
    {
        this.productService = productService;
    }

    [ObservableProperty]
    int productId;

    partial void OnProductIdChanged(int value)
    {
        LoadData(value);
    }
   
    private void LoadData(int id)
    {
        Product = productService.Get(id);
    }

    [RelayCommand]
    private void Reserve()
    {
        Product.Available--;

        // TODO: Wyswietl okno dialogowe
    }
}
