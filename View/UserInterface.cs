// Autor: Natalie Hasselmann
//  Klasse: IA219
//  Dateiname: UserInterface.cs
//  Datum: 30.09.2020
//  Beschreibung: Schnittstelle zwischen User und Programm
//  Aenderungen:
using System;

namespace FractionCalculator
{
    class UserInterface {

        #region Eigenschaften/Properties
        private Fraction fraction = new Fraction();
        #endregion

        #region Methods
        // User sets one fraction
        public Fraction getFraction()
        {
            Console.WriteLine("Please enter a counter: ");
            int counter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a denominator: ");
            int denominator = Convert.ToInt32(Console.ReadLine());
            Fraction fraction = new Fraction(counter, denominator);

            return fraction;

        }
        // Prints a fraction
        public void printFraction(Fraction fraction)
        {
            Console.WriteLine(fraction.Counter + "/" + fraction.Denominator);
        }
        // Prints the Menu for choosing one operation
        public int Menu()
        {
            Console.WriteLine("Please choose an operation");
            Console.WriteLine("1 for Addittion (+)");
            Console.WriteLine("2 for Subtraction (-)");
            Console.WriteLine("3 for Multiplication (*)");
            Console.WriteLine("4 for Division (/)");
            Console.WriteLine("5 to exit the programm" + "\n");
            int op = Convert.ToInt32(Console.ReadLine());

            return op;
        }
        // Prints Splash-Screen 
        public void Splash()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" + "\n");
            Console.WriteLine("Titel: Bruchrechner");
            Console.WriteLine("Beschreibung: Einfacher objektorientierter Bruchrechner, welcher 2 Brüche miteinander verrechnet und das Ergebnis kürzt.");
            Console.WriteLine("Autor: Natalie Hasselmann  ʕ•ᴥ•ʔ");
            Console.WriteLine("\n" + "Drücken Sie eine beliebige Taste zum fortfahren" + "\n");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" + "\n");
            Console.ReadKey(true);
        }
        #endregion
    }
}