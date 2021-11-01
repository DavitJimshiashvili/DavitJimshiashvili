using System;

namespace Day_03_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            Console.Write("divisors of " + input + " are: ");
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    Console.Write(i + " ");
            }
        }
    }
}
