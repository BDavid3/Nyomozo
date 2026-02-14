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
