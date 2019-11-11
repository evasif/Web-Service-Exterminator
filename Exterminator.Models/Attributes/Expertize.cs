using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Exterminator.Models.Attributes
{

    public class Expertize : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value.ToString() != "Ghost catcher" &&
                value.ToString() != "Ghoul strangler" &&
                value.ToString() != "Monster encager" &&
                value.ToString() != "Zombie exploder")
            {
                return new ValidationResult("This value is invalid, it must be one of these: ");
            }
            else
            {
                return ValidationResult.Success;
            }

        }
    }
}