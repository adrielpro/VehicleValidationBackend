using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleValidationBackend.Classes
{
    public class ModelsValidator
    {
        // IsValid method extension to be able to use it in classes external to the Controllers or that do not have ModelState
        public static bool IsValidModel<T>(ref T element, List<ValidationResult> validationResults = null)
        {
            var context = new ValidationContext(element, serviceProvider: null, items: null);
            if (validationResults == null)
            {
                validationResults = new List<ValidationResult>();
            }
            return Validator.TryValidateObject(element, context, validationResults, true);
        }
    }
}
