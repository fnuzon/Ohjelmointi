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
            bool value;
            Console.WriteLine("State of heater?: ");
            value = bool.Parse(Console.ReadLine());
            if (value == false)
            {
                IsOn = false;
            }
            if (value == true)
            {
                IsOn = true;
            }
            Console.WriteLine("State of the heater: " + IsOn);
        }
        public void TempChange()
        {
            int value;
            Console.WriteLine("Give temperature: " );
            value = int.Parse(Console.ReadLine());
            Temp = value;
            Console.WriteLine(Temp);
        }
        public void HumChange()
        {
            double value;
            Console.WriteLine("Give Humidity: ");
            value = int.Parse(Console.ReadLine());
            Humidity = value;
            Console.WriteLine(Humidity);
        }
    }
}
