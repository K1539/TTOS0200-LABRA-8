/*
 * kalastajan perustiedot(nimi, puhelinnumero)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class KalastajanTiedot
    {
        public string Nimi { get; set; }
        public string PuhNumero { get; set; }

        public KalastajanTiedot() { }
        public KalastajanTiedot(string nimi, string puhnumero)
        {
            Nimi = nimi;
            PuhNumero = puhnumero;
        }
        public override string ToString()
        {
            return "Uusi kalastaja lisätty kalastajarekisteriin: \n-Kalastaja: " + Nimi + " Puhelinnumero: " + PuhNumero + "\n";
        }
    }
}
