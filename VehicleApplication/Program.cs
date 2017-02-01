using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            int input;
            string value;
            int value2;
            do
            {
                Console.WriteLine("1. Give name for the vehicle");
                Console.WriteLine("2. Change the speed");
                Console.WriteLine("3. Change the amount of tyres");
                Console.WriteLine("4. Print data");
                Console.WriteLine("5. Other option to print data");
                Console.WriteLine("Use 0 to end the loop");
                Console.WriteLine("Give your choice: ");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Give vehicle name:");
                    value = Console.ReadLine();
                    vehicle.Name = value;
                }
                if (input == 2)
                {
                    Console.WriteLine("Give vehicle speed:");
                    value2 = int.Parse(Console.ReadLine());
                    vehicle.Speed = value2;
                }
                if (input == 3)
                {
                    Console.WriteLine("Change the amount of tyres ");
                    value2 = int.Parse(Console.ReadLine());
                    vehicle.Tyres = value2;
                }
                if (input == 4)
                {
                    vehicle.PrintData();
                }
                if (input == 5)
                {
                    Console.WriteLine(vehicle);
                }
            }
            while (input != 0);
        }
    }
}
