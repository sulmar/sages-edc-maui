using Models;
using MyMauiApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMauiApp.PageModels;

public class ProductsPageModel : BasePageModel
{
    public List<Product> Products { get; set; }
    public Product SelectedProduct { get; set; }

    public ProductsPageModel(IProductService productService)
    {
        Products = productService.GetAll();
    }

    public void MakeReservation()
    {
        Console.WriteLine("making...");

        throw new NotImplementedException();
    }
}
