using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.
            /// 
            int year;
            Console.WriteLine("Enter the year: ");
            year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " is a Leap Year");

            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year");
            }
            Console.ReadLine();
        }
    }
}
