namespace Altkom.Shop.Models
{
    public class OrderDetail : BaseEntity
    {
        public Item Item { get; set; }
        public short Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
