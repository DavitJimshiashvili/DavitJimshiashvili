using System;

namespace Day_06_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string input = Console.ReadLine();
            int letterCount=letterCounter(input);
            int digitCount=digitCounter(input);
            printCounts(letterCount, digitCount, input);


            Console.ReadKey();
        }

        static int digitCounter(string str)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i]<= '9')
                    counter++;
            }
            return counter;
        }

         static int letterCounter(string str)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'a' && str[i] <= 'z'))
                    counter++;
            }
            return counter;
        }

         static void printCounts(int lCount, int dCount, string str)
        {
            string letters = "Letters: " + lCount;
            string numbers = " ,Numbers: " + dCount;
            int othersCount = str.Length - lCount - dCount;
            string others = " ,Others: "+othersCount;
            Console.WriteLine("\""+str+"\""+" ->{0},{1},{2}",letters,numbers,others);
        }


    }
}
