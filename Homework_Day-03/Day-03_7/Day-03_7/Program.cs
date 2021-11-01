using System;

namespace Day_03_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, sum;
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());
            Console.Write(a + " " + b + " ");
            for (int i = 2; i <= input; ++i)
            {
                sum = a + b;
                Console.Write(sum + " ");
                a = b;
                b = sum;
            }
        }
    }
}