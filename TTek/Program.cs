using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txtHandle

{
    class Program
    {
        static void Main(string[] args)
        {
            string text;            
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Niko\Desktop\test.txt");
            do
            {
                Console.Write("Give a text line (press enter to end) : ");
                text = Console.ReadLine();
                file.WriteLine(text);
            }
            while (text != ""); 
            file.Close();

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Niko\Desktop\test.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }                 
          
        }
    }
}
