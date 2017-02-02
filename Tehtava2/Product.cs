/*
 *  Ostettavalta tuotteelta riittää käsitellä nimi ja hinta. Toteuta Product-luokka
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Product
    {
        public string Nimi { get; set; }
        public double Hinta { get; set; }

        public Product()
        { }

        public Product(string nimi, double hinta)
        {
            Nimi = nimi;
            Hinta = hinta;
        }
        public override string ToString()
        {
            return "-Tuote : " + Nimi + " " + Hinta + " e";
        }
    }
}
