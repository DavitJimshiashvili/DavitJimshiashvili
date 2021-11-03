using System;

namespace Day_06_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string input = Console.ReadLine();
            reversedString(input);


            Console.ReadKey();
        }
        static void reversedString(string str)
        {
            var temp = str.ToCharArray();
            Array.Reverse(temp);

            string reversed = new string(temp);
            Console.WriteLine(temp);
        }
    }
}
