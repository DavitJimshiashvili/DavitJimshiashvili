using System;

namespace Day_04_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("Enter number for index " + i + ": ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array);
            Console.WriteLine("Unique elements of array are");

            if (array[0] != array[1])
                Console.WriteLine(array[0]);

            for (int i = 1; i < arraySize - 1; i++)
            {
                if (array[i] != array[i + 1] && array[i] != array[i - 1])
                    Console.WriteLine(array[i]);
            }

            if (array[arraySize - 2] != array[arraySize - 1])
                Console.WriteLine(array[arraySize - 1]);


            Console.ReadKey();

        }
    }
}