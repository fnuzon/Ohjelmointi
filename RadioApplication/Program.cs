using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio(false, 2000, 0);
            int input, inpt;
            do
            {
                Console.WriteLine("1. Turn radio on or off");
                Console.WriteLine("2. Change volume");
                Console.WriteLine("3. Change frequency");
                Console.WriteLine("4. To print data");
                Console.WriteLine("0. To end the loop");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    radio.Power();
                    Console.WriteLine("Radio state has been changed to: " + radio.IsOn);
                }
                if (input == 2)
                {
                    Console.WriteLine("Give a new volume(0 - 9):");
                    inpt = int.Parse(Console.ReadLine());
                    radio.Volume = inpt;
                }
                if (input == 3)
                {
                    Console.WriteLine("Give a new frequency(2000.0 - 26000.0):");
                    inpt = int.Parse(Console.ReadLine());
                    radio.Freq = inpt;
                }       
                if (input == 4)
                {
                    radio.PrintData();
                }         
            }
            while (input != 0);
        }
    }
}
