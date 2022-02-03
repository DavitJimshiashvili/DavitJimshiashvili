using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PersonManagement.Web.Infrastracture.Attributes
{
    public class GeorgianOnlyAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var str = value as string;
            string regexPattern = @"^[ა-ჰ]*$";
            if (Regex.IsMatch(str,regexPattern))
            {
                return true;
            }
            ErrorMessage = "letters must be only georgian alphabet characters";
            return false;
        }

      
    }
}
