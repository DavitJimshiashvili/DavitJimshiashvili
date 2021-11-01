using System;

namespace Day_04_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter array row size: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter array column size: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] array2d = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Enter number for index " + i + "," + j + ": ");
                    array2d[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Here is matrix view of multidimensional array");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < columns; j++)
                    Console.Write(array2d[i, j] + ", ");
            }
            Console.WriteLine("\n");

            Console.ReadKey();

        }


    }
}