using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12_02
{
    public abstract class Vehicle
    {

        public abstract void TransportCategory();
    
        public abstract void GetInfo();
        public abstract void Create();
        public virtual void GetEnergyType()
        {
            Console.WriteLine("Energy type - other");
        }
        public abstract void GetVehicleModel();
    }
}
