using System;

namespace Day_07_3
{
    class Program
    {
        static int DigitsRecursiveTail(int num, int sum=1)
        {
            if (num / 10 == 0)
                return sum;

            return DigitsRecursiveTail(num / 10, sum+1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int input = int.Parse(Console.ReadLine());
            Console.Write("total digits: ");
            Console.WriteLine(DigitsRecursiveTail(input));

            Console.ReadKey();
        }
    }
}
