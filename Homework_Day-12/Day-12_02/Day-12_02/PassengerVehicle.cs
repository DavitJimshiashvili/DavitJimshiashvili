using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12_02
{
    public abstract class PassengerVehicle : Vehicle
    {
        public override void TransportCategory()
        {
            Console.WriteLine("Transport category - Passenger Vehicle");
        }
        public abstract void AddPassenger();
        public abstract void AddFuel();
    }
}
