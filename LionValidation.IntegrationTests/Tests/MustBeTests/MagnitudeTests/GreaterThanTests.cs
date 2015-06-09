using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class GreaterThanTests : TestsBase
    {
        [TestMethod]
        public void GreaterThanTest1()
        {
            FirstField.SendKeys("6");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void GreaterThanTest2()
        {
            FirstField.SendKeys("5");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void GreaterThanTest3()
        {
            FirstField.SendKeys("4");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void GreaterThanTest4()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class GreaterThanTests_NoJS : GreaterThanTests
    {}
}