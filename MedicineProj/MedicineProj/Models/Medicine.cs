using System;
using System.Collections.Generic;

namespace MedicineProj.Models
{
    public partial class Medicine
    {
        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

    }
}
