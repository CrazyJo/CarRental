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
    public interface ICarService
    {
        Task<IEnumerable<CarInfo>> GetAllAvailableCars();
        Task<IEnumerable<CarInfo>> GetAllCars();
        Task<OperationDetails> RemoveCar(int id);
        Task<OperationDetails> AddCar(CarInfo car);
        Task<OperationDetails> UpdateCar(CarInfo car);
        Task<OperationResult<CarInfo>> GetById(int id);
    }

    public class CarService : ICarService
    {
        public CarRentalModelContainer Db { get; set; }

        public CarService()
        {
            Db = new CarRentalModelContainer();
        }

        public async Task<IEnumerable<CarInfo>> GetAllAvailableCars()
        {
            var res = Enumerable.Empty<CarInfo>();
            try
            {
                var cars = await Db.Cars
                    .Include(r => r.ParkingItem)
                    .Include(r => r.PriceItem)
                    .Where(i => i.ParkingItem.Balance > 0).ToListAsync();

                res = Mapper.Map<IEnumerable<CarInfo>>(cars);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return res;
        }

        public async Task<IEnumerable<CarInfo>> GetAllCars()
        {
            var res = Enumerable.Empty<CarInfo>();
            try
            {
                var cars = await Db.Cars
                    .Include(r => r.ParkingItem)
                    .Include(r => r.PriceItem)
                    .Include(r => r.PriceItem)
                    .ToListAsync();

                res = Mapper.Map<IEnumerable<CarInfo>>(cars);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return res;
        }

        public async Task<OperationDetails> RemoveCar(int id)
        {
            var res = new OperationDetails();

            try
            {
                var car = await Db.Cars
                    .Include(q => q.ParkingItem)
                    .Include(q => q.Orders)
                    .FirstOrDefaultAsync(e => e.Id.Equals(id));
                if (car == null)
                {
                    res.Exception = new Exception("There is no such record in the database.");
                    return res;
                }
                if (car.Orders.Any())
                {
                    res.Exception = new Exception("You can not remove the car which is in orders.");
                    return res;
                }
                Db.Cars.Remove(car);
                var t = await Db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                res.Exception = e;
                return res;
            }

            return res;
        }

        public async Task<OperationDetails> AddCar(CarInfo car)
        {
            return await AddOrUpdateCar(car);
        }

        private async Task<OperationDetails> AddOrUpdateCar(CarInfo car)
        {
            var res = new OperationDetails();

            try
            {
                var dbModel = Mapper.Map<Car>(car);
                Db.Cars.AddOrUpdate(dbModel);
                Db.Parking.AddOrUpdate(dbModel.ParkingItem);
                Db.PriceList.AddOrUpdate(dbModel.PriceItem);
                var t = await Db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                res.Exception = e;
                return res;
            }

            return res;
        }

        public async Task<OperationDetails> UpdateCar(CarInfo car)
        {
            return await AddOrUpdateCar(car);
        }

        public async Task<OperationResult<CarInfo>> GetById(int id)
        {
            var res = new OperationResult<CarInfo>();

            try
            {
                var dbM = await Db.Cars.FindAsync(id);
                res.Result = Mapper.Map<CarInfo>(dbM);
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
