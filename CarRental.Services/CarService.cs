using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Services.Entities;

namespace CarRental.Services
{
    public class CarService
    {
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
            throw new NotImplementedException();
        }


    }
}
