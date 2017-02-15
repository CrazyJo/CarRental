using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Entities
{
    public class CustomerDTO : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
