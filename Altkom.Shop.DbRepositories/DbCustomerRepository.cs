using Altkom.Shop.IRepositories;
using Altkom.Shop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Altkom.Shop.DbRepositories
{

    public class DbCustomerRepository : DbEntityRepository<Customer>, ICustomerRepository
    {
        public DbCustomerRepository(ShopContext context) : base(context)
        {
        }


        public override ICollection<Customer> Get()
        {

            // context.Database.ExecuteSqlCommand()

            return context.Customers.FromSql("exec usp_GetActiveCustomers").ToList();
            //


            // return context.Customers.FromSql("select * from Customers").ToList();

            // return context.Query<Customer>().ToList();
        }

        //public override void Remove(int id)
        //{
        //    Customer customer = Get(id);
        //    customer.IsRemoved = true;
        //    Update(customer);

        //}


        public override void Add(Customer entity)
        {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Customers.Add(entity);
                        context.SaveChanges();

                        Order order = new Order
                        {
                            Number = "ZAM 1",
                            Customer = entity,
                            OrderDate = DateTime.Now
                        };

                        context.Orders.Add(order);
                        context.SaveChanges();


                        throw new Exception();

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                }

        }

        public override void Update(Customer entity)
        {
            Console.WriteLine(context.Entry(entity).State);

            Console.WriteLine(context.Entry(entity).Property(p => p.FirstName).OriginalValue);

            Console.WriteLine(context.Entry(entity).Property(p => p.FirstName).IsModified);

            context.Entry(entity).Property(p => p.FirstName).OriginalValue = "BBB";
            Console.WriteLine(context.Entry(entity).Property(p => p.FirstName).IsModified);
            Console.WriteLine(context.Entry(entity).State);

            context.Entry(entity).Property(p => p.FirstName).CurrentValue = "AAA";
            Console.WriteLine(context.Entry(entity).Property(p => p.FirstName).IsModified);
            Console.WriteLine(context.Entry(entity).State);

            var entries = context.ChangeTracker.Entries();

            foreach (var entry in entries)
            {
                Console.WriteLine(entry.State);
            }

            context.ChangeTracker.TrackGraph(entity, e =>
            {
                if (e.Entry.IsKeySet)
                {
                    e.Entry.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                else
                {
                    e.Entry.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                }
            }
            );


            base.Update(entity);
        }
    }
}
