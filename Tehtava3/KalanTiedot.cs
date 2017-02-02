/*
 * saadun kalan perustiedot(laji, pituus ja paino)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class KalanTiedot
    {
        public string Laji { get; set; }
        public double Pituus { get; set; }
        public double Paino { get; set; }
        public KalanTiedot() { }
        public KalanTiedot(string laji, double pituus, double paino)
        {
            Laji = laji;
            Pituus = pituus;
            Paino = paino;
        }
        public override string ToString()
        {
            return "Laji: " + Laji + Pituus + "cm " + Paino + "kg";
        }
    }
}
