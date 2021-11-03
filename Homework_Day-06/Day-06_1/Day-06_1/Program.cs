using System;
using System.Text;

namespace Day_06_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your string here: ");
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            string defaultCondition = "vowels";
            sb.Append("Vowel count: ");
            sb.AppendLine(vowelCounter(input, defaultCondition));
            sb.Append("Vowels: ");
            Console.Write(sb.ToString());
            printVowels(input, defaultCondition);

            Console.Write("Enter c if you want to count consonats in string: ");
            string optional = Console.ReadLine();
            Console.Write("Consonant count: ");
            Console.WriteLine(vowelCounter(input, optional));
            Console.Write("Consonants: ");
            printVowels(input, optional);






            Console.ReadKey();
        }

        static string vowelCounter(string inputstr, string str)
        {
            int counter = 0;
            string temp = "aeiouAEIOU";
            if (str == "vowels")
            {
                for (int i = 0; i < inputstr.Length; i++)
                {
                    if (temp.Contains(inputstr[i]))
                        counter++;

                }
                return counter.ToString();
            }
            else
            {
                for (int i = 0; i < inputstr.Length; i++)
                {
                    if (((inputstr[i] >= 'a' && inputstr[i] <= 'z') || (inputstr[i] >= 'A' && inputstr[i] <= 'Z')) && !(temp.Contains(inputstr[i])))
                    {
                        counter++;
                    }

                }
                return counter.ToString();
            }
        }

        static void printVowels(string inputStr, string str)
        {
            string temp = "aeiouAEIOU";

            if (str == "vowels")
            {
                for (int i = 0; i < inputStr.Length; i++)
                {
                    if (temp.Contains(inputStr[i]))
                    {
                        Console.Write(inputStr[i] + " ");
                    }
                }
                Console.WriteLine();
            }
            else
                for (int i = 0; i < inputStr.Length; i++)
                {
                    if (((inputStr[i] >= 'a' && inputStr[i] <= 'z') || (inputStr[i] >= 'A' && inputStr[i] <= 'Z')) && !(temp.Contains(inputStr[i])))
                    {
                        Console.Write(inputStr[i]+" ");
                    }

                }

        }
    }
}
