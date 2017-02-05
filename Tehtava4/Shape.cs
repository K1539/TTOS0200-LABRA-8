/*
 * Laadi erillinen abstrakti Shape-luokka, josta muut kuviot peryityvät. 
 * Määrittele Shape-luokan ominaisuutena kuvion nimi (Name) ja abstraktit Area- ja Circumference-metodit (pinta-ala ja ympärysmitta). 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    abstract class Shape
    {
        public string Name { get; set; }
        public abstract double Area();
        public abstract double Circumference();
    }
}
