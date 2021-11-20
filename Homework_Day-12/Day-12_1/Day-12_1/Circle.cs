using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12_1
{
    public class Circle : Shape
    {
        private readonly double _radius;
        Point A { get; }
        Point B { get; }
        public Circle(Point[] pointsArr)
        {
            A = pointsArr[0];
            B = pointsArr[1];
            _radius = Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
        }


        public override double Area()
        {
            double area = Math.PI * _radius * _radius;
            return area;

        }

        public override double Perimeter()
        {
            double perimeter = 2 * Math.PI * _radius;

            return perimeter;
        }
      
    }
}
