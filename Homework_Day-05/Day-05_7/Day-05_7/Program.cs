using System;

namespace Day_05_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter count of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter count of columns: ");
            int columns = int.Parse(Console.ReadLine());

            Console.WriteLine("===================================");

            int[,] array1=fillArray(rows, columns);
            int[,] array2 = fillArray(rows, columns);
            int[,] sum = sumOfArrays(array1, array2);

            printArray(sum);


            Console.ReadKey();
        }

        static int[,] fillArray(int rows, int columns)
        {

            int[,] array = new int[rows,columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Enter integer for index " + i + "," + j + ": ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("===================================");

            return array;
        }

        static int[,] sumOfArrays(int[,] arr1, int[,] arr2)
        {

            for (int i = 0; i < arr1.GetLength(0); i++)
            {

                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr1[i, j] += arr2[i, j];
                }
            }

            return arr1;
        }

        static void printArray(int[,] arr)
        {
            Console.Write("Here is sum of  matrices");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("\n");
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i, j] + ", ");
            }
            Console.WriteLine();
        }
    }
}
