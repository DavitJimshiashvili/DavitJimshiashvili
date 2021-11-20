using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12_02
{
    public abstract class SportVehicle : Vehicle
    {
        public override void TransportCategory()
        {
            Console.WriteLine("Transport category - Sport Car");
        }
        public abstract void AddFuel();
        public abstract void EnhancePower();

    }
}
