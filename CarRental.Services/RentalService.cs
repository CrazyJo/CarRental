using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarRental.Data;
using CarRental.Services.Entities;
using CarRental.Services.Infra;

namespace CarRental.Services
{
    public interface IRentalService
    {
        Task CreateOrder(Order order);
        IEnumerable<Order> GetOrdersById(int userId);
    }

    public class RentalService : IRentalService
    {
        public CarRentalModelContainer Db { get; set; }
        public RentalService()
        {
            Db = new CarRentalModelContainer();
        }

        public async Task CreateOrder(Order order)
        {
            try
            {
                var dm = Map(order);
                dm.Person = Db.People.Find(order.Customer.Id);
                dm.RentalDetails.First().Car =
                    Db.Cars.Include(i => i.CarDetail)
                        .Include(i => i.ParkingItem)
                        .Include(i => i.PriceItem)
                        .First(r => r.Id == order.Car.Id);
                Db.Rents.Add(dm);
                Db.RentalDetails.AddRange(dm.RentalDetails);
                await Db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        Rent Map(Order order)
        {
            return new Rent
            {
                DateRental = order.RentalDate,
                RentalDetails = {new RentalDetail
                {
                    Lease = order.Lease
                } }
            };
        }

        public IEnumerable<Order> GetOrdersById(int userId)
        {
            var res = Enumerable.Empty<Order>();
            var t = Db.CarDetails.Local;
            var person = Db.People.Include(r => r.Rents.Select(p => p.RentalDetails.Select(e => e.Car)))
                .FirstOrDefault(u => u.Id.Equals(userId));
            if (person == null || person.Rents.Count == 0) return res;
            
            return Map(person.Rents);
        }

        IEnumerable<Order> Map(ICollection<Rent> rents)
        {
            var res = new List<Order>();

            foreach (var rent in rents)
            {
                var rD = rent.RentalDetails.First();
                res.Add(new Order { Car = new CarDTO
                {
                    Color = rD.Car.CarDetail.Color,
                    Id = rD.Car.Id,
                    Name = rD.Car.Name
                },
                Lease = rD.Lease,
                RentalDate = rent.DateRental,
                Customer = new User {Id = rent.Person.Id } });
            }

            return res;
        }
    }
}
