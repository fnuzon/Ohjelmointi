using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public Vehicle()
        {

        }

        public void PrintData()
        {
            Console.WriteLine("Vehicle name: " + Name);
            Console.WriteLine("Vehicle speed: " + Speed);
            Console.WriteLine("Vehicle tyres: " + Tyres);
        }
        public override string ToString()
        {
            return "Vehicle name: " + Name + ", Vehicle speed: " + Speed + ", Vehicle tyres: " + Tyres;  
        }


    }
}
