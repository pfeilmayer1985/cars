using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesAgain
{

    public class VehicleClass
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int NoWheels { get; set; }
        public List<VehicleClass> VehicleClasses { get; set; }

        public VehicleClass()
        {
            VehicleClasses = new List<VehicleClass>();

        }





        public void AddMotorcycle()
        {
            Console.Write("Your motorcycle make: ");
            string Make = Console.ReadLine();
            Console.Write("Your motorcycle model: ");
            string Model = Console.ReadLine();
            Console.Write("How many wheels does it have: ");
            int NoWeheels = Convert.ToInt32(Console.ReadLine());
            Motorcycle oneMotorcycle = new Motorcycle(Make, Model, NoWeheels);
            VehicleClasses.Add(oneMotorcycle);

        }

        public void AddPKW()
        {
            Console.Write("Your car make: ");
            string Make = Console.ReadLine();
            Console.Write("Your car model: ");
            string Model = Console.ReadLine();
            Console.Write("How many wheels does it have: ");
            int NoWeheels = Convert.ToInt32(Console.ReadLine());
            PKW onePKW = new PKW(Make, Model, NoWeheels);
            VehicleClasses.Add(onePKW);

        }

        public void AddLKW()
        {
            Console.Write("Your truck make: ");
            string Make = Console.ReadLine();
            Console.Write("Your truck model: ");
            string Model = Console.ReadLine();
            Console.Write("How many wheels does it have: ");
            int NoWeheels = Convert.ToInt32(Console.ReadLine());
            LKW oneLKW = new LKW(Make, Model, NoWeheels);
            VehicleClasses.Add(oneLKW);

        }

        public void ListVehicles()
        {
            foreach (VehicleClass vehicle in VehicleClasses)
            {
                Console.WriteLine($"You have a {vehicle.Type}, make {vehicle.Make} and model {vehicle.Model} with {vehicle.NoWheels} wheels in your list.");

            }
        }
    }
}
