using Altkom.Shop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.Shop.DbRepositories.Configurations
{
    class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
               .OwnsOne(p => p.ShippingAddress)
               .ToTable("ShippingAddresses");

            builder
                .OwnsOne(p => p.InvoiceAddress)
                .ToTable("InvoiceAddresses");

            builder
                .Property(p => p.FirstName)
                .HasMaxLength(30);
                // .IsConcurrencyToken();

            builder
                .Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .Property(p => p.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();

            

        }
    }
}
