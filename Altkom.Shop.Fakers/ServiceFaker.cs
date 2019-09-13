using Altkom.Shop.Models;
using Bogus;
using System;

namespace Altkom.Shop.Fakers
{
    public class ServiceFaker : Faker<Service>
    {
        public ServiceFaker()
        {
            RuleFor(p => p.Id, f => f.IndexGlobal + 1);
            RuleFor(p => p.Name, f => f.Hacker.Verb());
            RuleFor(p => p.UnitPrice, f => f.Random.Decimal(100, 500));
            RuleFor(p => p.Duration, f => f.Date.Timespan(TimeSpan.FromHours(2)));
        }
    }
}
