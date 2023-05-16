using Microsoft.EntityFrameworkCore;
using Shared;
using System.Data;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
      //  {

          // modelBuilder.Entity<Order>()
          //.HasMany(e => e.OrderItems)
          //.WithOne(e => e.Order)
          //.HasForeignKey(e => e.OrderId)
          //.IsRequired();

          //  modelBuilder.Entity<Product>()
          // .HasMany(e => e.OrderItems)
          // .WithOne(e => e.Product)
          // .HasForeignKey(e => e.ProductId)
          // .IsRequired();

          //  modelBuilder.Entity<ProductType>()
          // .HasMany(e => e.Products)
          // .WithOne(e => e.ProductType)
          // .HasForeignKey(e => e.ProductTypeId)
          // .IsRequired();

          //  modelBuilder.Entity<Supplier>()
          // .HasMany(e => e.Orders)
          // .WithOne(e => e.Supplier)
          // .HasForeignKey(e => e.SupplierId)
          // .IsRequired();

            //modelBuilder.Entity<OrderItem>().HasNoKey();
            // modelBuilder.Entity<OrderItem>()
            //.HasKey(oi => new { oi.OrderId });
   //     }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
            
            modelBuilder.Entity<ProductType>().HasData(
              new ProductType { Id = 1, Name="เครื่องใช้ไฟฟ้า",  },
              new ProductType { Id = 2, Name = "เครื่องครัว" }

             );
            modelBuilder.Entity<Product>().HasData(
             new Product { Id = 1, Title= "คอมพิวเตอร์" , Description="Core i 2 ram 123 Mb " , ImageUrl="" , Price=123, Unit = "เครื่อง"  },
             new Product { Id = 2, Title = "มีสปาด้า", Description = "คมๆ", ImageUrl = "", Price = 20, Unit = "ด้าม", },
             new Product { Id = 3, Title = "Blizzard", Description = "???", ImageUrl = "", Price = 123, Unit = "???"}
            );

            modelBuilder.Entity<Supplier>().HasData(
             new Supplier { Id = 1, Name="ไม่บอก", Address="......", OfficeName = "..." , TaxID="...." , PostalCode = "...."}
         
            );
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


    }
}
