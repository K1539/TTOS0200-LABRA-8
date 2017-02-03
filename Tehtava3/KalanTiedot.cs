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
    class KalanTiedot : KalapaikanTiedot
    {
        public string Laji { get; set; }
        public double Pituus { get; set; }
        public double Paino { get; set; }
        public KalanTiedot() { }
        public KalanTiedot(string laji, double pituus, double paino, string paikannimi, string sijainti)
        {
            Laji = laji;
            Pituus = pituus;
            Paino = paino;
            this.Paikannimi = paikannimi;
            this.Sijainti = sijainti;
        }
        public override string ToString()
        {
            return "-Laji: " + Laji + " " + Pituus + "cm " + Paino + "kg\n-Paikka: " + Paikannimi + "\n" + "-Sijainti: " + Sijainti;
        }
    }
}
