using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplication
{
    class Heater
    {
        /// properties
        public string Model { get; set; }
        public int Temp { get; set; }
        public double Humidity { get; set; }
        public bool IsOn { get; set; }
        /// constructors
        public Heater(string model, int temp, double hum, bool ison)
        {
            Model = model;
            Temp = temp;
            Humidity = hum;
            IsOn = ison;
        }

        /// methods
        public void Power()
        {
            if (IsOn == true)
            {
                IsOn = false;
            }
            else IsOn = true;
        }

        public void PrintData()
        {
            Console.WriteLine("Model: " + Model);            
            Console.WriteLine("Temperature: " + Temp);
            Console.WriteLine("Humidity: " + Humidity);
            Console.WriteLine("Power: " + IsOn);            
        }
    }
}
