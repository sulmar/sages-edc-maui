using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMauiApp.Abstractions;

public interface IProductService : IEntityService<Product>
{
    List<Product> GetByColor(string color);
}
