using Models;
using Warehouse.Api.Abstractions;

namespace Warehouse.Api.Infrastructures;

public class FakeProductRepository : IProductRepository
{
    private readonly List<Product> products;

    public FakeProductRepository()
    {
        products = new List<Product>
        {
            new Product  { Id = 1,   Name = "Product #1", Price = 10.99m, Available = 10, Quantity = 1 },
            new Product  { Id = 2,   Name = "Product #2", Price = 1.99m, Available = 20, Quantity = 1 },
            new Product  { Id = 3,   Name = "Product #3", Price = 20.99m, Available = 30, Quantity = 1 },
            new Product  { Id = 4,   Name = "Product #4", Price = 30.99m, Available = 40, Quantity = 1 },
            new Product  { Id = 5,   Name = "Product #5", Price = 40.99m, Available = 50, Quantity = 1 },
        };
    }

    public Product? Get(int id)
    {
        return products.SingleOrDefault(p => p.Id == id);
    }

    public List<Product> GetAll()
    {
        return products;
    }
}
