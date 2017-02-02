using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApplication
{
    class Elevator
    {
        private readonly int maxFloor = 5;
        private readonly int minFloor = 1;
        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value > maxFloor)
                {
                    Console.WriteLine("Floor is too big!");
                }
                if (value < minFloor)
                {
                    Console.WriteLine("Floor is too samll!");
                }
                else
                {
                    floor = value;
                    Console.WriteLine("Elevator is now in floor: " + floor);
                }
            }
        }
    }
}
