﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebShopPet.Models;

namespace WebShopPet.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240625034929_AddTableOrder_OrderDetail")]
    partial class AddTableOrder_OrderDetail
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebShopPet.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Bull"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Alaska"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Husky"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Chihuahua"
                        });
                });

            modelBuilder.Entity("WebShopPet.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebShopPet.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MaHD")
                        .HasColumnType("int");

                    b.Property<int?>("MaSP")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaHD");

                    b.HasIndex("MaSP");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("WebShopPet.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "Bull Anh",
                            Price = 300.0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Name = "Bull Pháp",
                            Price = 350.0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Name = "American Bully",
                            Price = 400.0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Name = "American Pit Bull Terrier",
                            Price = 420.0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Name = "Alaska Sable – trắng",
                            Price = 630.0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Name = "Alaska màu lông xám – trắng",
                            Price = 750.0
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Name = "Alaska màu lông nâu đỏ – trắng",
                            Price = 820.0
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Name = "Husky màu đen trắng",
                            Price = 950.0
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Name = "Husky màu xám",
                            Price = 1200.0
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Name = "Husky màu trắng tinh khiết ",
                            Price = 1450.0
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Name = "Husky màu đồng hoặc đỏ",
                            Price = 750.0
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 4,
                            Name = "Chihuahua Socola",
                            Price = 1250.0
                        });
                });

            modelBuilder.Entity("WebShopPet.Models.OrderDetail", b =>
                {
                    b.HasOne("WebShopPet.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("MaHD");

                    b.HasOne("WebShopPet.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("MaSP");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebShopPet.Models.Product", b =>
                {
                    b.HasOne("WebShopPet.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
