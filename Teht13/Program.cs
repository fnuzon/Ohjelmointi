using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht13
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Mäkihypyssä käytetään viittä arvostelutuomaria. 
            /// Kirjoita ohjelma, joka kysyy arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten, että summasta on vähennetty pois pienin ja suurin tyylipiste.
            /// 
            int[] iTable = new int[5];
            for (int i = 0; i < iTable.Length; i++)
            {
                Console.WriteLine("Give your points ");
                iTable[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(iTable);

            Console.WriteLine("Overrall score is: " + (iTable[1] + iTable[2] + iTable[3]));

        }
    }
}
