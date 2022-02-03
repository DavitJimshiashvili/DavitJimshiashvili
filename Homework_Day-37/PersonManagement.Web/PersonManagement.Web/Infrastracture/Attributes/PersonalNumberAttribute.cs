using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PersonManagement.Web.Infrastracture.Attributes
{
    public class PersonalNumberAttribute:ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            string pNumber = value as string;
            string regexPattern = @"^[0-9]{11}";
            if (Regex.IsMatch(pNumber, regexPattern))
            {
                return true;
            }
            ErrorMessage = "personal number must be only 11 digits";
            return false;
        }
    }
}
