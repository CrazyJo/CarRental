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
        public Task<RegistrationResult> Register(User user)
        {
            throw new NotImplementedException();
        }

        public Task<AuthResult> Login(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
