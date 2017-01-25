using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht17
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot suurusjärjestykseen kolmanteen kokonaislukutaulukkoon. Tulosta lopuksi lajitellun taulukon sisältö.
            int[] iTable1 = {10, 20, 30, 40, 50};
            int[] iTable2 = {5, 15, 25, 35, 35};
            int[] Total = iTable1.Concat(iTable2).ToArray();
            
            Array.Sort(Total);
            Console.Write("Numbers from combined table: ");
            foreach (int i in Total)
            {
                Console.Write(i + ", ");
            }

        }
    }
}
