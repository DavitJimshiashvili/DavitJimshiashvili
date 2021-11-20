using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12_02
{
    public abstract class PublicVehicle:Vehicle
    {
        public override void TransportCategory()
        {
            Console.WriteLine("Transport category - Public Transport");
        }
        public abstract void AddPassenger();
        public abstract void AddFuel();
    }
}
