using System;

namespace Day_12_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Point[] trianglePoints = new Point[3];
            FillPoints(trianglePoints);
            Triangle triangle = new Triangle(trianglePoints);//0,0 0,5 8,5

            Point[] circlePoints = new Point[2];
            FillPoints(circlePoints);
            Circle circle = new Circle(circlePoints);//3,3 6,3

            Point[] quadrilateralPoints = new Point[4];
            FillPoints(quadrilateralPoints);
            Quadrilateral quadrilateral = new Quadrilateral(quadrilateralPoints);//0,0 0,5 8,5 8,0


            Shape[] shapesArr = new Shape[] { triangle, circle, quadrilateral };
            foreach (var shape in shapesArr)
            {
                Console.Write("Perimeter: {0}",shape.Perimeter());
                Console.Write(" Area: {0}\n",shape.Area());
            }
          
        }
        public static void FillPoints(Point[] shapePoints)
        {
            switch (shapePoints.Length)
            {
                case 2:
                    Console.WriteLine("Creating Circle object: ");
                    break;
                case 3:
                    Console.WriteLine("Creating Triangle object: ");
                    break;
                case 4:
                    Console.WriteLine("Creating Quadrilateral object: ");
                    break;
                default:
                    break;
            }
            for (int i = 0; i < shapePoints.Length; i++)
            {
                shapePoints[i] = new Point();
                Console.Write("enter abscissa x[{0}]: ", i);
                shapePoints[i].X = double.Parse(Console.ReadLine());
                Console.Write("enter ordinate y[{0}]: ", i);
                shapePoints[i].Y = double.Parse(Console.ReadLine());
            }
        }

    }
}
