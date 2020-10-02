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
            Controller controller = new Controller();
            controller.Run();
            
        }
    }
}