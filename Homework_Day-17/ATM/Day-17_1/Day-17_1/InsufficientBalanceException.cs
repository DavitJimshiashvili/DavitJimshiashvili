using System;
using System.Collections.Generic;
using System.Text;

namespace Day_17_1
{
    public class InsufficientBalanceException:Exception
    {

        public InsufficientBalanceException()
        {
        }

        public InsufficientBalanceException(string message)
            : base(message)
        {
        }

        public InsufficientBalanceException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
