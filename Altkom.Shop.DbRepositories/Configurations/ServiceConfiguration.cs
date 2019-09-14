using Altkom.Shop.Fakers;
using Altkom.Shop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Altkom.Shop.DbRepositories.Configurations
{
    internal class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {

        private readonly ServiceFaker serviceFaker;

        public ServiceConfiguration()
        {
            serviceFaker = new ServiceFaker();
        }

        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasData(serviceFaker.Generate(50));
        }
    }


    class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        private readonly OrderFaker orderFaker;

        public OrderConfiguration()
        {
            orderFaker = new OrderFaker();
        }


        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(orderFaker.Generate(100));
        }
    }
}
