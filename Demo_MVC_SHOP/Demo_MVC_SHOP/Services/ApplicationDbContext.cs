using Demo_MVC_SHOP.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo_MVC_SHOP.Services
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options) 
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
