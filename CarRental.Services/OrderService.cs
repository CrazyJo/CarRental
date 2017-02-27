using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarRental.Data;
using CarRental.Services.Entities;
using System.Data.Entity;
using CarRental.Services.Infra;

namespace CarRental.Services
{
    public interface IOrderService
    {
        Task<OperationDetails> CreateOrder(OrderDto orderDto);
        Task<OperationResult<IEnumerable<OrderDto>>> GetOrdersById(int userId);
        Task<OperationResult<IEnumerable<OrderDto>>> GetAllOrders();
    }

    public class OrderService : IOrderService
    {
        public CarRentalModelContainer Db { get; set; }

        public OrderService()
        {
            Db = new CarRentalModelContainer();
        }

        public async Task<OperationDetails> CreateOrder(OrderDto orderDto)
        {
            var res = new OperationDetails();

            try
            {
                var dbM = Mapper.Map<Order>(orderDto);
                Db.Orders.Add(dbM);

                var t = await Db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                res.Exception = e;
                return res;
            }

            return res;
        }

        public async Task<OperationResult<IEnumerable<OrderDto>>> GetOrdersById(int userId)
        {
            var res = new OperationResult<IEnumerable<OrderDto>> { Result = Enumerable.Empty<OrderDto>() };

            try
            {
                var person = await Db.People.Include(q => q.Orders.Select(r => r.Car))
                    .FirstOrDefaultAsync(u => u.Id.Equals(userId));
                if (person == null || !person.Orders.Any()) return res;
                res.Result = Mapper.Map<IEnumerable<OrderDto>>(person.Orders);
            }
            catch (Exception e)
            {
                res.Exception = e;
                return res;
            }

            return res;
        }

        public async Task<OperationResult<IEnumerable<OrderDto>>> GetAllOrders()
        {
            var res = new OperationResult<IEnumerable<OrderDto>> { Result = Enumerable.Empty<OrderDto>() };

            try
            {
                var orders = await Db.Orders
                    .Include(r => r.Person)
                    .Include(r => r.Car)
                    .ToListAsync();

                res.Result = Mapper.Map<IEnumerable<OrderDto>>(orders);
            }
            catch (Exception e)
            {
                res.Exception = e;
                return res;
            }

            return res;
        }
    }
}
