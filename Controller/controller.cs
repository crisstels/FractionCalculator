//  Autor: Natalie Hasselmann
//  Klasse: IA219
//  Dateiname: UserInterface.cs
//  Datum: 01.10.2020
//  Beschreibung: Steuert den Bruchrechner
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
            fraction = new Fraction();
            fraction2 = new Fraction();
            result = new Fraction();
            userInterface = new UserInterface();
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
        public Fraction MultiplyFractions()
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

        public void run()
        {
            UserInterface userInterface = new UserInterface();
            userInterface.Splash();
            while(true)
            {
                int op = userInterface.Menu();
                if(op == 5)
                {
                    break;
                }
                switch(op)
                {
                    case 1:
                    result = AddFractions();
                    break;

                    case 2:
                    result = SubtractFractions();
                    break;

                    case 3:
                    result = MultiplyFractions();
                    break;

                    case 4:
                    result = DivideFractions();
                    break;

                    default:
                    Console.WriteLine("Wrong operation");
                    break;
                }
                result = result.shorten(result);

                userInterface.printFraction(result);
            }

        }
        #endregion
    }
}