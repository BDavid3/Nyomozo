using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyomozo
{
    internal class SzemélyekKezelő
    {
        private static List<Személy> szemelyekListaja;

        public SzemélyekKezelő()
        {
            szemelyekListaja = new List<Személy>();
        } 

        internal List<Személy> SzemelyekListaja { get => szemelyekListaja; set => szemelyekListaja = value; }

        public void hozzaad(Személy szemely)
        {
            szemelyekListaja.Add(szemely);
        }

        public void kiir()
        {
            if (szemelyekListaja.Count == 0)
            {
                Console.WriteLine("Nincs rögzített személy");
                return;
            }
            foreach (var szemely in szemelyekListaja)
            {
                Console.WriteLine($"{szemely}\n");
            }
        }
    }
}
