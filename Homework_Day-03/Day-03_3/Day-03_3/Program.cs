using System;

namespace Day_03_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine(i + " cubed is " + Math.Pow(i, 3));
            }
        }
    }
}