using System.ComponentModel.DataAnnotations;

namespace Komplexni_ukol_Filmy.Models
{
    public class RokDoSoucasnostiAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            if (value is int rok)
            {
                int aktualniRok = DateTime.Now.Year;
                if (rok < 1895 || rok > aktualniRok)
                {
                    return new ValidationResult($"Rok vydání musí být mezi 1895 a {aktualniRok}.");
                }
            }
            return ValidationResult.Success!;
        }
    }
}
