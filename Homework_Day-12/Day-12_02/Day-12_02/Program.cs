using System;

namespace Day_12_02
{
    class Program
    {
        static void Main(string[] args)
        {

            CombatVehicle tank = new Tank();
            CombatVehicle btr = new BTR();
            PassengerVehicle sedan = new Sedan();
            PassengerVehicle jeep = new Jeep();
            SportVehicle sportcar = new SportCar();
            PublicVehicle bus = new Bus();
            Vehicle[] vehicle = new Vehicle[] { tank, btr, sedan, jeep, sportcar, bus };
            int condition = 0;
            while(condition==0)
            { 
            Console.WriteLine("***Menu:\nVehicle categories:\n1).*Combat(x2)\n2).*Passenger(x2)\n3).*Sport(x1)\n4).*Public transport(x1)");
            Console.Write("Chose one of them: ");
            int category = int.Parse(Console.ReadLine());
            switch (category)
            {
                case 1:
                    {
                        vehicle[0].TransportCategory();
                        vehicle[0].GetVehicleModel();
                        vehicle[1].GetVehicleModel();
                    }
                    break;
                case 2:
                    {
                        vehicle[2].TransportCategory();
                        vehicle[2].GetVehicleModel();
                        vehicle[3].GetVehicleModel();
                    }
                    break;
                case 3:
                    {
                        vehicle[4].TransportCategory();
                        vehicle[4].GetVehicleModel();
                    }
                    break;
                case 4:
                    {
                        vehicle[5].TransportCategory();
                        vehicle[5].GetVehicleModel();

                    }
                    break;

                default:
                    break;
            }
            Console.Write("Choose model: ");
            int subCategory = int.Parse(Console.ReadLine());
            int unique = 2 * category - subCategory;
            switch (unique)
            {
                case 0:
                    {
                        vehicle[1].Create();
                        vehicle[1].GetInfo();
                    }
                    break;
                case 1:
                    {
                        vehicle[0].Create();
                        vehicle[0].GetInfo();
                    }
                    break;
                case 2:
                    {
                        vehicle[3].Create();
                        vehicle[3].GetInfo();
                    }
                    break;
                case 3:
                    {
                        vehicle[2].Create();
                        vehicle[2].GetInfo();
                    }
                    break;
                case 5:
                    {
                        vehicle[4].Create();
                        vehicle[4].GetInfo();
                    }
                    break;
                case 7:
                    {
                        vehicle[5].Create();
                        vehicle[5].GetInfo();
                    }
                    break;

                default:
                    break;
            }
                Console.WriteLine("Do you want to exit? 1/0");
                condition = int.Parse(Console.ReadLine());

        }

            Console.ReadKey();

        }

     
    }
}
