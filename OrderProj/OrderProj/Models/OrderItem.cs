using System;
using System.Collections.Generic;

namespace OrderProj.Models
{
    public partial class OrderItem
    {
        public OrderItem()
        {
            Customer = new HashSet<Customer>();
        }

        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public DateTime DateOfPurchase { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
