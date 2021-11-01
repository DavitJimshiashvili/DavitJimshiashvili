using System;

namespace Day_03_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Enter a number of rows of Floyd's triangle to be printed: ");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                if (i % 2 == 0)
                { a = 1; b = 0; }
                else
                { a = 0; b = 1; }
                for (int j = 1; j <= i; j++)
                    if (j % 2 == 0)
                        Console.Write("{0} ", a);
                    else
                        Console.Write("{0} ", b);
                Console.Write("\n");
            }
        }
    }
}