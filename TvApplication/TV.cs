using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvApplication
{
    class TV
    {
        public string Model { get; set; }        
        public int Channel { get; set; }
        public int Bright { get; set; }
        public bool Guide { get; set; }
        public bool IsOn { get; set; }

        public TV (string model)
        {
            Model = model;
        }
        public void Power()
        {
            if (IsOn == true)
            {
                IsOn = false;
            }
            else IsOn = true;
        }
        public void GuideState()
        {
            if (Guide == true)
            {
                Guide = false;
            }
            else Guide = true;
        }
        public void PrintData()
        {
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Power: " + IsOn);
            Console.WriteLine("Channel: " + Channel);
            Console.WriteLine("TV guide state: " + Guide);
            Console.WriteLine("Brightness: " + Bright);
        }
    }
}
