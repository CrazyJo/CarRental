//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using CarRental.Data;
//using CarRental.Services.Entities;

//namespace CarRental.Services
//{
//    public interface IOrderService
//    {
//        Task CreateOrder(OrderDto orderDto);
//        IEnumerable<OrderDto> GetOrdersById(int userId);
//    }

//    public class OrderService : IOrderService
//    {
//        public CarRentalModelContainer Db { get; set; }
//        public OrderService()
//        {
//            Db = new CarRentalModelContainer();
//        }

//        public async Task CreateOrder(OrderDto orderDto)
//        {
//            try
//            {
//                var dbM = Map(orderDto);


//                dbM.Person = Db.People.Find(orderDto.Customer.Id);
//                dbM.RentalDetails.First().Car =
//                    Db.Cars.Include(i => i.CarDetail)
//                        .Include(i => i.ParkingItem)
//                        .Include(i => i.PriceItem)
//                        .First(r => r.Id == orderDto.Car.Id);
//                Db.Rents.Add(dbM);
//                Db.RentalDetails.AddRange(dbM.RentalDetails);
//                await Db.SaveChangesAsync();
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e);
//                throw;
//            }
//        }

//        Order Map(OrderDto orderDto)
//        {
//            return new Order
//            {
//                DateRental = orderDto.RentalDate,
//                RentalDetails = {new RentalDetail
//                {
//                    Lease = orderDto.Lease
//                } }
//            };
//        }

//        public IEnumerable<OrderDto> GetOrdersById(int userId)
//        {
//            var res = Enumerable.Empty<OrderDto>();
//            var t = Db.CarDetails.Local;
//            var person = Db.People.Include(r => r.Rents.Select(p => p.RentalDetails.Select(e => e.Car)))
//                .FirstOrDefault(u => u.Id.Equals(userId));
//            if (person == null || person.Rents.Count == 0) return res;
            
//            return Map(person.Rents);
//        }

//        IEnumerable<OrderDto> Map(ICollection<Order> rents)
//        {
//            var res = new List<OrderDto>();

//            foreach (var rent in rents)
//            {
//                var rD = rent.RentalDetails.First();
//                res.Add(new OrderDto { Car = new CarDto
//                {
//                    Color = rD.Car.CarDetail.Color,
//                    Id = rD.Car.Id,
//                    Name = rD.Car.Name
//                },
//                Lease = rD.Lease,
//                RentalDate = rent.DateRental,
//                Customer = new User {Id = rent.Person.Id } });
//            }

//            return res;
//        }
//    }
//}
