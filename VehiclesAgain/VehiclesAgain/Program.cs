using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesAgain
{
    public class Program
    {

        static void Main(string[] args)
        {
            VehicleClass vc = new VehicleClass();
            bool doaslong = true;

            while (doaslong)
            {
                Console.Clear();
                Console.WriteLine("What do you want to add ?");
                Console.WriteLine("1. Motorcycle");
                Console.WriteLine("2. Car");
                Console.WriteLine("3. Truck");
                Console.WriteLine("4. List all your vehicles");
                Console.WriteLine("5. Exit");
                int userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Console.Clear();
                        vc.AddMotorcycle();
                        break;
                    case 2:
                        Console.Clear();
                        vc.AddPKW();
                        break;
                    case 3:
                        Console.Clear();
                        vc.AddLKW();
                        break;
                    case 4:
                        Console.Clear();
                        vc.ListVehicles();
                        Console.ReadLine();
                        break;
                    case 5:
                        doaslong = false;
                        break;

                }
            }



            //Console.ReadLine();
        }
    }
}
