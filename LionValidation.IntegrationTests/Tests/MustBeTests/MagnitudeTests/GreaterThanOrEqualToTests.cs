using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class GreaterThanOrEqualToTests : TestsBase
    {
        [TestMethod]
        public void GreaterThanOrEqualToTest1()
        {
            FirstField.SendKeys("6");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void GreaterThanOrEqualToTest2()
        {
            FirstField.SendKeys("5");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void GreaterThanOrEqualToTest3()
        {
            FirstField.SendKeys("4");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void GreaterThanOrEqualToTest4()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class GreaterThanOrEqualToTests_NoJS : GreaterThanOrEqualToTests
    {}
}