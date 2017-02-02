using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmplifierApplication
{
    class Amplifier
    {
        private int maxVol = 100;
        private int minVol = 0;
        private int volume;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value < minVol)
                {
                    Console.WriteLine("Too low volume - Amplifier volume is set to minimum: 0");
                    volume = minVol;
                }
                if (value > maxVol)
                {
                    Console.WriteLine("Too much volume -  Amplifier volume is set to maximum : 100");
                    volume = maxVol;
                }
                else
                {
                    volume = value;
                    Console.WriteLine("Amplifier volume is set to: " + volume);
                }
            }
        }
    }
}
