using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMauiApp.Abstractions;

// Szablon (Interfejs generyczny)
public interface IEntityService<T>
{
    List<T> GetAll();
    T Get(int id);
}

public interface IProductService : IEntityService<Product>
{
    List<Product> GetByColor(string color);
}


public interface ICustomerService : IEntityService<Customer>
{
}