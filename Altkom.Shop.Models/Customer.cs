namespace Altkom.Shop.Models
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address InvoiceAddress { get; set; }
        public Address ShippingAddress { get; set; }
        public bool IsRemoved { get; set; }
    }
}
