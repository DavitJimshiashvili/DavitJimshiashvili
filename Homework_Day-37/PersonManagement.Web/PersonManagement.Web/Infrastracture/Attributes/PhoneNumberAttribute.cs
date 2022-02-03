using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PersonManagement.Web.Infrastracture.Attributes
{
    public class PhoneNumberAttribute:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var phoneNum = value as string;
            var regexPattern = @"[5][0-9]{8}";

            if (Regex.IsMatch(phoneNum,regexPattern))
            {
                return true;
            }

            ErrorMessage = "this number is not in correct format 5XX-XXX-XXX";
            return false;
        }
    }
}
