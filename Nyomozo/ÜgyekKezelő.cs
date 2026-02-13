using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void ugyHozzaadLista(Ügy ugy)
        {
            ugyekListaja.Add(ugy);
        }

        public void ugyKiiratas()
        {
            foreach (var ugy in ugyekListaja)
            {
                Console.WriteLine(ugy);
            }
        }
    }
}
