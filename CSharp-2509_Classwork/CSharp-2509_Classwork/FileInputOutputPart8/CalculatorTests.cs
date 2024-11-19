using FileInputOutputPart8;
using NUnit.Framework;
using System;

namespace FileInputOutputPart8
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
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Divide_WithValidInputs_ReturnsCorrectQuotient()
        {
            int result = _calculator.Divide(6, 2);
            object value = Assert.AreEqual(3, result);
        }

        [Test]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(6, 0));
        }
    }
}