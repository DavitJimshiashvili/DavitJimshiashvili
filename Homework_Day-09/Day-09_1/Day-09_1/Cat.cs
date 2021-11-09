using System;
using System.Collections.Generic;
using System.Text;

namespace Day_09_1
{
    class Cat
    {

        string _Name;
        string _Breed;
        //int _Age;
        //string _Sex;
        int _MeowingCount;
        int _Morsel = 10;
        int _FoodPortion;


        public string Name
        {
            get 
            {
                return _Name;
            }
            set 
            {
                _Name = value; 
            }
        }

        public string Breed
        {
            get
            {
                return _Breed;
            }
            set
            {
                _Breed = value;
            }
        }

        public int Age { get; set; }

        public string Sex { get; set; }

        public int MeowingCount
        {
            get 
            { 
                return _MeowingCount;
            }
            set
            {
                _MeowingCount = value;
            }
        }

        public int FoodPortion
        {
            get
            { 
                return _FoodPortion;
            }
            set 
            {
                    _FoodPortion = value;
            }
        }


        public void Meowing()
        {
            for (int i = 0; i < MeowingCount; i++)
            {
                Console.WriteLine("Meowing ...");
            }
        }

        public void Eating()
        {
            do
            {
                Console.WriteLine("Eating ...");
                FoodPortion -= _Morsel;
               
            } while (FoodPortion > 0);
               
            
        }

      


    }
}
