using Microsoft.EntityFrameworkCore;
using Shared;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>().HasNoKey();
        }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<Supplier> Supplier { get; set; }
        //public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
       // public DbSet<OrderItem> OrderItems { get; set; }
   
   
    }
}
