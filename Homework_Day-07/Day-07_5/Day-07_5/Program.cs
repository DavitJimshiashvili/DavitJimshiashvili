using System;

namespace Day_07_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string inputString = Console.ReadLine();
            int stringSize = inputString.Length;
            bool variable = IsPalindromeRecursive(inputString, stringSize - 1);

            Console.WriteLine(variable);

            Console.ReadKey();
        }

        static bool IsPalindromeRecursive(string str, int lastIndex, int startIndex = 0)
        {


            if (startIndex >= lastIndex)
                return true;

            if (str[startIndex] != str[lastIndex])
                return false;

            if (str[startIndex] == str[startIndex + 1])
                return true;

            if (startIndex < lastIndex + 1)
                return IsPalindromeRecursive(str, startIndex + 1, lastIndex - 1);

            return false;

        }
    }
}

