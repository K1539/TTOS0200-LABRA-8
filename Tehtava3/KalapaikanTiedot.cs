/*
 * saadun kalapaikan perustiedot(nimi ja paikka).
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class KalapaikanTiedot
    {
        public string Paikannimi { get; set; }
        public string Sijainti { get; set; }

        public KalapaikanTiedot() { }
        public KalapaikanTiedot(string paikannimi, string sijainti)
        {
            Paikannimi = paikannimi;
            Sijainti = sijainti;
        }
        public override string ToString()
        {
            return "-Paikka: " + Paikannimi + "\n" + "-Sijainti: " + Sijainti;
        }
    }
}
