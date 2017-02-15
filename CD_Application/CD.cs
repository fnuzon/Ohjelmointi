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
        public string Album { get; set; }
        public List<Song> songs;
        private string albm;
        private string art;
        private int cst;
        private List<Songs> sONGS;

        public CD(string album, string artist, int cost, List<Song>SONGS)
        {
            Album = album;
            Artist = artist;            
            Cost = cost;
            songs = SONGS;
        }

        public CD(string albm, string art, int cst, List<Songs> sONGS)
        {
            this.albm = albm;
            this.art = art;
            this.cst = cst;
            this.sONGS = sONGS;
        }

        /*public override string ToString()
        {
            return "Album name: " + Album + ", Artist: " + Artist + ", Cost: " + Cost;
        }*/

        
    }
}
