//  Dateiname: UserInterface.cs
//  Datum: 30.09.2020
//  Beschreibung: Schnittstelle zwischen User und Programm
//  Aenderungen:
using System;

namespace FractionCalculator
{
    class Controller
    {
        #region Eigenschaften/Prpoerties
        private UserInterface userInterface;
        private Fraction fraction;
        private Fraction fraction2;
        private Fraction result;
        #endregion

        #region Worker
        public Fraction AddFractions()
        {
            fraction = userInterface.getFraction();
            fraction2 = userInterface.getFraction();
            result = result.Allocation(fraction.Addition(fraction2));

            return result;
        }
        public Fraction SubtractFractions()
        {
            fraction = userInterface.getFraction();
            fraction2 = userInterface.getFraction();
            result = result.Allocation(fraction.Subtraction(fraction2));

            return result;
        }
        public Fraction MultipleFractions()
        {
            fraction = userInterface.getFraction();
            fraction2 = userInterface.getFraction();
            result = result.Allocation(fraction.Multiplication(fraction2));

            return result;
        }
        public Fraction DivideFractions()
        {
            fraction = userInterface.getFraction();
            fraction2 = userInterface.getFraction();
            result = result.Allocation(fraction.Division(fraction2));

            return result;
        }
        #endregion
    }
}