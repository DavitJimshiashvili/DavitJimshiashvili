using System;

namespace Day_03_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i <= 10; i++)
            {
                sum += i;
            }
            Console.Write("Sum from 0 to 10 is " + sum);
        }
    }
}