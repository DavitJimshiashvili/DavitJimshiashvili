using System;
using System.Collections.Generic;
using System.Text;

namespace Day_14_2
{
    public  class Triangle
    {
        public  double SideA { get; set; }
        public  double SideB { get; set; }
        public  double SideC { get; set; }

        public Triangle(double[] sides)
        {
            double a = sides[0];
            double b = sides[1];
            double c = sides[2];
            if(a + b > c && c + a > b && b + c > a)
            {
                SideA = a;
                SideB = b;
                SideC = c;
            }
            else Console.WriteLine("This can't be a triangle!!");
        }


        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public  double Perimeter()
        {
            return SideA + SideB + SideC;
        }


        public static bool operator ==(Triangle a, Triangle b)
        {
            return a.Area() == b.Area();
        }

        public static bool operator !=(Triangle a, Triangle b)
        {
            return a.Area() != b.Area();
        }

        public static bool operator >(Triangle a, Triangle b)
        {
            return a.Area() > b.Area();
        }
        public static bool operator <(Triangle a, Triangle b)
        {
            return a.Area() < b.Area();
        }

        public static Triangle operator +(Triangle a, Triangle b)
        {
            double rightTriangleArea = a.Area() + b.Area();
            double leg, hypotenuse;
            leg = Math.Sqrt(2 * rightTriangleArea);
            hypotenuse = leg * Math.Sqrt(2);
            
            return new Triangle(new double[]{ leg,leg,hypotenuse});

        }

        public static explicit operator Triangle(double a)
        {
            return new Triangle(new double[] {a,a,a});
        }

        public override string ToString()
        {
            return $"Side a={SideA}, Side b={SideB}, Side c={SideC}\nArea={this.Area()}, Perimeter={this.Perimeter()}";
        }
    }
}
