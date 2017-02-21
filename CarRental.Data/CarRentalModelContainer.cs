using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Data.Configurations;

namespace CarRental.Data
{
    public class CarRentalModelContainer : DbContext
    {
        public CarRentalModelContainer()
            : base("name=CarRentalModelContainer")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AuthInfoConfiguration());
            modelBuilder.Configurations.Add(new CarConfiguration());
            modelBuilder.Configurations.Add(new PersonConfiguration());
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<CarDetail> CarDetails { get; set; }
        public virtual DbSet<ParkingItem> Parking { get; set; }
        public virtual DbSet<Rent> Rents { get; set; }
        public virtual DbSet<RentalDetail> RentalDetails { get; set; }
        public virtual DbSet<PriceItem> PriceList { get; set; }
        public virtual DbSet<AuthInfo> AuthInfoes { get; set; }
    }
}
