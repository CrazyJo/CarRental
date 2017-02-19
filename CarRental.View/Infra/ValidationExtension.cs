using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.View.Shell;

namespace CarRental.View.Infra
{
    public static class ValidationExtension
    {
        public static ValidationResult InputValidation(this string input)
        {
            var res = new ValidationResult { Valid = true };
            var isEmpty = string.IsNullOrEmpty(input) && string.IsNullOrWhiteSpace(input);
            if (isEmpty)
            {
                res.Message = "Required";
                res.Valid = false;
                return res;
            }
            int value;
            var isOnlyNumbers = int.TryParse(input, out value);
            if (!isOnlyNumbers)
            {
                res.Message = "Input must contain only numbers";
                res.Valid = false;
                return res;
            }
            return res;
        }

    }
}
