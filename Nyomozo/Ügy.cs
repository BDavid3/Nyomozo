using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyomozo
{
    internal class Ügy
    {
        private string ügyAzonosító;
        private string cim;
        private string leiras;
        private string allapot;
        private List<string> szemelyekListaja;
        private List<string> bizonyitekokListaja;

        public Ügy(string ügyAzonosító, string cim, string leiras, string allapot, List<string> szemelyekListaja, List<string> bizonyitekokListaja)
        {
            this.ügyAzonosító = ügyAzonosító;
            this.cim = cim;
            this.leiras = leiras;
            this.allapot = allapot;
            this.szemelyekListaja = szemelyekListaja;
            this.bizonyitekokListaja = bizonyitekokListaja;
        }

        public string ÜgyAzonosító { get => ügyAzonosító; set => ügyAzonosító = value; }
        public string Cim { get => cim; set => cim = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public string Allapot { get => allapot; set => allapot = value; }
        public List<string> SzemelyekListaja { get => szemelyekListaja; set => szemelyekListaja = value; }
        public List<string> BizonyitekokListaja { get => bizonyitekokListaja; set => bizonyitekokListaja = value; }

        public static void ügyKezelese()
        {
            int szamInput;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ügyek kezelését választotta!\n");
            Console.ResetColor();

            do
            {
                Console.WriteLine("1. Ügy létrehozása");
                Console.WriteLine("2. Ügy módosítása");
                Console.WriteLine("3. Meglévő ügyek listázása");
                Console.WriteLine("4. Kilépés\n");
                Console.Write("Szám: ");

                szamInput = Convert.ToInt32(Console.ReadLine());

                switch (szamInput)
                {
                    case 1:
                        Console.Clear();

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Rossz értéket adtál meg!\n");
                        Console.ResetColor();
                        break;
                }
            }
            while (szamInput != 4);
            
        }
        public void ügyLetrehozasa()
        {
            
        }

    }   
    
}

