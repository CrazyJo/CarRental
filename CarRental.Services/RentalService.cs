using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Services.Entities;

namespace CarRental.Services
{
    public interface IRentalService
    {
        Task CreateOrder(Order order);
        IEnumerable<Order> GetOrdersById(int userId);
    }

    public class RentalService : IRentalService
    {
        public Task CreateOrder(Order order)
        {
            return Task.CompletedTask;
        }

        public IEnumerable<Order> GetOrdersById(int userId)
        {
            var orders = new List<Order>
            {
                new Order
                {
                    Car = new CarDTO {Color = "Red", Id = 1, Name = "NoNameCar"},
                    Customer = new User {Id = 1},
                    Lease = new TimeSpan(2, 0, 0, 0),
                    RentalDate = new DateTime(2017, 1, 12)
                },
                new Order
                {
                    Car = new CarDTO {Color = "Green", Id = 1, Name = "Mazda"},
                    Customer = new User {Id = 1},
                    Lease = new TimeSpan(1, 0, 0, 0),
                    RentalDate = new DateTime(2017, 1, 15)
                }
            };
            return orders;
        }
    }
}
