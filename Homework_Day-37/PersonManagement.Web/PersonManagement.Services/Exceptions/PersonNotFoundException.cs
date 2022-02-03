using PersonManagement.Services.Localisations;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonManagement.Services.Exceptions
{
   public class PersonNotFoundException : Exception
    {
        public string Code = ErrorMessages.NotFound;
        public PersonNotFoundException(string message) :base(message){}
    }
}
