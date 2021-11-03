using System;

namespace Day_05_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string input=takeNumber();
            int lngth = input.Length;
            int[] array = dissolved(input, lngth);
            Console.Write(input + " = ");
            for (int i = 0; i < lngth - 1; i++)
            {
                Console.Write(array[i]+" * 10^");
                Console.Write(lngth-i-1);
                Console.Write(" + ");
            }
            Console.WriteLine(array[lngth-1] + " * 10^0");

            Console.ReadKey();
        }

        static string takeNumber()
        {
            Console.Write("Enter a positive number: ");
            string num = Console.ReadLine();
            return num;
        }

        static int[] dissolved(string num, int length)
        {
            int number = int.Parse(num);
            int[] arr = new int[length];
            int index = 0;

            while (number>0)
            {
                arr[index] = number % 10;
                number /= 10;
                index++;
            }

            Array.Reverse(arr);

            return arr;
        }

   
    }
}
