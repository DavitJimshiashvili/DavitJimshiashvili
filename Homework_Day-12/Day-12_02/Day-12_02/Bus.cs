using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12_02
{
    public class Bus:PublicVehicle

    {
       
        const double MaxFuelCapcity = 150;
        const int EnginePower = 360;
        const int MaximumRoadSpeed = 180;
        const int MaxPassengerCount = 90;
        const string BusModel = "MAN A22";
        const string CountryOfOrigin = "Germany";
        private readonly string _energyType = "Diesel";
        private double _fuelVolume=22.5;
        private int _passengerCount=10;


        public override void Create()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Model {0}", BusModel);
            Console.WriteLine("Passengers in bus: {0}", Passenger);
            Console.WriteLine("Fuel volume: {0}L", Fuel);
            AddPassenger();
            AddFuel();
            Console.WriteLine("--------------------------------");
        }
        public int Passenger
        {
            get { return _passengerCount; }
            set
            {
                if (value > 0 && value <= MaxPassengerCount)
                    _passengerCount = value;
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


        public override void AddFuel()
        {
            Console.Write("Fill fuel reservoir (Max volume {0}L) you can add {1}L: ", MaxFuelCapcity, MaxFuelCapcity-Fuel);
            Fuel += double.Parse(Console.ReadLine());
        }

        public override void AddPassenger()
        {
            Console.Write("Add passenger (Max {0}): you can add {1}: ", MaxPassengerCount, MaxPassengerCount - Passenger);
            Passenger += int.Parse(Console.ReadLine());
        }

        public override void GetEnergyType()
        {
            Console.Write("*Energy type: {0}", _energyType);
        }

        public override void GetInfo()
        {
            Console.WriteLine("Vehicle info: ...");
            Console.WriteLine("*Model: {0}", BusModel);
            Console.WriteLine("*Country of origin: {0}", CountryOfOrigin);
            Console.WriteLine("*Passenger: {0}", Passenger);
            Console.WriteLine("*Engine power: {0}HP", EnginePower);
            Console.WriteLine("*Maximum speed: {0}KM\\H", MaximumRoadSpeed);
            GetEnergyType();
            Console.WriteLine("\n*Fuel in reservoir : {0}L - {1}%", Fuel, FuelInReservoir());
        }

        public override void GetVehicleModel()
        {
            Console.WriteLine("Model: {0}", BusModel);

        }
    }
}
