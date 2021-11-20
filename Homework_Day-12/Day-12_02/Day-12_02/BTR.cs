using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12_02
{
    public class BTR : CombatVehicle
    {
        const double MaxFuelCapcity = 320;
        const int EnginePower = 260;
        const int MaximumRoadSpeed = 90;
        const string BTRModel = "BTR-80";
        const string CountryOfOrigin = "Russia";
        private readonly string _energyType = "diesel";
        private double _fuelVolume;
        private int _soldierCount;


        public override void Create()
        {

            TransportCategory();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("your {0} is getting ready for testdrive ", BTRModel);
            AddCrew();
            AddFuel();
            Console.WriteLine("--------------------------------");
        }
        public int Crew
        {
            get { return _soldierCount; }
            set
            {
                if (value > 5 && value < 13)
                    _soldierCount = value;
            }
        }


        public double Fuel
        {
            get { return _fuelVolume; }
            set
            {
                if (value > 0 && value < MaxFuelCapcity)
                    _fuelVolume = value;
            }
        }

        public double FuelInReservoir()
        {
            return Fuel / MaxFuelCapcity * 100;
        }
      
        public override void GetInfo()
        {
            Console.WriteLine("BTR info: ...");
            Console.WriteLine("*Model: {0}", BTRModel);
            Console.WriteLine("*Country of origin: {0}", CountryOfOrigin);
            Console.WriteLine("*Crew: {0}", Crew);
            Console.WriteLine("*Engine power: {0}HP", EnginePower);
            Console.WriteLine("*Maximum speed: {0}KM\\H", MaximumRoadSpeed);
            GetEnergyType();
            Console.WriteLine("\n*Fuel in reservoir : {0}L - {1}%", Fuel, FuelInReservoir());
        }

        public override void GetVehicleModel()
        {
            Console.WriteLine("*Model: {0}", BTRModel);
        }
        public override void GetEnergyType()
        {
            Console.Write("*Energy type: {0}", _energyType);
        }

        public override void AddCrew()
        {
            Console.Write("Enter soldier count in range (6 ... 12): ");
            Crew = int.Parse(Console.ReadLine());
        }
        public override void AddFuel()
        {
            Console.Write("Fill fuel reservoir (Max volume {0}L) : ", MaxFuelCapcity);
            Fuel = double.Parse(Console.ReadLine());
        }
    }
}
