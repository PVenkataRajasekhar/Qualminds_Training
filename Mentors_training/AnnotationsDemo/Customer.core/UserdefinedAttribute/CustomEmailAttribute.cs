using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Customer.core.UserdefinedAttribute
{
    public class CustomEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string email = value.ToString();
                if (!IsValidEmail(email))
                {
                    return new ValidationResult("Invalid email format.");
                }
            }

            return ValidationResult.Success;
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[A-Za-z0-9._%+-]+@yahoo\.com$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
