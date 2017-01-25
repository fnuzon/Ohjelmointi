using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht14
{

    class Program
    {
        /// Aliohjelmassa käydään listan alkiot läpi ja tulostetaan niiden tilalle "*"
        static void print(List<int> table)
        {
            foreach (int i in table)
            {
                Console.Write("*");
            }
        }
        static void Main(string[] args)
        {
            /// Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5 ohjelmointi-opintojaksosta (voit itse päättää lopetusehdon)
            /// 
                  
        
            int grade;
            List<int> iTable1 = new List<int>();
            List<int> iTable2 = new List<int>();
            List<int> iTable3 = new List<int>();
            List<int> iTable4 = new List<int>();
            List<int> iTable5 = new List<int>();
            List<int> iTable6 = new List<int>();
            Console.WriteLine("Give a grade: ");
            grade = int.Parse(Console.ReadLine());
            /// arvolla 999 lopetetaan loop
            while (grade != 999)
            {

                if (grade == 1)
                {
                    iTable1.Add(grade);
                }
                if (grade == 2)
                {
                    iTable2.Add(grade);
                }
                if (grade == 3)
                {
                    iTable3.Add(grade);
                }
                if (grade == 4)
                {
                    iTable4.Add(grade);
                }
                if (grade == 5)
                {
                    iTable5.Add(grade);
                }
                if (grade == 0)
                {
                    iTable6.Add(grade);
                }
                
                Console.WriteLine("Give a new grade: ");
                grade = int.Parse(Console.ReadLine());
            }

            

            Console.Write("0: "); print(iTable6); Console.Write("\n");
            Console.Write("1: ");print(iTable1); Console.Write("\n");
            Console.Write("2: "); print(iTable2); Console.Write("\n");
            Console.Write("3: "); print(iTable3); Console.Write("\n");
            Console.Write("4: "); print(iTable4); Console.Write("\n");
            Console.Write("5: "); print(iTable5); Console.Write("\n");

        }
    }
}
