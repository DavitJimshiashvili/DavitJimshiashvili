using PersonManagement.Web.Infrastracture.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace PersonManagement.Web.Models
{
    public class CreatePersonRequest
    {
        [Required]
        [GeorgianOnly]
        public string FirstName { get; set; }

        [Required]
        [GeorgianOnly]
        public string LastName { get; set; }

        [Required]
        [PersonalNumber]
        public string PersonalNumber { get; set; }

        [Required]
        [Age]
        public int Age { get; set; }

        [Email]
        [Required]
        public string Email { get; set; }

        [Required]
        [PhoneNumber]
        public string PhoneNumber { get; set; }

        [Required]
        [BankCard]
        public string BankCard { get; set; }


        [Required]
        public string PersonalWebsite { get; set; }

    }
}
