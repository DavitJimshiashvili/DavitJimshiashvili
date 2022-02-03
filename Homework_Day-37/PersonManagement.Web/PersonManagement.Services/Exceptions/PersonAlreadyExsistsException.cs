using PersonManagement.Services.Localisations;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonManagement.Services.Exceptions
{
    public class PersonAlreadyExsistsException:Exception
    {
        public string Code = ErrorMessages.Conflict;
        public PersonAlreadyExsistsException(string message) : base(message) { }
    }
}
