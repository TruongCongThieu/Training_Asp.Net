using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
  {
             new Product { Id = 1, Name = "Laptop", Price = 999.99m },
                new Product { Id = 2, Name = "Smartphone", Price = 599.99m },
                new Product { Id = 3, Name = "Tablet", Price = 399.99m },
                 new Product { Id = 4, Name = "Laptop", Price = 999.99m },
                new Product { Id = 5, Name = "Smartphone", Price = 599.99m },
                new Product { Id = 6, Name = "Tablet", Price = 399.99m }
  };

            return View(products);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }
    }
}

