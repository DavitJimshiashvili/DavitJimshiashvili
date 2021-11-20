using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12_1
{
    public class Quadrilateral : Shape
    {
        private readonly double _sideAB;
        private readonly double _sideBC;
        private readonly double _sideCD;
        private readonly double _sideDA;

        Point A { get; }
        Point B { get; }
        Point C { get; }
        Point D { get; }


        public Quadrilateral(Point[] pointsArr)
        {
            A = pointsArr[0];
            B = pointsArr[1];
            C = pointsArr[2];
            D = pointsArr[3];
            _sideAB = Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
            _sideBC = Math.Sqrt((C.X - B.X) * (C.X - B.X) + (C.Y - B.Y) * (C.Y - B.Y));
            _sideCD = Math.Sqrt((C.X - D.X) * (C.X - D.X) + (C.Y - D.Y) * (C.Y - D.Y));
            _sideDA = Math.Sqrt((D.X - A.X) * (D.X - A.X) + (D.Y - A.Y) * (D.Y - A.Y));
        }


        public override double Perimeter()
        {
            return _sideAB + _sideBC + _sideCD + _sideDA;
        }
        public override double Area()
        {
            double diagonalAC = Math.Sqrt((C.X - A.X) * (C.X - A.X) + (C.Y - A.Y) * (C.Y - A.Y));

            double abcSemiperimeter = (_sideAB + _sideBC + diagonalAC) / 2;
            double abcArea = Math.Sqrt(abcSemiperimeter * (abcSemiperimeter - _sideAB) *
                (abcSemiperimeter - _sideBC) * (abcSemiperimeter - diagonalAC));

            double acdSemiperimeter = (_sideCD + _sideDA + diagonalAC) / 2;
            double acdArea = Math.Sqrt(acdSemiperimeter * (acdSemiperimeter - _sideCD)
                * (acdSemiperimeter - _sideDA) * (acdSemiperimeter - diagonalAC));

            double quadriliteralArea = abcArea + acdArea;

            return quadriliteralArea;
        }
    }
}
