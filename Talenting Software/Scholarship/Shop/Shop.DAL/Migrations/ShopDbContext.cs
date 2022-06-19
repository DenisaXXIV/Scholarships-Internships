using Microsoft.EntityFrameworkCore;
using Shop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Migrations
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderedProduct> OrderedProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingCartProduct> ShoppingCartProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>().HasData(

                new Client
                {
                    ClientID = 1,
                    Name = "Florian-Andrei Barbu",
                    Street = "Bulevardul Castanilor",
                    Number = "3A",
                    City = "Ploiesti",
                    Country = "Romania",
                    PhoneNumber = "0755864567",
                    GenderId = 2
                },
                new Client
                {
                    ClientID = 2,
                    Name = "Augustina Petrica",
                    Street = "Strada Cuza Voda",
                    Number = "18",
                    City = "Sinaia",
                    Country = "Romania",
                    PhoneNumber = "0700591298",
                    GenderId = 1
                });

            modelBuilder.Entity<Gender>().HasData(
                 new Gender
                 {
                     GenderId = 1,
                     ThisGender = 'F'
                 },
                 new Gender
                 {
                     GenderId = 2,
                     ThisGender = 'M'
                 });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Curmale uscate",
                    Price = "18,00",
                    ExpirationDate = "2023-04-30"
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Conserva File de Macrou",
                    Price = "3,50",
                    ExpirationDate = "2025-04-07"
                });

            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    OrderId = 1,
                    ClientId = 2,
                    CreatedDate = "2022-06-10",
                    TotalAmount = 3.00f,
                    Discount = 15
                },
                new Order
                {
                    OrderId = 2,
                    ClientId = 1,
                    CreatedDate = "2022-06-09",
                    TotalAmount = 15.00f,
                    Discount = 20
                });

            modelBuilder.Entity<OrderedProduct>().HasData(
                new OrderedProduct
                {
                    OrderedProductId = 1,
                    OrderId = 1,
                    ProductId = 2
                },
                new OrderedProduct
                {
                    OrderedProductId = 2,
                    OrderId = 2,
                    ProductId = 1
                });

            modelBuilder.Entity<ShoppingCart>().HasData(
                new ShoppingCart
                {
                    ShoppingCartId = 1,
                    TotalAmount = 3.00f,
                    HasExpired = true,
                    ClientId = 1
                },
                new ShoppingCart
                {
                    ShoppingCartId = 2,
                    TotalAmount = 15.00f,
                    HasExpired = false,
                    ClientId = 2
                });

            modelBuilder.Entity<ShoppingCartProduct>().HasData(
                new ShoppingCartProduct
                {
                    ShoppingCartProductId = 1,
                    ShoppingCartId = 1,
                    ProductId = 2
                },
                new ShoppingCartProduct
                {
                    ShoppingCartProductId = 2,
                    ShoppingCartId = 2,
                    ProductId = 1
                });
        }
    }
}
