using Altkom.Shop.Models;
using Bogus;

namespace Altkom.Shop.Fakers
{
    public class OrderFaker : Faker<Order>
    {
        public OrderFaker()
        {
            RuleFor(p => p.Id, f => f.IndexFaker + 2);
            RuleFor(p => p.Number, f => $"ZAM {f.Random.Int(1, 1000)}");
            RuleFor(p => p.OrderDate, f => f.Date.Past(3));
            RuleFor(p => p.Status, f => f.PickRandom<OrderStatus>());
            RuleFor(p => p.CustomerId, f => f.Random.Int(1, 14));            
        }
    }
}
