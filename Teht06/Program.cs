using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. 
            /// Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.
            double gasPrice = 1.595; // Per litre
            double consumption = 0.0702; // Per km used gas
            int distance;
            Console.Write("Give distance: ");
            distance = int.Parse(Console.ReadLine());
            double total = distance * consumption;
            if (distance > 0)
            {
                Console.WriteLine("Gas consumed: " + total +" Litre," + " Cost: " + (total * gasPrice)+ " euros");
            }
            
        }
    }
}
