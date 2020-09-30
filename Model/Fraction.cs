/* Autor: Natalie Hasselmann
*  Klasse: IA219
*  Dateiname: Fraction.cs
*  Datum: 16.09.2020
+  Beschreibung: Bildet einen math. Bruch ab
*  Aenderungen: 24.09.2020 kuerzen-Methode wurde hinzugefügt & Anpassung der Klasse an den Style-Guide
*/
using System;

namespace FractionCalculator
{
    class Fraction
    {
    #region Eigenschaften/Properties
     private int _counter;
     private int _denominator;
    #endregion

    # region Acessors/Modifiers
    private int Counter { get => _counter; set => _counter = value; }
    private int Denominator { get => _denominator; set => _denominator = value; }
    # endregion

    # region Constructor
     public Fraction()
     {
         this.Denominator = 1;
         this.Counter = 1;
     }

     public Fraction(int counter, int denominator)
     {
         this.Denominator = denominator;
         this.Counter = counter;
     }
     # endregion

     # region Worker
     /* Methods for calculating.*/
     public Fraction Addition(Fraction fraction)
     {
         Fraction result = new Fraction();
         result.Counter = this.Counter * fraction.Denominator+ this.Denominator *fraction.Counter;
         result.Denominator = this.Denominator * fraction.Denominator;
         return result;
     }

     public Fraction Subtraction(Fraction fraction)
     {
         Fraction result = new Fraction();
         result.Counter = this.Counter * fraction.Denominator - this.Denominator * fraction.Counter;
         result.Denominator = this.Denominator * fraction.Denominator;
         return result;
     }

     public Fraction Multiplication(Fraction fraction)
     {
         Fraction result = new Fraction();
         result.Counter= this.Counter * fraction.Counter;
         result.Denominator = this.Denominator * fraction.Denominator;
         return result;
     }

     public Fraction Division(Fraction fraction)
     {
         Fraction result = new Fraction();
         result.Counter = this.Counter * fraction.Denominator;
         result.Denominator = this.Denominator * fraction.Counter;
         return result;
     }
    /* Allocates result */
     public Fraction Allocation(Fraction fraction)
     {
         Fraction result = new Fraction();
         this.Counter = result.Counter = fraction.Counter;
         this.Denominator = result.Denominator = fraction.Denominator;
         Console.WriteLine(result.Counter);
         Console.WriteLine(result.Denominator);
         return result;
     }
     /* Detects the greatest common factor */
     private int Euklid(int counter, int denominator)
     {
        if (Counter == 0)
        {
            return denominator;
        }
        else
        {
            while (denominator != 0)
            {
                if (counter > denominator)
                {
                    counter -= denominator;
                }
                else
                {
                    denominator -= counter;
                }
            }
        }
            return counter;
     }
    /* Shortens a fraction. */
     public Fraction shorten(Fraction fraction)
     { 
         Fraction result = new Fraction();
         int gfc = Euklid(fraction.Counter, fraction.Denominator);
         result.Counter = fraction.Counter / gfc;
         result.Denominator = fraction.Denominator / gfc;

         Console.WriteLine(result.Counter);
         Console.WriteLine(result.Denominator);

         return result;

     }
     # endregion
    }
}
