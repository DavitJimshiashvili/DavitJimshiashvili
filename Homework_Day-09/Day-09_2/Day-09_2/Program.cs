using System;

namespace Day_09_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            Console.Write("Enter side 1: ");
            triangle.Side1 = int.Parse(Console.ReadLine());

            Console.Write("Enter side 2: ");
            triangle.Side2 = int.Parse(Console.ReadLine());

            Console.Write("Enter side 3: ");
            triangle.Side3 = int.Parse(Console.ReadLine());

            if (triangle.IsValid())
            {
                Console.WriteLine("Perimeter of the triangle is: {0} ", triangle.Perimeter());
                Console.WriteLine("Area of the triangle is: {0} ", triangle.Area());
            }






            Console.ReadKey();
        }
    }
}
