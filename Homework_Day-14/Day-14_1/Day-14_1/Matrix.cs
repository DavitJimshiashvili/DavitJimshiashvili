using System;
using System.Collections.Generic;
using System.Text;

namespace Day_14_1
{
    public class Matrix
    {
        private readonly double[,] _values;
   

        public int Rows { get; set; }
        public int Columns { get; set; }
        public double this[int r, int c]
        {
            get { return _values[r, c]; }
        }

        public Matrix(double[,] values)
        {
            _values = values;
            Rows = values.GetLength(0);
            Columns = values.GetLength(1);
        }

        public static Matrix operator + (Matrix a, Matrix b)
        {
            double[,] m1 = a._values;
            double[,] m2 = b._values;
            int rows = a.Rows;
            int cols = a.Columns;
            double[,] newMatrix = new double[rows,cols]  ;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <cols; j++)
                {
                    newMatrix[i, j] =m1[i,j] + m2[i, j];   
                }
            }

            return new Matrix(newMatrix);
        }

        public static Matrix operator - (Matrix a, Matrix b)
        {
            double[,] m1 = a._values;
            double[,] m2 = b._values;
            int rows = a.Rows;
            int cols = a.Columns;
            double[,] newMatrix = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    newMatrix[i, j] = m1[i, j] - m2[i, j];
                }
            }

            return new Matrix(newMatrix);
        }
        public static Matrix operator * (Matrix a, Matrix b)
        {  
            int rows = a.Rows;
            int cols = b.Columns;
            double[,] newMatrix = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    newMatrix[i, j] = 0;
                    for (int k = 0; k < a.Columns; k++)
                    {
                        newMatrix[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return new Matrix(newMatrix);
        }

        public static implicit operator double(Matrix a)
        {
            double[,] m = a._values;
            double detA = m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0];
            return detA;
        }

        public static Matrix operator - (Matrix a)
        {
            double[,] m = a._values;
            double[,] transposeMatrix = new double[m.GetLength(0), m.GetLength(1)];
            double detInverted = 1/(double)a;
            double[,] adjMatrix = new double[2, 2] { {m[1,1],-m[0,1] },{-m[1,0], m[0, 0] } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    transposeMatrix[i, j] = adjMatrix[i, j] * detInverted;
                }
            }

            return new Matrix(transposeMatrix);
        }


        public override bool Equals(object a)
        {
            Matrix matrix = a as Matrix ;
            bool result = true;
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    if (this[i, j] != matrix[i, j])
                        result = false;
                }
            }
            return result;
        }

        public override string ToString()
        {
            return String.Format("[{0} {1}]\n[{2} {3}]", this[0, 0], this[0, 1], this[1, 0], this[1, 1]);
        }



    }
}
