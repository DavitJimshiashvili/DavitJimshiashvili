using System;

namespace Day_02_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number :");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 + num2 > num3 && num1 + num3 > num2 && num2 + num3 > num1)
            {
                Console.WriteLine("This should be a triangle !");
            }
            else Console.WriteLine("This should not be a triangle !");
        }
    }
}
