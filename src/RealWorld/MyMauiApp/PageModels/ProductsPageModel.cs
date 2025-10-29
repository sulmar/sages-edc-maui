using Models;
using MyMauiApp.Abstractions;
using MyMauiApp.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyMauiApp.PageModels;

public class ProductsPageModel : BasePageModel
{
    public List<Product> Products { get; set; }
    public Product SelectedProduct { get; set; }


    public ICommand NavigateToProductCommand { get; }

    public ProductsPageModel(IProductService productService)
    {
        Products = productService.GetAll();

        NavigateToProductCommand = new RelayCommand<Product>(NavigateToProduct);
    }

    public void NavigateToProduct(Product product)
    {
        // TODO: display ProductPage
    }

    public void MakeReservation()
    {
        Console.WriteLine("making...");

        throw new NotImplementedException();
    }
}
