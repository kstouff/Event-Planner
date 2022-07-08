using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Belt.Models
{
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime d = Convert.ToDateTime(value);
            if(d <= DateTime.Now)
            {
                return new ValidationResult("No Dates Before the current Date");
            }
            return ValidationResult.Success; 
        }
    }
}