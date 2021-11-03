using System;
using System.Text;

namespace Day_06_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string:");
            string input = Console.ReadLine();
            spacedString(input);



            Console.ReadKey();
        }

        static void spacedString(string str)
        {
            char[] arr = str.ToCharArray();
            string resultString=String.Join(" ",arr);
            Console.WriteLine(resultString);
        }
    }
}
