
using System;

namespace Day_02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Entered number " + number + " is even");
            }
            else if (number % 2 == 1)
            {
                Console.WriteLine("Entered number " + number + " is odd");
            }
        }
    }
}
