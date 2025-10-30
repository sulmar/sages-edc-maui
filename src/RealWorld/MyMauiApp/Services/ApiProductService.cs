using Models;
using MyMauiApp.Abstractions;
using System.Net.Http.Json;

namespace MyMauiApp.Services;

public class ApiProductService : IProductService
{
    private readonly HttpClient _http;

    public ApiProductService(HttpClient http)
    {
        _http = http;
    }

    public Product Get(int id)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<List<Product>> GetAllAsync()
    {
        return _http.GetFromJsonAsync<List<Product>>("api/products");
    }

    public Task<Product> GetAsync(int id)
    {
        return _http.GetFromJsonAsync<Product>($"api/products/{id}");
    }

    public List<Product> GetByColor(string color)
    {
        throw new NotImplementedException();
    }
}
