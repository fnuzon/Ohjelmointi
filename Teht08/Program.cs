using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
            /// 
            int n1, n2, n3;

            Console.WriteLine("Give first integer: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give second integer: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give third integer: ");
            n3 = int.Parse(Console.ReadLine());

            if (n1 >= n2 && n1 >= n3)
            {
                Console.WriteLine("The largest integer is: " + n1);
            }

            if (n2 >= n1 && n2 >= n3)
            {
                Console.WriteLine("The largest integer is: " + n2);
            }

            if (n3 >= n1 && n3 >= n2)
            {
                Console.WriteLine("The largest integer is: " + n3);
            }
            Console.ReadLine();
        }
    }
}
