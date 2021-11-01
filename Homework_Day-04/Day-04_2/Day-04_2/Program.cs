using System;

namespace Day_04_2
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

            Console.Write("Here is your array in a reverse order!\n");

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}