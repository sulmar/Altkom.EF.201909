using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.Shop.DbRepositories
{
    public class ShopContextFactory : IDesignTimeDbContextFactory<ShopContext>
    {
        public ShopContext CreateDbContext(string[] args)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ShopDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            // dotnet add package Microsoft.EntityFrameworkCore.SqlServer
            var options = new DbContextOptionsBuilder<ShopContext>()
                .UseSqlServer(connectionString)
                .Options;

            return new ShopContext(options);
        }
    }
}
