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

            vc.AddMotorcycle();
            vc.AddLKW();
            vc.AddPKW();
            vc.ListVehicles();
           Console.ReadLine();
        }
    }
}
