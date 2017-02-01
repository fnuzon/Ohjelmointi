using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Washer washer = new Washer("Samsung", false, false, 0, true);
            int input;
            int value;
            do
            {                               
                Console.WriteLine("1. Change the state of washer");
                Console.WriteLine("2. Change the state of sling");
                Console.WriteLine("3. Change the water temperature(integer only)");
                Console.WriteLine("4. Is the washer empty or not?");
                Console.WriteLine("5. Print data");
                Console.WriteLine("Give your choice: ");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    washer.Power();
                    Console.WriteLine("State have been changed.");
                }
                if (input == 2)
                {
                    washer.Slinger();
                    Console.WriteLine("State have been changed.");
                }
                if (input == 3)
                {
                    Console.WriteLine("Give new temperature: ");
                    value = int.Parse(Console.ReadLine());
                    washer.WaterTemp = value;
                }
                if (input == 4)
                {
                    washer.EmptyC();
                    Console.WriteLine("State have been changed.");
                }
                if (input == 5)
                {
                    washer.PrintData();
                }
            }
            while (input != 0);
        }
    }
}
