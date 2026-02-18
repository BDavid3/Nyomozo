using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Nyomozo
{
    internal class ÜgyekKezelő
    {
        List<Ügy> ugyekListaja;

        public ÜgyekKezelő()
        {
            ugyekListaja = new List<Ügy>();
        }

        internal List<Ügy> UgyekListaja { get => ugyekListaja; set => ugyekListaja = value; }

        public void hozzaad(Ügy ugy)
        {
            ugyekListaja.Add(ugy);
        }

        public void kiirat()
        {
            foreach (var ugy in ugyekListaja)
            {
                Console.WriteLine($"{ugy}\n");
            }
        }
        public void ugySzemelyHozzaad(string azonosit,Személy ujSzemely)
        {
            foreach (var ugy in ugyekListaja)
            {
                if (azonosit == ugy.ÜgyAzonosító)
                {
                    ugy.SzemelyekListaja.Add(ujSzemely);
                }
            }
        }
        public void ugyBizonyitekHozzaad(string azonosit, Bizonyíték ujBizonyitek)
        {
            foreach (var ugy in ugyekListaja)
            {
                if (azonosit == ugy.ÜgyAzonosító)
                {
                    ugy.BizonyitekokListaja.Add(ujBizonyitek);
                }
            }
        }

        /*public void kiiratSorszammal(string ugyid, Ügy azugy)
        {
            foreach (var ugy in ugyekListaja)
            {
                if (ugyid == ugy.ÜgyAzonosító)
                {
                    Console.WriteLine($"1. Cím: {ugy.Cim}");
                    Console.WriteLine($"2. Leiras: {ugy.Leiras}");
                    Console.WriteLine($"3. Állapot: {ugy.Allapot}");
                }
            }
            Console.WriteLine("\n Szám: ");
            int beker = Convert.ToInt32(Console.ReadLine());

            switch (beker)
            {
                case 1:
                    Console.Write("\n Új cím: ");
                    string ujcim = Console.ReadLine();
                    azugy.Cim = ujcim;
                    break;
                case 2:
                    Console.Write("\n Új leírás: ");
                    string ujleiras = Console.ReadLine();
                    azugy.Leiras = ujleiras;
                    break;
                case 3:
                    Console.Write("\n Új állapot: ");
                    string ujallapot = Console.ReadLine();
                    azugy.Allapot = ujallapot;
                    break;
                default:
                    Console.WriteLine("\n Helytelen paraméter.");
                    break;
            }*/

    }
}
