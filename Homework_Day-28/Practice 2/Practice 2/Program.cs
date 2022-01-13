using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Practice_2
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //ElectricCar car = new ElectricCar(2, "Tesla", 2022);
            //var stopwatch = Stopwatch.StartNew();
            //car.Charge();
            //stopwatch.Stop();
            //Console.WriteLine("________________________________");
            //Console.WriteLine($"Total time elapsed: {stopwatch.Elapsed.TotalSeconds} seconds");

            List<ElectricCar> cars = new List<ElectricCar>();
            var Tesla = new ElectricCar(60, "Tesla", 2021);
            cars.Add(Tesla);
            var BMW = new ElectricCar(0, "BMW", 2019);
            cars.Add(BMW);
            var Lamborghini = new ElectricCar(0, "Lamborghini", 2077);
            cars.Add(Lamborghini);
            var Corvette = new ElectricCar(25, "Corvette", 2027);
            cars.Add(Corvette);
            var Audi = new ElectricCar(42, "Audi", 2021);
            cars.Add(Audi);
            var kia = new ElectricCar(35, "Kia", 2019);
            cars.Add(kia);

            var stopwatch = Stopwatch.StartNew();

            await ElectricCar.ChargeAllCars(cars);
            Console.WriteLine("________________________________");
            stopwatch.Stop();
            Console.WriteLine($"Total time elapsed: {stopwatch.Elapsed.TotalSeconds} seconds");

        }
    }
}
