using System;

namespace Day_07_1
{
    class Program
    {
        static void PrintingRecursiveTail(int num)
        {
            if (num < 1)
                return;
            Console.Write(num+" ");
            PrintingRecursiveTail(num - 1);

        }




        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            PrintingRecursiveTail(input);

            Console.ReadKey();
        }
    }
}
