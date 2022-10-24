using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekerObjektum
{
    class Vevo
    {
        public string nev;
        public string megye;
        public string email;

        public Vevo(string nev, string megye, string email)
        {
            this.nev = nev;
            this.megye = megye;
            this.email = email;
        }
    }

    class Program
    {
        List<Vevo> vevos = new List<Vevo>() {
            new Vevo("Nagy János", "Nógrád", "nagyj@gmail.com")
        };
        static void Main(string[] args)
        {
        }
    }
}
