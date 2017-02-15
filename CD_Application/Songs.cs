using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Application
{
    class Songs : Song
    {        
        public Songs()
        {

        }
        public Songs(string Name, string Length)
            :base(Name, Length)         
        {
            name = Name;
            lenght = Length;
        }
    }
}
