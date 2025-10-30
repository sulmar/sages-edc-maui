using Bogus;
using Models;
using MyMauiApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMauiApp.Services;


public class FakeProductService : IProductService
{
    private readonly List<Product> products;

    public FakeProductService(Faker<Product> faker)
    {
        products = faker.Generate(100);
    }

    public Product Get(int id)
    {
        return products.Single(p => p.Id == id);
    }

    public List<Product> GetAll()
    {
        return products;
    }

    public Task<List<Product>> GetAllAsync()
    {
        return Task.FromResult(products);
    }

    public Task<Product> GetAsync(int id)
    {
       return Task.FromResult(products.Single(p => p.Id == id));
    }

    public List<Product> GetByColor(string color)
    {
        throw new NotImplementedException();
    }
}
