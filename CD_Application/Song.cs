using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Application
{
    class Song
    {
        // Biisien kannalta kannattaa toteuttaa Biisi-luokka, jossa on käytössä yleisesti biisille kuuluvia ominaisuuksia: nimi ja pituus.
        public string name { get; set; }
        public string lenght { get; set; }
        public override string ToString()
        {
            return name + " " + lenght + " ";
        }
        public Song()
        {

        }
        public Song(string Name, string Lenght)
        {
            name = Name;
            lenght = Lenght;
        }
    }
}
