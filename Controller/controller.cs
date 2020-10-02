//  Autor: Natalie Hasselmann
//  Klasse: IA219
//  Dateiname: UserInterface.cs
//  Datum: 01.10.2020
//  Beschreibung: Steuert den Bruchrechner
//  Aenderungen: Run-Methode wurde verbessert, das Kürzen von Brüchen wurde hinzugefügt
using System;

namespace FractionCalculator
{
    class Controller
    {
        #region Eigenschaften/Properties
        private UserInterface userInterface = new UserInterface();
        private Fraction fraction;
        private Fraction fraction2;
        private Fraction result = new Fraction();
        #endregion

        #region Worker
        public Fraction AddFractions()
        {
            fraction = userInterface.getFraction();
            fraction2 = userInterface.getFraction();
            result.Allocate(fraction.Add(fraction2));

            return result;
        }
        public Fraction SubtractFractions()
        {
            fraction = userInterface.getFraction();
            fraction2 = userInterface.getFraction();
            result.Allocate(fraction.Minus(fraction2));

            return result;
        }
        public Fraction MultiplyFractions()
        {
            fraction = userInterface.getFraction();
            fraction2 = userInterface.getFraction();
            result.Allocate(fraction.Multiply(fraction2));

            return result;
        }
        public Fraction DivideFractions()
        {
            fraction = userInterface.getFraction();
            fraction2 = userInterface.getFraction();
            result.Allocate(fraction.Divide(fraction2));

            return result;
        }

        public void Run()
        {
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

                userInterface.printFraction(result);
                Console.ReadKey(true);
            }

        }
        #endregion
    }
}