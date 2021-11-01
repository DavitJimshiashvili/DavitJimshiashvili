using System;

namespace Day_02_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            double result = Math.Pow(number, 2);
            Console.WriteLine("The pow of the entered number is " + result);
        }
    }
}
