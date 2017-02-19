using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Entities
{
    public class CarInfo
    {
        public CarDTO Car { get; set; }
        public int Balance { get; set; }
        public int TotalCars { get; set; }
        public double PricePerHour { get; set; }
    }
}
