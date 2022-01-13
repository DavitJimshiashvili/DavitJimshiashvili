using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    public class ElectricCar
    {
        private int BatteryLevel { get; set; }
        private string Model { get; set; }
        private int Year { get; set; }

        public ElectricCar(int batteryLevel, string model, int year)
        {
            BatteryLevel = batteryLevel;
            Model = model;
            Year = year;
        }
        public void Charge()
        {
            Console.WriteLine($"{Model} has started charging, Battery Level - {BatteryLevel} ");
            Stopwatch sw = new Stopwatch();
            while (BatteryLevel != 100)
            {
                sw.Start();

                if (sw.Elapsed.Seconds == 10)
                {
                    if (BatteryLevel < 95)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        BatteryLevel += 5;
                        Console.WriteLine($"{Model}'s Battery level - {BatteryLevel}");
                        sw.Reset();
                    }
                    else
                    {
                        BatteryLevel = 100;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{Model} is fully charged - {BatteryLevel}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            sw.Stop();
        }
        public static async Task ChargeAllCars(IEnumerable<ElectricCar> cars)
        {
            List<Task> tasks = new List<Task>();

            foreach (var car in cars)
            {
                Task task = Task.Run(() => car.Charge());
                tasks.Add(task);
            }
            await Task.WhenAll(tasks.ToArray());

        }
    }
}

