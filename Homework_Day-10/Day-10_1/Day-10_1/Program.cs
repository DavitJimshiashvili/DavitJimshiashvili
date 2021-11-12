using System;

namespace Day_10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] p = new Person [3];
            var homeA = new Home();
            p[0].Home = homeA;

            var homeB = new Home();
            p[1].Home = homeB;

            var homeC = new Home();
            p[2].Home = homeC;




        }
    }
}
