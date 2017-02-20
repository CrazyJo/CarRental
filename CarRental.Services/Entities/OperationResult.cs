using System;
using System.Runtime.CompilerServices;

namespace CarRental.Services.Entities
{
    public class OperationResult
    {
        public bool Successful => Exception == null;
        public string OperationName { get; }
        public Exception Exception { get; set; }

        public OperationResult([CallerMemberName] string opName = "")
        {
            OperationName = opName;
        }
    }
}
