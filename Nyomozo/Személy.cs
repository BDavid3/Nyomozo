using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Nyomozo
{
    internal class Személy
    {
        private string nev;
        private int eletkor;
        private string megjegyzes;

        public Személy(string nev, int eletkor, string megjegyzes)
        {
            this.nev = nev;
            this.eletkor = eletkor;
            this.megjegyzes = megjegyzes;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Eletkor { get => eletkor; set => eletkor = value; }
        public string Megjegyzes { get => megjegyzes; set => megjegyzes = value; }

        public static void szemelyKezelese()
        {
            int szamInput;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Személyek kezelését választotta!\n");
            Console.ResetColor();

            do
            {
                Console.WriteLine("1. Személy létrehozása");
                Console.WriteLine("2. Személy hozzáadása egy ügyhöz");
                Console.WriteLine("3. Kilépés\n");
                Console.Write("Szám: ");

                szamInput = Convert.ToInt32(Console.ReadLine());

                switch (szamInput)
                {
                    case 1:
                        szemelyLetrehozasa();
                        break;
                    case 2:

                        break;
                    case 3:
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
            while (szamInput != 3);
        }
        public static void szemelyLetrehozasa()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Személy létrehozását választotta!\n");
            Console.ResetColor();
            Console.Write("Név: ");
            string nev = Console.ReadLine();
            Console.Write("Életkor: ");
            int eletkor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Megjegyzés: ");
            string megjegyzes = Console.ReadLine();

            Személy ujSzemely = new Személy(nev,eletkor,megjegyzes);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nNyomj meg egy gombot a visszatéréshez...");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        public void szemelyUgy()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Személy hozzáadása egy ügyhöz!\n");
            Console.ResetColor();
            Console.WriteLine("Jelenlévő ügyek, és azonosítójuk: \n");
        }
    }
}
