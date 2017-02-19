using System;

namespace CarRental.View.Model
{
    public class OrderViewModel
    {
        public string CarModel { get; set; }
        public TimeSpan Lease { get; set; }
        public DateTime RentalDate { get; set; }
    }
}
