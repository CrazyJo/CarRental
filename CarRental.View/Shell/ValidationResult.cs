using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.View.Shell
{
    public class ValidationResult
    {
        public bool Valid { get; set; }
        public string Message { get; set; }

        public ValidationResult()
        {
            Message = string.Empty;
        }

        public override string ToString()
        {
            return Valid ? "Valid" : string.IsNullOrEmpty(Message) ? "Invalid" : Message;
        }
    }
}
