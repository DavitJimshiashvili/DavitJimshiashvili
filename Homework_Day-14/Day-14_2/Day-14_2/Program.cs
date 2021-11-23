using System;

namespace Day_14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] firstTriangleSides = new double[3];
            Console.WriteLine("Creating first triangle:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter side-{0}: ",i);
                firstTriangleSides[i] = double.Parse(Console.ReadLine());
            }
            double[] secondTriangleSides = new double[3];
            Console.WriteLine("Creating second triangle:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter side-{0}: ", i);
                secondTriangleSides[i] = double.Parse(Console.ReadLine());
            }


            Triangle triangle1 = new Triangle(firstTriangleSides);
            Triangle triangle2 = new Triangle(secondTriangleSides);
            Console.WriteLine("First triangle: {0}",triangle1.ToString());
            Console.WriteLine("Second triangle: {0}",triangle2.ToString());
            Console.WriteLine("Triangles are equal? : {0}",triangle1==triangle2);
            Console.WriteLine("Triangle 1 > Triangle 2 ? : {0}",triangle1>triangle2);
            Console.WriteLine("Triangle 1 < Triangle 2 ? : {0}",triangle1<triangle2);
            Console.WriteLine("Enter double number for explicit cast: ");
            double input = double.Parse(Console.ReadLine());
            var triangleAfterCast=(Triangle)input;
            Console.WriteLine(triangleAfterCast.ToString());
        
        }

    }
}
