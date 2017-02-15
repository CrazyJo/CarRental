using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Services.Entities;
using CarRental.Services.Infra;

namespace CarRental.Services
{
    public class UserService
    {
        public Task CreateCustomer(CustomerDTO user)
        {
            throw new NotImplementedException();
        }

        public Task<SignInStatus> Login(User user)
        {
            throw new NotImplementedException();

        }
    }
}
