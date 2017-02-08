using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeBoatApplication
{
    class Bike : Vehicle
    {
        public bool gearwheels { get; set; }
        public string gear { get; set; }

        public Bike()           
        {

        }
        public Bike(string Name, string Model, int Year, string Color)
            :base(Name,Model,Year,Color)
        {
            name = Name;
            model = Model;
            year = Year;
            color = Color;
        }
        public Bike(string Name, string Model, int Year, string Color, bool GearWheels, string Gear)
            : base(Name, Model, Year, Color)
        {
            name = Name;
            model = Model;
            year = Year;
            color = Color;
            gearwheels = GearWheels;
            gear = Gear;
        }
    }
}
