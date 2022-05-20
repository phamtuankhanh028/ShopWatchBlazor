using Microsoft.EntityFrameworkCore;
using ShopWatch.Server.Authentication;
using ShopWatch.Shared;
using System;
using System.Collections.Generic;

namespace ShopWatch.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            

            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.EditionId });
            modelBuilder.Entity<OrderItem>()
                .HasKey(o => new {o.OrderId, o.ProductId});

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Seiko", Url = "seiko", Icon = "Seiko" },
                new Category { Id = 2, Name = "Rolex", Url = "rolex", Icon = "Rolex" },
                new Category { Id = 3, Name = "Longiness", Url = "longiness", Icon = "Longginess" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Đồng hồ Seiko 1",
                    Description = "Đồng hồ nam seiko 1 xuất sứ từ Nhật Bản -  Cơ - Automatic - Kính Khoáng - Size Mặt 37mm - Bảo Hành 5 Năm - Chính Hãng 100%",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/4/46/Seiko-5-blue-gold.jpg",
                    DateCreated = new DateTime(2022, 1, 1)
                },

                new Product
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "Đồng hồ Rolex 1",
                    Description = "Đồng hồ nam Rolex 1 xuất sứ từ Thụy Sỹ -  Cơ - Automatic - Kính Khoáng - Size Mặt 37mm - Bảo Hành 5 Năm - Chính Hãng 100%",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/c/c0/Seiko_Sportura_Chronograph_H023-00A0%2C_2003.jpg",
                    DateCreated = new DateTime(2022, 1, 1)
                },

                new Product
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "Đồng hồ Longiness 1",
                    Description = "Đồng hồ nam Rolex 1 xuất sứ từ Thụy Sỹ -  Cơ - Automatic - Kính Khoáng - Size Mặt 37mm - Bảo Hành 5 Năm - Chính Hãng 100%",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/0/08/Rolex_Daytona_Cosmograph.jpg",
                    DateCreated = new DateTime(2022, 1, 1)
                },

                new Product
                {
                    Id = 4,
                    CategoryId = 1,
                    Title = "Đồng hồ Seiko 2",
                    Description = "Đồng hồ nam Seiko 2 xuất sứ từ Nhật Bản -  Cơ - Automatic - Kính Khoáng - Size Mặt 37mm - Bảo Hành 5 Năm - Chính Hãng 100%",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/9/97/Rolex_Datejust_36_-_On_Display_%2850826140918%29.jpg",
                    DateCreated = new DateTime(2022, 1, 1)
                },

                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "Đồng hồ Rolex 2",
                    Description = "Đồng hồ nam Rolex 2 xuất sứ từ Thụy Sỹ - Pin - Automatic - Kính Khoáng - Size Mặt 37mm - Bảo Hành 5 Năm - Chính Hãng 100%",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/e/ed/Rolex_Datejust_Oysterquartz.jpg",
                    DateCreated = new DateTime(2022, 1, 1)
                },

                new Product
                {
                    Id = 6,
                    CategoryId = 3,
                    Title = "Đồng hồ Longiness 2",
                    Description = "Đồng hồ nam Longiness 2 xuất sứ từ Thụy Sỹ -  Cơ - Automatic - Kính Khoáng - Size Mặt 37mm - Bảo Hành 5 Năm - Chính Hãng 100%",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/1/12/Rolex_5100.jpg",
                    DateCreated = new DateTime(2022, 1, 1)
                }
            );

            modelBuilder.Entity<Edition>().HasData(
                new Edition { Id = 1, Name = "Default" },
                new Edition { Id = 2, Name = "Dây thép không gỉ" },
                new Edition { Id = 3, Name = "Dây cao su" },
                new Edition { Id = 4, Name = "Dây vải" },
                new Edition { Id = 5, Name = "Dây Titanium" },
                new Edition { Id = 6, Name = "Dây Da" }
            );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 2,
                    Price = 200000,
                    OriginalPrice = 300000
                },

                 new ProductVariant
                 {
                     ProductId = 1,
                     EditionId = 5,
                     Price = 250000,
                     OriginalPrice = 300000
                 },

                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 2,
                    Price = 200000,
                    OriginalPrice = 300000
                },

                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 4,
                    Price = 100000,
                    OriginalPrice = 300000
                },

                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 2,
                    Price = 100000,
                    OriginalPrice = 300000
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 1,
                    Price = 300000,
                    OriginalPrice = 300000
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 1,
                    Price = 150000,
                    OriginalPrice = 300000
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 1,
                    Price = 160000,
                    OriginalPrice = 300000
                }
            );


            modelBuilder.Entity<UserAccount>().HasData(
                new UserAccount { Id = 1, UserName = "admin", Password = "admin", Role = "Administrator" },
                new UserAccount { Id = 2, UserName = "user", Password = "user", Role = "User" }
                );
        }
    }
}
