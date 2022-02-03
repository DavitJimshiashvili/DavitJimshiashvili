using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace PersonManagement.Web.Infrastracture.Attributes
{
    public class AgeAttribute : ValidationAttribute
    {
      
        public override bool IsValid(object value)
        {
            string age =value.ToString();
            string regexPattern = @"[1][4-8]";
            if (Regex.IsMatch(age, regexPattern))
            {
                return true;
            }
            ErrorMessage = "Age must be in range (13-19)";
            return false;
        }
    }
}
