using System;

namespace Day_04_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int arrSize = Convert.ToInt32(Console.ReadLine());
            int[] numbersArray = new int[arrSize];
            int sum = 0;

            for (int i = 0; i < arrSize; i++)
            {
                Console.Write("Enter number for index " + i + ": ");
                numbersArray[i] = int.Parse(Console.ReadLine());
                sum += numbersArray[i];
            }

            Console.WriteLine("Sum of array elements is " + sum);
        }
    }
}