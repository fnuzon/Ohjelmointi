using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds;
            Console.Write("Give seconds:");
            seconds = int.Parse(Console.ReadLine());
            var timespan = TimeSpan.FromSeconds(seconds);
            Console.WriteLine(timespan.ToString(@"hh\:m\:ss"));
        }
    }
}
