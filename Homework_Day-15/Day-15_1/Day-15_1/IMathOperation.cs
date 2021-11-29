using System;
using System.Collections.Generic;
using System.Text;

namespace Day_15_1
{
    public interface IMathOperation<T>
    {
        public  T Addition(T a , T b);
        public  T Subtraction(T a, T b);
        public   T Multiplication(T a, T b);
    }
}
