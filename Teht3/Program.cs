using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3;
            Console.Write("Anna ensimmäinen luku > ");
            luku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna toinen luku > ");
            luku2 = int.Parse(Console.ReadLine());

            Console.Write("Anna kolmas luku > ");
            luku3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lukujen summa:" + (luku1 + luku2 + luku3));
            Console.WriteLine("lukujen keskiarvo:"+ (luku1 + luku2 + luku3) / 3);
        }
    }
}
