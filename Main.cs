using System;

namespace FractionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction result = new Fraction();
            Fraction fraction1 = new Fraction(3,4);
            Fraction fraction2 = new Fraction(1,2);

            result.Allocation(fraction1.Addition(fraction2));
            result.shorten(result);
            
            Console.ReadKey(true);
        }
    }
}