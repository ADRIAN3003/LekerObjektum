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
        static List<Vevo> vevos = new List<Vevo>() {
            new Vevo("Nagy János", "Nógrád", "nagyj@gmail.com"),
            new Vevo("Kiss Ildikó", "Budapest", "kiss@gmail.com"),
            new Vevo("Híves Elemér", "Nógrád", "hives@gmail.com"),
            new Vevo("Tuza Enikő", "Zala", "tuza@gmail.com"),
            new Vevo("Telek Tibor", "Nógrád", "telek@gmail.com"),
        };
        static void Main(string[] args)
        {
            var vevok = from vevo in vevos
                        group vevo by vevo.megye;

            foreach (var vevo in vevok)
            {
                Console.WriteLine(vevo.Key + $" ({vevo.Count()} db):");
                foreach (var item in vevo)
                {
                    Console.WriteLine("\t" + item.nev);
                }
            }

            Console.ReadKey();
        }
    }
}
