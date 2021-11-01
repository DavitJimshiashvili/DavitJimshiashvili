using System;

namespace Day_05_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1=filledArr();
            float result = Average(arr1);

            Console.WriteLine("Arithmetic average of array is " + result );

            Console.ReadKey();
        }

        static int[] filledArr()
        {
            Console.Write("Enter size of array: ");
            int arrSize = int.Parse(Console.ReadLine());
            int[] array = new int[arrSize];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter number for index " + i + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;

        }

        static float Average(int[] array)
        {
            float sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum / array.Length;
        }

    }
}
