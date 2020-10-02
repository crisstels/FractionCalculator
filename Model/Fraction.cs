/* Autor: Natalie Hasselmann
*  Klasse: IA219
*  Dateiname: Fraction.cs
*  Datum: 16.09.2020
+  Beschreibung: Bildet einen math. Bruch ab
*  Aenderungen: 24.09.2020 kuerzen-Methode wurde hinzugefügt & Anpassung der Klasse an den Style-Guide
*               02.10.2020 Methoden wurden umbenannt
*/
using System;

namespace FractionCalculator
{
    class Fraction
    {
    #region Eigenschaften/Properties
     private int counter;
     private int denominator;
    #endregion

    # region Acessors/Modifiers
    public int Counter { get => counter; set => counter = value; }
    public int Denominator { get => denominator; set => denominator = value; }
    # endregion

    # region Constructor
     public Fraction()
     {
         this.Denominator = 1;
         this.Counter = 0;
     }

     public Fraction(int counter, int denominator)
     {
         this.Denominator = denominator;
         this.Counter = counter;
     }
     # endregion

     # region Worker
     /* Methods for calculating.*/
     public Fraction Add(Fraction fraction)
     {
         Fraction result = new Fraction();
         result.Counter = this.Counter * fraction.Denominator + this.Denominator * fraction.Counter;
         result.Denominator = this.Denominator * fraction.Denominator;
         return result.Reduced();
     }

     public Fraction Minus(Fraction fraction)
     {
         Fraction result = new Fraction();
         result.Counter = this.Counter * fraction.Denominator - this.Denominator * fraction.Counter;
         result.Denominator = this.Denominator * fraction.Denominator;
         return result.Reduced();
     }

     public Fraction Multiply(Fraction fraction)
     {
         Fraction result = new Fraction();
         result.Counter= this.Counter * fraction.Counter;
         result.Denominator = this.Denominator * fraction.Denominator;
         return result.Reduced();
     }

     public Fraction Divide(Fraction fraction)
     {
         Fraction result = new Fraction();
         result.Counter = this.Counter * fraction.Denominator;
         result.Denominator = this.Denominator * fraction.Counter;
         return result.Reduced();
     }
    /* Allocates result */
     public Fraction Allocate(Fraction fraction)
     {
         Fraction result = new Fraction();
         this.Counter = result.Counter = fraction.Counter;
         this.Denominator = result.Denominator = fraction.Denominator;
         result = result.Reduced();
         return result.Reduced();
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
     private Fraction Reduced()
     { 
         Fraction result = new Fraction();
         int gfc = Euklid(Counter, Denominator);
         result.Counter = Counter / gfc;
         result.Denominator = Denominator / gfc;

         return result;
     }
     # endregion
    }
}
