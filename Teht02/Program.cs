using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            int pistemaara;
          
            Console.Write("Anna pistemäärä > ");
            pistemaara = int.Parse(Console.ReadLine()); // "10" -> 10
            switch (pistemaara)
            {
                case 0:
                case 1: Console.WriteLine("Koulunumero on 0!");
                    break;
                case 2:
                case 3: Console.WriteLine("Koulunumero on 1!");
                    break;
                case 4:
                case 5: Console.WriteLine("Koulunumero on 2!");
                    break;
                case 6:
                case 7: Console.WriteLine("Koulunumero on 3!");
                    break;
                case 8:
                case 9: Console.WriteLine("Koulunumero on 4!");
                    break;
                case 10:
                case 11:
                case 12: Console.WriteLine("Koulunumero on 5!");
                    break;
                default: Console.WriteLine("Anna Pistemäärä 0-12");
                    break;
                
            }
            Console.ReadLine();

        }
    }
}
