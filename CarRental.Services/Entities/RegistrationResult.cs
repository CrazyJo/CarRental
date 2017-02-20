using System;

namespace CarRental.Services.Entities
{
    public class RegistrationResult
    {
        public Exception Exception { get; set; }
        public bool Succeeded => Exception == null;
    }
}
