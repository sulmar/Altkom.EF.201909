using Altkom.Shop.Models;
using Bogus;

namespace Altkom.Shop.Fakers
{
    // dotnet add package Bogus

    public class ProductFaker : Faker<Product>
    {
        public ProductFaker()
        {
            RuleFor(p => p.Id, f => f.IndexGlobal + 1);
            RuleFor(p => p.Name, f => f.Commerce.ProductName());
            RuleFor(p => p.Color, f => f.Commerce.Color());
            RuleFor(p => p.Barcode, f => f.Commerce.Ean13());
            RuleFor(p => p.SerialNumber, f => f.Commerce.Ean8());
            RuleFor(p => p.UnitPrice, f => f.Random.Decimal(1, 100));
        }
    }
}
