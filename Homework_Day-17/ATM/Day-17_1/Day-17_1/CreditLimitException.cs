using System;
using System.Collections.Generic;
using System.Text;

namespace Day_17_1
{
    public class CreditLimitException:Exception
    {

        public CreditLimitException()
        {
        }

        public CreditLimitException(string message)
            : base(message)
        {
        }

        public CreditLimitException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
