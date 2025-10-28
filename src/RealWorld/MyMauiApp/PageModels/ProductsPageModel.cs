using Models;
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

    public ProductsPageModel()
    {
        Products = new List<Product>
        {
            new Product { Id = 1, Name = "Product A", Price = 1.99m, Quantity = 1 } ,
            new Product { Id = 2, Name = "Product B", Price = 20m, Quantity = 5 } ,
            new Product { Id = 3, Name = "Product C", Price = 30m, Quantity = 10 } ,
            new Product { Id = 4, Name = "Product D", Price = 40m, Quantity = 3 } ,
            new Product { Id = 5, Name = "Product E", Price = 50m, Quantity = 0 } ,
        };
    }

    public void MakeReservation()
    {
        Console.WriteLine("making...");

        throw new NotImplementedException();
    }
}
