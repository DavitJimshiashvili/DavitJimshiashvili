using System;

namespace Day_09_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();

            Console.WriteLine("Creating Cat object...");

            Console.Write("Enter name: ");
            cat.Name = Console.ReadLine();

            Console.Write("Enter breed: ");
            cat.Breed = Console.ReadLine();

            Console.Write("Enter age: ");
            cat.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter sex: ");
            cat.Sex = Console.ReadLine();

            Console.WriteLine("Cat object created.");

            Console.Write("Enter food weight in grams: ");
            cat.FoodPortion = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} start eating.",cat.Name);
            cat.Eating();
            Console.WriteLine("{0} finished eating.", cat.Name);


            Console.Write("Enter meowing count: ");
            cat.MeowingCount = int.Parse(Console.ReadLine());
            cat.Meowing();







            Console.ReadKey();
        }
    }
}
