using System;

namespace TestTask
{
     public class Program
    {
        private const int InitialNonValidNumber = -1;
        public static void Main()
        {
            Console.WriteLine("Welcome to Calculator");

            int firstNumber = GetNumber("first");
            int secondNumber = GetNumber("second");

            string enteredOperator = "";
            Operator convertedOperator = Operator.InvalidOperator;

            while (!IsOperatorValid(convertedOperator))
            {
                Console.Write("Select an operator (+, -, /, *): ");
                enteredOperator = Console.ReadLine();
                convertedOperator = ConvertToOperator(enteredOperator);
            }
           
           var result = Calculator.Calculate(firstNumber, secondNumber, convertedOperator);

           Console.WriteLine("Result: {0} {1} {2} = {3}", firstNumber, enteredOperator, secondNumber, result);
            Console.ReadLine();
        }

        public static int GetNumber(string orderedNumber)
        {
            int number = InitialNonValidNumber;

            while (!IsNumberValid(number))
            {
                Console.Write("Enter the {0} number (zero, one, two, ..., nine): ", orderedNumber);
                number = ConvertToNumber(Console.ReadLine());
            }

            return number;
        }

        public static bool IsNumberValid(int number)
        {
            if (number == InitialNonValidNumber)
            {
                return false;
            }

            return true;
        }

        public static bool IsOperatorValid(Operator someOperator)
        {
            return someOperator != Operator.InvalidOperator;
        }

        public static Operator ConvertToOperator(string input)
        {
            switch (input)
            {
                case "+":
                    {
                        return Operator.Plus;
                    }
                case "-":
                    {
                        return Operator.Minus;
                    }
                case "*":
                    {
                        return Operator.Multiply;
                    }
                case "/":
                    {
                        return Operator.Divide;
                    }
                default:
                    {
                        return Operator.InvalidOperator;
                    }
            }
        }

        public static int ConvertToNumber(string stringNumber)
        {
            switch (stringNumber.ToLowerInvariant())
            {
                case "zero":
                    {
                        return 0;
                    }
                case "one":
                    {
                        return 1;
                    }
                case "two":
                    {
                        return 2;
                    }
                case "three":
                    {
                        return 3;
                    }
                case "four":
                    {
                        return 4;
                    }
                case "five":
                    {
                        return 5;
                    }
                case "six":
                    {
                        return 6;
                    }
                case "seven":
                    {
                        return 7;
                    }
                case "eight":
                    {
                        return 8;
                    }
                case "nine":
                    {
                        return 9;
                    }
                default:
                    {
                        return -1;
                    }
            }
        }

    }
}
