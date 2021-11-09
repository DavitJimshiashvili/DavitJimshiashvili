using System;

namespace Day_09_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();

            Console.Write("Enter hours: ");
            time.Hours = int.Parse(Console.ReadLine());

            Console.Write("Enter minutes: ");
            time.Minutes = int.Parse(Console.ReadLine());

            Console.Write("Enter seconds: ");
            time.Seconds = int.Parse(Console.ReadLine());

            time.GetCurrentTime();

            //for (int i = 0; i < 4; i++)
            //{
            //    time.AddSecond();
            //}

            //time.GetCurrentTime();
            //Console.WriteLine("-------------------");

            //for (int i = 0; i < 3; i++)
            //{
            //    time.AddSecond();
            //}
            //time.AddMinute();

            //time.GetCurrentTime();




            Console.ReadKey();
        }
    }
}
