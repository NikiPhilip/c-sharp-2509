

using NUnit.Framework;
using System;
using NUnit.Framework.Legacy;
using FileInputOutputPart8;


namespace DebuggingAndTesting
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WithValidInputs_ReturnsCorrectSum()
        {
            int result = _calculator.Add(3, 2);
            ClassicAssert.AreEqual(5, result);
        }

        [Test]
        public void Divide_WithValidInputs_ReturnsCorrectQuotient()
        {
            int result = _calculator.Divide(6, 2);
            ClassicAssert.AreEqual(3, result);
        }

        [Test]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            ClassicAssert.Throws<DivideByZeroException>(() => _calculator.Divide(6, 0));
        }
    }
}