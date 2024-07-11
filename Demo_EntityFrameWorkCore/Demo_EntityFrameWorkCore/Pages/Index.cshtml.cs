using Microsoft.AspNetCore.Mvc.RazorPages;
using Demo_EntityFrameWorkCore.Data;
using Demo_EntityFrameWorkCore.Models;
using System.Collections.Generic;
using System.Linq;

public class IndexModel : PageModel
{
    private readonly ContosoPizzaContext _context;

    public IndexModel(ContosoPizzaContext context)
    {
        _context = context;
    }

    public IList<Product> Products { get; set; }

    public void OnGet()
    {
        Products = _context.Products
                            .Where(p => p.Price > 10.99M)
                            .OrderBy(p => p.Name)
                            .ToList();
    }
}
