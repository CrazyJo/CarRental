using System;

namespace CarRental.Services.Infra
{
    public class RegistrationResult
    {
        public Exception Exception { get; set; }
        public bool Succeeded => Exception == null;
    }
}
