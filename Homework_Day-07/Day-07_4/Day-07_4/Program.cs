using System;

namespace Day_07_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter base number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter exponent: ");
            int degree = int.Parse(Console.ReadLine());

            int result = PowerOfNumberTail(number, degree);
            Console.WriteLine( result);



            Console.ReadKey();
        }

        static int PowerOfNumberTail(int num, int degree, int tmp=1)
        {
            if (degree == 0)
                return tmp;
            if (num == 0)
                return 0;

            return PowerOfNumberTail(num, degree - 1,num*tmp);
        }
    }
}
