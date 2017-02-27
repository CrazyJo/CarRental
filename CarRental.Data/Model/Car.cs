using System.Collections.Generic;

namespace CarRental.Data
{
    public class Car
    {
        public Car()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ParkingItem ParkingItem { get; set; }
        public virtual PriceItem PriceItem { get; set; }
    }
}
