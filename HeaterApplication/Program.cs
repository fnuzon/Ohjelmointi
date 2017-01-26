using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Tehtävänäsi on ohjelmoida kiukaan toiminta. Kiuas pitää pystyä laittamaan päälle ja pois, 
            /// sekä sen lämpötilaa että sen antamaa kosteutta pitää pystyä säätämään (arvoja ei ole rajattu).
            ///  create one instance of heater class
            ///  testing...
            Heater heater = new Heater("Harvia 9000", 55, 80.7, false);
            int input;
            Console.WriteLine("1. Switch state of heater");
            Console.WriteLine("2. Change temperature");
            Console.WriteLine("3. Change humidity");
            Console.WriteLine("Use 0 to end the loop");
            Console.WriteLine("What do you want to do? ");
            input = int.Parse(Console.ReadLine());
            while (input != 0)
            {
                Console.WriteLine("1. Switch state of heater");
                Console.WriteLine("2. Change temperature");
                Console.WriteLine("3. Change humidity");
                Console.WriteLine("Use 0 to end the loop");
                switch (input)
                {
                    case 1: heater.Power();
                        break;
                    case 2: heater.TempChange();
                        break;
                    case 3: heater.HumChange();
                        break;
                }
            }
        }
    }
}
