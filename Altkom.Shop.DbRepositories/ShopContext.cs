﻿using Altkom.Shop.DbRepositories.Configurations;
using Altkom.Shop.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;

namespace Altkom.Shop.DbRepositories
{

    // dotnet add package Microsoft.EntityFrameworkCore
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options) : base(options)
        {
           //this.Database.EnsureDeleted();
            //this.Database.EnsureCreated();

            this.Database.Migrate();
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }

       // public DbQuery<Customer> ActiveCustomers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());

            modelBuilder.Query<Customer>().ToView("vw_ActiveCustomers");

            base.OnModelCreating(modelBuilder);
        }

    }
}
