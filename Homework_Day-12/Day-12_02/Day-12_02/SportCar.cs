using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12_02
{
    public class SportCar : SportVehicle
    {
        const double MaxFuelCapcity = 75;
        const double MaxEnginePower = 470;
        const string ChevroletModel = "Chevrolet Corvette Z06";
        const string CountryOfOrigin = "America";
        private readonly string _energyType = "Gasoline";
        private double _fuelVolume = 25;
        private double _enginePower = 390;
        private double _roadSpeed = 280;

        public override void Create()
        {
            TransportCategory();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Model {0}", ChevroletModel);
            Console.WriteLine("Actual engine power: {0}HP", HP);
            Console.WriteLine("Actual speed limit {0}kM/H", _roadSpeed);
            Console.WriteLine("Fuel in reservoir: {0}L", Fuel);
            EnhancePower();
            ChangeMaxSpeed();
            AddFuel();
            Console.WriteLine("--------------------------------");
        }


        public double HP
        {

            get { return _enginePower; }
            set
            {
                if (value > 0 && value < MaxEnginePower)
                    _enginePower = value;
            }
        }
        public override void EnhancePower()
        {
            Console.Write("Enhance engine power (Max engine power {0}) you can add {1}HP: ", MaxEnginePower, MaxEnginePower - HP);
            HP += int.Parse(Console.ReadLine());
        }

        public void ChangeMaxSpeed()
        {
            _roadSpeed *= (MaxEnginePower / HP);
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
            Console.Write("Fill fuel reservoir (Max volume {0}L) you can add {1}L: ", MaxFuelCapcity, MaxFuelCapcity - Fuel);
            Fuel += double.Parse(Console.ReadLine());
        }


        public override void GetEnergyType()
        {
            Console.Write("*Energy type: {0}", _energyType);
        }

        public override void GetInfo()
        {
            Console.WriteLine("Vehicle info: ...");
            Console.WriteLine("*Model: {0}", ChevroletModel);
            Console.WriteLine("*Country of origin: {0}", CountryOfOrigin);
            Console.WriteLine("*Engine power: {0}HP", _enginePower);
            Console.WriteLine("*Maximum speed: {0}KM\\H", _roadSpeed);
            GetEnergyType();
            Console.WriteLine("\n*Fuel in reservoir : {0}L - {1}%", Fuel, FuelInReservoir());
        }
        public override void GetVehicleModel()
        {
            Console.WriteLine("*Model: {0}", ChevroletModel);

        }
    }
}
