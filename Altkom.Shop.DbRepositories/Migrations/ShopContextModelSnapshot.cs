﻿// <auto-generated />
using System;
using Altkom.Shop.DbRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Altkom.Shop.DbRepositories.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Altkom.Shop.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasMaxLength(30);

                    b.Property<bool>("IsRemoved");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<decimal>("Salary");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Altkom.Shop.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("Id");

                    b.ToTable("Item");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Item");
                });

            modelBuilder.Entity("Altkom.Shop.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId");

                    b.Property<DateTime?>("DeliveredDate");

                    b.Property<string>("Number");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Altkom.Shop.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ItemId");

                    b.Property<int?>("OrderId");

                    b.Property<short>("Quantity");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("Altkom.Shop.Models.Product", b =>
                {
                    b.HasBaseType("Altkom.Shop.Models.Item");

                    b.Property<string>("Barcode");

                    b.Property<string>("Color")
                        .HasMaxLength(20);

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.ToTable("Product");

                    b.HasDiscriminator().HasValue("Product");
                });

            modelBuilder.Entity("Altkom.Shop.Models.Service", b =>
                {
                    b.HasBaseType("Altkom.Shop.Models.Item");

                    b.Property<TimeSpan?>("Duration");

                    b.ToTable("Service");

                    b.HasDiscriminator().HasValue("Service");
                });

            modelBuilder.Entity("Altkom.Shop.Models.Customer", b =>
                {
                    b.OwnsOne("Altkom.Shop.Models.Address", "InvoiceAddress", b1 =>
                        {
                            b1.Property<int>("CustomerId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City");

                            b1.Property<string>("Country");

                            b1.Property<string>("PostCode");

                            b1.Property<string>("Street");

                            b1.ToTable("Customers");

                            b1.HasOne("Altkom.Shop.Models.Customer")
                                .WithOne("InvoiceAddress")
                                .HasForeignKey("Altkom.Shop.Models.Address", "CustomerId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("Altkom.Shop.Models.Address", "ShippingAddress", b1 =>
                        {
                            b1.Property<int>("CustomerId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City");

                            b1.Property<string>("Country");

                            b1.Property<string>("PostCode");

                            b1.Property<string>("Street");

                            b1.ToTable("Customers");

                            b1.HasOne("Altkom.Shop.Models.Customer")
                                .WithOne("ShippingAddress")
                                .HasForeignKey("Altkom.Shop.Models.Address", "CustomerId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("Altkom.Shop.Models.Order", b =>
                {
                    b.HasOne("Altkom.Shop.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("Altkom.Shop.Models.OrderDetail", b =>
                {
                    b.HasOne("Altkom.Shop.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.HasOne("Altkom.Shop.Models.Order")
                        .WithMany("Details")
                        .HasForeignKey("OrderId");
                });
#pragma warning restore 612, 618
        }
    }
}
