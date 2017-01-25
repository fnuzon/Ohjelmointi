using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht16
{
    class Program
    {
        static void compare(int g, int a)
        {
            if (g < a)
            {
                Console.WriteLine("Value is bigger!");
            }
            if (g > a)
            {
                Console.WriteLine("Value is smaller!");
            }
            
        }
        static void Main(string[] args)
        {
            /// Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku. 
            /// Ohjelman tulee antaa vihje arvauksen jälkeen onko arvottu luku pienemäi vai suurempi. 
            /// Tämän jälkeen vihjeitä toistetaan kunnes käyttäjä arvaa oikean luvun. Tulosta lopuksi arvausten määrä näytölle.

            Random rnd = new Random();
            int answer = rnd.Next(0, 100);
            int guess;
            int count = 1;

            Console.WriteLine("Guess a number!: ");
            guess = int.Parse(Console.ReadLine());
            compare(guess, answer);
            while (guess != answer)
            {               
                Console.WriteLine("Guess a number!: ");
                guess = int.Parse(Console.ReadLine());
                compare(guess, answer);
                count++;
            }
            Console.WriteLine("You have guessed the right number!!! It took you " + count + " tries");
        }
    }
}
