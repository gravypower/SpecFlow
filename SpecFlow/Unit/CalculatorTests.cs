using NSubstitute;
using NUnit.Framework;

namespace Tests.Unit
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator.Calculator _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = Substitute.For<Calculator.Calculator>();
        }

        [Test]
        public void AddingNoNumbersNoNumbersExceptionThrown()
        {
            Assert.That(_sut.Add, Throws.InstanceOf<Calculator.Calculator.NoNumbersException>());
        }
    }
}
