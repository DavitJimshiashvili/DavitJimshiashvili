using System;

namespace Day_04_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array row size: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter array column size: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] array0 = new int[rows, columns];
            int[,] array1 = new int[rows, columns];

            Console.WriteLine("Fill first matrix");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Enter number for index " + i + "," + j + ": ");
                    array0[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n Fill second matrix");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Enter number for index " + i + "," + j + ": ");
                    array1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array0[i, j] += array1[i, j];
                }
            }


            Console.Write("Here is sum of two matrices");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < columns; j++)
                    Console.Write(array0[i, j] + ", ");
            }
            Console.WriteLine("\n");

            Console.ReadKey();

        }
    }
}