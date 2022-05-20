﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopWatch.Server.Data;

namespace ShopWatch.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220517151529_UserAccounts")]
    partial class UserAccounts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShopWatch.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "Seiko",
                            Name = "Seiko",
                            Url = "seiko"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "Rolex",
                            Name = "Rolex",
                            Url = "rolex"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "Longginess",
                            Name = "Longiness",
                            Url = "longiness"
                        });
                });

            modelBuilder.Entity("ShopWatch.Shared.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Editions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dây thép không gỉ"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Dây cao su"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Dây vải"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Dây Titanium"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Dây Da"
                        });
                });

            modelBuilder.Entity("ShopWatch.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồng hồ nam seiko 5 xuất sứ từ Nhật Bản - đường kính 34mm - dây kim loại - máy cơ",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/4/46/Seiko-5-blue-gold.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Đồng hồ Seiko 5"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            DateCreated = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồng hồ nam seiko 5 xuất sứ từ Nhật Bản - đường kính 34mm - dây kim loại - máy cơ",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/c/c0/Seiko_Sportura_Chronograph_H023-00A0%2C_2003.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Đồng hồ Seiko 5"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            DateCreated = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồng hồ nam seiko 5 xuất sứ từ Nhật Bản - đường kính 34mm - dây kim loại - máy cơ",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/0/08/Rolex_Daytona_Cosmograph.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Đồng hồ Seiko 5"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            DateCreated = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồng hồ nam seiko 5 xuất sứ từ Nhật Bản - đường kính 34mm - dây kim loại - máy cơ",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/9/97/Rolex_Datejust_36_-_On_Display_%2850826140918%29.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Đồng hồ Seiko 5"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            DateCreated = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồng hồ nam seiko 5 xuất sứ từ Nhật Bản - đường kính 34mm - dây kim loại - máy cơ",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/e/ed/Rolex_Datejust_Oysterquartz.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Đồng hồ Seiko 5"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            DateCreated = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đồng hồ nam seiko 5 xuất sứ từ Nhật Bản - đường kính 34mm - dây kim loại - máy cơ",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/1/12/Rolex_5100.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Đồng hồ Seiko 5"
                        });
                });

            modelBuilder.Entity("ShopWatch.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("EditionId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "EditionId");

                    b.HasIndex("EditionId");

                    b.ToTable("ProductVariant");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            EditionId = 2,
                            OriginalPrice = 100000m,
                            Price = 200000m
                        },
                        new
                        {
                            ProductId = 1,
                            EditionId = 4,
                            OriginalPrice = 0m,
                            Price = 200000m
                        },
                        new
                        {
                            ProductId = 2,
                            EditionId = 2,
                            OriginalPrice = 100000m,
                            Price = 200000m
                        },
                        new
                        {
                            ProductId = 2,
                            EditionId = 4,
                            OriginalPrice = 0m,
                            Price = 200000m
                        },
                        new
                        {
                            ProductId = 3,
                            EditionId = 2,
                            OriginalPrice = 0m,
                            Price = 200000m
                        });
                });

            modelBuilder.Entity("ShopWatch.Shared.UserAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserAccounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "admin",
                            Role = "Administrator",
                            UserName = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Password = "user",
                            Role = "User",
                            UserName = "user"
                        });
                });

            modelBuilder.Entity("ShopWatch.Shared.Product", b =>
                {
                    b.HasOne("ShopWatch.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ShopWatch.Shared.ProductVariant", b =>
                {
                    b.HasOne("ShopWatch.Shared.Edition", "Edition")
                        .WithMany()
                        .HasForeignKey("EditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopWatch.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Edition");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShopWatch.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}
