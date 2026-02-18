using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Nyomozo
{
    internal class Ügy
    {
        private string ügyAzonosító;
        private string cim;
        private string leiras;
        private string allapot;
        private List<Személy> szemelyekListaja;
        private List<Bizonyíték> bizonyitekokListaja;

        public Ügy(string ügyAzonosító, string cim, string leiras, string allapot)
        {
            this.ügyAzonosító = ügyAzonosító;
            this.cim = cim;
            this.leiras = leiras;
            this.allapot = allapot;
            List<string> szemelyekListaja = new List<string>();
            List<string> bizonyitekokListaja = new List<string>();
        }

        public string ÜgyAzonosító { get => ügyAzonosító; set => ügyAzonosító = value; }
        public string Cim { get => cim; set => cim = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public string Allapot { get => allapot; set => allapot = value; }
        public List<Személy> SzemelyekListaja { get => szemelyekListaja; set => szemelyekListaja = value; }
        public List<Bizonyíték> BizonyitekokListaja { get => bizonyitekokListaja; set => bizonyitekokListaja = value; }

    }   
    
}

