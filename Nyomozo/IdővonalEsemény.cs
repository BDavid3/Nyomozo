using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyomozo
{
    internal class IdővonalEsemény
    {
        private int ev;
        private int honap;
        private int nap;
        private string esemenyLeiras;

        public IdővonalEsemény(int ev, int honap, int nap, string esemenyLeiras)
        {
            this.ev = ev;
            this.honap = honap;
            this.nap = nap;
            this.esemenyLeiras = esemenyLeiras;
        }

        public int Ev { get => ev; set => ev = value; }
        public int Honap { get => honap; set => honap = value; }
        public int Nap { get => nap; set => nap = value; }
        public string EsemenyLeiras { get => esemenyLeiras; set => esemenyLeiras = value; }
    }
}
