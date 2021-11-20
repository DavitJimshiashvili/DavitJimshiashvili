using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12_02
{
    public abstract class CombatVehicle : Vehicle
    {

        public override void TransportCategory()
        {
            Console.WriteLine("Transport category - Combat Vehicle");
        }
        public abstract void AddCrew();
        public abstract void AddFuel();

    }
}
