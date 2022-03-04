using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateW.Services.Exceptions
{
    public class ObjectNotFoundException:Exception
    { 
        public string Code = "ObjectNotFound";

        public ObjectNotFoundException(string errorMsg) : base(errorMsg)
        {

        }
    }
}
