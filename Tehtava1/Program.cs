﻿/*Toteuta Noppa-luokka siten, että noppaa voidaan heittää.
 * Nopan tulee palauttaa satunnainen luku jokaisella heittokerralla.
 * Toteuta pääohjelmassa nopan heittäminen.
 * Kokeile ensin heittää noppaa kerran ja tulosta nopan luku. 
 * Toteuta tämän jälkeen ohjelma siten, että kysyt käyttäjältä heittojen määrän.
 * Heitä noppaa ja tulosta heittojen lukujen keskiarvo.

 * Esimerkkitulostus:
 * Dice, one test throw value is 4
 * How many times you want to throw a dice :  10000

 * Dice is now thrown 10000 times, average is 3,4853
 *
 * Jere Liikka 1.2.2017
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
            Noppa noppa = new Noppa();
            Console.WriteLine(noppa.NoppaLuku);
            Console.WriteLine(noppa.NoppaLuku);
            Console.WriteLine(noppa.NoppaLuku);



        }
    }
}