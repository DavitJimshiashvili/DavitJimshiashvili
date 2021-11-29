using System;
using System.Collections.Generic;
using System.Text;

namespace Day_15_1
{
    public class IntMathOperation<T> : IMathOperation<int>
    {
        public  int Addition(int a, int b)
        {
            return a + b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;

        }

        public int Subtraction(int a, int b)
        {
            return a - b;

        }
    }
}
