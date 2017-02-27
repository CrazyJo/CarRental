using System;
using System.Runtime.CompilerServices;

namespace CarRental.Services.Infra
{
    public class OperationDetails
    {
        public bool Successful => Exception == null;
        public string OperationName { get; }
        public Exception Exception { get; set; }

        public OperationDetails([CallerMemberName] string opName = "")
        {
            OperationName = opName;
        }

        public override string ToString()
        {
            return Successful ? "Successfully" : "Faulted";
        }
    }
}
