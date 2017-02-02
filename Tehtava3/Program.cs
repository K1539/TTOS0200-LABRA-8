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
            KalanTiedot kalantiedot1 = new KalanTiedot("Lohi", 50, 4.0);
            KalapaikanTiedot kalapaikantiedot1 = new KalapaikanTiedot("Jyväsjärvi", "Jyväskylä");
            KalastajanTiedot kalastajantiedot1 = new KalastajanTiedot("Kirsi Kernel", "040 1234567");


        }
    }
}
