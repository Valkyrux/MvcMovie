using System.ComponentModel.DataAnnotations;

namespace MvcMovie.CustomValidation
{
    public class MoreThanOneWordValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string? fieldValue = (string?)value;
            if (fieldValue == null || fieldValue.Split(" ").Length < 2)
            {
                return new ValidationResult("Nome Completo non valido, inserire almeno 'nome cognome'");
            } else 
            {
                string[]? nameArray = fieldValue.Split(" ");

                foreach (string namePart in nameArray)
                {
                    if(namePart.Length == 0)
                    {
                        return new ValidationResult("Nome Completo non valido, inserire almeno 'nome cognome'");
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}
