using System;
using System.Collections.Generic;

namespace CarRental.Data
{
    public class Person
    {
        public Person()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }

        public virtual AuthInfo AuthInfo { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
