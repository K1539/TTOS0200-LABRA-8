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
    class KalapaikanTiedot : KalastajanTiedot
    {
        public string Paikannimi { get; set; }
        public string Sijainti { get; set; }
    }
}
