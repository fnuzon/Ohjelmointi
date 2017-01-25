using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht12
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon. Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.
            /// 
            
            int[] iTable = new int[5];
            for (int i = 0; i < iTable.Length; i++)
            {
                Console.WriteLine("Give a integer: ");
                iTable[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(iTable);

            foreach (int value in iTable)
            {
                Console.WriteLine("_" + value);
            }
            Console.WriteLine();

        }
    }
}
