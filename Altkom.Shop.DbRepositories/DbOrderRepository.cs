using Altkom.Shop.IRepositories;
using Altkom.Shop.Models;
using Altkom.Shop.Models.SearchCriterias;
using System;
using System.Collections.Generic;

namespace Altkom.Shop.DbRepositories
{
    public class DbOrderRepository : DbEntityRepository<Order>, IOrderRepository
    {
        public DbOrderRepository(ShopContext context) : base(context)
        {
        }

        public ICollection<Order> Get(OrderSearchCriteria criteria)
        {
            throw new NotImplementedException();
        }
    }
}
