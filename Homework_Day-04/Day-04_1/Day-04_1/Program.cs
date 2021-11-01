using System;

namespace Day_04_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int arrSize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                Console.Write("Enter number for index " + i + ": ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Here is your array!\n");

            foreach (var numbers in array)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}