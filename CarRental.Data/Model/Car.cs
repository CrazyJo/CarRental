using System.Collections.Generic;

namespace CarRental.Data
{

    public class Car
    {
        public Car()
        {
            RentalDetails = new HashSet<RentalDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual CarDetail CarDetail { get; set; }
        public virtual ICollection<RentalDetail> RentalDetails { get; set; }
        public virtual ParkingItem ParkingItem { get; set; }
        public virtual PriceItem PriceItem { get; set; }
    }
}
