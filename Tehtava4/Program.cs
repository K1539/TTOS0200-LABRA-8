/*
 * Tehtävä 4 - Kuviot Kotitehtävä
Toteuta sovellus, jolla voidaan käsitellä erilaisia kuviota (esim. Circle ja Rectangle). 
Laadi erillinen abstrakti Shape-luokka, josta muut kuviot peryityvät. 
Määrittele Shape-luokan ominaisuutena kuvion nimi (Name) ja abstraktit Area- ja Circumference-metodit (pinta-ala ja ympärysmitta). 
Peri Circle- ja Rectangle-luokat Shape-luokasta ja toteuta Area- ja Circumference-metodit. 
Luo Shapes-luokka ja sen sisälle List-tietorakenne, jonne voit aina lisätä kuvioita. 
Toteuta pääohjelma, jossa käytät Shapes-luokkaa, luo muutamia eri kuviota ja lisää ne Shapes-luokassa olevaan List-tietorakenteeseen. 
Käy pääohjelmassa lopuksi läpi Shapes-luokan List-tietorakenne ja tulosta kaikki sen sisältämät kuviot.

Esimerkkitulostus:


    Circle Radius=1 Area=3,14 Circumference=7,28
    Circle Radius=2 Area=12,57 Circumference=12,56
    Circle Radius=3 Area=28,27 Circumference=18,84
    Rectangle Width=10 Height=20 Area=200,00 Circumference=60,00
    Rectangle Width=20 Height=30 Area=600,00 Circumference=100,00
    Rectangle Width=40 Height=50 Area=2000,00 Circumference=180,00

    Press enter key to continue...
 * 
 * Jere Liikka 5.2.2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    abstract class Program : Shapes
    {
        static void Main(string[] args)
        {
            Shapes shapes = new Shapes();
            shapes.AddShape(new Circle(1));
            shapes.AddShape(new Circle(2));
            shapes.AddShape(new Circle(3));
            shapes.AddShape(new Rectangle(10, 20));
            shapes.AddShape(new Rectangle(20, 30));
            shapes.AddShape(new Rectangle(40, 50));

            foreach (var item in shapes.list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
