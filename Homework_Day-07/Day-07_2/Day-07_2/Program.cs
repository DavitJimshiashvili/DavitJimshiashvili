using System;

namespace Day_07_2
{
    class Program
    {
        static int SumRecursiveTail(int num, int basis)
        {
            if (num==1)
                return basis;

            return SumRecursiveTail(num-1,num+basis);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(SumRecursiveTail(input,1));


            Console.ReadKey();
        }
    }
}
