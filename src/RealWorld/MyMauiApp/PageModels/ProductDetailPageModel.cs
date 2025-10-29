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

// [QueryProperty(nameof(productId), "id")]
public partial class ProductDetailPageModel : BasePageModel, IQueryAttributable
{

    [ObservableProperty]
    private Product product;

    private readonly IProductService productService;
    public ProductDetailPageModel(IProductService productService)
    {
        this.productService = productService;
    }

    // backfield
    //int productId;

    // Manual
    //public int ProductId
    //{
    //    get {  return productId; }
    //    set { 
    //        productId = value;
    //        OnPropertyChanged(nameof(ProductId));
    //    }
    //}

    // Source Generators

    // backfield
    // Auto
    [ObservableProperty]
    int productId;
     

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.ContainsKey("id"))
        {
            productId = Convert.ToInt32(query["id"]);

            LoadData(productId);
        }
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
