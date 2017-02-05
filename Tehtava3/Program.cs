/*
Toteuta sovellus, jossa voit hallita kalastukseen liittyviä tietoja.
Pohdi tarvittava luokkarakenne UML-kaaviona.Toteuta pääohjelmassa kalastaja ja muutamia kaloja.Tulosta lopuksi kalarekisterin sisältö.

Esimerkkitulostus:



A new fisherman added to register:
     - Fisherman: Kirsi Kernel Phone: 020-12345678

    Fisher : Kirsi Kernel got a new fish
     - specie : pike 120 cm 4,5 kg
     - place: The Lake of Jyväskylä
     - location: Jyväskylä

    Fisher : Kirsi Kernel got a new fish
     - specie: salmon 190 cm 13,2 kg
     - place: River Teno
     - location: The Northern edge of Finland

    All fishes in register:

    Fisherman Kirsi Kernel has got following fishes:

     - specie: pike 120 cm 4,5 kg
     - place: The Lake of Jyväskylä
     - location: Jyväskylä

     - specie: salmon 190 cm 13,2 kg
     - place: River Teno
     - location: The Northern edge of Finland

    Press enter key to continue...   
    
+tehtävä: tulosta kalarekisteri siten, että kalat ovat suuruusjärjestykessä(painavin ensin).


    Sorted register

    All fishes in register:

    Fisherman Kirsi Kernel has got following fishes:

     - specie: salmon 190 cm 13,2 kg
     - place: River Teno
     - location: The Northern edge of Finland

     - specie: pike 120 cm 4,5 kg
     - place: The Lake of Jyväskylä
     - location: Jyväskylä

    Press enter key to continue...   
    *
    *Jere Liikka 2.2.2017
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
            KalastajanTiedot kalastajantiedot1 = new KalastajanTiedot("Kirsi Kernel", "040 1234567");
            List<KalastajanTiedot> kalastajalista = new List<KalastajanTiedot>();
            kalastajalista.Add(kalastajantiedot1);
            foreach (var item in kalastajalista)
            {
                Console.WriteLine(item.ToString());
            }
            //print fish info
            KalanTiedot kalantiedot1 = new KalanTiedot("Lohi", 50, 4.0, "Jyväsjärvi", "Jyväskylä");
            KalanTiedot kalantiedot2 = new KalanTiedot("Taimen", 45, 4.0, "Pyhäjärvi", "Kouvola");
            List<KalanTiedot> kalantiedot = new List<KalanTiedot>();
            kalantiedot.Add(kalantiedot1);
            kalantiedot.Add(kalantiedot2);
            foreach (var item in kalantiedot)
            {
                Console.WriteLine("Kalastaja : {0} sai uuden kalan", kalastajantiedot1.Nimi);
                Console.WriteLine(item.ToString());
            }
            //All fishes in register
            Console.WriteLine("Kalastajalla {0} on seuraavat kalat :\n", kalastajantiedot1.Nimi);
            foreach (var item in kalantiedot)
            {
                Console.WriteLine(item.ToString() + "\n");
            }
        }
    }
}
