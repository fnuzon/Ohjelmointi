using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeBoatApplication
{
    class Boat : Vehicle
    {
        public int seatcount { get; set; }
        public string boatType { get; set; }

        public Boat()
        {

        }
        public Boat(string Name, string Model, int Year, string Color)
            :base(Name,Model,Year,Color)
        {
            name = Name;
            model = Model;
            year = Year;
            color = Color;
        }
        public Boat(string Name, string Model, int Year, string Color, int Seatcount, string BoatType)
            : base(Name, Model, Year, Color)
        {
            name = Name;
            model = Model;
            year = Year;
            color = Color;
            seatcount = Seatcount;
            boatType = BoatType;
        }
    }
}
