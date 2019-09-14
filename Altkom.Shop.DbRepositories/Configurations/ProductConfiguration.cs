using Altkom.Shop.Fakers;
using Altkom.Shop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Altkom.Shop.DbRepositories.Configurations
{

    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        private readonly ProductFaker productFaker;

        public ProductConfiguration()
        {
            this.productFaker = new ProductFaker();
        }


        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
              .Property(p => p.SerialNumber)
              .IsRequired()
              .HasMaxLength(10)
              .IsUnicode(false);

            builder
                .Property(p => p.Color)
                .HasMaxLength(20);


            //builder.HasData(
            //    new Product { Id = 1, Name = "Product 1", Color = "red", UnitPrice = 2.5m },
            //    new Product { Id = 1, Name = "Product 1", Color = "red", UnitPrice = 2.5m },
            //    new Product { Id = 1, Name = "Product 1", Color = "red", UnitPrice = 2.5m }
            //    );

            builder.HasData(productFaker.Generate(100));
        }
    }
}
