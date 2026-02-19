using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyomozo
{
    internal class IdővonalEseményKezelő
    {
        private List<IdővonalEsemény> esemenyek;

        public IdővonalEseményKezelő()
        {
            esemenyek = new List<IdővonalEsemény>();
        }

        internal List<IdővonalEsemény> Esemenyek { get => esemenyek; set => esemenyek = value; }


        public void kiiratIdoSzerint()
        {
            if (esemenyek.Count == 0 || esemenyek == null)
            {
                Console.WriteLine("Nincs esemény.");
            }

            var rendezettEsemenyek = esemenyek
                .OrderBy(e => e.Ev)
                .ThenBy(e => e.Honap)
                .ThenBy(e => e.Nap);
                

            foreach (var esemeny in rendezettEsemenyek)
            {
                Console.WriteLine($"\n{esemeny.Ev}/{esemeny.Honap}/{esemeny.Nap} - {esemeny.EsemenyLeiras}");
            }
        }
    }
}
