using Models;

namespace Warehouse.Api.Abstractions;

public interface IProductRepository
{
    List<Product> GetAll();
    Product? Get(int id);
}
