using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateW.Services.Exceptions
{
    public class ObjectAlreadyExistsException:Exception
    {
        public string Code = "ObjectAlreadyExsists";
        public ObjectAlreadyExistsException(string errorMsg) : base(errorMsg)
        {

        }
    }
}
