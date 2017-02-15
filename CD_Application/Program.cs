using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Songs> SONGS = new List<Songs>();
            CDs myCDs = new CDs();
            int input, cst;
            string albm, art, inpt,songn,songl;
            do
            {
                Console.WriteLine("1. To add new CD");
                Console.WriteLine("2. To see all CD's");
                Console.WriteLine("0. Ends the loop");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("Give Album name:");
                    albm = Console.ReadLine();
                    Console.WriteLine("Give Artist name:");
                    art = Console.ReadLine();
                    Console.WriteLine("Give cost:");
                    cst = int.Parse(Console.ReadLine());
                    Console.WriteLine("Do you want to add songs? (yes or no)");
                    inpt = Console.ReadLine();
                    if (inpt == "yes")
                    {
                        while (inpt != "0")
                        {
                            Console.WriteLine("1. To add new song");
                            Console.WriteLine("0. To exit");
                            inpt = Console.ReadLine();
                            if (inpt != "0")
                            {
                                Console.WriteLine("Give a song name, give 0 to exit the song loop");
                                songn = Console.ReadLine();
                                Console.WriteLine("Give a song lenght (ex. 4:45)");
                                songl = Console.ReadLine();
                                SONGS.Add(new Songs(songn, songl));                               
                            }
                                                        
                        }
                        
                    }                   
                    else Console.WriteLine("No songs added");
                    myCDs.AddCD(new CD(albm, art, cst, SONGS));

                }
                if (input == 2)
                {
                    Console.WriteLine("CDs:");
                    myCDs.PrintData();
                }
                
            }
            while (input != 0);
        }
    }
}
