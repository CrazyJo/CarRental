using System;

namespace CarRental.View.Model
{
    public class OrderViewModel
    {
        public int CarId { get; set; }
        public int UserId { get; set; }
        public string CarModel { get; set; }
        public TimeSpan Lease { get; set; }
        public DateTime RentalDate { get; set; }

        /// <summary>
        /// The rest of time
        /// </summary>
        public TimeSpan Rest { get; set; }
    }
}
