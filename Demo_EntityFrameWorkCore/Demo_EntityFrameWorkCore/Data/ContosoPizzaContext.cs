using Demo_EntityFrameWorkCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo_EntityFrameWorkCore.Data;

    public class ContosoPizzaContext : DbContext
    {

    
    public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; }=null!;
        public DbSet<Product> Products { get; set; } = null!;   
        public DbSet<OrderDetails> OrderDetails { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-CJFDEDMJ\\THIEUTRUONG;Persist Security Info=True;User ID=Thieu;Password =Thieu2262002;Initial Catalog=DemoEntityFrameworkCore;Trust Server Certificate=True");
        }
    }

