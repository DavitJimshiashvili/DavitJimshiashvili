using System;

namespace Day_03_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;

            Console.Write("Enter a Number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int holder = input;


            result = "";
            while (input > 1)
            {
                int remainder = input % 2;
                result = Convert.ToString(remainder) + result;
                input /= 2;
            }

            result = Convert.ToString(input) + result;
            Console.WriteLine("Decimal " + holder + " in binary is {0}", result);
        }
    }
}