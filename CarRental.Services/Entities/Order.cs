using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Entities
{
    public class Order
    {
        public CarDTO Car { get; set; }
        public TimeSpan Lease { get; set; }
        public CustomerDTO Customer { get; set; }
        public int Employee { get; set; }
    }
}
