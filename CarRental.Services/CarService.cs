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
        IEnumerable<CarInfo> GetAllAvailableCars();
        IEnumerable<CarInfo> GetAllCars();
        Task<OperationResult> RemoveCar(int id);
        Task<OperationResult> AddCar(CarInfo car);
        Task<OperationResult> UpdateCar(CarInfo car);
    }

    public class CarService : ICarService
    {
        public CarRentalModelContainer Db { get; set; }

        public CarService()
        {
            Db = new CarRentalModelContainer();
        }

        public IEnumerable<CarInfo> GetAllAvailableCars()
        {
            var res = Enumerable.Empty<CarInfo>();
            try
            {
                var cars = Db.Cars
                    .Include(r => r.CarDetail)
                    .Include(r => r.ParkingItem)
                    .Include(r => r.PriceItem)
                    .Include(r => r.RentalDetails)
                    .Where(i => i.RentalDetails.Count > 0).ToList();
                res = Map(cars);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return res;
        }

        public IEnumerable<CarInfo> GetAllCars()
        {
            IEnumerable<CarInfo> res = Enumerable.Empty<CarInfo>();
            try
            {
                var cars = Db.Cars
                    .Include(r => r.CarDetail)
                    .Include(r => r.ParkingItem)
                    .Include(r => r.PriceItem)
                    .Include(r => r.PriceItem)
                    .ToList();
                res = Map(cars);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return res;
        }

        private IEnumerable<CarInfo> Map(IEnumerable<Car> enumerable)
        {
            var res = new List<CarInfo>();
            foreach (var car in enumerable)
            {
                res.Add(new CarInfo
                {
                    Car = new CarDTO { Id = car.Id, Name = car.Name, Color = car.CarDetail.Color },
                    PricePerHour = car.PriceItem.PricePerHour,
                    Balance = car.ParkingItem.Balance,
                    TotalCars = car.ParkingItem.TotalCars
                });
            }
            return res;
        }

        public async Task<OperationResult> RemoveCar(int id)
        {
            var res = new OperationResult();

            try
            {
                var car = await Db.Cars
                    .Include(q => q.ParkingItem)
                    .Include(q => q.RentalDetails)
                    .FirstOrDefaultAsync(e => e.Id.Equals(id));
                if (car == null)
                {
                    res.Exception = new Exception("There is no such record in the database.");
                    return res;
                }
                //if (!car.RentalDetails.Any())
                //{
                //    res.Exception = new Exception("You can not remove the car which is in orders.");
                //    return res;
                //}
                Db.Cars.Remove(car);
                await Db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                res.Exception = e;
                return res;
            }

            return res;
        }

        public async Task<OperationResult> AddCar(CarInfo car)
        {
            var res = new OperationResult();

            try
            {
                var dbModel = Map(car);
                Db.Cars.Add(dbModel);
                Db.CarDetails.Add(dbModel.CarDetail);
                Db.Parking.Add(dbModel.ParkingItem);
                Db.PriceList.Add(dbModel.PriceItem);
                await Db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                res.Exception = e;
                return res;
            }

            return res;
        }

        private Car Map(CarInfo car)
        {
            return new Car
            {
                CarDetail = new CarDetail { Color = car.Car.Color},
                Name = car.Car.Name,
                ParkingItem = new ParkingItem { Balance = car.Balance,TotalCars = car.TotalCars},
                PriceItem = new PriceItem { PricePerHour = car.PricePerHour},
            };
        }

        public async Task<OperationResult> UpdateCar(CarInfo car)
        {
            var res = new OperationResult();

            try
            {
                var dbModel = Map(car);
                Db.Cars.AddOrUpdate(dbModel);
                Db.CarDetails.AddOrUpdate(dbModel.CarDetail);
                Db.Parking.AddOrUpdate(dbModel.ParkingItem);
                Db.PriceList.AddOrUpdate(dbModel.PriceItem);
                await Db.SaveChangesAsync();
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
