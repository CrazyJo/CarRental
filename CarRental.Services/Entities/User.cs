using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Services.Infra;

namespace CarRental.Services.Entities
{
    public class User : IEntity
    {
        public User()
        {
            Roles = new HashSet<Role>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Role> Roles { get; }
    }
}
