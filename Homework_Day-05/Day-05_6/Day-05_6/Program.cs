using System;

namespace Day_05_6
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = filledArr();

            Console.Write("Enter symbol to check the array: ");
            char symbol = char.Parse(Console.ReadLine());

            int count = symbolCount(arr, symbol);

            print(symbol, count);

            Console.ReadKey();

        }

        static char[] filledArr()
        {
            Console.Write("Enter size of array: ");
            int arrSize = int.Parse(Console.ReadLine());
            char[] array = new char[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                Console.Write("Enter character for index " + i + ": ");
                array[i] = char.Parse(Console.ReadLine());
            }

            return array;
        }

        static int symbolCount(char[] arr, char symbol)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == symbol)
                    counter++;
            }
            return counter;
        }

        static void print(char sym, int cnt)
        {
            Console.WriteLine("simbolo " + "'" + sym + "'" + " shegvxvda " + cnt + "-jer");
        }
    }
}
