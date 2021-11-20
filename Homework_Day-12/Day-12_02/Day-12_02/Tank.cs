using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12_02
{
    public class Tank : CombatVehicle
    {
        const double MaxFuelCapcity = 1100;
        const int EnginePower = 1500;
        const int MaximumSpeed = 72;
        const string TankModel = "Leopard 2A7 MBT";
        const string CountryOfOrigin = "Germany";
        private readonly string _energyType = "diesel";
        private double _fuelVolume;
        private int _soldierCount;



        public override void Create()
        {
            TransportCategory();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("your {0} is getting ready for testdrive ", TankModel);
            AddCrew();
            AddFuel();
            Console.WriteLine("--------------------------------");
        }

        public int Crew
        {
            get { return _soldierCount; }
            set
            {
                if (value > 2 && value < 7)
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
            Console.WriteLine("Tank info: ...");
            Console.WriteLine("*Model: {0}", TankModel);
            Console.WriteLine("*Country of origin: {0}", CountryOfOrigin);
            Console.WriteLine("*Crew: {0}", Crew);
            Console.WriteLine("*Engine power: {0}HP", EnginePower);
            Console.WriteLine("*Maximum speed: {0}KM\\H", MaximumSpeed);
            GetEnergyType();
            Console.WriteLine("\n*Fuel in reservoir : {0}L - {1}%", Fuel, FuelInReservoir());
        }
        public override void GetEnergyType()
        {
            Console.Write("*Energy type: {0}", _energyType);
        }

        public override void AddCrew()
        {
            Console.Write("Enter soldier count in range (3 ... 6): ");
            Crew = int.Parse(Console.ReadLine());
        }
        public override void AddFuel()
        {
            Console.Write("Fill fuel reservoir (Max volume 1100L) : ");
            Fuel = double.Parse(Console.ReadLine());
        }
        public override void GetVehicleModel()
        {
            Console.WriteLine("*Model: {0}", TankModel);

        }
    }
}
