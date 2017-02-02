using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            int input;
            do
            {
                Console.WriteLine("Give a new floor number (1-5): ");
                input = int.Parse(Console.ReadLine());
                elevator.Floor = input;
            }
            while (input != 0);
        }
    }
}
