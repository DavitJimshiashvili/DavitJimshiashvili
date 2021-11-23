using System;

namespace Day_14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 2;
            int columns = 2;


            double[,] matrix1 = new double[rows, columns];
            Console.WriteLine("Creating matrix- dimenssion {0}x{1}", rows, columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Enter number on [row,column]--[{0},{1}]: ", i + 1, j + 1);
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            double[,] matrix2 = new double[rows, columns];
            Console.WriteLine("Creating matrix- dimenssion {0}x{1}", rows, columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Enter number on [row,column]--[{0},{1}]: ", i + 1, j + 1);
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Matrix m1 = new Matrix(matrix1);
            Matrix m2 = new Matrix(matrix2);
            Matrix mult = m1 * m2;
            Matrix sum = m1 + m2;
            Matrix sub = m1 - m2;
            Matrix transpose = -m1;


            Console.WriteLine("First matrix m1:\n{0}",m1.ToString());
            Console.WriteLine("Second matrix m2:\n{0}",m2.ToString());

            Console.WriteLine("Addition m1+m2:\n{0}", sum.ToString());
            Console.WriteLine("Substraction m1-m2:\n{0}", sub.ToString());
            Console.WriteLine("Multiplication m1-m2:\n{0}", mult.ToString());

            Console.WriteLine("m1 equals m2 ? :\n{0}", m1.Equals(m2));

            Console.WriteLine("Transpose of first matrix:\n{0}", transpose.ToString());

            Console.WriteLine("Implicit cast of first matrix:\n{0}", (double)m1);






            Console.ReadKey();
        }
    }
}
