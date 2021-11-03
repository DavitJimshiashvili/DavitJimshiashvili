using System;

namespace Day_05_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 123, 15, 13, 23, 98 };
            int index = int.Parse(Console.ReadLine());
            Console.Write("The sum of the digits at index " + index + " is ");
            Console.WriteLine(Sum(arr,index));

            Console.ReadKey();
        }

        static int Sum(int[] arr, int index)
        {
            int sum = 0;
            int number = arr[index];
            while(number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
