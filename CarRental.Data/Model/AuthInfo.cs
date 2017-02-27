using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Data
{
    public class AuthInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual Person Person { get; set; }
        public virtual ICollection<Role> Role { get; set; }

        public AuthInfo()
        {
            Role = new HashSet<Role>();
        }
    }
}
