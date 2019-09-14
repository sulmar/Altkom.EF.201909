using System;
using System.Collections.Generic;

namespace Altkom.Shop.Models
{
    public class Order : BaseEntity
    {
        public string Number { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public OrderStatus Status { get; set; }
        public ICollection<OrderDetail> Details { get; set; }
    }
}
