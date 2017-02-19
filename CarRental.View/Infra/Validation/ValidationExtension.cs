using CarRental.View.Shell;

namespace CarRental.View.Infra.Validation
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

        public static ValidationResult Required(this string input)
        {
            var res = new ValidationResult { Valid = true };
            if (!string.IsNullOrEmpty(input)) return res;
            res.Message = "Required";
            res.Valid = false;
            return res;
        }

        public static ValidationResult Numbers(this string input)
        {
            var res = new ValidationResult { Valid = true };

            double value;
            if (double.TryParse(input, out value)) return res;

            res.Message = "Input must contain only numbers";
            res.Valid = false;
            return res;
        }
    }
}
