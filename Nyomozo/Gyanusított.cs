using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyomozo
{
    internal class Gyanusított : Személy
    {
        private int gyanusitottSzint;
        private string statusz;

        public Gyanusított(string nev, int eletkor, string megjegyzes, int gyanusitottSzint, string statusz)
            : base(nev, eletkor, megjegyzes)
        {
            this.gyanusitottSzint = gyanusitottSzint;
            this.statusz = statusz;
        }

        public int GyanusitottSzint { get => gyanusitottSzint; set => gyanusitottSzint = value; }
        public string Statusz { get => statusz; set => statusz = value; }
    }
}
