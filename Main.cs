/* Autor: Natalie Hasselmann
*  Klasse: IA219
*  Dateiname: Main.cs
*  Datum: 16.09.2020
+  Beschreibung: Hauptprogramm
*  Aenderungen: 24.09.2020 Aufruf der kuerzen-Methode, sowie Anpassung an den Style-Guide
*/
using System;

namespace FractionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            # region Central Data
            Fraction result = new Fraction();
            Fraction fraction1 = new Fraction(3,4);
            Fraction fraction2 = new Fraction(1,2);
            # endregion

            # region Call Methods
            result.Allocation(fraction1.Addition(fraction2));
            result.shorten(result);
            # endregion
            
            Console.ReadKey(true);
        }
    }
}