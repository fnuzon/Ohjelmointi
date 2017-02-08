using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeBoatApplication
{
    class Vehicle
    {
        public string name { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string color { get; set; }
        
        public Vehicle()
        {

        }
        public Vehicle(string Name, string Model, int Year, string Color)
        {
            name = Name;
            model = Model;
            year = Year;
            color = Color;
        }
    }
}
