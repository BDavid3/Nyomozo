using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyomozo
{
    internal class BizonyítékokKezelő
    {
        private List<Bizonyíték> bizonyitekok;

        public BizonyítékokKezelő()
        {
            bizonyitekok = new List<Bizonyíték>();
        }

        internal List<Bizonyíték> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }

        public void hozzaad(Bizonyíték bizonyitek)
        {
            bizonyitekok.Add(bizonyitek);
        }

        public void kiir()
        {
            if (bizonyitekok.Count == 0)
            {
                Console.WriteLine("Nincs rögzített bizonyítékS");
                return;
            }
            foreach (var bizonyitek in bizonyitekok)
            {
                Console.WriteLine($"{bizonyitek}\n");
            }
        }
    }
}
