﻿using System;

namespace PersonManagement.Services.Models
{
    public class PersonServiceModel
    {
        public int Id { get; set; }
        public string PersonalNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BankCard { get; set; }
        public string PersonalWebsite { get; set; }
    }
}