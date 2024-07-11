using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Demo_EntityFrameWorkCore.Data;
using Demo_EntityFrameWorkCore.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ContosoPizzaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ContosoPizzaContext>();

    var veggieSpecial = context.Products
                        .Where(p => p.Name == "Veggie Special Pizza")
                        .FirstOrDefault();

    if (veggieSpecial is Product)
    {
        veggieSpecial.Price = 10.99M;
    }

    context.SaveChanges();

    var products = from product in context.Products
                   where product.Price > 10.99M
                   orderby product.Name
                   select product;

    foreach (Product p in products)
    {
        Console.WriteLine($"Id:   {p.Id}");
        Console.WriteLine($"Name:   {p.Name}");
        Console.WriteLine($"Price:   {p.Price}");
        Console.WriteLine(new string('-', 20));
    }
}

app.Run();
