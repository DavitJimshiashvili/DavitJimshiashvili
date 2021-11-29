using System;
using System.Collections.Generic;
using System.Text;

namespace Day_15_1
{
    public class Matrix
    {
        private readonly int[,] _values;


        public Matrix(int[,] values)
        {
            _values = values;
        }
        public static Matrix operator + (Matrix a, Matrix b)
        {
            int[,] newMatrix = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    newMatrix[i, j] = a._values[i, j] + b._values[i, j];
                }
            }

            return new Matrix(newMatrix);
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            
            int[,] newMatrix = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    newMatrix[i, j] = a._values[i, j] - b._values[i, j];
                }
            }

            return new Matrix(newMatrix);
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            int[,] newMatrix = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    newMatrix[i, j] = 0;
                    for (int k = 0; k <2; k++)
                    {
                        newMatrix[i, j] += a._values[i, k] * b._values[k, j];
                    }
                }
            }

            return new Matrix(newMatrix);
        }
        public override string ToString()
        {
            return $"[{_values[0, 0]} {_values[0, 1]}]\n[{_values[1, 0]} {_values[1, 1]}]";
        }

    }
}
