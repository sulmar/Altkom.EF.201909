using Altkom.Shop.IRepositories;
using Altkom.Shop.Models;
using System.Linq;
using System.Text;

namespace Altkom.Shop.DbRepositories
{

    public class DbCustomerRepository : DbEntityRepository<Customer>, ICustomerRepository
    {
        public DbCustomerRepository(ShopContext context) : base(context)
        {
        }

        public override void Remove(int id)
        {
            Customer customer = Get(id);
            customer.IsRemoved = true;
            Update(customer);

        }
    }
}
