/*
 * Toteuta sovellus, jolla voit hallita ostoskärryn sisältöä. Ostettavalta tuotteelta riittää käsitellä nimi ja hinta. 
 * Toteuta Product-luokka ja lisää pääohjelmassa esimerkiksi List-tietorakenteeseen muutamia Product-luokan oliota. 
 * Tulosta lopuksi kokoelman sisältö.

Esimerkkitulostus:


    All products in collection:
    - product : Milk 1,4 e
    - product : Beer 2,2 e
    - product : Butter 3,2 e
    - product : Cheese 4,2 e
    
    Press enter key to continue...
    *
    * Jere Liikka 2.2.2017
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Maito = new Product("Maito", 1.4);
            Product Olut = new Product("Olut", 2.2);
            Product Voi = new Product("Voi", 3.2);
            Product Juusto = new Product("Juusto", 4.2);

            List<Product> Ostoskarry = new List<Product>();
            Ostoskarry.Add(Maito);
            Ostoskarry.Add(Olut);
            Ostoskarry.Add(Voi);
            Ostoskarry.Add(Juusto);

            foreach (var key in Ostoskarry)
            {
                Console.WriteLine(key.ToString());
            }


        }
    }
}
