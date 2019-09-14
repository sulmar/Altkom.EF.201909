using Altkom.Shop.Models;
using Bogus;
using System.Collections.Generic;

namespace Altkom.Shop.Fakers
{
    public class OrderDetailFaker : Faker<OrderDetail>
    {
        public OrderDetailFaker(IEnumerable<Item> items)
        {
            RuleFor(p => p.Item, f => f.PickRandom(items));
        }
    }
}
