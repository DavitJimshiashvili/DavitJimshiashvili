using System;

namespace Day_03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i <= input; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum from 1 to " + input + " is " + sum);
        }
    }
}