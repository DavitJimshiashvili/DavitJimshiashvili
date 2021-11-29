using System;
using System.Collections.Generic;
using System.Text;

namespace Day_15_1
{
    public class MatrixMathOperation<T> : IMathOperation<Matrix>
    {

        public Matrix Addition(Matrix a, Matrix b)
        {
            return a + b;
        }

        public Matrix Multiplication(Matrix a, Matrix b)
        {
            return a * b;
        }

        public Matrix Subtraction(Matrix a, Matrix b)
        {
            return a - b;
        }
    }
}
