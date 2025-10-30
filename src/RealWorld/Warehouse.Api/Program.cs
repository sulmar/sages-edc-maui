using Microsoft.AspNetCore.Mvc;
using Warehouse.Api.Abstractions;
using Warehouse.Api.Infrastructures;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IProductRepository, FakeProductRepository>();

var app = builder.Build();

app.UseHttpsRedirection();

/* PHP Laravel

use Illuminate\Support\Facades\Route;

Route::get('/greeting', function () {
    return 'Hello World';
});

*/

app.MapGet("/greeting", () => "Hello World");
app.MapGet("/", () => "Hello Api!");

app.MapGet("/api/products", (IProductRepository repository) => repository.GetAll());
app.MapGet("/api/products/{id}", (IProductRepository productRepository, int id) => productRepository.Get(id));

// /api/products?color=red&from=100&to=200
//app.MapGet("/api/products", (IProductRepository repository, [FromQuery] ProductSearchCriteria criteria) => criteria);

app.Run();

// record ProductSearchCriteria(string? color, decimal? from, decimal? to);
