using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.U16.HW.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(30, 40) == 70);
            Assert.That(calculator.Additional(-50, 20) == -30);
        }

        [Test]
        public void SubstractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(12, 7) == 5);
        }

        [Test]
        public void MiltiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Miltiplication(5, 9) == 45);
        }

        [Test]
        public void DivisionShouldWorkCorrect()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(81, 9) == 9);
            Assert.Throws<DivideByZeroException>(() => calculator.Division(1, 0));
        }

        

    }
}
