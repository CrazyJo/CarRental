using System;
using System.Collections.Generic;

namespace CarRental.Data
{
    public class PriceItem
    {
        public int Id { get; set; }

        public double PricePerHour { get; set; }
        public int CarId { get; set; }

        public virtual Car Car { get; set; }
    }
}
