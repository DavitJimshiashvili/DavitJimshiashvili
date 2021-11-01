using System;

namespace Day_04_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int arrSize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrSize];

            int product = 1;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter number for index " + i + ": ");
                array[i] = int.Parse(Console.ReadLine());
                product *= array[i];
            }

            Console.WriteLine("Product of array elements is " + product);
        }
    }
}