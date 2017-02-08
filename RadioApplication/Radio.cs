using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Radio
    {
        private readonly double maxFreq = 26000.0;
        private readonly double minFreq = 2000.0;
        private readonly int maxVol = 9;
        private readonly int minVol = 0;
        private double freq;
        private int volume;
        public bool IsOn { get; set; }
        public double Freq
        {
            get
            {
                return freq;
            }
            set
            {
                if (value > maxFreq)
                {
                    Console.WriteLine("Frequency is too high! Frequency changed to 26000.0");
                    freq = maxFreq;
                    return;
                }
                if (value < minFreq)
                {
                    Console.WriteLine("Frequency is too small! Frequency changed to 2000.0");
                    freq = minFreq;
                    return;
                }
                else
                {
                    freq = value;
                    Console.WriteLine("Frequency changed to: " + freq);
                }

            }
        }
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value > maxVol)
                {                    
                    Console.WriteLine("Volume is too high! Volume changed to 9");
                    volume = minVol;
                    return;            
                }
                if (value < minVol)
                {
                    Console.WriteLine("Volume is too small! Volume changed to 0");
                    volume = maxVol;
                    return;
                }
                else
                {
                    volume = value;
                    Console.WriteLine("volume changed to: " + volume);
                }
            } 
        }

        public Radio()
        {

        }
        public Radio(bool ison, double freQ, int vol)
        {
            IsOn = ison;
            freq = freQ;
            volume = vol;
        }
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
            Console.WriteLine("Power: " + IsOn);
            Console.WriteLine("Volume: " + volume);
            Console.WriteLine("Frequency: " + freq);
        }
    }
}
