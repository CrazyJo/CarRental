using System;
using System.Collections.Generic;

namespace CarRental.Data
{
    public class ParkingItem
    {
        public int Id { get; set; }

        public int TotalCars { get; set; }
        public int Balance { get; set; }
        public int CarId { get; set; }

        public virtual Car Car { get; set; }
    }
}
