using System;

namespace CarRental.Services.Entities
{
    public class OrderDto
    {
        public CarDto Car { get; set; }
        public TimeSpan Lease { get; set; }
        public DateTime RentalDate { get; set; }
        public IEntity Customer { get; set; }
    }
}
