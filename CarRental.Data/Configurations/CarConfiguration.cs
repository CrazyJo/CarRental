using System.Data.Entity.ModelConfiguration;

namespace CarRental.Data.Configurations
{
    public class CarConfiguration : EntityTypeConfiguration<Car>
    {
        public CarConfiguration()
        {
            HasRequired(r => r.CarDetail).WithRequiredPrincipal(r => r.Car).WillCascadeOnDelete(true);
            HasRequired(r => r.ParkingItem).WithRequiredPrincipal(r => r.Car).WillCascadeOnDelete(true);
            HasRequired(r => r.PriceItem).WithRequiredPrincipal(r => r.Car).WillCascadeOnDelete(true);
        }
    }
}
