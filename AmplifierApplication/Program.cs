using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmplifierApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            int input;
            do
            {
                Console.WriteLine("Give a new volume value (0-100)");
                input = int.Parse(Console.ReadLine());
                amp.Volume = input;
            }
            while (input != 0);
        }
    }
}
