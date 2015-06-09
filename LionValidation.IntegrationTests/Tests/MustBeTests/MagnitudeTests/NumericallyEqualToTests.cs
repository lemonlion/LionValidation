using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class NumericallyEqualToTests : TestsBase
    {
        [TestMethod]
        public void NumericallyEqualToTest1()
        {
            FirstField.SendKeys("5");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void NumericallyEqualToTest2()
        {
            FirstField.SendKeys(" 5");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void NumericallyEqualToTest3()
        {
            FirstField.SendKeys("0");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void NumericallyEqualToTest4()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class NumericallyEqualToTests_NoJS : NumericallyEqualToTests
    {}
}