using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Give a number > ");
            string line = Console.ReadLine();
            bool result = Int32.TryParse(line, out number);
            if (result == true)
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Yksi");
                        break;
                    case 2:
                        Console.WriteLine("Kaksi");
                        break;
                    case 3:
                        Console.WriteLine("Kolme");
                        break;
                    default:
                        Console.WriteLine("Joku muu luku");
                        break;
                }
            } else
            {
                Console.WriteLine("Not a integer value!");
            }
           
           
            Console.ReadLine();
        }
    }
}
