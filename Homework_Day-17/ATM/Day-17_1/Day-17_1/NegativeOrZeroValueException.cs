using System;
using System.Collections.Generic;
using System.Text;

namespace Day_17_1
{
    public class NegativeOrZeroValueException:Exception
    {

        public NegativeOrZeroValueException()
        {
        }

        public NegativeOrZeroValueException(string message)
            : base(message)
        {
        }

        public NegativeOrZeroValueException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
