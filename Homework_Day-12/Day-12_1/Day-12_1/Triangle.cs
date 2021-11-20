using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12_1
{
    public class Triangle : Shape
    {
        private readonly double _sideAB;
        private readonly double _sideBC;
        private readonly double _sideCA;

        Point A { get; set; }
        Point B { get; set; }
        Point C { get; set; }

        public Triangle(Point[] pointsArr)

        {
            A = pointsArr[0];
            B = pointsArr[1];
            C = pointsArr[2];
            _sideAB = Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
            _sideBC = Math.Sqrt((C.X - B.X) * (C.X - B.X) + (C.Y - B.Y) * (C.Y - B.Y));
            _sideCA = Math.Sqrt((A.X - C.X) * (A.X - C.X) + (A.Y - C.Y) * (A.Y - C.Y));
        }

        public override double Perimeter()
        {
            double perimeter = _sideAB + _sideBC + _sideCA;
            return perimeter;
        }
        public override double Area()
        {
            double semiPerimeter = Perimeter() / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - _sideAB) * (semiPerimeter - _sideBC) *
                (semiPerimeter - _sideCA));

            return area;
        }


    }
}
