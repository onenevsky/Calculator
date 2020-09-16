using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace TestTask
{
    [TestFixture]
    public class CalculatorTests
    {

        [Test]

        public void AddNumbersTest()
        {             
            double expectedResult = Calculator.Calculate(7, 4, Operator.Plus);
            Assert.That(expectedResult, Is.EqualTo(11));
        }

        [Test]

        public void SubtractNumbersTest()

        {
            double expectedResult = Calculator.Calculate(9, 9, Operator.Minus);
            Assert.That(expectedResult, Is.EqualTo(0));
        }

        [Test]

        public void DivideNumbersTest()

        {
            double expectedResult = Calculator.Calculate(6, 2, Operator.Divide);
            Assert.That(expectedResult, Is.EqualTo(3));
        }

        [Test]

        public void MultiplyNumbersTest()
        {
            double expectedResult = Calculator.Calculate(5, 5, Operator.Multiply);
            Assert.That(expectedResult, Is.EqualTo(25));

        }

        [Test]

        public void ValidNumberTest()

        {
            Boolean expectedResult = Program.IsNumberValid(9);
            Assert.That(expectedResult, Is.True);
        }

        [Test]

        public void ValidOperatorTest()
        {
            
            Boolean expectedResult = Program.IsOperatorValid(Operator.Multiply);
            Assert.That(expectedResult, Is.True);
        }

        [Test]

        public void ConvertOperatorPlusTest()
        {
            Operator expectedResult = Program.ConvertToOperator("+");
            Assert.That(expectedResult, Is.EqualTo(Operator.Plus));
        }

        [Test]

        public void ConvertOperatorMinusTest()
        {
            Operator expectedResult = Program.ConvertToOperator("-");
            Assert.That(expectedResult, Is.EqualTo(Operator.Minus));
        }

        [Test]

        public void ConvertOperatorDivideTest()
        {
         Operator expectedResult = Program.ConvertToOperator("/");
            Assert.That(expectedResult, Is.EqualTo(Operator.Divide));
        }

        [Test]

        public void ConvertOperatorMultiplyTest()
        {
            Operator expectedResult = Program.ConvertToOperator("*");
            Assert.That(expectedResult, Is.EqualTo(Operator.Multiply));
        }

        [Test]

        public void ConvertOperatorInvalidTest()
        {
            Operator expectedResult = Program.ConvertToOperator("");
            Assert.That(expectedResult, Is.EqualTo(Operator.InvalidOperator));
        }

        [Test]

        public void ConvertNumberTest()
        { 
            int expectedResult = Program.ConvertToNumber("one");
            Assert.That(expectedResult, Is.EqualTo(1));
        }

        [Test]

        public void ConvertDefaultNumberTest()
        {
            int expectedResult = Program.ConvertToNumber("");
            Assert.That(expectedResult, Is.EqualTo(-1));
        }

        [Test]

        public void ChangeSignTest()
        {
            double expectedResult = Calculator.ChangeSign(7);
            Assert.That(expectedResult, Is.EqualTo(-7));
        }
    }
}
