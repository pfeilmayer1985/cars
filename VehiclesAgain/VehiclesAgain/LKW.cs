using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesAgain
{
    public class LKW : VehicleClass
    {
        public LKW(string make, string model, int noWheels)
        {
            Make = make;
            Model = model;
            Type = "LKW";
            NoWheels = noWheels;
        }
    }
}
