using System;

namespace Day_06_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence: ");
            string sentence = Console.ReadLine();
            wordCount(sentence);

            Console.ReadKey();
        }
        static void wordCount(string str)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    counter++;
            }
            Console.WriteLine(counter+1);
        }
    }
}
