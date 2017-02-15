using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Application
{
    class CDs
    {
        public List<CD> cds;
        public CDs()
        {
            cds = new List<CD>();
        }
        public void AddCD(CD cd)
        {
            cds.Add(cd);
        }
        public void PrintData()
        {
            foreach (CD cd in cds)
            {
                Console.WriteLine("Album: " + cd.Album + ", Artist: " + cd.Artist + ", Cost: " + cd.Cost + ", Songs: " + cd.songs);
            }
        }
    }
}
