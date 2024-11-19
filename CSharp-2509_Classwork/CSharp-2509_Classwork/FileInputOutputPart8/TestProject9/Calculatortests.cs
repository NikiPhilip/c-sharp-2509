using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace TestProject9
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
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(6, 0));
        }
    }

}
