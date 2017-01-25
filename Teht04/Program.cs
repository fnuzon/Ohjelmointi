using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            float age;

            Console.Write("Give age: ");
            age = float.Parse(Console.ReadLine());
            
                if (age < 18)
                {
                    Console.WriteLine(" Alaikainen ");
                }

                else if (age >= 18 && age <= 65)
                {
                    Console.WriteLine(" Aikuinen ");
                }
                
                else 
                {
                    Console.WriteLine(" Seniori ");
                }               
                           
            }
            
                
            
        }
    }

