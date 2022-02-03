using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PersonManagement.Web.Infrastracture.Attributes
{
    public class BankCardAttribute:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string bankCard = value as string;
            string regexPattern = @"^[0-9]{16}";
            if (Regex.IsMatch(bankCard,regexPattern))
            {
                return true;
            }



            ErrorMessage = "bank card is not in correct format";
            return false;
        }
    }
}
