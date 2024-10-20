using NUnit.Framework;

namespace CalcAPI_NunitTesting
{
    [TestFixture]
    public class CalcTest
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenCalled_ReturnsCorrectSum()
        {
            Assert.AreEqual(100, _calculator.Add(60, 40));
        }

        [Test]
        public void Sub_WhenCalled_ReturnsCorrectDifference()
        {
            Assert.AreEqual(50, _calculator.Sub(90, 40));
        }

        [Test]
        public void Mul_WhenCalled_ReturnsCorrectProduct()
        {
            Assert.AreEqual(180, _calculator.Mul(60, 3));
        }

        [Test]
        public void Div_WhenCalledWithNonZero_ReturnsCorrectQuotient()
        {
            Assert.AreEqual(3, _calculator.Div(9, 3));
        }

        [Test]
        public void IsEven_WhenCalledWithEvenNumber_ReturnsTrue()
        {
            Assert.IsTrue(_calculator.IsEven(4));
        }

        [Test]
        public void IsEven_WhenCalledWithOddNumber_ReturnsFalse()
        {
            Assert.IsFalse(_calculator.IsEven(5));
        }
    }
}
