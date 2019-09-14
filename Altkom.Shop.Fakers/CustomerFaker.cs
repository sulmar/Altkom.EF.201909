using Altkom.Shop.Models;
using Bogus;

namespace Altkom.Shop.Fakers
{
    public class CustomerFaker : Faker<Customer>
    {
        public CustomerFaker()
        {
            RuleFor(p => p.Id, f => f.IndexFaker + 1);
            RuleFor(p => p.FirstName, f => f.Person.FirstName);
            RuleFor(p => p.LastName, f => f.Person.LastName);
            RuleFor(p => p.IsRemoved, f => f.Random.Bool(0.3f));
            
        }
    }
}
