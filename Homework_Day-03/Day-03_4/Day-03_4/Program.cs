using System;

namespace Day_03_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= input; i += 2)
            {
                sum += i;
            }

            Console.Write("sum of odd numbers from 1 to " + input + " is " + sum);
        }
    }
}