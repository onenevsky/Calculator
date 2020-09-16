using System;

namespace TestTask
{
    public class Calculator 
    {
        public static double Calculate(int numberOne, int numberTwo, Operator mathOperator)
        {
            switch (mathOperator)
            {
                case Operator.Plus:
                {
                    return numberOne + numberTwo;
                }
                case Operator.Minus:
                {
                    return numberOne - numberTwo;
                }
                case Operator.Multiply:
                {
                    return numberOne * numberTwo;
                }
                case Operator.Divide:
                {
                    if (numberTwo == 0)
                    {
                        return Double.PositiveInfinity;
                    }

                    return (double)numberOne / numberTwo;
                }
            }
            
            return Double.NaN;
        }

        public static double ChangeSign(int number)
        {
            return -1 * number;
        }
    }
}