using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Services.Infra;

namespace CarRental.Services.Entities
{
    public class AuthResult
    {
        public User User { get; set; }
        public bool LogIn => SignInStatus == SignInStatus.Success;
        public SignInStatus SignInStatus { get; set; }
    }
}
