using Altkom.Shop.DbRepositories;
using Altkom.Shop.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Altkom.Shop.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello EF Core!");

            // dotnet add package Microsoft.Extensions.DependencyInjection --version 2.1.1

            IServiceCollection services = new ServiceCollection();
            services.AddScoped<ICustomerRepository, DbCustomerRepository>();
            services.AddScoped<IOrderRepository, DbOrderRepository>();

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ShopDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            // dotnet add package Microsoft.EntityFrameworkCore.SqlServer
            // services.AddDbContext<ShopContext>(options => options.UseSqlServer(connectionString));

            services.AddDbContextPool<ShopContext>(options => options.UseSqlServer(connectionString));

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                ICustomerRepository customerRepository = serviceProvider.GetService<ICustomerRepository>();

                var customers = customerRepository.Get();


                foreach (var customer in customers)
                {
                    Console.WriteLine($"{customer.FirstName} {customer.LastName}");
                }
            }

        }
    }
}
