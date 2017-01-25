using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht11
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion:
            /// *
            /// **
            /// ***
            /// ****
            /// *****
            int k;
            Console.WriteLine("Give a number of stars to print: ");
            k = int.Parse(Console.ReadLine());
                                   
                for (int i = 0; i <= k; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            
            }
            
        }
    }

