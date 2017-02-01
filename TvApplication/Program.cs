using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV("Sony 42");
            int input;
            int value;
            do
            {
                Console.WriteLine("1. Turn tv on or off");
                Console.WriteLine("2. Change channel");
                Console.WriteLine("3. Change brightness");
                Console.WriteLine("4. turn tv guide on or off");
                Console.WriteLine("5. Print data");
                Console.WriteLine("Use 0 to end the loop");
                Console.WriteLine("Give your choice: ");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    tv.Power();
                    Console.WriteLine("State have been changed.");
                }
                if (input == 2)
                {                   
                    Console.WriteLine("Give new channel number:");
                    value = int.Parse(Console.ReadLine());
                    tv.Channel = value;
                }
                if (input == 3)
                {
                    Console.WriteLine("Change brightness: ");
                    value = int.Parse(Console.ReadLine());
                    tv.Bright = value;
                }
                if (input == 4)
                {
                    tv.GuideState();
                    Console.WriteLine("State have been changed.");
                }
                if (input == 5)
                {
                    tv.PrintData();
                }
            }
            while (input != 0);
        }
    }
}
