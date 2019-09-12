using Altkom.Shop.Models;
using Altkom.Shop.Models.SearchCriterias;
using System.Collections.Generic;

namespace Altkom.Shop.IRepositories
{
    public interface IOrderRepository : IEntityRepository<Order>
    {
        ICollection<Order> Get(OrderSearchCriteria criteria);
    }
}
