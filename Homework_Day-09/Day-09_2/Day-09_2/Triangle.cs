using System;
using System.Collections.Generic;
using System.Text;

namespace Day_09_2
{
    class Triangle
    {
        int _Side1;
        int _Side2;
        int _Side3;

  
        public int Side1
        {
            get
            {
                return _Side1;
            }
            set
            {
                _Side1 = value;
            }
        }

        public int Side2
        {
            get
            { 
                return _Side2;
            }
            set 
            { 
                _Side2 = value; 
            }
        }

        public int Side3
        {
            get 
            {
                return _Side3; 
            }
            set 
            {
                    _Side3 = value;
            }
        }

         public bool  IsValid()
        {
            if (_Side1 + _Side2 > _Side3 && _Side1 + _Side3 > _Side2 && _Side2 + _Side3 > _Side1)
                return true;
            else
            {
                Console.WriteLine("It is not valid triangle");
              
            }
            return false;

        }

        public int Perimeter()
        {
            return _Side1 + _Side2 + _Side3;
        }


        public double Area()
        {
            int s = Perimeter() / 2;
            return Math.Sqrt(s * (s - _Side1) * (s - _Side2) * (s - _Side3));
        }
    }
}
