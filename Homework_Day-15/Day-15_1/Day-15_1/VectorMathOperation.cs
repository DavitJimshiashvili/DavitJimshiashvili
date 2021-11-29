using System;
using System.Collections.Generic;
using System.Text;

namespace Day_15_1
{
    public class VectorMathOperation<T> : IMathOperation<Vector> where T:Vector
    {
        public Vector Addition(Vector a, Vector b)
        {
            return a + b;
        }

        public Vector Subtraction(Vector a, Vector b)
        {
            return a - b;
        }

        public Vector Multiplication(Vector a, Vector b)
        {
            return a * b;
        }
    }
}