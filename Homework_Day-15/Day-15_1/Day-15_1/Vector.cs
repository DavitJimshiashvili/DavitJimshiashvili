using System;
using System.Collections.Generic;
using System.Text;

namespace Day_15_1
{
    public class Vector
    {
        public int Abscissa { get; set; }
        public int Ordinate { get; set; }
        public Vector(int abscissa, int ordinate)
        {
            Abscissa = abscissa;
            Ordinate = ordinate;
        }
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.Abscissa + b.Abscissa, a.Ordinate + b.Ordinate);
        }
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.Abscissa - b.Abscissa, a.Ordinate - b.Ordinate);
        }

        public static Vector operator *(Vector a, Vector b)
        {
            return new Vector(0, a.Abscissa*b.Abscissa+a.Ordinate*b.Ordinate);
        }
        public override string ToString()
        {
            return $"({Abscissa},{Ordinate})";
        }
    }
}
