using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Data
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime DateRental { get; set; }
        public TimeSpan Lease { get; set; }

        public int CarId { get; set; }
        public virtual Car Car { get; set; }

        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
