using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.View.Model
{
    public class CarInfoViewModel
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double PricePerHour { get; set; }
    }
}
