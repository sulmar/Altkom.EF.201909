using Altkom.Shop.IRepositories;
using Altkom.Shop.Models;
using Altkom.Shop.Models.SearchCriterias;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Altkom.Shop.DbRepositories
{
    public class DbOrderRepository : DbEntityRepository<Order>, IOrderRepository
    {
        public DbOrderRepository(ShopContext context) : base(context)
        {
        }

        public override ICollection<Order> Get()
        {

            var orders = context.Orders.ToList();


            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order.Customer.LastName);
            //}

            foreach (var order in orders)
            {
                context.Entry(order).Reference(p => p.Customer).Load();

                context.Entry(order).Collection(p => p.Details).Query().Where(p=>p.Quantity>0).Load();
            }

            //return context.Orders
            //    .Include(p => p.Customer)
            //        .ThenInclude(p => p.InvoiceAddress)
            //    .Include(p => p.Customer)
            //        .ThenInclude(p => p.ShippingAddress)
            //    .ToList();

            return context.Orders.Include(p=>p.Customer).ToList();
        }

        public ICollection<Order> Get(OrderSearchCriteria criteria)
        {
            throw new NotImplementedException();
        }
    }
}
