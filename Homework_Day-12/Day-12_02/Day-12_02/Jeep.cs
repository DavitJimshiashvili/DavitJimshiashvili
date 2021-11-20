using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12_02
{
    public class Jeep : PassengerVehicle
    {
        const double MaxFuelCapcity = 80;
        const int EnginePower = 375;
        const int MaximumRoadSpeed = 180;
        const string JeepModel = "Jeep Wrangler";
        const string CountryOfOrigin = "America";
        private readonly string _energyType = "Diesel";
        private double _fuelVolume;
        private int _passengerCount;

        public override void Create()
        {
            TransportCategory();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("{0} is getting ready for testdrive ", JeepModel);
            AddPassenger();
            AddFuel();
            Console.WriteLine("--------------------------------");
        }


        public int Passenger
        {
            get { return _passengerCount; }
            set
            {
                if (value > 0 && value < 5)
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
            Console.Write("Fill fuel reservoir (Max volume {0}L) : ", MaxFuelCapcity);
            Fuel = double.Parse(Console.ReadLine());
        }

        public override void AddPassenger()
        {
            Console.Write("Enter Passenger count in range (0 ... 4): ");
            Passenger = int.Parse(Console.ReadLine());
        }

        public override void GetEnergyType()
        {
            Console.Write("*Energy type: {0}", _energyType);
        }

        public override void GetInfo()
        {
            Console.WriteLine("Vehicle info: ...");
            Console.WriteLine("*Model: {0}", JeepModel);
            Console.WriteLine("*Country of origin: {0}", CountryOfOrigin);
            Console.WriteLine("*Passenger: {0}", Passenger);
            Console.WriteLine("*Engine power: {0}HP", EnginePower);
            Console.WriteLine("*Maximum speed: {0}KM\\H", MaximumRoadSpeed);
            GetEnergyType();
            Console.WriteLine("\n*Fuel in reservoir : {0}L - {1}%", Fuel, FuelInReservoir());
        }

        public override void GetVehicleModel()
        {
            Console.WriteLine("*Model: {0}", JeepModel);

        }

    }
}
