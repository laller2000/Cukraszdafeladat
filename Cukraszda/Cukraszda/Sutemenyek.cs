using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cukraszda
{
    class Sutemenyek
    {
        private string nev;
        private int ar;

        public string Nev { get => nev; set => nev = value; }
        public int Ar { get => ar; set => ar = value; }

        public Sutemenyek(string nev, int ar)
        {
            Nev = nev;
            Ar = ar;
        }
        public Sutemenyek(string sor)
        {
            string[] adatok = sor.Split(';');
            Nev = adatok[0];
            Ar = Convert.ToInt32(adatok[1]);
        }

        public override string ToString()
        {
            return string.Format(Nev + (Ar+"Ft"));
        }
    }
}
