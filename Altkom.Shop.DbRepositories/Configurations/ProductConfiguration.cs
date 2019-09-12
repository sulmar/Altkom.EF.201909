using Altkom.Shop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Altkom.Shop.DbRepositories.Configurations
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
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
        }
    }
}
