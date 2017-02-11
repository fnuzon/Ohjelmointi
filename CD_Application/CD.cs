using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Application
{
    class CD
    {
        // Toteuta CD-luokka, joka sisältää CD:lle yleisesti kuuluvia ominaisuuksia: artisti, hinta ja biisit (ei saa olla rajattu eli käytä apuna jotain tietorakennetta).
        public string Artist { get; set; }
        public int Cost { get; set; }
        public List<Song> Songs;
    }
}
