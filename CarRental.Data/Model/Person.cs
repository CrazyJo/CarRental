namespace CarRental.Data
{
    using System;
    using System.Collections.Generic;
    
    public class Person
    {
        public Person()
        {
            Rents = new HashSet<Rent>();
        }
    
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
    
        public virtual AuthInfo AuthInfo { get; set; }
        public virtual ICollection<Rent> Rents { get; set; }
    }
}
