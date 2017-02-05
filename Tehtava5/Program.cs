/*
 * Tehtävä 5 - Laskutoimituksia ja yksikkötestaus home Kotitehtävä
Toteuta ArrayCalcs-niminen luokka ja sen sisälle seuraavat staattiset-metodit: Sum, Average, Min ja Max. 
Metodit ottavat parametriksi double[]-taulukon ja laskevat nimensä mukaisen laskutoimintuksen taulukon alkioille ja palauttavat tuloksen kutsuvalle ohjelmalle.

Toteuta pääohjelma ja esimerkiksi seuraavaa dataa sisältävä taulukko: 
double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 }; 
Kutsu pääohjelmasta ArrayCalcs-luokan staattisia laskutoimituksia tekeviä metodeja annetun taulukon arvoilla ja tulosta tulokset näyttölaitteelle.

Esimerkkitulostus:


    Sum = 25,60
    Ave = 3,66
    Min = -4,50
    Max = 12,00

    Press enter key to continue...    
 * 
 * Jere Liikka 5.2.2017
 */
    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Ohjelma();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        static void Ohjelma()
        {

            try
            {
                double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
                Console.WriteLine("Sum = {0:00.00}", ArrayCalcs.Sum(array));
                Console.WriteLine("Avg = {0:00.00}", ArrayCalcs.Average(array));
                Console.WriteLine("Min = {0:0.00}", ArrayCalcs.Min(array));
                Console.WriteLine("Max = {0:00.00}", ArrayCalcs.Max(array));
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
