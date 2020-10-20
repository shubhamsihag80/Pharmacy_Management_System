using System;
using System.Collections.Generic;

namespace MedicineProj.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Medicine = new HashSet<Medicine>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int PhoneNumber { get; set; }
        public int? OrderId { get; set; }

        public virtual OrderItem Order { get; set; }
        public virtual ICollection<Medicine> Medicine { get; set; }
    }
}
