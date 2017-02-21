using System.Collections.Generic;
using CarRental.Data;

namespace CarRental.Services.Entities
{
    public class User : IEntity
    {
        public User()
        {
            Role = new HashSet<Role>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public ICollection<Role> Role { get; set; }
    }
}
