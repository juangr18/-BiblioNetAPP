using System.ComponentModel.DataAnnotations;

namespace BiblioNetAPP.Validations
{
    public class FirstCapitalLetter : ValidationAttribute
    {
        protected override ValidationResult IsValid(Object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()) || value.ToString() == "" || value.ToString() == " ")
            {
                return new ValidationResult("Value is null");
            }
            var firstLetter = value.ToString()[0].ToString();
            return firstLetter != firstLetter.ToUpper()
                ? new ValidationResult("First letter must be in uppercase")
                : ValidationResult.Success;
        }
    }
}
