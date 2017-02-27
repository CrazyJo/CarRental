using System;
using System.Collections.Generic;

namespace CarRental.Data
{
    public class Role
    {
        public int Id { get; set; }
        public UserRole Name { get; set; }

        public virtual ICollection<AuthInfo> AuthInfo { get; set; }

        public Role()
        {
            AuthInfo = new HashSet<AuthInfo>();
        }
    }
}
