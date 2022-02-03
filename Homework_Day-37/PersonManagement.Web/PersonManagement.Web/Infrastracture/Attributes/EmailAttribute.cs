using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PersonManagement.Web.Infrastracture.Attributes
{
    public class EmailAttribute:ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            string email = value as string;
            string regexPattern = @"^[A-Z0-9._%-]+@[A-Z0-9.-]+\.@gmail.com|@yahoo.com$";

            if (Regex.IsMatch(email, regexPattern))
            {
                return true;
            }


            ErrorMessage = "Email format should be gmail.com or yahoo.com";
            return false;
        }
    }
}
