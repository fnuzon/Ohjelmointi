using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.
            /// 
            int number;
            int total = 0;        
            Console.WriteLine("Give a number: ");
            number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                total = total + number;
                Console.WriteLine("Give a new number: ");
                number = int.Parse(Console.ReadLine());                
            }
            Console.WriteLine("The sum of the figures: " + total);
        }
    }
}
