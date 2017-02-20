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
            return new List<CarInfo>
            {
                new CarInfo
                {
                    Balance = 2,
                    Car = new CarDTO {Color = "Red", Id = 8, Name = "Mercedes"},
                    TotalCars = 5,
                    PricePerHour = 50.7
                },
                new CarInfo
                {
                    Balance = 1,
                    Car = new CarDTO {Color = "Blue", Id = 9, Name = "Opel"},
                    TotalCars = 3,
                    PricePerHour = 70.15
                }
            };
        }

        public IEnumerable<CarInfo> GetAllCars()
        {
            return new List<CarInfo>
            {
                new CarInfo
                {
                    Balance = 2,
                    Car = new CarDTO {Color = "Red", Id = 8, Name = "Mercedes"},
                    TotalCars = 5,
                    PricePerHour = 50.7
                },
                new CarInfo
                {
                    Balance = 1,
                    Car = new CarDTO {Color = "Blue", Id = 9, Name = "Opel"},
                    TotalCars = 3,
                    PricePerHour = 70.15
                },
                new CarInfo
                {
                    Balance = 0,
                    Car = new CarDTO {Color = "Black", Id = 10, Name = "Audi"},
                    TotalCars = 3,
                    PricePerHour = 81.15
                }

            };

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
                var dbModel = Mapper.Map<Car>(car);
                Db.Cars.Add(dbModel);
                await Db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                res.Exception = e;
                return res;
            }

            return res;
        }

        public async Task<OperationResult> UpdateCar(CarInfo car)
        {
            var res = new OperationResult();

            try
            {
                var dbModel = Mapper.Map<Car>(car);
                Db.Cars.AddOrUpdate(dbModel);
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
