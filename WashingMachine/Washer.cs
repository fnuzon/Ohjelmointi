using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine
{
    class Washer
    {
        public string Model { get; set; }
        public bool IsOn { get; set; }
        public bool Sling { get; set; }
        public int WaterTemp { get; set; }
        public bool Empty { get; set; }

        public Washer(string model, bool ison, bool sling, int watertemp, bool empty)
        {
            Model = model;
            IsOn = ison;
            Sling = sling;
            WaterTemp = watertemp;
            Empty = empty;
        }
         public void Power()
        {
            if (IsOn == true)
            {
                IsOn = false;
            }
            else IsOn = true;
        }
        public void Slinger()
        {
            if(Sling == true)
            {
                Sling = false;
            }
            else Sling = true;
        }
        public void EmptyC()
        {
            if (Empty == true)
            {
                Empty = false;
            }
            else Empty = true;
        }
        public void PrintData()
        {
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Power: " + IsOn);
            Console.WriteLine("Slinger: " + Sling);
            Console.WriteLine("Water temp: " + WaterTemp);
            Console.WriteLine("Empty: " + Empty);
        }
    }
}
