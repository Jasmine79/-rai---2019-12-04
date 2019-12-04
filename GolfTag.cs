using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf
{
    class GolfTag
    {
        int kod;
        string nev;
        DateTime szuletett;
        int magassag;

        public int Kod { get => kod; set => kod = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Szuletett { get => szuletett; set => szuletett = value; }
        public int Magassag { get => magassag; set => magassag = value; }

        public GolfTag(int kod, string nev, DateTime szuletett, int magassag)
        {
            Kod = kod;
            Nev = nev;
            Szuletett = szuletett;
            Magassag = magassag;
        }
        
    }
}
