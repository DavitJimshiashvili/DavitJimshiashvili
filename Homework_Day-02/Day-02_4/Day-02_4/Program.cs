using System;

namespace Day_02_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth year:");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            int temp = birthYear % 12;

            switch (temp)
            {
                case 0:
                    Console.WriteLine(birthYear + " was Monkey year");
                    break;
                case 1:
                    Console.WriteLine(birthYear + " was Rooster year");
                    break;
                case 2:
                    Console.WriteLine(birthYear + " was Dog year");
                    break;
                case 3:
                    Console.WriteLine(birthYear + " was Pig year");
                    break;
                case 4:
                    Console.WriteLine(birthYear + " was Rat year");
                    break;
                case 5:
                    Console.WriteLine(birthYear + " was Ox year");
                    break;
                case 6:
                    Console.WriteLine(birthYear + " was Tiger year");
                    break;
                case 7:
                    Console.WriteLine(birthYear + " was Rabbit year");
                    break;
                case 8:
                    Console.WriteLine(birthYear + " was Dragon year");
                    break;
                case 9:
                    Console.WriteLine(birthYear + " was Snake year");
                    break;
                case 10:
                    Console.WriteLine(birthYear + " was Horse year");
                    break;
                case 11:
                    Console.WriteLine(birthYear + " was Sheep year");
                    break;
                    //no need for case default, because (any number)%12=>should be numbers{from 0 to 11}
            }
        }
    }
}
