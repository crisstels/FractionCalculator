using System;

namespace FractionCalculator
{
    class Fraction
    {
     private int Denominator { get; set; }
     private int Counter { get; set; }

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
     public int Euklid(int counter, int denominator)
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
                    counter -= denominator;
                }
            }
        }
            return counter;
     }
    /* Shortens a fraction. TODO: implement this */
     public Fraction shorten(){}
    }
}
